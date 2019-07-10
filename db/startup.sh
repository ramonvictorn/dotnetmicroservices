#!/usr/bin/env bash
echo STARTUP AQUI
export PATH="$PATH:/opt/mssql-tools/bin" >> ~/.bashrc
echo DEPOIS DO EXPORT
# exec source ~/.bashrc
# bash ./startup.sh
# /opt/mssql/bin/sqlservr
# sqlcmd
# sqlcmd -S 127.0.0.1 -U sa -P Password123 -i createDb.sql -e