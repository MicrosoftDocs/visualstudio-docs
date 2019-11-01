---
title: "Editor Factories | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - editor factories"
ms.assetid: cf4e8164-3546-441d-b465-e8a836ae7216
caps.latest.revision: 21
ms.author: gregvanl
manager: jillfra
---
# Editor Factories
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

An editor factory creates editor objects and puts them in a window frame, known as a physical view. It creates the document data and document view objects that are necessary to create editors and designers. An editor factory is required to create the Visual Studio core editor and any standard editor. A custom editor can also optionally be created with an editor factory.  
  
 You create an editor factory by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory> interface. The following example illustrates how to implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory> to create an editor factory:  
  
 [!code-csharp[VSSDKEditorFactories#1](../snippets/csharp/VS_Snippets_VSSDK/vssdkeditorfactories/cs/vssdkeditorfactoriespackage.cs#1)]
 [!code-vb[VSSDKEditorFactories#1](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkeditorfactories/vb/vssdkeditorfactoriespackage.vb#1)]  
  
 An editor is loaded the first time that you open a file type handled by that editor. You can choose to open either a specific editor or the default editor. If you select the default editor, the integrated development environment (IDE) determines the correct editor to open and then opens it. For more information, see [Determining Which Editor Opens a File in a Project](../extensibility/internals/determining-which-editor-opens-a-file-in-a-project.md).  
  
## Registering Editor Factories  
 Before you can use an editor that you have created, you first must register information about it, including the file extensions it can handle.  
  
 If your VSPackage is written in managed code, you can use the Managed Package Framework (MPF) method <xref:Microsoft.VisualStudio.Shell.Package.RegisterEditorFactory%2A> to register the editor factory after your VSPackage is loaded. If your VSPackage is written in unmanaged code, then you must register your editor factory by using the <xref:Microsoft.VisualStudio.Shell.Interop.SVsRegisterEditors> service.  
  
### Registering an Editor Factory by Using Managed Code  
 You must register your editor factory in your VSPackage's the `Initialize` method. First call `base.Initialize`, and then call <xref:Microsoft.VisualStudio.Shell.Package.RegisterEditorFactory%2A> for each editor factory  
  
 In managed code, there is no need to unregister an editor factory, because the VSPackage will handle this for you. Also, if your editor factory implements <xref:System.IDisposable>, it is automatically disposed when it is unregistered.  
  
### Registering an editor factory by using unmanaged code  
 In the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite%2A> implementation for your editor package, use the `QueryService` method to call `SVsRegisterEditors`. Doing this returns a pointer to <xref:Microsoft.VisualStudio.Shell.Interop.IVsRegisterEditors>. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRegisterEditors.RegisterEditor%2A> method by passing your implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory> interface. You must mplement <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory> in a separate class.  
  
## The Editor Factory Registration Process  
 The following process occurs when Visual Studio loads your editor using your editor factory:  
  
1. The [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project system calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A>.  
  
2. This method returns the editor factory. Visual Studio delays loading the editor's package, however, until a project system actually needs the editor.  
  
3. When a project system needs the editor, Visual Studio calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A>, a specialized method that returns both the document view and the document data objects.  
  
4. If calls by Visual Studio to your editor factory using <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> return both a document data object and a document view object, Visual Studio then creates the document window, places the document view object in it, and makes an entry into the running document table (RDT) for the document data object.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory>   
 [Running Document Table](../extensibility/internals/running-document-table.md)
