---
title: "IWebAppDiagnosticsObjectInitialization::Initialize | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IWebAppDiagnosticsObjectInitialization::Initialize"
ms.assetid: 7ccfac28-9f65-4e1c-a0fb-a8a6c7f75b63
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IWebAppDiagnosticsObjectInitialization::Initialize
Initializes objects created with [IWebAppDiagnosticsSetup::CreateObjectWithSiteAtWebApp](../../winscript/reference/iwebappdiagnosticssetup-createobjectwithsiteatwebapp.md).  
  
> [!IMPORTANT]
> [IWebAppDiagnosticsObjectInitialization Interface](../../winscript/reference/iwebappdiagnosticsobjectinitialization-interface.md) is found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT Initialize(        [in, annotation("__in")] HANDLE_PTR hPassedHandle,        [in, annotation("__in")] IUnknown* pDebugApplication        );  
```  
  
#### Parameters  
 `hPassedHandle`  
 The handle that was passed to the [IWebAppDiagnosticsSetup::CreateObjectWithSiteAtWebApp](../../winscript/reference/iwebappdiagnosticssetup-createobjectwithsiteatwebapp.md) method in the `hPassToObject` parameter.  
  
 `pDebugApplication`  
 The PDM application with which the object was created.