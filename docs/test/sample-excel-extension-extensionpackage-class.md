---
title: "Sample Excel Extension: ExtensionPackage Class | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6e45410a-1819-4d54-ac21-7280152f7e3a
caps.latest.revision: 9
ms.author: "mlearned"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Sample Excel Extension: ExtensionPackage Class
This class extends the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage> class and provides the entry point for a coded UI test that is testing an [!INCLUDE[ofprexcel](../test/includes/ofprexcel_md.md)] Worksheet.  
  
## Assembly Attribute  
 The file begins with an assembly attribute that identifies the assembly as a UI Test Extension.  
  
```  
[assembly: Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage(  
    "ExcelExtensionPackage",  
    typeof(  
     Microsoft.VisualStudio.Test.Sample.UI.ExtensionPackage))]  
```  
  
 This attribute declares the base class name, the name of the package class, and the fully qualified class name for the custom extension package class.  
  
## Simple Properties  
 This class has properties that provide values that are used by the coded UI testing framework to identify and describe the extension and the assembly. See the code comments for more information.  
  
## GetService Method  
 The <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage.GetService%2A> method is the single entry point used by the coded UI testing framework to gain access to the technology manager, the property provider, and the action filter, as identified by the base class for each object.  
  
## See Also  
 <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage>   
 [Extending Coded UI Tests and Action Recordings to Support Microsoft Excel](../test/extending-coded-ui-tests-and-action-recordings-to-support-microsoft-excel.md)