---
title: "Upgrade .mdf files | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "SQL Server Express"
  - "SQL Server LocalDB"
  - "LocalDB"
  - "SQLEXPRESS"
  - "upgrading SQLExpress to SQLExpress"
  - "upgrading to LocalDB"
ms.assetid: 14ca6f76-f80e-4926-8020-3fee2d802b75
caps.latest.revision: 36
author: jillre
ms.author: jillfra
manager: jillfra
robots: noindex,nofollow
---
# Upgrade .mdf files
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic describes your options for upgrading your database file (.mdf) after you install a newer version of Visual Studio. It includes instructions for the following tasks:

- Upgrade a database file to use a newer version of SQL Server Express LocalDB

- Upgrade a database file to use a newer version of SQL Server Express

- Work with a database file in Visual Studio but retain compatibility with an older version of SQL Server Express or LocalDB

- Make SQL Server Express the default database engine

  You can use Visual Studio to open a  project that contains a database file (.mdf) that was created by using an older version of SQL Server Express or LocalDB. However, to continue to develop your project in Visual Studio, you must have that version of SQL Server Express or LocalDB  installed on the same machine as Visual Studio, or you must upgrade the database file. If you upgrade the database file, you won't be able to access it by using older versions of SQL Server Express or LocalDB.

  You may also be prompted to upgrade a database file that was created through an earlier version of SQL Server Express or LocalDB if the version of the file isn't compatible with the instance of SQL Server Express or LocalDB that’s currently installed. To resolve the issue, Visual Studio will prompt you to upgrade the file.

> [!IMPORTANT]
> We recommend that you back up the database file before you upgrade it.

> [!WARNING]
> If you upgrade an .mdf file that was created in LocalDB 2014 (V12) 32 bit to LocalDB 2016 (V13), you will not be able to open the file again in the 32-bit version of LocalDB.  In Update 2, LocalDB V13 is 64 bit only.

 Before you upgrade a database, consider the following criteria:

- Don't upgrade if you want to work on your project in both an older version and a newer version of Visual Studio.

- Don't upgrade if your application will be used in environments that use SQL Server Express rather than LocalDB.

- Don't upgrade if your application uses remote connections, because LocalDB doesn't accept them.

- Don't upgrade if your application relies on Internet Information Services (IIS).

- Consider upgrading if you want to test database applications in a sandbox environment but don't want to administer a database.

### To upgrade a database file

1. In **Server Explorer**, select the **Connect to Database** button.

2. In the **Add Connection** dialog box, specify the following information:

   - **Data Source**: `Microsoft SQL Server (SqlClient)`

   - **Server Name**:

       - To use the default version: `(localdb)\MSSQLLocalDB`.  This will specify either ProjectV12 or ProjectV13, depending on which version of Visual Studio  is installed and when the first LocalDB instance was created. The **MSSQLLocalDB** node in **SQL Server Object Explorer** shows which version it is pointing to.

       - To use a specific version: `(localdb)\ProjectsV12` or `(localdb)\ProjectsV13`, where V12 is LocalDB 2014 and V13 is LocalDB 2016.

   - **Attach a database file**: The physical path of the primary .mdf file.

   - **Logical Name**: The name that you want to use with the file.

3. Select the **OK** button.

4. When you're prompted, select the **Yes** button to upgrade the file.

   The database is upgraded, is attached to the LocalDB database engine, and is no longer compatible with  the older version of LocalDB.

   You can also modify a SQL Server Express connection to use LocalDB by opening the shortcut menu for the connection and then selecting **Modify Connection**. In the **Modify Connection** dialog box, change the server name to `(LocalDB)\MSSQLLocalDB`. In the **Advanced Properties** dialog box, make sure that **User Instance** is set to **False**.

### To upgrade to a newer version of SQL Server Express

1. On the shortcut menu for the connection to the database, select **Modify Connection**.

2. In the **Modify Connection** dialog box, select the **Advanced** button.

3. In the **Advanced Properties** dialog box, select the **OK** button without changing the server name.

   The database file is upgraded to match the current version of SQL Server Express.

### To work with the database in Visual Studio but retain compatibility with SQL Server Express

- In Visual Studio, open the project without upgrading it.

  - To run the project, select the F5 key.

  - To edit the database, open the .mdf file in **Solution Explorer**, and expand the node in **Server Explorer** to work with your database.

### To make SQL Server Express the default database engine

1. On the menu bar, select **Tools** > **Options**.

2. In the **Options** dialog box, expand the **Data Tools** options, and then select the **Data Connections** node.

3. In the **SQL Server Instance Name** text box, specify the name of the instance of SQL Server Express or LocalDB that you want to use. If the instance isn't named, specify `.\SQLEXPRESS or (localdb)\MSSQLLocalDB`.

4. Select the **OK** button.

   SQL Server Express will be the default database engine for your applications.
