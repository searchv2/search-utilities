# syntax=docker/dockerfile:1

# SearchUtilities is a shared library, not a service - this image exists only to
# build the NuGet package. The other services build it themselves; this is for
# CI or for populating a local feed:
#
#   docker build -t search-utilities .
#   docker create --name su search-utilities && docker cp su:/packages ./nupkg && docker rm su

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY . .
RUN dotnet pack SearchUtilities.csproj -c Release -o /packages

# Final stage holds just the packed .nupkg.
FROM scratch
COPY --from=build /packages/ /
