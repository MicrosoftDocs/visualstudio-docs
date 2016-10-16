---
title: "BP_RESOLUTION_LOCATION"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "BP_RESOLUTION_LOCATION"
helpviewer_keywords: 
  - "BP_RESOLUTION_LOCATION structure"
ms.assetid: 21dc5246-69c1-43e3-855c-9cd4e596c0e6
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# BP_RESOLUTION_LOCATION
Specifies the structure of the breakpoint resolution location.  
  
## Syntax  
  
```cpp#  
struct _BP_RESOLUTION_LOCATION {  
   BP_TYPE bpType;  
   union {  
      BP_RESOLUTION_CODE bpresCode;  
      BP_RESOLUTION_DATA bpresData;  
      int                unused;  
   } bpResLocation;  
} BP_RESOLUTION_LOCATION;  
```  
  
```c#  
public struct BP_RESOLUTION_LOCATION {  
   public uint bpType;  
   public IntPtr unionmember1;  
   public IntPtr unionmember2;  
   public IntPtr unionmember3;  
   public uint   unionmember4;  
};  
```  
  
## Members  
 `bpType`  
 A value from the [BP_TYPE](../extensibility/bp_type.md) enumeration that specifies how to interpret the `bpResLocation` union or `unionmemberX` members.  
  
 `bpResLocation.bpresCode`  
 [C++ only] Contains the [BP_RESOLUTION_CODE](../extensibility/bp_resolution_code.md) structure if `bpType` = `BPT_CODE`.  
  
 `bpResLocation.bpresData`  
 [C++ only] Contains the [BP_RESOLUTION_DATA](../extensibility/bp_resolution_data.md) structure if `bpType` = `BPT_DATA`.  
  
 `bpResLocation.unused`  
 [C++ only] A placeholder.  
  
 `unionmember1`  
 [C# only] See Remarks on how to interpret.  
  
 `unionmember2`  
 [C# only] See Remarks on how to interpret.  
  
 `unionmember3`  
 [C# only] See Remarks on how to interpret.  
  
 `unionmember4`  
 [C# only] See Remarks on how to interpret.  
  
## Remarks  
 This structure is a member of the [BP_ERROR_RESOLUTION_INFO](../extensibility/bp_error_resolution_info.md) and [BP_RESOLUTION_INFO](../extensibility/bp_resolution_info.md) structures.  
  
 [C# only] The `unionmemberX` members are interpreted according to the following table. Look down the left column for the `bpType` value then across to determine what each `unionmemberX` member represents and marshal the `unionmemberX` accordingly. See the Example for a way to interpret this structure in C#.  
  
|`bpLocationType`|`unionmember1`|`unionmember2`|`unionmember3`|`unionmember4`|  
|----------------------|--------------------|--------------------|--------------------|--------------------|  
|`BPT_CODE`|[IDebugCodeContext2](../extensibility/idebugcodecontext2.md)|-|-|-|  
|`BPT_DATA`|`string` (data expression)|`string` (function name)|`string` (image name)|`enum_BP_RES_DATA_FLAGS`|  
  
## Example  
 This example shows how to interpret the `BP_RESOLUTION_LOCATION` structure in C#.  
  
```c#  
using System;  
using System.Runtime.Interop.Services;  
using Microsoft.VisualStudio.Debugger.Interop;  
  
namespace MyPackage  
{  
    public class MyClass  
    {  
        public void Interpret(BP_RESOLUTION_LOCATION bprl)  
        {  
            if (bprl.bpType == (uint)enum_BP_TYPE.BPT_CODE)  
            {  
                 IDebugCodeContext2 pContext = (IDebugCodeContext2)Marshal.GetObjectForIUnknown(bp.unionmember1);  
            }  
            else if (bprl.bpType == (uint)enum_BP_TYPE.BPT_DATA)  
            {  
                 string dataExpression = Marshal.PtrToStringBSTR(bp.unionmember3);  
                 string functionName = Marshal.PtrToStringBSTR(bp.unionmember2);  
                 string imageName = Marshal.PtrToStringBSTR(bp.unionmember3);  
                 enum_BP_RES_DATA_FLAGS numElements = (enum_BP_RES_DATA_FLAGS)bp.unionmember4;  
            }  
        }  
    }  
}  
```  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [BP_TYPE](../extensibility/bp_type.md)   
 [BP_ERROR_RESOLUTION_INFO](../extensibility/bp_error_resolution_info.md)   
 [BP_RESOLUTION_INFO](../extensibility/bp_resolution_info.md)   
 [BP_RESOLUTION_CODE](../extensibility/bp_resolution_code.md)   
 [BP_RESOLUTION_DATA](../extensibility/bp_resolution_data.md)   
 [BP_RES_DATA_FLAGS](../extensibility/bp_res_data_flags.md)