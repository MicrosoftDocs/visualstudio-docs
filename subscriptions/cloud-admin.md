---
title: Setting Up Administrators for Cloud Subscriptions | Microsoft Docs
author: evanwindom
ms.author: jaunger
manager: lank
ms.date: 07/17/2019
ms.topic: conceptual
description: Setting Up Administrators for Cloud Subscriptions
---
# Set up administrators for Visual Studio Cloud subscriptions

Visual Studio Cloud subscriptions are managed by administrators. These individuals can assign subscriptions, edit assignments, add or delete subscriptions, and perform other subscription management tasks.

## The Azure subscription owner is the first administrator

When you purchase Visual Studio Cloud subscriptions, as the owner of the Azure subscription used to make the purchases, you are automatically set up as an administrator for those subscriptions.

You can purchase cloud subscriptions through the [Visual Studio Marketplace](https://marketplace.visualstudio.com/subscriptions), or by contacting a Cloud Solution Provider. If you purchase through the Visual Studio Marketplace, at the end of the purchase experience, you'll be provided with an opportunity to manage users. Choosing that option will take you to the Visual Studio subscriptions Administration Portal - [https://manage.visualstudio.com](https://manage.visualstudio.com).

Once you've purchased subscriptions, you can visit the [Administration Portal](https://manage.visualstudio.com) at any time. Just sign in to the portal, and select the appropriate Azure subscription in the upper left and corner.

As the owner of the Azure subscription used to purchase the cloud subscriptions, you can also assign additional administrators.

## Add administrators

To add administrators:

1. Connect to the Azure Portal at [portal.azure.com](https://portal.azure.com).
2. Sign in with the account you used to purchase the Visual Studio Cloud subscriptions.
3. In the left navigation pane, scroll down to **Cost Management + Billing**.
4. In the **My subscriptions** list, choose the Azure subscription that you used to make the purchase.
5. Click **Access control**, which is located near the top of the list in the left navigation pane.
6. Click the **Add** tab at the top of the page.
7. Click **Add role assignment**.
8. In the fly-out pane on the right, click on the **Role** drop-down at the top of the pane, scroll down, and select **User Access Administrator**.
9. In the list of users, scroll down to the user you wish to make an admin, and select them. 
10. Click **Save**.
11. Click on the **Role assignments** tab to verify that the user you selected now appears as a User Access Administrator.

The new administrator can now sign in to the [Administration Portal](https://manage.visualstudio.com), select the same Azure subscription that was used to purchase the cloud subscriptions from the list in the upper left corner of the page, and begin to manage those subscriptions.

> [!NOTE]
> If you see users with access to edit your cloud subscriptions that you didn't establish as administrators, they may have roles in the underlying Azure subscription that allow them to manage subscriptions. Those roles include: owner, contributor, service admin, or co-admin. For more information, visit [Add billing managers](/azure/devops/organizations/billing/add-backup-billing-managers?view=vsts).

For information about Visual Studio Cloud subscriptions, see the [Overview](vscloud-overview.md) under Buying  subscriptions. To purchase Visual Studio Cloud subscriptions, visit the Visual Studio Marketplace at [https://marketplace.visualstudio.com/subscriptions](https://marketplace.visualstudio.com/subscription).
