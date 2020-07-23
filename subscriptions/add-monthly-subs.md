---
title: Add new monthly Visual Studio subscriptions to Subscriptions Administration Portal | Microsoft Docs
author: evanwindom
ms.author: cabuschl
manager: cabuschl
ms.assetid: 36f0d9f1-fe28-469f-a54c-dc46638270a8
ms.date: 06/23/2020
ms.topic: how-to
description:  Learn how to newly purchased monthly Visual Studio subscriptions to the Subscriptions Administration Portal
---
# Add new monthly Visual Studio subscriptions to the Subscriptions Administration Portal
When you purchase new monthly Visual Studio subscriptions using an Azure subscription, you may need to add them to the Subscriptions Administration Portal in order to assign them to users.  

## How do I know if I need to add my subscriptions?
The steps to add monthly subscriptions depend on what kinds of subscriptions your organization already has, and whether you're a new administrator.
- If you're a new administrator, we'll check for Azure subscriptions on which you have User Access Administrator rights when you sign in to the Subscriptions Administration Portal the first time.  If we find monthly subscriptions for you, we'll add them automatically. 
- If you have previously added or administered monthly subscriptions, we check for new monthly subscriptions each time you sign in. 
- If you are already an administrator for subscriptions acquired through Volume Licensing but haven't previously added or managed monthly subscriptions, you will need to add them using the steps provided below.

## How to add monthly subscriptions
1. Sign in to the Subscriptions Administration Portal at <https://manage.visualstudio.com>
1. On the **Manage subscribers** tab, choose the **New agreement** drop-down 
1. Choose **New monthly subscriptions** in the drop-down
   > [!div class="mx-imgBorder"]
   > ![Add new monthly subscriptions drop-down](_img/add-monthly-subs/add-subs-drop-down.png)
1. The system will search for any Azure subscriptions on which you have User Access Administrator rights, and will import any Visual Studio subscriptions purchased with those Azure subscriptions.
1. If no Azure subscriptions on which you have User Access Administrator rights are found, or qualifying Azure subscriptions are found but no Visual Studio subscriptions are found, you will receive the following message:
   > [!div class="mx-imgBorder"]
   > ![No new monthly subscriptions found](_img/add-monthly-subs/no-subs-found.png)
1. If new monthly subscriptions are found, you will receive a confirmation message
   > [!div class="mx-imgBorder"]
   > ![Subscriptions added confirmation message](_img/add-monthly-subs/subs-added-confirmation.png)

## Things to keep in mind
- The option to add new monthly subscriptions will only be available the first time you purchase them.  Once you've added monthly subscriptions, we will check for new subscriptions each time you sign in to the portal. 
- When new subscriptions are found, you may see that they are already assigned to subscribers.  That's because there are other administrators with access to the Azure subscription, and they have already assigned the new Visual Studio subscriptions to users.  Now that you have also added them to your portal, you can administer those subscriptions. 

## Next steps
Now that you've added subscriptions, you're ready to assign them to users.  You can do that in several ways:
- [Assign subscriptions individually](assign-license.md)
- [Assign subscriptions to multiple users](assign-license-bulk.md)
- [Assign specific subscriptions to specific users](assign-guid.md)

## See also
- [Visual Studio documentation](https://docs.microsoft.com/visualstudio/)
- [Azure DevOps documentation](https://docs.microsoft.com/azure/devops/)
- [Azure documentation](https://docs.microsoft.com/azure/)
- [Microsoft 365 documentation](https://docs.microsoft.com/microsoft-365/)
