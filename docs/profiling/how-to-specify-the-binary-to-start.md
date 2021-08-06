---
title: Specify the Binary to Start | Microsoft Docs
description: Learn how you must enter information in the <Target> Property Pages dialog box to profile binaries, such as DLLs.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.performance.property.itemlaunch
helpviewer_keywords: 
  - profiling tools, launching
  - performance tools, launching
  - performance sessions, launching
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Specify the binary to start

To profile binaries, such as DLLs, you must enter information in the **\<Target> Property Pages** dialog box. This information indicates where the DLL project can find the calling application.

1. In **Performance Explorer**, right-click the target binary, and then click **Properties**.

2. In the **Property Pages** dialog box, click the **Launch** properties.

3. Select the **Override project properties** check box.

4. In the **Executable to launch** text box, specify the file location.

5. In the **Arguments** text box, specify arguments that are required to start the application.

6. In the **Working directory** text box, specify the directory location.

7. Click **OK**.

## See also

[Configure performance sessions](../profiling/configuring-performance-sessions.md)
