---
title: "SCRIPTTRACEINFO Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: cb8a4767-8c8e-4fa0-a735-038767a8c500
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SCRIPTTRACEINFO Enumeration
Represents the script event that is being traced. Used in the [IActiveScriptSiteTraceInfo::SendScriptTraceInfo Method](../../winscript/reference/iactivescriptsitetraceinfo-sendscripttraceinfo-method.md).  
  
## Syntax  
  
```cpp
typedef enum tagSCRIPTTRACEINFO {      SCRIPTTRACEINFO_SCRIPTSTART = 0,      SCRIPTTRACEINFO_SCRIPTEND   = 1,      SCRIPTTRACEINFO_COMCALLSTART    = 2,      SCRIPTTRACEINFO_COMCALLEND  = 3,      SCRIPTTRACEINFO_CREATEOBJSTART  = 4,      SCRIPTTRACEINFO_CREATEOBJEND    = 5,      SCRIPTTRACEINFO_GETOBJSTART = 6,      SCRIPTTRACEINFO_GETOBJEND   = 7,  } SCRIPTTRACEINFO ;  
```  
  
## Enumeration Values  
  
|||  
|-|-|  
|SCRIPTTRACEINFO_SCRIPTSTART|The start of a script.|  
|SCRIPTTRACEINFO_SCRIPTEND|The end of the script.|  
|SCRIPTTRACEINFO_COMCALLSTART|The start of a COM call.|  
|SCRIPTTRACEINFO_COMCALLEND|The end of a COM call.|  
|SCRIPTTRACEINFO_CREATEOBJSTART|The start of object creation.|  
|SCRIPTTRACEINFO_CREATEOBJEND|The end of object creation.|  
|SCRIPTTRACEINFO_GETOBJSTART|The start of a GetObject call.|  
|SCRIPTTRACEINFO_GETOBJEND|The end of a GetObject call.|