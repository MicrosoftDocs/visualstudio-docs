---
title: "Customize default web page for ClickOnce application"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "Publish.htm Web page"
  - "ClickOnce deployment default Web page"
  - "deploying applications [ClickOnce], publishing"
  - "publishing, ClickOnce"
ms.assetid: 418de18c-bee9-4f24-9cd9-0252d175070d
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Customize the default Web page for a ClickOnce application
When publishing a ClickOnce application to the Web, a Web page is automatically generated and published along with the application. The default page contains the name of the application and links to install the application, install prerequisites, or access help on MSDN.

> [!NOTE]
> The actual links that you see on the page depend on the computer where the page is being viewed and what prerequisites you are including.

 The default name for the Web page is *Publish.htm*; you can change the name in the **Project Designer**. For more information, see [How to: Specify a publish page for a ClickOnce application](../deployment/how-to-specify-a-publish-page-for-a-clickonce-application.md).

 The *Publish.htm* Web page is published only if a newer version is detected.

> [!NOTE]
> Changes that you make to your **Publish** settings will not affect the *Publish.htm* page, with one exception: if you add or remove prerequisites after initially publishing, the list of prerequisites will no longer be accurate. You will need to edit the text for the prerequisite link to reflect the changes.

### To customize the publish Web page

1. Publish your ClickOnce application to a Web location. For more information, see [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md).

2. On the Web server, open the *Publish.htm* file in Visual Web Designer or another HTML editor.

3. Customize the page as desired and save it.

4. Optional. To prevent Visual Studio from overwriting your customized publish Web page, uncheck **Automatically generate deployment Web page after every publish** in the **Publish Options** dialog box.

## See also
- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
- [Publishing ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Install prerequisites with a ClickOnce application](../deployment/how-to-install-prerequisites-with-a-clickonce-application.md)
- [How to: Specify a publish page for a ClickOnce application](../deployment/how-to-specify-a-publish-page-for-a-clickonce-application.md)