---
title: "DONT_SAVE_VSGLOG_TO_TEMP"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f27ab0e6-9575-4ca0-9901-37d3e5c3a2f5
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
# DONT_SAVE_VSGLOG_TO_TEMP
Defines by its presence whether the graphics log file is saved to the user's temporary files directory.  
  
## Syntax  
  
```cpp  
#define DONT_SAVE_VSGLOG_TO_TEMP  
```  
  
## Value  
 A preprocessor symbol that by its presence or absence determines whether the graphics log file is saved to the user's temporary files directory. If this symbol is defined, then the file name defined by `VSG_DEFAULT_RUN_FILENAME` is relative to the current directory of the captured app, or is an absolute path; otherwise, the file name defined by `VSG_DEFAULT_RUN_FILENAME` is relative to the user's temporary files directory and can't be an absolute path.  
  
## Remarks  
 Depending on the user's privileges, the graphics log file may not be able to be saved in an arbitrary location. We recommend that you prefer to save graphics logs to the user's temporary files directory, or another known-good location, if you are unsure whether the location you would choose can be written to by the user.  
  
 To prevent the graphics log file from being saved to the temporary files directory, you must defined `DONT_SAVE_VSGLOG_TO_TEMP` before you include `vsgcapture.h`.  
  
## Example  
 This example shows how to save the graphics log file to an absolute path on the host machine.  
  
```  
// Define DONT_SAVE_VSGLOG_TO_TEMP and VSG_DEFAULT_RUN_FILENAME before including vsgcapture.h  
#define DONT_SAVE_VSGLOG_TO_TEMP  
#define VSG_DEFAULT_RUN_FILENAME L"C:\\Graphics Diagnostics Captures\\default.vsglog"  
  
#include <vsgcapture.h>  
  
```  
  
## See Also  
 [VSG_DEFAULT_RUN_FILENAME](../debugger/vsg_default_run_filename.md)