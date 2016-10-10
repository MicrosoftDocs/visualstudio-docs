---
title: "IDiaStackFrame"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 486d25b8-a590-41c1-bdb5-faff3ae35632
caps.latest.revision: 16
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# IDiaStackFrame
Exposes the properties of a stack frame.  
  
## Syntax  
  
```  
IDiaStackFrame : IUnknown  
```  
  
## Methods in Vtable Order  
 The following are methods supported by this interface:  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaStackFrame::get_allocatesBasePointer](../VS_debugger/IDiaStackFrame--get_allocatesBasePointer.md)|Retrieves a flag indicating that the base pointer is allocated for code in this address range. This method is deprecated.|  
|[IDiaStackFrame::get_base](../VS_debugger/IDiaStackFrame--get_base.md)|Retrieves the address base of the frame.|  
|[IDiaStackFrame::get_cplusplusExceptionHandling](../VS_debugger/IDiaStackFrame--get_cplusplusExceptionHandling.md)|Retrieves a flag indicating that C++ exception handling is in effect.|  
|[IDiaStackFrame::get_functionStart](../VS_debugger/IDiaStackFrame--get_functionStart.md)|Retrieves a flag indicating that the block contains the entry point of a function.|  
|[IDiaStackFrame::get_lengthLocals](../VS_debugger/IDiaStackFrame--get_lengthLocals.md)|Retrieves the number of bytes of local variables pushed on the stack.|  
|[IDiaStackFrame::get_lengthParams](../VS_debugger/IDiaStackFrame--get_lengthParams.md)|Retrieves the number of bytes of parameters pushed on the stack.|  
|[IDiaStackFrame::get_lengthProlog](../VS_debugger/IDiaStackFrame--get_lengthProlog.md)|Retrieves the number of bytes of prologue code in the block|  
|[IDiaStackFrame::get_lengthSavedRegisters](../VS_debugger/IDiaStackFrame--get_lengthSavedRegisters.md)|Retrieves the number of bytes of saved registers pushed on the stack.|  
|[IDiaStackFrame::get_localsBase](../VS_debugger/IDiaStackFrame--get_localsBase.md)|Retrieves the address base of the locals.|  
|[IDiaStackFrame::get_maxStack](../VS_debugger/IDiaStackFrame--get_maxStack.md)|Retrieves the maximum number of bytes pushed on the stack in the frame.|  
|[IDiaStackFrame::get_rawLVarInstanceValue](../VS_debugger/IDiaStackFrame--get_rawLVarInstanceValue.md)|Retrieves the value of the specified local variable as raw bytes.|  
|[IDiaStackFrame::get_registerValue](../VS_debugger/IDiaStackFrame--get_registerValue.md)|Retrieves the value of a specified register.|  
|[IDiaStackFrame::get_returnAddress](../VS_debugger/IDiaStackFrame--get_returnAddress.md)|Retrieves the return address of the frame.|  
|[IDiaStackFrame::get_size](../VS_debugger/IDiaStackFrame--get_size.md)|Retrieves the size of the frame in bytes.|  
|[IDiaStackFrame::get_systemExceptionHandling](../VS_debugger/IDiaStackFrame--get_systemExceptionHandling.md)|Retrieves a flag indicating that system exception handling is in effect.|  
|[IDiaStackFrame::get_type](../VS_debugger/IDiaStackFrame--get_type.md)|Retrieves the frame type.|  
  
## Remarks  
 A stack frame is an abstraction of a function call during its execution.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumStackFrames::Next](../VS_debugger/IDiaEnumStackFrames--Next.md) method. See the [IDiaEnumStackFrames](../VS_debugger/IDiaEnumStackFrames.md) interface for an example on obtaining the `IDiaStackFrame` interface.  
  
## Example  
 This example displays various attributes of a stack frame.  
  
```cpp#  
void PrintStackFrame(IDiaStackFrame* pFrame)  
{  
    if (pFrame != NULL)  
    {  
        ULONGLONG bottom = 0;  
        ULONGLONG top    = 0;  
  
        if (pFrame->get_base(&bottom) == S_OK &&  
            pFrame->get_registerValue( CV_REG_ESP, &top ) == S_OK )  
        {  
             printf("range = 0x%08I64x - 0x%08I64x\n", bottom, top);  
        }  
  
        ULONGLONG returnAddress = 0;  
        if (pFrame->get_returnAddress(&returnAddress) == S_OK)  
        {  
             printf("return address = 0x%08I64x\n", returnAddress);  
        }  
  
        DWORD lengthFrame     = 0;  
        DWORD lengthLocals    = 0;  
        DWORD lengthParams    = 0;  
        DWORD lengthProlog    = 0;  
        DWORD lengthSavedRegs = 0;  
        if (pFrame->get_size(&lengthFrame) == S_OK &&  
            pFrame->get_lengthLocals(&lengthLocals) == S_OK &&  
            pFrame->get_lengthParams(&lengthParams) == S_OK &&  
            pFrame->get_lengthProlog(&lengthProlog) == S_OK &&  
            pFrame->get_lengthSavedRegisters(&lengthSavedRegs) == S_OK)  
        {  
            printf("stack frame size          = 0x%08lx bytes\n", lengthFrame);  
            printf("length of locals          = 0x%08lx bytes\n", lengthLocals);  
            printf("length of parameters      = 0x%08lx bytes\n", lengthParams);  
            printf("length of prolog          = 0x%08lx bytes\n", lengthProlog);  
            printf("length of saved registers = 0x%08lx bytes\n", lengthSavedRegs);  
        }  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaEnumStackFrames](../VS_debugger/IDiaEnumStackFrames.md)   
 [IDiaEnumStackFrames::Next](../VS_debugger/IDiaEnumStackFrames--Next.md)   
 [IDiaStackWalkFrame](../VS_debugger/IDiaStackWalkFrame.md)