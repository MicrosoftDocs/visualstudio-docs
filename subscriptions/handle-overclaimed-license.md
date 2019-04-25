---
title: Handle over-claimed licenses | Microsoft Docs
author: evanwindom
ms.author: jaunger
manager: evelynp
ms.date: 02/13/2018
ms.topic: conceptual
description:  Learn how administrators can resolve over-claimed subscriptions
searchscope: VS Subscription
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

When your organization purchases Visual Studio subscriptions or Visual Studio with GitHub Enterprise subscriptions through an Enterprise Agreement (EA), admins are able to assign more subscriptions than were included in the purchase.  When you overallocate, your organization will be billed for the maximum number of subscriptions assigned to users during a reconciliation process called a "true-up".  This is true even if you no longer have the maximum number of subscriptions assigned at the time the true-up takes place.  To learn more about monitoring your maximum usage, visit the [Maximum Usage](maximum-usage.md) topic.

## Visual Studio with GitHub Enterprise subscriptions

Because subscription assignments for Visual Studio with GitHub Enterprise subscriptions work differently, there are a couple of unique scenarios to keep in mind:

- If a Visual Studio subscriptions admin assigns more subscriptions than their organization purchased, the organization will be billed for the maximum number of subscriptions assigned during a true-up.  It's not necessary to place a purchase order to assign these subscriptions.  However, if no order is placed, the purchases will not be provisioned or visible to the GitHub Enterprise subscription admin(s).  So, the organization may be billed for subscriptions that the GitHub Enterprise admin(s) didn't know were available.

- If a GitHub Enterprise subscription admin assigns more subscriptions than were purchased, these subscriptions are not automatically included in a true-up, so this may place the organization in a situation of being out of compliance with their license.  To avoid this problem, GitHub Enterprise admins should ensure that an order supporting the additional subscriptions is placed. 

Learn more about managing [Visual Studio with GitHub Enterprise subscriptions](assign-github.md).

## Support resources
-  For assistance with sales, subscriptions, accounts and billing for Visual Studio Subscriptions, contact Visual Studio [Subscriptions Support](https://visualstudio.microsoft.com/subscriptions/support/).