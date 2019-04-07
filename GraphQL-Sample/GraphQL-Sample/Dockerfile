FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY GraphQL-Sample/GraphQL-Sample.csproj GraphQL-Sample/
RUN dotnet restore GraphQL-Sample/GraphQL-Sample.csproj
COPY . .
WORKDIR /src/GraphQL-Sample
RUN dotnet build GraphQL-Sample.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish GraphQL-Sample.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GraphQL-Sample.dll"]
