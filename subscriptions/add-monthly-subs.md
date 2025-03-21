---
title: Link new monthly subscriptions to Subscriptions Admin Portal
author: joseb-rdc
ms.author: amast
manager: shve
ms.date: 03/20/2025
ms.topic: how-to
description:  Learn how to link newly purchased monthly Visual Studio subscriptions to the Subscriptions Admin Portal.
---
# Link new monthly Visual Studio subscriptions to the Subscriptions Admin Portal

If you're an Azure Admin and already completed the purchase process in the [Marketplace](https://marketplace.visualstudio.com/subscriptions) of new monthly Visual Studio subscriptions using an Azure subscription, you might need to link them into your specific admin group using the Admin Portal. 

## How do I know if I need to link my subscriptions?

The steps to link monthly subscriptions depend on what kinds of subscriptions your organization already has, and whether you're a new admin.
+ If you're a new admin, we check for Azure subscriptions on which you have User Access Administrator rights when you sign in to the Subscriptions Admin portal the first time. If we find monthly subscriptions for you, we link them automatically. 
+ If you linked or administered monthly subscriptions purchased using an Azure subscription, we check for new monthly subscriptions each time you sign in. 
+ If you're already an admin for Volume Licensing subscriptions but **haven't** linked or managed monthly subscriptions, you need to link them using the following steps.

## How to link monthly subscriptions

1. Sign in to the Subscriptions Admin portal at <https://manage.visualstudio.com>.
0. On the **Manage subscribers** tab, choose the **Add agreement** drop-down.
0. Choose **New monthly subscriptions** in the drop-down.
   > [!div class="mx-imgBorder"]
   > ![Add new monthly subscriptions drop-down](_img/add-monthly-subs/add-subs-drop-down.png "Screenshot of Add agreement drop-down. New monthly subscriptions option is highlighted.")

> [!NOTE]
> If the "New monthly subscription(s)" option isn't visible when you select the "Add agreements" drop-down, it indicates that a monthly subscription hasn't been purchased in the marketplace or the monthly subscriptions were automatically linked, allowing for immediate assignment.

4. The system searches for any Azure subscriptions on which you have User Access Administrator rights and imports any Visual Studio subscriptions purchased with those Azure subscriptions.
0. If you don't have User Access Administrator rights on any Azure subscriptions, or no Visual Studio subscriptions are found, you receive the following message:
   > [!div class="mx-imgBorder"]
   > ![No new monthly subscriptions found](_img/add-monthly-subs/no-subs-found.png "Screenshot of Error message indicating that there are no Azure subscriptions or Visual Studio subscriptions are available to you.")
0. If new monthly subscriptions are found, you receive a confirmation message.
   > [!div class="mx-imgBorder"]
   > ![Subscriptions added confirmation message](_img/add-monthly-subs/subs-added-confirmation.png "Screenshot of a message confirming that new monthly subscriptions have been added.")

## Things to keep in mind

+ The option to link new monthly subscriptions is only available the first time you purchase them. After you link monthly subscriptions, we check for new subscriptions each time you sign in to the portal. 
+ When new subscriptions are found, you might see that they're already assigned to subscribers. That behavior is because there are other admins with access to the Azure subscription, and they assigned the new Visual Studio subscriptions to users. Now that you linked them to your portal, you can administer those subscriptions. 

## Support resources

For assistance with administration of Visual Studio Subscriptions, contact [Visual Studio subscriptions support](https://aka.ms/vsadminhelp).

## Next steps

Now that you linked subscriptions, you're ready to assign them to users. You can do that in several ways:
+ [Assign subscriptions individually](assign-license.md)
+ [Assign subscriptions to multiple users](assign-license-bulk.md)
+ [Assign specific subscriptions to specific users](assign-guid.md)

## See also

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps Services documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)