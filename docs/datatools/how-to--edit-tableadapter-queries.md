---
title: "How to: Edit TableAdapter Queries"
ms.custom: na
ms.date: "09/17/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbData.Microsoft.VSDesigner.DataSource.DbSource"
  - "vbdata.Microsoft.VSDesigner.DataSource.DbSource"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "queries [Visual Basic], editing"
  - "TableAdapters, editing queries"
  - "data [Visual Studio], TableAdapters"
  - "editing queries"
ms.assetid: aac7b7b4-bd91-4225-95d4-a07643568c43
caps.latest.revision: 10
ms.author: "mblome"
manager: "ghogen"
robots: noindex,nofollow
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
# How to: Edit TableAdapter Queries
You edit TableAdapter queries with the [Editing TableAdapters](../datatools/editing-tableadapters.md) in the **Dataset Designer**. You should modify a TableAdapter query when it no longer suits the needs of your application. (Alternatively, you can create additional queries on the TableAdapter. For more information on adding new queries, see [How to: Create TableAdapter Queries](../datatools/how-to--create-tableadapter-queries.md).)  
  
> [!NOTE]
>  If the [TableAdapter Configuration Wizard](../Topic/TableAdapter%20Configuration%20Wizard.md) opens instead of the **TableAdapter Query Configuration Wizard**, you might have selected the TableAdapter's main `Fill` query and not one of the TableAdapter's additional queries. For information on editing the TableAdapter's main `Fill` query, see [How to: Edit TableAdapters](../Topic/How%20to:%20Edit%20TableAdapters.md).  
  
 ![TableAdapter with multiple queries](../datatools/media/tableadapter.gif "TableAdapter")  
  
### To edit a TableAdapter query  
  
1.  Open the dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md).  
  
2.  Select the TableAdapter query you want to edit.  
  
3.  Right-click the TableAdapter query and select **Configure**.  
  
     The **TableAdapter Query Configuration Wizard** opens, ready for you to modify the query or stored procedure for that query.  
  
4.  Complete the **TableAdapter Query Configuration Wizard** with the changes that you want. For more information, see [Editing TableAdapters](../datatools/editing-tableadapters.md).  
  
## See Also  
 [TableAdapters](../Topic/TableAdapters.md)   
 [Connecting to Data in Visual Studio](../datatools/connecting-to-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../datatools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../datatools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../datatools/editing-data-in-your-application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../datatools/saving-data.md)   
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)