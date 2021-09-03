---
description: "The debugger stopped execution of code on the Web site."
title: "Web site worker process has been terminated by IIS | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.web_server_process_terminated"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Error: Web site worker process has been terminated by IIS
The debugger stopped execution of code on the Web site. This caused Internet Information Services (IIS) to assume that the worker process had stopped responding. Therefore, IIS terminated the worker process.

 To continue to debug, you must configure IIS to allow the worker process to continue. This error message does not appear with versions of IIS that are older than IIS 7.

### To configure IIS 7 to allow the worker process to continue

1. Open the **Administrative Tools** window.

   1. Click **Start**, and then choose **Control Panel**.

   2. In **Control Panel**, choose **Switch to Classic View**, if necessary, and then double-click **Administrative Tools**.

2. In the **Administrative Tools** window, double-click **Internet Information Services (IIS) Manager**.

    IIS Manager opens.

3. In the **Connections** pane, expand the \<computer name> node if necessary.

4. Under the \<computer name> node, click **Application Pools**.

5. In the **Application Pools** list, right-click the name of the pool your application runs in, and then click **Advanced Settings**.

6. In the **Advanced Settings** dialog box, locate the **Process Model** section, and perform one of the following actions:

   - Set **Ping Enabled** to **False**.

   - Set **Ping Maximum Response Time** to a value that is larger than 90 seconds.

     Setting **Ping Enabled** to **False** stops IIS from checking whether the worker process is still running and keeps the worker process alive until you stop your debugged process. Setting **Ping Maximum Response Time** to a large value allows IIS to continue monitoring the worker process.

7. Click **OK** to close the **Advanced Settings** dialog box.

8. Close IIS Manager and the **Administrative Tools** window.

## See also
- [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)
