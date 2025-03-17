FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

WORKDIR /app

EXPOSE 3000
EXPOSE 3001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Development
WORKDIR /src

COPY ["src/Services/shop/Products.Presentation/Products.Presentation.csproj", "src/Services/shop/Products.Presentation/"]
COPY ["src/Services/shop/Products.Presentation/Products.csproj", "src/Services/shop/Products.Infrastructure/"]
COPY ["src/Services/shop/Products.Presentation/Products.csproj", "src/Services/shop/Products.Domain/"]
COPY ["src/Services/shop/Products.Presentation/Products.csproj", "src/Services/shop/Products.Application/"]
COPY ["src/Services/shop/Products.Presentation/Products.csproj", "src/Services/shop/Products.Contracts/"]

RUN dotnet restore "src/Services/shop/Products.Presentation/Products.Presentation.csproj"

COPY . .

WORKDIR "src/Services/shop/Products.Presentation"
RUN dotnet build "Products.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Development
RUN dotnet publish "Products.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Products.Presentation.dll"]