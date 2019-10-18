---
title: "The connection string contains credentials with a clear text password and is not using integrated security | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 501d85af-92e0-4471-b280-8a59c0688575
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# The connection string contains credentials with a clear text password and is not using integrated security
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Do you want to save the connection string to the current DBML file and application configuration files with this sensitive information?  Click No to save the connection string without the sensitive information.

 When working with data connections that include sensitive information (passwords that are included in the connection string), you are given the option of saving the connection string into a project's DBML file and application configuration file with or without the sensitive information.

> [!WARNING]
> Explicitly setting the **Connection** properties **Application Settings** property to **False** will add the password to the DBML file.

### To save the connection string with the sensitive information in the project's application settings

- Click **Yes**.

     The connection string is stored as an application setting. The connection string includes the sensitive information in plain text. The DBML file does not contain the sensitive information.

### To save the connection string without the sensitive information in the project's application settings

- Click **No**.

     The connection string is stored as an application setting, but the password is not included.

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
