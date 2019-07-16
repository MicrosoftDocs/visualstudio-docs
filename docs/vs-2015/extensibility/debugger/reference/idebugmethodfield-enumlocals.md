---
title: "IDebugMethodField::EnumLocals | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugMethodField::EnumLocals"
helpviewer_keywords: 
  - "IDebugMethodField::EnumLocals method"
ms.assetid: b0456a6d-2b96-49e2-a871-516571b4f6a5
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugMethodField::EnumLocals
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Creates an enumerator for selected local variables of the method.  
  
## Syntax  
  
```cpp#  
HRESULT EnumLocals(   
   IDebugAddress*     pAddress,  
   IEnumDebugFields** ppLocals  
);  
```  
  
```csharp  
int EnumLocals(  
   IDebugAddress        pAddress,   
   out IEnumDebugFields ppLocals  
);  
```  
  
#### Parameters  
 `pAddress`  
 [in] An [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object representing the debug address that selects the context or scope from which to get the locals.  
  
 `ppLocals`  
 [out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing a list of the locals; otherwise, returns a null value if there are no locals.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no locals. Otherwise, returns an error code.  
  
## Remarks  
 Only the variables defined within the block that contains the given debug address are enumerated. If all locals including any compiler-generated locals are needed, call the [EnumAllLocals](../../../extensibility/debugger/reference/idebugmethodfield-enumalllocals.md) method.  
  
 A method can contain multiple scoping contexts or blocks. For example, the following contrived method contains three scopes, the two inner blocks and the method body itself.  
  
```csharp  
public void func(int index)  
{  
    // Method body scope  
    int a = 0;  
    if (index == 1)  
    {  
        // Inner scope 1  
        int temp1 = a;  
    }  
    else  
    {  
        // Inner scope 2  
        int temp2 = a;  
    }  
}  
```  
  
 The [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md) object represents the `func` method itself. Calling the `EnumLocals` method with an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) set to the `Inner Scope 1` address returns an enumeration containing the `temp1` variable, for example.  
  
## See Also  
 [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)   
 [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)   
 [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)   
 [EnumAllLocals](../../../extensibility/debugger/reference/idebugmethodfield-enumalllocals.md)
