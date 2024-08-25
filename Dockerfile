FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 90
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /src
COPY ["./HubEnterntainmentApi.csproj", "./"]
RUN dotnet restore "./HubEnterntainmentApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./HubEnterntainmentApi.csproj" -c Release -o /app/build