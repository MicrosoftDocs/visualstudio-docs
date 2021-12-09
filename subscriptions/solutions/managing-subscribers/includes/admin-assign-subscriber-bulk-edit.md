---
title: How do I assign subscribers in bulk?
description: Super admin or admin would like more details on how to use the bulk feature.
ms.topic: include
ms.assetid: 3b450a79-47d2-4434-899d-bea29a0271e1
author: evanwindom
ms.author: amast
ms.date: 06/01/2021
user.type: admin
tags: bulk
subscription.type: vl, cloud, retail, partner
sap.id: b84fffb5-3363-eb7d-224e-1c63faf4067b
---

## How do I assign subscribers in bulk?

You have two options for assigning subscribers in bulk.
- You can [bulk upload by using an Excel template](https://docs.microsoft.com/visualstudio/subscriptions/assign-license-bulk#use-bulk-add-to-assign-subscriptions).
- If your organization has an agreement type that can over assign subscriptions, you can use [Azure Active Directory (Azure AD) group assignment](https://docs.microsoft.com/visualstudio/subscriptions/assign-license-bulk#use-azure-active-directory-groups-to-assign-subscriptions).

## Use bulk upload
1. Make sure the agreement that needs to be updated is selected in the agreement dropdown menu.
2. Select **Add** and then choose **Bulk edit** in the dropdown menu. Follow the instructions in the pop-up window.
3. After you export the Excel sheet, make the necessary edits in the file, then save and upload the file. When you make the edits, keep in mind that GUIDs can't be changed.
4. Select **OK** to begin the bulk edit.

If the template contains any errors, the upload fails. You're shown the errors, so you can correct the template and try again.

## Use Azure AD groups
Using Azure AD to bulk upload is currently only available to organizations with agreements that can overclaim.
1. Make sure the agreement that needs updated is selected in the agreement dropdown menu.
2. Select **Add**, then choose **Azure Active Directory group** from the dropdown menu.
3. Enter the name of the Azure AD group you'd like to add into the form field. As you type the name, the search updates to show the available Azure AD groups within your organization.
4. When you select the group, the field automatically populates with the group name. You can view the users in that group before you make changes.
5. Select **Add**, and then select **Confirm**.
6. Any future users added to the Azure AD group are automatically given a subscription. Anyone removed from the group has their subscription removed.