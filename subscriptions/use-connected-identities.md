---
title: Use connected identities in subscriptions
author: joseb-rdc
ms.author: amast
manager: shve
ms.date: 11/19/2025
ms.topic: how-to
robots: "noindex, nofollow"
description: Work with connected identities such as Microsoft accounts and Microsoft Entra ID identities in Visual Studio subscriptions.
---

# Use connected identities in Visual Studio subscriptions

If you receive a Visual Studio subscription through your work or school, and you use your Microsoft account (MSA) to sign in, your subscriptions admin can connect your MSA to your identity in your organization's Microsoft Entra ID. This connection changes how you access some of the benefits included in your subscription. 

## About connected IDs

Organizations are increasingly moving to Microsoft Entra ID-based identities to provide improved security and support for automated management of subscriptions. If your subscription uses an MSA such as an @outlook.com or other personal email address, your admin can change your sign-in email to your Microsoft Entra identity. Switching changes how you sign in to the subscription portal at https://my.visualstudio.com. It might not change how you access all of your benefits, however. 

If your admin connects your MSA and Microsoft Entra identities, you receive an email letting you know to start accessing your Visual Studio subscription with your Microsoft Entra identity instead of your MSA. 

<a name='how-to-access-benefits-using-microsoft-entra-id-identities'></a>

## How to access benefits using Microsoft Entra identities

After your admin connects your MSA to your Microsoft Entra identity, sign in to the [subscription portal](https://my.visualstudio.com) with your Microsoft Entra identity to access benefits that rely on Microsoft Entra ID. These benefits include:
+ Visual Studio IDE
+ Azure DevOps
+ Azure DevTest individual credit

## How to access benefits using your MSA

For many of the benefits offered in Visual Studio subscriptions such as Pluralsight, Cloud Academy, CloudPilot, and others, you actually create user accounts on the partners' web sites. For those accounts, you should continue to use the identity you used when you created the account. For example, if you activated your Pluralsight benefit using your MSA, you should continue to use your MSA when taking Pluralsight training. 

## Use an alternate identity to access your subscription

Adding an alternate account to your Visual Studio subscription allows you to access the subscription benefits with a different identity than the one to which the subscription is assigned. In the past, this functionality was available only if your Visual Studio subscription was assigned to a Microsoft Account (MSA). We extended this functionality for work or school accounts in Microsoft Entra ID. 

### Why add an alternate account to your subscription

Adding an alternate account to your Visual Studio subscription allows you to access certain subscription benefits with a different identity than that to which the subscription is assigned. These benefits include things like Azure DevOps and Azure, and the Visual Studio IDE. In the past, this option was possible only if your Visual Studio subscription used a Microsoft Account (MSA). We extended this functionality for work or school accounts in Microsoft Entra ID.

> [!NOTE]
> An alternate ID only allows you to use that second ID to activate Azure credits and Azure DevOps, and to sign in to the Visual Studio IDE. It can't be used to sign in to the subscription portal at <https://my.visualstudio.com>. You still need to use the ID to which the subscription is assigned to sign in to the portal. 

### Add the alternate account

1. Sign in to the Visual Studio subscription portal with your Microsoft account (https://my.visualstudio.com).
2. Select the **Subscriptions** tab.
3. Choose **Add alternate account**.
4. Add your work or school account.
5. Use your work or school account to sign in to Azure DevOps.

Your alternate account is added to the Visual Studio subscription, allowing both identities to utilize the benefits of the subscription that require you to sign in with the alternate account (IDE, Azure DevOps, and Azure).

## FAQ

### Q: Why doesn't Azure DevOps recognize me as a Visual Studio subscriber?

A: Azure DevOps should automatically recognize your subscription when you sign in using your primary or alternate identity. If not, you can try a few things:
+ Check that you have an active Visual Studio subscription that includes [Azure DevOps](vs-azure-devops.md#eligibility) as a benefit.
+ Confirm that you're using a login/identity that is either the primary or alternate identity for your Visual Studio subscription. Many people, for example, also have a Visual Studio Dev Essentials membership associated with a different sign-in ID. Attempting to sign in to other subscriptions with that ID fails unless those subscriptions are associated with that email address.
+ Visit the [Visual Studio subscription portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs) at least once before you sign in to Azure DevOps.

If Azure DevOps still doesn't recognize your subscription, contact [Azure DevOps support](https://azure.microsoft.com/support/devops/).

### Q: How can I contact my admin about alternate IDs?

A: Look for the "Contact my admin" button at the top right in the subscription portal. For more information, see our [Contact your subscriptions admin](contact-my-admin.md) article. 

### Q: I'm an admin. How do I use alternate IDs?

A: Implementing connected identities is simple. Check out [this article](personal-email-sign-ins.md) for more information. 

## Resources

For assistance with sales, subscriptions, accounts, and billing for Visual Studio Subscriptions, see Visual Studio [Subscriptions support](https://aka.ms/vssubscriberhelp).

## See also

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)

## Next steps

After your admin connects your Microsoft Entra ID and MSA accounts, we recommend verifying that you can successfully sign in to the [subscription portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs). Make sure you can access benefits like Azure DevOps, Visual Studio, and your Azure DevTest individual credit.
