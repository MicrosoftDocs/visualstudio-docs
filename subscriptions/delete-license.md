---
title:  Delete Visual Studio Subscription Assignments in the Subscriptions Admin Portal
author: joseb-rdc
ms.author: amast
manager: shve
ms.assetid: e49242bc-e9f2-49e8-8caa-f574d508aba6
ms.date: 01/28/2025
ms.topic: how-to
description:  Learn how admins can delete subscription assignments in the Visual Studio Subscriptions Admin Portal.
---

# Delete assignments in Visual Studio subscriptions

When a subscriber no longer requires a Visual Studio subscription, you can remove their subscription and assign it to someone else. When you reassign a subscription, not all the subscriber benefits are reset. The new user is able to claim any unclaimed keys and view previously claimed keys, but claim limits are *not* reset. For organizations that have Enterprise Agreements (EAs), any benefits that were used by the original user, such as Pluralsight training, are reset.

> [!IMPORTANT]
> Subscriptions can only be assigned to different users if a minimum of 90 days have passed after the subscription was last assigned. For example, if a subscription was assigned to a subscriber on June 1, it can't be assigned to a new subscriber until at least August 30.

To learn how to delete assignments, watch the following video or continue reading.

> [!VIDEO https://medius.microsoft.com/Embed/video-nc/b1db51e8-18e2-4432-9f8c-9a172cb1ca02?r=455207584654]

## Delete a subscription assignment

1. Select the name of the subscriber you want to remove. To select multiple subscribers for removal, you can select the circle to the left of the subscriber name to select each one. Or you can hold down the Ctrl key and select each subscriber you want to remove. To remove a range of subscribers, select the first one, press the Shift key, and then select the last one. Press the `CTRL+A` buttons to select and remove all subscribers. In this example, three subscribers named Amber, Kai, and Madison are deleted.
2. To delete the selected subscribers, select **Delete**.

   > [!div class="mx-imgBorder"]
   > ![Delete subscribers](_img/delete-license/delete-subscribers.png "Screenshot of the Manage subscribers page in the admin portal. The Delete menu option is highlighted.")

3. When a message appears that asks you to confirm the deletion, select **OK**.

   > [!NOTE]
   > If you added subscription assignments through Microsoft Entra groups, it might take up to 24 hours for the deletion to be updated in the admin portal. For more information about by using Microsoft Entra groups to manage subscriptions, see [this article about adding multiple users](assign-license-bulk.md#use-entra-id-groups-to-assign-subscriptions).

## Delete a large number of subscriptions

If you need to delete a large number of subscription assignments, you can use the **Bulk edit** feature.

> [!IMPORTANT]
> Before you make large changes to your subscriber list, we recommend that you create a backup of your current list. Select the **Export** option to create a backup. This action places an Excel copy of your current list in your downloads folder.
> 
> Don't use this approach to manage cloud subscriptions. Although you can download and complete the bulk edit template, you can't upload the template with your changes.

1. [Sign in](https://manage.visualstudio.com) by using an email address with admin rights for the agreement that was used to purchase the subscriptions.
0. Select the **Bulk edit** option.
   > [!div class="mx-imgBorder"]
   > ![Select Bulk edit](_img/delete-license/bulk-edit-select.png "Screenshot of the Manage subscribers page in the admin portal. The Bulk edit menu option is highlighted.")

0. The **Edit Multiple Subscribers** dialog appears.
0. Select the **Export this excel** link in step 1.
   > [!div class="mx-imgBorder"]
   > ![Select Export this excel](_img/delete-license/export-this-excel-select.png "Screenshot of the Edit multiple subscribers dialog. The Export this excel link in the first step is highlighted.")

0. Your subscriber list downloads as an Excel file. Locate the file in your downloads folder, and then open it. The file name contains the name of your agreement and the current date.
0. In a column to the right of the template, paste the email addresses of the subscribers you want to remove. (In the current template, column **V** is the first one available. Don't unhide any hidden columns and use them.) For this example, we're removing these users:
    * `aa-user1@contoso.com`
    * `a-user3@contoso.com`
    * `a-user5@contoso.com`
    * `b-user2@contoso.com`
    * `b-user4@contoso.com`

   > [!div class="mx-imgBorder"]
   > ![Add the users you want to delete](_img/delete-license/user-list-added.png "Screenshot of the bulk edit template that shows the users you want to delete listed in the right-most column. The list of users is highlighted.")

0. Select both the column that contains the users you want to delete, and the column that contains the email addresses of all the users. In this case, that's column **B** and column **V**. To select the columns, select the first column heading, and then `CTRL+select` the second column heading. The template should now look like this:
   > [!div class="mx-imgBorder"]
   > ![Select both user columns](_img/delete-license/columns-selected.png "Screenshot of the bulk edit template that shows the columns for all users with the users you want to delete selected.")

0. On the **Home** tab in Excel, select **Conditional Formatting**, choose **Highlight Cells Rules**, and then select **Duplicate Values**.
0. Select **OK** to accept the default color choice. The users you want to delete should be highlighted in both columns.
   > [!div class="mx-imgBorder"]
   > ![Duplicates highlighted](_img/delete-license/duplicates-highlighted.png "Screenshot of the bulk edit template that shows the columns for all users and the users you want to delete selected. The user names that you want to delete are highlighted.")

0. To deselect the two columns, select a cell in the spreadsheet.
0. On the **Data** tab, select **Filter**.
0. Select the filter dropdown menu in column **B**, choose **Sort by color**, and select the color that was applied to the duplicate cells. You should now see only the users you want to delete.
0. In the **Reference** column for each user, identify the users you want to delete by entering a specific word or phrase. Use the same term for all of the users. In the following example, the phrase is **DELETE USER**. You can use the **fill down** feature in Excel to replicate the phrase for all of the users. Your template show now look like this:
   > [!div class="mx-imgBorder"]
   > ![Filtered User List](_img/delete-license/reference-added.png "Screenshot of the template that shows the columns filtered by color. The phrase Delete User has been added to the reference field for each user.")

0. Save the template.
0. Switch back to the admin portal. The **Edit multiple subscribers** dialog should still be open. (If it's not, just reselect the **Bulk edit** option.)
0. Select the **Browse** button, select the file you saved, and select **Open**. The name of your file is displayed in the dialog.
0. Select **OK**.
0. You should now see your subscriber list. The subscribers you want to delete should have the identifying phrase you defined earlier in the **Reference** column. If it's not visible and you want to display it, select the **Edit columns** menu option and add the column.
   > [!div class="mx-imgBorder"]
   > ![List Showing Reference](_img/delete-license/reference-list.png "Screenshot of the subscriber list in the admin portal that shows the addition of the reference term that marks the users you want to delete.")

0. In the **Filter by name, email or reference** field, enter the word or phrase that you used to mark the users you want to delete. The filter is applied even if the **Reference** column isn't displayed.
0. You should now see only the users you need to delete. You can select one user, then use Ctrl+A to select them all, and choose **Delete**.
0. Clear the filter field to display your updated subscriber list.

## Related content

* [Subscriptions support](https://aka.ms/vsadminhelp)
* [Visual Studio documentation](/visualstudio/)
* [Azure DevOps documentation](/azure/devops/)
* [Azure documentation](/azure/)
* [Microsoft 365 documentation](/microsoft-365/)
* Need to change a subscription without deleting it? Learn how to [edit subscriptions](edit-license.md).
* To find a particular subscription, check out [search for a subscription](search-license.md).
* Need to create a list of all your subscriptions? See [export subscriptions](exporting-subscriptions.md).
