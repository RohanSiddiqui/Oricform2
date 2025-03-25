# Use official .NET SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy project files and restore dependencies
COPY . ./
RUN dotnet restore Oricform2.csproj

# Build the project
RUN dotnet publish -c Release -o /out

# Use official .NET runtime image for production
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /out ./

# Expose port 80 and run the app
EXPOSE 80
CMD ["dotnet", "Oricform2.dll"]
