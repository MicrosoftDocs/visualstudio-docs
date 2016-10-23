---
title: "Save data in a transaction"
ms.custom: na
ms.date: 10/07/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - aspx
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 80260118-08bc-4b37-bfe5-9422ee7a1e4e
caps.latest.revision: 15
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Save data in a transaction
This walkthrough demonstrates how to save data in a transaction by using the <xref:System.Transactions?qualifyHint=False> namespace. This example uses the `Customers` and `Orders` tables from the Northwind sample database.  
  
## Prerequisites  
 This walkthrough requires access to the Northwind sample database. For information about setting up the Northwind sample database, see [How to: Install Sample Databases](../VS_raddata/How-to--Install-Sample-Databases.md).  
  
## Create a Windows application  
 The first step is to create a **Windows Application**.  
  
#### To create the new Windows project  
  
1.  In Visual Studio, on the **File** menu, create a new **Project**.  
  
2.  Name the project **SavingDataInATransactionWalkthrough**.  
  
3.  Select **Windows Application**, and then select**OK**. For more information, see [Client Applications](../Topic/Developing%20Client%20Applications%20with%20the%20.NET%20Framework.md).  
  
     The **SavingDataInATransactionWalkthrough** project is created and added to **Solution Explorer**.  
  
## Create a database data source  
 This step uses the [Data Source Configuration Wizard](../VS_raddata/media/Data-Source-Configuration-Wizard.png) to create a data source based on the `Customers` and `Orders` tables in the Northwind sample database.  
  
#### To create the data source  
  
1.  On the **Data** menu, select**Show Data Sources**.  
  
2.  In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration Wizard**.  
  
3.  On the **Choose a Data Source Type**screen, select **Database**, and then select**Next**.  
  
4.  On the **Choose your Data Connection**screen do one of the following:  
  
    -   If a data connection to the Northwind sample database is available in the drop-down list, select it.  
  
         -or-  
  
    -   Select **New Connection** to launch the **Add/Modify Connection** dialog box and create a connection to the Northwind database.  
  
5.  If your database requires a password, select the option to include sensitive data, and then select**Next**.  
  
6.  On the **Save connection string to the Application Configuration file** screen, select**Next**.  
  
7.  On the **Choose your Database Objects** screen, expand the **Tables** node.  
  
8.  Select the `Customers` and `Orders` tables, and then select**Finish**.  
  
     The **NorthwindDataSet** is added to your project and the `Customers` and `Orders` tables appear in the **Data Sources** window.  
  
## Addcontrols to the form  
 You can create the data-bound controls by dragging items from the **Data Sources** window onto your form.  
  
#### To create data bound controls on the Windows form  
  
-   In the **Data Sources** window, expand the **Customers** node.  
  
-   Drag the main **Customers** node from the **Data Sources** window onto **Form1**.  
  
     A <xref:System.Windows.Forms.DataGridView?qualifyHint=False> control and a tool strip (<xref:System.Windows.Forms.BindingNavigator?qualifyHint=False>) for navigating records appear on the form. A [NorthwindDataSet](../VS_raddata/Dataset-tools-in-Visual-Studio.md), [CustomersTableAdapter](../VS_raddata/TableAdapter-Overview.md),<xref:System.Windows.Forms.BindingSource?qualifyHint=False>, and <xref:System.Windows.Forms.BindingNavigator?qualifyHint=False> appear in the component tray.  
  
-   Drag the related **Orders** node (not the main **Orders** node, but the related child-table node below the **Fax** column) onto the form below the **CustomersDataGridView**.  
  
     A <xref:System.Windows.Forms.DataGridView?qualifyHint=False> appears on the form. An [OrdersTableAdapter](../VS_raddata/TableAdapter-Overview.md) and <xref:System.Windows.Forms.BindingSource?qualifyHint=False> appear in the component tray.  
  
## Add a reference to the System.Transactions assembly  
 Transactions use the <xref:System.Transactions?qualifyHint=False> namespace. A project reference to the system.transactions assembly is not added by default, so you need to manually add it.  
  
#### To add a reference to the System.Transactions DLL file  
  
1.  On the **Project** menu, select**Add Reference**.  
  
2.  Select **System.Transactions**(on the **.NET** tab), and then select**OK**.  
  
     A reference to **System.Transactions** is added to the project.  
  
## Modifythe code in the BindingNavigator's SaveItem button  
 For the first table dropped onto your form, code is added by default to the `click` event of the save button on the <xref:System.Windows.Forms.BindingNavigator?qualifyHint=False>. You need to manually add code to update any additional tables. For this walkthrough, we refactor the existing save code out of the save button's click event handler.We also create a few more methods to provide specific update functionality based on whether the row needs to be added or deleted.  
  
#### To modify the auto-generated save code  
  
1.  Select the **Save** button on the **CustomersBindingNavigator** (the button with the floppy disk icon).  
  
2.  Replace the `CustomersBindingNavigatorSaveItem_Click` method with the following code:  
  
     [!CODE [VbRaddataSaving#4](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#4)]  
  
 The order for reconciling changes to related data is as follows:  
  
-   Delete child records. (In this case, delete records from the `Orders` table.)  
  
-   Delete parent records. (In this case, delete records from the `Customers` table.)  
  
-   Insert parent records.(In this case, insert records in the `Customers` table.)  
  
-   Insert child records. (In this case, insert records in the `Orders` table.)  
  
#### To delete existing orders  
  
-   Add the following `DeleteOrders` method to **Form1**:  
  
     [!CODE [VbRaddataSaving#5](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#5)]  
  
#### To delete existing customers  
  
-   Add the following `DeleteCustomers` method to **Form1**:  
  
     [!CODE [VbRaddataSaving#6](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#6)]  
  
#### To add new customers  
  
-   Add the following `AddNewCustomers` method to **Form1**:  
  
     [!CODE [VbRaddataSaving#7](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#7)]  
  
#### To add new orders  
  
-   Add the following `AddNewOrders` method to **Form1**:  
  
     [!CODE [VbRaddataSaving#8](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#8)]  
  
## Run the application  
  
#### To run the application  
  
-   Select**F5** to run the application.  
  
## See Also  
 [Save data back to the database](../VS_raddata/Save-data-back-to-the-database.md)