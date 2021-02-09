---
title: require-mssql
description: devinit tool require-mssql.
ms.date: 11/20/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jmartens
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# require-mssql

The `require-mssql` tool is used to install [Microsoft SQL Server 2019 Developer Edition](https://www.microsoft.com/sql-server/application-development) from via the MS SQL server ISO. The SQL server will be available on `localhost` using integrated Windows auth the SQL server will be accessible with the connection string `"Server=localhost;Integrated Security=true;"`.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                                   |
|--------------------------------------------------|--------|----------|-----------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                                   |
| [**input**](#input)                              | string | No       | See [Input](#input) below for details.                                                  |
| [**additionalOptions**](#additional-options)     | string | No       | Not used. See [Additional options](#additional-options) below for details.              |

### Input

The `input` property can be a string with one of two values:

| Value     | Description                              |
|-----------|------------------------------------------|
| install   | Installs SQL server.                     |
| uninstall | Uninstalls all SQL server installations. |

### Additional options

Not used.

### Default behavior

The default behavior of the `require-mssql` tool is to install SQL server.

### Built-in options

The `require-mssql` tool sets a number of installer command line arguments to ensure that the installer can run headless. These arguments are listed below and documentation on them can be found in the [SQL install documentation](/sql/database-engine/install-windows/install-sql-server-from-the-command-prompt?view=sql-server-ver15&preserve-view=true).

| Name                                                               | Description |
|--------------------------------------------------------------------|-------------|
| /q                                                                 |             |
| /ACTION=Install                                                    |             |
| /FEATURES=SQLEngine, LocalDB                                       |             |
| /UpdateEnabled                                                     |             |
| /UpdateSource=MU                                                   |             |
| /X86=false                                                         |             |
| /INSTANCENAME=MSSQLSERVER                                          |             |
| /INSTALLSHAREDDIR="C:\Program Files\Microsoft SQL Server"          |             |
| /INSTALLSHAREDWOWDIR="C:\Program Files (x86)\Microsoft SQL Server" |             |
| /SQLSVCINSTANTFILEINIT=True                                        |             |
| /INSTANCEDIR="C:\Program Files\Microsoft SQL Server"               |             |
| /AGTSVCACCOUNT="NT Service\SQLSERVERAGENT"                         |             |
| /AGTSVCSTARTUPTYPE=Manual                                          |             |
| /SQLSVCSTARTUPTYPE=Automatic                                       |             |
| /SQLCOLLATION="SQL_Latin1_General_CP1_CI_AS"                       |             |
| /SQLSVCACCOUNT="NT Service\MSSQLSERVER"                            |             |
| /SQLSYSADMINACCOUNTS=Administrators                                |             |
| /IACCEPTSQLSERVERLICENSETERMS                                      |             |

## Example usage
Below is an example of how to run `require-msssql` using a `.devinit.json`.

#### .devinit.json that will install MSSQL:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
    "run": [
        {
            "tool": "require-mssql",
            "input": "install",
        }
    ]
}
```