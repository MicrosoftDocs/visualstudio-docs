---
title: "SCRIPTLANGUAGEVERSION Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 58aa904a-e3ed-41c6-82d6-e91c8279a792
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SCRIPTLANGUAGEVERSION Enumeration
Specifies the possible scripting versions.  
  
## Syntax  
  
```cpp  
typedef enum tagSCRIPTLANGUAGEVERSION{    SCRIPTLANGUAGEVERSION_DEFAULT = 0,    SCRIPTLANGUAGEVERSION_5_7  = 1,    SCRIPTLANGUAGEVERSION_5_8  = 2,    SCRIPTLANGUAGEVERSION_MAX  = 255} SCRIPTLANGUAGEVERSION ;  
```  
  
## Enumeration Values  
  
|||  
|-|-|  
|SCRIPTLANGUAGEVERSION_DEFAULT|The default version. The integer value is 0.|  
|SCRIPTLANGUAGEVERSION_5_7|Windows Scripting version 5.7. The integer value is 1.|  
|SCRIPTLANGUAGEVERSION_5_8|Windows Scripting version 5.8. The integer value is 2.|  
|SCRIPTLANGUAGEVERSION_MAX|The maximum version. The integer value is 255.|  
  
## See also  
 [Active Script Constants, Enumerations, and Error Codes](../../winscript/reference/active-script-constants-enumerations-and-error-codes.md)