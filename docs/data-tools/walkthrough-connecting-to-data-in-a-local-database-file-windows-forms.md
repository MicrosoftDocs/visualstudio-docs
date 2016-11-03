---
title: "Walkthrough: Connecting to Data in a Local Database File (Windows Forms) | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "databases, connecting to"
  - "local data, SQL Express"
  - "SQL Express, walkthroughs"
  - "SQL Express, connecting"
  - "data [Visual Studio], local"
  - "data [Visual Studio], connecting to SQL Express"
ms.assetid: 5e16b7da-3fdc-4e69-bdb4-e8e700481811
caps.latest.revision: 35
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
robots: noindex,nofollow
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Walkthrough: Connecting to Data in a Local Database File (Windows Forms)
You can quickly and easily display data from a local database file in your application by creating a dataset and then adding data-bound controls to your application. In this walkthrough, you'll display data from the local database file that you created by following the steps in [Create a SQL database by using a designer](../data-tools/create-a-sql-database-by-using-a-designer.md). After you create a Windows Forms project, you'll connect to that database and specify that you want data from the Customers table to appear in a data grid on the form for the application.  
  
 When you create a database in Visual Studio 2013, the SQL Server Express LocalDB engine is used to access a database file (.mdf) in SQL Server 2012. In earlier versions of Visual Studio, the SQL Server Express engine is used to access a database file (.mdf). See [Local Data Overview](../data-tools/local-data-overview.md).  
  
 [!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]  
  
 This walkthrough includes the following tasks:  
  
-   [Creating and configuring a dataset](../data-tools/walkthrough-connecting-to-data-in-a-local-database-file-windows-forms.md#BKMK_CreateDataset)  
  
-   [Adding data-bound controls](../data-tools/walkthrough-connecting-to-data-in-a-local-database-file-windows-forms.md#BKMK_AddCtrls)  
  
## Prerequisites  
 To complete this walkthrough, you need access to the SampleDatabase.mdf database that you create by completing [Create a SQL database by using a designer](../data-tools/create-a-sql-database-by-using-a-designer.md).  
  
##  <a name="BKMK_CreateDataset"></a> Creating and configuring a dataset  
  
#### To create and configure a dataset  
  
1.  Create a Windows Forms project, and name it **ConnectLocalData**.  
  
     See [Client Applications](../Topic/Developing%20Client%20Applications%20with%20the%20.NET%20Framework.md).  
  
2.  If the **Data Sources** window isn't showing, choose the Shift-Alt-D keys or, on the menu bar, choose **View**, **Other Windows**, **Show Data Sources**.  
  
3.  In the **Data Sources** window, choose the **Add New Data Source** link.  
  
     In the **Data Source Configuration Wizard**, choose the **Next** button two times to accept the default settings.  
  
4.  On the **Choose Your Data Connection** page, choose the **New Connection** button.  
  
     The **Choose Data Source** dialog box appears.  
  
5.  In the **Data source** list, choose **Microsoft SQL Server Database File**, and then choose the **Continue** button.  
  
     The **Add Connection** dialog box appears.  
  
6.  In the **Database file name** box, specify the file that you created by completing [Create a SQL database by using a designer](../data-tools/create-a-sql-database-by-using-a-designer.md), or choose the **Browse** button and then locate that file.  
  
     By default, the file is in Users\\*YourAccount*\Documents\Visual Studio *Version*\Projects\SampleDatabaseWalkthrough\SampleDatabaseWalkthrough.  
  
7.  Under **Log on to the server**, accept the default values, choose the **OK** button, and then choose the **Next** button.  
  
    > [!NOTE]
    >  When you connect to a local database file, you can create a copy of the database in your project, or you can connect to the database file in its current location. See [How to: Manage Local Data Files in Your Project](../data-tools/how-to-manage-local-data-files-in-your-project.md).  
  
8.  In the dialog box that appears, choose **Yes** to copy the database file to your project.  
  
9. On the **Save the Connection String to the Application Configuration File** page, choose the **Next** button.  
  
10. On the **Choose Your Database Objects** page, expand the **Tables** node, select the **Customers** and **Orders** check boxes, and then choose the **Finish** button.  
  
     The **SampleDatabaseDataSet** is added to your project, and the **Customers** and **Orders** tables appear in the **Data Sources** window.  
  
##  <a name="BKMK_AddCtrls"></a> Adding data-bound controls  
  
#### To add data-bound controls  
  
1.  Move the main **Customers** node from the **Data Sources** window onto **Form1**.  
  
     A <xref:System.Windows.Forms.DataGridView> and a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records appear on the form. A [SampleDatabaseDataSet](../data-tools/dataset-tools-in-visual-studio.md), [CustomersTableAdapter](../data-tools/tableadapter-overview.md), <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.  
  
2.  To run the application and show the data that you added in the previous walkthrough, choose the F5 key.  
  
3.  Choose the yellow addition icon (![Add button in Windows Form](../data-tools/media/addrecord.png "AddRecord")), add a customer record, and then save your changes by choosing the disk icon (![Save button in Windows Form](../data-tools/media/saveinwf.png "SaveInWF")).  
  
4.  Delete the record that you just created by choosing it and then choosing the red delete icon (![Delete button in Windows Form](../data-tools/media/deleterecord.png "DeleteRecord")).  
  
## Next Steps  
 You can create or modify objects in the dataset if you open the data source in the [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md). You can also add validation logic to the <xref:System.Data.DataTable.ColumnChanging> or <xref:System.Data.DataTable.RowChanging> events of the data tables in the dataset. See [Validate data in datasets](../data-tools/validate-data-in-datasets.md).  
  
## See Also  
 [Local Data Overview](../data-tools/local-data-overview.md)   
 [How to: Manage Local Data Files in Your Project](../data-tools/how-to-manage-local-data-files-in-your-project.md)   
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../data-tools/saving-data.md)