---
title: "IWebAppDiagnosticsSetup Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-script-interfaces"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IWebAppDiagnosticsSetup Interface"
ms.assetid: ec7359f2-633e-4d59-b64b-9cab0134dfd0
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IWebAppDiagnosticsSetup Interface
This interface is implemented by a PDM debug application to create COM objects in the process that is being debugged and to enable web diagnostics. If the PDM debug application object implements [IObjectWithSite](http://go.microsoft.com/fwlink/?LinkId=232438), Internet Explorer calls [SetSite](http://go.microsoft.com/fwlink/?LinkId=232439) on it after it has been created and passes in a reference to [IWebBrowser2](http://go.microsoft.com/fwlink/?LinkId=232449). A WWA application calls [SetSite](http://go.microsoft.com/fwlink/?LinkId=232439) and passes in the WWA interface IWebApplicationHost instead. If [SetSite](http://go.microsoft.com/fwlink/?LinkId=232439) has been called with a non-NULL value, [IWebAppDiagnosticsSetup::DiagnosticsSupported](../../winscript/reference/iwebappdiagnosticssetup-diagnosticssupported.md) returns true. If not, it returns false and calls to [IWebAppDiagnosticsSetup::CreateObjectWithSiteAtWebApp](../../winscript/reference/iwebappdiagnosticssetup-createobjectwithsiteatwebapp.md) fail.  
  
> [!IMPORTANT]
>  `IWebAppDiagnosticsSetup` is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Methods  
 This interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IWebAppDiagnosticsSetup::CreateObjectWithSiteAtWebApp](../../winscript/reference/iwebappdiagnosticssetup-createobjectwithsiteatwebapp.md)|Gets the text documents that are hidden by the specified filter.|  
|[IWebAppDiagnosticsSetup::DiagnosticsSupported](../../winscript/reference/iwebappdiagnosticssetup-diagnosticssupported.md)|Determines whether the specified document belongs to one of the child nodes of this node.|