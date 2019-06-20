---
title: Personal Emails Displayed In VLSC
author: evanwindom
ms.author: jaunger
manager: evelynp
ms.date: 01/23/2018
ms.topic: conceptual
description:  Visual Studio Subscriptions – Why Am I Seeing Hotmail or Gmail Addresses for My Subscribers?
---

# Visual Studio subscriptions – Why am I seeing Hotmail or Gmail addresses for my subscribers?

As companies migrate from the Volume Licensing Service Center (VLSC) to the new Visual Studio [Subscriptions Administration portal](https://manage.visualstudio.com), administrators may be surprised to find that the “Sign-in Email Address” for some subscribers shows a 3rd party email address like Hotmail, Gmail, or Yahoo.  For more information, check out [this video](https://www.youtube.com/watch?v=1op-i1zEMfY&t=0s&list=PLReL099Y5nRfDyvvwzNDBaZe7qTxmuM2T&index=6).

## Cause

This scenario occurs due to sign-in processes that were associated with the legacy MSDN subscriber experience. Users were migrated from the Volume License Service Center (VLSC) to the new portal without modifications. Administrators may not have been aware that users had been using personal accounts to access their subscription benefits. Prior to the Visual Studio subscriber migrations, which were completed in 2016, there were two actions required to successfully use a Visual Studio Subscription:
1. The administrator “assigned” the subscription to an individual subscriber, using their work or school email address.
2. The subscriber “activated” the subscription.

During the subscriber activation process:
A Microsoft Account (MSA) was required to sign-in. If the subscriber didn’t attempt to make their work or school account (e.g. tasha@contoso.com) an MSA, they could create a new MSA or leverage an existing one. This resulted in their “Sign-in Email Address” being different than their “Assigned to Email Address”.

> [!NOTE]
> The new subscriber experience on [https://my.visualstudio.com](https://my.visualstudio.com?wt.mc_id=o~msft~docs) supports both Work/School and Microsoft Account (MAA) identity types.

Finally, since the administrator migration is taking data from VLSC regarding the subscriber’s “Sign-In Email Address” to populate the new subscriber management experience, recently migrated admins may see these previously unnoticed personal accounts due to changes to the user interface which make this information more visible.

## Solution

To correct the problem, you'll need to edit subscriber information to update their sign-in email addresses.  Edits can be made for individual subscribers, or in bulk. For complete information, please visit [Edit a subscription](edit-license.md).

Once you have updated the subscriber(s) email address(es), you may want to notify them that their sign-in information has changed.  They will also receive an email with the updated information.