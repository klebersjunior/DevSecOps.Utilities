#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DevSecOps.Utilities.WebApi/DevSecOps.Utilities.WebApi.csproj", "DevSecOps.Utilities.WebApi/"]
RUN dotnet restore "DevSecOps.Utilities.WebApi/DevSecOps.Utilities.WebApi.csproj"
COPY . .
WORKDIR "/src/DevSecOps.Utilities.WebApi"
RUN dotnet build "DevSecOps.Utilities.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DevSecOps.Utilities.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN mkdir repos
RUN apt -y update && apt upgrade
RUN apt -y install curl
RUN apt-get -y install git
RUN curl -sSfL https://raw.githubusercontent.com/trufflesecurity/trufflehog/main/scripts/install.sh | sh -s -- -b /usr/local/bin
RUN chown -R app:app /usr/local/bin
RUN apt-get update && apt-get install -y \
    software-properties-common \
    npm
RUN npm install npm@latest -g && \
    npm install n -g && \
    n latest

RUN npm install -g @cyclonedx/cdxgen

ENTRYPOINT ["dotnet", "DevSecOps.Utilities.WebApi.dll"]
