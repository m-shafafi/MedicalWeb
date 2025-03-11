# Use the base image with ASP.NET
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy only the .csproj files first to optimize caching
COPY ["src/Services/Shop/MedicalShop.Presentation/MedicalShop.Presentation.csproj", "src/Services/Shop/MedicalShop.Presentation/"]

# Restore the dependencies for the project
RUN dotnet restore "src/Services/Shop/MedicalShop.Presentation/MedicalShop.Presentation.csproj"

# Copy the rest of the project files
COPY . .

# Set the working directory to the project folder
WORKDIR "/src/Services/Shop/MedicalShop.Presentation"

# Build the application in Release configuration
RUN dotnet build "MedicalShop.Presentation.csproj" -c Release -o /app/build

# Publish the application to the /app/publish folder
FROM build AS publish
RUN dotnet publish "MedicalShop.Presentation.csproj" -c Release -o /app/publish

# Final image based on the base ASP.NET image
FROM base AS final
WORKDIR /app

# Copy the published application to the final image
COPY --from=publish /app/publish .

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "MedicalShop.Presentation.dll"]
