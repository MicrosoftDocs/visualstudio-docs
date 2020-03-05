---
title: "The connection property in the Application Settings file is missing or incorrect | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 77724510-ff59-4d43-b933-a0434e1ac597
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# The connection property in the Application Settings file is missing or incorrect
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The connection property in the Application Settings file is missing or incorrect. The connection string from the .dbml file has been used in its place.

 The .dbml file contains a reference to a connection string in the application settings file that cannot be found. This message is informational; the connection string setting will be created when **OK** is clicked.

### To respond to this message

- Click **OK**. The connection information that is contained in the .dbml file is added to application settings.

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](https://msdn.microsoft.com/library/35aad4a4-2e8a-46e2-ae09-5fbfd333c233)
 [NIB: How to: Add or Remove Application Settings](https://msdn.microsoft.com/a233965c-126d-46ab-add4-efb758f576f4)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
