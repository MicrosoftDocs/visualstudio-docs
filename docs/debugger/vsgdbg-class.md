---
title: "VsgDbg Class"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 6722263c-ccef-40c7-a0ae-87a863fbab00
caps.latest.revision: 5
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
# VsgDbg Class
Represents an interface for programmatic control of the in-app component of graphics diagnostics.  
  
## Syntax  
  
```cpp  
class VsgDbg;  
```  
  
## Members  
 The `VsgDbg` class supports the following members.  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[VsgDbg::VsgDbg (Constructor)](../debugger/vsgdbg--vsgdbg--constructor-.md)|Constructs an instance of the `VsgDbg` class and optionally prepares the in-app component of graphics diagnostics to actively capture and record graphics information.|  
|[VsgDbg::~VsgDbg (Destructor)](../debugger/vsgdbg--~vsgdbg--destructor-.md)|Destroys an instance of the `VsgDbg` class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[AddMessage](../debugger/addmessage.md)|Adds a custom message to the graphics diagnostics HUD (Head-Up Display).|  
|[BeginCapture](../debugger/begincapture.md)|Begins a capture interval that will end with `EndCapture`.|  
|[CaptureCurrentFrame](../debugger/capturecurrentframe.md)|Captures the remainder of the current frame to the graphics log file.|  
|[Copy (Programmatic Capture)](../debugger/copy--programmatic-capture-.md)|Copies the contents of the active graphics log (.vsglog) file into a new file.|  
|[EndCapture](../debugger/endcapture.md)|Ends a capture interval that was started with `BeginCapture`.|  
|[Init](../debugger/init.md)|Prepares the in-app component of graphics diagnostics to actively capture and record graphics information.|  
|[ToggleHUD](../debugger/togglehud.md)|Toggles the graphics diagnostics HUD overlay on or off.|  
|[UnInit](../debugger/uninit.md)|Finalizes the graphics log file, closes it, and frees resources that were used while the app was actively recording graphics information.|  
  
## Remarks  
 The `VsgDbg` class represents an interface that you can use to control graphics diagnostics features programmatically. You can use some features even when you're not actively capturing and recording graphics information; this includes the `AddMessage` member function and `ToggleHUD` member function. The other member functions either prepare the in-app component of graphics diagnostics to start or stop the active capture of graphics information, or must be called while the app is actively capturing and recording graphics information to a graphics log file.