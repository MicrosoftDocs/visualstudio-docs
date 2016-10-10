---
title: "How to: Connect to Data in a Database"
ms.custom: na
ms.date: 10/01/2016
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
ms.assetid: 6c56e54e-8834-4297-85aa-cc1a443ba556
caps.latest.revision: 55
manager: ghogen
robots: noindex,nofollow
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Connect to Data in a Database
You can use Visual Studio to connect your application to a database. After creating the data connection, Visual Studio generates a data model that your application uses to interact with the data in the database. The objects in the data model appear in the [Data Sources Window](../Topic/Data%20Sources%20Window.md). You can then create data-bound controls by dragging items from the **Data Sources Window** to a design surface. For more information, see [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md).  
  
 This topic provides instructions for connecting to a database and creating the following types of data models:  
  
-   Dataset  
  
-   Entity Data Model (EDM)  
  
> [!NOTE]
>  You can also use Visual Studio to create LINQ to SQL classes from a database. However, LINQ to SQL classes do not appear in the **Data Sources** window, and therefore cannot be dragged directly to a designer to create data-bound controls. For more information about creating LINQ to SQL classes from a database, see [How to: Create LINQ to SQL classes mapped to tables and views (O/R Designer)](../VS_raddata/How-to--Create-LINQ-to-SQL-classes-mapped-to-tables-and-views--O-R-Designer-.md).  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
##  <a name="dataset"></a> Connecting to a Database and Creating a Dataset  
 When you create a dataset that is based on a database, Visual Studio creates a set of classes that represent a programmable view of the data. The main class is called a *typed dataset*. The typed dataset contains data table objects that represent tables in the database. For more information about typed datasets, see [Dataset tools in Visual Studio](../VS_raddata/Dataset-tools-in-Visual-Studio.md).  
  
 After you create a dataset, you can create data-bound WPF or Windows Forms controls by dragging dataset objects from the Data Sources window to the WPF or Windows Forms designer.  
  
#### To connect your application to a database and create a dataset  
  
1.  Open an existing project in Visual Studio, or create a new project.  
  
2.  On the **Data** menu, click **Add New Data Source**.  
  
     The **Data Source Configuration Wizard** opens.  
  
3.  On the **Choose a Data Source Type** page, select **Database**, and then click **Next**.  
  
4.  On the **Choose a Database Model** page, select **Dataset**, and then click **Next**.  
  
5.  On the **Choose Your Data Connection** page, select a data connection from the list of available connections and then click **Next**.  
  
     If your desired data connection is not available, create a new connection by following the steps in [Creating a New Database Connection](#CreatingDataConnection).  
  
6.  On the **Save the Connection String to the Application Configure File** page, optionally clear the **Yes, save the connection as** check box if you want to save the connection string directly in the compiled application. By default, the connection is saved in the application configuration file. For more information, see [How to: Save and Edit Connection Strings](../Topic/How%20to:%20Save%20and%20Edit%20Connection%20Strings.md).  
  
7.  On the **Choose Your Database Objects** page, select the database objects that you will use in your application. You also have the option of replacing the default **DataSet name**.  
  
8.  Click **Finish**. The dataset you just created is now available in the **Data Sources** window.  
  
    > [!NOTE]
    >  If the **Data Sources** window is not open, click **Show Data Sources** on the **Data** menu to open the window.  
  
9. You can now drag items from the **Data Sources** window to the WPF designer, the Windows Forms designer, or the [Component Designer](../Topic/Component%20Designer.md) to create data-bound controls. For more information, see [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md).  
  
##  <a name="edm"></a> Connecting to Database and Creating an Entity Data Model  
 When you create an Entity Data Model that is based on a database, Visual Studio creates a set of classes that represent a programmable view of the data. For more information about Entity Data Models and the ADO.NET Entity Framework, see [Entity Framework Overview](../Topic/Entity%20Framework%20Overview.md).  
  
 After you create an Entity Data Model, you can create data-bound WPF controls by dragging entity objects from the Data Sources window to the WPF designer.  
  
#### To connect your application to a database and create an Entity Data Model  
  
1.  Open an existing project in Visual Studio, or create a new project.  
  
2.  Follow the steps in the **Entity Data Model Wizard** to connect to a database and specify the contents of the model. For more information, see [How to: Create a New .edmx File](assetId:///beb8189e-e51c-4051-839c-9902c224abf2).  
  
3.  After you complete the **Entity Data Model Wizard**, the Entity Data Model you created opens in the Entity Data Model Designer, and the data objects are now available in the **Data Sources** window.  
  
    > [!NOTE]
    >  If the **Data Sources** window is not open, click **Show Data Sources** on the **Data** menu to open the window.  
  
4.  If the WPF designer is open, you can now drag items from the **Data Sources** window to the designer to create controls that are bound to the Entity Data Model. For more information, see [Bind WPF controls to data in Visual Studio](../VS_raddata/Bind-WPF-controls-to-data-in-Visual-Studio2.md).  
  
     If the Windows Forms designer is open, you cannot drag items from the **Data Sources** to the designer. To create controls that are bound to the Entity Data Model, you must build the project, add a new object data source that is based on the Entity Data Model, and then drag those objects to the designer.  
  
##  <a name="CreatingDataConnection"></a> Creating a New Database Connection  
 When you use the **Data Source Configuration Wizard**or the **Entity Data Model Wizard**, you must specify a connection to the database you want to use. If you do not already have a connection to the database, perform the following steps to create the connection.  
  
 These instructions assume you have already started the **Data Source Configuration Wizard** or the **Entity Data Model Wizard** as described in [Connecting to Database and Creating a Dataset](#dataset) and [Connecting to Database and Creating an Entity Data Model](#edm).  
  
#### To create a new database connection  
  
1.  On the **Choose Your Data Connection** page of the **Data Source Configuration Wizard** or the **Entity Data Model Wizard**, click **New Connection**.  
  
     One of the following actions occur:  
  
    -   If you have already created a data connection in Visual Studio, the **Add Connection** dialog box opens.  
  
    -   If this is the first data connection you have created in Visual Studio, the **Choose Data Source** dialog box displays. Select the type of database you want to connect to, and then click **OK** to display the **Add Connection** dialog box.  
  
2.  In the **Add Connection** dialog box, enter the requested information. The **Add Connection** dialog box is different for each type of data provider.  
  
    > [!NOTE]
    >  If the selected **Data source** in the **Add Connection** dialog box is not the data source you want to connect to, click **Change** to open the **Change Data Source** dialog box and then choose a different data source.  
  
3.  In the **Add Connection** dialog box, click **OK**.  
  
     You return to the **Choose Your Data Connection** page of the **Data Source Configuration Wizard** or the **Entity Data Model Wizard**.  
  
4.  On the **Choose Your Data Connection** page, make sure that the new data connection is selected and then click **Next**.  
  
5.  Complete the remaining steps in the **Data Source Configuration Wizard** or the **Entity Data Model Wizard**.  
  
## .NET Framework Security  
 Storing sensitive information (such as a password) can affect the security of your application. Using Windows Authentication (also known as integrated security) is a more secure way to control access to a database. For more information, see [Protecting Connection Information](../Topic/Protecting%20Connection%20Information.md).  
  
## See Also  
 [Add new data sources](../VS_raddata/Add-new-data-sources.md)   
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Bind Windows Forms controls to data in Visual Studio](../VS_raddata/Bind-Windows-Forms-controls-to-data-in-Visual-Studio.md)   
 [Connecting to Data in Visual Studio](../VS_raddata/Connecting-to-Data-in-Visual-Studio.md)   
 [Connecting to a Data Source](../Topic/Connecting%20to%20a%20Data%20Source%20in%20ADO.NET.md)