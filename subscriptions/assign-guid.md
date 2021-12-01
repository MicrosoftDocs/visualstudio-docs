---
title: Assign specific GUIDs to Visual Studio subscribers | Microsoft Docs
author: evanwindom
ms.author: amast
manager: shve
ms.date: 03/19/2021
ms.topic: conceptual
ms.assetid: f9c82d7d-55bd-4e41-a170-6077b28ba5af
description:  Learn how admins can specific subscription GUID to subscribers
---

# Assign specific subscriptions in the Visual Studio Subscriptions Administration Portal

Admins can now use the Visual Studio Subscriptions Administration Portal to assign specific subscriptions to individual subscribers.  This can be useful in situations where the organization has temporary staff or vendors that need access to a subscription for a short period.  Admins can assign a subscription that has already been partially used, leaving their new subscriptions for longer term use.  

Watch the video or read on to learn how assign specific subscriptions GUIDs to users. 

<br>

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4t4cl]


## Assign specific subscription GUIDs to users

The process for assigning specific subscriptions to individuals involves leveraging two existing admin processes to assign specific subscription Globally Unique Identifiers (GUIDs) to individual users.  The three-step process includes exporting a list of your current subscriptions and assignments, using that list to identify the specific GUIDs you want to assign, and then using the bulk add process to upload the new assignments.

### Export your subscriptions information

To perform the export:
1. Sign in to the [Administration Portal](https://manage.visualstudio.com).
2. Select the **Export** tab. and the file will download to your local machine. The file will include the name of the agreement that contains your user subscriptions, as well as the date of the export.
> [!div class="mx-imgBorder"]
> ![Export subscribers](_img/exporting-subscriptions/exporting-subscriptions.png "Click Export to save of list of your assigned subscriptions with subscriber information.")

### Identify the GUIDs you want to assign

If you've used the Export tool previously, you'll notice that new fields have been added to the spreadsheet that's produced.  These will help you determine the status of each subscription and which ones you want to assign to users.  

- **Subscription Status**: This field will indicate either "assigned" or "unassigned".  If a subscription has a status of "assigned", it will also have user information associated with it, such as name, email, etc. 
- **Usage Status**: The usage status will indicate either "new", meaning it has never been assigned to a user, or "used" which indicates it has been assigned to a user at some point.  

You can use the values in these fields along with other information in the spreadsheet to determine which subscriptions you want to assign to individual users. You can apply a filter in Excel to help narrow the list by status, subscription level, expiration date, etc. 

### Upload your new assignments

The final step is to download the **Bulk add** template, fill out the required information for the subscriptions you want to assign, and upload the template.  For a complete description of that process, please see our [Add multiple users](assign-license-bulk.md) article.  

> [!IMPORTANT]
> To ensure a successful upload, please make sure that:
> - You are using the template linked in the dialog box when you select **Bulk add**.  Do not use a locally stored copy of the template, as it may not contain all the required fields.  Using an old template will cause the upload to fail. 
> - All fields shown as **Required** in template are complete.
> - There are no errors listed in the **Error message** column.
> - Each GUID is used only once in the template. 
> - The subscription level in the template matches the subscription of the GUID in the exported list. 
> - The GUID is not already assigned to another user in the exported list. 

## Frequently asked questions
### Q: How do I change which subscription is currently assigned to an individual user?
A: If you want to change which GUID is assigned to a user, you must first delete the subscription for that user.  For more information, please see our [Delete subscriptions](delete-license.md) article for more information.  After deleting the subscription for that user, use the process outlined above to export the list and upload the new subscription information.  

## Resources
- [Subscriptions Support](https://aka.ms/vsadminhelp)

## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)

## Next steps
Now that you have assigned subscriptions to users, find out how to perform other admin tasks.
- [Assign individual subscriptions](assign-license.md)
- [Assign multiple subscriptions](assign-license-bulk.md)
- [Edit subscriptions](edit-license.md)
- [Delete subscriptions](delete-license.md)
- [Determine maximum usage](maximum-usage.md)
