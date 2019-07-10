# versão funcionando abaixo já com o publish
FROM mcr.microsoft.com/dotnet/core/sdk:2.2
LABEL version="1.0" maintainer="Ramon"
WORKDIR /app
COPY ./build .
# COPY ./startup.sh .
# CMD ["bash", "startup.sh"]
CMD [ "dotnet", "MS1.dll" , "> ramon.log"]






# adicionando build na hora da criação
# FROM mcr.microsoft.com/dotnet/core/sdk:2.2
# WORKDIR /app/
# COPY MS1/build/MS1.dll ;
# RUN dotnet restore
# RUN dotnet publish -o dist
# WORKDIR /dist
# ENTRYPOINT [ "dotnet", "MS1.dll"]



# EXPOSE 5000
# EXPOSE 5001
# Copy csproj and restore as distinct layers
# FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
# WORKDIR ../
# COPY *.csproj /app
# WORKDIR $DIRAPP/
# RUN dotnet restore


# # Copy everything else and build
# COPY . .
# RUN dotnet build -c Release

# WORKDIR /build
# COPY --from=build-env /app/out .
# ENTRYPOINT [ "dotnet", "MS1.dll"]
# ENTRYPOINT ["dotnet", "run"]