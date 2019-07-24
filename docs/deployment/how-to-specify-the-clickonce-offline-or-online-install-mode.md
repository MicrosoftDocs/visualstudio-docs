---
title: "How to: Specify the ClickOnce Offline or Online Install Mode | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "ClickOnce deployment, specifying install mode"
  - "install mode"
  - "online applications"
  - "offline applications"
  - "ClickOnce install mode"
ms.assetid: 0aee5fc1-e966-4bda-9b8f-d9997aeaa779
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Specify the ClickOnce offline or online install mode
The `Install Mode` for a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application determines whether the application will be available offline or online. When you choose **The application is available online only**, the user must have access to the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] publishing location (either a Web page or a file share) in order to run the application. When you choose **The application is available offline as well**, the application adds entries to the **Start** menu and the **Add or Remove Programs** dialog box; the user is able to run the application when they are not connected.

The `Install Mode` can be set on the **Publish** page of the **Project Designer**.

> [!NOTE]
> The `Install Mode` can also be set using the Publish wizard. For more information, see [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

### To make a ClickOnce application available online only

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. In the **Install Mode and Settings** area, click the **The application is available online only** option button.

### To make a ClickOnce application available online or offline

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. In the **Install Mode and Settings** area, click the **The application is available offline as well** option button.

     When installed, the application adds entries to the **Start** menu and to **Add or Remove Programs** in Control Panel.

## See also
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)
- [Choose a ClickOnce deployment strategy](../deployment/choosing-a-clickonce-deployment-strategy.md)