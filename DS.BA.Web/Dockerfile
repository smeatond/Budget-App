# Use SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DS.BA.Web/DS.BA.Web.csproj", "DS.BA.Web/"]
RUN dotnet restore "DS.BA.Web/DS.BA.Web.csproj"
COPY . .
WORKDIR "/src/DS.BA.Web"
RUN dotnet publish "DS.BA.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Use Nginx to serve the static files
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=build /app/build/wwwroot .
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]