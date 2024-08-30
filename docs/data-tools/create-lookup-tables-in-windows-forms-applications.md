---
title: Create lookup tables in .NET Framework Windows Forms applications
description: Read how to create lookup tables in Windows Forms applications. A lookup table describes controls that are bound to two related data tables.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- lookup tables
- lookup tables, creating
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Create lookup tables in .NET Framework Windows Forms applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

The term *lookup table* describes controls that are bound to two related data tables. These lookup controls display data from the first table based on a value selected in the second table.

You can create lookup tables by dragging the main node of a parent table (from the [Data Sources window](add-new-data-sources.md#work-with-data-sources-and-windows-forms)) onto a control on your form that is already bound to the column in the related child table.

For example, consider a table of `Orders` in a sales database. Each record in the `Orders` table includes a `CustomerID`, indicating which customer placed the order. The `CustomerID` is a foreign key pointing to a customer record in the `Customers` table. In this scenario, you expand the `Orders` table in the **Data Sources** window and set the main node to **Details**. Then, set the `CustomerID` column to use a <xref:System.Windows.Forms.ComboBox> (or any other control that supports lookup binding), and drag the `Orders` node onto your form. Finally, drag the `Customers` node onto the control that is bound to the related column — in this case, the <xref:System.Windows.Forms.ComboBox> bound to the `CustomerID` column.

## To databind a lookup control

1. With your project open, open the **Data Sources** window by choosing **View** > **Other Windows** > **Data Sources**.

    > [!NOTE]
    > Lookup tables require that two related tables or objects are available in the **Data Sources** window. For more information, see [Relationships in datasets](relationships-in-datasets.md).

2. Expand the nodes in the **Data Sources** window until you can see the parent table and all of its columns, and the related child table and all of its columns.

    > [!NOTE]
    > The child table node is the node that appears as an expandable child node in the parent table.

3. Change the drop type of the child table to **Details** by selecting **Details** from the control list on the child table's node. For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

4. Locate the node that relates the two tables (the `CustomerID` node in the previous example). Change its drop type to a <xref:System.Windows.Forms.ComboBox> by selecting **ComboBox** from the control list.

5. Drag the main child table node from the **Data Sources** window onto your form.

     Databound controls (with descriptive labels) and a tool strip (<xref:System.Windows.Forms.BindingNavigator>) appear on the form. A [DataSet](../data-tools/dataset-tools-in-visual-studio.md), [TableAdapter](../data-tools/create-and-configure-tableadapters.md), <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

6. Now, drag the main parent table node from the **Data Sources** window directly onto the lookup control (the <xref:System.Windows.Forms.ComboBox>).

     The lookup bindings are now established. Refer to the following table for the specific properties that were set on the control.

    |Property|Explanation of setting|
    |--------------| - |
    |**DataSource**|Visual Studio sets this property to the <xref:System.Windows.Forms.BindingSource>, created for the table you drag onto the control (as opposed to the <xref:System.Windows.Forms.BindingSource>, created when the control was created).<br /><br /> If you need to make an adjustment, set this to the <xref:System.Windows.Forms.BindingSource> of the table with the column you want to display.|
    |**DisplayMember**|Visual Studio sets this property to the first column after the primary key that has a string data type for the table you drag onto the control.<br /><br /> If you need to make an adjustment, set this to the column name you want to display.|
    |**ValueMember**|Visual Studio sets this property to the first column participating in the primary key, or the first column in the table if no key is defined.<br /><br /> If you need to make an adjustment, set this to the primary key in the table with the column you want to display.|
    |**SelectedValue**|Visual Studio sets this property to the original column dropped from the **Data Sources** window.<br /><br /> If you need to make an adjustment, set this to the foreign-key column in the related table.|

## Related content

- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
