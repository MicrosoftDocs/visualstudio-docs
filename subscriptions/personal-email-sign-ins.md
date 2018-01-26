---
title: Personal Emails Displayed In VLSC
Author: evanwindom
Ms.author: jaunger
Manager: evelynp
Ms.date: 1/23/2018
Ms.topic: Get-Started-Article
Description:  Visual Studio Subscriptions – Why Am I Seeing Hotmail or Gmail Addresses for My Subscribers?   
Ms.prod: vs-subscription
Ms.technology: vs-subscriptions
Searchscope: VS Subscription
---

# Visual Studio Subscriptions – Why Am I Seeing Hotmail or Gmail Addresses for My Subscribers? 

As companies migrate from the Volume Licensing Service Center (VLSC) to the new Visual Studio [Subscriptions Administration Portal](https://manage.visualstudio.com), administrators may be surprised to find that the “Sign-in Email Address” for some subscribers shows a 3rd party email address like Hotmail, Gmail, or Yahoo.

## Cause

This scenario occurs due to sign-in processes that were associated with the legacy MSDN Subscriber experience. Users were migrated from VLSC to the new portal without modifications. Some admins may have been unaware that users had been using personal accounts to access their subscription benefits. Prior to the Visual Studio subscriber migrations, which were completed in 2016, there were two actions required to successfully use a Visual Studio Subscription:
1. The administrator “assigned” the subscription to an individual subscriber, using their work or school email address.
2. The subscriber “activated” the subscription.

During the subscriber activation process:
1. A Microsoft Account (MSA) was required to sign-in.
2. If the subscriber didn’t attempt to make their work or school account (e.g. John@contoso.com) an MSA, they could create a new MSA or leverage an existing one.
3. This resulted in their “Sign-in Email Address” being different than their “Assigned to Email Address”.

> [!NOTE] 
> The new subscriber experience on [https://my.visualstudio.com](https://my.visualstudio.com?wt.mc_id=o~msft~docs) supports both Work/School and Microsoft Account (MSA) identity types.

Finally, since the administrator migration is taking data from VLSC regarding the subscriber’s “Sign-In Email Address” to populate the new subscriber management experience, recently migrated admins may see these previously unnoticed personal accounts due to changes to the UI which make this information more visible.

## Solution

To correct the problem, you'll need to edit subscriber information to update their sign-in email addresses.  Edits can be made for individual subscribers, or in bulk. For complete information, please visit [Edit a subscription](/visualstudio/subscriptions/edit-license).  

Once you have updated the subscriber(s) email address(es), you may want to notify them that their sign-in information has changed.  