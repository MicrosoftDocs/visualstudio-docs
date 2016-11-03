---
title: "Data User Interface Elements | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.data.tablemappings"
  - "vs.datasource.choosebindingsourcedialog"
  - "vs.datasource.choosedatasourceinstancedlg"
  - "vs.data.editrelation"
  - "DSD_EditMultiKey"
  - "vs.datasource.RealtionBuilder"
  - "vs.xmldesigner.editkey"
  - "vs.xmldesigner.choosekey"
  - "vs.data.generatedataset"
  - "vs.data.configurationerror"
  - "vs.data.DSD_MissingConnections_Message"
  - "vs.datasource.choosedesigndatasourcedlg"
  - "vs.data.datapreview"
  - "vs.data.editforeignkeyconstraint"
  - "vs.datasource.choosedataconectordialog"
  - "vs.data.dataadapterpreview"
  - "vs.data.configurationwizard"
  - "vs.data.datapreviewdialog"
  - "DSD_EditMultiKeyHelpID"
  - "vs.data.advancedoptions"
  - "vs.data.previewscript"
  - "vs.data.datasourcelogin"
  - "vs.syncdesigner.syncnowconflictiondialog"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "dialog boxes, data"
  - "data [Visual Studio], dialog boxes"
ms.assetid: 90943baf-5bd1-4eef-927f-f82485979fde
caps.latest.revision: 18
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
# Data User Interface Elements
This section contains information about all the dialog boxes and wizards that you use when designing data access in your [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] or Visual C# applications.  
  
 [!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]  
  
## In This Section  
 [Data Smart Tags](http://msdn.microsoft.com/en-us/1e0a848f-c57b-47ab-b884-eaaa40726f43)  
 Provides information on some smart tag commands that are available for data.  
  
 [Add Dataset Dialog Box](http://msdn.microsoft.com/en-us/0e03c0ff-212b-4bfa-ac51-3c2adb71ead0)  
 Puts an existing typed dataset or a new untyped dataset (an instance of the **System.Data.Dataset** class) onto a form or component.  
  
 [Advanced SQL Generation Options Dialog Box](http://msdn.microsoft.com/en-us/41420450-1ff4-4a1a-b85b-6f6901538fef)  
 Allows you to control how SQL statements or stored procedures are created for a data adapter by specifying options for updates, optimistic concurrency, and refreshing the dataset.  
  
 [Choose a Data Source Instance Dialog Box](http://msdn.microsoft.com/en-us/51c47f06-fdc5-453e-9178-0a5a2c5c9f34)  
 Allows you to select the desired dataset from a list of datasets in your project.  
  
 [Choose a Data Source to Merge with Dialog Box](http://msdn.microsoft.com/en-us/accafff7-f6bd-481c-a121-fe8a76cd681d)  
 Allows you to select which data source to merge with when multiple data sources are available.  
  
 [Choose Key Dialog Box](http://msdn.microsoft.com/en-us/4ddbfbb7-a80a-412a-b80d-291d86376ca3)  
 Allows you select a key when a column participates in a multi-key constraint.  
  
 [Collection Editors](../Topic/Collection%20Editors.md)  
 Provides links to topics about different collection editors that allow you to create and edit individual members of a collection.  
  
 [Connections Missing](http://msdn.microsoft.com/en-us/bb9b2e12-7f76-4ee5-acbb-5d20116ee044)  
 Informs you when a dataset contains a reference to a connection string that is not in application settings.  
  
 [Data Adapter Configuration Error Dialog Box](http://msdn.microsoft.com/en-us/9ce65cd2-0c7d-4f51-8685-d68be5f3009b)  
 Displays one or more errors that occurred while Visual Studio was attempting to create an instance of a data adapter and set its properties.  
  
 [Data Adapter Configuration Wizard](http://msdn.microsoft.com/en-us/efff90cb-0e4c-4eb3-87dc-65dd9d418809)  
 Configures SQL commands or stored procedures that a data adapter uses to read data into a dataset from a database and write it back again. The topic describes how to run the wizard and what to do after the wizard has completed.  
  
 [Data Adapter Preview Dialog Box](http://msdn.microsoft.com/en-us/1f614cd3-4530-457e-84af-00ccbaea08cc)  
 Allows you to see how data will be filled into a dataset by a data adapter, which is useful for testing that the adapter is returning the data you expect, that table mappings work properly, and the effect of different parameter values.  
  
 [Data Source Login Dialog Box](http://msdn.microsoft.com/en-us/6f2d9a57-53c3-4841-bd37-a3643eb68d2e)  
 Allows you to request access to a data source (typically a database) for which you have not already been authenticated.  
  
 [DataSet Tab, Toolbox](http://msdn.microsoft.com/en-us/fa5f2d6f-924d-4262-ba1b-e9e7f90e7764)  
 Displays the objects you can add to a typed dataset.  
  
 [Do you want to include the password in the connection string Dialog Box](http://msdn.microsoft.com/en-us/193696a7-5213-4396-8328-05ac2df6ee94)  
 Allows you to control whether a password is embedded into the connection string.  
  
 [Edit Key Dialog Box](http://msdn.microsoft.com/en-us/f5c80e39-3a42-4284-b222-6ca009fd9675)  
 Allows you to define and edit keys.  
  
 [Foreign Key Constraint Dialog Box](http://msdn.microsoft.com/en-us/45d15629-1f4d-40a7-8708-c9ddfebedc1e)  
 Allows you to place a foreign key constraint on one or more columns in a dataset table that is related to another table.  
  
 [Generate Dataset Dialog Box](http://msdn.microsoft.com/en-us/c0efdbaf-13b1-4ee8-ade6-f8a784126cdc)  
 Allows you to generate a new typed dataset from information provided by one or more data adapters and to add tables to an existing dataset.  
  
 [Multiple BindingSources Dialog Box](http://msdn.microsoft.com/en-us/db76f70c-4fb5-479d-9b64-a67158d48f97)  
 Allows you to select which <xref:System.Windows.Forms.BindingSource> to use when more than one <xref:System.Windows.Forms.BindingSource> is available.  
  
 [Preview Data Dialog Box](http://msdn.microsoft.com/en-us/aa4f0d04-2695-4bb8-946d-54a97ae7287f)  
 Allows you to review the data returned by queries in your project.  
  
 [Preview SQL Script Dialog Box](http://msdn.microsoft.com/en-us/e9571e8b-821c-492d-9bc8-b44eba898bdd)  
 Appears as part of the [Data Adapter Configuration Wizard](http://msdn.microsoft.com/en-us/efff90cb-0e4c-4eb3-87dc-65dd9d418809) to allow you to see the SQL script the wizard will use to create stored procedures to read and write data.  
  
 [Relation Dialog Box](http://msdn.microsoft.com/en-us/ab8f4b0e-af4c-4725-a550-e2b2ebe43a02)  
 Allows you to create a relationship (a **DataRelation** object) that maintains information about parent-child records in two data tables in a dataset.  
  
 [Search Criteria Builder Dialog Box](../Topic/Search%20Criteria%20Builder%20Dialog%20Box.md)  
 Allows you to create a parameterized query on a data-bound Windows Form, and automatically add the controls required to run the query.  
  
 [Table Mappings Dialog Box](http://msdn.microsoft.com/en-us/fb4cec1e-f3c8-4773-b409-c2de15293fea)  
 Allows you to specify which columns in a database table or other data source are equivalent to columns in a dataset table.  
  
 [Unique Constraint Dialog Box](http://msdn.microsoft.com/en-us/e71a60d7-fae2-4bd0-a1e8-43aae351707d)  
 Allows you to place a unique constraint on one or more columns in a table in an untyped dataset.  
  
## Related Sections  
 [Accessing Data](../data-tools/accessing-data-in-visual-studio.md)  
 Provides links to topics that describe how to access data in your Visual Basic and Visual C# applications.  
  
## See Also  
 [Overview of Data Applications in Visual Studio](../data-tools/overview-of-data-applications-in-visual-studio.md)   
 [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../data-tools/saving-data.md)