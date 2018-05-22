---
title: "Visual Studio Experience Improvement Program"
description: "Find out how to manage privacy settings in Visual Studio."
ms.date: 05/21/2018
ms.prod: visual-studio-dev15
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.topic: conceptual
author: PoulChapman
ms.author: tglee
manager: douge
ms.workload:
  - "multiple"
---
# Visual Studio Experience Improvement Program

The Visual Studio Experience Improvement Program (VSEIP) is a program designed to help Microsoft improve Visual Studio over time. This program collects information about computer hardware and how people use Visual Studio, without interrupting users in their tasks at the computer. The information that's collected helps Microsoft identify which features to improve. This document covers how to opt in or out of the VSEIP.

## Opt in or out

The VSEIP is turned on by default. You can turn it off, or back on again, by following these instructions:

1. Start Visual Studio.

1. From the **Help** menu, point to **Send Feedback**, and then select **Settings**.

1. To turn off VSEIP, select **No, I would not like to participate**, and then select **OK**.
   To turn on VSEIP, select **Yes, I am willing to participate**, and then clselectick **OK**.

### Registry settings

If you install the [Build Toosl for Visual Studio](https://www.visualstudio.com/downloads/#build-tools-for-visual-studio-2017), you must update the registry to configure the VSEIP. Enterprise customers can construct a group policy to opt in or out of the VSEIP by setting a registry-based policy. The relevant registry subkey and settings are as follows:

Subkey = **HKEY_CURRENT_USER\SOFTWARE\Microsoft\VSCommon\15.0\SQM**
Entry = OptIn
Value = (DWORD)
- **0** is opted out (turn off the VSEIP)
- **1** is opted in (turn on the VSEIP)

> [!CAUTION]
> Incorrectly editing the registry may severely damage your system. Before making changes to the registry, you should back up any valued data on the computer. You can also use the Last Known Good Configuration startup option if you encounter problems after manual changes have been applied.

For more information about the information collected, processed, or transmitted by the VSEIP, see the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

[!INCLUDE [gdpr-hybrid-note](../misc/includes/gdpr-hybrid-note.md)]

## See also

* [Talk to us](../ide/talk-to-us.md)
* [How to report a problem with Visual Studio](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
* [Visual Studio Developer Community](https://developercommunity.visualstudio.com/)
* [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement)