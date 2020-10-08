---
title: Unlock Visual Studio 2015 | Microsoft Docs"
titleSuffix: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-general
ms.topic: conceptual
ms.assetid: ffb580a1-8b5d-48f5-b811-87f8036f50ea
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to Unlock Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can evaluate Visual Studio for free up to 30 days. When you sign into the IDE you can extend the trial period by 90 days. To continue using Visual Studio you can unlock the IDE by

1. using an online subscription.

2. entering a product key.

## To Unlock Visual Studio using an online subscription
 To unlock Visual Studio using an MSDN or Visual Studio online subscription associated with a Microsoft account, or a work or school account:

1. Click on the “Sign in” button in the upper right corner of the IDE (or go to File > Account Settings to open the Account Settings dialog and click on the “Sign in” button.)

2. Enter the credentials for either a Microsoft account or a work or school account. Visual Studio will find an MSDN subscription or Visual Studio Team Services subscription associated with your account.

> [!IMPORTANT]
> Visual Studio automatically looks for associated online subscriptions when you connect to a Visual Studio Team Services account from the Team Explorer tool window. When you connect to a Visual Studio Team Services account, you can sign in using both Microsoft and work or school accounts. If an online subscription exists for that user account, Visual Studio will automatically unlock the IDE for you.

## To unlock Visual Studio with a product key

1. Select **File > Account Settings** to open the Account Settings dialog and click on the “**License with a Product Key**” link.

2. Enter the product key in the space provided.

> [!TIP]
> Prerelease versions of Visual Studio do not have product keys. You must sign in to the IDE to use prerelease versions.

## Addressing License Problem States

### Updating stale licenses
 You may have seen the below message that your license is going stale in Visual Studio.

 ![Visual Studio User Information Dialog](../ide/media/vs2013-userinfo.png "VS2013_UserInfo")

 This message indicates that while your subscription may still be valid, the license token Visual Studio uses to keep your subscription up to date hasn’t been refreshed and has gone stale due to one of the following reasons:

1. You have not used Visual Studio or have had no internet connection for an extend period of time.

2. You signed out of Visual Studio.

   Before the license token goes stale, Visual Studio will first show a warning message asking you to re-enter your credentials.

   If you do not reenter your credentials the token starts to go stale. When this happens, the Account Settings dialog tells you how many days you have left before your token will fully expire. After your token expires, you will need to reenter your credentials for this account or license with another method above before you can continue using Visual Studio.

> [!IMPORTANT]
> If you are using Visual Studio for extended periods in environments with limited or no internet access, you should use a product key to unlock Visual Studio in order to avoid interruption.

### Updating Expired Licenses
 If your subscription has expired completely, and you no longer have access rights to Visual Studio, you must:

1. Renew your subscription. To see more information about the license you are using, go to File > Account Settings dialog, and look at the license information on the right side of the dialog.

2. If you have another subscription associated with a different account, add that account to the All Accounts list on the left side of File > Account Settings dialog by clicking on the “Add an account…” link.

## See Also
 [Signing in to Visual Studio](../ide/signing-in-to-visual-studio.md)
