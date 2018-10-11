---
title: "Copy (Programmatic Capture) | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 30ec235a-0abb-44b9-8852-61bc9e67ce22
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Copy (Programmatic Capture)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Copies the contents of the active graphics log (.vsglog) file into a new file.  
  
## Syntax  
  
```cpp  
void Copy(  
  wchar_t const * szNewVSGLog  
);  
```  
  
#### Parameters  
 `szNewVSGLog`  
 The file name of the new graphics log file.  
  
## Remarks  
 To copy the graphics information to a new file, you must already have captured some graphics information; otherwise, nothing happens.



