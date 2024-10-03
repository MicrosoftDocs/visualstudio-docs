---
title: Update subscriber sign-in email address
description: Super admin or admin wants to update the subscribers domain in bulk.
comment:  As of August 2023 this include is used to render marketing FAQ content for VS Subscriptions in the following portals - VSCom, Manage, and My portals. It was not used for learn.microsoft.com content at that time. SMEs are Jose Becerra and Larissa Crawford of Red Door Collaborative and Angela Cao-Hong.
ms.topic: include
ms.assetid: c1220a33-26b0-4bf9-be97-ab2b3055e351
author: joseb-rdc
ms.author: amast
ms.date: 04/09/2024
user.type: admin
tags: email
subscription.type: vl, cloud, retail, partner
sap.id: b84fffb5-3363-eb7d-224e-1c63faf4067b
---

## Update subscriber's sign-in email address

You can update subscriber's sign-in email address individually or by using bulk edit. 

## Bulk edit
1. On the **Manage subscribers** page, make sure you’re on the agreement that needs to be updated.
2. Select **Bulk edit**, export the Excel file, and follow the instructions in the pop-up window.
3. Make the necessary edits in the file, then save and upload the file. When you make the edits, keep in mind that GUIDs can't be changed.
4. Select **OK** to begin the bulk edit.
5. Your subscribers receive an email informing them of the change.

## Individual edit 
1. On the **Manage subscribers** page, make sure you’re on the agreement that needs to be updated.
2. Select the subscriber to update, and then select the ellipsis (...) next to the subscriber name.
3. Select **Edit**.
4. In the fly-out panel, make the necessary edits, and then select **Save**.
5. Your subscribers receive an email informing them of the change.

## Microsoft Entra ID
If you assign subscriptions by using Microsoft Entra groups, any email address or name updates are automatically reflected in [manage.visualstudio.com](https://manage.visualstudio.com). After you save the changes, you should see the updates reflected in the admin portal within 24 hours. 
1. Sign into the [Azure portal](https://portal.azure.com).
2. Make the necessary updates.

## Effects of sign-in email updates
Changing the sign-in email can have negative effects for your subscribers, including:
+ Sign-in issues with the Visual Studio IDE.
+ Sign-in issues with Azure DevOps.
 Issues with the monthly Azure dev/test individual credit.

[Read more about how changing the sign-in email](https://learn.microsoft.com/visualstudio/subscriptions/subscription-level-changes) can affect subscriber's associated benefits.
