---
title: "VsgDbg::VsgDbg (Constructor) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 670651e6-5e79-4845-b0c2-671beb7055a8
caps.latest.revision: 4
author: "mikejo5000"
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
# VsgDbg::VsgDbg (Constructor)
Constructs an instance of the `VsgDbg` class with or without preparing the in-app component of graphics diagnostics to actively capture and record graphics information by default, based on the specified Boolean parameter.  
  
## Syntax  
  
```cpp  
VsgDbg(  
  bDefaultInit  
);  
```  
  
#### Parameters  
 `bDefaultInit`  
 `true` to specify that the in-app component of graphics diagnostics is to be prepared to actively capture and record graphics information; `false` to specify that the app should not be prepared to actively capture and record graphics information at this time.  
  
## Remarks  
 When the constructor is called with `bDefaultInit` set to `true`, the file name of the graphics log file is determined by how the `DONT_SAVE_VSGLOG_TO_TEMP` and `VSG_DEFAULT_RUN_FILENAME` preprocessor symbols are defined before `vsgcapture.h` is included in your app.  
  
 When the constructor is called with `bDefaultInit` set to `false`, the in-app component of graphics diagnostics can be prepared to actively capture and record graphics information at a later time by calling the `Init` function.  
  
## See Also  
 [VsgDbg::~VsgDbg (Destructor)](../debugger/vsgdbg-tilde-vsgdbg-destructor.md)   
 [Init](../debugger/init.md)   
 [DONT_SAVE_VSGLOG_TO_TEMP](../debugger/dont-save-vsglog-to-temp.md)   
 [VSG_DEFAULT_RUN_FILENAME](../debugger/vsg-default-run-filename.md)