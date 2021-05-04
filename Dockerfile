#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["GitHubApi.csproj", "."]
RUN dotnet restore "./GitHubApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "GitHubApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GitHubApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GitHubApi.dll"]

CMD  dotnet dev-certs https --clean; dotnet dev-certs https --trust
CMD ASPNETCORE_URLS="http://*:$PORT" dotnet GitHubApi.dll