# Set the base image as the .NET 6.0 SDK (this includes the runtime)
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env

# Copy everything and publish the release (publish implicitly restores and builds)
COPY . ./
RUN dotnet publish ./DotNetGitHubActionTemplate/DotNetGitHubActionTemplate.csproj -c Release -o out --no-self-contained

# Label the container
LABEL maintainer="Calvin Wilkinson <kinsondigital@gmail.com>"
LABEL repository="https://github.com/KinsonDigital/DotNetGitHubActionTemplate"
LABEL homepage="https://github.com/KinsonDigital/DotNetGitHubActionTemplate"

# Label as GitHub action
LABEL com.github.actions.name="DotNet GitHub Action Template"

# Relayer the .NET SDK, anew with the build output
FROM mcr.microsoft.com/dotnet/sdk:6.0
COPY --from=build-env /out .
ENTRYPOINT [ "dotnet", "/DotNetGitHubActionTemplate.dll" ]