---
title:  Resolve bulk upload issues
description: The super admin or admin thought they assigned the users to the new agreement, but they added the users to the wrong agreement.
ms.topic: include
ms.assetid: 273f5f7a-739e-4de0-b7f7-d0bdd616e059
author: evanwindom
ms.author: amast
ms.date:  06/01/2021
user.type: admin
tags: bulk, upload
subscription.type: vl, cloud, retail, partner
sap.id: b84fffb5-3363-eb7d-224e-1c63faf4067b
---

## How do I fix a bulk upload to use the correct agreement?

If you mistakenly bulk upload to the wrong agreement, follow these steps to fix the issue.

First, be sure to upload the subscribers to the correct agreement, and then delete the subscribers from the other agreement. You can delete in bulk or fix the issue for a single user through the admin portal.

## Individual users

1. On the [Subscribers page of the admin portal](https://manage.visualstudio.com/subscribers), find the subscribers you need to remove by clicking on the column name and sorting. You can also use the filter option to more easily find the users.
2. After you find the subscribers to remove, select the check box beside the users. There's no limit to the number of users you can select at a time. You can also select the first user in a list that you want to remove, then select Shift, and then select the last user in the list. These steps select all the users in the list. You can also select the check icon at the top of the list to select all users. 
3. Select **Delete** at the top of the grid, and then confirm deletion.

## Azure Active Directory (Azure AD) group

If the users were added through an Azure AD group, you need to remove the users from the Azure AD group directly. After the users are removed from the group, it can take up to 24 hours for the deletion to be visible in the admin portal. 

## Impact of moving subscriptions

When subscribers are moved to a new agreement, they receive a new subscription ID. This change breaks the link with their Azure subscription associated with the monthly Azure credit benefit. When the link is broken, the old Azure subscription is subject to eventual deactivation. To avoid disruption, subscribers need to create a new Azure subscription by using the benefit in their new Visual Studio subscription, and then [transfer any existing Azure assets](https://docs.microsoft.com/azure/azure-resource-manager/management/move-resource-group-and-subscription) from the old Azure subscription to the new one.