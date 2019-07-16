---
title: VLSC Admin Migration FAQs  | Microsoft Docs
author: evanwindom
ms.author: jaunger
manager: evelynp
ms.date: 03/13/2018
ms.topic: conceptual
description: Volume License Service Center Admin Migration FAQs
---
# Visual Studio subscriptions administration migration

Over the next few months, changes are coming to the management of Visual Studio subscriptions (formerly MSDN Subscriptions). Today, you can purchase Visual Studio subscriptions through Volume Licensing and the subscriptions are managed within the Volume License Service Center portal (VLSC). A new management portal is being created and Visual Studio subscriptions will be managed in this new portal in the future. In addition to the existing operations provided by the VLSC, the new portal will allow bulk assignment with no limits, tracking and filtering of subscriptions, and the ability to utilize Azure Active Directory (Azure AD) to manage access. The new Visual Studio Administration Portal will be located at: [https://manage.visualstudio.com](https://manage.visualstudio.com).

> [!Note]
> This migration will not impact MPSA customers.

## Frequently asked questions

### Why is it changing?
The new portal will optimize the experience of Visual Studio subscriptions management and create a single experience managing Visual Studio subscriptions, regardless of how they were purchased. The new portal has a new platform that enables Azure AD and positions us for the future. Additionally, it will have an updated user interface that will be easier to navigate and use, increasing administrator efficiency.

### Who will be impacted?
The change will impact all customers who have active Volume Licensing agreements and have purchased Visual Studio Subscriptions through Volume Licensing.

### When is it changing?
This is a massive transition and will be completed in phases until all customers with active Volume Licensing agreements for Visual Studio Subscriptions are migrated over to the new management portal. The migration began during the first quarter of 2017. We will notify our Volume Licensing customers in advance of their scheduled migration week.

### Does my organization need to sign up for Azure Active Directory (Azure AD)?
Your organization does not need to sign up for Azure AD, but you can do so at any time. If you choose to onboard to Azure AD, you can do so at no cost by using the free tier for Azure AD. With Azure Active Directory, you will be protecting your organization with increased security, control, and long-term reliability. However, if you are not ready for Azure AD, you will be able to continue using your Microsoft Accounts (MSAs) as you do today.

### How do I know when my organization will be migrated?
Primary/Notices Contacts will receive an email from us inviting them to complete the onboarding process one week before your organization is migrated. Subscription Managers will also receive an email letting them know that we’ve contacted the Primary/Notices Contacts and provided details on how to help ensure successful onboarding. Learn how to [locate your organization’s Primary/Notices Contacts](#how-do-i-find-out-who-my-primary-or-notices-contact-is).

### Is onboarding different from migration?
Yes.  There are two phases in this process. Setting up (or onboarding) your organization in advance of migration ensures that there is no interruption in your work as an administrator. Once we migrate your organization’s information, you will then be able to manage Visual Studio subscriptions in the new portal. If the Primary/Notices Contacts don’t onboard before being migrated, the Subscription Managers will be blocked and will not be able to manage subscriptions until you complete the onboarding process.

### What is the onboarding process?
An email is sent to the Primary and Notices Contacts inviting them to complete the onboarding process.
See below for instructions on the process.
1. **Locating your PCN and signing in:**

    a. In the email, the Primary and Notices Contacts are provided with a unique link and the last three digits of their Public Customer Number (PCN).*

    b. In order to obtain the entire PCN, the Primary Contact will need to sign in to the VLSC (instructions for locating the PCN can be found below).

    c. After obtaining the PCN, they’ll need to select their unique link which will prompt them to sign in. They will be able to sign in using either a work/school account (if your organization is on Azure AD) or a Microsoft Account (MSA) if your organization is not on Azure AD.

    d. Next, they will be prompted to enter the PCN.

2. **Set up your administrators:**

    After entering the PCN, they will be taken to the page where they are able to add super admins and administrators (previously known as Subscription Managers). Ideally this should be completed prior to your organization’s migration date so you don’t have any interruption in managing your subscriptions.

3. **Accessing the new subscription management portal:**
    Once your organization is migrated, emails will be sent to the super admins and administrators inviting them to access the new portal and begin managing subscriptions.

> [!NOTE]
> If the Primary or Notices Contacts receive more than one email, this means that they have more than one PCN. They will need to complete the process using the unique link for the PCN referenced in each email.

### What is the difference between a Super Admin and an Administrator?
When the Primary/Notices Contact signs in for the first time, they are automatically set up as a super admin. Super admins can manage administrator access to subscriptions by adding/deleting other super admins or administrators and can also manage subscriptions. The super admin can choose to assign other super admins in addition to themselves.

Administrators (previously known as Subscription Managers) are only able to manage subscriptions but can’t control who has access to managing subscriptions.

### How will I, as an administrator, onboard to the new portal?
Your organization’s Primary Contacts and Notices Contacts will receive an email with a unique  link that will take them to a page that will allow them to sign in using either work or school accounts, backed by Azure Active Directory (Azure AD) or personal MSAs. Once signed in, they will need to enter your organization’s Public Customer Number (PCN) or Authorization Number to verify the agreements. They will then be set up as a super admin able to add other administrators, like you, to manage Visual Studio Subscriptions.

### Where do I manage subscriptions if my organization has been onboarded, but hasn’t been migrated?
You will continue managing subscriptions through the VLSC until you receive the email from Visual Studio Subscriptions that your organization has been migrated and is ready to be managed in the new portal.

### Where can I locate my organization’s Public Customer Number (PCN) or Authorization Number?
Sign in to the [VLSC](https://www.microsoft.com/Licensing/servicecenter/default.aspx) and navigate the following path: **Subscriptions** > **Visual Studio Subscriptions**. The PCN is located below the **Agreement/Public Customer Number Results**. Get step by step guidance on locating your PCN in this [help article](find-pcn.md).

### How do I find out who my Primary or Notices Contact is?
Sign in to the [VLSC](https://www.microsoft.com/Licensing/servicecenter/default.aspx) and navigate the following path: **Licenses > Relationship Summary**  Select your **Licensing ID > Contacts**. Get step by step guidance on finding your Primary or Notices Contact in this [help article](find-primary-contact.md).

### What if my Primary or Notices Contact is gone, no longer with the company or not available to complete onboarding?
You will need to [contact support](https://visualstudio.microsoft.com/subscriptions/support/#talktous) and provide the email that you used in the VLSC for managing subscriptions. Once verified, support will be able to assist you in the onboarding process.

### What will happen with renewing customers?
Renewing customers should continue to renewal their subscriptions as usual, as renewal processes are not impacted by the migration.

### Should my organization wait to set up a new agreement in the new system, rather than renew an existing agreement?
No.  The migration will not impact the creation or renewal of agreements.

### What if my organization’s agreement is in the grace period during the transition? Will they also be migrated?
Yes, if the agreement is still active, your organization will be migrated.

### What if my organization has over claimed in the current system? Will we still be migrated to the new system?
Yes, your organization will still be migrated to the new system. The ability to over claim (for agreement types that allow this) will exist in the new system.

### What if my organization has more than one subscription assigned to a single user/email address?
Your organization will still be migrated.  However, you will not be able to assign any additional subscriptions of the same level (ie: Enterprise, Professional, etc.) to that user/email address. Any subscriptions of the same level that have the same email address upon migration will still be visible, but administrators will need to change the email addresses so that they are unique. You will not be able to assign multiple subscriptions of the same level to a single user/email address in the new portal.

### Where can I find the most up to date information about the migration?
For the most up to date information regarding this migration, please visit our Visual Studio Subscriptions administrator [webpage](https://aka.ms/vs-admin). If you need support, check out the Visual Studio subscriptions [support page](http://visualstudio.microsoft.com/subscriptions/support/#!collections/962-subscriptions), which contains self-help information and support contact information. Over the next few months, we will continue to provide updates on the administrator webpage and via email to help this transition occur with ease.

## Resources and support information
- [Administrator webpage](https://visualstudio.microsoft.com/subscriptions-administration/)

- Visual Studio subscriptions and management [support](https://visualstudio.microsoft.com/subscriptions/support/)

- [How to find my PCN](find-pcn.md)

- [How to find my Primary or Notices Contact](find-primary-contact.md)

- [Video](https://www.youtube.com/watch?v=ZmnywYGSFMg&list=PLReL099Y5nRfDyvvwzNDBaZe7qTxmuM2T&index=1&t=0s) for onboarding your organization and managing administrators
