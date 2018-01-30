---
title: "How to: Cache Data for Use Offline or on a Server | Microsoft Docs"
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
  - "data caching [Office development in Visual Studio], server use"
  - "Office applications [Office development in Visual Studio], data"
  - "datasets [Office development in Visual Studio], caching"
  - "offline data [Office development in Visual Studio]"
  - "data [Office development in Visual Studio], caching"
  - "data caching [Office development in Visual Studio], offline use"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Cache Data for Use Offline or on a Server
  You can mark a data item to be cached in the document, so that it is available offline. This also makes it possible for the data in the document to be manipulated by other code when the document is stored on a server.  
  
 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]  
  
 You can mark a data item to be cached when the data item is declared in your code, or, if you are using a <xref:System.Data.DataSet>, by setting a property in the **Properties** window. If you are caching a data item that is not a <xref:System.Data.DataSet> or <xref:System.Data.DataTable>, ensure that it meets the criteria for being cached in the document. For more information, see [Caching Data](../vsto/caching-data.md).  
  
> [!NOTE]  
>  Datasets created using Visual Basic that are marked as **Cached** and **WithEvents** (including datasets that are dragged from the **Data Sources** window or **Toolbox** that have the **CacheInDocument** property set to **True**) have an underscore prefixed to their names in the cache. For example, if you create a dataset and name it **Customers**, the <xref:Microsoft.VisualStudio.Tools.Applications.CachedDataItem> name will be **_Customers** in the cache. When you use <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> to access this cached item, you must specify **_Customers** instead of **Customers**.  
  
### To cache data in the document using code  
  
1.  Declare a public field or property for the data item as a member of a host item class in your project, such as the `ThisDocumen`t class in a Word project or the `ThisWorkbook` class in an Excel project.  
  
2.  Apply the <xref:Microsoft.VisualStudio.Tools.Applications.Runtime.CachedAttribute> attribute to the member to mark the data item to be stored in the document's data cache. The following example applies this attribute to a field declaration for a <xref:System.Data.DataSet>.  
  
     [!code-csharp[Trin_VstcoreDataExcel#11](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#11)]
     [!code-vb[Trin_VstcoreDataExcel#11](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb#11)]  
  
3.  Add code to create an instance of the data item and, if applicable, to load it from the database.  
  
     The data item is only loaded when it is first created; thereafter, the cache stays with the document and you must write other code to update it.  
  
### To cache a dataset in the document by using the Properties window  
  
1.  Add the dataset to the project by using tools in the Visual Studio designer, for example, by adding a data source to your project using the **Data Sources** window.  
  
2.  Create an instance of the dataset if you do not already have one, and select the instance in the designer.  
  
3.  In the **Properties** window, set the **CacheInDocument** property to **True**.  
  
     For more information, see [Properties in Office Projects](../vsto/properties-in-office-projects.md).  
  
4.  In the **Properties** window, set the **Modifiers** property to **Public** (by default it is **Internal**).  
  
## See Also  
 [Caching Data](../vsto/caching-data.md)   
 [How to: Programmatically Cache a Data Source in an Office Document](../vsto/how-to-programmatically-cache-a-data-source-in-an-office-document.md)   
 [How to: Cache Data in a Password-Protected Document](../vsto/how-to-cache-data-in-a-password-protected-document.md)   
 [Accessing Data in Documents on the Server](../vsto/accessing-data-in-documents-on-the-server.md)   
 [Saving Data](/visualstudio/data-tools/saving-data)  
  
  