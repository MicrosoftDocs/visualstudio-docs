---
title: Internet demos via Terminal Services in Visual Studio subscriptions| Microsoft Docs
author: joseb-rdc
ms.author: amast
manager: shve
ms.date: 09/16/2024
ms.topic: article
description: Learn how to use product keys to support internet demonstrations via Terminal Services and enable RDS access.
---

# Internet demonstrations via Terminal Services

With a Visual Studio subscription, you can provide end users access to Internet demonstrations of your programs. You can use either Terminal Services (TS) in Windows Server 2003 or Windows Server 2008 or Remote Desktop Services (RDS) in Windows Server 2008 R2 and later. Up to 200 anonymous users can simultaneously access your demonstration this way. Your demonstration must not use production data. Visual Studio subscribers are licensed to demonstrate their applications to end users. Running internet demonstrations using TS or RDS is the only scenario where end users without a Visual Studio subscription can interact with the demonstration application when the software is licensed through Visual Studio subscriptions.

This permission is in addition to dev/test rights, where Visual Studio subscribers can use as many RDS or TS connections as needed.

## Enabling RDS Access

Visual Studio subscribers can increase the number of users who can access a Windows Server via RDS by entering a product key supplied in the [Product Keys](https://my.visualstudio.com/productkeys?wt.mc_id=o~msft~docs) tab on the [subscription portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs). To obtain a product key, connect to the Product Keys page and scroll down to the version of Windows Server you're running. Locate “Windows Server < version > R2 Remote Desktop Services < user or device > connections” and select the **Claim Key** link. For example, if you’re using RDS on Windows Server 2012 R2 and your deployment uses user Client Access Licenses (CALs), choose “Windows Server 2012 Remote Desktop Services user connections (50).”
Five keys of each type are available for Windows Server 2008 R2, and each key supports 20 connections. For Windows Server 2012 R2, four keys for each type are provide and support 50 connections each.

## To enable more connections in Windows Server

1. Open Server Manager.
2. Open the Servers list in the left nav pane.
3. Right select your license server and choose “Install Licenses.”
4. Follow the steps in the wizard. When you’re selecting the agreement type, choose “License Pack (retail)” and enter the product key you obtained from the MY portal.

End users can connect to access applications via RDS if the following conditions are met:
+ Users must be anonymous (in a nonauthenticated state).
+ Connections must be over the Internet.
+ Up to 200 concurrent user connections can be used for demonstrations of the application.
+ A Visual Studio subscriber must obtain the keys to enable user connections.

## Support resources

For assistance with sales, subscriptions, accounts, and billing for Visual Studio Subscriptions, contact [Visual Studio subscriptions support](https://aka.ms/vssubscriberhelp).

## See also

+ [Windows Server documentation](/windows-server/)
+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)

## Next steps

If you need guidance for deploying RDS, check out the multi-part blog series on **Remote Desktop Services (RDS) 2012 session deployment** at https://techcommunity.microsoft.com/t5/Ask-The-Performance-Team/bg-p/AskPerf. 

If you have any questions, visit the [Microsoft Remote Desktop Services forum](https://social.technet.microsoft.com/Forums/windowsserver/home?forum=winserverTS).
