---
title: "IActiveScriptProperty::GetProperty | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProperty.GetProperty"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "GetProperty method, IActiveScriptProperty interface"
ms.assetid: a43383db-b148-4d76-83bd-4f0e899b7cb1
caps.latest.revision: 24
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProperty::GetProperty
Gets the property that is specified by the parameter.  
  
## Syntax  
  
```cpp
HRESULT GetProperty(  
// The property value:  
    uint dwProperty,    
// Not used:  
    IntPtr pvarIndex,    
// The value of the property:   
    out object pvarValue,    
);  
```  
  
#### Parameters  
 `dwProperty`  
 The property value to get.  
  
 `pvarIndex`  
 Not used.  
  
 `pvarValue`  
 The value of the property.  
  
 The values allowed for `dwProperty` are described in the following table.  
  
|Constant|Value|Meaning|  
|--------------|-----------|-------------|  
|SCRIPTPROP_INTEGERMODE|0x00003000|Forces the scripting engine to divide in integer mode instead of floating point mode.|  
|SCRIPTPROP_STRINGCOMPAREINSTANCE|0x00003001|Allows the string compare function of the scripting engine to be replaced.|  
|SCRIPTPROP_ABBREVIATE_GLOBALNAME_RESOLUTION|0x70000002|Informs the scripting engine that no other scripting engines exist to contribute to the global object.|  
|SCRIPTPROP_INVOKEVERSIONING|0x00004000|Forces the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine to select a set of language features to be supported. The default set of language features supported by the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine is equivalent to the language feature set that appeared in version 5.7 of the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine.|  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_INVALIDARG`|An argument is not valid.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized).|  
  
## Remarks  
 The host can use the SCRIPTPROP_ABBREVIATE_GLOBALNAME_RESOLUTION property to inform a scripting engine that no other scripting engines exist to contribute to the global object. For example, Internet Explorer can inform the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] engine that the page being rendered contains only [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripts. Thus, only the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] engine can add new properties to the global object window, and there is no Visual Basic Scripting Edition (VBScript) engine to do the same. The engine can ignore this flag or can use it to optimize the management of new members that are added to the global object.  
  
 The host can use the SCRIPTPROP_INVOKEVERSIONING property to select the set of language features to be supported when the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine is started. If this property is set to 1 (SCRIPTLANGUAGEVERSION_5_7), the available language features are the same as those that appeared in version 5.7 of the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine. If it is set to 2 (SCRIPTLANGUAGEVERSION_5_8), the available language features are those that appeared in version 5.7 in addition to features that were added in version 5.8. By default, this property is set to 0 (SCRIPTLANGUAGEVERSION_DEFAULT), which is equivalent to the language feature set that appeared in version 5.7, unless the host supports a different default behavior. For instance, Internet Explorer 8 opts into the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] language features supported by the version 5.8 [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine by default when the document mode for Internet Explorer 8 is "Internet Explorer 8 Standards" mode.  
  
## See also  
 [Defining Document Compatibility](https://docs.microsoft.com/previous-versions/windows/internet-explorer/ie-developer/compatibility/cc288325(v=vs.85))   
 [IActiveScriptProperty](../../winscript/reference/iactivescriptproperty.md)   
 [Version Information](../../javascript/reference/javascript-version-information.md)