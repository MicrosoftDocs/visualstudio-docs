---
title:  Super admin and administrator roles in the Administration Portal
author: evanwindom
ms.author: lank
manager: lank
ms.date: 08/21/2019
ms.topic: conceptual
description: Learn about the super admin and administrator roles, and how to assign administrators. 
---

# Super admins and administrators for Visual Studio subscription agreements

There are two different roles in the new Visual Studio Subscriptions Administration Portal for Volume Licensing customers. These roles are like the Primary/Notices Contact role and the Subscriptions Manager role that used to exist in the VLSC.

**Super admins:** When an organization is initially set up, the Primary or Notices Contact becomes a super admin by default. The Primary or Notices Contact can choose to assign additional super admins or administrators. A super admin can add and remove other administrators as well as subscribers. If there are more than two super admins in the system, a super-admin can delete all but the last two for security.

**Administrators:** An administrator can only be assigned by a super admin. An administrator can only manage subscribers in the agreements that the super admin assigns to them.

## Assigning administrators
To assign new administrators (admins):
1. Sign in to https://manage.visualstudio.com using an email address that's assigned as a super admin on the agreement through which the subscriptions were purchased.
2. Click on the tab labeled **Manage Administrators**.
3. Click **Add**.
   > [!div class="mx-imgBorder"]
   > ![Add administrators](_img/admin-roles/add-admins.png)
4. Complete the form with the new admin's information.  
   > [!div class="mx-imgBorder"]
   > ![Add administrator form](_img/admin-roles/add-form.png)

   > [!NOTE]
   > If you want this admin to be able to assign additional admins, remember to check the **Super Admin** box.

5. After you click **Add** to assign the new admin, they will receive an email inviting them to sign in to the portal.  

## Resources
- [Visual Studio Administration and Subscriptions Support](https://visualstudio.microsoft.com/support/support-overview-vs)

## Next steps
- Learn how to [assign subscriptions](assign-license.md)
- Learn more about the full range of [subscription benefits](https://visualstudio.microsoft.com/vs/benefits/)
- [Set agreement preferences](admin-prefs.md) 


