---
title: What Happens When Your Subscription is Removed?
author: joseb-rdc
ms.author: amast
manager: shve
ms.date: 04/28/2025
ms.topic: troubleshooting
description: Understand what happens when an admin removes a Visual Studio subscription, including changes to benefits and available resources.
---

# What happens when your Visual Studio subscription is removed?

If an admin in your work or school organization assigned your Visual Studio subscription to you, they might remove the subscription at some point. Reasons can include changes to job roles or to your organization's purchase plans. This article outlines what you can expect if an admin removes your subscription.

> [!TIP]
> If your admin removes your subscription, they might be planning to issue you a different subscription. If you receive a notification that your subscription is removed, you might want to ask your admin if another subscription is available. In the [subscription portal](https://my.visualstudio.com), select the **Contact my admin** button.

This article also provides information for admins about why Microsoft might remove subscriptions and what happens after removal.

## Changes to benefits after subscription removal

After an admin removes your subscription, the changes for a specific benefit depend on the benefit itself. The following sections describe some examples and steps for making sure that you have access to things like your Azure assets.

### Visual Studio IDE

The license for the Visual Studio integrated development environment (IDE) is dependent on a subscription that's assigned to you. If your subscription is removed, you lose access to any version of the IDE provided in a paid subscription. If you still need Visual Studio, consider installing the free version: [Visual Studio Code](https://code.visualstudio.com/).

To learn about the differences between the editions included in your subscription, see the [Compare Visual Studio Editions](https://visualstudio.microsoft.com/vs/compare/) page.

### Individual Azure credits

When your subscription is removed, you no longer accrue individual Azure credits. The credits that you accrued remain available for 30 days. After that time, your assets are unavailable.

To avoid losing your assets, make sure to take one of the following steps if your subscription is removed:

+ Convert the subscription to pay-as-you-go pricing. For details, see the [Pay-As-You-Go Dev/Test](https://azure.microsoft.com/offers/ms-azr-0023p/) page. You need to attach a payment instrument such as a credit card to this subscription.
+ Move your assets to another Azure subscription if one is available to you. For example, you might have an Azure subscription as part of a different Visual Studio subscription. For more information, see [Change directory tenants with your Azure subscriptions](/azure/devtest/offer/how-to-change-directory-tenants-visual-studio-azure).

### Software downloads and product keys

Access to software downloads and product keys from the subscription portal is lost.

### Azure DevOps

Access to Azure DevOps requires a license and is lost.

### Other benefits

The effects of a subscription removal vary:

+ **Benefits that have a fixed length**: Many of the benefits provided by Microsoft partners are offers that have a fixed length of time. If you activated them before the removal of your subscription, many of them are unaffected and remain available to you until the end of their normal term.

  If you've been accessing those benefits through the subscription portal, you need to access them directly on the partner site. For example, let's say you received a Pluralsight subscription as part of a Visual Studio subscription. When your Visual Studio subscription is removed, you still have any remaining time on the training subscription, but you need to sign in to Pluralsight's website directly.

+ **Benefits that require sign-in for each use**: These benefits are no longer available.

Upon removal of your subscription, you lose the ability to activate any more benefits.

## Microsoft deletion of Visual Studio subscription assignments

If you're a subscription admin, you might occasionally see in your dashboard that Microsoft removed a subscription. The reason states that the account is closed.

### Why an account might be removed  

+ **Subscribers request closure of their Microsoft accounts**. If a subscriber requests closure of a Microsoft account, subscriptions associated with that account are removed. For more information, including important considerations before you close an account, see [How to close your Microsoft account](https://support.microsoft.com/account-billing/how-to-close-your-microsoft-account-c1b2d13f-4de6-6e1b-4a31-d9d668849979).
+ **Subscribers are removed from the Microsoft Entra tenant**. Admins can automatically assign subscriptions through a Microsoft Entra group. When subscribers are removed from the group, their subscriptions are removed.

### What happens when an account is closed

If a subscription is removed, the subscriber loses access to the subscription. If a subscriber is removed from a Microsoft Entra group, their subscription information is permanently removed within 180 days. If a subscriber closes their Microsoft account, their information is removed immediately.

### Anonymization of Visual Studio subscriber information

When an event blocks a subscriber's use of a subscription, personal information (such as name and sign-in account) is scrambled to render it unusable. This *anonymization* helps safeguard the subscriber's personal information.

[!INCLUDE [GDPR-related guidance](includes/gdpr-intro-sentence.md)]

How quickly anonymization occurs depends on the type of subscription and the triggering event.

| Subscription type | Event that triggers anonymization | When anonymization occurs |
| ----------------- | ------------------------------ | ---------------- |
| Visual Studio Dev Essentials | The subscriber opts out of the program or doesn't accept the terms of use. | 30 days |
| Visual Studio subscriptions purchased  through the Microsoft Store (retail) | The subscription expires or isn't activated. | 360 days |
| Visual Studio subscriptions acquired through volume license, Visual Studio Marketplace (cloud subscriptions), or programs such as the Microsoft AI Cloud Partner Program | The subscription expires or isn't assigned to a user. | 180 days |
| All subscriptions | A Microsoft Entra account or a Microsoft account that's used to sign in to the subscription is closed. | Immediately |
| All subscriptions | A subscriber is removed from the tenant that's associated with the Microsoft Entra account. | Immediately |

## Support resources

+ For assistance with sales, accounts, and billing for Visual Studio subscriptions, go to the [Get Help](https://my.visualstudio.com/gethelp) page of the subscription portal.
+ For assistance or questions about the Visual Studio IDE, Azure DevOps, or other Visual Studio products or services, go to the Visual Studio [Support](https://visualstudio.microsoft.com/support/) page.

## Related content

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)
