---
title: "How to: Create Data Tables | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "Microsoft.VSDesigner.DataSource.DesignTable"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "data [Visual Studio], creating data tables"
  - "Dataset Designer, creating data tables"
  - "tables [Visual Studio], creating"
ms.assetid: 0e8bf4c4-3d05-4b20-9926-9d29914b26ed
caps.latest.revision: 19
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# How to: Create Data Tables
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Data can be stored in memory in <xref:System.Data.DataTable> objects. (Datasets are made up of <xref:System.Data.DataTable> objects.) You typically create new data tables with TableAdapters using the [TableAdapter Configuration Wizard](http://msdn.microsoft.com/library/3a373dd9-7b34-4d3c-a48b-69414512bac8) or by dragging database objects from **Server Explorer** onto the **Dataset Designer**.  
  
 Data tables are created as a byproduct when you create new TableAdapters in the [Data Source Configuration Wizard](http://msdn.microsoft.com/library/c4df7de5-5da0-4064-940c-761dd6d9e28f) as well, but they can also be created independently. You create a standalone data table by dragging a <xref:System.Data.DataTable> object from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.  
  
> [!NOTE]
>  To create data tables programmatically, see [Creating a DataTable](http://msdn.microsoft.com/library/eecf9d78-60e3-4fdc-8de0-e56c13a89414).  
  
 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]  
  
## Creating a DataTable with TableAdapter  
 Data tables with TableAdapters include methods that fill the table with data and write changes back to the database. You create TableAdapters by running the **TableAdapter Configuration Wizard** or by dragging database objects from **Server Explorer** onto the **Dataset Designer**.  
  
#### To create a new data table with TableAdapter  
  
1.  Open your dataset in the **Dataset Designer**. For information, see [How to: Open a Dataset in the Dataset Designer](http://msdn.microsoft.com/library/36fc266f-365b-42cb-aebb-c993dc2c47c3).  
  
2.  Drag a **TableAdapter** from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.  
  
     The **TableAdapter Configuration Wizard** opens.  
  
3.  Complete the wizard. For more information, see [TableAdapter Configuration Wizard](http://msdn.microsoft.com/library/3a373dd9-7b34-4d3c-a48b-69414512bac8)  
  
#### To create a new data table with a TableAdapter from Server Explorer  
  
1.  Open your dataset in the **Data Source Designer**.  
  
2.  Drag a database object (for example, a table) from **Server Explorer** onto the **Dataset Designer**.  
  
## Creating a Standalone DataTable  
 Standalone tables need to have `Fill` logic implemented in order to be filled with data. For information on filling standalone data tables, see [Populating a DataSet from a DataAdapter](http://msdn.microsoft.com/library/3fa0ac7d-e266-4954-bfac-3fbe2f913153).  
  
#### To create a new stand alone data table  
  
1.  Open your dataset in the **Dataset Designer**.  
  
2.  Drag a <xref:System.Data.DataTable> from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.  
  
3.  Add columns to define your data table. For more information, see [How to: Add Columns to a DataTable](http://msdn.microsoft.com/library/8ca21f77-b99a-47a7-a656-7cfd7a1bd9df).  
  
## See Also  
 <xref:System.Data.DataTable>   
 [Data Walkthroughs](http://msdn.microsoft.com/library/15a88fb8-3bee-4962-914d-7a1f8bd40ec4)   
 [Walkthrough: Displaying Data on a Windows Form](../data-tools/walkthrough-displaying-data-on-a-windows-form.md)   
 [TableAdapter Overview](../data-tools/tableadapter-overview.md)   
 [Creating and Editing Typed Datasets](../data-tools/creating-and-editing-typed-datasets.md)   
 [Add new data sources](../data-tools/add-new-data-sources.md)   
 [Data Sources Window](http://msdn.microsoft.com/library/0d20f699-cc95-45b3-8ecb-c7edf1f67992)   
 [How to: Connect to Data in a Database](../data-tools/how-to-connect-to-data-in-a-database.md)   
 [Validating Data](http://msdn.microsoft.com/library/b3a9ee4e-5d4d-4411-9c56-c811f2b4ee7e)