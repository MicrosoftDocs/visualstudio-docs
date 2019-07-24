---
title: Handle over-claimed licenses | Microsoft Docs
author: evanwindom
ms.author: jaunger
manager: evelynp
ms.date: 02/13/2018
ms.topic: conceptual
description:  Learn how administrators can resolve over-claimed subscriptions
---

# Overallocated subscriptions

Sometimes orders are changed after subscribers have been added, which can result in having more assigned subscriptions than licenses owned by your company. When this happens, the Subscribers tab shows an alert and provides you with further information.

> [!NOTE]
> Overclaimed scenarios are not allowed in Open License programs.  Also, other programs may display this information in the portal differently.
>
> [!div class="mx-imgBorder"]
> ![Notice of Over-claimed Subscriptions](_img/over-claimed/over-claimed-alert.png)

## Resolving overallocated subscriptions

To resolve overallocated licenses:

1. Click the alert text. This will display a filtered list of the subscribers that are assigned to the subscription level and expiration date that is over-claimed. 

2. Remove subscribers as needed to rectify the over-claimed licenses. 

3. The overview on the left side of the page will update to show that you are once again in compliance, and all over-claimed notifications will disappear. 

## Billing and true-up

If your organization has an Enterprise Agreement (EA), admins are able to assign subscriptions without purchasing them, and pay for them later through a reconciliation process known as a "true-up".  When you overallocate, your organization will be billed for the maximum number of subscriptions assigned to users during the "true-up".  This is true even if you no longer have the maximum number of subscriptions assigned at the time the true-up takes place.  To learn more about monitoring your maximum usage, visit the [Maximum Usage](maximum-usage.md) topic.

> [!Important]
> If Visual Studio Subscriptions with GitHub Enterprise are assigned by Visual Studio subscription admins and there has never been a purchase of those subscriptions, they will not be visible to GitHub Enterprise admins within the organization. To ensure GitHub Enterprise subscriptions are visible, a purchase including **at least one** Visual Studio Professional with GitHub Enterprise or Visual Studio Enterprise with GitHub Enterprise subscription should be made the first time the subscriptions are assigned.  
>
> It is the customer’s responsibility to ensure that for each GitHub subscription that is assigned there is a corresponding Visual Studio with GitHub subscription assigned in the Manage portal to remain in compliance with the licensing requirements for this subscription.

Learn more about managing [Visual Studio Subscriptions with GitHub Enterprise](assign-github.md).

## Support resources

- For assistance with sales, subscriptions, accounts and billing for Visual Studio Subscriptions, contact Visual Studio [Subscriptions Support](https://visualstudio.microsoft.com/subscriptions/support/).
