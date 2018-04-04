---
title: How to Resend Subscription Assignment Emails from Within Manage.visualstudio.com or VLSC | Microsoft Docs
author: evanwindom
ms.author: jaunger
manager: evelynp
ms.date: 02/13/2018
ms.topic: Get-Started-Article
description:  Learn how to resend the subscription assignment to subscribers from manage.visualstudio.com or VLSC
ms.prod: vs-subscription
ms.technology: vs-subscriptions
searchscope: VS Subscription
---

# How to resend subscription assignment emails in the Visual Studio subscription management portal

The steps needed to resend an assignment email depend on which portal you're using to manage your subscriptions. 

## Resending assignment emails from within manage.visualstudio.com

The process for resending assignment emails from within the manage.visualstudio.com portal is very simple:

1. Visit the [manage.visualstudio.com](https://manage.visualstudio.com) portal and sign in. 
2. Use the **Filter** tab to search for the subscriber to whom you want to resend the assignment email. (For more information about filtering, please see [Search for a subscription](/visualstudio/subscriptions/search-license).)
3. Click on the subscriber(s).  You can use Ctrl+click or Shift+click to select multiple subscribers.
4. Click **Resend** at the top of the search results.  

## Resending assignment emails from within VLSC
When a subscription has been assigned to a subscriber in VLSC and the subscriber requests the assignment email be resent, you can accomplish it by editing the subscriber’s email information and then changing it back to the original address. This will automatically trigger the resending of the assignment email.

Please follow the below instructions to resend the assignment email:


1. Visit the Volume Licensing Service Center (VLSC) and sign-in.
2. From the VLSC Admin pages, click **Subscriptions** and then **Visual Studio Subscriptions**.
3. Click the **Agreement Number** associated with the Visual Studio Subscription.
4. Click the down arrow on the **Search** bar.  
5. Search for the Subscriber using the Email Address field.
6. From the results list, click the **Last Name** of the Subscriber.
7. Click **Edit**.
8. Make an edit to the subscription. The specific change you make doesn't matter - there just needs to be a change.  For example, remove a character from the subscriber’s email address - remove the “m” from .com. Click the **Save** button
9. Once the information is saved, click the **Edit** button again and correct the missing character from the email. Click **Save**.
   
This will cause the VLSC to recognize that there were changes on the subscription and resend the assignment email to the email listed on the portal. 

> [!NOTE]
> - Newly assigned subscriptions will generate the assignment email automatically. The above is only necessary when a user requests a new assignment email notification or the notification is not sent for any reason.
