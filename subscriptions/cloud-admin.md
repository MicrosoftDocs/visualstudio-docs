---
title: Setting Up Administrators for Monthly Subscriptions | Microsoft Docs
author: evanwindom
ms.author: lank
manager: lank
ms.assetid: 8b30e2bc-2ac3-4fcc-b296-128731471032
ms.date: 03/03/2020
ms.topic: how-to
description: Setting Up Administrators for monthly Subscriptions
---
# Set up administrators for Visual Studio monthly subscriptions

Visual Studio monthly subscriptions are managed by administrators. These individuals can assign subscriptions, edit assignments, add or delete subscriptions, and perform other subscription management tasks.

## The Azure subscription owner is the first administrator

When you purchase Visual Studio monthly subscriptions, as the owner of the Azure subscription used to make the purchases, you are automatically set up as an administrator for those subscriptions.

You can purchase monthly subscriptions through the [Visual Studio Marketplace](https://marketplace.visualstudio.com/subscriptions), or by contacting a Cloud Solution Provider. If you purchase through the Visual Studio Marketplace, at the end of the purchase experience, you'll be provided with an opportunity to manage users. Choosing that option will take you to the Visual Studio Subscriptions Administration Portal - [https://manage.visualstudio.com](https://manage.visualstudio.com).

Once you've purchased subscriptions, you can visit the [Administration Portal](https://manage.visualstudio.com) at any time. Just sign in to the portal, and select the appropriate Azure subscription in the upper left corner.

As the owner of the Azure subscription used to purchase the monthly subscriptions, you can also assign additional administrators.

## Add administrators

To add administrators:

1. Connect to the Azure Portal at [portal.azure.com](https://portal.azure.com).
2. Sign in with the account you used to purchase the Visual Studio monthly subscriptions.
3. Under **Azure services**, choose **Cost Management + Billing**.
   > [!div class="mx-imgBorder"]
   > ![Choose Cost Management + Billing under Azure services](_img/cloud-admin/azure-cost-billing.png)
4. In the **My subscriptions** list, choose the Azure subscription that you used to make the purchase.
   > [!div class="mx-imgBorder"]
   > ![Choose subscription](_img/cloud-admin/subscription-list.png)
5. Click **Access control (IAM)**, which is located near the top of the list in the left navigation pane.
6. Click the **Add** tab at the top of the page.
7. Click **Add role assignment**.
   > [!div class="mx-imgBorder"]
   > ![Choose Access control, Add, Add role assignment](_img/cloud-admin/access-control-add.png)
8. In the fly-out pane on the right, click on the **Role** drop-down at the top of the pane, scroll down, and select **User Access Administrator**.
9. In the list of users, scroll down to the user you wish to make an admin, and select them. 
   > [!div class="mx-imgBorder"]
   > ![Choose Role, User access admin](_img/cloud-admin/add-role-user-access-admin.png)
10. Click **Save**.
11. Click on the **Role assignments** tab to verify that the user you selected now appears as a User Access Administrator.

The new administrator can now sign in to the [Administration Portal](https://manage.visualstudio.com), select the same Azure subscription that was used to purchase the monthly subscriptions from the list in the upper left corner of the page, and begin to manage those subscriptions.

> [!NOTE]
> If you see users with access to edit your monthly subscriptions that you didn't establish as administrators, they may have roles in the underlying Azure subscription that allow them to manage subscriptions. Those roles include: owner, contributor, service admin, or co-admin. For more information, visit [Add billing managers](/azure/devops/organizations/billing/add-backup-billing-managers?view=vsts).

For information about Visual Studio monthly subscriptions, see the [Overview](vscloud-overview.md) under Buying  subscriptions. To purchase Visual Studio monthly subscriptions, visit the Visual Studio Marketplace at [https://marketplace.visualstudio.com/subscriptions](https://marketplace.visualstudio.com/subscription).

## See also
- [Visual Studio documentation](https://docs.microsoft.com/visualstudio/)
- [Azure DevOps documentation](https://docs.microsoft.com/azure/devops/)
- [Azure documentation](https://docs.microsoft.com/azure/)
- [Microsoft 365 documentation](https://docs.microsoft.com/microsoft-365/)

## Next steps
Learn more about managing Visual Studio subscriptions.
- [Assign individual subscriptions](assign-license.md)
- [Assign multiple subscriptions](assign-license-bulk.md)
- [Edit subscriptions](edit-license.md)
- [Determine maximum usage](maximum-usage.md)



