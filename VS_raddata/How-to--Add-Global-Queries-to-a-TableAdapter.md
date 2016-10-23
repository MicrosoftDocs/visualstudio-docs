---
title: "How to: Add Global Queries to a TableAdapter"
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
ms.assetid: 4abffd6b-2e9f-4ef3-99b2-6e9ae4ad4679
caps.latest.revision: 13
manager: ghogen
robots: noindex,nofollow
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
# How to: Add Global Queries to a TableAdapter
*Global queries* are SQL queries that return either a single (scalar) value or no value. Typically, global functions perform database operations such as inserts, updates, deletes, and the aggregating of information, such as returning a count of customers in a table or the total charges for all items in a particular order.  
  
 You add global queries by running the **TableAdapter Query Configuration Wizard** from within the **Dataset Designer**.  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
### To add a global query to a dataset  
  
1.  Open a dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md).  
  
2.  Drag a **Query** from the **DataSet** tab of the **Toolbox** onto an empty area of the **Dataset Designer**.  
  
     The [Editing TableAdapters](../VS_raddata/Editing-TableAdapters.md) opens.  
  
3.  Choose a connection for the query to use. You can either choose one from the list or create a new connection. If you create a new connection, you will have the option to save it to the application configuration file. For more information, see [How to: Save and Edit Connection Strings](../Topic/How%20to:%20Save%20and%20Edit%20Connection%20Strings.md).  
  
4.  Choose whether to use SQL statements or stored procedures.  
  
5.  Choose the stored procedure to use or, on the **Choose a Query Type** page of the wizard, choose the type of query you want and then click **Next**.  
  
6.  Provide a query that performs the desired task, for example, `SELECT COUNT(*) AS CustomerCount FROM Customers`.  
  
    > [!NOTE]
    >  Dragging a query directly onto the **Dataset Designer** creates a method that will only return a scalar (single) value. While the query or stored procedure you select may return more than a single value, the method created by the wizard will only return a single value. For example, the query might return the first column of the first row of the returned data.  
  
7.  Complete the wizard; the query is added to the **Dataset Designer**. For information on running the query, see [How to: Execute TableAdapter Queries](../Topic/How%20to:%20Execute%20TableAdapter%20Queries.md).  
  
## See Also  
 [Create and configure TableAdapters](../VS_raddata/Create-and-configure-TableAdapters.md)   
 [How to: Create TableAdapter Queries](../VS_raddata/How-to--Create-TableAdapter-Queries.md)   
 [Bind Windows Forms controls to data in Visual Studio](../VS_raddata/Bind-Windows-Forms-controls-to-data-in-Visual-Studio.md)   
 [TableAdapter Overview](../VS_raddata/TableAdapter-Overview.md)   
 [Creating and Editing Typed Datasets](../VS_raddata/Creating-and-Editing-Typed-Datasets.md)   
 [Add new data sources](../VS_raddata/Add-new-data-sources.md)   
 [How to: Connect to Data in a Database](../VS_raddata/How-to--Connect-to-Data-in-a-Database.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [How to: Navigate Data with the Windows Forms BindingNavigator Control](../Topic/How%20to:%20Navigate%20Data%20with%20the%20Windows%20Forms%20BindingNavigator%20Control.md)   
 [Walkthrough: Displaying Data on a Windows Form](../VS_raddata/Walkthrough--Displaying-Data-on-a-Windows-Form.md)