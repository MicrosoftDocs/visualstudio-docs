---
title: "Add code to datasets in n-tier applications | Microsoft Docs"
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
  - "n-tier applications, extending datasets"
ms.assetid: d43c2ccd-4902-43d8-b1a8-d10ca5d3210c
caps.latest.revision: 20
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
# Add code to datasets in n-tier applications
You can extend the functionality of a dataset by creating a partial class file for the dataset and adding code to it (instead of adding code to the *DatasetName*.Dataset.Designer file). Partial classes enable code for a specific class to be divided among multiple physical files. For more information, see [Partial](/dotnet/visual-basic/language-reference/modifiers/partial) or [Partial Classes and Methods](/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods).  
  
 The code that defines a dataset is generated every time changes are made to the dataset definition (in the [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md)). This code is also generated when you make changes during the running of any wizard that modifies the configuration of a dataset. To prevent your code from being deleted during the regeneration of a dataset, add code to the dataset's partial class file.  
  
 By default, after you separate the dataset and `TableAdapter` code, the result is a discrete class file in each project. The original project has a filenamed *DatasetName*.Designer.vb (or *DatasetName*.Designer.cs) that contains the `TableAdapter` code. The project that's designated in the **Dataset Project** property has a file that's named *DatasetName*.DataSet.Designer.vb (or *DatasetName*.DataSet.Designer.cs).This file contains the dataset code.  
  
> [!NOTE]
>  When you separate datasets and `TableAdapter`s (by setting the **DataSet Project** property), existing partial dataset classes in the project won't be moved automatically. Existing dataset partial classes must be moved manually to the dataset project.  
  
> [!NOTE]
>  When validation code needs to be added, the [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md)provides functionality for generating <xref:System.Data.DataTable.ColumnChanging> and <xref:System.Data.DataTable.RowChanging> event handlers. For more information, see [Add validation to an n-tier dataset](../data-tools/add-validation-to-an-n-tier-dataset.md).  
  
### To add code to datasets in n-tier applications  
  
1.  Locate the project that contains the .xsd file (the [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md)).  
  
2.  Select the **.xsd** file to open the [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md).  
  
3.  Right-click the data table to which you want to add code (the table name in the title bar), and thenselect**View Code**.  
  
     A partial class is created and opens in the Code Editor.  
  
4.  Add code inside the partial class declaration.  
  
     The following example shows where to add code to the CustomersDataTable in the NorthwindDataSet:  
  
    ```vb#  
    Partial Public Class CustomersDataTable  
        ' Add code here to add functionality   
        ' to the CustomersDataTable.  
    End Class  
    ```  
  
    ```c#  
    partial class CustomersDataTable  
    {  
        // Add code here to add functionality  
        // to the CustomersDataTable.  
    }  
    ```  
  
## See Also  
 [N-Tier Data Applications Overview](../data-tools/n-tier-data-applications-overview.md)   
 [Add code to TableAdapters in n-tier applications](../data-tools/add-code-to-tableadapters-in-n-tier-applications.md)   
 [TableAdapters](../Topic/TableAdapters.md)   
 [TableAdapterManager Overview](../Topic/TableAdapterManager%20Overview.md)   
 [Hierarchical Update Overview](../Topic/Hierarchical%20Update%20Overview.md)   
 [Creating Data Applications](../data-tools/creating-data-applications.md)   
 [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)