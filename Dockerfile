FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

# Set the working directory.
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.sln ./
COPY APIs/*.csproj ./APIs/
COPY BusinessObjects/*.csproj ./BusinessObjects/
COPY DataAccess/*.csproj ./DataAccess/
COPY Repositories/*.csproj ./Repositories/
COPY WebClient/*.csproj ./WebClient/
RUN dotnet restore

# Copy everything else and build the project
COPY . ./
WORKDIR /app/APIs
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/APIs/out .
ENTRYPOINT ["dotnet", "APIs.dll"]