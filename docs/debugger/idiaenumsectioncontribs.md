---
title: "IDiaEnumSectionContribs"
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
  - "IDiaEnumSectionContribs interface"
ms.assetid: 0d6c0632-310f-4a99-8921-58149a1817e3
caps.latest.revision: 12
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
# IDiaEnumSectionContribs
Enumerates the various section contributions contained in the data source.  
  
## Syntax  
  
```  
IDiaEnumSectionContribs : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumSectionContribs`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumSectionContribs::get__NewEnum](../debugger/idiaenumsectioncontribs--get__newenum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumSectionContribs::get_Count](../debugger/idiaenumsectioncontribs--get_count.md)|Retrieves the number of section contributions.|  
|[IDiaEnumSectionContribs::Item](../debugger/idiaenumsectioncontribs--item.md)|Retrieves section contributions by means of an index.|  
|[IDiaEnumSectionContribs::Next](../debugger/idiaenumsectioncontribs--next.md)|Retrieves a specified number of section contributions in the enumeration sequence.|  
|[IDiaEnumSectionContribs::Skip](../debugger/idiaenumsectioncontribs--skip.md)|Skips a specified number of section contributions in an enumeration sequence.|  
|[IDiaEnumSectionContribs::Reset](../debugger/idiaenumsectioncontribs--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumSectionContribs::Clone](../debugger/idiaenumsectioncontribs--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Note for Callers  
 Obtain this interface from the [IDiaSession::getEnumTables](../debugger/idiasession--getenumtables.md) method. See the example for details.  
  
## Example  
 This example shows how to obtain (the `GetEnumSectionContribs` function) and use (the `ShowSectionContribs` function) the `IDiaEnumSectionContribs` interface. For a more complete example of using section contributions, see the [IDiaSectionContrib](../debugger/idiasectioncontrib.md) interface.  
  
```cpp#  
  
      IDiaEnumSectionContribs* GetEnumSectionContribs(IDiaSession *pSession)  
{  
    IDiaEnumSectionContribs* pUnknown    = NULL;  
    REFIID                   iid         = __uuidof(IDiaEnumSectionContribs);  
    IDiaEnumTables*          pEnumTables = NULL;  
    IDiaTable*               pTable      = NULL;  
    ULONG                    celt        = 0;  
  
    if (pSession->getEnumTables(&pEnumTables) != S_OK)  
    {  
        wprintf(L"ERROR - GetTable() getEnumTables\n");  
        return NULL;  
    }  
    while (pEnumTables->Next(1, &pTable, &celt) == S_OK && celt == 1)  
    {  
        // There is only one table that matches the given iid  
        HRESULT hr = pTable->QueryInterface(iid, (void**)&pUnknown);  
        pTable->Release();  
        if (hr == S_OK)  
        {  
            break;  
        }  
    }  
    pEnumTables->Release();  
    return pUnknown;  
}  
  
void ShowSectionContribs(IDiaSession *pSession)  
{  
    IDiaEnumSectionContribs* pEnumSectionContribs;  
  
    pEnumSectionContribs = GetEnumSectionContribs(pSession);  
    if (pSectionContrib != NULL)  
    {  
        IDiaSectionContrib* pSectionContrib;  
        ULONG celt = 0;  
  
        while(pEnumSectionContribs->Next(1, &pSectionContrib, &celt) == S_OK &&  
              celt == 1)  
        {  
            PrintSectionContrib(pSectionContrib, pSession);  
            pSectionContrib->Release();  
        }  
        pSectionContrib->Release();   
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../debugger/interfaces--debug-interface-access-sdk-.md)   
 [IDiaSession::getEnumTables](../debugger/idiasession--getenumtables.md)   
 [IDiaSectionContrib](../debugger/idiasectioncontrib.md)