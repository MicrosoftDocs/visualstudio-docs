---
title:  Delete Visual Studio subscription assignments in the Subscriptions Admin Portal | Microsoft Docs
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: e49242bc-e9f2-49e8-8caa-f574d508aba6
ms.date: 03/21/2021
ms.topic: how-to
description:  Learn how admins can delete subscription assignments in the Visual Studio Subscriptions Administration Portal
---

# Delete assignments in Visual Studio subscriptions
When a subscriber no longer requires a Visual Studio subscription, such as when they leave the company, complete a project, or switch to a new job role, you can remove their subscription and assign it to someone else. Please note that when you reassign a subscription, not all the subscriber benefits will be reset.  The new user will be able to claim any unclaimed keys and view previously claimed keys but claim limits are **not** reset.  For organizations that have Enterprise Agreements (EA), any benefits that were used by the original user, such as Pluralsight training, will be reset. 
> [!Important]
> Subscriptions can only be assigned to different users if a minimum of 90 days have passed since the subscription was last assigned.  For example, if a subscription was assigned to a subscriber on June 1, it cannot be assigned to a new subscriber until at least August 30. 

Watch this video or read on to learn how to delete assignments.  

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4yG2q]

## Delete a subscription assignment
1. Click the name of the subscriber you want to remove. To select multiple subscribers for removal, you can click the circle to the left of the subscriber name to select each one.  Alternatively, you can hold down the **CTRL** key and click each subscriber you wish to remove. To remove a range of subscribers, click the first one, press the **Shift** key, and click the last one.  Press **CTRL + A** to select and remove all subscribers. In this example, three subscribers - Amber, Kai, and Madison - will be deleted. 
2. To delete the selected subscriber(s), click **Delete**.
3. When the message appears asking you to confirm the deletion, click **OK**.
   > [!div class="mx-imgBorder"]
   > ![Delete subscribers](_img/delete-license/delete-subscribers.png "Choose the user(s) you wish to delete, and click Delete. You can use CTRL and Shift keys to select multiple subscribers.")

   > [!NOTE]
   > Bulk delete using a template is not available. 
   >
   > If you added subscription assignments through Azure Active Directory Security Groups, it may take up to 24 hours for the deletion to be updated in the admin portal.  See [our article](assign-license-bulk.md#use-azure-active-directory-groups-to-assign-subscriptions) for more information about using Azure Active Directory groups to manage subscriptions. 

## Resources
- [Subscriptions Support](https://aka.ms/vsadminhelp)

## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)

## Next steps
- Need to change a subscription without deleting it?  Learn how to [Edit subscriptions](edit-license.md)
- For help finding a particular subscription, check out [Search for a subscription](search-license.md).
- Need to create a list of all your subscriptions?  Please see [Export subscriptions](exporting-subscriptions.md).