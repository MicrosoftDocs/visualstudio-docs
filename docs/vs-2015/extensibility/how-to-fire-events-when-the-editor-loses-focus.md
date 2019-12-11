---
title: "How to: Fire Events When the Editor Loses Focus | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - fire events on losing focus"
ms.assetid: 64d40695-6917-468a-8037-a253453ac159
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# How to: Fire Events When the Editor Loses Focus
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Sometimes it is necessary to know when an editor loses focus on the window frame. For example, you might need to extract code from a code window after the editor is no longer focused on it. The following procedure provides the steps to follow to receive notification of the editor losing focus.  
  
### To fire an event in response to an editor losing focus  
  
1. Monitor selection events by obtaining an <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection> object from <xref:Microsoft.VisualStudio.Shell.Interop.SVsShellMonitorSelection>.  
  
2. Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection.AdviseSelectionEvents%2A> and provide it your <xref:Microsoft.VisualStudio.Shell.Interop.IVsSelectionEvents> object.  
  
3. In your call to <xref:Microsoft.VisualStudio.Shell.Interop.IVsSelectionEvents.OnElementValueChanged%2A>, look for `elementid==SEID_WindowFrame`.  
  
4. Test the `varValueNew` parameter for two things:  
  
    1. The window frame you are looking for.  
  
    2. The point at which your program loses the selection to that window frame.
