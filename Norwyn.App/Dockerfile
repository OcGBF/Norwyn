FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY Norwyn.App.csproj ./

COPY ../Norwyn.Shared ../Norwyn.Shared

RUN dotnet restore Norwyn.App.csproj

COPY . ./

RUN dotnet build Norwyn.App.csproj -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
RUN dotnet publish Norwyn.App.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Norwyn.App.dll"]