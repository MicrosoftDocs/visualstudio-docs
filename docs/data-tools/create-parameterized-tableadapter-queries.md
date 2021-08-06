---
title: Create parameterized TableAdapter queries
description: Understand how to create parameterized TableAdapter queries. A parameterized query returns data that meets the conditions of a WHERE clause within the query.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- data [Visual Studio], TableAdapters
- TableAdapters, parameterized queries
- data [Visual Studio], searching data
- queries [Visual Studio], creating
- TableAdapters, searching data
- queries [Visual Studio], TableAdapters
ms.assetid: 104d1d19-b5a9-4071-b81e-1b3af08e9c7b
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Create parameterized TableAdapter queries

A parameterized query returns data that meets the conditions of a WHERE clause within the query. For example, you can parameterize a customer list to display only customers in a certain city by adding `WHERE City = @City` to the end of the SQL statement that returns a list of customers.

You create parameterized TableAdapter queries in the **Dataset Designer**.You can also create them in a Windows application with the **Parameterize Data Source** command on the **Data** menu. The **Parameterize Data Source** command  creates controls on your form where you can input the parameter values and run the query.

> [!NOTE]
> When constructing a parameterized query, use the parameter notation that's specific to the database you're coding against. For example, Access and OleDb data sources use the question mark '?' to denote parameters, so the WHERE clause would look like this: `WHERE City = ?`.

## Create a parameterized TableAdapter query

### To create a parameterized query in the Dataset Designer

- Create a new TableAdapter, adding a WHERE clause with the desired parameters to the SQL statement. For more information, see [Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md).

     -or-

- Add a query to an existing TableAdapter, adding a WHERE clause with the desired parameters to the SQL statement.

### To create a parameterized query while designing a data-bound form

1. Select a control on your form that is already bound to a dataset. For more information, see [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md).

2. On the **Data** menu, select **Add Query**.

3. Complete the **Search Criteria Builder** dialog box, adding a WHERE clause with the desired parameters to the SQL statement.

### To add a query to an existing data-bound form

1. Open the form in the **Windows Forms Designer**.

2. On the **Data** menu, select **Add Query** or **Data Smart Tags**.

    > [!NOTE]
    > If **Add Query** is not available on the **Data** menu, select a control on the form that displays the data source you want to add the parameterization to. For example, if the form displays data in a <xref:System.Windows.Forms.DataGridView> control, select it. If the form displays data in individual controls, select any data-bound control.

3. In the **Select data source table** area, select the table to which you want to add parameterization.

4. Type a name in the **New query name** box if you are creating a new query.

     -or-

     Select a query in the **Existing query name** box.

5. In the **Query Text** box, type a query that takes parameters.

6. Select **OK**.

     A control to input the parameter and a **Load** button are added to the form in a <xref:System.Windows.Forms.ToolStrip> control.

### Query for null values

TableAdapter parameters can be assigned null values when you want to query for records that have no current value. For example, consider the following query that has a `ShippedDate` parameter in its `WHERE` clause:

```sql
SELECT CustomerID, OrderDate, ShippedDate
FROM Orders
WHERE (ShippedDate = @ShippedDate) OR (ShippedDate IS NULL)
```

If this were a query on a TableAdapter, you could query for all orders that have not been shipped with the following code:

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataTableAdapters/CS/Form2.cs" id="Snippet8":::
:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataTableAdapters/VB/Form2.vb" id="Snippet8":::

To enable a query to accept null values:

1. In the **Dataset Designer**, select the TableAdapter query that needs to accept null parameter values.

2. In the **Properties** window, select **Parameters**, then click the ellipsis (**...**) button to open the **Parameters Collection Editor**.

3. Select the parameter that allows null values and set the **AllowDbNull** property to `true`.

## See also

- [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)
