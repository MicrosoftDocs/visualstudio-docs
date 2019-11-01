---
title: "IActiveScriptProperty::SetProperty | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptProperty.SetProperty"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "SetProperty method, IActiveScriptProperty interface"
ms.assetid: 0ba429c5-04a3-4505-bc5f-69c505dfca91
caps.latest.revision: 21
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProperty::SetProperty
Sets the property that is specified by the parameter.  
  
## Syntax  
  
```cpp
HRESULT SetProperty(  
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
 The property value to set.  
  
 `pvarIndex`  
 Not used.  
  
 `pvarValue`  
 The value of the property.  
  
 The values allowed for `dwProperty` are described in the following table.  
  
|Constant|Value|Meaning|  
|--------------|-----------|-------------|  
|SCRIPTPROP_INTEGERMODE|0x00003000|Forces the scripting engine to divide in integer mode instead of floating point mode. The default value is `False`.|  
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
 To enable or disable integer division, invoke `SetProperty` and convert a `Boolean` to an `Object`. By default, the property value is `False`. If you set it to `True`, division operations will return only integers.  
  
 To enable or disable custom string comparison, invoke `SetProperty` and pass in an `Object` value. The object that you pass in must implement the interface [IActiveScriptStringCompare Interface](../../winscript/reference/iactivescriptstringcompare-interface.md). The [StrComp](../../winscript/reference/iactivescriptstringcompare-strcomp.md) method of the [IActiveScriptStringCompare Interface](../../winscript/reference/iactivescriptstringcompare-interface.md) interface is called every time that a string compare function is executed.  
  
 To select the set of language features to be supported when the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine is initialized, invoke `SetProperty` and pass a value that corresponds to the language feature set to be enabled for SCRIPTPROP_INVOKEVERSIONING. If this property is set to 1 (SCRIPTLANGUAGEVERSION_5_7), the available language features are the same as those that appeared in version 5.7 of the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine. If it is set to 2 (SCRIPTLANGUAGEVERSION_5_8), the available language features are those that appeared in version 5.7 in addition to new features that were added in version 5.8. By default, this property is set to 0 (SCRIPTLANGUAGEVERSION_DEFAULT), which is equivalent to the language feature set that appeared in version 5.7, unless the host supports a different default behavior. For example, Internet Explorer 8 opts into the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] language features that are supported by the version 5.8 [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine by default when the default document mode for Internet Explorer 8 is "Internet Explorer 8 Standards" mode. Switching the Internet Explorer 8 document mode to Internet Explorer 7 Standards or Quirks mode resets the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine to support only the language feature set that existed in the version 5.7 [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine.  
  
> [!NOTE]
> SCRIPTPROP_INVOKEVERSIONING should be set only when the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine is being initialized.  
  
## Example  
 The following example shows how to force the scripting engine to use integer division and how to allow overloading of the compare function.  
  
```c#  
BMLScriptEngine bmlScriptEngine = new BMLScriptEngine();  
IActiveScriptProperty scriptProperties = bmlScriptEngine as   
    IActiveScriptProperty;  
  
// Force the scripting engine to use integer division.  
Boolean enableIntegerDivision = true;  
Object vtIntegerDivInstance = (Object)enableIntegerDivision;  
                scriptProperties.SetProperty(SCRIPTPROP_INTEGERDIVISION,   
    System.IntPtr.Zero, ref vtIntegerDivInstance);  
  
// Allow overloading of the compare function.  
BMLScriptStringCompare bmlScriptStringCompareInstance = new   
    BMLScriptStringCompare();  
Object vtStrCmpInstance = (Object)bmlScriptStringCompareInstance;  
scriptProperties.SetProperty(SCRIPTPROP_STRCOMPINST,   
    System.IntPtr.Zero, ref vtStrCmpInstance);  
```  
  
## See also  
 [Defining Document Compatibility](https://docs.microsoft.com/previous-versions/windows/internet-explorer/ie-developer/compatibility/cc288325(v=vs.85))   
 [IActiveScriptProperty](../../winscript/reference/iactivescriptproperty.md)   
 [Version Information](../../javascript/reference/javascript-version-information.md)