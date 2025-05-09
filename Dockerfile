# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia solo el archivo .csproj y restaura las dependencias
COPY *.csproj .
RUN dotnet restore

# Copia el resto de los archivos y construye
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:4000
EXPOSE 4000

ENTRYPOINT ["dotnet", "LOGIN.dll"]
