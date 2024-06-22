#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
RUN apt -y update && apt upgrade
RUN apt -y install curl
RUN curl -sSfL https://raw.githubusercontent.com/trufflesecurity/trufflehog/main/scripts/install.sh | sh -s -- -b /usr/local/bin
RUN apt -y install git
RUN chown -R app:app /usr/local/bin
#USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DevSecOps.Utilities.RunAllProjects/DevSecOps.Utilities.RunAllProjects.csproj", "DevSecOps.Utilities.RunAllProjects/"]
COPY ["DevSecOps.Utilities.Infra/DevSecOps.Utilities.Infra.csproj", "DevSecOps.Utilities.Infra/"]
RUN dotnet restore "./DevSecOps.Utilities.RunAllProjects/DevSecOps.Utilities.RunAllProjects.csproj"
COPY . .
WORKDIR "/src/DevSecOps.Utilities.RunAllProjects"
RUN dotnet build "./DevSecOps.Utilities.RunAllProjects.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DevSecOps.Utilities.RunAllProjects.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN mkdir repos
RUN apt -y update && apt upgrade
RUN apt -y install curl
RUN apt-get -y install git
RUN curl -sSfL https://raw.githubusercontent.com/trufflesecurity/trufflehog/main/scripts/install.sh | sh -s -- -b /usr/local/bin
RUN chown -R app:app /usr/local/bin
ENTRYPOINT ["dotnet", "DevSecOps.Utilities.RunAllProjects.dll"]