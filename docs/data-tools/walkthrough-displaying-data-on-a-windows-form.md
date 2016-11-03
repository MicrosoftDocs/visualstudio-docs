---
title: "Walkthrough: Displaying Data on a Windows Form | Microsoft Docs"
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
  - "displaying data on forms, walkthroughs"
  - "Windows Forms, displaying data"
  - "Windows applications, displaying data"
  - "data binding, Windows Forms"
  - "data [Visual Studio], displaying on Windows Forms"
  - "forms, displaying data"
ms.assetid: f6e08c2c-c792-43de-adf3-3e52c0100225
caps.latest.revision: 20
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
# Walkthrough: Displaying Data on a Windows Form
One of the most common scenarios in application development is to display data on a form in a Windows-based application. You can display data on a form by dragging items from the [Data Sources Window](../Topic/Data%20Sources%20Window.md) onto the form. This walkthrough creates a simple form that displays data from a single table in several individual controls. This example uses the `Customers` table from the Northwind sample database.  
  
 Tasks illustrated in this walkthrough include:  
  
-   Creating a new **Windows Application** project.  
  
-   Creating and configuring a dataset with the [Data Source Configuration Wizard](../data-tools/media/data-source-configuration-wizard.png).  
  
-   Selecting the control to be created on the form when dragging items from the **Data Sources** window. For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).  
  
-   Creating a data-bound control by dragging items from the **Data Sources** window onto your form.  
  
## Prerequisites  
 In order to complete this walkthrough, you need:  
  
-   Access to the Northwind sample database. For more information, see [How to: Install Sample Databases](../data-tools/how-to-install-sample-databases.md).  
  
## Creating the Windows Application  
 The first step is to create a **Windows Application** project.  
  
#### To create the new Windows Application project  
  
1.  From the **File** menu, create a new project.  
  
2.  Name the project `DisplayingDataonaWindowsForm`.  
  
3.  Select **Windows Application** and click **OK**. For more information, see [Client Applications](../Topic/Developing%20Client%20Applications%20with%20the%20.NET%20Framework.md).  
  
     The **DisplayingDataonaWindowsForm** project is created and added to **Solution Explorer**.  
  
## Creating the Data Source  
 This step creates a data source using the **Data Source Configuration Wizard** based on the `Customers` table in the Northwind sample database. You must have access to the Northwind sample database to create the connection. For information on setting up the Northwind sample database, see [How to: Install Sample Databases](../data-tools/how-to-install-sample-databases.md).  
  
#### To create the data source  
  
1.  On the **Data** menu, click **Show Data Sources**.  
  
2.  In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration Wizard**.  
  
3.  Select **Database** on the **Choose a Data Source Type** page, and then click **Next**.  
  
4.  On the **Choose your Data Connection** page do one of the following:  
  
    -   If a data connection to the Northwind sample database is available in the drop-down list, select it.  
  
         -or-  
  
    -   Select **New Connection** to launch the **Add/Modify Connection** dialog box..  
  
5.  If your database requires a password, select the option to include sensitive data, and then click **Next**.  
  
6.  Click **Next** on the **Save connection string to the Application Configuration file** page.  
  
7.  Expand the **Tables** node on the **Choose your Database Objects** page.  
  
8.  Select the **Customers** table, and then click **Finish**.  
  
     The **NorthwindDataSet** is added to your project and the **Customers** table appears in the **Data Sources** window.  
  
## Setting the Controls to be Created  
 For this walkthrough the data will be in a **Details** layout where data is displayed in individual controls. (The alternative approach is the default **Grid** layout where the data is displayed in a <xref:System.Windows.Forms.DataGridView> control.)  
  
#### To set the drop type for the items in the Data Sources window  
  
1.  Expand the **Customers** node in the **Data Sources** window.  
  
2.  Change the drop type of the **Customers** table to **Details** by selecting **Details** from the drop-down list on the **Customers** node. For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).  
  
3.  Change the **CustomerID** column's drop type to a label by selecting **Label** from the control list on the **CustomerID** node.  
  
## Creating the Form  
 Create the data-bound controls by dragging items from the **Data Sources** window onto your form.  
  
#### To create data-bound controls on the form  
  
-   Drag the main **Customers** node from the **Data Sources** window onto the form.  
  
     Data-bound controls with descriptive labels appear on the form, along with a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), [CustomersTableAdapter](../data-tools/tableadapter-overview.md), <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.  
  
## Testing the Application  
  
#### To run the application  
  
-   Press F5.  
  
-   Navigate records using the <xref:System.Windows.Forms.BindingNavigator> control.  
  
## Next Steps  
 Depending on your application requirements, there are several steps you may want to perform after creating a data-bound Windows Form. Some enhancements you could make to this walkthrough include:  
  
-   Adding search functionality to the form. For more information, see [How to: Add a Parameterized Query to a Windows Forms Application](../Topic/How%20to:%20Add%20a%20Parameterized%20Query%20to%20a%20Windows%20Forms%20Application.md).  
  
-   Add functionality to send updates back to the database. For more information, see [Walkthrough: Saving Data to a Database (Single Table)](../Topic/Walkthrough:%20Saving%20Data%20to%20a%20Database%20\(Single%20Table\).md).  
  
-   Adding the `Orders` table to the dataset by selecting **Configure DataSet with Wizard** from within the **Data Sources** window. Then you can add controls that display related data by dragging the **Orders** node (the one below the **Fax** column within the **Customers** table) onto the form. For more information, see [How to: Display Related Data in a Windows Forms Application](../data-tools/how-to-display-related-data-in-a-windows-forms-application.md).  
  
## See Also  
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [Add new data sources](../data-tools/add-new-data-sources.md)   
 [TableAdapter Overview](../data-tools/tableadapter-overview.md)