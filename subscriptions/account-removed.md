---
title:  Visual Studio subscription assignments deleted by Microsoft | Microsoft Docs
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: f853ed9d-3543-4f5f-a754-92381ee03523
ms.date: 03/21/2023
ms.topic: how-to
description:  Learn what it means when you see a notification that Microsoft has deleted a subscription.
---

# Why does my dashboard show Microsoft removed a subscriber? 

In the **Recent changes** section of the Dashboard on the [admin portal](https://manage.visualstudio.com), you may see that subscriptions have been removed, and the reason is shown as "Account closed".    

## Why an account may be removed.  
+ Subscribers request closure of their Microsoft accounts. If a subscriber requests closure of a Microsoft account (MSA) that is used to sign in to their subscription, the subscription is removed when the MSA is closed. For more information including important things to consider before closing an account, see [How to close your Microsoft account](https://support.microsoft.com/account-billing/how-to-close-your-microsoft-account-c1b2d13f-4de6-6e1b-4a31-d9d668849979).
+ Subscribers are removed from Azure Active Directory tenant.  Subscriptions can automatically assigned subscriptions through an Azure Active Directory group.  When they are removed from the group, their subscriptions are removed.

## What happens when the account is closed?

If the subscription is removed, the subscriber loses access to the subscription.  If a subscriber is removed from an Azure AD group, their subscription information is permanently removed within 180 days.  If a subscriber closes their MSA, their information is removed immediately.  

## Resources

[Subscriptions Support](https://aka.ms/vsadminhelp) for admins

## See also

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)

## Next steps

+ Need to change a subscription without deleting it?  Learn how to [Edit subscriptions](edit-license.md).
+ To find a particular subscription, check out [Search for a subscription](search-license.md).
+ Need to create a list of all your subscriptions?  See [Export subscriptions](exporting-subscriptions.md).
+ Learn how to [delete subscriptions](delete-license.md). 

