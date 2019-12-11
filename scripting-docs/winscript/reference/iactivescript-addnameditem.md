---
title: "IActiveScript::AddNamedItem | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScript.AddNamedItem"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "AddNamedItem method, IActiveScript interface"
ms.assetid: a7c6317d-948f-4bb3-b169-1bbe5b7c7cc5
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript::AddNamedItem
Adds the name of a root-level item to the scripting engine's name space. A root-level item is an object with properties and methods, an event source, or all three.  
  
## Syntax  
  
```cpp
HRESULT AddNamedItem(  
    LPCOLESTR pstrName,  // address of item name  
    DWORD dwFlags          // item flags  
);  
```  
  
#### Parameters  
 `pstrName`  
 [in] Address of a buffer that contains the name of the item as viewed from the script. The name must be unique and persistable.  
  
 `dwFlags`  
 [in] Flags associated with an item. Can be a combination of these values:  
  
|Value|Meaning|  
|-----------|-------------|  
|SCRIPTITEM_CODEONLY|Indicates that the named item represents a code-only object, and that the host has no `IUnknown` to be associated with this code-only object. The host only has a name for this object. In object-oriented languages such as C++, this flag would create a class. Not all languages support this flag.|  
|SCRIPTITEM_GLOBALMEMBERS|Indicates that the item is a collection of global properties and methods associated with the script. Normally, a scripting engine would ignore the object name (other than for the purpose of using it as a cookie for the [IActiveScriptSite::GetItemInfo](../../winscript/reference/iactivescriptsite-getiteminfo.md) method, or for resolving explicit scoping) and expose its members as global variables and methods. This allows the host to extend the library (run-time functions and so on) available to the script. It is left to the scripting engine to deal with name conflicts (for example, when two SCRIPTITEM_GLOBALMEMBERS items have methods of the same name), although an error should not be returned because of this situation.|  
|SCRIPTITEM_ISPERSISTENT|Indicates that the item should be saved if the scripting engine is saved. Similarly, setting this flag indicates that a transition back to the initialized state should retain the item's name and type information (the scripting engine must, however, release all pointers to interfaces on the actual object).|  
|SCRIPTITEM_ISSOURCE|Indicates that the item sources events that the script can sink. Child objects (properties of the object that are in themselves objects) can also source events to the script. This is not recursive, but it provides a convenient mechanism for the common case, for example, of creating a container and all of its member controls.|  
|SCRIPTITEM_ISVISIBLE|Indicates that the item's name is available in the name space of the script, allowing access to the properties, methods, and events of the item. By convention the properties of the item include the item's children; therefore, all child object properties and methods (and their children, recursively) will be accessible.|  
|SCRIPTITEM_NOCODE|Indicates that the item is simply a name being added to the script's name space, and should not be treated as an item for which code should be associated. For example, without this flag being set, VBScript will create a separate module for the named item, and C++ might create a separate wrapper class for the named item.|  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized).|  
  
## See also  
 [IActiveScript](../../winscript/reference/iactivescript.md)