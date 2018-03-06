---
title: Managing Administrator Rights in the Visual Studio Subscriptions Administrator Portal
Author: evanwindom
Ms.author: jaunger
Manager: evelynp
Ms.date: 1/19/2018
Ms.topic: Get-Started-Article
Description:  Learn how manage admins & super admins in the Visual Studio Subscriptions Administrator Portal.
Ms.prod: vs-subscription
Ms.technology: vs-subscriptions
Searchscope: VS Subscription
---

# Managing Administrator Rights in the Visual Studio Subscriptions Administrator Portal

## Overview 
In the Visual Studio Subscriptions Administrator Portal (https://manage.visualstudio.com), there are two management roles:

**Super Admins:**  Upon first setting up an organization, the Primary or Notices Contact becomes a super admin by default. The Primary or Notices contact can choose to assign additional super admins or administrators. In addition to managing subscriptions for individual subscribers, super admins can add and remove other administrators and super admins. If there are more than two super admins in the system, a super admin can delete all but the last two for security. 

**Administrators:** An administrator can manage subscribers in the agreements that the super admin assigns to them.  They can assign subscriptions to individuals, edit subscriptions, and reassign or remove them.   (Administrators are appointed by Super Admins.)  

## Adding an administrator **with** Super Admin rights:

1. Sign in to the Visual Studio Subscriptions [Administrator Portal](https://manage.visualstudio.com) using an account that already has super admin rights.

2. Click on the **Manage Administrators** tab at the top of the page. (Only Super Admins have access to this tab.  Administrators without super admin rights use the **Manage Subscribers** tab to manage individual subscribers.)

3. Click **Add** to create a new administrator. 

4. Fill in all requested details in the Add Administrator pop-up window.
  - If your organization has already enrolled in the Azure Active Directory (AAD), start typing the name in the **Name** field, and select the correct item on the dropdown list. With new users, type the full name and ignore the *No identities found* notification.
  - Once the correct user has been identified, the Sign-in Email Address field will be automatically populated. Type the new admin's email address, if not already provided.

5. Select the **PCN** you'd like the new admin to manage, by clicking on the dropdown list under **Agreements**. If the PCN you are onboarding has more than one agreement under it, you can provide your administrator with access to any or all of the agreements. 

**More on agreements:** The dropdown functionality under Agreements is disabled when there is only one agreement available.  All Agreements are automatically checked when the user you’re configuring is granted Super Admin rights.

6. Click the **Super Admin** box to enable super admin rights for this administrator.  

7. To finish adding this administrator, click **Add**.

**Potential error received while adding Admins:** Some users may receive an error message when trying to add the administrator. This is likely to occur if the super admin’s email address that is being added is not listed in the company's AAD. To finish adding the new administrator, simply ignore the error, and click **Add** again. 

8. Once a super admin has been created, you'll see them in the list of administrators, and their account will be marked with a green check mark to indicate their super admin status. 

### Optional:  Add a different notification email.
If your organization has a different address/ account for receiving emails, you now have an option to enter a "Communication" address. Select **Add a different notification email for receiving communication**. 

*Example:*
 Rene uses rene@contoso.com when he signs in using his company credentials.  However, Rene's company only uses that address to manage directory access.  When sending and receiving emails, Rene uses rene.collado@contoso.com, so his Super Admin has entered a second address to ensure he receives the welcome mails.  If your company is not configured in this way, then simply entering the Sign-in Email Address should be sufficient.

## Adding an administrator **without** Super Admin rights:

The same process as described above should be followed in order to add administrators without Super Admin rights, but taking into account the following aspects:
-  When adding Administrators without Super Admin rights, there is no need for an additional email address to be added, and the Super Admin checkbox remains blank.
-  Users without Super Admin rights do not receive the Green Check icon in her profile configuration entry under "Manage Administrators".
