---
title: "IDiaInjectedSource"
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
ms.assetid: 75192c5c-812d-4675-9dc5-4c2cff3ba503
caps.latest.revision: 9
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
# IDiaInjectedSource
Accesses injected source code stored in the DIA data source.  
  
## Syntax  
  
```  
IDiaInjectedSource : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaInjectedSource`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaInjectedSource::get_crc](../VS_debugger/IDiaInjectedSource--get_crc.md)|Retrieves a cyclic redundancy check (CRC) calculated from the bytes of the source code.|  
|[IDiaInjectedSource::get_length](../VS_debugger/IDiaInjectedSource--get_length.md)|Retrieves the number of bytes of code.|  
|[IDiaInjectedSource::get_filename](../VS_debugger/IDiaInjectedSource--get_filename.md)|Retrieves the file name for the source.|  
|[IDiaInjectedSource::get_objectFilename](../VS_debugger/IDiaInjectedSource--get_objectFilename.md)|Retrieves the object file name to which the source was compiled.|  
|[IDiaInjectedSource::get_virtualFilename](../VS_debugger/IDiaInjectedSource--get_virtualFilename.md)|Retrieves the name given to non-file source code; that is, code that was injected.|  
|[IDiaInjectedSource::get_sourceCompression](../VS_debugger/IDiaInjectedSource--get_sourceCompression.md)|Retrieves the indicator of the source compression used.|  
|[IDiaInjectedSource::get_source](../VS_debugger/IDiaInjectedSource--get_source.md)|Retrieves the source code bytes.|  
  
## Remarks  
 Injected source is text that is injected during compilation. This does not mean the preprocessor `#include` used in C++.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumInjectedSources::Item](../VS_debugger/IDiaEnumInjectedSources--Item.md) or [IDiaEnumInjectedSources::Next](../VS_debugger/IDiaEnumInjectedSources--Next.md) methods. See the [IDiaEnumInjectedSources](../VS_debugger/IDiaEnumInjectedSources.md) interface for an example of obtaining the `IDiaInjectedSource` interface.  
  
## Example  
 This example displays the data available from the `IDiaInjectedSource` interface. For an alternative approach using the [IDiaPropertyStorage](../VS_debugger/IDiaPropertyStorage.md) interface, see the example in the [IDiaEnumInjectedSources](../VS_debugger/IDiaEnumInjectedSources.md) interface.  
  
```cpp#  
void PrintInjectedSource(IDiaInjectedSource* pSource)  
{  
    ULONGLONG codeLength      = 0;  
    DWORD     crc             = 0;  
    DWORD     compressionType = 0;  
    BSTR      sourceFilename  = NULL;  
    BSTR      objectFilename  = NULL;  
    BSTR      virtualFilename = NULL;  
  
    std::cout << "Injected Source:" << std::endl;  
    if (pSource != NULL)  
    {  
        if (pSource->get_crc(&crc) == S_OK &&  
            pSource->get_sourceCompression(&compressionType) == S_OK &&  
            pSource->get_length(&codeLength) == S_OK)  
        {  
            wprintf(L"  crc = %lu\n", crc);  
            wprintf(L"  code length = %I64u\n",codeLength);  
            wprintf(L"  compression type code = %lu\n", compressionType);  
        }  
  
        wprintf(L"  source filename: ");  
        if (pSource->get_filename(&sourceFilename) == S_OK)  
        {  
            wprintf(L"%s", sourceFilename);  
        }  
        else  
        {  
            wprintf(L"<none>");  
        }  
        wprintf(L"\n");  
  
        wprintf(L"  object filename: ");  
        if (pSource->get_filename(&objectFilename) == S_OK)  
        {  
            wprintf(L"%s", objectFilename);  
        }  
        else  
        {  
            wprintf(L"<none>");  
        }  
        wprintf(L"\n");  
  
        wprintf(L"  virtual filename: ");  
        if (pSource->get_filename(&virtualFilename) == S_OK)  
        {  
            wprintf(L"%s", virtualFilename);  
        }  
        else  
        {  
            wprintf(L"<none>");  
        }  
        wprintf(L"\n");  
  
        SysFreeString(sourceFilename);  
        SysFreeString(objectFilename);  
        SysFreeString(virtualFilename);  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaEnumInjectedSources::Item](../VS_debugger/IDiaEnumInjectedSources--Item.md)   
 [IDiaEnumInjectedSources::Next](../VS_debugger/IDiaEnumInjectedSources--Next.md)   
 [IDiaEnumInjectedSources](../VS_debugger/IDiaEnumInjectedSources.md)