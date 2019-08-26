---
title: "How to: Unlock Visual Studio"
titleSuffix: ""
ms.date: 03/30/2019
ms.topic: conceptual
ms.assetid: ffb580a1-8b5d-48f5-b811-87f8036f50ea
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
---
# How to: Unlock Visual Studio

You can evaluate Visual Studio for free up to 30 days. Signing into the IDE extends the trial period to 90 days. To continue using Visual Studio, unlock the IDE by either:

- using an online subscription

- entering a product key

## To unlock Visual Studio using an online subscription

To unlock Visual Studio using a Visual Studio subscription or an Azure DevOps organization associated with a Microsoft account, or a work or school account:

1. Choose the **Sign in** button in the upper-right corner of the IDE (or go to **File** > **Account Settings** to open the **Account Settings** dialog and choose the **Sign in** button).

1. Enter the credentials for either a Microsoft account or a work or school account. Visual Studio finds a Visual Studio subscription or an Azure DevOps organization associated with your account.

> [!IMPORTANT]
> Visual Studio automatically looks for associated online subscriptions when you connect to an Azure DevOps organization from the **Team Explorer** tool window. When you connect to an Azure DevOps organization, you can sign in using both Microsoft and work or school accounts. If an online subscription exists for that user account, Visual Studio will automatically unlock the IDE for you.

## To unlock Visual Studio with a product key

1. Select **File** > **Account Settings** to open the **Account Settings** dialog, and then choose the **License with a Product Key** link.

1. Enter the product key in the space provided.

> [!TIP]
> Pre-release versions of Visual Studio do not have product keys. You must sign in to the IDE to use pre-release versions.

## Address license problem states

### Update stale licenses

You might have seen the following message that says that your license is going stale in Visual Studio. It reads, "Your license has gone stale and must be updated."

![Visual Studio stale license message](../ide/media/vs2017_stale-license.png)

This message indicates that while your subscription may still be valid, the license token Visual Studio uses to keep your subscription up to date hasn't been refreshed and has gone stale due to one of the following reasons:

- You have not used Visual Studio or have had no internet connection for an extended period of time.
- You signed out of Visual Studio.

Before the license token goes stale, Visual Studio first shows a warning message that asks you to reenter your credentials.

If you do not reenter your credentials, the token starts to go stale and the **Account Settings** dialog tells you how many days you have left before your token will fully expire. After your token expires, you must reenter your credentials for the account before you can continue using Visual Studio.

> [!Important]
> If you are using Visual Studio for extended periods in environments with limited or no internet access, you should use a product key to unlock Visual Studio to avoid interruption.

### Update expired licenses

If your subscription has expired completely and you no longer have access rights to Visual Studio, you must renew your subscription or add another account that has a subscription. To see more information about the license you are using, go to **File** > **Account Settings** and look at the license information on the right side of the dialog. If you have another subscription associated with a different account, add that account to the **All Accounts** list on the left side of the dialog box by selecting the **Add an account** link.

## See also

* [Sign in to Visual Studio](../ide/signing-in-to-visual-studio.md)
