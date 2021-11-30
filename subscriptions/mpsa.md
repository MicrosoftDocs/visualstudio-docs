---
title: Visual Studio Subscriptions in MPSA | Microsoft Docs
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: b331c837-3524-42b7-820e-b4fdd5e12793
ms.date: 03/21/2021
ms.topic: conceptual
description:  Learn about managing Visual Studio subscriptions in a Microsoft Products and Services Agreement (MPSA)
---

# Visual Studio subscriptions in a Microsoft Products and Services Agreement (MPSA)
If you have purchased Visual Studio Subscriptions through the MPSA program, there are a few things to be aware of before you can become a Visual Studio subscriptions admin and assign subscriptions to your users. If you have already been set up as an admin, you can go directly to the Visual Studio subscriptions [Administration Portal](https://manage.visualstudio.com/).

MPSA customers manage assets purchased through MPSA in a portal called the [Business Center](https://businessaccount.microsoft.com/Customer), that supports functionalities similar to the Volume Licensing Service Center (VLSC). These include viewing your License Summary, Orders, Downloads, Keys, Users, etc. However, Visual Studio subscriptions in MPSA behave much like Cloud Services. The Business Center also uses work accounts to sign in, instead of Microsoft Accounts (MSA). If your organization uses cloud services such as Office 365 or Azure Active Directory, and your email is part of either of these two services, it is already a work account. This will allow you to register to Business Center with your existing password. If your organization is not using cloud services and your email is not a work account, you may use it to register to the Business Center.

Additionally, the Visual Studio subscriptions [Administration Portal](https://manage.visualstudio.com/) is where you will assign subscriptions after you become a Visual Studio subscriptions admin. In MPSA, Visual Studio subscriptions must be provisioned to their respective management portal, which is the Visual Studio Subscriptions Administration Portal. To do that, you need to associate your Purchasing Account to a tenant (i.e. contoso.onmicrosoft.com).

Note that there are two types of tenants - managed tenants and unmanaged tenants. A managed tenant refers to a tenant that is already being managed by admins within the organization.

An unmanaged tenant is a tenant without any admins assigned and is not usable for Online Services such as Office 365. Unmanaged tenants are also created when registering to the Business Center with an email that is not a work account. If you were asked to create a password when registering to the Business Center, this means your email was not a work account and it created an unmanaged tenant.

Here are a few requirements/steps to become a Visual Studio Subscriptions admin prior to completing the tenant association.

## Pre-tenant association (managed tenant)
- You must be a registered user to the Business Center.
- You must be a User Admin (at minimum) or Global Admin within the tenant that you are part of. (This applies if your company already uses Cloud Services). Either role is needed to be a Visual Studio subscriptions admin.
- You must be a Global Admin in the tenant that you are part of to be able to associate your Purchasing Account to your tenant.
- You must be an Account Admin or Account Manager in Business Center.
- The “Country or Region” field within your user profile (and any other user) in [Azure](https://portal.azure.com/) needs to be populated appropriately depending on your region (i.e. US, CA, etc.). 

> [!NOTE]
> Any users that you want to make Visual Studio subscriptions admins are not required to be users in the Business Center, as they only need to meet criteria 2 and 5.

After you have met the criteria above, you may proceed to associate your Purchasing Account to your tenant following the steps below.
1. Log in to [Business Center](https://businessaccount.microsoft.com/Customer).
2. Click on the **Account** tab and choose **Associate Domains**.
3. Select your **Purchasing Account** (if you have more than one).
4. Select your **tenant** (example: contoso.onmicrosoft.com).
5. Click **Associate Domain**.

Upon association, all users meeting the criteria will typically provision as Visual Studio subscriptions admins within minutes. However, at times it may take up to 24 hours. After your tenant is provisioned, you will be able to access the Visual Studio Subscriptions Administration Portal. If this takes longer than 24 hours,  contact [Business Center support](https://businessaccount.microsoft.com/Customer/ContactUs).

> [!NOTE]
> If there are new users that meet the criteria in steps 2 and 5 (after association) you must contact MPSA Support. MPSA Support will provide assistance to provision the new Visual Studio Subscriptions admins.

## Tenant association (unmanaged)
If you registered to the Business Center with an email that was not a work account (not registered in the Azure Active Directory “Azure AD”), as explained above, the tenant association will be slightly different. You will need to perform what’s called a "domain take-over". During this process you will make yourself the Global Admin which will change your tenant from unmanaged to managed.

For a more detailed explanation for this process, you may use the [Quick Start guides](https://www.microsoft.com/Licensing/existing-customer/business-center-training-and-resources.aspx). Download the guide named *"Setup and Use Your Online Services"* that will guide you through a domain take-over. After this is completed, your Purchasing Account will also be associated to your tenant.

> [!NOTE]
> When you complete the domain take-over process, you must adhere to the criteria from the five steps in the section for Pre Tenant Association (Managed). After the criteria are met, it will only be necessary to contact MPSA Support to provision additional Visual Studio subscriptions admins.

## Support resources
- For assistance with administration of Visual Studio Subscriptions, contact [Visual Studio subscriptions support](https://aka.ms/vsadminhelp).

## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)

## Next steps
Learn more about managing Visual Studio subscriptions.
- [Assign individual subscriptions](assign-license.md)
- [Assign multiple subscriptions](assign-license-bulk.md)
- [Edit subscriptions](edit-license.md)
- [Delete subscriptions](delete-license.md)
- [Determine maximum usage](maximum-usage.md)