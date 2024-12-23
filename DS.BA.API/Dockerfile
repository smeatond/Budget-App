FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release

# Install platform linker and other required dependencies
RUN apt-get update && apt-get install -y clang gcc libc6-dev

WORKDIR /src
COPY ["DS.BA.API/DS.BA.API.csproj", "DS.BA.API/"]
#copy for migration
COPY ["DS.BA.Common.DbContext/DS.BA.Common.DbContext.csproj", "DS.BA.Common.DbContext/"]
RUN dotnet restore "DS.BA.API/DS.BA.API.csproj"
COPY . .
WORKDIR "/src/DS.BA.API"
RUN ls "../"
RUN dotnet build "DS.BA.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "DS.BA.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=true /p:PublishAot=true

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["./DS.BA.API"]