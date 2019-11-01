---
title: "IWebAppDiagnosticsSetup::DiagnosticsSupported | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IWebAppDiagnosticsSetup::DiagnosticsSupported"
ms.assetid: 5bbcd0d0-1460-4cf7-bbb1-f4f4a04f739a
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IWebAppDiagnosticsSetup::DiagnosticsSupported
Determines whether diagnostics are supported on this application. If [SetSite](/windows/win32/api/ocidl/nf-ocidl-iobjectwithsite-setsite) has been called on the object implementing this interface with a non-NULL value, [DiagnosticsSupported](../../winscript/reference/iwebappdiagnosticssetup-diagnosticssupported.md) returns `true`. If not, it returns `false` and calls to [IWebAppDiagnosticsSetup::CreateObjectWithSiteAtWebApp](../../winscript/reference/iwebappdiagnosticssetup-createobjectwithsiteatwebapp.md) fail.  
  
> [!IMPORTANT]
> [IWebAppDiagnosticsSetup Interface](../../winscript/reference/iwebappdiagnosticssetup-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.  
  
## Syntax  
  
```cpp  
HRESULT DiagnosticsSupported(        [out, retval] VARIANT_BOOL* pRetVal        );  
```  
  
#### Parameters  
 `pRetVal`  
 If [SetSite](/windows/win32/api/ocidl/nf-ocidl-iobjectwithsite-setsite) has been called on the object implementing this interface with a non-NULL value, [DiagnosticsSupported](../../winscript/reference/iwebappdiagnosticssetup-diagnosticssupported.md) returns `true`. If not, it returns `false`, and calls to [IWebAppDiagnosticsSetup::CreateObjectWithSiteAtWebApp](../../winscript/reference/iwebappdiagnosticssetup-createobjectwithsiteatwebapp.md) fail.