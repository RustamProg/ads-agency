FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AdsAgency.Documents/AdsAgency.Documents.csproj", "AdsAgency.Documents/"]
RUN dotnet restore "AdsAgency.Documents/AdsAgency.Documents.csproj"
COPY . .
WORKDIR "/src/AdsAgency.Documents"
RUN dotnet build "AdsAgency.Documents.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdsAgency.Documents.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdsAgency.Documents.dll"]
