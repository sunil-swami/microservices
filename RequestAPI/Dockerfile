FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["RequestAPI/RequestAPI.csproj", "RequestAPI/"]
RUN dotnet restore "RequestAPI/RequestAPI.csproj"
COPY . .
WORKDIR "/src/RequestAPI"
RUN dotnet build "RequestAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "RequestAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:7004
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RequestAPI.dll"]