---
title: "Legacy Language Service Interfaces | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "IVsLanguageInfo interface"
  - "language services, objects"
ms.assetid: 03b2d507-f463-417e-bc22-bdac68eeda52
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Legacy Language Service Interfaces
For any particular programming language, there can be only one instance of a language service at a time. However, a single language service can serve more than one editor.

 [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] does not associate a language service with any particular editor. Therefore, when you request a language service operation, you must identify the appropriate editor as a parameter.

## Common Interfaces Associated with Language Services
 The editor gets your language service by calling <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider.QueryService%2A> on the appropriate VSPackage. The service ID (SID) passed in this call identifies the language service being requested.

 You can implement the core language service interfaces on any number of separate classes. However, a common approach is to implement the following interfaces in a single class:

- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo>

- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsProvideColorableItems>

- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageDebugInfo>

- <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageBlock> (optional)

  The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo> interface must be implemented on all language services. It provides information about your language service, such as the localized name of the language, the file name extensions associated with the language service, and how to retrieve a colorizer.

## Additional Language Service Interfaces
 Other interfaces can be provided with your language service. [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] requests a separate instance of these interfaces for each instance of the text buffer. Therefore, you should implement each of these interfaces on its own object. The following table shows interfaces that require one instance per text buffer instance.

|Interface|Description|
|---------------|-----------------|
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindowManager>|Manages code window adornments, such as the drop-down bar. You can get this interface by using the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo.GetCodeWindowManager%2A> method. There is one <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindowManager> per code window.|
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer>|Colorizes language keywords and delimiters. You can get this interface by using the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo.GetColorizer%2A> method. <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer> is called at paint time. Avoid computation-intensive work inside <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer> or performance could suffer.|
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData>|Provides IntelliSense parameter tooltips. When the language service recognizes a character that indicates that method data should be displayed, such as an open parenthesis, it calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodTipWindow.SetMethodData%2A> method to notify the text view that the language service is ready to display a Parameter Info ToolTip. The text view then calls back into the language service by using the methods of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData> interface to get the required information to display the tooltip.|
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompletionSet>|Provides IntelliSense statement completion. When the language service is ready to display a completion list, it calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateCompletionStatus%2A> method on the text view. The text view then calls back into the language service by using methods on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompletionSet> object.|
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewFilter>|Allows for modification of the text view using the command handler. The class in which you implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewFilter> interface must also implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface. The text view retrieves the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewFilter> object by querying the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> object that is passed into the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.AddCommandFilter%2A> method. There should be one <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewFilter> object for each view.|
|<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>|Intercepts commands that the user types into the code window. Monitor output from your <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> implementation to provide custom completion information and view modification<br /><br /> To pass your <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> object to the text view, call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.AddCommandFilter%2A>.|

## See also
- [Developing a Legacy Language Service](../../extensibility/internals/developing-a-legacy-language-service.md)
- [Checklist: Creating a Legacy Language Service](../../extensibility/internals/checklist-creating-a-legacy-language-service.md)