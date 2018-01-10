---
title: "How to: Populate Documents with Data from Objects | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "documents [Office development in Visual Studio], populating with data"
  - "data [Office development in Visual Studio], adding to documents"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Populate Documents with Data from Objects
  Accesing data in a data object works the same way in document-level projects for Microsoft Office Word as it does in Windows Forms projects. You use the same tools and code to bring the data from an object into your solution, and you can use Windows Forms controls to display the data. In addition, you can display data by using host controls. Host controls are native objects in Microsoft Office Word that have been enhanced with events and data binding capability. For more information, see [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md).  
  
 [!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]  
  
 You must complete three basic steps to populate the document with data from an object:  
  
-   Add a control to the document that you can bind to data.  
  
-   Add a data object to the document.  
  
-   Connect the data object to the BindingSource.   
  
## Adding a Data Object  
  
#### To add a data object  
  
-   Open the **Data Sources** window and create a data source from an object. For more information, see [Add new data sources](/visualstudio/data-tools/add-new-data-sources).  
  
## Connecting the Data Object to the BindingSource  
 In document-level projects, you add controls to your document and bind them to data at design time.  
  
 In VSTO Add-in projects, you create controls and bind them at run time.  
  
### Document-Level Projects  
  
##### To connect the data object to the BindingSource  
  
1.  Drag the data field you want from the **Data Sources** window to your document. This automatically creates a control.  
  
2.  In your code, create an instance of the type of the object that you chose for the data source.  
  
3.  Assign the instance to the <xref:System.Windows.Forms.BindingSource.DataSource%2A> property of the <xref:System.Windows.Forms.BindingSource>.  
  
### Application-Level Projects  
  
##### To connect the data object to the BindingSource  
  
1.  In your code, create an instance of the type of the object that is associated with the data source.  
  
2.  Create an instance of a <xref:System.Windows.Forms.BindingSource>.  
  
3.  Assign the data source instance to the <xref:System.Windows.Forms.BindingSource.DataSource%2A> property of the <xref:System.Windows.Forms.BindingSource>.  
  
4.  Add the data source as a databinding to the control.  
  
## See Also  
 
 [Add new data sources](/visualstudio/data-tools/add-new-data-sources)   
 [Bind Windows Forms controls to data in Visual Stduio](/visualstudio/data-tools/bind-windows-forms-controls-to-data-in-visual-studio)
 
 [How to: Populate Documents with Data from a Database](../vsto/how-to-populate-documents-with-data-from-a-database.md)   
 [How to: Update a Data Source with Data from a Host Control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md)   
 [Connecting to Data in Windows Forms Applications](/visualstudio/data-tools/connecting-to-data-in-windows-forms-applications)   
 [BindingSource Component Overview](/dotnet/framework/winforms/controls/bindingsource-component-overview)  
  
  