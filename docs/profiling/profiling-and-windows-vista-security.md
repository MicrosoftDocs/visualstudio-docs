---
title: "Profiling and Windows Vista security | Microsoft Docs"
ms.date: "11/02/2018"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Profiling Tools,security"
  - "performance tools, security"
ms.assetid: 842112fc-b886-4801-8cd7-a25b314b0393
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Profiling and Windows Vista security

Depending on the [!INCLUDE[wiprlhext](../debugger/includes/wiprlhext_md.md)] User Access Permissions settings that a computer administrator has made available, an individual user might have security permission to profile a process on that computer. The following examples illustrate possible differences among users:

- Some users may access advanced profiling features when the administrator has set the driver and service to start.

- Domain users may access sample profiling only.

- Some users may deny access to profiling to all other users.

  For more information, see the ADMIN options in [VSPerfCmd](../profiling/vsperfcmd.md).

## Cross-session profiling

*Cross-session profiling* is the ability to profile a process that runs in a different user session. For example, most services run in session 0, and users can't run directly in session 0. By using the **Attach to Process** button on the Performance Explorer toolbar, or the `/attach` option of the VSPerfCmd command-line tool, you can profile most processes in different user sessions.

You can see a list of the processes that are available by setting the cross-process profiling visibility options. These options are available in the **Attach to process** window that is displayed when you select **Attach to Process**:

- **Show processes from all users**

  When this option isn't selected, the list displays only those processes that are owned by the current user. Otherwise, the list displays processes from all users.

- **Show processes in all sessions**

  When this option isn't selected, the list displays processes in the current session. Otherwise, the list displays processes in all sessions.

## See also

- [Overviews](../profiling/overviews-performance-tools.md)
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [How to: Attach to a running process](/previous-versions/visualstudio/visual-studio-2010/c6wf8e4z\(v\=vs.100\))
