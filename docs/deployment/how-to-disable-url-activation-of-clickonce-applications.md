---
title: Disable URL Activation of ClickOnce apps
description: Learn how to disable automatic start on install for your ClickOnce application, in case you want users to start the application from the Start menu.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - disallowUrlActivation
  - URL activation, ClickOnce applications
  - ClickOnce deployment, URL activation
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Disable URL activation of ClickOnce applications

Typically, a ClickOnce application will launch automatically immediately after it is installed from a Web server. For security reasons, you may decide to disable this behavior, and tell users to launch the application from the **Start** menu instead. The following procedure describes how to disable URL activation.

This technique can be used only for ClickOnce applications installed on the user's computer from a Web server. It cannot be used for online-only applications, which can be launched only by using their URL. For more information on the difference between online-only and installed applications, see [Choosing a ClickOnce Deployment Strategy](../deployment/choosing-a-clickonce-deployment-strategy.md).

This procedure uses the Windows Software Development Kit (SDK) tool MageUI.exe. For more information on this tool, see [MageUI.exe (Manifest Generation and Editing Tool, Graphical Client)](/dotnet/framework/tools/mageui-exe-manifest-generation-and-editing-tool-graphical-client). You can also perform this procedure using Visual Studio.

## Procedure

### To disable URL activation for your application

1. Open your deployment manifest in MageUI.exe. If you have not yet created one, follow the steps in [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md).

2. Select the **Deployment Options** tab.

3. Clear the **Automatically run application after installing** check box.

4. Save and sign the manifest.

## Related content

- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)