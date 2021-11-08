---
title: "Warning: Script Debugging Disabled | Microsoft Docs"
description: A "Script Debugging Disabled" warning occurs when you try to debug script without enabling script debugging in Internet Explorer. See the steps to enable it.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.scriptdisabled"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
ms.assetid: 323d2b1d-52a4-42f7-b4ad-96b4b0c23b8d
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Warning: Script Debugging Disabled
Script Debugging is currently disabled in Internet Explorer

 This warning occurs when you try to debug script without enabling script debugging in Internet Explorer. For security reasons, Internet Explorer disables script debugging by default.

### To enable script debugging in Internet Explorer

1. On the Internet Explorer **Tools** menu, choose **Internet Options**.

2. In the **Internet Options** dialog box, click the **Advanced** tab.

3. On the **Advanced** tab, look in the **Settings** box, **Browsing** category.

4. Clear **Disable Script Debugging (Internet Explorer)**.

5. Click **OK**.

6. Exit and restart Internet Explorer.

     The new settings will now be in effect.

## See also
- [How to: Attach to Script](attach-to-running-processes-with-the-visual-studio-debugger.md)