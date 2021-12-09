---
title: Update subscriber sign-in email address
description: Super admin or admin wants to update the subscribers domain in bulk.
ms.topic: include
ms.assetid: c1220a33-26b0-4bf9-be97-ab2b3055e351
author: evanwindom
ms.author: amast
ms.date: 06/01/2021
user.type: admin
tags: email
subscription.type: vl, cloud, retail, partner
sap.id: b84fffb5-3363-eb7d-224e-1c63faf4067b
---

## Update subscriber's sign-in email address

You can update subscriber's sign-in email address individually or by using bulk edit. 

##  Bulk edit
1. On the **Manage subscribers** page, make sure you’re on the agreement that needs to be updated.
2. Select **Bulk edit**, export the Excel file, and follow the instructions in the pop-up window.
3. Make the necessary edits in the file, then save and upload the file. When you make the edits, keep in mind that GUIDs can't be changed.
4. Select **OK** to begin the bulk edit.
5. Your subscribers will receive an email informing them of the change.

## Individual edit 
1. On the **Manage subscribers** page, make sure you’re on the agreement that needs to be updated.
2. Select the subscriber to update, and then select the ellipsis (...) next to the subscriber name.
3. Select **Edit**.
4. In the fly-out panel, make the necessary edits, and then select **Save**.
5. Your subscribers will receive an email informing them of the change.

## Azure Active Directory (Azure AD) 
If you assign subscriptions by using Azure AD groups, any email address or name updates are automatically reflected in [manage.visualstudio.com](https://manage.visualstudio.com). After you save the changes, you should see the updates reflected in the admin portal within 24 hours. 
1. Sign into the [Azure portal](https://portal.azure.com).
2. Make the necessary updates.

## Impact of sign-in email updates
Changing the sign-in email can have negative impacts for your subscribers, including:
- Sign-in issues with the Visual Studio IDE.
- Sign-in issues with Azure DevOps.
- Issues with the monthly Azure dev/test individual credit.

[Read more about how changing the sign-in email](https://docs.microsoft.com/visualstudio/subscriptions/subscription-level-changes) can impact subscriber's associated benefits.