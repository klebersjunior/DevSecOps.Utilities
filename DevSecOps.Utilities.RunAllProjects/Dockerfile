#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DevSecOps.Utilities.RunAllProjects/DevSecOps.Utilities.RunAllProjects.csproj", "DevSecOps.Utilities.RunAllProjects/"]
RUN dotnet restore "DevSecOps.Utilities.RunAllProjects/DevSecOps.Utilities.RunAllProjects.csproj"
COPY . .
WORKDIR "/src/DevSecOps.Utilities.RunAllProjects"
RUN dotnet build "DevSecOps.Utilities.RunAllProjects.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DevSecOps.Utilities.RunAllProjects.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN curl -sSfL https://raw.githubusercontent.com/trufflesecurity/trufflehog/main/scripts/install.sh | sh -s -- -b /usr/local/bin
ENTRYPOINT ["dotnet", "DevSecOps.Utilities.RunAllProjects.dll"]
