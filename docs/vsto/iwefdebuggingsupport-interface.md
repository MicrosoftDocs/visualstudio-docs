---
title: "IWefDebuggingSupport Interface | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# IWefDebuggingSupport Interface
  Implemented by a debugging environment, such as Visual Studio, to facilitate debugging of apps for Office. The Office application, such as Word or Excel, obtains this interface from Visual Studio and then calls methods on the interface at certain points during the debugging session.  
  
## Syntax  
  
```  
[  
    uuid(ccaf1a90-ce1c-4199-9cd6-b40c5c57a671),  
    oleautomation  
]  
interface IWefDebuggingSupport : IUnknown  
{  
    HRESULT SetWefProcessId(  
        [in] DWORD dwProcessId);  
    HRESULT GetAutoInsertExtensions(  
        [out, retval] SAFEARRAY(BSTR)* psaExtensionNames);  
}  
```  
  
## Methods  
 The following table lists the methods that the IWefDebuggingSupport interface defines.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAutoInsertExtensions Method](../vsto/getautoinsertextensions-method.md)|Gets information about the apps for Office that are to be automatically inserted during debugging.|  
|[SetWefProcessId Method](../vsto/setwefprocessid-method.md)|Provides the process identifier that will run Web Extensions Framework (WEF) content.|  
  
  