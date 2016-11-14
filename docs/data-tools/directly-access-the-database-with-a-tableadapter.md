---
title: "Directly access the database with a TableAdapter | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "databases [Visual Basic], accessing with a TableAdapter"
  - "DBDirect methods"
  - "datasets [Visual Basic], adding to projects"
  - "data [Visual Studio], saving"
  - "TableAdapter.Delete method"
  - "GenerateDbDirectMethods property"
  - "TableAdapter.Insert method"
  - "TableAdapter.GenerateDBDirectMethods property"
  - "TableAdapter.Update method"
  - "saving data"
  - "TableAdapters"
ms.assetid: 012c5924-91f7-4790-b2a6-f51402b7014b
caps.latest.revision: 12
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Directly access the database with a TableAdapter
In addition to the `InsertCommand`, `UpdateCommand`, and `DeleteCommand`, TableAdapters are created with methods that can be run directly against the database. These methods (`TableAdapter.Insert`, `TableAdapter.Update`, and `TableAdapter.Delete`) can be called to manipulate data directly in the database.  
  
 If you don't want to create these direct methods, set the TableAdapter's `GenerateDbDirectMethods` property to `false` in the **Properties** window. If any queries  are added to a TableAdapter in addition to the TableAdapter's main query, they are standalone queries that don't generate these DbDirect methods.  
  
## Sendcommandsdirectly to a database  
 Call the TableAdapter DbDirect method that performs the task you are trying to accomplish.  
  
#### To insert new records directly into a database  
  
-   Call the TableAdapter's `Insert` method, passing in the values for each column as parameters. The following procedure uses the `Region` table in the Northwind databaseas an example.  
  
    > [!NOTE]
    >  If you do not have an instance available, instantiate the TableAdapter that you want to use.  
  
     [!code-vb[VbRaddataSaving#15](../data-tools/codesnippet/VisualBasic/directly-access-the-database-with-a-tableadapter_1.vb)]
     [!code-cs[VbRaddataSaving#15](../data-tools/codesnippet/CSharp/directly-access-the-database-with-a-tableadapter_1.cs)]  
  
#### To update records directly in a database  
  
-   Call the TableAdapter's `Update` method, passing in the new and original values for each column as parameters.  
  
    > [!NOTE]
    >  If you do not have an instance available, instantiate the TableAdapter that you want to use.  
  
     [!code-vb[VbRaddataSaving#18](../data-tools/codesnippet/VisualBasic/directly-access-the-database-with-a-tableadapter_2.vb)]
     [!code-cs[VbRaddataSaving#18](../data-tools/codesnippet/CSharp/directly-access-the-database-with-a-tableadapter_2.cs)]  
  
#### To delete records directly from a database  
  
-   Call the TableAdapter's `Delete` method, passing in the values for each column as parameters of the `Delete` method. The following procedure uses the `Region` table in the Northwind databaseas an example.  
  
    > [!NOTE]
    >  If you do not have an instance available, instantiate the TableAdapter that you want to use.  
  
     [!code-vb[VbRaddataSaving#21](../data-tools/codesnippet/VisualBasic/directly-access-the-database-with-a-tableadapter_3.vb)]
     [!code-cs[VbRaddataSaving#21](../data-tools/codesnippet/CSharp/directly-access-the-database-with-a-tableadapter_3.cs)]  
  
## See Also  
 [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)