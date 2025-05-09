# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar archivos del proyecto y restaurar dependencias
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Etapa de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Exponer el puerto 4000
EXPOSE 4000

# Establecer variable de entorno para que ASP.NET escuche en el puerto 4000
ENV ASPNETCORE_URLS=http://+:4000

# Comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "LOGIN.dll"]

