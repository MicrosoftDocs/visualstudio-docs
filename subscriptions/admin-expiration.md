---
title: What happens when Visual Studio Subscription agreements expire
author: joseb-rdc
ms.author: amast
ms.manager: shve
ms.date: 06/22/2026
ms.topic: concept-article
description: Understand what happens when a Visual Studio Subscriptions agreement expires, including lifecycle stages, access changes, and actions admins might need to take.
---

# What happens when Visual Studio Subscription agreements expire

When the agreement used to purchase Visual Studio Subscriptions expires, the agreement and the subscriptions assigned within it remain available for a limited time. That period might not be the same for all agreements. You receive more specific information about the length of that period in communications by email and in the admin portal. This article applies to Visual Studio Subscriptions purchased through Volume Licensing programs (specifically Enterprise Agreement and Campus Agreement) and managed in the Visual Studio Subscriptions admin portal.

## Expiration lifecycle

Agreements that include Visual Studio Subscriptions have a defined end date. As that date approaches, your organization can choose to renew the agreement or replace it with a new one. If you don't renew or replace the agreement, it moves through several lifecycle states that affect how subscriptions are managed and accessed. 

The lifecycle consists of three phases:

### Before expiration

Starting about 120 days before the expiration of your agreement, admins and super admins receive notifications with information about the expiration. The notifications include steps you might need to take depending on whether your company plans to renew its agreement.

### Expired

When your agreement reaches its expiration date, it enters an expired state. During this period, admins and subscribers continue to have access for a limited time.

This period provides an opportunity for your organization to:
+ Complete ongoing purchasing processes.
+ Take steps to preserve data if your agreement isn't renewed or replaced.

Admins and subscribers continue to receive notifications during this phase, including: 
+ Links to specific information to help preserve data such as subscriber lists for future use.
+ Notifications for subscribers providing guidance on preserving resources, such as assets in existing Azure subscriptions.

During the expired phase:
+ Both admins and subscribers continue to have access to their respective portals.
+ Admins carry out the full range of subscription management tasks.
+ Subscribers continue to have unrestricted access to their subscription benefits.

> [!IMPORTANT]
> While admins and subscribers will continue to have access to their respective resources, it's important that action be taken quickly so that important data is preserved before this period expires and access to the information is lost.

### Disabled

When the expired period ends, the agreement becomes disabled.

At this point:
+ Admins and super admins:
  + Lose access to expired agreements in the [admin portal](https://manage.visualstudio.com).
  + Can't make changes to subscriptions within that agreement.
  + Access to any other current agreements in the admin portal remains unaffected.
+ Subscribers:
  + Lose access to the subscription associated with the expired agreement.
  + Continue to have access to subscriptions assigned to them as part of another agreement.
+ Azure subscriptions:
  + Thirty days after a Visual Studio Subscription is disabled, any Azure subscriptions that rely on the Visual Studio Subscription are removed.
  + Subscribers must move Azure assets to another active subscription to retain them.

Access to the [Get help](https://manage.visualstudio.com/gethelp) page continues to be available in the admin portal. 

## Preserving your information

You might need to retain certain information to support planning and transition activities if your agreement expires or you purchase a new agreement. 
+ Maximum usage. Understanding how many subscriptions you assigned during the life of your agreement can help your organization purchase the right number of subscriptions for your needs. You can [view your usage and export a report](maximum-usage.md) from within the admin portal. 
+ Your subscriber list. [Exporting a list of the subscribers](exporting-subscriptions.md) in your current agreement can help you move those subscriptions to a new agreement quickly. 

## Assisting subscribers

As your agreement approaches expiration, subscribers might also receive notifications about upcoming changes to their subscriptions and benefits or associated resources such as Azure. These changes might prompt questions about how their access, benefits, or resources are affected.

The answers to those questions depend on your organization's plans. If your organization intends to renew its agreement or replace it with a new one, you can help subscribers understand what to expect and when their access will continue or change. If the agreement won't be renewed, you can guide them to take steps to preserve their data and resources before access is removed.

Subscribers should also be aware that some benefits continue for a limited time after expiration, while others depend on an active subscription and might no longer be available. For details about how expiration affects downloads, product keys, and benefits, see [When subscriptions expire](subscription-expiration.md).

Subscribers who use Azure might need to transfer resources to another subscription or take steps to maintain access before their subscription is disabled. For guidance, see [Renew an expired subscription, purchase a new one, or transfer your Azure resources](https://learn.microsoft.com/azure/devtest/offer/troubleshoot-expired-removed-subscription). 

## Moving to a new agreement

If your organization purchases a new agreement, you might need to move existing Visual Studio Subscriptions to that agreement to maintain access and continue managing subscriptions. For detailed instructions, see [Migrate subscriptions](migrate-subscriptions.md).

## Next steps

+ Learn how expired agreements affect [individual subscribers](subscription-expiration.md).
+ Learn how to [export your subscriber list](exporting-subscriptions.md).
+ Learn how to [move subscriptions to a new agreement](migrate-subscriptions.md).
+ Learn how to [add subscribers using Microsoft Entra groups](assign-license-bulk.md#use-entra-id-groups-to-assign-subscriptions).
