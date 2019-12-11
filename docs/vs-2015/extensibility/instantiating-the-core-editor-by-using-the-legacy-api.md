---
title: "Instantiating the Core Editor By Using the Legacy API | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - instantiating editor"
ms.assetid: dda23b18-96ef-43c6-b0dc-06d15cbe5cbb
caps.latest.revision: 30
ms.author: gregvanl
manager: jillfra
---
# Instantiating the Core Editor By Using the Legacy API
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The editor is responsible for text editing functions such as insertion, deletion, copy, and paste. It combines these functions with those provided by language services, such as text coloring, indentation, and IntelliSense statement completion.  
  
 You can instantiate an instance of the core editor in one of three ways:  
  
- Explicitly create an instance of the core editor in a window.  
  
- Provide an editor factory which returns an instance of the core editor  
  
- Open a file from the project hierarchy.  
  
  The following sections discuss how to use the legacy API to instantiate the editor.  
  
## Explicitly Opening a Core Editor Instance  
 When explicitly obtaining an instance of the core editor:  
  
- Obtain a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer> to hold the document data object being edited.  
  
- Create a line oriented representation of the document data object by creating an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines> interface from the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer> interface.  
  
- Set <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines> as the document data object for an instance of the default implementation of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow> interface, using the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow.SetBuffer%2A> method.  
  
   Host the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow> instance in a <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame> interface by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.CreateToolWindow%2A> method.  
  
  At this point, displaying the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame> interface provides a window that contains an instance of the core editor.  
  
  However, this is not a very useful instance, because it does not have shortcut keys, or access to advanced features. To obtain access to shortcut keys and advanced features:  
  
- Use the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer.SetLanguageServiceID%2A> method to associate a language service and the document data object that the editor uses.  
  
- Either create your own shortcut keys, or use the system default by setting the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame> objects display properties. To do this, call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.SetGuidProperty%2A> method with the <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID> property.  
  
   To obtain and use non-standard shortcut keys, generate them using the .vsct file. For more information, see [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md).  
  
## How to Use an Editor factory to Obtain the Core Editor  
 When implementing a core editor with an editor factory using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> method, follow all the steps outlined in the previous section to explicitly host an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow> using an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer> document data object, in an <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame> object.  
  
 To display the text, obtain a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> interface from the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow> object and call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> method.  
  
 To provide a language service to the editor, call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer.SetLanguageServiceID%2A> method within the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> method.  
  
 To obtain default shortcut keys, unlike the previous section, you use the command context returned by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> method when obtaining the core editor from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> method.  
  
 If the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> method returns the same command GUID as the text editor, the instance of the core editor automatically obtains the default shortcut keys.  
  
 For general information, see [Walkthrough: Creating a Core Editor and Registering an Editor File Type](../extensibility/walkthrough-creating-a-core-editor-and-registering-an-editor-file-type.md).  
  
## See Also  
 [Inside the Core Editor](../extensibility/inside-the-core-editor.md)   
 [Opening and Saving Project Items](../extensibility/internals/opening-and-saving-project-items.md)   
 [Walkthrough: Creating a Core Editor and Registering an Editor File Type](../extensibility/walkthrough-creating-a-core-editor-and-registering-an-editor-file-type.md)
