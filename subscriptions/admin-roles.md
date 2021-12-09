---
title:  Super admin and admin roles for Visual Studio subscriptions
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: 6601c395-f778-48c1-ab76-cf454b9193e4
ms.date: 03/19/2021
ms.topic: conceptual
description: Learn about the super admin and admin roles, and how to assign admins. 
---

# Super admins and admins for Visual Studio subscription agreements

There are two different roles in the new Visual Studio Subscriptions Administration Portal for Volume Licensing customers. These roles are like the Primary/Notices Contact role and the Subscriptions Manager role that used to exist in the VLSC.

**Super admins:** When an organization is initially set up, the Primary or Notices Contact becomes a super admin by default. The Primary or Notices Contact can choose to assign additional super admins or admins. A super admin can add and remove other admins as well as subscribers. If there are more than two super admins in the system, a super-admin can delete all but the last two for security.

**Admins:** An admin can only be assigned by a super admin. An admin can only manage subscribers in the agreements that the super admin assigns to them.

Watch a demonstration about how to manage admins. 
> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4th6L]

## Assigning admins
To assign new admins (admins):
1. Sign in to https://manage.visualstudio.com using an email address that's assigned as a super admin on the agreement through which the subscriptions were purchased.
2. Click on the tab labeled **Manage Administrators**.
3. Click **Add**.
   > [!div class="mx-imgBorder"]
   > ![Add admins](_img/admin-roles/add-admins.png "Click the Manage Administrators blade, then click Add to assign new admins.")
4. Complete the form with the new admin's information.  
   > [!div class="mx-imgBorder"]
   > ![Add admin form](_img/admin-roles/add-form.png "Enter the sign-in information for the new admin, and choose whether to make them a super admin.  Then click Add.")

   > [!NOTE]
   > If you want this admin to be able to assign additional admins, remember to check the **Super Admin** box.

5. After you click **Add** to assign the new admin, they will receive an email inviting them to sign in to the portal.  

## Resources
- [Visual Studio administration and subscriptions support](https://aka.ms/vsadminhelp)

## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)

## Next steps
- Learn how to [assign subscriptions](assign-license.md)
- Learn more about the full range of [subscription benefits](https://visualstudio.microsoft.com/vs/benefits/)
- [Set agreement preferences](admin-preferences.md)