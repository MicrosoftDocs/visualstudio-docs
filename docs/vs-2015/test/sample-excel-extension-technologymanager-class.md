---
title: "Sample Excel Extension: TechnologyManager Class | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: 8a7b760d-b5ac-4451-9593-6ac1a0b95cdb
caps.latest.revision: 11
ms.author: jillfra
manager: jillfra
---
# Sample Excel Extension: TechnologyManager Class
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This class extends the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager> class and is responsible for providing core services for the [!INCLUDE[ofprexcel](../includes/ofprexcel-md.md)] extension. Although the base class has many methods, only a subset of them is used in this sample.

 Some methods just return a property value. Many of the methods are intended to allow the developer to override default algorithms build into the coded UI test engine. These methods throw a <xref:System.NotSupportedException> or return `null`, which tells the framework to use the default algorithm.

 Depending on the complexity of the underlying technology, developing the technology manager code could take from a few weeks to a few months. Excel provides an opportunity to create a potentially very extensive technology manager. This example is intentionally limited to Excel worksheets and cells and uses limited formatting.

 When it is possible, the technology manager code uses the .NET Remoting channel opened by the `Communicator` class to extract information from the Add-In running in the Excel process.

## COM Visibility
 Notice that this class and each of the element classes that extend the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement> class all have the <xref:System.Runtime.InteropServices.ComVisibleAttribute> with a value of `true` to make sure the classes are visible to COM.

## TechnologyName Property
 This override of the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager.TechnologyName%2A?displayProperty=fullName> property must provide a unique and meaningful name that identifies the underlying technology for every other component of the extension. For this extension, the value is "Excel".

## GetControlSupportLevel Method
 This override of the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager.GetControlSupportLevel%2A?displayProperty=fullName> method returns a number that indicates the level of support that the technology manager can offer for the control represented by the provided handle. The higher the returned value, the more the technology manager can support the control. In this case, the method checks the window that contains the control and if it is an Excel Worksheet, the method returns the highest value; otherwise, it returns zero, which indicates that no support is provided.

## Methods to Get an Element
 There are several important methods that are used by the coded UI testing framework to get an element specific to the technology by providing a handle, a point on the screen, or an element from a different technology. The code for these methods are self-explanatory. The base methods are as follows:

- <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager.GetFocusedElement%2A?displayProperty=fullName>

- <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager.GetElementFromPoint%2A?displayProperty=fullName>

- <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager.GetElementFromWindowHandle%2A?displayProperty=fullName>

- <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager.GetElementFromNativeElement%2A?displayProperty=fullName>

- <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager.ConvertToThisTechnology%2A?displayProperty=fullName>

## ParseQueryId Method
 When a coded UI test is created, the user can specify property values for some or all the controls in the test. These property values are used by the testing framework to create name-value pairs called search properties that are used to find specific UI controls during the test. All the search properties together represent the value of the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.QueryId%2A?displayProperty=fullName> property of every element in the technology, which includes every control. Because a control might have to be found several times during a test, this method gives the technology manager a way to optimize parsing of search properties for the given control. This method also returns a cookie that the framework can use for subsequent searches for that control. This implementation of the method uses the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.AndCondition.Match%2A?displayProperty=fullName> method to parse the search properties.

## MatchElement Method
 To perform a control search by the technology manager, you can implement the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager.Search%2A?displayProperty=fullName> method to either return an array of possible matches, or throw the <xref:System.NotSupportedException>, which tells the framework to use its own search algorithm. Either way, you must implement the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager.MatchElement%2A> method where this implementation again uses the <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.AndCondition.Match%2A?displayProperty=fullName> method.

## Navigation Methods
 These methods get the parent, children, or siblings of the provided element from the UI hierarchy. The code is simple and clearly commented.

## GetExcelElement Internal Method
 This internal method takes a window handle and information about an Excel element, and returns the requested Excel element.

## See Also
 <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyManager>
 <xref:System.NotSupportedException>
 <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement>
 <xref:System.Runtime.InteropServices.ComVisibleAttribute>
 <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.QueryId%2A>
 [Extending Coded UI Tests and Action Recordings to Support Microsoft Excel](../test/extending-coded-ui-tests-and-action-recordings-to-support-microsoft-excel.md)
