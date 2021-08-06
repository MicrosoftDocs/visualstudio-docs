---
title: "How to: Populate documents with data from services"
description: Learn how you can use the data from services in your solution, and how you can use Windows Forms controls to display the data in a document.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], populating with data"
  - "Web services [Office development in Visual Studio], populating documents"
  - "data [Office development in Visual Studio], adding to documents"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Populate documents with data from services

Data access works the same way in document-level projects for Microsoft Office as it does in Windows Forms projects. You use the same tools and code to bring the data into your solution, and you can even use Windows Forms controls to display the data. In addition, you can take advantage of controls called host controls, which are native objects in Microsoft Office Excel and Microsoft Office Word that have been enhanced with events and data binding capability. For more information, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

[!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

The following example shows how to add data-bound controls to documents at design time. For an example of how to add data-bound controls in VSTO Add-ins at run time, see [Walkthrough: Bind to data from a service in a VSTO Add-in project](../vsto/walkthrough-binding-to-data-from-a-service-in-a-vsto-add-in-project.md).

## To populate a document-level project with data from a web service

1. Open the **Data Sources** window and create a service data source for your project. For more information, see [Add new data sources](../data-tools/add-new-data-sources.md).

2. Drag the table or field you want from the **Data Sources** window to your document.

     A control is created on the document, a <xref:System.Windows.Forms.BindingSource> is created that is bound to the object class in your project, and classes are generated for the service.

3. In your code, create an instance of the web service class that you connected to in step 1.

4. If there are properties that are required for communication with the web service, create instances of those properties.

5. Create and send a data request using methods exposed by the Web service and any property instances you created in step 4.

     The methods that you use depend on what the web service offers.

6. Assign the data response from the web service to the <xref:System.Windows.Forms.BindingSource.DataSource%2A> property of the <xref:System.Windows.Forms.BindingSource>.

When you run the project, the controls display the first record in the data source. You can enable scrolling through the records by handling the currency events using the objects in the <xref:System.Windows.Forms.BindingSource>.

## See also

- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Add new data sources](../data-tools/add-new-data-sources.md)
- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
- [How to: Populate worksheets with data from a database](../vsto/how-to-populate-worksheets-with-data-from-a-database.md)
- [How to: Populate documents with data from objects](../vsto/how-to-populate-documents-with-data-from-objects.md)
- [How to: Populate documents with data from a database](../vsto/how-to-populate-documents-with-data-from-a-database.md)
- [How to: Update a data source with data from a host control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md)