---
title: "How to: Host An Editor in Another Editor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - host a nested editor"
ms.assetid: 2b0eb705-fe94-4ca8-93e0-9dbd8ce61a44
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# How to: Host An Editor in Another Editor
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio you can host one editor inside another by specifying the hosting window as a parent window. To do so, set the parameters <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID2> and <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID2> on the child window frame.  
  
### To set up the window frame to host an editor  
  
1. Designate an editor as a hosted editor by creating a child window pane.  
  
     This pane is where the editor's text will go.  
  
2. Create the hosting editor using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> or <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenSpecificEditor%2A> method.  
  
3. Set the <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID2> and <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID2> properties in the window frame implementation of the hosted editor by passing these properties as the parameters to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.SetProperty%2A> method, respectively.  
  
     If you need to retrieve these parameters, pass these properties to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.GetProperty%2A> method.  
  
4. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.Show%2A> method for the contained editor.  
  
     The editor appears in the hosted pane of the containing editor.  
  
## Robust Programming  
 The **Application Designer** in the Visual Studio Team Edition for Architects is an example of an editor window frame hosting another editor. The **Application Designer** hosts other designers in its right-hand pane. A designer panel (or **Properties** page) for each of the contained designers is added to the containing window frame.
