# 1. Use the .NET SDK to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# 2. Copy the project file and restore dependencies
COPY ["SpamClassifierApp.csproj", "./"]
RUN dotnet restore

# 3. Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o /app

# 4. Final Stage: Run the app
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app .

# CRITICAL: Copy your dataset into the container
COPY spam.csv . 

ENTRYPOINT ["dotnet", "SpamClassifierApp.dll"]