FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AdsAgency.Gateway/AdsAgency.Gateway.csproj", "AdsAgency.Gateway/"]
RUN dotnet restore "AdsAgency.Gateway/AdsAgency.Gateway.csproj"
COPY . .
WORKDIR "/src/AdsAgency.Gateway"
RUN dotnet build "AdsAgency.Gateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdsAgency.Gateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdsAgency.Gateway.dll"]
