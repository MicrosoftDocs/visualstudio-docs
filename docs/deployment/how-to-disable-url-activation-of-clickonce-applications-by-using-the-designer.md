---
title: "Disable URL activation of ClickOnce apps using Designer"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "disallowURLActivation"
  - "URL activation, ClickOnce applications"
  - "ClickOnce deployment, URL activation"
ms.assetid: a337a582-e67c-409a-b52e-607cd1a8fc57
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Disable URL activation of ClickOnce applications by using the Designer
Typically, a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application will start automatically immediately after it is installed from a Web server. For security reasons, you may decide to disable this behavior, and tell users to start the application from the **Start** menu instead. The following procedure describes how to disable URL activation.

 This technique can be used only for [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications installed on the user's computer from a Web server. It cannot be used for online-only applications, which can be started only by using their URL. For more information about the difference between online-only and installed applications, see [Choosing a ClickOnce Deployment Strategy](../deployment/choosing-a-clickonce-deployment-strategy.md).

 This procedure uses [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. You can also accomplish this task by using the [!INCLUDE[winsdklong](../deployment/includes/winsdklong_md.md)]. For more information, see [How to: Disable URL Activation of ClickOnce Applications](../deployment/how-to-disable-url-activation-of-clickonce-applications.md).

## Procedure

#### To disable URL activation for your application

1. Right-click your project name in **Solution Explorer**, and click **Properties**.

2. On the **Properties** page, click the **Publish** tab.

3. Click **Options**.

4. Click **Manifests**.

5. Select the check box labeled **Block application from being activated via a URL**.

6. Deploy your application.

## See also
- [Publishing ClickOnce applications](../deployment/publishing-clickonce-applications.md)