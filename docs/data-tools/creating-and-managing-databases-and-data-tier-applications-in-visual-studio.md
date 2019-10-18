---
title: Database projects and DAC projects
ms.date: 11/21/2018
ms.topic: conceptual
helpviewer_keywords:
  - "databases, managing change"
ms.assetid: 40b51f5a-d52c-44ac-8f84-037a0917af33
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Database projects and data-tier applications

You can use database projects to create new databases, new data-tier applications (DACs), and to update existing databases and data-tier applications. Both database projects and DAC projects enable you to apply version control and project management techniques to your database development efforts in much the same way that you apply those techniques to managed or native code. You can help your development team manage changes to databases and database servers by creating a DAC project, database project, or a server project and putting it under version control. Members of your team can then check out files to make, build, and test changes in an isolated development environment, or sandbox, before sharing them with the team. To help ensure code quality, your team can finish and test all changes for a particular release of the database in a staging environment before you deploy the changes into production.

For a list of the database features that are supported by data-tier applications, see [DAC support for SQL Server objects](/sql/relational-databases/data-tier-applications/dac-support-for-sql-server-objects-and-versions). If you use features in your database that are not supported by data-tier applications, you should instead use a database project to manage changes to your database.

## Common high-level tasks

| High-Level Task | Supporting Content |
| - | - |
| **Start development of a data-tier application:** The concept of a data-tier application (DAC) was introduced with SQL Server 2008. A DAC contains the definition for a SQL Server database and the supporting instance objects that are used by a client-server or 3-tier application. A DAC includes database objects, such as tables and views, together with instance entities such as logins. You can use Visual Studio to create a DAC project, build a DAC package file, and send the DAC package file to a database administrator for deployment onto an instance of the SQL Server database engine. | - [Data-tier applications](/sql/relational-databases/data-tier-applications/data-tier-applications)<br />- [SQL Server Management Studio](/sql/ssms/sql-server-management-studio-ssms) |
| **Performing iterative database development:** Developers can check out parts of the project and update them in an isolated development environment. By using this type of environment, you can test your changes without affecting other members of the team. After the changes are complete, you check the files back into version control, where other team members can obtain your changes and build and deploy them to a test server. | - [Project-oriented offline database development (SQL Server Data Tools)](/sql/ssdt/project-oriented-offline-database-development)<br />- [Transact-SQL debugger (SQL Server Management Studio)](/sql/ssms/scripting/transact-sql-debugger) |
| **Prototyping, verifying test results, and modifying database scripts and objects:** You can use the Transact-SQL editor to perform any one of these common tasks. | - [Query and text editors (SQL Server Management Studio)](/sql/ssms/scripting/query-and-text-editors-sql-server-management-studio) |

## See also

- [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)