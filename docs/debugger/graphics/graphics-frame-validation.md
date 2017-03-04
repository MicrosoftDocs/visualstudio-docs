---
title: "Graphics Frame Validation | Microsoft Docs"
ms.custom: ""
ms.date: "03/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.graphics.FrameValidation"
ms.assetid: 1e639182-1301-4e28-9c1e-b5df732f3f1b
author: "BrianPeek"
ms.author: "brpeek"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Graphics Frame Validation

The Frame Validation window displays errors and warnings associated with the event list.  To view this window, select the **View > Frame Validation** menu.

![Frame Validation](media/gfx_diag_frame_validation.png)

Click the **Run Validation** button at the top left corner to initiate the analysis.  It may take several minutes to complete depending on the complexity of the frame.  Once complete, you will see several columns of data:

**Column**|**Description**
---|---
Event Id | ID which maps to an entry in the [Event List](graphics-event-list.md) window.
Severity | Error or Warning severity.
Category | A descriptor for the type of entry.
Message | The message associated with the event.
Event | The event associated with the error or warning.

## See Also  
[Graphics Diagnostics (Debugging DirectX Graphics)](visual-studio-graphics-diagnostics.md)   
