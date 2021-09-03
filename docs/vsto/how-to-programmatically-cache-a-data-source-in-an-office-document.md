---
title: "Cache data source in Office document programmatically"
description:  Learn how you can programmatically add a data object to the data cache in a document by calling the StartCaching method of a host item.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office applications [Office development in Visual Studio], data"
  - "datasets [Office development in Visual Studio], caching"
  - "StartCaching method"
  - "data caching [Office development in Visual Studio], programmatically"
  - "data [Office development in Visual Studio], caching"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically cache a data source in an Office document
  You can programmatically add a data object to the data cache in a document by calling the `StartCaching` method of a host item, such as a <xref:Microsoft.Office.Tools.Word.Document>, <xref:Microsoft.Office.Tools.Excel.Workbook>, or <xref:Microsoft.Office.Tools.Excel.Worksheet>. Remove a data object from the data cache by calling the `StopCaching` method of a host item.

 The `StartCaching` method and the `StopCaching` method are both private, but they appear in IntelliSense.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 When you use the `StartCaching` method to add a data object to the data cache, the data object does not need to be declared with the <xref:Microsoft.VisualStudio.Tools.Applications.Runtime.CachedAttribute> attribute. However, the data object must meet certain requirements to be added to the data cache. For more information, see [Cache data](../vsto/caching-data.md).

## To programmatically cache a data object

1. Declare the data object at the class level, not inside a method. This example assumes that you are declaring a <xref:System.Data.DataSet> named `dataSet1` that you want to cache programmatically.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs" id="Snippet12":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb" id="Snippet12":::

2. Instantiate the data object, and then call the `StartCaching` method of the document or worksheet instance and pass in the name of the data object.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs" id="Snippet13":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb" id="Snippet13":::

## To stop caching a data object

1. Call the `StopCaching` method of the document or worksheet instance and pass in the name of the data object. This example assumes that you have a <xref:System.Data.DataSet> named `dataSet1` that you want to stop caching.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs" id="Snippet14":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb" id="Snippet14":::

    > [!NOTE]
    > Do not call `StopCaching` from the event handler for the `Shutdown` event of a document or worksheet. By the time the `Shutdown` event is raised, it is too late to modify the data cache. For more information about the `Shutdown` event, see [Events in Office Projects](../vsto/events-in-office-projects.md).

## See also

- [Cache data](../vsto/caching-data.md)
- [How to: Cache data for use offline or on a server](../vsto/how-to-cache-data-for-use-offline-or-on-a-server.md)
- [How to: Cache data in a password-protected document](../vsto/how-to-cache-data-in-a-password-protected-document.md)
- [Access data in documents on the server](../vsto/accessing-data-in-documents-on-the-server.md)
- [Save data](../data-tools/save-data-back-to-the-database.md)
