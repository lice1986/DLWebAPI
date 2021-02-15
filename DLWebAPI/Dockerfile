#FROM microsoft/dotnet:latest
#
#RUN mkdir -p /usr/src/DLWebAPI
#WORKDIR /usr/src/DLWebAPI
#
#COPY . /usr/src/DLWebAPI
#
#RUN dotnet restore
#RUN ["dotnet", "build"]
#
#EXPOSE 5000/tcp
#ENV ASPNETCORE_URLS http://*:5000
#
#ENTRYPOINT ["dotnet", "run"]
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
#WORKDIR /app

# Copy csproj and restore as distinct layers
#COPY *.csproj ./
#RUN dotnet restore

# Copy everything else and build
#COPY . ./
#RUN dotnet publish -c Release -o out

# Build runtime image
#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
#WORKDIR /app
#COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "DLWebAPI.dll"]
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
#WORKDIR /app

#COPY *.csproj ./
#RUN dotnet restore

#COPY . ./
#RUN dotnet publish -c Release -o out

#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
#WORKDIR /app
#EXPOSE 80
#COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "DLWebAPI.dll"]
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["/DLWebAPI.csproj", "./"]
COPY ["/DLIT_GETDB_API.*", "./"]
RUN dotnet restore "./DLWebAPI.csproj"
RUN ls
COPY . .
WORKDIR "/src/."
#RUN dotnet publish
RUN ls
RUN dotnet build "DLWebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN ls
RUN dotnet publish "DLWebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DLWebAPI.dll"]
