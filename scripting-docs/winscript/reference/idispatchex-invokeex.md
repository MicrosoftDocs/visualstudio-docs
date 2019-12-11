---
title: "IDispatchEx::InvokeEx | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispatchEx.InvokeEx"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "InvokeEx method"
ms.assetid: d90783e6-4b89-4423-8a56-a9c8b4b2c813
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispatchEx::InvokeEx
Provides access to properties and methods exposed by an `IDispatchEx` object.  
  
## Syntax  
  
```cpp
HRESULT InvokeEx(  
   DISPID id,  
   LCID lcid,  
   WORD wFlags,  
   DISPARAMS *pdp,  
   VARIANT *pVarRes,   
   EXCEPINFO *pei,   
   IServiceProvider *pspCaller   
);  
```  
  
#### Parameters  
 `id`  
 Identifies the member. Uses `GetDispID` or `GetNextDispID` to obtain the dispatch identifier.  
  
 `lcid`  
 The locale context in which to interpret arguments. The `lcid` is passed to `InvokeEx` to allow the object to interpret its arguments specific to a locale.  
  
 `wFlags`  
 The legal values for `wFlags` are:  
  
 DISPATCH_PROPERTYGET &#124; DISPATCH_METHOD &#124; DISPATCH_PROPERTYPUT &#124; DISPATCH_PROPERTYPUTREF &#124; DISPATCH_CONSTRUCT  
  
 Flags describing the context of the `InvokeEx` call:  
  
|Value|Meaning|  
|-----------|-------------|  
|DISPATCH_METHOD|The member is invoked as a method. If a property has the same name, both this and the DISPATCH_PROPERTYGET flag may be set (defined by `IDispatch`).|  
|DISPATCH_PROPERTYGET|The member is retrieved as a property or data member (defined by `IDispatch`).|  
|DISPATCH_PROPERTYPUT|The member is changed as a property or data member (defined by `IDispatch`).|  
|DISPATCH_PROPERTYPUTREF|The member is changed by a reference assignment rather than a value assignment. This flag is valid only when the property accepts a reference to an object (defined by `IDispatch`).|  
|DISPATCH_CONSTRUCT|The member is being used as a constructor. (This is a new value defined by `IDispatchEx`). The legal values for `wFlags` are:<br /><br /> DISPATCH_PROPERTYGET DISPATCH_METHOD DISPATCH_PROPERTYPUT DISPATCH_PROPERTYPUTREF DISPATCH_CONSTRUCT|  
  
 `pdp`  
 Pointer to a structure containing an array of arguments, an array of argument DISPIDs for named arguments, and counts for the number of elements in the arrays. See the `IDispatch` documentation for a full description of the DISPPARAMS structure.  
  
 `pVarRes`  
 Pointer to the location where the result is to be stored or Null if the caller expects no result. This argument is ignored if DISPATCH_PROPERTYPUT or DISPATCH_PROPERTYPUTREF is specified.  
  
 `pei`  
 Pointer to a structure that contains exception information. This structure should be filled in if `DISP_E_EXCEPTION` is returned. Can be Null. See the `IDispatch` documentation for a full description of the `EXCEPINFO` structure.  
  
 `pspCaller`  
 Pointer to a service provider object supplied by the caller, which allows the object to obtain services from the caller. Can be Null.  
  
 `IDispatchEx::InvokeEx` provides all of the same features as `IDispatch::Invoke` and adds a few extensions:  
  
|||  
|-|-|  
|DISPATCH_CONSTRUCT|Indicates that the item is being used as a constructor.|  
|`pspCaller`|The `pspCaller` allows the object access to services provided by the caller. Specific services may be handled by the caller itself or delegated to callers further up the call chain. For example, if a script engine inside a browser makes an `InvokeEx` call to an external object, the object can follow the `pspCaller` chain to obtain services from the script engine or browser. (Note that the call chain is not the same as the creation chain—also known as container chain or site chain. The creation chain may be available through some other mechanism such as `IObjectWithSite`.)|  
|`this` pointer|When DISPATCH_METHOD is set in `wFlags`, there may be a "named parameter" for the "this" value. The DISPID will be DISPID_THIS and it must be the first named parameter.|  
  
 The unused `riid` parameter in `IDispatch::Invoke` has been removed.  
  
 The `puArgArr` parameter in `IDispatch::Invoke` has been removed.  
  
 See the `IDispatch::Invoke` documentation for the following examples:  
  
 "Calling a method with no arguments"  
  
 "Getting and setting properties"  
  
 "Passing parameters"  
  
 "Indexed Properties"  
  
 "Raising exceptions during Invoke"  
  
 "Returning errors"  
  
## Return Value  
 Returns one of the following values:  
  
|||  
|-|-|  
|`S_OK`|Success.|  
|DISP_E_BADPARAMCOUNT|The number of elements provided to DISPPARAMS is different from the number of arguments accepted by the method or property.|  
|DISP_E_BADVARTYPE|One of the arguments in `rgvarg` is not a valid variant type.|  
|DISP_E_EXCEPTION|The application needs to raise an exception. In this case, the structure passed in `pei` should be filled in.|  
|DISP_E_MEMBERNOTFOUND|The requested member does not exist, or the call to `InvokeEx` tried to set the value of a read-only property.|  
|DISP_E_NONAMEDARGS|This implementation of `IDispatch` does not support named arguments.|  
|DISP_E_OVERFLOW|One of the arguments in `rgvarg` could not be coerced to the specified type.|  
|DISP_E_PARAMNOTFOUND|One of the parameter DISPIDs does not correspond to a parameter on the method.|  
|DISP_E_TYPEMISMATCH|One or more of the arguments could not be coerced.|  
|DISP_E_UNKNOWNLCID|The member being invoked interprets string arguments according to the LCID, and the LCID is not recognized. If the LCID is not needed to interpret arguments, this error should not be returned.|  
|DISP_E_PARAMNOTOPTIONAL|A required parameter was omitted.|  
  
## Example  
  
```cpp
VARIANT var;  
   BSTR bstrName;  
   DISPID dispid;  
   IDispatchEx *pdex;  
   DISPPARAMS dispparamsNoArgs = {NULL, NULL, 0, 0};  
  
   // Assign to pdex and bstrName  
   if (SUCCEEDED(pdex->GetDispID(bstrName, fdexNameCaseSensitive, &dispid)))  
   {  
      pdex->InvokeEx(dispid, LOCALE_USER_DEFAULT,  
         DISPATCH_PROPERTYGET, &dispparamsNoArgs,   
         &var, NULL, NULL);  
   }  
```  
  
## See also  
 [IDispatchEx Interface](../../winscript/reference/idispatchex-interface.md)   
 [IDispatchEx::GetDispID](../../winscript/reference/idispatchex-getdispid.md)   
 [IDispatchEx::GetNextDispID](../../winscript/reference/idispatchex-getnextdispid.md)