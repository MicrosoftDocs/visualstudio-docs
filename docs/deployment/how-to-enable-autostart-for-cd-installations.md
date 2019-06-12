---
title: "How to: Enable AutoStart for CD Installations | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "ClickOnce deployment, AutoStart"
  - "ClickOnce deployment, installation on CD or DVD"
  - "deploying applications [ClickOnce], installation on CD or DVD"
ms.assetid: caaec619-900c-4790-90e3-8c91f5347635
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Enable AutoStart for CD installations
When deploying a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application by means of removable media such as CD-ROM or DVD-ROM, you can enable `AutoStart` so that the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application is automatically launched when the media is inserted.

 `AutoStart` can be enabled on the **Publish** page of the **Project Designer**.

### To enable AutoStart

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Click the **Publish** tab.

3. Click the **Options** button.

     The **Publish Options** dialog box appears.

4. Click **Deployment**.

5. Select the **For CD installations, automatically start Setup when CD is inserted** check box.

     An *Autorun.inf* file will be copied to the publish location when the application is published.

## See also
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)