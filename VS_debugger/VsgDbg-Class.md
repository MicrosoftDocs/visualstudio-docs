---
title: "VsgDbg Class"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6722263c-ccef-40c7-a0ae-87a863fbab00
caps.latest.revision: 5
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
|[VsgDbg::VsgDbg (Constructor)](../VS_debugger/VsgDbg--VsgDbg--Constructor-.md)|Constructs an instance of the `VsgDbg` class and optionally prepares the in-app component of graphics diagnostics to actively capture and record graphics information.|  
|[VsgDbg::~VsgDbg (Destructor)](../VS_debugger/VsgDbg--~VsgDbg--Destructor-.md)|Destroys an instance of the `VsgDbg` class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[AddMessage](../VS_debugger/AddMessage.md)|Adds a custom message to the graphics diagnostics HUD (Head-Up Display).|  
|[BeginCapture](../VS_debugger/BeginCapture.md)|Begins a capture interval that will end with `EndCapture`.|  
|[CaptureCurrentFrame](../VS_debugger/CaptureCurrentFrame.md)|Captures the remainder of the current frame to the graphics log file.|  
|[Copy (Programmatic Capture)](../VS_debugger/Copy--Programmatic-Capture-.md)|Copies the contents of the active graphics log (.vsglog) file into a new file.|  
|[EndCapture](../VS_debugger/EndCapture.md)|Ends a capture interval that was started with `BeginCapture`.|  
|[Init](../VS_debugger/Init.md)|Prepares the in-app component of graphics diagnostics to actively capture and record graphics information.|  
|[ToggleHUD](../VS_debugger/ToggleHUD.md)|Toggles the graphics diagnostics HUD overlay on or off.|  
|[UnInit](../VS_debugger/UnInit.md)|Finalizes the graphics log file, closes it, and frees resources that were used while the app was actively recording graphics information.|  
  
## Remarks  
 The `VsgDbg` class represents an interface that you can use to control graphics diagnostics features programmatically. You can use some features even when you're not actively capturing and recording graphics information; this includes the `AddMessage` member function and `ToggleHUD` member function. The other member functions either prepare the in-app component of graphics diagnostics to start or stop the active capture of graphics information, or must be called while the app is actively capturing and recording graphics information to a graphics log file.