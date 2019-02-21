---
title: "Language Services and the Core Editor | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], legacy - language services"
ms.assetid: e03199a6-ad5f-4075-bfba-8d36865112b7
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# Language services and the core editor
Editors in Visual Studio are frequently associated with a language service. Among other things, a language service provides syntax coloring, statement completion, IntelliSense, and text formatting.

## Core editors and document data objects
 When you access the core editor, you do not create document data and document view objects. The IDE creates and controls these two objects, and you obtain handles to them by making the appropriate calls in your editor factory implementation.

 For more information, see [Determine which editor opens a file in a project](../extensibility/internals/determining-which-editor-opens-a-file-in-a-project.md).

## Language services and the core editor
 By implementing a language service, you can control how data is displayed in the document view. A language service provides information and behavior that is specific to a given language, such as Visual C++. When you create a text buffer and determine the filename extension for the document you are opening, the text buffer determines the language service associated with this file name extension from a registry key, **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Editors\\{YourLanguageService GUID}\Extensions**. The standard VSPackage loading procedure then loads your VSPackage and an instance of your language service is created.

 A basic language service is shown in the following illustration.

 ![Language Service Model graphic](../extensibility/media/vslanguageservicemodel.gif "vsLanguageServiceModel")
Core editor and language service objects

 The document data object for the core editor is called a text buffer and is represented by the <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer> object. The document view object is called a text view and is represented by the <xref:Microsoft.VisualStudio.TextManager.Interop.VsCodeWindow> object. These two objects work together through the language service to provide a unified view of the core editor. Information from the text buffer and the text view displays in a document window called a code window. The code window document is managed by a code window manager.

## See also
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo>
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer>
- <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextView>
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindowManager>
- <xref:Microsoft.VisualStudio.TextManager.Interop.VsCodeWindow>
- [Provide a language service context by using the legacy API](../extensibility/providing-a-language-service-context-by-using-the-legacy-api.md)
- [IntelliSense hosting](../extensibility/intellisense-hosting.md)
- [Contained languages](../extensibility/contained-languages.md)
- [Develop a legacy language service](../extensibility/internals/developing-a-legacy-language-service.md)