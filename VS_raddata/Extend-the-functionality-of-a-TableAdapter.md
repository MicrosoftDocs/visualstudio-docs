---
title: "Extend the functionality of a TableAdapter"
ms.custom: na
ms.date: 10/07/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - aspx
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 418249c8-c7f3-47ef-a94c-744cb6fe6aaf
caps.latest.revision: 11
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Extend the functionality of a TableAdapter
You can extend the functionality of a TableAdapter by adding code to the TableAdapter's partial class file.  
  
 The code that defines a TableAdapter is regenerated when any changes are made to the TableAdapter in the **Dataset Designer**, or when a wizard  modifies the configuration of a TableAdapter. To prevent your code from being deleted during the regeneration of a TableAdapter, add code to the TableAdapter's partial class file.  
  
 Partial classes allow code for a specific class to be divided among multiple physical files. For more information, see [Partial](../Topic/Partial%20\(Visual%20Basic\).md) or [partial (Type)](../Topic/partial%20\(Type\)%20\(C%23%20Reference\).md).  
  
## Locate TableAdapters in code  
 While TableAdapters are designed with the **Dataset Designer**, the TableAdapter classes that are generated are not  nested classes of <xref:System.Data.DataSet?qualifyHint=False>. TableAdapters are located in a namespace based on the name of the TableAdapter's associated dataset. For example, if your application contains a dataset named `HRDataSet`, the TableAdapters would be located in the `HRDataSetTableAdapters` namespace. (The naming convention follows this pattern: *DatasetName* + `TableAdapters`).  
  
 The following example assumes a TableAdapter named `CustomersTableAdapter`is in a project with `NorthwindDataSet`.  
  
#### To create a partial class for a TableAdapter  
  
1.  Add a new class to your project by going to the **Project** menu and selecting**Add Class**.  
  
2.  Name the class `CustomersTableAdapterExtended`.  
  
3.  Select**Add**.  
  
4.  Replace the code with the correct namespace and partial class name for your project as follows:  
  
     [!CODE [VbRaddataTableAdapters#2](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataTableAdapters#2)]  
  
## See Also  
 [Fill datasets by using TableAdapters](../VS_raddata/Fill-datasets-by-using-TableAdapters.md)