FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Behavioral/Visitor/Visitor.csproj", "Visitor/"]
RUN dotnet restore "Behavioral/Visitor/Visitor.csproj"
COPY . .
WORKDIR "/src/Visitor"
RUN dotnet build "Visitor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Visitor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Visitor.dll"]
