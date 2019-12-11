---
title: "Handle a concurrency exception | Microsoft Docs"
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
  - "concurrency control, exceptions"
  - "datasets [Visual Basic], errors"
  - "exception handling, concurrency issues"
  - "data concurrency, walkthroughs"
  - "updating datasets, errors"
  - "concurrency control, walkthroughs"
ms.assetid: 73ee9759-0a90-48a9-bf7b-9d6fc17bff93
caps.latest.revision: 27
author: jillre
ms.author: jillfra
manager: jillfra
---
# Handle a concurrency exception
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Concurrency exceptions (<xref:System.Data.DBConcurrencyException>) are raised when two users attempt to change the same data in a database at the same time. In this walkthrough, you create a Windows application that illustrates how to catch a <xref:System.Data.DBConcurrencyException>, locate the row that caused the error, and learn a strategy for how to handle it.

 This walkthrough takes you through the following process:

1. Create a new **Windows Application** project.

2. Create a new dataset based on the Northwind `Customers` table.

3. Create a form with a <xref:System.Windows.Forms.DataGridView> to display the data.

4. Fill a dataset with data from the `Customers` table in the Northwind database.

5. Use the [Visual Database Tools](https://msdn.microsoft.com/6b145922-2f00-47db-befc-bf351b4809a1) in Visual Studio to directly access the `Customers` data table and change a record.

6. Change the same record to a different value, update the dataset, and attempt to write the changes to the database, which results in a concurrency error being raised.

7. Catch the error, then display the different versions of the record, allowing the user to determine whether to continue and update the database, or to cancel the update.

## Prerequisites
 In order to complete this walkthrough, you need:

- Access to the Northwind sample database with permission to perform updates.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or the edition that you're using. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

## Create a new project
 You begin your walkthrough by creating a new Windows application.

#### To create a new Windows application project

1. On the **File** menu, create a new project.

2. In the **Project Types** pane, select a programming language.

3. In the **Templates** pane, select **Windows Application**.

4. Name the project `ConcurrencyWalkthrough`, and then select **OK**.

     Visual Studio adds the project to **Solution Explorer** and displays a new form in the designer.

## Create the Northwind dataset
 In this section, you create a dataset named `NorthwindDataSet`.

#### To create the NorthwindDataSet

1. On the **Data** menu, choose **Add New Data source**.

     The [Data Source Configuration Wizard](https://msdn.microsoft.com/library/c4df7de5-5da0-4064-940c-761dd6d9e28f) opens.

2. On the **Choose a Data Source Type**screen, select **Database**.

3. Select a connection to the Northwind sample database from the list of available connections.If the connection is not available in the list of connections,select**New Connection**

    > [!NOTE]
    > If you are connecting to a local database file, select **No** when asked if you would you like to add the file to your project.

4. On the **Save connection string to the application configuration file**screen, select **Next**.

5. Expand the **Tables** node and select the `Customers` table. The default name for the dataset should be `NorthwindDataSet`.

6. Select **Finish** to add the dataset to the project.

## Create a data-bound DataGridView control
 In this section, you create a <xref:System.Windows.Forms.DataGridView> by dragging the **Customers** item from the **Data Sources** window onto your Windows Form.

#### To create a DataGridView control that is bound to the Customers table

1. On the **Data** menu, choose **Show Data Sources** to open the **Data Sources Window**.

2. In the **Data Sources** window, expand the **NorthwindDataSet** node, and then select the **Customers** table.

3. Select the down arrow on the table node, and then select **DataGridView** in the drop-down list.

4. Drag the table onto an empty area of your form.

     A <xref:System.Windows.Forms.DataGridView> control named `CustomersDataGridView` and a <xref:System.Windows.Forms.BindingNavigator> named `CustomersBindingNavigator` are added to the form that's bound to the <xref:System.Windows.Forms.BindingSource>.This, is in, is turn bound to the `Customers` table in the `NorthwindDataSet`.

## Test the form
 You can now test the form to make sure it behaves as expected up to this point.

#### To test the form

1. Select **F5** to run the application

     The form appears with a <xref:System.Windows.Forms.DataGridView> control on it that's filled with data from the `Customers` table.

2. On the **Debug** menu, select**Stop Debugging**.

## Handleconcurrency errors
 How you handle errors is depends on the specific business rules that govern your application. For this walkthrough, we use the following strategy as an example for how tohandle the concurrency error.

 The applicationpresents the user with three versions of the record:

- The current record in the database

- The original record that's loaded into the dataset

- The proposed changes in the dataset

  The user is then able to either overwrite the database with the proposed version, or cancel the update and refresh the dataset with the new values from the database.

#### To enable the handling of concurrency errors

1. Create a custom error handler.

2. Display choices to the user.

3. Process the user's response.

4. Resend the update, or reset the data in the dataset.

### Addcode to handle the concurrency exception
 When you attempt to perform an update and an exception gets raised, you generally want to do something with the information that's provided by the raised exception.

 In this section, you add code that  attempts to update the database.You also handle any <xref:System.Data.DBConcurrencyException> that might get raised, as well as any other exceptions.

> [!NOTE]
> The `CreateMessage` and `ProcessDialogResults` methods will be added later in this walkthrough.

##### To add error handling for the concurrency error

1. Add the following code below the `Form1_Load` method:

     [!code-csharp[VbRaddataConcurrency#1](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataConcurrency/CS/Form1.cs#1)]
     [!code-vb[VbRaddataConcurrency#1](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataConcurrency/VB/Form1.vb#1)]

2. Replace the `CustomersBindingNavigatorSaveItem_Click` method to call the `UpdateDatabase` method so it looks like the following:

     [!code-csharp[VbRaddataConcurrency#2](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataConcurrency/CS/Form1.cs#2)]
     [!code-vb[VbRaddataConcurrency#2](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataConcurrency/VB/Form1.vb#2)]

### Displaychoices to the user
 The code you just wrote calls the `CreateMessage` procedure to display error information to the user. For this walkthrough, you use a message box to display the different versions of the record to the user.This enables the user to choose whether to overwrite the record with the changes or cancel the edit. Once the user selects an option (clicks a button) on the message box, the response is passed to the `ProcessDialogResult` method.

##### To create the message to display to the user

- Create the message by adding the following code to the **Code Editor**. Enter this code below the `UpdateDatabase` method.

     [!code-csharp[VbRaddataConcurrency#4](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataConcurrency/CS/Form1.cs#4)]
     [!code-vb[VbRaddataConcurrency#4](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataConcurrency/VB/Form1.vb#4)]

### Process the user's response
 You  also need code to process the user's response to the message box. The options are either to overwrite the current record in the database with the proposed change, or abandon the local changes and refresh the data table with the record that's currently in the database. If the user chooses yes, the <xref:System.Data.DataTable.Merge%2A> method is called with the *preserveChanges* argument set to `true`. This causes the update attempt to be successful, because the original version of the record now matches the record in the database.

##### To process the user input from the message box

- Add the following code below the code that was added in the previous section.

     [!code-csharp[VbRaddataConcurrency#3](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataConcurrency/CS/Form1.cs#3)]
     [!code-vb[VbRaddataConcurrency#3](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataConcurrency/VB/Form1.vb#3)]

## Test the form
 You can now test the form to make sure it behaves as expected. To simulate a concurrency violation you need to change data in the database after filling the NorthwindDataSet.

#### To test the form

1. Select **F5** to run the application.

2. After the form appears, leave it running and switch to the Visual Studio IDE.

3. On the **View** menu, choose **Server Explorer**.

4. In **Server Explorer**, expand the connection your application is using, and then expand the **Tables** node.

5. Right-click the **Customers** table, and then select **Show Table Data**.

6. In the first record (`ALFKI`) change `ContactName` to `Maria Anders2`.

    > [!NOTE]
    > Navigate to a different row to commit the change.

7. Switch to the `ConcurrencyWalkthrough`'s running form.

8. In the first record on the form (`ALFKI`), change`ContactName` to `Maria Anders1`.

9. Select the **Save** button.

     The concurrency error is raised, and the message box appears.

10. Selecting **No** cancels the update and updates the dataset with the values that are currently in the database. Selecting **Yes** writes the proposed value to the database.

## See Also

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)