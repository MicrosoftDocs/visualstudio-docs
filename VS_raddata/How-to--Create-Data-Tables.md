---
title: "How to: Create Data Tables"
ms.custom: na
ms.date: 10/03/2016
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
ms.assetid: 0e8bf4c4-3d05-4b20-9926-9d29914b26ed
caps.latest.revision: 19
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
# How to: Create Data Tables
Data can be stored in memory in <xref:System.Data.DataTable?qualifyHint=False> objects. (Datasets are made up of <xref:System.Data.DataTable?qualifyHint=False> objects.) You typically create new data tables with TableAdapters using the [TableAdapter Configuration Wizard](../Topic/TableAdapter%20Configuration%20Wizard.md) or by dragging database objects from **Server Explorer** onto the **Dataset Designer**.  
  
 Data tables are created as a byproduct when you create new TableAdapters in the [Data Source Configuration Wizard](../VS_raddata/media/Data-Source-Configuration-Wizard.png) as well, but they can also be created independently. You create a standalone data table by dragging a <xref:System.Data.DataTable?qualifyHint=False> object from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.  
  
> [!NOTE]
>  To create data tables programmatically, see [Creating a DataTable](../Topic/Creating%20a%20DataTable.md).  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
## Creating a DataTable with TableAdapter  
 Data tables with TableAdapters include methods that fill the table with data and write changes back to the database. You create TableAdapters by running the **TableAdapter Configuration Wizard** or by dragging database objects from **Server Explorer** onto the **Dataset Designer**.  
  
#### To create a new data table with TableAdapter  
  
1.  Open your dataset in the **Dataset Designer**. For information, see [How to: Open a Dataset in the Dataset Designer](../Topic/How%20to:%20Open%20a%20Dataset%20in%20the%20Dataset%20Designer.md).  
  
2.  Drag a **TableAdapter** from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.  
  
     The **TableAdapter Configuration Wizard** opens.  
  
3.  Complete the wizard. For more information, see [TableAdapter Configuration Wizard](../Topic/TableAdapter%20Configuration%20Wizard.md)  
  
#### To create a new data table with a TableAdapter from Server Explorer  
  
1.  Open your dataset in the **Data Source Designer**.  
  
2.  Drag a database object (for example, a table) from **Server Explorer** onto the **Dataset Designer**.  
  
## Creating a Standalone DataTable  
 Standalone tables need to have `Fill` logic implemented in order to be filled with data. For information on filling standalone data tables, see [Populating a DataSet from a DataAdapter](../Topic/Populating%20a%20DataSet%20from%20a%20DataAdapter.md).  
  
#### To create a new stand alone data table  
  
1.  Open your dataset in the **Dataset Designer**.  
  
2.  Drag a <xref:System.Data.DataTable?qualifyHint=False> from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.  
  
3.  Add columns to define your data table. For more information, see [How to: Add Columns to a DataTable](../Topic/How%20to:%20Add%20Columns%20to%20a%20DataTable.md).  
  
## See Also  
 <xref:System.Data.DataTable?qualifyHint=False>   
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Walkthrough: Displaying Data on a Windows Form](../VS_raddata/Walkthrough--Displaying-Data-on-a-Windows-Form.md)   
 [TableAdapter Overview](../VS_raddata/TableAdapter-Overview.md)   
 [Creating and Editing Typed Datasets](../VS_raddata/Creating-and-Editing-Typed-Datasets.md)   
 [Add new data sources](../VS_raddata/Add-new-data-sources.md)   
 [Data Sources Window](../Topic/Data%20Sources%20Window.md)   
 [How to: Connect to Data in a Database](../VS_raddata/How-to--Connect-to-Data-in-a-Database.md)   
 [Validating Data](../Topic/Validating%20Data.md)