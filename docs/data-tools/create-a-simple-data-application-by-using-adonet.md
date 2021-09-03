---
title: Create a simple data application by using ADO.NET
description: Learn to create a simple forms-to-data application by using Windows Forms and ADO.NET in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 08/23/2017
ms.topic: conceptual
dev_langs:
- VB
- CSharp
ms.assetid: 2222841f-e443-4a3d-8c70-4506aa905193
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Create a simple data application by using ADO.NET

When you create an application that manipulates data in a database, you perform basic tasks such as defining connection strings, inserting data, and running stored procedures. By following this topic, you can discover how to interact with a database from within a simple Windows Forms "forms over data" application by using Visual C# or Visual Basic and ADO.NET.  All .NET data technologies—including datasets, LINQ to SQL, and Entity Framework—ultimately perform steps that are very similar to those shown in this article.

This article demonstrates a simple way to get data out of a database in a fast manner. If your application needs to modify data in non-trivial ways and update the database, you should consider using Entity Framework and using data binding to automatically sync user interface controls to changes in the underlying data.

> [!IMPORTANT]
> To keep the code simple, it doesn't include production-ready exception handling.

## Prerequisites

To create the application, you'll need:

- Visual Studio.

- SQL Server Express LocalDB. If you don't have SQL Server Express LocalDB, you can install it from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express).

This topic assumes that you're familiar with the basic functionality of the Visual Studio IDE and can create a Windows Forms application, add forms to the project, put buttons and other controls on the forms, set properties of the controls, and code simple events. If you aren't comfortable with these tasks, we suggest that you complete the [Getting started with Visual C# and Visual Basic](../ide/quickstart-visual-basic-console.md) topic before you start this walkthrough.

## Set up the sample database

Create the sample database by following these steps:

1. In Visual Studio, open the **Server Explorer** window.

2. Right-click on **Data Connections** and choose **Create New SQL Server Database**.

3. In the **Server name** text box, enter **(localdb)\mssqllocaldb**.

4. In the **New database name** text box, enter **Sales**, then choose **OK**.

     The empty **Sales** database is created and added to the Data Connections node in Server Explorer.

5. Right-click on the **Sales** data connection and select **New Query**.

     A query editor window opens.

6. Copy the [Sales Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/raw/master/docs/data-tools/samples/sales.sql) to your clipboard.

7. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

     After a short time, the query finishes running and the database objects are created. The database contains two tables: Customer and Orders. These tables contain no data initially, but you can add data when you run the application that you'll create. The database also contains four simple stored procedures.

## Create the forms and add controls

1. Create a project for a Windows Forms application, and then name it **SimpleDataApp**.

    Visual Studio creates the project and several files, including an empty Windows form that's named **Form1**.

2. Add two Windows forms to your project so that it has three forms, and then give them the following names:

   - **Navigation**

   - **NewCustomer**

   - **FillOrCancel**

3. For each form, add the text boxes, buttons, and other controls that appear in the following illustrations. For each control, set the properties that the tables describe.

   > [!NOTE]
   > The group box and the label controls add clarity but aren't used in the code.

   **Navigation form**

   ![Navigation dialog box](../data-tools/media/simpleappnav.png)

|Controls for the Navigation form|Properties|
| - |----------------|
|Button|Name = btnGoToAdd|
|Button|Name = btnGoToFillOrCancel|
|Button|Name = btnExit|

**NewCustomer form**

![Add  a new customer and place an order](../data-tools/media/simpleappnewcust.png)

|Controls for the NewCustomer form|Properties|
| - |----------------|
|TextBox|Name = txtCustomerName|
|TextBox|Name = txtCustomerID<br /><br /> Readonly = True|
|Button|Name = btnCreateAccount|
|NumericUpdown|DecimalPlaces = 0<br /><br /> Maximum = 5000<br /><br /> Name = numOrderAmount|
|DateTimePicker|Format = Short<br /><br /> Name = dtpOrderDate|
|Button|Name = btnPlaceOrder|
|Button|Name = btnAddAnotherAccount|
|Button|Name = btnAddFinish|

**FillOrCancel form**

![fill or cancel orders](../data-tools/media/simpleappcancelfill.png)

|Controls for the FillOrCancel form|Properties|
| - |----------------|
|TextBox|Name = txtOrderID|
|Button|Name = btnFindByOrderID|
|DateTimePicker|Format = Short<br /><br /> Name = dtpFillDate|
|DataGridView|Name = dgvCustomerOrders<br /><br /> Readonly = True<br /><br /> RowHeadersVisible = False|
|Button|Name = btnCancelOrder|
|Button|Name = btnFillOrder|
|Button|Name = btnFinishUpdates|

## Store the connection string
When your application tries to open a connection to the database, your application must have access to the connection string. To avoid entering the string manually on each form, store the string in the *App.config* file in your project, and create a method that returns the string when the method is called from any form in your application.

You can find the connection string by right-clicking on the **Sales** data connection in **Server Explorer** and choosing **Properties**. Locate the **ConnectionString** property, then use **Ctrl**+**A**, **Ctrl**+**C** to select and copy the string to the clipboard.

1. If you're using C#, in **Solution Explorer**, expand the **Properties** node under the project, and then open the **Settings.settings** file.
    If you're using Visual Basic, in **Solution Explorer**, click **Show All Files**, expand the **My Project** node, and then open the **Settings.settings** file.

2. In the **Name** column, enter `connString`.

3. In the **Type** list, select **(Connection String)**.

4. In the **Scope** list, select **Application**.

5. In the **Value** column, enter your connection string (without any outside quotes), and then save your changes.

> [!NOTE]
> In a real application, you should store the connection string securely, as described in [Connection strings and configuration files](/dotnet/framework/data/adonet/connection-strings-and-configuration-files).

## Write the code for the forms

This section contains brief overviews of what each form does. It also provides the code that defines the underlying logic when a button on the form is clicked.

### Navigation form

The Navigation form opens when you run the application. The **Add an account** button opens the NewCustomer form. The **Fill or cancel orders** button opens the FillOrCancel form. The **Exit** button closes the application.

#### Make the Navigation form the startup form

If you're using C#, in **Solution Explorer**, open **Program.cs**, and then change the `Application.Run` line to this: `Application.Run(new Navigation());`

If you're using Visual Basic, in **Solution Explorer**, open the **Properties** window, select the **Application** tab, and then select **SimpleDataApp.Navigation** in the **Startup form** list.

#### Create auto-generated event handlers

Double-click the three buttons on the Navigation form to create empty event handler methods. Double-clicking the buttons also adds auto-generated code in the Designer code file that enables a button click to raise an event.

#### Add code for the Navigation form logic

In the code page for the Navigation form, complete the method bodies for the three button click event handlers as shown in the following code.

:::code language="csharp" source="../data-tools/codesnippet/CSharp/SimpleDataApp/Navigation.cs" id="Snippet1":::
:::code language="vb" source="../data-tools/codesnippet/VisualBasic/SimpleDataApp/Navigation.vb" id="Snippet1":::

### NewCustomer form

When you enter a customer name and then select the **Create Account** button, the NewCustomer form creates a customer account, and SQL Server returns an IDENTITY value as the new customer ID. You can then place an order for the new account by specifying an amount and an order date and selecting the **Place Order** button.

#### Create auto-generated event handlers

Create an empty Click event handler for each button on the NewCustomer form by double-clicking on each of the four buttons. Double-clicking the buttons also adds auto-generated code in the Designer code file that enables a button click to raise an event.

#### Add code for the NewCustomer form logic

To complete the NewCustomer form logic, follow these steps.

1. Bring the `System.Data.SqlClient` namespace into scope so that you don't have to fully qualify the names of its members.

     ```csharp
     using System.Data.SqlClient;
     ```

     ```vb
     Imports System.Data.SqlClient
     ```

2. Add some variables and helper methods to the class as shown in the following code.

     :::code language="csharp" source="../data-tools/codesnippet/CSharp/SimpleDataApp/NewCustomer.cs" id="Snippet1":::
     :::code language="vb" source="../data-tools/codesnippet/VisualBasic/SimpleDataApp/NewCustomer.vb" id="Snippet1":::

3. Complete the method bodies for the four button click event handlers as shown in the following code.

     :::code language="csharp" source="../data-tools/codesnippet/CSharp/SimpleDataApp/NewCustomer.cs" id="Snippet2":::
     :::code language="vb" source="../data-tools/codesnippet/VisualBasic/SimpleDataApp/NewCustomer.vb" id="Snippet2":::

### FillOrCancel form

The FillOrCancel form runs a query to return an order when you enter an order ID and then click the **Find Order** button. The returned row appears in a read-only data grid. You can mark the order as canceled (X) if you select the **Cancel Order** button, or you can mark the order as filled (F) if you select the **Fill Order** button. If you select the **Find Order** button again, the updated row appears.

#### Create auto-generated event handlers

Create empty Click event handlers for the four buttons on the FillOrCancel form by double-clicking the buttons. Double-clicking the buttons also adds auto-generated code in the Designer code file that enables a button click to raise an event.

#### Add code for the FillOrCancel form logic

To complete the FillOrCancel form logic, follow these steps.

1. Bring the following two namespaces into scope so that you don't have to fully qualify the names of their members.

     ```csharp
     using System.Data.SqlClient;
     using System.Text.RegularExpressions;
     ```

     ```vb
     Imports System.Data.SqlClient
     Imports System.Text.RegularExpressions
     ```

2. Add a variable and helper method to the class as shown in the following code.

     :::code language="csharp" source="../data-tools/codesnippet/CSharp/SimpleDataApp/FillOrCancel.cs" id="Snippet1":::
     :::code language="vb" source="../data-tools/codesnippet/VisualBasic/SimpleDataApp/FillOrCancel.vb" id="Snippet1":::

3. Complete the method bodies for the four button click event handlers as shown in the following code.

     :::code language="csharp" source="../data-tools/codesnippet/CSharp/SimpleDataApp/FillOrCancel.cs" id="Snippet2":::
     :::code language="vb" source="../data-tools/codesnippet/VisualBasic/SimpleDataApp/FillOrCancel.vb" id="Snippet2":::

## Test your application

Select the **F5** key to build and test your application after you code each Click event handler, and then after you finish coding.

## See also

- [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)
