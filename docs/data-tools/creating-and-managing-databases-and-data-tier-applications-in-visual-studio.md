---
title: Database Projects & DAC Projects (.NET Framework)
description: Explore database projects and data-tier applications (DACs), create databases and DACs, and update existing databases and DACs.
ms.date: 06/24/2025
ms.topic: concept-article
helpviewer_keywords:
- databases, managing change
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
#customer intent: As a developer, I want to explore database projects and data-tier applications (DACs) in Visual Studio, so I can create and updated databases and DACs.
---

# Database projects and data-tier applications (.NET Framework)

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

You can use database projects to create new databases and new data-tier applications (DACs) and update existing databases and DACs. Both database projects and DAC projects enable you to apply version control and project management techniques to your database development efforts in much the same way you apply those techniques to managed or native code. You can help your development team manage changes to databases and database servers by creating a DAC project, database project, or a server project and putting it under version control. Members of your team can then check out files to make, build, and test changes in an isolated development environment, or sandbox, before sharing them with the team. To help ensure code quality, your team can finish and test all changes for a particular release of the database in a staging environment before you deploy the changes into production.

To review the list of the supported database features for data-tier applications, see [DAC support for SQL Server objects](/sql/relational-databases/data-tier-applications/dac-support-for-sql-server-objects-and-versions). If you use unsupported features in your database, you should instead use a database project to manage changes to your database.

## Common high-level tasks

The following table describes the common high-level tasks you can accomplish for your database projects and data-tier applications in Visual Studio:

| High-level task | Description | Supporting content |
|-----------------|-------------|--------------------|
| **Start development of a data-tier application** | The concept of a data-tier application (DAC) was introduced with SQL Server 2008. A DAC contains the definition for a SQL Server database and the supporting instance objects that are used by a client-server or three-tier application. A DAC includes database objects, such as tables and views, together with instance entities like logins. You can use Visual Studio to create a DAC project and build a DAC package file. Then you can send the DAC package file to a database administrator for deployment onto an instance of the SQL Server Database Engine. | - [Data-tier applications](/sql/relational-databases/data-tier-applications/data-tier-applications)<br />- [SQL Server Management Studio](/sql/ssms/sql-server-management-studio-ssms) |
| **Perform iterative database development** | Developers can check out parts of the project and make updates in an isolated development environment. By using this type of environment, you can test your changes without affecting other members of the team. After the changes are complete, you check the files back into version control, where other team members can obtain your changes and build and deploy them to a test server. | - [Project-oriented offline database development (SQL Server Data Tools)](/sql/ssdt/project-oriented-offline-database-development)<br />- [Transact-SQL debugger (SQL Server Management Studio)](/sql/ssms/scripting/transact-sql-debugger) |
| **Prototype, verify test results, modify database scripts and objects** | You can use the Transact-SQL editor to perform any of these common tasks. | - [Query and text editors (SQL Server Management Studio)](/sql/ssms/scripting/query-and-text-editors-sql-server-management-studio) |

## Related content

- [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)