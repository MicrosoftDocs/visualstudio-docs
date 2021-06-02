--- 
title:  Resolve bulk upload issues
description: The super admin/admin thought they had assigned the users to the new agreement when they actually added them to the wrong agreement
ms.assetid: 273f5f7a-739e-4de0-b7f7-d0bdd616e059  
author: CaityBuschlen 
ms.author: cabuschl 
ms.date:  06/01/2021
user.type: admin 
tags:  
subscription.type: vl, cloud, retail, partner 
sap.id: b84fffb5-3363-eb7d-224e-1c63faf4067b
---

## How do I fix a bulk upload to the wrong agreement?

If you mistakenly bulk upload to the wrong agreement, follow the steps below to fix.  

First, be sure to upload the subscribers to the correct agreement then delete them from the other agreement. You can delete in bulk or single user through the admin portal.

## Individual users
1.	On the [Subscribers page of the admin portal](https://manage.visualstudio.com/subscribers), find the subscribers you need to remove by clicking on the column name and sorting, or use the filter option, to find your users more easily
2.	Once you’ve found the subscribers to remove, select the check box beside the users. There's no limit to the number of users you can select at once. You can also select the first user in a list you want to remove, select shift, and then select the last user in the list, which will select all the users in the list. Or click the check icon at the top of the list to select all users. 
3.	Click the **Delete** button along the top of the grid and confirm deletion.

## Azure Active Directory (Azure AD) group
If the users were added through an Azure AD group, you'll need to remove them from the Azure AD group directly. Once removed from the group, it may take up to 24 hours for the deletion to update in the admin portal. 

## Impact of moving subscriptions
When subscribers are moved to a new agreement, they'll receive a new subscription ID. This change will break the link with their Azure subscription associated with the monthly Azure credit benefit. When that happens, the old Azure subscription will be subject to eventual deactivation. To avoid disruption, subscribers will need to create a new Azure subscription using the benefit in their new Visual Studio subscription, and [transfer any existing Azure assets](https://docs.microsoft.com/azure/azure-resource-manager/management/move-resource-group-and-subscription) from the old Azure subscription to the new one.


