#Build Stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
# Create working directory
WORKDIR /source
# Copy code to working directory
COPY . .
# Restore dependencies
RUN dotnet restore "./PacificTours/PacificTours.sln"
# Publish app
RUN dotnet publish "./PacificTours/PacificTours.sln" -c Release -o /app

#Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app ./

ENTRYPOINT ["dotnet", "PacificTours.dll"]