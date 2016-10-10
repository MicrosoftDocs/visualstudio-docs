---
title: "IDiaSession::put_loadAddress"
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
ms.assetid: b157b245-1ea0-4b80-8962-d8b278dbc742
caps.latest.revision: 11
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
# IDiaSession::put_loadAddress
Sets the load address for the executable file that corresponds to the symbols in this symbol store.  
  
## Syntax  
  
```cpp#  
HRESULT put_loadAddress (   
   ULONGLONG NewVal  
);  
```  
  
#### Parameters  
 `NewVal`  
 [in] Load address for the executable file.  
  
## Remarks  
 Symbol virtual address (VA) properties are computed using the value of this method. Virtual addresses are not calculated unless this property is set to non-zero.  
  
> [!NOTE]
>  You must call this method when you get the [IDiaSession](../VS_debugger/IDiaSession.md) object and before you start using the object if you need to use any virtual properties on symbols.  
  
## See Also  
 [IDiaSession](../VS_debugger/IDiaSession.md)