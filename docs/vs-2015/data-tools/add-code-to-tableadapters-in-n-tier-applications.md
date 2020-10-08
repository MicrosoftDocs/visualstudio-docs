---
title: "Add code to TableAdapters in n-tier applications | Microsoft Docs"
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
  - "TableAdapters, n-tier applications"
  - "n-tier applications, extending TableAdapters"
ms.assetid: dafac00e-df9d-4d4a-95a6-e34b4d099425
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: jillfra
---
# Add code to TableAdapters in n-tier applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can extend the functionality of a `TableAdapter` by creating a partial class file for the `TableAdapter` and adding code to it (instead of adding code to the *DatasetName*.DataSet.Designer file). Partial classes enable code for a specific class to be divided among multiple physical files. For more information, see [Partial](https://msdn.microsoft.com/library/7adaef80-f435-46e1-970a-269fff63b448) or [partial (Type)](https://msdn.microsoft.com/library/27320743-a22e-4c7b-b0b3-53afe3607334).

 The code that defines a `TableAdapter` is generated every time changes are made to the `TableAdapter`. This code is also generated when changes are made during the running of any wizard that modifies the configuration of the `TableAdapter`. To prevent your code from being deleted during the regeneration of a `TableAdapter`, add code to the partial class file of the `TableAdapter`.

 By default, after you separate the dataset and `TableAdapter` code, the result is a discrete class file in each project. The original project has a file named *DatasetName*.Designer.vb (or *DatasetName*.Designer.cs) that contains the `TableAdapter` code. The project that's designated in the **Dataset Project** property has a file named *DatasetName*.DataSet.Designer.vb (or *DatasetName*.DataSet.Designer.cs) that contains the dataset code.

> [!NOTE]
> When you separate datasets and `TableAdapter`s (by setting the **DataSet Project** property), existing partial dataset classes in the project will not be moved automatically. Existing dataset partial classes must be moved manually to the dataset project.

> [!NOTE]
> The DataSet Designer provides functionality for generating <xref:System.Data.DataTable.ColumnChanging> and <xref:System.Data.DataTable.RowChanging> event handlers when validation is needed. For more information, see [Add validation to an n-tier dataset](../data-tools/add-validation-to-an-n-tier-dataset.md).

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

### To add user code to a TableAdapter in an n-tier application

1. Locate the project that contains the .xsd file (the dataset).

2. Double click the **.xsd** file to open the dataset.

3. Right-click the `TableAdapter` that you want to add code to, and then select**View Code**.

     A partial class is created and opens in the Code Editor.

4. Add code inside the partial class declaration.

5. The following example shows where to add code to the `CustomersTableAdapter` in the `NorthwindDataSet`:

    ```vb
    Partial Public Class CustomersTableAdapter
        ' Add code here to add functionality
        ' to the CustomersTableAdapter.
    End Class
    ```

    ```csharp
    public partial class CustomersTableAdapter
    {
        // Add code here to add functionality
        // to the CustomersTableAdapter.
    }
    ```

## See Also
 [N-Tier Data Applications Overview](../data-tools/n-tier-data-applications-overview.md)
 [Add code to datasets in n-tier applications](../data-tools/add-code-to-datasets-in-n-tier-applications.md)
 [TableAdapters](https://msdn.microsoft.com/library/09416de9-134c-4dc7-8262-6c8d81e3f364)
 [TableAdapterManager Overview](https://msdn.microsoft.com/library/33076d42-6b41-491a-ac11-6c6339aea650)
 [Hierarchical Update Overview](https://msdn.microsoft.com/library/c4f8e8b9-e4a5-4a02-8462-d03d1e8222d6)