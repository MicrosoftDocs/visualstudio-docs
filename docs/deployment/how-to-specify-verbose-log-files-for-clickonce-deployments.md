---
title: Specify verbose log files (ClickOnce deployments)
description: Learn how to specify verbosity for the activity logs that ClickOnce maintains for installing, initializing, updating, and uninstalling a ClickOnce deployment.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - logs, ClickOnce deployment
  - ClickOnce deployment, logging
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Specify verbose log files for ClickOnce deployments

ClickOnce maintains activity log files for all deployments. These logs document details pertaining to installing, initializing, updating, and uninstalling a ClickOnce deployment. To increase the detail that ClickOnce writes to these log files, use Registry Editor (*regedit.exe*) to specify the verbosity level.

> [!CAUTION]
> If you use Registry Editor incorrectly, you may cause serious problems that may require you to reinstall the operating system. Use Registry Editor at your own risk.

 The following procedure describes how to specify the verbosity level for ClickOnce log files for the current user. To reduce the level of verbosity, remove this registry value.

### To specify verbose log files

1. Open *Regedit.exe*.

2. Navigate to the node **HKEY_CURRENT_USER\Software\Classes\Software\Microsoft\Windows\CurrentVersion\Deployment**.

3. If necessary, create a new string value named `LogVerbosityLevel`.

4. Set the `LogVerbosityLevel` value to `1`.

## Related content
- [Troubleshoot ClickOnce deployments](../deployment/troubleshooting-clickonce-deployments.md)