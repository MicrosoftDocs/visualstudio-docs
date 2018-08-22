---
title: "Saving Data | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "DataRow.RowState"
  - "DataSet.GetChanges"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "DBDirect methods"
  - "updating data"
  - "data [Visual Studio], saving"
  - "TableAdapter DBDirect methods"
  - "databases, updating"
  - "TableAdapter.Update method"
  - "data [Visual Studio], updating"
  - "saving data"
  - "updating databases"
ms.assetid: 21d2b115-62e4-4ac9-a873-dcbb535b8af8
caps.latest.revision: 13
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# Saving Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Saving data is the process of persisting changed data in an application's data model back to the original data store, typically a relational database such as SQL Server.  
  
 Updating a data source by means of a data model is typically a two-step process. The first step is to update the data model with new information — new records, changed records, or deleted records. The second step is to save the changes in your data model back to the database.  
  
 The following topics describe the concepts and tasks associated with saving data.  
  
## Related Topics  
 [Save data back to the database](../data-tools/save-data-back-to-the-database.md)  
 Provides an overview of how changes are made in a dataset and how the dataset tracks information about changes in order to save those changes to a database.  
  
 [Saving Entity Data](../data-tools/saving-entity-data.md)  
 Describes how to save changes in [ADO.NET Entity Framework](http://msdn.microsoft.com/library/a437041f-6899-4ae7-96ce-aabf528d7205) and [WCF Data Services 4.5](http://msdn.microsoft.com/library/73d2bec3-7c92-4110-b905-11bb0462357a) applications.