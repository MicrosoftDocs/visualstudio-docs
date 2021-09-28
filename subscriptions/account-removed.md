---
title:  Visual Studio subscription assignments deleted by Microsoft | Microsoft Docs
author: evanwindom
ms.author: cabuschl
manager: cabuschl
ms.assetid: f853ed9d-3543-4f5f-a754-92381ee03523
ms.date: 09/28/2021
ms.topic: how-to
description:  Learn what it means when you see a notification that Microsoft has deleted a subscription.
---

# Why does my dashboard shows Microsoft removed a subscriber? 
In the **Recent changes** section of the Dashboard on the [admin portal](https://manage.visualstudio.com), you may see that subscriptions have been removed, and the reason is shown as "Account closed".  There are two reasons this may occur.  

## Subscribers request closure of their Microsoft accounts
If a subscriber requests closure of their Microsoft account (MSA), and that MSA is used to sign in to their subscription, the subscription will be removed when the MSA is closed.  

For more information about closing MSAs, including important information you should consider before closing the account and the steps to take, see [How to close your Microsoft account](https://support.microsoft.com/account-billing/how-to-close-your-microsoft-account-c1b2d13f-4de6-6e1b-4a31-d9d668849979).

## Subscribers are removed from Azure Active Directory tenant
When a subscriber whose subscription was assigned automatically using an Azure Active Directory (Azure AD) group is removed from that group, the subscription is automatically removed.  

## What happens when the account is closed?
If the subscription is removed, either because the subscriber requested closure of the account or because they were removed from an Azure AD tenant used to assign subscriptoins, they immediately lose access to the subscription.  A countdown for the permanent removal of their information will also begin.  The duration of the countdown depends on depends on several factors.

## Resources
- [Subscriptions Support](https://aka.ms/vsadminhelp) for admins

## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)

## Next steps
- Need to change a subscription without deleting it?  Learn how to [Edit subscriptions](edit-license.md).
- For help finding a particular subscription, check out [Search for a subscription](search-license.md).
- Need to create a list of all your subscriptions?  Please see [Export subscriptions](exporting-subscriptions.md).
- Learn how to [delete subscriptions](delete-license.md). 

