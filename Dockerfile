FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app 
#
# copy csproj and restore as distinct layers
COPY *.sln .
COPY Deus_DataAccessLayer/*.csproj ./Deus_DataAccessLayer/
COPY deusbarbershop/*.csproj ./deusbarbershop/
COPY Deus_Models/*.csproj ./Deus_Models/
COPY FunctionalTests/*.csproj ./FunctionalTests/
COPY IntegrationTests/*.csproj ./IntegrationTests/
#
# copy everything else and build app
COPY Deus_DataAccessLayer/. ./Deus_DataAccessLayer/
COPY deusbarbershop/. ./deusbarbershop/
COPY Deus_Models/. ./Deus_Models/
COPY FunctionalTests/. ./FunctionalTests/
COPY IntegrationTests/. ./IntegrationTests/
#

WORKDIR /app/deusbarbershop
RUN dotnet publish -c Release -o out 
#

# run the unit tests
FROM build AS test
WORKDIR /app/deusbarbershop/IntegrationTests/*
RUN dotnet test 

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app 
#
COPY --from=build /app/deusbarbershop/out ./

EXPOSE 80
ENTRYPOINT ["dotnet", "deusbarbershop.dll"]