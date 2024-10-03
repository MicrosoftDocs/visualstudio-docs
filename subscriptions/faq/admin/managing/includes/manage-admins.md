---
title: How do I manage administrators?
description: If you're a Super Admin, you can add or remove other Super Admins or Administrators. Administrators can only add or remove subscribers...
comment:  As of August 2023 this include is used to render marketing FAQ content for VS Subscriptions in the following portals - VSCom, Manage, and My portals. It was not used for learn.microsoft.com content at that time.  SMEs are Jose Becerra and Larissa Crawford of Red Door Collaborative and Angela Cao-Hong.
ms.faqid: group1_2
ms.topic: include
ms.assetid: 11274272-d834-44c7-acdb-09c9ba2f852d
ms.subservice: 
author: joseb-rdc
ms.author: amast
ms.date: 09/19/2024
---

## How do I manage administrators?

If you're a Super Admin, you can add or remove other Super Admins or admins. Administrators can only add or remove subscribers and don't see the Manage Administrators tab in the [Admin Portal](https://manage.visualstudio.com).

To manage administrators:

1. Select the [Manage Administrators](https://manage.visualstudio.com/administrators) tab at the top of the page on [manage.visualstudio.com](https://manage.visualstudio.com).
2. To add:
+ Select Add and type the name and email address of the person you would like to add
+ Select the appropriate agreement from the drop down menu.  
+ Select the language that they should receive their welcome email in. 
+ Select Super Admin.
3. To remove, select the person you would like to remove and select Delete.

Administrators manage Cloud subscriptions in the Azure subscription used to purchase the cloud subscriptions. The owner of the subscription is automatically assigned as the first administrator.

To assign more administrators:

1. Connect to the Azure portal at [portal.azure.com](https://portal.azure.com)
2. Sign in with the account you used to purchase the Visual Studio Cloud subscriptions.
3. In the left navigation pane, scroll down to  Cost Management + Billing.
4. In the My subscriptions  list, choose the Azure subscription that you used to make the purchase.
5. Select Access control, which is located near the top of the list in the left navigation pane.
6. Select the  Add tab at the top of the page.
7. In the fly-out pane on the right, select on the name of the subscriber you wish to make an administrator.
8. Select on the  Role drop-down at the top of the pane, scroll down, and select  User Access Administrator.
9. Select Save.

[Learn more](https://learn.microsoft.com/visualstudio/subscriptions/cloud-admin) about administration of cloud subscriptions.
