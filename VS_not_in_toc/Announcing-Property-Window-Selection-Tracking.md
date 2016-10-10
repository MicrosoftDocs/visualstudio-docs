---
title: "Announcing Property Window Selection Tracking"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a7536f82-afd7-4894-9a60-84307fb92b7e
caps.latest.revision: 13
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Announcing Property Window Selection Tracking
If you want to work with the **Properties** window or the **Property** pages, for example, a form, text, or a selection for which you want to see properties, then you must have complete knowledge of how you coordinate selection. For example, you must know whether you have single selection or multiple selections. You then need to announce your selection type (single or multiple) to the IDE using the <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection?qualifyHint=False> interface. This interface provides information required by the **Properties** window.  
  
### To announce selection to the environment  
  
1.  Call `QueryInterface` for <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider?qualifyHint=False>.  
  
    1.  To do this, use the site pointer passed to the view when it was created.  
  
    2.  Call `QueryService` from the view for the `SID_STrackSelection` service.  
  
         This returns a pointer to <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection?qualifyHint=False>.  
  
2.  Call the <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection.OnSelectChange?qualifyHint=False> method every time your selection changes, and pass a pointer to an object that implements <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer?qualifyHint=False>.  
  
     The selection container object can use either single or multiple selections and contains the selection information in an `IDispatch` object. Calling the <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection.OnSelectChange?qualifyHint=False> method notifies the **Properties** window that the selection has changed. The **Properties** window then uses the objects on <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer?qualifyHint=False> to determine whether single or multiple selections have occurred, and what the actual object selections are.  
  
     If you specify a multiple selection, then the **Properties** window finds the intersection between common properties for the objects. If you specify a single object selection, then the **Properties** window displays all of the properties for the one object.  
  
## See Also  
 [Extending Properties](../Topic/Extending%20Properties.md)   
 [Property Pages](../Topic/Property%20Pages.md)