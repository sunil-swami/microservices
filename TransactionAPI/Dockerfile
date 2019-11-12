FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 7003

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["TransactionAPI/TransactionAPI.csproj", "TransactionAPI/"]
RUN dotnet restore "TransactionAPI/TransactionAPI.csproj"
COPY . .
WORKDIR "/src/TransactionAPI"
RUN dotnet build "TransactionAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TransactionAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:7003
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TransactionAPI.dll"]