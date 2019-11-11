FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["CustomerAPI/CustomerAPI.csproj", "CustomerAPI/"]
RUN dotnet restore "CustomerAPI/CustomerAPI.csproj"
COPY . .
WORKDIR "/src/CustomerAPI"
RUN dotnet build "CustomerAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CustomerAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CustomerAPI.dll"]