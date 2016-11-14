---
title: "How to: Display Related Data in a Windows Forms Application | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2016"
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
  - "Windows Forms, displaying data"
  - "displaying data, related data"
  - "related data, displaying"
  - "displaying tables, related data"
  - "data [Windows Forms], displaying"
  - "displaying table data"
  - "data [Windows Forms], related"
  - "displaying data on forms, related data"
  - "displaying table information"
ms.assetid: 60b1f1ec-6257-42ab-83f0-06d54ed364fd
caps.latest.revision: 16
author: "mikeblome"
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
# How to: Display Related Data in a Windows Forms Application
You can display related data by dragging items that share the same main table node from the [Data Sources Window](../Topic/Data%20Sources%20Window.md) onto your form. For example, if you have a data source that has a `Customers` table and a related `Orders` table, you would see both tables as top-level nodes (in the tree view) in the **Data Sources** window. Expand the `Customers` node so that you can see the columns, and you will notice that the last column in the list is an expandable node representing the `Orders` table. This node represents the related orders for a customer. This means that if you want to create a form that allows you to select a customer and then display a list of orders for that customer, you would drag the items you want to display from this single hierarchy.  
  
 ![Data Sources Window showing relation](../data-tools/media/datasources2.gif "DataSources2")  
Creating data-bound controls that display related records  
  
 ![link to video](../data-tools/media/playvideo.gif "PlayVideo") For a video version of this topic, see [How do I: Update Related Tables](http://go.microsoft.com/fwlink/?LinkId=143527).  
  
### To create controls that display related records  
  
1.  Open your form in the [Windows Forms Designer](http://msdn.microsoft.com/en-us/3c3d61f8-f36c-4d41-b9c3-398376fabb15).  
  
2.  Open the **Data Sources** window. For more information, see [How to: Open the data sources window](../data-tools/how-to-open-the-data-sources-window.md).  
  
3.  Expand the node representing the parent table in the relationship. (The parent table is the table on the "one" side of a one-to-many relationship.)  
  
4.  Drag any items you want to display from the parent table in the relationship from the **Data Sources** window onto your form.  
  
5.  Related child tables appear as expandable nodes at the bottom of the parent table's column list. Drag the item(s) that you want to display from such a related node onto your form.  
  
    > [!NOTE]
    >  Dragging an item from a top-level nodes creates a separate unrelated [BindingSource Component](../Topic/BindingSource%20Component.md) that does not facilitate navigating the related records. To bind related data you must select the tables from the same hierarchical node.  
  
## See Also  
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Walkthrough: Displaying Data on a Windows Form](../data-tools/walkthrough-displaying-data-on-a-windows-form.md)   
 [TableAdapter Overview](../data-tools/tableadapter-overview.md)   
 [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md)   
 [Add new data sources](../data-tools/add-new-data-sources.md)   
 [How to: Connect to Data in a Database](../data-tools/how-to-connect-to-data-in-a-database.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [How to: Navigate Data with the Windows Forms BindingNavigator Control](../Topic/How%20to:%20Navigate%20Data%20with%20the%20Windows%20Forms%20BindingNavigator%20Control.md)