---
title: Create a .NET Framework data app by using ADO.NET
description: Create a forms-over-data .NET Framework application with Visual C# or Visual Basic by using Windows Forms and ADO.NET in Visual Studio.
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
ms.topic: how-to
ms.date: 02/24/2025
dev_langs:
- VB
- CSharp

# Customer intent: As a developer, I want to understand how to create a .NET Framework Windows Forms application using ADO.NET with Visual C# or Visual Basic in Visual Studio.
---

# Create a basic data application by using ADO.NET

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

When you create an application that manipulates data in a database, you typically perform tasks such as defining connection strings, inserting data, and running stored procedures. As you follow this article, you can discover how to interact with a database from within a *forms over data* (FOD) Windows Forms application by using Visual C# or Visual Basic and ADO.NET. All .NET data technologies, including datasets, LINQ (Language-Integrated Query) to SQL, and Entity Framework, ultimately perform steps that are similar to those steps shown in this article.

This article demonstrates how to quickly get data out of a database. If your application needs to modify data in nontrivial ways and update the database, consider using Entity Framework and data binding. Doing so allows your user interface controls to automatically sync to changes in the underlying data.

To access the complete code for this tutorial, see the Visual Studio docs GitHub repo for [C#](https://github.com/MicrosoftDocs/visualstudio-docs/tree/main/docs/data-tools/codesnippet/CSharp/SimpleDataApp) and [Visual Basic](https://github.com/MicrosoftDocs/visualstudio-docs/tree/main/docs/data-tools/codesnippet/VisualBasic/SimpleDataApp).

> [!IMPORTANT]
> To keep the code simple, it doesn't include production-ready exception handling.

## Prerequisites

- Visual Studio with the **.NET desktop development** and **Data storage and processing** workloads installed. To install them, open Visual Studio Installer and choose **Modify** next to the version of Visual Studio you want to modify.

- SQL Server Express LocalDB. If you don't have SQL Server Express LocalDB, you can install it from the [SQL Server download page](https://www.microsoft.com/sql-server/sql-server-downloads).

This article assumes that you're familiar with the basic functionality of the Visual Studio IDE. It also assumes that you can create a Windows Forms application, add forms to a project, add buttons and other controls to the forms, set control properties, and code simple events. If you aren't comfortable with these tasks, complete the [Create a Windows Forms app in Visual Studio with C# tutorial](../ide/create-csharp-winform-visual-studio.md) or the [Create a Windows Forms app in Visual Studio with Visual Basic tutorial](../ide/create-a-visual-basic-winform-in-visual-studio.md) before you start this walkthrough.

## Set up the sample database

Create the sample database by following these steps:

1. In Visual Studio, open the **Server Explorer** window.

1. Right-click **Data Connections** and choose **Create New SQL Server Database**.

1. For **Server name**, enter **(localdb)\mssqllocaldb**.

1. For **New database name**, enter **Sales**, and then choose **OK**.

     Visual Studio creates an empty **Sales** database under the **Data Connections** node in Server Explorer.

1. Right-click the **Sales** data connection and select **New Query**.

     A query editor window opens.

1. Copy the [Sales Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/raw/main/docs/data-tools/samples/sales.sql) to your clipboard.

1. Paste the T-SQL script into the query editor window, and then select **Execute**.

     After a short time, the query finishes running and the database objects are created. The database contains two tables: Customer and Orders. These tables contain no data initially, but you can add data when you run the application that you create. The database also contains five basic stored procedures.

## Create the forms and add controls

1. Create a C# or Visual Basic project with the **Windows Forms App (.NET Framework)** template and name it **SimpleDataApp**.

    Visual Studio creates the project and several files, including an empty Windows form named **Form1**.

1. In **Solution Explorer**, add two Windows forms to your project so that it has a total of three forms, and give them the following names:

   - **Navigation**

   - **NewCustomer**

   - **FillOrCancel**

1. For each form, add the text boxes, buttons, and other controls shown in the following illustrations. For each control, set the properties that the tables describe.

   > [!NOTE]
   > The group box and the label controls add clarity, but aren't used in the code.

   **Navigation form**

   :::image type="content" source="../data-tools/media/simpleappnav.png" alt-text="Screenshot that shows the Navigation form details.":::

   **Controls for the Navigation form**

   |Control text|Control type|Control properties|
   |------------|------------|------------|
   |Add an account|Button|Name = btnGoToAdd|
   |Fill or cancel an order |Button|Name = btnGoToFillOrCancel|
   |Exit|Button|Name = btnExit|

   **NewCustomer form**

   :::image type="content" source="../data-tools/media/simpleappnewcust.png" alt-text="Screenshot that shows the NewCustomer form details.":::

   **Controls for the NewCustomer form**

   |Label/Control text|Control type|Control properties|
   |------------|------------|------------------|
   |Customer name|TextBox|Name = txtCustomerName|
   |Customer ID|TextBox|Name = txtCustomerID<br /> ReadOnly = True|
   |Create account|Button|Name = btnCreateAccount|
   |Order amount|NumericUpdown|Name = numOrderAmount<br /> DecimalPlaces = 0<br /> Maximum = 5000|
   |Order date|DateTimePicker|Name = dtpOrderDate<br /> Format = Short|
   |Place order|Button|Name = btnPlaceOrder|
   |Finish |Button|Name = btnAddFinish|
   |Add another account|Button|Name = btnAddAnotherAccount|

   **FillOrCancel form**

   :::image type="content" source="../data-tools/media/simpleappcancelfill.png" alt-text="Screenshot that shows the FillOrCancel form details.":::

   **Controls for the FillOrCancel form**

   |Label/Control text|Control type|Control properties|
   |------------------|------------|------------------|
   |Order ID|TextBox|Name = txtOrderID|
   |Find order|Button|Name = btnFindByOrderID|
   |If filling an order...|DateTimePicker|Name = dtpFillDate<br /> Format = Short |
   |(None)|DataGridView|Name = dgvCustomerOrders<br /> ReadOnly = True<br /> RowHeadersVisible = False|
   |Cancel order|Button|Name = btnCancelOrder|
   |Fill order|Button|Name = btnFillOrder|
   |Finish|Button|Name = btnFinishUpdates|

## Store the connection string

When your application tries to open a connection to the database, your application must have access to the connection string. To avoid the need to enter the string manually on each form, store the string in the *App.config* file in your project. Then, create a method that returns the string when the method is called from any form in your application.

To find the connection string:

1. In Server Explorer, right-click the **Sales** data connection, and then choose **Properties**.

1. Locate the **Connection String** property and copy its string value to the clipboard.

To store the connection string in your project:

1. In **Solution Explorer**, do one of the following steps, depending on your project type:

   - For a C# project, expand the **Properties** node under the project, and then open the **Settings.settings** file.

   - For a Visual Basic project, select **Show All Files**, expand the **My Project** node, and then open the **Settings.settings** file.

1. In the **Name** column, enter **connString**.

1. In the **Type** list, select **(Connection string)**.

1. In the **Scope** list, select **Application**.

1. In the **Value** column, enter your connection string (without any outside quotes), and then save your changes.

   :::image type="content" source="media/vs-2022/simple-data-app-settings.png" alt-text="Screenshot that shows the Connection String data in Settings.settings." lightbox="media/vs-2022/simple-data-app-settings.png":::

> [!CAUTION]
> In a real application, you should store the connection string securely, as described in [Connection strings and configuration files](/dotnet/framework/data/adonet/connection-strings-and-configuration-files). For best security, use an authentication method that doesn't rely on storing a password in the connection string. For example, Windows Authentication for an on-premises SQL Server database. For more information, see [Save and edit connection strings](how-to-save-and-edit-connection-strings.md).

## Write the code for the forms

This section contains brief overviews of what each form does. It also provides the code that defines the underlying logic when you select a button on the form.

### Navigation form

The Navigation form opens when you run the application and includes the following buttons:

- **Add an account**: Opens the **NewCustomer** form.

- **Fill or cancel orders**: Opens the **FillOrCancel** form.

- **Exit**: Closes the application.

#### Make the Navigation form the startup form

For C# projects:

1. In **Solution Explorer**, open **Program.cs**.

1. Change the `Application.Run` line to: `Application.Run(new Navigation());`

For Visual Basic projects:

1. In **Solution Explorer**, right-click the project and choose **Properties**.

1. In the Project Designer, select the **Application** tab, and then select **Navigation** in the **Startup object** list.

#### Create autogenerated event handlers for the Navigation form

To create empty event handler methods, double-click each of the three buttons on the Navigation form. Double-clicking a button adds autogenerated code in the Designer code file, which enables a button selection to raise an event.

If you decide to copy and paste code directly into your code files instead of using the double-click action in the designer, ensure you set the event handler to the right method:

1. In the **Properties** window of the code file for the form, switch to the **Events** tab by using the lightning bolt toolbar button.

1. Search for the **Click** property and verify its value is the correct event handler method.

#### Add code for the Navigation form logic

In the code page for the Navigation form, complete the method bodies for the three button-select event handlers as shown in the following code.

### [C#](#tab/csharp)

:::code language="csharp" source="../data-tools/codesnippet/CSharp/SimpleDataApp/Navigation.cs" id="Snippet1":::

### [VB](#tab/vb)

:::code language="vb" source="../data-tools/codesnippet/VisualBasic/SimpleDataApp/Navigation.vb" id="Snippet1":::

---

### NewCustomer form

When you enter a customer name and then select the **Create account** button, the NewCustomer form creates a customer account, and SQL Server returns an IDENTITY value as the new customer ID. You can then place an order for the new account by specifying an amount and an order date, and selecting the **Place order** button.

#### Create autogenerated event handlers for the NewCustomer form

Create an empty Click event handler for each button on the NewCustomer form by double-clicking each of the four buttons. Double-clicking the buttons also adds autogenerated code in the Designer code file that enables a button select to raise an event.

#### Add code for the NewCustomer form logic

To complete the NewCustomer form logic, follow these steps:

1. Bring the `System.Data.SqlClient` namespace into scope so that you don't need to fully qualify the names of its members.

   ### [C#](#tab/csharp)

   ```csharp
   using System.Data.SqlClient;
   ```

   ### [VB](#tab/vb)

   ```vb
   Imports System.Data.SqlClient
   ```

   ---

2. Add some variables and helper methods to the class.

   ### [C#](#tab/csharp)

   :::code language="csharp" source="../data-tools/codesnippet/CSharp/SimpleDataApp/NewCustomer.cs" id="Snippet1":::

   ### [VB](#tab/vb)

   :::code language="vb" source="../data-tools/codesnippet/VisualBasic/SimpleDataApp/NewCustomer.vb" id="Snippet1":::

   ---

3. Complete the method bodies for the four button-select event handlers.

   ### [C#](#tab/csharp)

   :::code language="csharp" source="../data-tools/codesnippet/CSharp/SimpleDataApp/NewCustomer.cs" id="Snippet2":::

   ### [VB](#tab/vb)

   :::code language="vb" source="../data-tools/codesnippet/VisualBasic/SimpleDataApp/NewCustomer.vb" id="Snippet2":::

   ---

### FillOrCancel form

The FillOrCancel form runs a query to return an order when you enter an order ID, and then select the **Find order** button. The returned row appears in a read-only data grid. You can mark the order as canceled (X) if you select the **Cancel order** button, or you can mark the order as filled (F) if you select the **Fill order** button. If you select the **Find order** button again, the updated row appears.

#### Create autogenerated event handlers for the FillOrCancel form

Create empty Click event handlers for the four buttons on the FillOrCancel form by double-clicking the buttons. Double-clicking the buttons also adds autogenerated code in the Designer code file that enables a button select to raise an event.

#### Add code for the FillOrCancel form logic

To complete the FillOrCancel form logic, follow these steps.

1. Bring the following two namespaces into scope so that you don't have to fully qualify the names of their members.

   ### [C#](#tab/csharp)

   ```csharp
   using System.Data.SqlClient;
   using System.Text.RegularExpressions;
   ```

   ### [VB](#tab/vb)

   ```vb
   Imports System.Data.SqlClient
   Imports System.Text.RegularExpressions
   ```

   ---

2. Add a variable and helper method to the class.

   ### [C#](#tab/csharp)

   :::code language="csharp" source="../data-tools/codesnippet/CSharp/SimpleDataApp/FillOrCancel.cs" id="Snippet1":::

   ### [VB](#tab/vb)

   :::code language="vb" source="../data-tools/codesnippet/VisualBasic/SimpleDataApp/FillOrCancel.vb" id="Snippet1":::

   ---

3. Complete the method bodies for the four button-select event handlers.

   ### [C#](#tab/csharp)

   :::code language="csharp" source="../data-tools/codesnippet/CSharp/SimpleDataApp/FillOrCancel.cs" id="Snippet2":::

   ### [VB](#tab/vb)

   :::code language="vb" source="../data-tools/codesnippet/VisualBasic/SimpleDataApp/FillOrCancel.vb" id="Snippet2":::

   ---

## Test your application

Run the application and try creating a few customers and orders to verify that everything is working as expected.

To verify that the database is updated with your changes:

1. Open the **Tables** node in Server Explorer.

1. Right-click the **Customers** and **Orders** nodes, and choose **Show Table Data**.

## Related content

- [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)
