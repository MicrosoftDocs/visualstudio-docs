---
title: "Event logging for Office solutions"
description: Use the event viewer in Windows to see exception messages that are captured by the Visual Studio Tools for Office runtime.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office applications [Office development in Visual Studio], event viewer"
  - "ClickOnce deployment [Office development in Visual Studio], event viewer"
  - "deploying applications [Office development in Visual Studio], event viewer"
  - "Office development in Visual Studio, event viewer"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Event logging for Office solutions

  You can use the event viewer in Windows to see exception messages that are captured by the  Visual Studio Tools for Office runtime  when you install or uninstall Office solutions. You can use these messages from the event logger to resolve installation and deployment problems.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

## Read the Event Log
 Open **Event Viewer** and filter for the events you want to see.

### To read the Event Log in Windows Server 2003 and Windows XP

1. In Control Panel, open **Administrative Tools**.

2. Start **Event Viewer**.

3. In the list of event logs, select **Application**.

4. On the **View** menu, click **Filter**.

5. In the **Event source** list, select **VSTO 4.0**.

6. For installation events, in the **Event ID** box, type **4096**.

7. Click **OK** to see the filtered view.

### To read the Event Log in Windows 7, Windows Vista, and Windows Server 2008

1. In Control Panel, open **Administrative Tools**.

2. Start **Event Viewer**.

3. Expand **Windows Logs**.

4. In the list of event logs, select **Application**.

5. On the **Action** menu, click **Filter Current Log**.

6. In the **Event source** list, select **VSTO 4.0**.

7. For installation events, in the **Event ID** box, type **4096**.

8. Click **OK** to see the filtered view.

   The event viewer includes the following information:

- The location of the deployment manifest for the solution.

- A message that describes the cause of the error or exception.

  These exception messages can help you determine the reason for an installation problem, such as an untrusted certificate, an untrusted document location, or an invalid deployment manifest.

  After an Office solution is uninstalled, the exception messages remain in the event log.

  To show or log exception messages when an Office solution is running, see [Debug Office projects](../vsto/debugging-office-projects.md) and [Debug Office projects](../vsto/debugging-office-projects.md).

### Localization
 The language of the exception message is determined by the Visual Studio Tools for Office runtime language. For instance, if the end-user computer has the Japanese language pack installed, the exception message is written to the event log in Japanese.

## Disable the event logger
 By default, the event logger is enabled when you install or uninstall Office solutions. You can disable the event logger by setting the VSTO_EVENTLOGDISABLED environment variable to "1" (one).

### To disable the Event Log

1. In Control Panel, open **System**.

2. On the **Advanced** tab, click **Environment Variables**.

3. In the **System variables** pane, click **New**.

4. In the **New System Variable** dialog box, type **VSTO_EVENTLOGDISABLED** in the **Variable name** box.

5. In the **Variable value** box, type **1**.

6. Click **OK**.

## Related content
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
- [Troubleshoot Office solution deployment](../vsto/troubleshooting-office-solution-deployment.md)
