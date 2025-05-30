---
title: "Stale Code Warning Dialog Box"
description: Read about the Stale Code Warning dialog box, which appears when you've made changes to native code that Edit and Continue couldn't immediately apply.
ms.date: "11/04/2016"
ms.topic: "ui-reference"
f1_keywords:
  - "vs.debug.ENC.stalecode"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Stale Code Warning dialog box"
  - "code, stale code warning"
  - "warnings, Stale Code Warning dialog box"
  - "Edit and Continue, stale code"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Stale Code Warning Dialog Box

This dialog box appears when you have made changes to native code that **Edit and Continue** could not immediately apply. As a result, some native code in the current stack frame is now out of date, that is, stale. For more information, see [Edit and continue (C++)](edit-and-continue-visual-cpp.md).

**Don't show me this dialog again**

If you select this check box, Edit and Continue will apply code changes without asking permission in the future. You can turn this warning on again by going to the **Options** dialog box, opening the **Debugging** Folder, clicking the **Edit and Continue** page, and selecting **Warn about stale code**.

## See also

- [Supported Code Changes (C++)](supported-code-changes-cpp.md)
- [Edit and Continue, Debugging, Options Dialog Box](/visualstudio/debugger/how-to-enable-and-disable-edit-and-continue)