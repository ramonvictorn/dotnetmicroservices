# versão funcionando abaixo
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
LABEL version="1.2" maintainer="Ramon"
WORKDIR /app
COPY ./build .
# COPY ./libs/wait-for-it/wait-for-it.sh .
# COPY ./startup.sh .
# CMD ["bash", "startup.sh"],
RUN apt-get update && apt-get install -y wget
ENV DOCKERIZE_VERSION v0.6.1
RUN wget https://github.com/jwilder/dockerize/releases/download/$DOCKERIZE_VERSION/dockerize-linux-amd64-$DOCKERIZE_VERSION.tar.gz \
    && tar -C /usr/local/bin -xzvf dockerize-linux-amd64-$DOCKERIZE_VERSION.tar.gz \
    && rm dockerize-linux-amd64-$DOCKERIZE_VERSION.tar.gz
# RUN dos2unix ./test.sh && apt-get --purge remove -y dos2unix && rm -rf /var/lib/apt/lists/*
# CMD [ "dotnet", "Auditoria.dll"]
CMD ["dockerize" , "-wait" , "http://rabbitmq:15672" , "-timeout" , "20s" ,"dotnet", "Auditoria.dll"] 
# CMD ["bash",".test.sh rabbitmq:5672" ]


# adicionando build na hora da criação
# FROM mcr.microsoft.com/dotnet/core/sdk:2.2
# WORKDIR /app2
# COPY Auditoria/Program.cs /app2
# COPY Auditoria/Auditoria.csproj /app2
# RUN dotnet restore
# RUN dotnet publish -o dist
# WORKDIR dist
# ENTRYPOINT [ "dotnet", "Auditoria.dll"]



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