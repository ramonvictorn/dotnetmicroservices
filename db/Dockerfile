# versão funcionando abaixo
FROM mcr.microsoft.com/mssql/server:2017-latest-ubuntu
WORKDIR /app
COPY ./createDb.sql .
COPY ./startup.sh .

# CMD ["bash" , "createDb.sh"] 
# RUN echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bashrc
# RUN source ~/.bashrc
# RUN sqlcmd -S 127.0.0.1 -U sa -P Password123 -i createDb.sql -e
# CMD ["sqlcmd", "-S" ,"127.0.0.1" ,"-U" ,"sa" ,"-P" ,"Password123" ,"-i" ,"createDb.sql", "-e"]
# CMD ["bash", "./startup.sh"]x