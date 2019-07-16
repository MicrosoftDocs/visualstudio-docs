---
title: "IDiaSession::getEnumTables | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSession::getEnumTables method"
ms.assetid: 66e0fba2-ca63-4e24-a46a-c99c7fb61dd1
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSession::getEnumTables
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves an enumerator for all tables contained in the symbol store.  
  
## Syntax  
  
```cpp#  
HRESULT getEnumTables (   
   IDiaEnumTables** ppEnumTables  
);  
```  
  
#### Parameters  
 `ppEnumTables`  
 [out] Returns an [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md) object. Use this interface to enumerate the tables in the symbol store.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Example  
 This example presents a general function that uses the `getEnumTables` method to obtain a specific enumerator object. If the enumerator is found, the function returns a pointer that can be cast to the desired interface; otherwise, the function returns `NULL`.  
  
```cpp#  
IUnknown *GetTable(IDiaSession *pSession, REFIID iid)  
{  
    IUnknown *pUnknown = NULL;  
    if (pSession != NULL)  
    {  
        CComPtr<IDiaEnumTables> pEnumTables;  
        if (pSession->getEnumTables(&pEnumTables) == S_OK)  
        {  
             CComPtr<IDiaTable> pTable;  
             DWORD celt = 0;  
             while(pEnumTables->Next(1,&pTable,&celt) == S_OK &&  
                   celt == 1)  
             {  
                  if (pTable->QueryInterface(iid, (void **)pUnknown) == S_OK)  
                  {  
                       break;  
                  }  
                  pTable = NULL;  
             }  
        }  
    }  
    return(pUnknown);  
}  
```  
  
## See Also  
 [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md)   
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
