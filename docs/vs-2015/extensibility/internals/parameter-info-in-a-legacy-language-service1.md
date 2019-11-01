---
title: "Parameter Info in a Legacy Language Service1 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "language services, method tips"
  - "method tips"
  - "language services, parameter info tooltip"
  - "IVsMethodData interface"
  - "Parameter Info (IntelliSense)"
ms.assetid: f367295e-45b6-45d2-9ec8-77481743beef
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# Parameter Info in a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The IntelliSense Parameter Info tooltip provides users with hints about where they are in a language construct.  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Extending the Editor and Language Services](../../extensibility/extending-the-editor-and-language-services.md).  
  
> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
## How Parameter Info Tooltips Work  
 When you type a statement in the editor, the VSPackage displays a small tooltip window containing the definition of the statement being typed. For example, if you type a Microsoft Foundation Classes (MFC) statement (such as `pMainFrame ->UpdateWindow`) and press the opening parenthesis key to begin listing parameters, a method tip appears displaying the definition of the `UpdateWindow` method.  
  
 Parameter Info tooltips are usually used in conjunction with statement completion. They are most useful for languages that have parameters or other formatted information after the method name or keyword.  
  
 The Parameter Info tooltips are initiated by the language service through command interception. To intercept user characters, your language service object must implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface and pass the text view a pointer to your <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> implementation, by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.AddCommandFilter%2A> method in the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> interface. The command filter intercepts commands that you type into the code window. Monitor the command information to know when to display parameter information to the user. You can use the same command filter for statement completion, error markers, and so forth.  
  
 When you type a keyword for which the language service can provide hints, then the language service creates an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodTipWindow> object and calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateTipWindow%2A> method in the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> interface to notify the IDE to display a hint. Create the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodTipWindow> object using `VSLocalCreateInstance` and specifying the coclass `CLSID_VsMethodTipWindow`. `VsLocalCreateInstance` is a function defined in the header file vsdoc.h that calls `QueryService` for the local registry and calls `CreateInstance` on this object for the `CLSID_VsMethodTipWindow`.  
  
## Providing a Method Tip  
 To provide a method tip, call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodTipWindow.SetMethodData%2A> method in the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodTipWindow> interface, passing it your implementation of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData> interface.  
  
 When your <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData> class is invoked, its methods are called in the following order:  
  
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.GetContextStream%2A>  
  
     Returns the position and length of the relevant data in the current text buffer. This instructs the IDE to not obscure that data with the tooltip window.  
  
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.GetCurMethod%2A>  
  
     Returns the method number (zero-based index) you want to be displayed initially. For example, if you return zero, then the first overloaded method is initially presented.  
  
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.GetOverloadCount%2A>  
  
     Returns the number of overloaded methods that are applicable in the current context. If you return a value greater than 1 for this method, then the text view displays up and down arrows for you. If you click the down arrow, the IDE calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.NextMethod%2A> method. If you click the up arrow, the IDE calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.PrevMethod%2A> method.  
  
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.GetMethodText%2A>  
  
     The text of the Parameter Info tooltip is constructed during several calls to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.GetMethodText%2A> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.GetParameterText%2A> methods.  
  
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.GetParameterCount%2A>  
  
     Returns the number of parameters to display in the method.  
  
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.GetParameterText%2A>  
  
     If you return a method number corresponding with the overload you want displayed, this method is called, followed by a call to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.UpdateView%2A> method.  
  
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.UpdateView%2A>  
  
     Informs your language service to update the editor when a method tip is displayed. In the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.UpdateView%2A> method, call the following:  
  
    ```  
    <pTxWin> ->UpdateTipWindow(<pTip>, UTW_CONTENTCHANGED | UTW_CONTEXTCHANGED).  
    ```  
  
- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.OnDismiss%2A>  
  
     You receive a call to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.OnDismiss%2A> method when you close the method tip window.
