# 使用官方 .NET 執行時映像檔
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# 使用 SDK 映像建構程式
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY ["1104001期末/1104001期末.csproj", "1104001期末/"]
RUN dotnet restore "1104001期末/1104001期末.csproj"

COPY . .
WORKDIR "/src/1104001期末"
RUN dotnet build "1104001期末.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "1104001期末.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "1104001期末.dll"]
