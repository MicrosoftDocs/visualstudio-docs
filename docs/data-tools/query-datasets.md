---
title: Query ADO.NET datasets (.NET Framework)
description: Query ADO.NET datasets in .NET Framework application development with Visual Studio and find a specific row, rows by column values, and related records.
ms.date: 11/01/2023
ms.topic: how-to
dev_langs:
- VB
- CSharp
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Query datasets in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

To search for specific records in a dataset, use the `FindBy` method on the DataTable, write your own foreach statement to loop over the table's Rows collection, or use [LINQ to DataSet](/dotnet/framework/data/adonet/linq-to-dataset).

## Dataset case sensitivity

Within a dataset, table and column names are case-insensitive by default — that is, a table in a dataset called "Customers" can also be referred to as "Customers." This matches the naming conventions in many databases, including SQL Server. In SQL Server, the default behavior is that the names of data elements cannot be distinguished only by case.

> [!NOTE]
> Unlike datasets, XML documents are case-sensitive, so the names of data elements defined in schemas are case-sensitive. For example, schema protocol allows the schema to define a table called `Customers` and a different table called `customers`. This can result in name collisions when a schema that contains elements that differ only by case is used to generate a dataset class.

Case sensitivity, however, can be a factor in how data is interpreted within the dataset. For example, if you filter data in a dataset table, the search criteria might return different results depending on whether the comparison is case-sensitive. You can control the case sensitivity of filtering, searching, and sorting by setting the dataset's <xref:System.Data.DataSet.CaseSensitive%2A> property. All the tables in the dataset inherit the value of this property by default. (You can override this property for each individual table by setting the table's <xref:System.Data.DataTable.CaseSensitive%2A> property.)

## Locate a specific row in a data table

#### To find a row in a typed dataset with a primary key value

- To locate a row, call the strongly typed `FindBy` method that uses the table's primary key.

     In the following example, the `CustomerID` column is the primary key of the `Customers` table. This means that the generated `FindBy` method is `FindByCustomerID`. The example shows how to assign a specific <xref:System.Data.DataRow> to a variable by using the generated `FindBy` method.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs" id="Snippet18":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb" id="Snippet18":::
     ---

#### To find a row in an untyped dataset with a primary key value

- Call the <xref:System.Data.DataRowCollection.Find%2A> method of a <xref:System.Data.DataRowCollection> collection, passing the primary key as a parameter.

     The following example shows how to declare a new row called `foundRow` and assign it the return value of the <xref:System.Data.DataRowCollection.Find%2A> method. If the primary key is found, the contents of column index 1 are displayed in a message box.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs" id="Snippet19":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb" id="Snippet19":::
     ---

## Find rows by column values

#### To find rows based on the values in any column

- Data tables are created with the <xref:System.Data.DataTable.Select%2A> method, which returns an array of <xref:System.Data.DataRow>s based on the expression passed to the <xref:System.Data.DataTable.Select%2A> method. For more information about creating valid expressions, see the "Expression Syntax" section of the page about the <xref:System.Data.DataColumn.Expression%2A> property.

     The following example shows how to use the <xref:System.Data.DataTable.Select%2A> method of the <xref:System.Data.DataTable> to locate specific rows.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs" id="Snippet20":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb" id="Snippet20":::
     ---

## Access related records

When tables in a dataset are related, a <xref:System.Data.DataRelation> object can make the related records available in another table. For example, a dataset containing `Customers` and `Orders` tables can be made available.

You can use a <xref:System.Data.DataRelation> object to locate related records by calling the <xref:System.Data.DataRow.GetChildRows%2A> method of a <xref:System.Data.DataRow> in the parent table. This method returns an array of related child records. Or, you can call the <xref:System.Data.DataRow.GetParentRow%2A> method of a <xref:System.Data.DataRow> in the child table. This method returns a single <xref:System.Data.DataRow> from the parent table.

This page provides examples using typed datasets. For information about navigating relationships in untyped datasets, see [Navigating DataRelations](/dotnet/framework/data/adonet/dataset-datatable-dataview/navigating-datarelations).

> [!NOTE]
> If you are working in a Windows Forms application and using the data-binding features to display data, the designer-generated form might provide enough functionality for your application. For more information, see [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md). Specifically, see [Relationships in Datasets](relationships-in-datasets.md).

The following code examples demonstrate how to navigate up and down relationships in typed datasets. The code examples use typed <xref:System.Data.DataRow>s (`NorthwindDataSet.OrdersRow`) and the generated FindBy*PrimaryKey* (`FindByCustomerID`) methods to locate a desired row and return the related records. The examples compile and run correctly only if you have:

- An instance of a dataset named `NorthwindDataSet` with a `Customers` table.

- An `Orders` table.

- A relationship named `FK_Orders_Customers` relating the two tables.

Additionally, both tables need to be filled with data for any records to be returned.

#### To return the child records of a selected parent record

- Call the <xref:System.Data.DataRow.GetChildRows%2A> method of a specific `Customers` data row, and return an array of rows from the `Orders` table:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDatasets/CS/Form1.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDatasets/VB/Form1.vb" id="Snippet6":::
     ---

#### To return the parent record of a selected child record

- Call the <xref:System.Data.DataRow.GetParentRow%2A> method of a specific `Orders` data row, and return a single row from the `Customers` table:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDatasets/CS/Form1.cs" id="Snippet7":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDatasets/VB/Form1.vb" id="Snippet7":::
     ---

## Related content

- [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)
