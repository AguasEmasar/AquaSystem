# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia el archivo .csproj y restaura las dependencias
COPY ["LOGIN.csproj", "."]
RUN dotnet restore "LOGIN.csproj"

# Copia el resto de los archivos y construye
COPY . .
RUN dotnet publish "LOGIN.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:4000
EXPOSE 4000

ENTRYPOINT ["dotnet", "LOGIN.dll"]
