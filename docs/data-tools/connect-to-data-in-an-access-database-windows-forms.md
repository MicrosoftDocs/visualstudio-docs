---
title: "Connect to data in an Access database (Windows Forms) | Microsoft Docs"
ms.custom: ""
ms.date: "09/15/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "databases, connecting to"
  - "databases, Access"
  - "data [Visual Studio], connecting"
  - "connecting to data, from Access databases"
  - "Access databases, connecting"
ms.assetid: 4159e815-d430-4ad0-a234-e4125fcbef18
caps.latest.revision: 29
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.technology: "vs-data-tools"
ms.workload: 
  - "data-storage"
---
# Connect to data in an Access database (Windows Forms)
You can connect to an Access database (either an .mdf file or an .accdb file) by using Visual Studio. After you define the connection, the data appears in the **Data Sources** window. From there, you can drag tables or views onto your forms.   
  
## Prerequisites  
 To use these procedures, you need a Windows Forms application project, and either an Access database (.accdb file) or an Access 2000-2003 database (.mdb file). Follow the procedure that corresponds to your file type.  
  
## Creating the dataset for an .accdb file  
 You can connect to databases created through Access 2013, Office 365, Access 2010, or Access 2007 by using the following procedure.  
  
#### To create the dataset  
  
1.  Open the Windows Forms application to which you want to connect data.  
  
2.  On the **View** menu, select **Other Windows** > **Data Sources**.  
  
     ![View Other Windows Data Sources](../data-tools/media/viewdatasources.png "ViewDataSources")  
  
3.  In the **Data Sources** window, click **Add New Data Source**.  

     The **Data Source Configuration Wizard** opens.  
  
4.  Select **Database** on the **Choose a Data Source Type** page, and then select **Next**.  
  
5.  Select **Dataset** on the **Choose a Database Model** page, and then select **Next**.  
  
6.  On the **Choose your Data Connection** page, select **New Connection** to configure a new data connection.  

     The **Add Connection** dialog box opens.  
  
7.  Select the **Change** button next to the **Data source** text box.

     The **Change Data Source** dialog box opens.  
  
8.  In the list of data sources, choose **\<other\>**. In the **Data provider** drop-down, select **.NET Framework Data Provider for OLE DB**, then choose **OK**.  

9. Back in the **Add Connection** dialog box, select **Microsoft Office 12.0 Access Database Engine OLE DB Provider** from the **OLE DB Provider** drop-down.  
  
     ![OLE DB Provider Microsoft Office 12.0 Access](../data-tools/media/dataoledbprovideroffice12access.png "dataOLEDBProviderOffice12Access")  

     > [!NOTE]
     >  If you don't see **Microsoft Office 12.0 Access Database Engine OLE DB Provider** in the OLE DB provider drop-down, you may need to install the [2007 Office System Driver: Data Connectivity Components](https://www.microsoft.com/download/confirmation.aspx?id=23734).
  
9. In the **Server or file name** text box, specify the path and file name of the .accdb file you want to connect to, and then select **OK**. (If the database file has a user name and password, specify them before you select **OK**.)    
  
10. Select **Next** on the **Choose your Data Connection** page.  

     You may get a dialog box telling you the data file is not in your current project. Select **Yes** or **No**.
  
11. Select **Next** on the **Save connection string to the Application Configuration file** page.  
  
12. Expand the **Tables** node on the **Choose your Database Objects** page.  
  
13. Select whatever tables or views you want in your dataset, and then select **Finish**.  
  
     The dataset is added to your project, and the tables and views appear in the **Data Sources** window.  
  
## Creating the dataset for an .mdb file  
 You create the dataset by running the **Data Source Configuration Wizard**.  
  
#### To create the dataset  
  
1.  Open the Windows Forms application to which you want to connect data.  
  
2.  On the **View** menu, select **Other Windows** > **Data Sources**.  
  
     ![View Other Windows Data Sources](../data-tools/media/viewdatasources.png "ViewDataSources")  
  
3.  In the **Data Sources** window, click **Add New Data Source**.  

     The **Data Source Configuration Wizard** opens.
  
4.  Select **Database** on the **Choose a Data Source Type** page, and then select **Next**.  
  
5.  Select **Dataset** on the **Choose a Database Model** page, and then select **Next**.  
  
6.  On the **Choose your Data Connection** page, select **New Connection** to configure a new data connection.  
  
7.  If the data source is not **Microsoft Access Database File (OLE DB)**, select **Change** to open the **Change Data Source** dialog box and select **Microsoft Access Database File**, and then select **OK**.  
  
8.  In the **Database file name**, specify the path and name of the .mdb file you want to connect to, and then select **OK**.  
  
     ![Add Connection Access Database File](../data-tools/media/dataaddconnectionaccessmdb.png "dataAddConnectionAccessMDB")  
  
9. Select **Next** on the **Choose your Data Connection** page.  
  
10. Select **Next** on the **Save connection string to the Application Configuration file** page.  
  
11. Expand the **Tables** node on the **Choose your Database Objects** page.  
  
12. Select whatever tables or views you want in your dataset, and then select **Finish**.  
  
     The dataset is added to your project, and the tables and views appear in the **Data Sources** window.  
  
## Security  
 Storing sensitive information (such as a password) can affect the security of your application. Using Windows Authentication (also known as integrated security) is a more secure way to control access to a database. For more information, see [Protecting Connection Information](/dotnet/framework/data/adonet/protecting-connection-information).  
  
## Next Steps  
 The dataset that you just created is now available in the **Data Sources** window. You can now perform any of the following tasks:  
  
-   Select items in the **Data Sources** window and drag them onto your form (see [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)).  
  
-   Open the data source in the **Dataset Designer** to add or edit the objects that make up the dataset.  
  
-   Add validation logic to the <xref:System.Data.DataTable.ColumnChanging> or <xref:System.Data.DataTable.RowChanging> event of the data tables in the dataset (see [Validate data in datasets](../data-tools/validate-data-in-datasets.md)).  
  
## See also
[Adding connections](../data-tools/add-new-connections.md)
