---
title: "Considerations for Unloading and Reloading Nested Projects | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "nested projects, unloading and reloading"
  - "projects [Visual Studio SDK], unloading and reloading nested"
ms.assetid: 06c3427e-c874-45b1-b9af-f68610ed016c
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Considerations for Unloading and Reloading Nested Projects
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

When you implement nested project types, you must perform additional steps when you unload and reload the projects. To correctly notify listeners to solution events, you must correctly raise the `OnBeforeUnloadProject` and `OnAfterLoadProject` events.  
  
 One reason you must raise these events in this manner is that you do not want source code control (SCC) to delete the items from the server and then add them back as something new if there is a `Get` operation from SCC. In that case, a new file would be loaded out of SCC and you have to unload and reload all the files in case they are different. SCC calls `ReloadItem`. Your implementation of that call is to delete the project and re-create it again by implementing `IVsFireSolutionEvents` to call `OnBeforeUnloadProject` and `OnAfterLoadProject`. When you perform this implementation, the SCC is informed that the project was temporarily deleted and added again. Therefore, the SCC does not operate on the project as if the project was actually deleted from the server and then added again.  
  
## Reloading Projects  
 To support reloading of nested projects, you implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2.ReloadItem%2A> method. In your implementation of `ReloadItem`, you close the nested projects and then re-create them.  
  
 Typically when a project is reloaded, the IDE raises the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnBeforeUnloadProject%2A> and the `M:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnAfterLoadProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy,Microsoft.VisualStudio.Shell.Interop.IVsHierarchy)` events. However, for nested projects that will be deleted and reloaded, the parent project initiates the process, not the IDE. Because the parent project does not raise solution events, and the IDE has no information about the initialization of the process, the events are not raised.  
  
 To handle this process, the parent project calls `QueryInterface` on the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFireSolutionEvents> interface off the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution> interface. `IVsFireSolutionEvents` has functions that tell the IDE to raise the `OnBeforeUnloadProject` event to unload the nested project, and then raise the `OnAfterLoadProject` event to reload the same project.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3>   
 [Nesting Projects](../../extensibility/internals/nesting-projects.md)
