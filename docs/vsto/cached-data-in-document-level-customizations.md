---
title: "Cached data in document-level customizations"
description: Learn how Visual Studio separates the data from the view in document-level customizations by enabling data to be embedded as a data cache.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "data islands [Office development in Visual Studio]"
  - "view [Office development in Visual Studio]"
  - "caching data [Office development in Visual Studio], about caching data"
  - "data caching [Office development in Visual Studio], about data caching"
  - "data [Office development in Visual Studio], cache"
  - "data [Office development in Visual Studio], document-level solutions"
  - "document-level customizations [Office development in Visual Studio], data model"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Cached data in document-level customizations

  A primary goal of document-level customizations is to separate data from view in Office documents. Data refers to the information that is stored in the document, including numbers and text. View refers to the user interface and the object model of Microsoft Office Word and Microsoft Office Excel.

 Visual Studio separates the data from the view in document-level customizations by enabling data to be embedded as a *data island*, also called the *data cache*. You can read or modify the data directly without starting Word or Excel. This is useful when you need to modify data in documents on a server that does not have Microsoft Office installed. Word and Excel are intended for use in client environments; they are not designed to be run on a server.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 For more information about document-level customizations, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md) and [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md).

## Understand the cached data programming model
 The data island can contain any object in your solution that meets certain requirements. These objects include <xref:System.Data.DataSet> objects, <xref:System.Data.DataTable> objects, and any other object that can be serialized by the <xref:System.Xml.Serialization.XmlSerializer> class. For more information, see [Cache data](../vsto/caching-data.md).

 To provide the view for the cached data, you can bind Windows Forms controls and *host controls* on the document to objects in the data island. Data binding between the data island and the data-bound controls keeps the two synchronized. You can also add validation code to the data that is independent of the controls. For more information, see [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md).

 Host controls are extended versions of native objects in the Excel and Word object models. Unlike the native objects, host controls can be bound directly to managed data objects. For more information, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md) and [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md).

## Access cached data on the server
 To access cached data in a document, you can use the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class. This class is part of the  Visual Studio Tools for Office runtime , and it can be used on a server without running Excel or Word. When the user opens the document after you modify the cached data, any controls that are bound to the data are automatically synchronized to the changes, and the user is presented with the updated data. For more information, see [Access data in documents on the server](../vsto/accessing-data-in-documents-on-the-server.md).

 Excel and Word are not needed to write to the data on the server, only to view it on the client. Excel and Word do not even need to be installed on the server. This provides improved scalability and the ability to perform fast batch processing of documents that contain data islands.

## Data caching for offline use
 Storing data in the data island enables offline scenarios. When a user first opens a document or requests the document from the server, the data island is filled with the most recent data. The data island is cached in the document and is then available offline. The user (and your code) can manipulate the data, even though no live connection is available. When the user reconnects, the changes to the data can be propagated back to a server data source.

## Cached data and custom XML parts compared
 Custom XML parts were introduced in the 2007 Microsoft Office system as a way to store arbitrary pieces of XML in a document. Although custom XML parts are useful in many of the same scenarios as the data cache, there are some differences between the data island and custom XML parts. For more information about custom XML parts, see [Custom XML parts overview](../vsto/custom-xml-parts-overview.md).

 The following table lists some of the differences and similarities.

|Question / Characteristic|Data cache|Custom XML parts|
|-|----------------|----------------------|
|Which Office applications can use these?|Document-level customizations for the following applications:<br /><br /> -   Excel<br />-   Word|Document-level and application-level solutions for the following applications:<br /><br /> -   Excel<br />-   PowerPoint<br />-   Word|
|What types of data can you store?|Any public object in your customization assembly that meets certain requirements. For more information, see [Cache data](../vsto/caching-data.md).|Any XML data.|
|Can you access the data without starting Microsoft Office applications?|Yes, by using the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class provided by the  Visual Studio Tools for Office runtime .|Yes, by using classes in the <xref:System.IO.Packaging> namespace, or by using the Open XML Format SDK.|

## Related content
- [Data in Office solutions](../vsto/data-in-office-solutions.md)
- [Architecture of Office solutions in Visual Studio](../vsto/architecture-of-office-solutions-in-visual-studio.md)
