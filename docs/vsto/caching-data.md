---
title: "Caching Data | Microsoft Docs"
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
  - "data caching [Office development in Visual Studio], about caching data"
  - "data [Office development in Visual Studio], caching"
  - "data caching [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Caching Data
  You can cache data objects in a document-level customization so that the data can be accessed offline, or without opening Microsoft Office Word or Microsoft Office Excel. To cache an object, the object must have a data type that meets certain requirements. Many common data types in the .NET Framework meet these requirements, including <xref:System.String>, <xref:System.Data.DataSet>, and <xref:System.Data.DataTable>.  
  
 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]  
  
 There are two ways to add an object to the data cache:  
  
-   To add an object to the data cache when the solution is built, apply the <xref:Microsoft.VisualStudio.Tools.Applications.Runtime.CachedAttribute> attribute to the object declaration. For more information, see [How to: Cache Data for Use Offline or on a Server](../vsto/how-to-cache-data-for-use-offline-or-on-a-server.md).  
  
-   To programmatically add an object to the data cache at run time, use the `StartCaching` method of a host item, such as the `ThisDocument` or `ThisWorkbook` classes. For more information, see [How to: Programmatically Cache a Data Source in an Office Document](../vsto/how-to-programmatically-cache-a-data-source-in-an-office-document.md).  
  
 After you add an object to the data cache, you can access and modify the cached data without starting Word or Excel. For more information, see [Accessing Data in Documents on the Server](../vsto/accessing-data-in-documents-on-the-server.md).  
  
## Requirements for Data Objects to be Cached  
 To cache a data object in your solution, the object must meet these requirements:  
  
-   Be a read/write public field or property of a host item, such as the `ThisDocument` or `ThisWorkbook` classes.  
  
-   Not be an indexer or other parameterized property.  
  
 In addition, the data object must be serializable by the <xref:System.Xml.Serialization.XmlSerializer> class, which means the type of the object must have these characteristics:  
  
-   Be a public type.  
  
-   Have a public constructor with no parameters.  
  
-   Not execute code that requires additional security privileges.  
  
-   Expose only read/write public properties (other properties will be ignored).  
  
-   Not expose multi-dimensional arrays (nested arrays are accepted).  
  
-   Not return interfaces from properties and fields.  
  
-   Not implement <xref:System.Collections.IDictionary> if a collection.  
  
 When you cache a data object, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] serializes the object into an XML string that is stored in a *custom XML part* in the document. For more information, see [Custom XML Parts Overview](../vsto/custom-xml-parts-overview.md).  
  
## Cached Data Size Limits  
 There are some limits to the total amount of data you can add to the data cache in a document, and to the size of any individual object in the data cache. If you exceed these limits, the application might close unexpectedly when the data is saved to the data cache.  
  
 To avoid these limits, follow these guidelines:  
  
-   Do not add any object larger than 10 MB to the data cache.  
  
-   Do not add more than 100 MB of total data to the data cache in a single document.  
  
 These are approximate values. The exact limits depend on several factors, including the available RAM and the number of running processes.  
  
## Controlling the Behavior of Cached Objects  
 To gain more control over the behavior of a cached object, you can implement the <xref:Microsoft.VisualStudio.Tools.Applications.Runtime.ICachedType> interface on the type of the cached object. For example, you can implement this interface if you want to control how the user is notified when the object has been changed. For code examples that demonstrate how to implement <xref:Microsoft.VisualStudio.Tools.Applications.Runtime.ICachedType>, see the `ControlCollection` class in the Excel Dynamic Controls Sample and Word Dynamic Controls Sample in [Office Development Samples and Walkthroughs](../vsto/office-development-samples-and-walkthroughs.md).  
  
## Persisting Changes to Cached Data in Password-Protected Documents  
 If you cache data objects in a document that is protected with a password, changes to the cached data are not saved. You can save changes to the cached data by overriding two methods. Override these methods to temporarily remove the protection when the document is saved, and then reapply the protection after the save operation is complete.  
  
 For more information, see [How to: Cache Data in a Password-Protected Document](../vsto/how-to-cache-data-in-a-password-protected-document.md).  
  
## Preventing Data Loss When Adding Null Values to the Data Cache  
 When you add objects to the data cache, all of the cached objects must be initialized to a non-**null** value before the document is saved and closed. If any cached object has a **null** value when the document is saved and closed, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] will automatically remove all of the cached objects from the data cache.  
  
 If you add an object with a **null** value to the data cache by using the <xref:Microsoft.VisualStudio.Tools.Applications.Runtime.CachedAttribute> attribute at design time, you can use the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class to initialize the cached data objects before the document is opened. This is useful if you want to initialize the cached data on a server without Word or Excel installed, before the document is opened by an end user. For more information, see [Accessing Data in Documents on the Server](../vsto/accessing-data-in-documents-on-the-server.md).  
  
## See Also  
 [How to: Cache Data for Use Offline or on a Server](../vsto/how-to-cache-data-for-use-offline-or-on-a-server.md)   
 [How to: Programmatically Cache a Data Source in an Office Document](../vsto/how-to-programmatically-cache-a-data-source-in-an-office-document.md)   
 [How to: Cache Data in a Password-Protected Document](../vsto/how-to-cache-data-in-a-password-protected-document.md)   
 [Walkthrough: Creating a Master Detail Relation Using a Cached Dataset](../vsto/walkthrough-creating-a-master-detail-relation-using-a-cached-dataset.md)  
  
  