---
title: "IDiaFrameData"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaFrameData interface"
ms.assetid: 2f1b4986-341b-4641-89a4-226e261e9d93
caps.latest.revision: 10
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaFrameData
Exposes the details of a stack frame.  
  
## Syntax  
  
```  
IDiaFrameData : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaFrameData`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaFrameData::get_addressSection](../debugger/idiaframedata--get_addresssection.md)|Retrieves the section part of the code address for the frame.|  
|[IDiaFrameData::get_addressOffset](../debugger/idiaframedata--get_addressoffset.md)|Retrieves the offset part of the code address for the frame.|  
|[IDiaFrameData::get_relativeVirtualAddress](../debugger/idiaframedata--get_relativevirtualaddress.md)|Retrieves the image relative virtual address (RVA) of the code for the frame.|  
|[IDiaFrameData::get_virtualAddress](../debugger/idiaframedata--get_virtualaddress.md)|Retrieves the virtual address (VA) of the code for the frame.|  
|[IDiaFrameData::get_lengthBlock](../debugger/idiaframedata--get_lengthblock.md)|Retrieves the length, in bytes, of the block of code described by the frame.|  
|[IDiaFrameData::get_lengthLocals](../debugger/idiaframedata--get_lengthlocals.md)|Retrieves the number of bytes of local variables pushed on the stack.|  
|[IDiaFrameData::get_lengthParams](../debugger/idiaframedata--get_lengthparams.md)|Retrieves the number of bytes of parameters pushed on the stack.|  
|[IDiaFrameData::get_maxStack](../debugger/idiaframedata--get_maxstack.md)|Retrieves the maximum number of bytes pushed on the stack in the frame.|  
|[IDiaFrameData::get_lengthProlog](../debugger/idiaframedata--get_lengthprolog.md)|Retrieves the number of bytes of prologue code in the block.|  
|[IDiaFrameData::get_lengthSavedRegisters](../debugger/idiaframedata--get_lengthsavedregisters.md)|Retrieves the number of bytes of saved registers pushed on the stack.|  
|[IDiaFrameData::get_program](../debugger/idiaframedata--get_program.md)|Retrieves the program string that is used to compute the register set before the call to the current function.|  
|[IDiaFrameData::get_systemExceptionHandling](../debugger/idiaframedata--get_systemexceptionhandling.md)|Retrieves a flag that indicates that system exception handling is in effect.|  
|[IDiaFrameData::get_cplusplusExceptionHandling](../debugger/idiaframedata--get_cplusplusexceptionhandling.md)|Retrieves a flag that indicates that C++ exception handling is in effect.|  
|[IDiaFrameData::get_functionStart](../debugger/idiaframedata--get_functionstart.md)|Retrieves a flag that indicates that the block contains the entry point of a function.|  
|[IDiaFrameData::get_allocatesBasePointer](../debugger/idiaframedata--get_allocatesbasepointer.md)|Retrieves a flag that indicates that the base pointer is allocated for code in this address range. This method is deprecated.|  
|[IDiaFrameData::get_type](../debugger/idiaframedata--get_type.md)|Retrieves the compiler-specific frame type.|  
|[IDiaFrameData::get_functionParent](../debugger/idiaframedata--get_functionparent.md)|Retrieves frame data interface for enclosing function.|  
|[IDiaFrameData::execute](../debugger/idiaframedata--execute.md)|Performs stack unwinding and returns the current state of registers in a stack walk frame interface.|  
  
## Remarks  
 The details available for a frame are for execution points within the address range indicated by the address and block length.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumFrameData::Next](../debugger/idiaenumframedata--next.md) or [IDiaEnumFrameData::Item](../debugger/idiaenumframedata--item.md) methods. See the [IDiaEnumFrameData](../debugger/idiaenumframedata.md) interface for details.  
  
## Example  
 This example prints out the properties of an `IDiaFrameData` object. See the [IDiaEnumFrameData](../debugger/idiaenumframedata.md) interface for an example of how the `IDiaFrameData` interface is obtained.  
  
```cpp#  
void PrintFrameData(IDiaFrameData* pFrameData){  
    DWORD dwSect;  
    DWORD dwOffset;  
    DWORD cbBlock;  
    DWORD cbLocals; // Number of bytes reserved for the function locals  
    DWORD cbParams; // Number of bytes reserved for the function arguments  
    DWORD cbMaxStack;  
    DWORD cbProlog;  
    DWORD cbSavedRegs;  
    BOOL  bSEH;  
    BOOL  bEH;  
    BOOL  bStart;  
    BSTR  wszProgram;  
  
    if(pFrameData->get_addressSection(&dwSect) == S_OK &&   
       pFrameData->get_addressOffset(&dwOffset) == S_OK &&  
       pFrameData->get_lengthBlock(&cbBlock) == S_OK &&  
       pFrameData->get_lengthLocals(&cbLocals) == S_OK &&  
       pFrameData->get_lengthParams(&cbParams) == S_OK &&  
       pFrameData->get_maxStack(&cbMaxStack) == S_OK &&  
       pFrameData->get_lengthProlog(&cbProlog) == S_OK &&  
       pFrameData->get_lengthSavedRegisters(&cbSavedRegs) == S_OK &&  
       pFrameData->get_systemExceptionHandling(&bSEH) == S_OK &&  
       pFrameData->get_cplusplusExceptionHandling(&bEH) == S_OK &&  
       pFrameData->get_functionStart(&bStart) == S_OK )  
    {  
        wprintf(L"Frame address  : %04X:%08X\n", dwSect, dwOffset);  
        wprintf(L"Block size     : 0x%8X\n", cbBlock);  
        wprintf(L"Locals size    : 0x%8X\n", cbLocals);  
        wprintf(L"Parms size     : 0x%8X\n", cbParams);  
        wprintf(L"Max stack used : 0x%8X\n", cbMaxStack);  
        wprintf(L"Prolog size    : 0x%8X\n", cbProlog);  
        wprintf(L"Saved regs size: 0x%8X\n", cbSavedRegs);  
        wprintf(L"System Exception Handling: %c\n", bSEH ? L'Y' : L'N');  
        wprintf(L"C++ Exception Handling   : %c\n", bEH ? L'Y' : L'N');  
        wprintf(L"Function starts in block : %c\n", bStart ? L'Y' : L'N');  
  
        if (pFrameData->get_program(&wszProgram) == S_OK)  
        {  
            wprintf(L"Program used for register set: %s\n", wszProgram);  
            SysFreeString(wszProgram);  
        }  
        else  
        {  
            wprintf(L"\n");  
        }  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../debugger/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumFrameData](../debugger/idiaenumframedata.md)   
 [IDiaEnumFrameData::Item](../debugger/idiaenumframedata--item.md)   
 [IDiaEnumFrameData::Next](../debugger/idiaenumframedata--next.md)