---
title: "IWebAppDiagnosticsSetup::CreateObjectWithSiteAtWebApp | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IWebAppDiagnosticsSetup::CreateObjectWithSiteAtWebApp"
ms.assetid: 30975973-acb1-48f4-8266-5e097a57db22
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IWebAppDiagnosticsSetup::CreateObjectWithSiteAtWebApp
This method co-creates the class whose ID you pass in with `rclsid` using the `dwClsContext`. This is similar to the way [IRemoteDebugApplication::CreateInstanceAtApplication](../../winscript/reference/iremotedebugapplication-createinstanceatapplication.md) works, except that in the case of `CreateObjectWithSiteAtWebApp` the object is created asynchronously on the web application's UI thread. The object specified by the class ID should implement [IWebAppDiagnosticsObjectInitialization Interface](../../winscript/reference/iwebappdiagnosticsobjectinitialization-interface.md). After the object has been created, [IWebAppDiagnosticsObjectInitialization::Initialize](../../winscript/reference/iwebappdiagnosticsobjectinitialization-initialize.md) is called with a reference to the PDM debug application and the `hPassToObject` parameter of `CreateObjectWithSiteAtWebApp`. You can use this method to pass into the app a handle to an anonymous pipe that you have copied using [DuplicateHandle](/windows/win32/api/handleapi/nf-handleapi-duplicatehandle).  
  
> [!IMPORTANT]
> [IWebAppDiagnosticsSetup Interface](../../winscript/reference/iwebappdiagnosticssetup-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT CreateObjectWithSiteAtWebApp(        [in] REFCLSID rclsid,         [in] DWORD dwClsContext,         [in] REFIID riid,         [in] DWORD_PTR hPassToObject        );  
```  
  
#### Parameters  
 `rclsid`  
 The class ID of the class to create.  
  
 `dwClsContext`  
 The context in which the code will run. In most cases it is CLSCTX_INPROC_SERVER.  
  
 `riid`  
 Not used.  
  
 `hPassToObject`  
 A value that will be passed to the object once it is created on the UI thread, if the object implements [IWebAppDiagnosticsObjectInitialization Interface](../../winscript/reference/iwebappdiagnosticsobjectinitialization-interface.md).