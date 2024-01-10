---
title: "Warning: Script Debugging Disabled"
description: A "Script Debugging Disabled" warning occurs when you try to debug script without enabling script debugging in Internet Explorer. See the steps to enable it.
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.scriptdisabled"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.subservice: vs-ide-debug
---
# Warning: Script Debugging Disabled

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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

## Related content
- [How to: Attach to Script](attach-to-running-processes-with-the-visual-studio-debugger.md)