---
title: Creating Custom Editors and Designers
description: "Learn about the different types of editors that can by hosted by the Visual Studio IDE: the core editor, custom editors, external editors, and designers."
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- designers [Visual Studio SDK]
- editors [Visual Studio SDK], custom
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create custom editors and designers

The Visual Studio integrated development environment (IDE) can host different types of editor:

- The Visual Studio core editor

- Custom editors

- External Editors

- Designers

The following information helps you choose the type of editor you need.

## Types of editor

For information about the Visual Studio core editor, see [Extend the editor and language services](../extensibility/extending-the-editor-and-language-services.md).

### Custom editors
 A custom editor is one that is designed to work in specialized circumstances. For example, you might create an editor whose function is to read and write data to a specific repository, such as a Microsoft Exchange server. Choose a custom editor if you want an editor that works with your project type only or if you want an editor that has only a few specific commands. Note, however, that users will not be able to use a custom editor to edit standard Visual Studio projects.

 A custom editor can use an editor factory and add information about the editor to the registry. However, the project type associated with the custom editor can instantiate the custom editor in other ways.

 A custom editor can use either in-place activation or simplified embedding to implement a view.

### External editors
 External editors are editors that are not integrated into Visual Studio, such as Microsoft Word, Notepad, or Microsoft FrontPage. You might call such an editor if, for example, you are passing text to it from your VSPackage. External editors register themselves and can be used outside Visual Studio. When you call an external editor, and it can be embedded in a host window, then it appears in a window in the IDE. If not, then the IDE creates a separate window for it.

 The <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.IsDocumentInProject%2A> method sets the document priority by using the <xref:Microsoft.VisualStudio.Shell.Interop.VSDOCUMENTPRIORITY> enumeration. If the `DP_External` value is specified, the file can be opened by an external editor.

## Editor design decisions
 The following design questions will help you to choose the type of editor best suited to your application:

- Will your application save its data in files or not? If it will save its data in files, will they be in a custom or standard format?

   If you use a standard file format, other project types in addition to your project will be able to open and read/write data to them. If you use a custom file format, however, only your project type will be able to open and read/write data to them.

   If your project uses files, then you should customize the standard editor. If your project does not use files, but rather uses items in a database or other repository, then you should create a custom editor.

- Does your editor need to host ActiveX controls?

   If your editor hosts ActiveX controls, then implement an in-place activation editor, as outlined in [In-place activation](/previous-versions/visualstudio/visual-studio-2015/misc/in-place-activation?preserve-view=true&view=vs-2015). If it does not host ActiveX controls, then either use a simplified embedding editor, or customize the Visual Studio default editor.

- Will your editor support multiple views? You must support multiple views if you want views of your editor to be visible at the same time as the default editor.

   If your editor needs to support multiple views, the document data and document view objects for the editor must be separate objects. For more information, see [Support multiple document views](../extensibility/supporting-multiple-document-views.md).

   If your editor supports multiple views, do you plan to use the Visual Studio core editor's text buffer implementation (<xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer> object) for your document data object? That is, do you want to support your editor view side-by-side with the Visual Studio core editor? The ability to do this is the basis of the forms designer..

- If you need to host an external editor , can the editor be embedded inside Visual Studio?

   If it can be embedded, you should create a host window for the external editor and then call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.IsDocumentInProject%2A> method and set the <xref:Microsoft.VisualStudio.Shell.Interop.VSDOCUMENTPRIORITY> enumeration value to `DP_External`. If the editor cannot be embedded, the IDE will automatically create a separate window for it.

## In This Section

[Walkthrough: Create a custom editor](../extensibility/walkthrough-creating-a-custom-editor.md)\
Explains how to create a custom editor.

[Walkthrough: Add features to a custom editor](../extensibility/walkthrough-adding-features-to-a-custom-editor.md)\
Explains how to add features to a custom editor.

[Designer initialization and metadata configuration](../extensibility/designer-initialization-and-metadata-configuration.md)\
Explains how to initialize a designer.

[Supply undo support to designers](../extensibility/supplying-undo-support-to-designers.md)\
Explains how to provide undo support for designers.

[Syntax coloring in custom editors](../extensibility/syntax-coloring-in-custom-editors.md)\
Explains the difference between syntax coloring in the core editor and in custom editors.

[Document data and document view in custom editors](../extensibility/document-data-and-document-view-in-custom-editors.md)\
Explains how to implement document data and document views in custom editors.

## Related content

- [Legacy interfaces in the editor](/previous-versions/visualstudio/visual-studio-2015/extensibility/legacy-interfaces-in-the-editor?preserve-view=true&view=vs-2015)\
Explains how to access the core editor by means of the legacy API.

- [Develop a legacy language service](../extensibility/internals/developing-a-legacy-language-service.md)\
Explains how to implement a language service.

- [Extend other parts of Visual Studio](../extensibility/extending-other-parts-of-visual-studio.md)\
Explains how to create UI elements that match the rest of Visual Studio.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory>
