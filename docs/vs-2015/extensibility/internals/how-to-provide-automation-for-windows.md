---
title: "How to: Provide Automation for Windows | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "automation [Visual Studio SDK], tool windows"
  - "tool windows, automation"
ms.assetid: 512ab2a4-7987-4912-8f40-8804bf66f829
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# How to: Provide Automation for Windows
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

You can provide automation for document and tool windows. Providing automation is advisable whenever you want to make automation objects available on a window, and the environment does not already provide a ready-made automation object, as it does with a task list.  
  
## Automation for Tool Windows  
 The environment provides automation on a tool window by returning a standard <xref:EnvDTE.Window> object as explained in the following procedure:  
  
#### To provide automation for tool windows  
  
1. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.GetProperty%2A> method via the environment with <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID> as `VSFPROPID` parameter to get the `Window` object.  
  
2. When a caller requests a VSPackage-specific automation object for your tool window through <xref:EnvDTE.Window.Object%2A>, the environment calls `QueryInterface` for `IExtensibleObject`, <xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibleObject>, or the `IDispatch` interfaces. Both `IExtensibleObject` and `IVsExtensibleObject` provide a <xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibleObject.GetAutomationObject%2A> method.  
  
3. When the environment then calls the `GetAutomationObject` method passing `NULL`, respond by passing back your VSPackage-specific object.  
  
4. If calling `QueryInterface` for `IExtensibleObject` and `IVsExtensibleObject` fails, then the environment calls `QueryInterface` for `IDispatch`.  
  
## Automation for Document Windows  
 A standard <xref:EnvDTE.Document> object is also available from the environment, although an editor can have its own implementation of the `T:EnvDTE.Document` object by implementing `IExtensibleObject` interface and responding to `GetAutomationObject`.  
  
 In addition, an editor can provide a VSPackage-specific automation object, retrieved through the <xref:EnvDTE.Document.Object%2A> method, by implementing the `IVsExtensibleObject` or `IExtensibleObject` interfaces. The [VSSDK Samples](../../misc/vssdk-samples.md) contributes an RTF document-specific automation object.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibleObject>
