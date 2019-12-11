---
title: "Error: You do not have permission to inspect the process&#39;s identity | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: You do not have permission to inspect the process&#39;s identity
You do not have permission to inspect the process's identity. This may be due to your system's configuration.

 The debugger was not able to inspect the process identity, which is necessary information for debugging. The most likely cause is Terminal Services being disabled. Terminal Services service is enabled by default. Follow these steps to re-enable it.

### To enable Terminal Services

1. Click **Start** and then choose **Control Panel**.

2. In Control Panel, choose **Switch to Classic View**, if necessary, and then double-click **Administrative Tools**.

3. In the **Administrative Tools** window, double-click **Computer Management**.

4. In the Computer Management window, expand the **Services and Applications** node.

5. Under the **Services and Applications**, click **Services**.

     A list of services appears in the right pane.

6. In the **Services** list, right-click **Terminal Services** and then choose **Properties**.

7. In the **Terminal Services Properties** window, go to the **General** tab and set **Startup type** to **Manual**.

8. Click **OK**.

9. Restart the computer.

     This procedure does not automatically enable Remote Desktop. If you want to enable Remote Desktop on your computer, perform the following additional procedure.

### To enable Remote Desktop

1. Click **Start** and then right-click **My Computer**.

2. Choose **Properties**.

     The **System Properties** window is displayed.

3. Click **Remote**.

4. Under **Remote Desktop**, select **Allow users to connect remotely to this computer**.

5. Click **OK**.

## See also
- [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)