---
title: Use super admin and admin roles for subscriptions
author: joseb-rdc
ms.author: amast
manager: shve
ms.date: 01/28/2025
ms.topic: conceptual
description: Review the responsibilities and roles for super admins and admins of Visual Studio subscriptions and how to assign admins. 
---

# Super admins and admins for Visual Studio subscription agreements

There are two different roles in the new Visual Studio Subscriptions Admin Portal for Volume Licensing customers, similar to the Primary/Notices Contact and Subscriptions Manager roles that previously existed in the Volume Licensing Service Center (VLSC).

**Super admins:** When an organization is initially set up, the Primary or Notices Contact becomes a super admin by default. The Primary or Notices Contact can choose to assign more super admins or admins. A super admin can add and remove other admins and subscribers. If there are more than two super admins in the system, a super-admin can delete all but the last two for security. In addition to naming admins and managing subscribers, super admins can set global preferences for agreements.

**Admins:** Only super admins can assign new admins and add them to agreements. An admin can only manage subscribers in the agreements that the super admin assigns to them.

Watch a demonstration about how to manage admins. 
> [!VIDEO https://medius.microsoft.com/Embed/video-nc/b2a63234-a82a-402b-a729-8e1259bc12fd?r=484038674989]

## Assigning admins

To assign new admins:
1. Sign in to https://manage.visualstudio.com using an email address that is listed as a super admin on the agreement through which the subscriptions were purchased.
0. Select the tab labeled **Manage Administrators**.
0. Select **Add**.
   > [!div class="mx-imgBorder"]
   > ![Add admins](_img/admin-roles/add-admins.png "Screenshot of the management portal. Manage admins and add menu items are highlighted.")
0. Complete the form with the new admin's information.
   > [!div class="mx-imgBorder"]
   > ![Add admin form](_img/admin-roles/add-form.png "Screenshot of the Add Admin dialog. Super admin checkbox is highlighted.")

   > [!NOTE]
   > If you want this admin to be able to assign additional admins, remember to check the **Super Admin** box.

0. After you select **Add** to assign the new admin, they'll receive an email inviting them to sign in to the portal.

## Resources

[Visual Studio administration and subscriptions support.](https://aka.ms/vsadminhelp)

## See also

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)

## Next steps

+ Learn how to [assign subscriptions](assign-license.md)
+ Learn more about the full range of [subscription benefits](https://visualstudio.microsoft.com/vs/benefits/)
+ [Set agreement preferences](admin-preferences.md)
