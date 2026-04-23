---
title: Assign specific GUIDs to Visual Studio subscribers
author: joseb-rdc
ms.author: amast
manager: shve
ms.date: 01/28/2025
ms.topic: how-to
description:  Learn how admins can  assign specific subscription GUID to subscribers.
ms.custom: sfi-image-nochange
---

# Assign specific subscriptions in the Visual Studio Subscriptions Admin Portal

Admins can now use the Visual Studio Subscriptions Admin Portal to assign specific subscriptions to individual subscribers. These assignments can be useful in situations where the organization has temporary staff or vendors that need access to a subscription for a short period. Admins can assign a subscription that is partially used, leaving their new subscriptions for longer term use. 

Watch the video or read on to learn how to assign specific subscriptions GUIDs to users. 

> [!VIDEO https://medius.microsoft.com/Embed/video-nc/0873adfc-6e4b-4676-9eee-76e79103c44e?r=253107379154]

## Assign specific subscription GUIDs to users

Assigning specific subscriptions to individuals uses two existing admin processes to assign specific subscription Globally Unique Identifiers (GUIDs) to individual users. The process has three steps:
1. Export a list of your current subscriptions and assignments.
0. Use that list to identify the specific GUIDs you want to assign.
0. Use the "Bulk add" to upload the new assignments.

### Export your subscriptions information

To perform the export:
1. Sign in to the [Admin Portal](https://manage.visualstudio.com).
2. Select the **Export** tab. A file downloads to your local machine. The file includes the name of the agreement that contains your user subscriptions, and the date of the export.
> [!div class="mx-imgBorder"]
> ![Export subscribers](_img/exporting-subscriptions/exporting-subscriptions.png "Screenshot of the manage portal. The Export menu is highlighted.")

### Identify the GUIDs you want to assign

If you're familiar with the Export tool before, notice there are new fields in the spreadsheet. This information helps you decide which ones you want to assign to users. 

+ **Subscription Status**: This field indicates either "assigned" or "unassigned." If a subscription has a status of "assigned," it also has user information associated with it, such as name, email, etc. 
+ **Usage Status**: The usage status indicates either "new," meaning it isn't assigned to a user, or "used" which indicates it was assigned to a user at some point. 

You can use the values in these fields along with other information in the spreadsheet to determine which subscriptions you want to assign to individual users. You can apply a filter in Excel to help narrow the list by status, subscription level, expiration date, etc. 

### Upload your new assignments

The final step is to download the **Bulk add** template, fill out the required information for the subscriptions you want to assign, and upload the template. For a complete description of that process, see our [Add multiple users](assign-license-bulk.md) article. 

> [!IMPORTANT]
> To ensure a successful upload, make sure that:
>  You're using the template linked in the dialog box when you select **Bulk add**. Do not use a locally stored copy of the template, as it may not contain all the required fields. Using an old template will cause the upload to fail. 
> + All fields shown as **Required** in template are complete.
> + There are no errors listed in the **Error message** column.
> + Each GUID is used only once in the template. 
> + The subscription level in the template matches the subscription of the GUID in the exported list. 
> + The GUID is not already assigned to another user in the exported list. 

## Frequently asked questions

### Q: How do I change which subscription is currently assigned to an individual user?

A: If you want to change which GUID is assigned to a user, you must first delete the subscription for that user. For more information, see our [Delete subscriptions](delete-license.md) article. After deleting the subscription for that user, use the process outlined in this article to export the list and upload the new subscription information. 

## Resources

[Subscriptions Support](https://aka.ms/vsadminhelp)

## See also

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps Services documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)

## Next steps

Now that you assigned subscriptions to users, find out how to perform other admin tasks.
+ [Assign individual subscriptions](assign-license.md)
+ [Assign multiple subscriptions](assign-license-bulk.md)
+ [Edit subscriptions](edit-license.md)
+ [Delete subscriptions](delete-license.md)
+ [Determine maximum usage](maximum-usage.md)
