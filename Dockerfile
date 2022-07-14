# Set the base image as the .NET 6.0 SDK (this includes the runtime)
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env

# Copy everything and publish the release (publish implicitly restores and builds)
COPY . ./
# TODO: Update this
RUN dotnet publish ./DotNetGitHubActionTemplate/DotNetGitHubActionTemplate.csproj -c Release -o out --no-self-contained

# Label the container
LABEL maintainer="Calvin Wilkinson <kinsondigital@gmail.com>"
# TODO: Update this
LABEL repository="https://github.com/KinsonDigital/DotNetGitHubActionTemplate"
# TODO: Update this
LABEL homepage="https://github.com/KinsonDigital/DotNetGitHubActionTemplate"

# Label as GitHub action
# TODO: Update this
LABEL com.github.actions.name="DotNet GitHub Action Template"

# Relayer the .NET SDK, anew with the build output
FROM mcr.microsoft.com/dotnet/sdk:6.0
COPY --from=build-env /out .
# TODO: Update this
ENTRYPOINT [ "dotnet", "/DotNetGitHubActionTemplate.dll" ]
