---
title: "Validate data in datasets | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
f1_keywords:
  - "DataTable.ColumnChanging"
  - "System.Data.DataTable.ColumnChanging"
  - "System.Data.DataTable.RowChanging"
  - "DataTable.RowChanging"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "data validation, datasets"
  - "data validation"
  - "validating data, datasets"
  - "updating datasets, validating data"
ms.assetid: 79500596-1e4d-478e-a991-a636fd73a622
caps.latest.revision: 27
author: jillre
ms.author: jillfra
manager: jillfra
---
# Validate data in datasets
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Validating data is the process of confirming that the values being entered into data objects conform to the constraints within a dataset's schema. The validation process also confirms that these values are following the rules that have been established for your application. It's a good practice to validate data prior to sending updates to the underlying database. This reduces errors as well as the potential number of round trips between an application and the database.

 You can confirm that data that's being written to a dataset is valid by building validation checks into the dataset itself. The dataset can check the data no matter how the update is being performed — whether directly by controls in a form, within a component, or in some other way. Because the dataset is part of your application (unlike the database backend), it's a logical place to build application-specific validation.

 The best place to add validation to your application is in the dataset's partial class file. In [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] or [!INCLUDE[csprcs](../includes/csprcs-md.md)], open the **Dataset Designer** and double-click the column or table for which you want to create validation. This action automatically creates an <xref:System.Data.DataTable.ColumnChanging> or <xref:System.Data.DataTable.RowChanging> event handler. For more information, see [How to: Validate Data During Column Changes](https://msdn.microsoft.com/library/a2680600-67b6-4a40-a77e-b5bc638281c5) or [How to: Validate Data During Row Changes](https://msdn.microsoft.com/library/afc03c77-dfed-4302-9376-929400468ecc). For a complete example, see [Walkthrough: Adding Validation to a Dataset](https://msdn.microsoft.com/library/09351fab-d670-45e3-b53a-a944eff717e7).

## Validate data
 Validation within a dataset can be accomplished in the following ways:

- By creating your own application-specific validation that can check values in an individual data column during changes.  For more information, see [How to: Validate Data During Column Changes](https://msdn.microsoft.com/library/a2680600-67b6-4a40-a77e-b5bc638281c5).

- By creating your own application-specific validation that can check data to values while an entire data row is changing. For more information, see [How to: Validate Data During Row Changes](https://msdn.microsoft.com/library/afc03c77-dfed-4302-9376-929400468ecc).

- By creating keys, unique constraints, and so on as part of the actual schema definition of the dataset. For more information about incorporating validation into the schema definition, see [Constraining a DataColumn to Contain Unique Values](https://msdn.microsoft.com/library/8ca21f77-b99a-47a7-a656-7cfd7a1bd9df).

- By setting the properties of the <xref:System.Data.DataColumn> object's,  such as <xref:System.Data.DataColumn.MaxLength%2A>, <xref:System.Data.DataColumn.AllowDBNull%2A>, and <xref:System.Data.DataColumn.Unique%2A>.

  Several events are raised by the <xref:System.Data.DataTable> object when a change is occurring in a record:

- The <xref:System.Data.DataTable.ColumnChanging> and <xref:System.Data.DataTable.ColumnChanged> events are raised during and after each change to an individual column. The <xref:System.Data.DataTable.ColumnChanging> event is useful when you want to validate changes in specific columns. Information about the proposed change is passed as an argument with the event. For more information, see [How to: Validate Data During Column Changes](https://msdn.microsoft.com/library/a2680600-67b6-4a40-a77e-b5bc638281c5).

- The <xref:System.Data.DataTable.RowChanging> and <xref:System.Data.DataTable.RowChanged> events are raised during and after any change in a row. The <xref:System.Data.DataTable.RowChanging> event is more general. It  indicates that a change is occurring somewhere in the row, but you don't know which column has changed. For more information, see [How to: Validate Data During Row Changes](https://msdn.microsoft.com/library/afc03c77-dfed-4302-9376-929400468ecc).

  By default, each change to a column therefore raises four events. The first is the <xref:System.Data.DataTable.ColumnChanging> and <xref:System.Data.DataTable.ColumnChanged> events for the specific column that's being changed. Next are the <xref:System.Data.DataTable.RowChanging> and <xref:System.Data.DataTable.RowChanged> events. If multiple changes are being made to the row, the events will be raised for each change.

> [!NOTE]
> The data row's <xref:System.Data.DataRow.BeginEdit%2A> method turns off the <xref:System.Data.DataTable.RowChanging> and <xref:System.Data.DataTable.RowChanged> events after each individual column change. In that case, the event is not raised until the <xref:System.Data.DataRow.EndEdit%2A> method has been called, when the <xref:System.Data.DataTable.RowChanging> and <xref:System.Data.DataTable.RowChanged> events are raised just once. For more information, see [Turn off constraints while filling a dataset](../data-tools/turn-off-constraints-while-filling-a-dataset.md).

 The event you choose depends on how granular you want the validation to be. If it's important that you catch an error immediately when a column changes, build validation by using the <xref:System.Data.DataTable.ColumnChanging> event. Otherwise, use the <xref:System.Data.DataTable.RowChanging> event, which might result in catching several errors at once. Additionally, if your data is structured  so that the value of one column is validated based on the contents of another column, then perform your validation during the <xref:System.Data.DataTable.RowChanging> event.

 When records are updated, the <xref:System.Data.DataTable> object raises events that you can respond to as changes are occurring and after changes are made.

 If your application uses a typed dataset, you can create strongly typed event handlers. This will add four additional typed events that you can create handlers for: `dataTableNameRowChanging`, `dataTableNameRowChanged`, `dataTableNameRowDeleting`, and `dataTableNameRowDeleted`. These typed event handlers pass an argument that includes the column names of your table that make code easier to write and read.

## Data update events

|Event|Description|
|-----------|-----------------|
|<xref:System.Data.DataTable.ColumnChanging>|The value in a column is being changed. The event passes the row and column to you, along with the proposed new value.|
|<xref:System.Data.DataTable.ColumnChanged>|The value in a column has been changed. The event passes the row and column to you, along with the proposed value.|
|<xref:System.Data.DataTable.RowChanging>|The changes that were made to a <xref:System.Data.DataRow> object are about to be committed back into the dataset. If you have not called the <xref:System.Data.DataRow.BeginEdit%2A> method, the <xref:System.Data.DataTable.RowChanging> event is raised for each change to a column immediately after the <xref:System.Data.DataTable.ColumnChanging> event has been raised. If you called <xref:System.Data.DataRow.BeginEdit%2A> before making changes, the <xref:System.Data.DataTable.RowChanging> event is raised only when you call the <xref:System.Data.DataRow.EndEdit%2A> method.<br /><br /> The event passes the row to you, along with a value indicating what type of action (change, insert, and so on) is being performed.|
|<xref:System.Data.DataTable.RowChanged>|A row has been changed. The event passes the row to you, along with a value indicating what type of action (change, insert, and so on) is being performed.|
|<xref:System.Data.DataTable.RowDeleting>|A row is being deleted. The event passes the row to you, along with a value indicating what type of action (delete) is being performed.|
|<xref:System.Data.DataTable.RowDeleted>|A row has been deleted. The event passes the row to you, along with a value indicating what type of action (delete) is being performed.|

 The <xref:System.Data.DataTable.ColumnChanging>, <xref:System.Data.DataTable.RowChanging>, and <xref:System.Data.DataTable.RowDeleting> events are raised during the update process. You can use these events to validate data or perform other types of processing. Because the update is in process during these events, you can cancel it by throwing an exception, which prevents the update from finishing.

 The <xref:System.Data.DataTable.ColumnChanged>, <xref:System.Data.DataTable.RowChanged> and <xref:System.Data.DataTable.RowDeleted> events are notification events that are raised when the update has finished successfully. These events are useful when you want to take further action based on a successful update.

## Validate data during column changes

> [!NOTE]
> The **Dataset Designer** creates a partial class in which validation logic can be added to a dataset. The designer-generated dataset doesn't delete or change any code in the partial class.

 You can validate data when the value in a data column changes by responding to the <xref:System.Data.DataTable.ColumnChanging> event. When raised, this event passes an event argument (<xref:System.Data.DataColumnChangeEventArgs.ProposedValue%2A>) that contains the value that's being proposed for the current column. Based on the contents of `e.ProposedValue`, you can:

- Accept the proposed value by doing nothing.

- Reject the proposed value by setting the column error (<xref:System.Data.DataRow.SetColumnError%2A>) from within the column-changing event handler.

- Optionally use an <xref:System.Windows.Forms.ErrorProvider> control to display an error message to the user. For more information, see [ErrorProvider Component](https://msdn.microsoft.com/library/c0f2e231-c5c9-413d-a507-75af2db499b6).

  Validation can also be performed during the <xref:System.Data.DataTable.RowChanging> event. For more information, see [How to: Validate Data During Row Changes](https://msdn.microsoft.com/library/afc03c77-dfed-4302-9376-929400468ecc).

## Validate data during row changes
 You can write code to verify that each column you want to validate contains data that meets the requirements of your application. Do this by setting the column to indicate that it contains an error if a proposed value is unacceptable. The following examples set a column error when the `Quantity` column is 0 or less. The row-changing event handlers should resemble the following examples.

#### To validate data when a row changes (Visual Basic)

1. Open your dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](https://msdn.microsoft.com/library/36fc266f-365b-42cb-aebb-c993dc2c47c3).

2. Double-click the title bar of the table you want to validate. This action automatically creates the <xref:System.Data.DataTable.RowChanging> event handler of the <xref:System.Data.DataTable> in the dataset's partial-class file.

    > [!TIP]
    > Double-click to the left of the table name to create the row-changing event handler. If you double-click the table name, you can edit it.

     [!code-vb[VbRaddataValidating#3](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataValidating/VB/NorthwindDataSet.vb#3)]

#### To validate data when a row changes (C#)

1. Open your dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](https://msdn.microsoft.com/library/36fc266f-365b-42cb-aebb-c993dc2c47c3).

2. Double-click the title bar of the table you want to validate. This action creates a partial-class file for the <xref:System.Data.DataTable>.

    > [!NOTE]
    > The **Dataset Designer** does not automatically create an event handler for the <xref:System.Data.DataTable.RowChanging> event. You have to create a method to handle the <xref:System.Data.DataTable.RowChanging> event, and run code to hook up the event in the table's initialization method.

3. Copy the following code into the partial class:

    ```
    public override void EndInit()
    {
        base.EndInit();
        Order_DetailsRowChanging += TestRowChangeEvent;
    }

    public void TestRowChangeEvent(object sender, Order_DetailsRowChangeEvent e)
    {
        if ((short)e.Row.Quantity <= 0)
        {
            e.Row.SetColumnError("Quantity", "Quantity must be greater than 0");
        }
        else
        {
            e.Row.SetColumnError("Quantity", "");
        }
    }
    ```

## To retrieve changed rows
 Each row in a data table has a <xref:System.Data.DataRow.RowState%2A> property that keeps track of the current state of that row by using the values in the <xref:System.Data.DataRowState> enumeration. You can return changed rows from a dataset or data table by calling the `GetChanges` method of a <xref:System.Data.DataSet> or <xref:System.Data.DataTable>. You can verify that changes exist prior to calling `GetChanges` by calling the <xref:System.Data.DataSet.HasChanges%2A> method of a dataset. For more information about <xref:System.Data.DataSet.HasChanges%2A>, see [How to: Check for Changed Rows](https://msdn.microsoft.com/library/af160d20-472b-4c13-8f15-75480c39a653).

> [!NOTE]
> After you commit changes to a dataset or data table (by calling the <xref:System.Data.DataSet.AcceptChanges%2A> method), the `GetChanges` method returns no data. If your application needs to process changed rows, you must process the changes before calling the `AcceptChanges` method.

 Calling the <xref:System.Data.DataSet.GetChanges%2A> method of a dataset or data table returns a new dataset or data table that contains only records that have been changed. If you want to get specific records — for example, only new records or only modified records — you can pass a value from the <xref:System.Data.DataRowState> enumeration as a parameter to the `GetChanges` method.

 Use the <xref:System.Data.DataRowVersion> enumeration to access the different versions of a row (for example, the original values that were in a row prior to processing it).

#### To get all changed records from a dataset

- Call the <xref:System.Data.DataSet.GetChanges%2A> method of a dataset.

     The following example creates a new dataset called `changedRecords` and populates it with all the changed records from another dataset called `dataSet1`.

     [!code-csharp[VbRaddataEditing#14](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs#14)]
     [!code-vb[VbRaddataEditing#14](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb#14)]

#### To get all changed records from a data table

- Call the <xref:System.Data.DataTable.GetChanges%2A> method of a DataTable.

     The following example creates a new data table called `changedRecordsTable` and populates it with all the changed records from another data table called `dataTable1`.

     [!code-csharp[VbRaddataEditing#15](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs#15)]
     [!code-vb[VbRaddataEditing#15](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb#15)]

#### To get all records that have a specific row state

- Call the `GetChanges` method of a dataset or data table and pass a <xref:System.Data.DataRowState> enumeration value as an argument.

     The following example shows how to create a new dataset called `addedRecords` and populate it only with records that have been added to the `dataSet1` dataset.

     [!code-csharp[VbRaddataEditing#16](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs#16)]
     [!code-vb[VbRaddataEditing#16](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb#16)]

- The following example shows how to return all records that were recently added to the `Customers` table:

     [!code-csharp[VbRaddataEditing#17](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs#17)]
     [!code-vb[VbRaddataEditing#17](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb#17)]

## Access the original version of a DataRow
 When changes are made to data rows, the dataset retains both the original (<xref:System.Data.DataRowVersion>) and new (<xref:System.Data.DataRowVersion>) versions of the row. For example, before calling the `AcceptChanges` method, your application can access the different versions of a record (as defined in the <xref:System.Data.DataRowVersion> enumeration) and process the changes accordingly.

> [!NOTE]
> Different versions of a row exist only after it has been edited and before it the `AcceptChanges` method has been called. After the `AcceptChanges` method has been called, the current and original versions are the same.

 Passing the <xref:System.Data.DataRowVersion> value along with the column index (or column name as a string) returns the value from that column's particular row version. The changed column is identified during the <xref:System.Data.DataTable.ColumnChanging> and <xref:System.Data.DataTable.ColumnChanged> events. This is a good time to inspect the different row versions for validation purposes. However, if you have temporarily suspended constraints, those events won't be raised, and you will need to programmatically identify which columns have changed. You can do this by iterating through the <xref:System.Data.DataTable.Columns%2A> collection and comparing the different <xref:System.Data.DataRowVersion> values.

#### To get the original version of a record

- Access the value of a column by passing in the <xref:System.Data.DataRowVersion> of the row you want to return.

     The following example shows how to use a <xref:System.Data.DataRowVersion> value to get the original value of a `CompanyName` field in a <xref:System.Data.DataRow>:

     [!code-csharp[VbRaddataEditing#21](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs#21)]
     [!code-vb[VbRaddataEditing#21](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb#21)]

## Access the current version of a DataRow

#### To get the current version of a record

- Access the value of a column, and then add a parameter to the index that indicates which version of a row you want to return.

     The following example shows how to use a <xref:System.Data.DataRowVersion> value to get the current value of a `CompanyName` field in a <xref:System.Data.DataRow>:

     [!code-csharp[VbRaddataEditing#22](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs#22)]
     [!code-vb[VbRaddataEditing#22](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb#22)]

## See also

- [How to: Validate Data in the Windows Forms DataGridView Control](https://msdn.microsoft.com/library/d10aef35-701e-4a3c-a684-2a2ed1aeaca6)
- [How to: Display Error Icons for Form Validation with the Windows Forms ErrorProvider Component](https://msdn.microsoft.com/library/3b681a32-9db4-497b-a34b-34980eabee46)