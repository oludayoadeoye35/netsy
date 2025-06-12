#!/bin/bash
sleep 30s

/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P s3cret-Ninja -i /docker-entrypoint-initdb.d/Northwind4AzureSqlEdgeDocker.sql
