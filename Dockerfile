FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY dulichaspnet/dulichaspnet.csproj ./
RUN ls -la && dotnet restore --verbosity detailed

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .

# Set the environment variable to specify the port
ENV ASPNETCORE_URLS=http://+:\${PORT}

# Run the app on container startup
ENTRYPOINT [ "dotnet", "dulichaspnet.dll" ]