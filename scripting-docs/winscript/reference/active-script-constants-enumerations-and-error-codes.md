---
title: "Active Script Constants, Enumerations, and Error Codes | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: aab24471-5817-45c0-be07-ffe4648923ed
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Active Script Constants, Enumerations, and Error Codes
This section describes the enumerations and error codes used in Windows Scripting engines.  
  
## Constants  
  
|Constant|Description|  
|--------------|-----------------|  
|[SCRIPTTHREADID Constants](../../winscript/reference/scriptthreadid-constants.md)|Specifies the type of thread.|  
  
## Properties  
  
|Property|Description|  
|--------------|-----------------|  
|[SCRIPTPROP_HOSTKEEPALIVE Property](../../winscript/reference/scriptprop-hostkeepalive-property.md)|Used to specify whether or not the scripting engine should be kept fully functional if there are outstanding references.|  
  
## Enumerations  
  
|Enumeration|Description|  
|-----------------|-----------------|  
|[SCRIPTGCTYPE Enumeration](../../winscript/reference/scriptgctype-enumeration.md)|The type of garbage collection to perform.|  
|[SCRIPTLANGUAGEVERSION Enumeration](../../winscript/reference/scriptlanguageversion-enumeration.md)|Specifies the possible scripting versions.|  
|[SCRIPTSTATE Enumeration](../../winscript/reference/scriptstate-enumeration.md)|Specifies the state of a scripting engine.|  
|||  
|[SCRIPTTHREADSTATE Enumeration](../../winscript/reference/scriptthreadstate-enumeration.md)|Specifies the state of a thread in a scripting engine.|  
|[SCRIPTTRACEINFO Enumeration](../../winscript/reference/scripttraceinfo-enumeration.md)|Represents the script event that is being traced. Used in the [IActiveScriptSiteTraceInfo::SendScriptTraceInfo Method](../../winscript/reference/iactivescriptsitetraceinfo-sendscripttraceinfo-method.md).|  
|[SCRIPTUICHANDLING Enumeration](../../winscript/reference/scriptuichandling-enumeration.md)|Represents the way that the UI control should be handled.|  
|[SCRIPTUICITEM Enumeration](../../winscript/reference/scriptuicitem-enumeration.md)|Represents the type of UI item. Used in the [IActiveScriptSiteUIControl::GetUIBehavior Method](../../winscript/reference/iactivescriptsiteuicontrol-getuibehavior-method.md).|  
  
## Error Codes  
  
|Error Code|Description|  
|----------------|-----------------|  
|[SCRIPT_E_PROPAGATE Error Code](../../winscript/reference/script-e-propagate-error-code.md)|A script error is being propagated to the caller, which might be in a different thread.|  
|[SCRIPT_E_RECORDED Error Code](../../winscript/reference/script-e-recorded-error-code.md)|An error has been passed between the script engine and the host.|  
|[SCRIPT_E_REPORTED Error Code](../../winscript/reference/script-e-reported-error-code.md)|The scripting engine has reported an unhandled exception to the host.|  
  
## See also  
 [Active Script Interfaces](../../winscript/reference/active-script-interfaces.md)