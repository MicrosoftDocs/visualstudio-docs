---
title: "Stop debugging in progress"
description: Explore the Stop Debugging In Progress dialog box, which appears when the debugger tries to stop a debugging session, but stopping the session will take time.
ms.date: "1/12/2026"
ms.topic: "ui-reference"
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
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Stop debugging in progress

If the debugger tries to stop a debugging session, but stopping the session is going to take some time, the **Stop Debugging in Progress** dialog box appears. Stopping a debugging session is normally very fast and this dialog box doesn't appear. Sometimes, however, it takes additional time to detach from all the processes being debugged. If stopping the session takes more than a few seconds (or if a detach error occurs), this dialog box appears. If this occurs frequently, it may be due to an internal problem and you may want to contact Product Support Services or use [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md).

You can wait for the processes to detach and this dialog box to disappear, or use the **Stop Now** button to force immediate termination.

To force immediate termination of the debugging session:

Select the **Stop Now** button. Using **Stop Now** will terminate rather than detach from the processes being debugged. If you're debugging system processes, terminating those processes with **Stop Now** can have unexpected and undesired effects.

## See also
- [Debugger Security](../debugger/debugger-security.md)
- [Detaching Programs](/previous-versions/visualstudio/visual-studio-2010/x1thkxez(v=vs.100))