---
title: Edit subscriptions in the Administration Portal | Microsoft Docs
author: evanwindom
ms.author: lank
manager: lank
ms.date: 07/28/2019
ms.topic: conceptual
description:  Learn how administrators can edit subscription assignments.
---

# Edit Visual Studio subscription assignments
As a subscription administrator, you can make changes to the subscriptions assigned to individuals within your organization.  This article discusses the types of changes you can make and provides the necessary steps.

## Change subscriber information
You can edit a subscriber’s information to correct errors or update information.

To edit a subscriber, select the ellipses (…) that appear next to the subscriber’s email address when you hover your mouse over it. A dropdown will appear.  Select **Edit** to modify the subscriber’s details. You can also double-click on the subscriber's row in the grid to open the edit window.
> [!div class="mx-imgBorder"]
> ![Select subscriber to edit](_img/edit-license/select-subscriber.png)

You can update the subscriber’s first name, last name, country, language and downloads. Edit the subscriber’s information, and then click **Save**.

   > [!NOTE]
   > If you need to change the subscription level for a subscriber, you will need to delete the user from the portal and add them again. Subscription levels are not editable.

## Edit multiple subscribers using bulk edit
You can edit multiple subscribers at once using the bulk edit process. This feature is primarily used for organizations that are going through corporate email address changes or if an organization has decided to restrict access to downloads.

   > [!IMPORTANT]
   > Subscription levels (i.e. Enterprise, Professional, etc.) and subscription GUIDs cannot be altered.  If you attempt an upload with these items changed, the upload will fail.

1. To edit multiple subscribers at once, navigate to the Subscribers tab. In the ribbon at the top, click **Bulk Edit**.

2. Bulk edit uses an Excel template to make edits to subscriber information. In the Bulk Edit box, click **Export this excel** to download the current list of subscribers including all of their information.
   > [!div class="mx-imgBorder"]
   > ![Editing a License - Export Bulk Edits List](_img/edit-license/edit-license-bulk-edit-export.png)

3. Next, save the file locally so you can easily find it and make any necessary changes prior to uploading it. To ensure a successful upload, **don’t edit the subscription level or the subscription GUID** as doing so will cause the upload to fail.

4. Return to the Visual Studio Subscriptions Administration portal and in the Bulk Edit dialog box, click **Browse**. Select the Excel file you saved and click **OK**. You will see the upload progress on the screen.
   > [!div class="mx-imgBorder"]
   > ![Editing a License - Bulk Edits File Upload](_img/edit-license/edit-license-bulk-file-upload1.png)

5. Once you’ve uploaded the file, you will see a notification letting you know it was successful. At this point, your edits will be reflected in the subscriber information.

## Next steps
- For help finding a particular subscription, check out [Search for a subscription](search-license.md).
- Need to create a list of all your subscriptions?  Check out [Export subscriptions](exporting-subscriptions.md).