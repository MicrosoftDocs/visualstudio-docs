---
title: Organization name change impacts on Visual Studio subscriptions
author: joseb-rdc
ms.author: amast
manager: shve
ms.assetid: bda8772c-cc0b-4949-8419-1084331cc54b
ms.date: 09/16/2024
ms.topic: how-to
description:  Learn what to do if your email domain changes to ensure uninterrupted access to the admin portal and subscriptions. 
---

# What happens when your organization’s name or email domain changes

In today's fast moving business climate, organizations can undergo important changes.  Mergers, acquisitions, spin-offs, and rebranding can all cause the names of organizations and their tenants and domains to change.  Changes to email addresses can affect the ability of both subscribers and admins to access Visual Studio subscriptions.  For instance, if you're an admin and your email address changes, you can't log into the admin portal with your new address.  Follow the steps in this article to ensure you have uninterrupted access to your subscriptions when organization name changes occur. 

## What to do if your organization's email addresses change

> [!IMPORTANT]
> You'll need to be a super admin on your agreement to make some of these changes.  If you're not, you can ask a super admin to perform them for you. It's important that you update your admin information before your email address changes.

Complete these steps to move admins and subscribers to new email addresses:

### Update your admins

1. Sign in to the admin portal.
0. Select **Manage administrators**.
0. If you have more than one agreement, choose the agreement you want to change. 
0. Add yourself using your new email address and be sure to select the **Super admin** checkbox.  Learn more about [assigning admins](/visualstudio/subscriptions/admin-roles#assigning-admins).
0. Add your other admins using their new email addresses. 
> [!IMPORTANT]
> Do not delete your current admin email addresses until your new email addresses are active and the current ones are no longer needed.  This will ensure that your admins have uninterrupted access to the admin portal.

### Update your subscribers

Perform these steps **AFTER** the subscribers' email addresses change.  
1. Sign in to the admin portal.
0. Select **Manage subscribers**.
0. For subscriptions listed individually in the subscriber list, use the [bulk add](assign-license-bulk.md) feature to update all your subscribers easily.  
0. For subscriptions assigned to members of a Microsoft Entra group, there are no actions to take in the admin portal.  When their email addresses are updated in the Microsoft Entra group, their subscriptions are automatically updated in the admin portal. 

## Resources

+ [Subscriptions Support](https://aka.ms/vsadminhelp) for admins
+ [Microsoft Entra documentation](https://learn.microsoft.com/entra/)

## Next steps

+ Need to change a subscription without deleting it?  Learn how to [Edit subscriptions](edit-license.md).
+ To find a particular subscription, check out [Search for a subscription](search-license.md).
+ Need to create a list of all your subscriptions?  See [Export subscriptions](exporting-subscriptions.md).
+ Learn how to [delete subscriptions](delete-license.md). 
+ [Migrate existing subscriptions](migrate-subscriptions.md) to a new agreement.
