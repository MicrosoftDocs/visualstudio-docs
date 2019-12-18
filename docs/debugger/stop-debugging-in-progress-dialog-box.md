---
title: "Stop Debugging In Progress Dialog Box | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "vs.debug.stopnow"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
  - "SQL"
helpviewer_keywords:
  - "Stop Debugging in Progress dialog box"
ms.assetid: ed7ef49d-e25f-4a4d-9396-9bc7b4143117
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Stop Debugging In Progress Dialog Box
This dialog box appears when the debugger is trying to stop a debugging session, but stopping the session is going to take some time. Stopping a debugging session is normally very fast and this dialog box does not appear. Sometimes, however, it takes additional time to detach from all the processes being debugged. If stopping the session takes more than a few seconds (or if a detach error occurs), this dialog box appears. If this occurs frequently, it may be due to an internal problem and you may want to contact Product Support Services.

 You can wait for the processes to detach and this dialog box to disappear, or use the **Stop Now** button to force immediate termination.

 **Stop Now**
 Click this button to end the debugging session immediately. Using **Stop Now** will terminate rather than detaching the processes being debugged. If you are debugging system processes, terminating those processes with **Stop Now** can have unexpected and undesired effects.

## See also
- [Debugger Security](../debugger/debugger-security.md)
- [Detaching Programs](/previous-versions/visualstudio/visual-studio-2010/x1thkxez(v=vs.100))