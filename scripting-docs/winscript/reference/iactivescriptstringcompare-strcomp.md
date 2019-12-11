---
title: "IActiveScriptStringCompare::StrComp | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptStringCompare.StrComp"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "StrComp method, IActiveScriptStringCompare interface"
ms.assetid: 124d1281-8037-4766-a2a1-61244ac1f114
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptStringCompare::StrComp
Defines the string comparison method for the scripting engine.  
  
## Syntax  
  
```cpp
HRESULT StrComp(  
// The first string:  
    [in] BSTR bszStr1,    
// The second string:   
    [in] BSTR bszStr2,    
// The result of the comparison:  
    [out, retval] LONG* iRet   
);  
```  
  
#### Parameters  
 `bszStr1`  
 The first string.  
  
 `bszStr2`  
 The second string.  
  
 `iRet`  
 The result of the comparison. 0 if `bszStr1` and `bszStr2`are identical; -1 if `bszStr1` < `bszStr2`; 1 if `bszStr1` > `bszStr2`.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`E_INVALIDARG`|An argument is not valid.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized).|  
  
## Remarks  
 This method is called every time that a string comparison is executed.  
  
## Example  
 The following example shows how to overload the string comparison function. Overloading is allowed when you use [IActiveScriptProperty::SetProperty](../../winscript/reference/iactivescriptproperty-setproperty.md) to set SCRIPTPROP_STRINGCOMPAREINSTANCE.  
  
```cpp#  
cpp_quote("// {58562769-ED52-42f7-8403-4963514E1F11}")  
cpp_quote("DEFINE_GUID(IID_IActiveScriptStringCompare, 0x58562769,   
    0xED52, 0x42f7, 0x84, 0x03, 0x49, 0x63, 0x51, 0x4E, 0x1F, 0x11);")  
cpp_quote("")  
  
cpp_quote("#define SCRIPTPROP_INTEGERMODE              0x00003000")  
cpp_quote("#define SCRIPTPROP_STRINGCOMPAREINSTANCE    0x00003001")  
cpp_quote("")  
interface IActiveScriptStringCompare;  
[  
         object,  
         uuid(58562769-ED52-42f7-8403-4963514E1F11),  
         pointer_default(unique)  
]  
interface IActiveScriptStringCompare : IUnknown  
{  
        // StrComp  
        //     bszStr1: first string  
        //     bszStr2: second string  
        //     iRet: 0 if identical, -1 if bszStr1 < bszStr2, 1 if   
        //         bszStr1 > bszStr2  
        //            
        //     Return values:  
        //         S_OK: Success  
        //         E_NOTIMPL: Not implemented  
        //  
        HRESULT StrComp(  
                [in] BSTR bszStr1,  
                [in] BSTR bszStr2,  
                [out, retval] LONG* iRet  
        );  
}  
```  
  
## See also  
 [IActiveScriptStringCompare Interface](../../winscript/reference/iactivescriptstringcompare-interface.md)