---
title: Add validation to an n-tier dataset
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "n-tier applications, validating"
  - "validation [Visual Basic], n-tier data applications"
  - "validating n-tier data applications"
ms.assetid: 34ce4db6-09bb-4b46-b435-b2514aac52d3
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Add validation to an n-tier dataset
Adding validation to a dataset that is separated into an n-tier solution is basically the same as adding validation to a single-file dataset (a dataset in a single project). The suggested location for performing validation on data is during the <xref:System.Data.DataTable.ColumnChanging> and/or <xref:System.Data.DataTable.RowChanging> events of a data table.

The dataset provides the functionality to create partial classes to which you can add user code to column- and row-changing events of the data tables in the dataset. For more information about adding code to a dataset in an n-tier solution, see [Add code to datasets in n-tier applications](../data-tools/add-code-to-datasets-in-n-tier-applications.md), and [Add code to TableAdapters in n-tier applications](../data-tools/add-code-to-tableadapters-in-n-tier-applications.md). For more information about partial classes, see [How to: Split a class into partial classes (Class Designer)](../ide/class-designer/how-to-split-a-class-into-partial-classes.md) or [Partial classes and methods](/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods).

> [!NOTE]
> When you separate datasets from TableAdapters (by setting the **DataSet Project** property), existing partial dataset classes in the project won't be moved automatically. Existing partial dataset classes must be moved manually to the dataset project.

> [!NOTE]
> The dataset Designer does not automatically create event handlers in C# for the <xref:System.Data.DataTable.ColumnChanging> and <xref:System.Data.DataTable.RowChanging> events. You have to manually create an event handler and hook up the event handler to the underlying event. The following procedures describe how to create the required event handlers in both Visual Basic and C#.

## Validate changes to individual columns
Validate values in individual columns by handling the <xref:System.Data.DataTable.ColumnChanging> event. The <xref:System.Data.DataTable.ColumnChanging> event is raised when a value in a column is modified. Create an event handler for the <xref:System.Data.DataTable.ColumnChanging> event by double-clicking the desired column on the **Dataset Designer**.

The first time that you double-click a column, the designer generates an event handler for the <xref:System.Data.DataTable.ColumnChanging> event. An `If...Then` statement is also created that tests for the specific column. For example, the following code is generated when you double-click the **RequiredDate** column on the Northwind Orders table:

```vb
Private Sub OrdersDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
    If (e.Column.ColumnName = Me.RequiredDateColumn.ColumnName) Then
        ' Add validation code here.
    End If
End Sub
```

> [!NOTE]
> In C# projects, the Dataset Designer only creates partial classes for the dataset and individual tables in the dataset. The Dataset Designer does not automatically create event handlers for the <xref:System.Data.DataTable.ColumnChanging> and <xref:System.Data.DataTable.RowChanging> events in C# like it does in Visual Basic. In C# projects, you have to manually construct a method to handle the event and hook up the method to the underlying event. The following procedure provides the steps to create the required event handlers in both Visual Basic and C#.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

#### To add validation during changes to individual column values

1. Open the dataset by double-clicking the *.xsd* file in **Solution Explorer**. For more information, see [Walkthrough: Creating a dataset in the Dataset Designer](walkthrough-creating-a-dataset-with-the-dataset-designer.md).

2. Double-click the column you want to validate. This action creates the <xref:System.Data.DataTable.ColumnChanging> event handler.

    > [!NOTE]
    > The Dataset Designer does not automatically create an event handler for the C# event. The code that's necessary to handle the event in C# is included in the next section. `SampleColumnChangingEvent` is created and then hooked up to the <xref:System.Data.DataTable.ColumnChanging> event in the <xref:System.Data.DataTable.EndInit%2A> method.

3. Add code to verify that `e.ProposedValue` contains data that meets the requirements of your application. If the proposed value is unacceptable, set the column to indicate that it contains an error.

     The following code example validates that the **Quantity** column contains a value greater than 0. If **Quantity** is less than or equal to 0, the column is set to an error. The `Else` clause clears the error if **Quantity** is more than 0. The code in the column-changing event handler should resemble the following:

    ```vb
    If (e.Column.ColumnName = Me.QuantityColumn.ColumnName) Then
        If CType(e.ProposedValue, Short) <= 0 Then
            e.Row.SetColumnError(e.Column, "Quantity must be greater than 0")
        Else
            e.Row.SetColumnError(e.Column, "")
        End If
    End If
    ```

    ```csharp
    // Add this code to the DataTable partial class.

    public override void EndInit()
    {
        base.EndInit();
        // Hook up the ColumnChanging event
        // to call the SampleColumnChangingEvent method.
        ColumnChanging += SampleColumnChangingEvent;
    }

    public void SampleColumnChangingEvent(object sender, System.Data.DataColumnChangeEventArgs e)
    {
        if (e.Column.ColumnName == QuantityColumn.ColumnName)
        {
            if ((short)e.ProposedValue <= 0)
            {
                e.Row.SetColumnError("Quantity", "Quantity must be greater than 0");
            }
            else
            {
                e.Row.SetColumnError("Quantity", "");
            }
        }
    }
    ```

## Validate changes to whole rows
Validate values in whole rows by handling the <xref:System.Data.DataTable.RowChanging> event. The <xref:System.Data.DataTable.RowChanging> event is raised when the values in all columns are committed. It is necessary to validate in the <xref:System.Data.DataTable.RowChanging> event when the value in one column relies on the value in another column. For example, consider OrderDate and RequiredDate in the Orders table in Northwind.

When orders are being entered, validation makes sure that an order is not entered with a RequiredDate that is on or before the OrderDate. In this example, the values for both the RequiredDate and OrderDate columns need to be compared, so validating an individual column change does not make sense.

Create an event handler for the <xref:System.Data.DataTable.RowChanging> event by double-clicking the table name in the title bar of the table on the **Dataset Designer**.

#### To add validation during changes to whole rows

1. Open the dataset by double-clicking the *.xsd* file in **Solution Explorer**. For more information, see [Walkthrough: Creating a dataset in the Dataset Designer](walkthrough-creating-a-dataset-with-the-dataset-designer.md).

2. Double-click the title bar of the data table on the designer.

     A partial class is created with a `RowChanging` event handler and opens in the Code Editor.

    > [!NOTE]
    > The Dataset Designer does not automatically create an event handler for the <xref:System.Data.DataTable.RowChanging> event in C# projects. You have to create a method to handle the <xref:System.Data.DataTable.RowChanging> event and run code then hook up the event in the table's initialization method.

3. Add user code inside the partial class declaration.

4. The following code shows where to add user code to validate during the <xref:System.Data.DataTable.RowChanging> event. The C# example also includes code to hook the event handler method up to the `OrdersRowChanging` event.

    ```vb
    Partial Class OrdersDataTable
        Private Sub OrdersDataTable_OrdersRowChanging(ByVal sender As System.Object, ByVal e As OrdersRowChangeEvent) Handles Me.OrdersRowChanging
            ' Add logic to validate columns here.
            If e.Row.RequiredDate <= e.Row.OrderDate Then
                ' Set the RowError if validation fails.
                e.Row.RowError = "Required Date cannot be on or before the OrderDate"
            Else
                ' Clear the RowError when validation passes.
                e.Row.RowError = ""
            End If
        End Sub
    End Class
    ```

    ```csharp
    partial class OrdersDataTable
    {
        public override void EndInit()
        {
            base.EndInit();
            // Hook up the event to the
            // RowChangingEvent method.
            OrdersRowChanging += RowChangingEvent;
        }

        public void RowChangingEvent(object sender, OrdersRowChangeEvent e)
        {
            // Perform the validation logic.
            if (e.Row.RequiredDate <= e.Row.OrderDate)
            {
                // Set the row to an error when validation fails.
                e.Row.RowError = "Required Date cannot be on or before the OrderDate";
            }
            else
            {
                // Clear the RowError if validation passes.
                e.Row.RowError = "";
            }
        }
    }
    ```

## See also

- [N-Tier data applications overview](../data-tools/n-tier-data-applications-overview.md)
- [Walkthrough: Creating an N-Tier data application](../data-tools/walkthrough-creating-an-n-tier-data-application.md)
- [Validate data in datasets](../data-tools/validate-data-in-datasets.md)