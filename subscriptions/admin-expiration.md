---
title: Admin portal changes for expired Visual Studio subscription agreements | Microsoft Docs
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: f38092ba-051c-4e58-97f5-4255dbe873ba
ms.date: 10/08/2021
ms.topic: conceptual
description: Learn what happens for admins when an agreement expires
---

# Admin portal changes for expired agreements
When the agreement used to purchase Visual Studio subscriptions expires, the agreement and the subscriptions assigned within it will remain available for a limited time.  That period may not be the same for all agreements, and more specific information about the length of that period will be provided in communications you receive via emails and in the admin portal.  Depending on your company's plans, you may need to take some action to assist subscribers or to prevent loss of important information.

## Expiration timeline 
The timeline for agreement expiration consists of three phases:
- [Prior to expiration](#prior-to-expiration)
- [Expired](#expired)
- [Disabled](#disabled)

### Prior to expiration
Beginning about 120 days prior to the expiration of your agreement, we'll begin sending notifications to admins and super admins with information about the expiration as well as steps you may need to take depending on whether your company plans to renew their agreement. 

### Expired
When your agreement reaches its expiration date, admins and subscribers will still have access for a limited time.  This is done to provide an opportunity for your company to complete any ongoing purchasing processes and to provide both admins and subscribers with the opportunity to take appropriate steps to preserve important data in the event your company doesn't renew their agreement or chooses to purchase a new one.  Admins will continue to receive notifications during that period with links to specific information to help preserve information such as subscriber lists for future use.  Subscribers will also begin receiving notifications providing them with guidance around preserving information such as any assets they may have created in existing Azure subscriptions.  

During this phase, both admins and subscribers will continue to have access to their respective portals.  Admins will still be able to carry out the full range of subscription management tasks.  Subscribers will continue to have unrestricted access to their subscription benefits.  

> [!IMPORTANT]
> While admins and subscribers will continue to have access to their respective resources, it's important that action be taken quickly so that important data is preseved before this period expires and access to the information is lost.

### Disabled
When your agreement reaches the end of the expired period:
- Admins and super admins will lose access to the expired agreement(s) in the [admin portal](https://manage.visualstudio.com).  They will not be able to make any changes to subscriptions within the agreement.  (Access to any other current agreements in the admin portal will remain unaffected.  The [Get help](https://manage.visualstudio.com/gethelp) page will also continue to be available.)
- Subscribers will lose access to the expired subscription in the [subscriber portal](https://my.visualstudio.com).  If they have any other subscriptions assigned to them as part of another agreement, those subscriptions will not be affected. Thirty days after a Visual Studio subscription is disabled, any Azure subscriptions that rely on the Visual Studio subscription will also be removed, so it's vital that subscribers move their Azure assets to another valid subscription if they wish to retain them.  Azure has its own notification process that will help guide subscribers in this case.  

## Preserving your information
As an admin, there is some information you may want to retain if your agreement expires or you purchase a new agreement. 
- Maximum usage.  Understanding how many subscriptions you assigned during the life of your agreement can help your organization purchase the right number of subscriptions for your needs.  You can [view your usage and export a report](maximum-usage.md) from within the admin portal.  
- Your subscriber list.  [Exporting a list of the subscribers](exporting-subscriptions.md) in your current agreement can help you move those subscriptions to a new agreement quickly.  

## Assisting subscribers
When they begin to receive notifications of the expiration of their subscriptions, subscribers may contact you with questions.  Some of the answers to those questions will depend on your company's plan, of course.  If your company plans to renew their agreement or purchase a new one, you can help your subscribers understand where your company is in the process.  If your company does not intend to renew, you can help guide them in the process of saving their important information.  You may find it helpful to learn how individual subscribers will be impacted when an agreement expires. Check out our [When subscriptions expire](subscription-expiration.md) article for more information. 

## Moving to a new agreement
If your company purchases a new agreement, you can [move subscribers to a new agreement](migrate-subscriptions.md) rather than recreating them in the new agreement.  

## Next steps
- Learn how [individual subscribers](subscription-expiration.md) are impacted by expired agreements.
- Learn how to [export your subscriber list](exporting-subscriptions.md).
- Learn how to [move subscriptions to a new agreement](migrate-subscriptions.md)
- Learn how to [add subscribers using Azure Active Directory](assign-license-bulk.md#use-azure-active-directory-groups-to-assign-subscriptions) groups.
