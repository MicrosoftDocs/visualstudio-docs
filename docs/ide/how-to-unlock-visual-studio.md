---
title: Extend a Trial Version or Update a License
description: Learn how to extend a free trial of Visual Studio, use an online subscription or product key to unlock Visual Studio, and update a stale or expired license.
ms.date: 08/08/2025
ms.topic: how-to
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a Visual Studio user, I want to learn about extending a trial version, using an online subscription or product key to unlock Visual Studio, or updating a stale or expired license. 
---

# Extend a trial version or update a license

This article describes how to extend a free trial of Visual Studio, use an online subscription or product key to unlock Visual Studio, and update a stale or expired license.

You can evaluate a free trial of [Visual Studio Professional or Visual Studio Enterprise](https://visualstudio.microsoft.com/vs/compare/) for 30 days. If you sign in, you can extend the trial period to 90 days. The 90-day trial extension works only one time. (Visual Studio Community doesn't require you to sign in. However, if the installation prompts you to sign in periodically, [sign in](signing-in-to-visual-studio.md) to continue using Visual Studio Community without interruptions.)

To continue using Visual Studio after a trial period ends, unlock it with an [online subscription](#use-an-online-subscription) or a [product key](#enter-a-product-key).

## Use an online subscription

1. Select the **Sign in** button in the upper-right corner of the IDE. (Or go to **File** > **Account Settings** to open the **Account Settings** dialog, and then select **Sign in**).

1. Enter the credentials for a [Microsoft account, a work or school account, or a GitHub account](signing-in-to-visual-studio.md). Visual Studio finds a Visual Studio subscription or an Azure DevOps organization that's associated with your account.

> [!IMPORTANT]
> Visual Studio automatically looks for associated online subscriptions when you connect to an Azure DevOps organization from the **Team Explorer** window. When you connect to an Azure DevOps organization, you can use both Microsoft and work or school accounts to sign in. If an online subscription exists for that user account, Visual Studio automatically unlocks the IDE.

For more information about Visual Studio subscriptions and how they work, see the [subscriptions support FAQ](https://visualstudio.microsoft.com/subscriptions/support/) page.

## Enter a product key

1. Select **File** > **Account Settings** to open the **Account Settings** dialog, and then select the **License with a Product Key** link.

1. Enter the product key in the space provided.

> [!TIP]
> Prerelease versions of Visual Studio don't have product keys. You must sign in to the IDE to use prerelease versions.

For more information about product keys for Visual Studio and how to get them, see [Using product keys in Visual Studio subscriptions](/visualstudio/subscriptions/product-keys).

## Update a stale license

You might see a message in Visual Studio that says, "Your license has gone stale and must be updated."

:::image type="content" source="../ide/media/vs2017_stale-license.png" alt-text="Screenshot of the Visual Studio stale license message." border="false":::

This message indicates that, although your subscription might still be valid, the license token that Visual Studio uses to keep your subscription up to date hasn't been refreshed. Visual Studio reports that the license is stale for one of the following reasons:

* You haven't used Visual Studio or you haven't connected to the internet for an extended period of time.
* You signed out of Visual Studio.

Before the license token goes stale, Visual Studio first shows a warning message that asks you to re-enter your credentials.

If you don't re-enter your credentials, the token will eventually expire, and the **Account Settings** dialog will specify the number of days remaining before your token becomes stale. After your token expires, you must re-enter your credentials for the account before you can continue using Visual Studio.

Note that CA policies that are enabled on an account might affect the account state or license. You can [troubleshoot the CA/MFA issues](work-with-multi-factor-authentication.md#troubleshoot-sign-in-issues) to find a resolution. For accounts that are associated with multiple Microsoft Entra ID tenants, [filtering out nonessential tenants](work-with-multi-factor-authentication.md#how-to-filter-out-individual-tenants) might help. You can do that by using the **Filter account** dialog (**File > Account Settings > ellipsis button (...) > Apply filter**). When [re-authenticating an account](work-with-multi-factor-authentication.md#reauthenticating-an-account), you can also filter out any directories that have access issues by using the **Re-enter your credentials** dialog.

>[!Important]
>If you use Visual Studio for extended periods in environments that have limited or no internet access, you should use a product key to unlock Visual Studio to avoid interruption.

## Update an expired license

If your extended trial or subscription is expired and you no longer have access rights to Visual Studio, you must renew your subscription, add another account that has a subscription, or enter a product key. For information about the license you're using, go to **File** > **Account Settings** and review the license information on the right side of the dialog. 

:::image type="content" source="media/vs-2022/expired-license-account-settings-dialog.png" alt-text="Screenshot of an expired license notification in Visual Studio." border="false":::

If you have another subscription that's associated with a different account, [add that account](signing-in-to-visual-studio.md#add-and-switch-user-accounts-in-visual-studio) to the **All Accounts** list on the left side of the dialog box by selecting **+Add**.

You can also enter the [product key for your Visual Studio subscription](/visualstudio/subscriptions/product-keys) in the **Account Settings** dialog. To do that, select **Unlock with a Product Key** and enter the product key in the **Enter a product key** dialog.

:::image type="content" source="media/vs-2022/expired-license-enter-product-key.png" alt-text="Screenshot of the Enter a product key dialog.":::

## Get support

Things sometimes go wrong. If you experience a problem, here are some support options:

* [Report product issues](how-to-report-a-problem-with-visual-studio.md).
* Find answers to questions about subscriptions, accounts, and billing in the [subscriptions support FAQ](https://visualstudio.microsoft.com/subscriptions/support/).

## Related content

* [Sign in to Visual Studio](../ide/signing-in-to-visual-studio.md)
* [Compare Visual Studio editions](https://visualstudio.microsoft.com/vs/compare/)
* [Learn more about Visual Studio subscriptions](/visualstudio/subscriptions/)
