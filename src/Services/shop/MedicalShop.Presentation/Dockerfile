FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

WORKDIR /app

EXPOSE 3000
EXPOSE 3001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Development
WORKDIR /src

COPY ["MedicalShop.Presentation/MedicalShop.Presentation.csproj", "MedicalShop.Presentation/"]
COPY ["MedicalShop.Infrastructure/MedicalShop.Infrastructure.csproj", "MedicalShop.Infrastructure/"]
COPY ["MedicalShop.Domain/MedicalShop.Domain.csproj", "MedicalShop.Domain/"]
COPY ["MedicalShop.Application/MedicalShop.Application.csproj", "MedicalShop.Application/"]
COPY ["MedicalShop.Contracts/MedicalShop.Contracts.csproj", "MedicalShop.Contracts/"]

RUN dotnet restore "MedicalShop.Presentation/MedicalShop.Presentation.csproj"

COPY . .

WORKDIR "/src/MedicalShop.Presentation"
RUN dotnet build "MedicalShop.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Development
RUN dotnet publish "MedicalShop.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "MedicalShop.Presentation.dll"]