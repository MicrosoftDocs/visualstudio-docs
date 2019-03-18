---
title: "SCRIPTPROP_HOSTKEEPALIVE Property | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: bfa199f2-28ba-4320-bc0f-2320fad018bd
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SCRIPTPROP_HOSTKEEPALIVE Property
Used to specify whether or not the scripting engine should be kept fully functional if there are outstanding references.  
  
 Use [IActiveScriptProperty::SetProperty](../../winscript/reference/iactivescriptproperty-setproperty.md) to set this property to `true`. If this property is set to `true`, the scripting engine is kept fully functional as long as there is at least one outstanding reference either to the scripting engine itself or to an `IDispatch` pointer to a JavaScript object created by using the scripting engine. When this property is set to `true`, you should not explicitly close or reset the script engine by using the [IActiveScript::Close](../../winscript/reference/iactivescript-close.md) or [IActiveScript::SetScriptState](../../winscript/reference/iactivescript-setscriptstate.md) methods. The release of the last reference to a script object shuts the script engine down.  
  
## Syntax  
  
```cpp
#define SCRIPTPROP_HOSTKEEPALIVE 0x70000004  
```  
  
## Requirements  
 This property appears only in the version of activscp.idl that is installed with [!INCLUDE[win8](../../javascript/includes/win8-md.md)], with KB 2707082 for Internet Explorer 8 on [!INCLUDE[win7](../../winscript/reference/includes/win7-md.md)], or with KB 2722913 for Internet Explorer 9 on [!INCLUDE[win7](../../winscript/reference/includes/win7-md.md)] or [!INCLUDE[vista_first](../../winscript/reference/includes/vista-first-md.md)].