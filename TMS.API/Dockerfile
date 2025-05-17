# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.sln ./
COPY TMS.Domain/TMS.Domain.csproj ./TMS.Domain/
COPY TMS.Application/TMS.Application.csproj ./TMS.Application/
COPY TMS.Infrastructure/TMS.Infrastructure.csproj ./TMS.Infrastructure/
COPY TMS.API/TMS.API.csproj ./TMS.API/
RUN dotnet restore

# Copy everything and build the project
COPY . ./
WORKDIR /app/TMS.API
RUN dotnet publish -c Release -o out

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/TMS.API/out ./

# Environment variable for production (optional)
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

ENTRYPOINT ["dotnet", "TMS.API.dll"]
