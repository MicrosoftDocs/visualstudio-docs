---
title: "Add code to datasets in n-tier applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "n-tier applications, extending datasets"
ms.assetid: d43c2ccd-4902-43d8-b1a8-d10ca5d3210c
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: jillfra
---
# Add code to datasets in n-tier applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can extend the functionality of a dataset by creating a partial class file for the dataset and adding code to it (instead of adding code to the *DatasetName*.Dataset.Designer file). Partial classes enable code for a specific class to be divided among multiple physical files. For more information, see [Partial](https://msdn.microsoft.com/library/7adaef80-f435-46e1-970a-269fff63b448) or [Partial Classes and Methods](https://msdn.microsoft.com/library/804cecb7-62db-4f97-a99f-60975bd59fa1).

The code that defines a dataset is generated every time changes are made to the dataset definition. This code is also generated when you make changes during the running of any wizard that modifies the configuration of a dataset. To prevent your code from being deleted during the regeneration of a dataset, add code to the dataset's partial class file.

By default, after you separate the dataset and `TableAdapter` code, the result is a discrete class file in each project. The original project has a filenamed *DatasetName*.Designer.vb (or *DatasetName*.Designer.cs) that contains the `TableAdapter` code. The project that's designated in the **Dataset Project** property has a file that's named *DatasetName*.DataSet.Designer.vb (or *DatasetName*.DataSet.Designer.cs).This file contains the dataset code.

> [!NOTE]
> When you separate datasets and `TableAdapter`s (by setting the **DataSet Project** property), existing partial dataset classes in the project won't be moved automatically. Existing dataset partial classes must be moved manually to the dataset project.

> [!NOTE]
> When validation code needs to be added, the DataSet Designer provides functionality for generating <xref:System.Data.DataTable.ColumnChanging> and <xref:System.Data.DataTable.RowChanging> event handlers. For more information, see [Add validation to an n-tier dataset](../data-tools/add-validation-to-an-n-tier-dataset.md).

## Add code to datasets in n-tier applications

1. Locate the project that contains the .xsd file (the dataset).

2. Select the **.xsd** file to open the dataset.

3. Right-click the data table to which you want to add code (the table name in the title bar), and then select **View Code**.

     A partial class is created and opens in the Code Editor.

4. Add code inside the partial class declaration.

     The following example shows where to add code to the CustomersDataTable in the NorthwindDataSet:

    ```vb
    Partial Public Class CustomersDataTable
        ' Add code here to add functionality
        ' to the CustomersDataTable.
    End Class
    ```

    ```csharp
    partial class CustomersDataTable
    {
        // Add code here to add functionality
        // to the CustomersDataTable.
    }
    ```

## See also

- [N-Tier Data Applications Overview](../data-tools/n-tier-data-applications-overview.md)
- [Add code to TableAdapters in n-tier applications](../data-tools/add-code-to-tableadapters-in-n-tier-applications.md)
- [TableAdapters](https://msdn.microsoft.com/library/09416de9-134c-4dc7-8262-6c8d81e3f364)
- [TableAdapterManager Overview](https://msdn.microsoft.com/library/33076d42-6b41-491a-ac11-6c6339aea650)
- [Hierarchical Update Overview](https://msdn.microsoft.com/library/c4f8e8b9-e4a5-4a02-8462-d03d1e8222d6)
- [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)