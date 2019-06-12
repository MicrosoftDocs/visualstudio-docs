---
title: "How to: Provide Context for Editors | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - provide context"
ms.assetid: 12df4d06-df6b-4eaf-a7bf-c83655a0c683
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# How to: Provide Context for Editors
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For an editor, the context is active only when the editor has focus or had focus immediately before the focus was moved to a tool window. You can provide context for an editor by doing the following:  
  
1. Create a context bag.  
  
2. Publish the context bag to the selection element identifier (SEID).  
  
3. Maintain the context in the bag.  
  
   These tasks are covered by the following procedures. For more information about providing context, see **Robust Programming** later in this topic.  
  
### To create a context bag for an editor or a designer  
  
1. Call `QueryService` on your <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider> interface for the <xref:Microsoft.VisualStudio.Shell.Interop.SVsMonitorUserContext> service.  
  
     A pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorUserContext> interface is returned.  
  
2. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorUserContext.CreateEmptyContext%2A> method to create a new context or subcontext bag.  
  
     A pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext> interface is returned.  
  
3. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AddAttribute%2A> method to add attributes, lookup keywords, or F1 keywords to the context or subcontext bag.  
  
4. If you are creating a subcontext bag, call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AddSubcontext%2A> method to link the subcontext bag to the parent context bag.  
  
5. Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AdviseUpdate%2A> to receive notification when the **Dynamic Help** window is about to update.  
  
     Having the **Dynamic Help** window call your editor when it is ready to update gives you the opportunity to delay changing the context until the update occurs. Doing this can improve performance because it allows you to delay running time-consuming algorithms until system idle time is available.  
  
### To publish the context bag to the SEID  
  
1. Call `QueryService` on the <xref:Microsoft.VisualStudio.Shell.Interop.SVsTrackSelectionEx> service to return a pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx> interface.  
  
2. Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx.OnElementValueChange%2A>, specifying an element identifier (`elementid` parameter) value of SEID_UserContext to indicate that you are passing context to the global level.  
  
3. When the editor or designer becomes active, the values in its <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx> object are propagated to the global selection. You only need to complete this process once per session, and then store the pointer to the global context created when you called <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx.OnElementValueChange%2A>.  
  
### To maintain the context bag  
  
1. Implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext> to ensure that the **Dynamic Help** window calls the editor or designer before it updates.  
  
     For each context bag that has called <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AdviseUpdate%2A> after the context bag is created and has implemented <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate>, the IDE calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate.UpdateUserContext%2A> to notify the context provider that the context bag will be updated. You can use this call to change the attributes and keywords in the context bag, and in any subcontext bags, before the **Dynamic Help** window update occurs.  
  
2. Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.SetDirty%2A> on the context bag to indicate that the editor or designer has new context.  
  
     When the **Dynamic Help** window calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate.UpdateUserContext%2A> to indicate that it is updating, the editor or designer can update the context appropriately for both the parent context bag and any subcontext bags at that time.  
  
    > [!NOTE]
    > The `SetDirty` flag is automatically set to `true` whenever context is added or removed from the context bag. The **Dynamic Help** window only calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate.UpdateUserContext%2A> on the context bag if the `SetDirty` flag is set to `true`. It is reset to `false` after the update.  
  
3. Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AddAttribute%2A> to add context to the active context collection or <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.RemoveAttribute%2A> to remove context.  
  
## Robust Programming  
 If you are writing your own editor, then you must complete all three of the procedures in this topic to provide context for the editor.  
  
> [!NOTE]
> To properly activate an editor or designer window and to ensure that command routing is updated properly, you must call <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.Show%2A> on the component to make it the focus window.  
  
 The SEID is a collection of properties that change based on the selection. SEID information is available through the global selection. The global selection is wired into events triggered by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx> interface, and has a list of everything that is selected (current editor, current tool window, current hierarchy, and so on).  
  
 For editors and designers, in which context can change whenever the cursor moves within a word, it is inefficient to constantly update the context bag. To make updating more efficient any time you detect the cursor moving within the editor or designer window, you can call <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.SetDirty%2A>. Doing this allows you to hold your context changes until there is idle time and the IDE's context service sends notification to the editor or designer that the **Dynamic Help** window is updating. This approach is used in the "To maintain the context bag" procedure in this topic.  
  
 After providing context for activities within your editor or designer, you should provide a specific F1 keyword to allow users to get help for the editor or designer itself.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx.OnElementValueChange%2A>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AddAttribute%2A>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AdviseUpdate%2A>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.RemoveAttribute%2A>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.SetDirty%2A>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate.UpdateUserContext%2A>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.Show%2A>   
 <xref:Microsoft.VisualStudio.Shell.Interop.SVsTrackSelectionEx>
