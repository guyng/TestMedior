#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
RUN apt-get update -yq \
    && apt-get install curl gnupg -yq \
    && curl -sL https://deb.nodesource.com/setup_10.x | bash \
    && apt-get install nodejs -yq
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-bionic AS build
RUN apt-get update -yq \
    && apt-get install curl gnupg -yq \
    && curl -sL https://deb.nodesource.com/setup_10.x | bash \
    && apt-get install nodejs -yq
WORKDIR /src
COPY ["TestMedior/TestMedior.csproj", "TestMedior/"]
COPY ["Services/BL.csproj", "Services/"]
COPY ["DAL/DAL.csproj", "DAL/"]
RUN dotnet restore "TestMedior/TestMedior.csproj"
COPY . .
WORKDIR "/src/TestMedior"
RUN dotnet build "TestMedior.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestMedior.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestMedior.dll"]