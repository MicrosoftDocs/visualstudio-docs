---
title: How do I assign subscribers in bulk?
description: Super admin or admin would like more details on how to use the bulk feature.
comment:  As of August 2023 this include is used to render marketing FAQ content for VS Subscriptions in the following portals - VSCom, Manage, and My portals. It was not used for learn.microsoft.com content at that time. SMEs are Jose Becerra and Larissa Crawford of Red Door Collaborative and Angela Cao-Hong.
ms.topic: include
ms.assetid: 3b450a79-47d2-4434-899d-bea29a0271e1
author: joseb-rdc
ms.author: amast
ms.date: 04/09/2024
user.type: admin
tags: bulk
subscription.type: vl, cloud, retail, partner
sap.id: b84fffb5-3363-eb7d-224e-1c63faf4067b
---

## How do I assign subscribers in bulk?

You have two options for assigning subscribers in bulk.
+ You can [bulk upload by using an Excel template](https://learn.microsoft.com/visualstudio/subscriptions/assign-license-bulk#use-bulk-add-to-assign-subscriptions).
+ If your organization has an agreement type that can over assign subscriptions, you can use [Microsoft Entra group assignment](https://learn.microsoft.com/visualstudio/subscriptions/assign-license-bulk#use-entra-id-groups-to-assign-subscriptions).

## Use bulk upload
1. Make sure the agreement that needs to be updated is selected in the agreement dropdown menu.
2. Select **Add** and then choose **Bulk edit** in the dropdown menu. Follow the instructions in the pop-up window.
3. After you export the Excel sheet, make the necessary edits in the file, then save and upload the file. When you make the edits, keep in mind that GUIDs can't be changed.
4. Select **OK** to begin the bulk edit.

If the template contains any errors, the upload fails. You're shown the errors, so you can correct the template and try again.

<a name='use-microsoft-entra-id-groups'></a>

## Use Microsoft Entra groups
Using Microsoft Entra groups to bulk upload is currently only available to organizations with agreements that can overclaim.
1. Make sure the agreement that needs updated is selected in the agreement dropdown menu.
2. Select **Add**, then choose **Microsoft Entra ID** from the dropdown menu.
3. Enter the name of the Microsoft Entra group you'd like to add into the form field. As you type the name, the search updates to show the available Microsoft Entra groups within your organization.
4. When you select the group, the field automatically populates with the group name. You can view the users in that group before you make changes.
5. Select **Add**, and then select **Confirm**.
6. Any future users added to the Microsoft Entra group are automatically given a subscription. Anyone removed from the group has their subscription removed.
