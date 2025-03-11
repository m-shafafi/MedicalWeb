#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Services/shop/MedicalShop.Presentation/MedicalShop.Presentation.csproj", "src/Services/shop/MedicalShop.Presentation/"]
RUN dotnet restore "src/Services/shop/MedicalShop.Presentation/MedicalShop.Presentation.csproj"
COPY . .
WORKDIR "/src/services/shop/MedicalShop.Presentation"

RUN dotnet build "MedicalShop.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MedicalShop.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MedicalShop.Presentation.dll"]