---
title: "Sample Coded UI Test Extension for Excel | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
helpviewer_keywords:
  - "coded UI tests, extensions for Excel"
ms.assetid: 451e4d14-7fac-42f9-af56-2bdc8414c6c7
caps.latest.revision: 15
ms.author: jillfra
manager: jillfra
---
# Sample Coded UI Test Extension for Excel
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The extension component of the sample runs in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Coded UI Test process and is somewhat hierarchical with the `ExtensionPackage` class at the base. The `TechnologyManager`, `ActionFilter`, and `PropertyProvider` classes are at the next level, with the control elements at the top level.

 ![Excel Test Extension Architecture](../test/media/excel-extarch.png "Excel_ExtArch")
Excel Extension Architecture

## Extension Points
 These classes represent the extension points that are implemented in the sample to enable coded UI testing for [!INCLUDE[ofprexcel](../includes/ofprexcel-md.md)].

### ExtensionPackage
 Inherited from the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage> class, this is the entry point for the coded UI testing extension. Implementing this abstract class gives the coded UI testing framework internal access to your custom UI test technology manager, UI test property provider, and UI test action filter for testing the new UI. For more information, see [ExtensionPackage Class](../test/sample-excel-extension-extensionpackage-class.md).

### TechnologyManager
 Inherited from the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager> class, this class provides a technology manager for test recording and playback. For more information, see [TechnologyManager Class](../test/sample-excel-extension-technologymanager-class.md).

### ActionFilter
 Inherited from the [UITestActionFilter](/previous-versions/visualstudio/visual-studio-2012/dd985757(v=vs.110)) class, this class provides a base class for aggregating similar test action results into a single test result. For more information, see [ActionFilter Class](../test/sample-excel-extension-actionfilter-class.md).

### Technology Elements
 A base class inherited from the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement> class provides the foundation for the technology elements in your UI tests that can be recorded and played back. For more information, see [Element Classes](../test/sample-excel-extension-element-classes.md).

### PropertyProvider
 Inherited from the <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestPropertyProvider> class, this class provides a base class for supporting the properties of UI elements for test recording and playback. For more information, see [PropertyProvider Class](../test/sample-excel-extension-propertyprovider-class.md).

## See also

- <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestPropertyProvider>
- <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement>
- <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage>
- [ExtensionPackage Class](../test/sample-excel-extension-extensionpackage-class.md)
- [TechnologyManager Class](../test/sample-excel-extension-technologymanager-class.md)
- [ActionFilter Class](../test/sample-excel-extension-actionfilter-class.md)
- [Element Classes](../test/sample-excel-extension-element-classes.md)
- [PropertyProvider Class](../test/sample-excel-extension-propertyprovider-class.md)
