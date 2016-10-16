---
title: "IDiaTable::Item"
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
  - "IDiaTable::Item method"
ms.assetid: eae11b26-4807-400c-be25-e85bbc0c6b20
caps.latest.revision: 9
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
# IDiaTable::Item
Retrieves a reference to the specified entry in the table.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD      index,  
   IUnknown** element  
);  
```  
  
#### Parameters  
 `index`  
 [in] The index of the table entry in the range 0 to `count`-1, where `count` is returned by the [IDiaTable::get_Count](../debugger/idiatable--get_count.md)method.  
  
 `element`  
 [out] Returns an `IUnknown` object that represents the specified table entry.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A table represents a collection of objects. Depending on those objects, the element parameter can be cast to the appropriate interface. For example, if a table contains [IDiaSegment](../debugger/idiasegment.md) objects, then the element parameter can be cast to the `IDiaSegment` interface.  
  
 It is a more common approach to call the `QueryInterface` method in the [IDiaTable](../debugger/idiatable.md) interface for the appropriate enumerator interface and use the enumerator's specific methods to access the table contents. See the [IDiaEnumInjectedSources](../debugger/idiaenuminjectedsources.md) interface for an example.  
  
## See Also  
 [IDiaTable](../debugger/idiatable.md)   
 [IDiaTable::get_Count](../debugger/idiatable--get_count.md)   
 [IDiaSegment](../debugger/idiasegment.md)   
 [IDiaEnumInjectedSources](../debugger/idiaenuminjectedsources.md)