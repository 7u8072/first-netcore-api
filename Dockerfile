FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /source

COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "./my-first-api-container.dll"]