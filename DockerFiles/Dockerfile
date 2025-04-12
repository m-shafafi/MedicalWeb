#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Services/Products/Products.Presentation/Products.Presentation.csproj", "src/Services/Products/Products.Presentation/"]
COPY ["src/Services/Products/Products.Application/Products.Application.csproj", "src/Services/Products/Products.Application/"]
COPY ["BuildingBlocks/EventBus.Messages/EventBus.Messages.csproj", "BuildingBlocks/EventBus.Messages/"]
COPY ["src/Services/Products/Products.Infrastructure/Products.Infrastructure.csproj", "src/Services/Products/Products.Infrastructure/"]
COPY ["src/Services/Products/Products.Domain/Products.Domain.csproj", "src/Services/Products/Products.Domain/"]
RUN dotnet restore "./src/Services/Products/Products.Presentation/Products.Presentation.csproj"
COPY . .
WORKDIR "/src/src/Services/Products/Products.Presentation"
RUN dotnet build "./Products.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Products.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Products.Presentation.dll"]