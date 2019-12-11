---
title: Add code to TableAdapters in n-tier applications
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "TableAdapters, n-tier applications"
  - "n-tier applications, extending TableAdapters"
ms.assetid: dafac00e-df9d-4d4a-95a6-e34b4d099425
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Add code to TableAdapters in n-tier applications
You can extend the functionality of a TableAdapter by creating a partial class file for the TableAdapter and adding code to it (instead of adding code to the *DatasetName.DataSet.Designer* file). Partial classes enable code for a specific class to be divided among multiple physical files. For more information, see [Partial](/dotnet/visual-basic/language-reference/modifiers/partial) or [partial (Type)](/dotnet/csharp/language-reference/keywords/partial-type).

The code that defines a TableAdapter is generated every time changes are made to the TableAdapter in the dataset. This code is also generated when changes are made during the running of any wizard that modifies the configuration of the TableAdapter. To prevent your code from being deleted during the regeneration of a TableAdapter, add code to the partial class file of the TableAdapter.

By default, after you separate the dataset and TableAdapter code, the result is a discrete class file in each project. The original project has a file named *DatasetName.Designer.vb* (or *DatasetName.Designer.cs*) that contains the TableAdapter code. The project that's designated in the **Dataset Project** property has a file named *DatasetName.DataSet.Designer.vb* (or *DatasetName.DataSet.Designer.cs*) that contains the dataset code.

> [!NOTE]
> When you separate datasets and TableAdapters (by setting the **DataSet Project** property), existing partial dataset classes in the project will not be moved automatically. Existing partial dataset classes must be moved manually to the dataset project.

> [!NOTE]
> The dataset provides functionality for generating <xref:System.Data.DataTable.ColumnChanging> and <xref:System.Data.DataTable.RowChanging> event handlers when validation is needed. For more information, see [Add validation to an n-tier dataset](../data-tools/add-validation-to-an-n-tier-dataset.md).

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

## To add user code to a TableAdapter in an n-tier application

1. Locate the project that contains the *.xsd* file.

2. Double click the *.xsd* file to open the **Dataset Designer**.

3. Right-click the TableAdapter that you want to add code to, and then select **View Code**.

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

## See also

- [N-Tier data applications overview](../data-tools/n-tier-data-applications-overview.md)
- [Add code to datasets in n-tier applications](../data-tools/add-code-to-datasets-in-n-tier-applications.md)
- [Create and configure TableAdapters](create-and-configure-tableadapters.md)
- [Hierarchical update overview](hierarchical-update.md)
