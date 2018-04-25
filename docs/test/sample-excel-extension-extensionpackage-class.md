---
title: "Sample Excel Extension: ExtensionPackage Class"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
ms.topic: sample
ms.author: gewarren
manager: douge
ms.workload: 
  - "multiple"
author: gewarren
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

## See also

- <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage>
- [Extending Coded UI Tests and Action Recordings to Support Microsoft Excel](../test/extending-coded-ui-tests-and-action-recordings-to-support-microsoft-excel.md)
