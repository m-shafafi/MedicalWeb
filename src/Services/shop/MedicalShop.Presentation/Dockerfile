FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

WORKDIR /app

EXPOSE 3000
EXPOSE 3001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Development
WORKDIR /src

COPY ["src/Services/shop/MedicalShop.Presentation/MedicalShop.Presentation.csproj", "src/Services/shop/MedicalShop.Presentation/"]
COPY ["src/Services/shop/MedicalShop.Presentation/MedicalShop.csproj", "src/Services/shop/MedicalShop.Infrastructure/"]
COPY ["src/Services/shop/MedicalShop.Presentation/MedicalShop.csproj", "src/Services/shop/MedicalShop.Domain/"]
COPY ["src/Services/shop/MedicalShop.Presentation/MedicalShop.csproj", "src/Services/shop/MedicalShop.Application/"]
COPY ["src/Services/shop/MedicalShop.Presentation/MedicalShop.csproj", "src/Services/shop/MedicalShop.Contracts/"]

RUN dotnet restore "src/Services/shop/MedicalShop.Presentation/MedicalShop.Presentation.csproj"

COPY . .

WORKDIR "src/Services/shop/MedicalShop.Presentation"
RUN dotnet build "MedicalShop.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Development
RUN dotnet publish "MedicalShop.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "MedicalShop.Presentation.dll"]