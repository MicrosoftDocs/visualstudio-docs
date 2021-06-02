--- 
title: How do I assign subscribers in bulk?
description: Super admin/admin would like more details on how to use the bulk feature
ms.assetid: 3b450a79-47d2-4434-899d-bea29a0271e1
author: CaityBuschlen 
ms.author: cabuschl 
ms.date: 06/01/2021
user.type: admin 
tags:  
subscription.type: vl, cloud, retail, partner 
sap.id: b84fffb5-3363-eb7d-224e-1c63faf4067b
---

## How do I assign subscribers in bulk?

You have two options for assigning subscribers in bulk. You can [bulk upload using an excel template](https://docs.microsoft.com/visualstudio/subscriptions/assign-license-bulk#use-bulk-add-to-assign-subscriptions), or if your organization has an agreement type that can over assign subscriptions, you can use [Azure Active Directory (Azure AD) group assignment](https://docs.microsoft.com/visualstudio/subscriptions/assign-license-bulk#use-azure-active-directory-groups-to-assign-subscriptions).

## Using bulk upload
1.	Make sure the agreement that needs updated is selected in the agreement drop-down menu
2.	Click on **Add** and then choose **Bulk edit** in the dropdown and follow the instructions in the pop-up 
3.	After you export the Excel sheet, make the necessary edits in the file (GUIDs can't be changed), then save and upload the file
4.	Click on **OK** to begin the bulk edit 

If the template contains any errors, the upload will fail. You'll be shown the errors so that you can correct the template and try again.

## Using Azure AD groups
Using Azure AD to bulk upload is currently only available to organizations with agreements that can overclaim.
1.	Make sure the agreement that needs updated is selected in the agreement dropdown
2.	Select on **Add**, then choose **Azure Active Directory group** from the drop-down menu
3.	Enter the name of the Azure AD group you'd like to add into the form field. As you begin, the search will show the available Azure AD groups within your organization
4.	When you select the group, the field will automatically populate with the group name. You can view the users in that group before making changes 
5.	Select **Add** then **Confirm**
6.	Any future users added to the Azure AD group will automatically be given a subscription, and anyone removed from the group will have their subscription removed



