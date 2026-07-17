---
title: Internet demos via Remote Desktop Services in Visual Studio Subscriptions| Microsoft Docs
author: joseb-rdc
ms.author: amast
ms.manager: shve
ms.date: 07/16/2026
ms.topic: how-to
description: Learn how to use product keys to support internet demonstrations via Remote Desktop Services.
---

# Internet demonstrations through Remote Desktop Services

With a Visual Studio Subscription, you can give end users access to internet demonstrations of your applications. Host demonstrations by using Remote Desktop Services (RDS). Earlier versions of Windows Server referred to this capability as Terminal Services (TS). Up to 200 anonymous users can simultaneously access your demonstration. Demonstrations must not use production data.

Visual Studio subscribers are licensed to demonstrate their applications to end users. Running internet demonstrations by using RDS or TS is the only scenario where end users without a Visual Studio Subscription can interact with an application licensed through Visual Studio Subscriptions.

This permission is in addition to dev/test rights, where Visual Studio subscribers can use as many RDS or TS connections as needed.

## Enabling RDS Access

Visual Studio subscribers can increase the number of users who can access a Windows Server through RDS by getting a Remote Desktop Services connection key from the [Product Keys](https://my.visualstudio.com/productkeys?wt.mc_id=o~msft~docs) page in the [Visual Studio Subscriptions portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs).

To get a product key, go to the Product Keys page and browse to the version of Windows Server you're using. Find the Remote Desktop Services user connections or device connections key that matches your Windows Server version and licensing model, and then select the **blue key** icon to claim the key.

For example, if you're using RDS on Windows Server 2012 R2 and your deployment uses user Client Access Licenses (CALs), choose **Windows Server 2012 Remote Desktop Services user connections (50).**

Five keys of each type are available for Windows Server 2008 R2, and each key supports 20 connections. For Windows Server 2012 R2 and later versions, four keys for each type are provided and support 50 connections each.

## To enable more connections in Windows Server

1. Open Server Manager.
1. Open the Servers list in the left navigation pane.
1. Right-click your license server and choose **Install Licenses**.
1. Follow the steps in the wizard.
1. When you select the agreement type, choose **License Pack (Retail)** and enter the product key you got from the Visual Studio Subscriptions portal.

End users can access applications through RDS if all the following conditions are met:
+ Users must be anonymous (in a nonauthenticated state).
+ Connections must be over the internet.
+ Up to 200 concurrent user connections can be used for demonstrations of the application.
+ A Visual Studio subscriber must obtain the keys to enable user connections.

## Support resources

For assistance with sales, subscriptions, accounts, and billing for Visual Studio Subscriptions, contact [Visual Studio Subscriptions support](https://aka.ms/vssubscriberhelp).

## See also

+ [Windows Server documentation](/windows-server/)
+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)

## Next steps

+ [Learn more about Remote Desktop Services (RDS) in Windows Server](https://learn.microsoft.com/windows-server/remote/remote-desktop-services/)
+ [Review Remote Desktop Services (RDS) client access license (CAL) requirements](https://learn.microsoft.com/windows-server/remote/remote-desktop-services/rds-client-access-license)
+ [Learn how to install Remote Desktop Services (RDS) client access licenses](https://learn.microsoft.com/windows-server/remote/remote-desktop-services/rds-install-cals)
