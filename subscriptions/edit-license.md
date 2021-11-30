---
title: Edit Visual Studio subscriptions in the Administration Portal | Microsoft Docs
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: 97ac8e4d-7a03-42f8-98cb-15bcaa90ef65
ms.date: 03/21/2021
ms.topic: how-to
description:  Learn how admins can edit subscription assignments.
---

# Edit Visual Studio subscription assignments
As a subscription admin, you can make changes to the subscriptions assigned to individuals within your organization.  This article discusses the types of changes you can make and provides the necessary steps.

   > [!NOTE]
   > If you need to change subscription details for a subscriber assigned through an Azure Active Directory Group, you will need to remove them from the group and add them into the Administration Portal individually.  

## Change subscriber information
You can edit a subscriber’s information to correct errors or update information.

To edit a subscriber, select the ellipses (…) that appear next to the subscriber’s email address when you hover your mouse over it. A dropdown will appear.  Select **Edit** to modify the subscriber’s details. 
> [!div class="mx-imgBorder"]
> ![Select subscriber to edit](_img/edit-license/select-subscriber.png "Click the ellipses and choose Edit.")

You can update the subscriber’s first name, last name, subscription level, email address, country, language, downloads and reference field. Edit the subscriber’s information, and click **Save**.

## Edit multiple subscribers using bulk edit

You can edit multiple subscribers at once using the bulk edit process. This feature is primarily used for organizations that are going through corporate email address changes or if an organization has decided to restrict access to downloads.

Watch this video or read on to learn how to edit multiple subscribers using bulk edit. 
<br>

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4vkAF]

> [!NOTE]
> Do not change subscription GUIDs in the template. Please see our article about [assigning specific subscription GUIDs](assign-guid.md).

1. To edit multiple subscribers at once, navigate to the Subscribers tab. In the ribbon at the top, click **Bulk Edit**.

2. Bulk edit uses an Excel template to make edits to subscriber information. In the Bulk Edit box, click **Export this excel** to download the current list of subscribers including all of their information.
   > [!div class="mx-imgBorder"]
   > ![Editing a License - Export Bulk Edits List](_img/edit-license/edit-license-bulk-edit-export.png "Click Export this excel to create a list of your current subscriptions.")

3. Next, save the file locally so you can easily find it and make any necessary changes prior to uploading it. 

4. Return to the Visual Studio Subscriptions Administration portal and in the Bulk Edit dialog box, click **Browse**. Select the Excel file you saved and click **OK**. You will see the upload progress on the screen.
   > [!div class="mx-imgBorder"]
   > ![Editing a License - Bulk Edits File Upload](_img/edit-license/edit-license-bulk-file-upload1.png "Browse to the location of your completed Excel file, select it, and click OK.")

5. Once you’ve uploaded the file, you will see a notification letting you know it was successful. At this point, your edits will be reflected in the subscriber information.

## Resources
- [Subscriptions Support](https://aka.ms/vsadminhelp)

## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)

## Next steps
- Need to assign a specific subscription ID? Check out Assigning a subscription ID. 
- For help finding a particular subscription, check out [Search for a subscription](search-license.md).
- Need to create a list of all your subscriptions?  Check out [Export subscriptions](exporting-subscriptions.md).