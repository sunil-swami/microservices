FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 7001

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["AccountAPI/AccountAPI.csproj", "AccountAPI/"]
RUN dotnet restore "AccountAPI/AccountAPI.csproj"
COPY . .
WORKDIR "/src/AccountAPI"
RUN dotnet build "AccountAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AccountAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:7001
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AccountAPI.dll"]