---
title: "VSG_DEFAULT_RUN_FILENAME"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: ea549d2f-c857-458c-93c7-bc5a2d11d15d
caps.latest.revision: 4
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
# VSG_DEFAULT_RUN_FILENAME
Defines the default file name of the graphics log file.  
  
## Syntax  
  
```cpp  
#define VSG_DEFAULT_FILENAME filename  
```  
  
#### Parameters  
 `filename`  
 The file name given by default to the graphics log file when graphics information is captured programmatically.  
  
## Value  
 A string literal that represents the file name of the graphics log file. By default, L"default.vsglog".  
  
```cpp  
#define VSG_DEFAULT_FILENAME L"default.vsglog"  
```  
  
## Remarks  
 If the preprocessor symbol `DONT_SAVE_VSGLOG_TO_TEMP` is defined, then the file name is relative to the current directory of the captured app, or is an absolute path; otherwise, it's relative to the user's temporary files directory and can't be an absolute path.  
  
 To change the defined file name, you must redefine it before you include `vsgcapture.h` in your program.  
  
## Example  
 This example shows how to change the capture file's default file name:  
  
```cpp  
// Redefine the default capture filename before including vsgcapture.h  
#define VSG_DEFAULT_FILENAME L"capture.vsglog"  
  
#include <vsgcapture.h>  
```  
  
## See Also  
 [DONT_SAVE_VSGLOG_TO_TEMP](../debugger/dont_save_vsglog_to_temp.md)