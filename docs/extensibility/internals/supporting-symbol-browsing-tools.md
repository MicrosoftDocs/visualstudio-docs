---
title: Supporting Symbol-Browsing Tools
description: Visual Studio provides symbol browsing capabilities in Visual Studio. Learn how to extend these capabilities with libraries for the symbols in your components.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- symbols, symbol-browsing tools
- browsers, symbol browsers
- symbol-browsing tools
- libraries
- IVsLibrary2 interface, symbol-browsing tools
- IVsSimpleLibrary2 interface, symbol-browsing tools
- symbol-browsing tools, library manager
- symbols
- libraries, symbol-browsing tools
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Supporting Symbol-Browsing Tools

**Object Browser**, **Class View**, **Call Browser** and **Find Symbol Results** tools provide symbol browsing capabilities in Visual Studio. These tools display hierarchical tree views of symbols and show the relationships between the symbols in the tree. The symbols may represent namespaces, objects, classes, class members, and other language elements contained in various components. The components include Visual Studio projects, external .NET Framework components and type (.tlb) libraries. For more information, see [Viewing the Structure of Code](../../ide/viewing-the-structure-of-code.md).

## Symbol-Browsing Libraries
 As a language implementer, you can extend the Visual Studio symbol-browsing capabilities by creating libraries that track the symbols in your components and provide the lists of symbols to the Visual Studio object manager through a set of the interfaces. A library is described by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleLibrary2> interface. The Visual Studio object manager responds to requests for new data from the symbol-browsing tools by obtaining the data from the libraries and organizing it. It subsequently populates or updates the tools with the requested data. To obtain a reference to the Visual Studio object manager, <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2>, pass the <xref:Microsoft.VisualStudio.Shell.Interop.SVsObjectManager> service ID to the `GetService` method.

 Each library must register with the Visual Studio object manager, which collects the information on all libraries. To register a library, call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.RegisterSimpleLibrary%2A> method. Depending on which tool initiates the request, the Visual Studio object manager finds the appropriate library and requests data. The data travels between the libraries and the Visual Studio object manager in lists of symbols described by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2> interface.

 The Visual Studio object manager is responsible for periodically refreshing symbol-browsing tools to reflect the most current data contained in the libraries.

 The diagram below contains a sample of key elements of the requests/data exchange process between a library and the Visual Studio object manager. The interfaces in the diagram are part of a managed code application.

 ![Data flow between a library and the object manager](../../extensibility/internals/media/callbrowserdiagram.gif "CallBrowserDiagram")

 To provide the lists of symbols to the Visual Studio object manager, you must first register the library with the Visual Studio object manager by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.RegisterSimpleLibrary%2A> method. After the library is registered, the Visual Studio object manager requests certain information about the capabilities of the library. For example, it requests the library flags and supported categories by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleLibrary2.GetLibFlags2%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleLibrary2.GetSupportedCategoryFields2%2A> methods. At some point, when one of the tools requests data from this library, the object manager requests the top-level list of symbols by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleLibrary2.GetList2%2A> method. In response, the library manufactures a list of symbols and exposes it to the Visual Studio object manager through the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2> interface. The Visual Studio object manager determines how many items are in the list by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetItemCount%2A> method. All following requests relate to a given item in the list and supply the item index number in each request. The Visual Studio object manager proceeds to collect the information on the type, the accessibility, and other properties of the item by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetCategoryField2%2A> method.

 It determines the name of the item by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetTextWithOwnership%2A> method and requests the icon information by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetDisplayData%2A> method. The icon is displayed to the left of the item name and depicts the type of the item, the accessibility, and other properties.

 The Visual Studio object manager calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetExpandable3%2A> method to determine if a given list item is expandable and has children items. If UI sends a request to expand an element, the object manager requests the child list of symbols by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetList2%2A> method. The process continues with different parts of the tree being built on demand.

> [!NOTE]
> To implement a native code symbol provider, use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsLibrary2> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectList2> interfaces.

## Related content
- [How to: Register a Library with the Object Manager](../../extensibility/internals/how-to-register-a-library-with-the-object-manager.md)
- [How to: Expose Lists of Symbols Provided by the Library to the Object Manager](../../extensibility/internals/how-to-expose-lists-of-symbols-provided-by-the-library-to-the-object-manager.md)
- [How to: Identify Symbols in a Library](../../extensibility/internals/how-to-identify-symbols-in-a-library.md)
