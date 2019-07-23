---
title: Visual Studio Subscriptions in a Microsoft Products and Services Agreement (MPSA)| Microsoft Docs
author: evanwindom
ms.author: lank
manager: lank
ms.date: 07/23/2019
ms.topic: conceptual
description:  Visual Studio Subscriptions in a Microsoft Products and Services Agreement (MPSA)
---

# Visual Studio subscriptions in a Microsoft Products and Services Agreement (MPSA)
If you have purchased Visual Studio Subscriptions through the MPSA program, there are a few things to be aware of before you can become a Visual Studio subscriptions administrator and assign subscriptions to your users. If you have already been set up as an administrator, you can go directly to the Visual Studio subscriptions [Administration Portal](https://manage.visualstudio.com/).

MPSA customers now manage assets purchased through MPSA in a new portal  called the [Business Center](https://businessaccount.microsoft.com/), which supports functionalities similar to the Volume Licensing Service Center (VLSC). These include viewing your License Summary, Orders, Downloads, Keys, Users, etc. However, Visual Studio subscriptions in MPSA behave much like Cloud Services. The Business Center also uses work accounts to sign in, instead of Microsoft Accounts (MSA). If your organization uses cloud services such as Office 365 or Azure Active Directory, and your email is part of either of these two services, it is already a work account. This will allow you to register to Business Center with your existing password. If your organization is not using cloud services and your email is not a work account, you may use it to register to the Business Center.

In addition, the Visual Studio subscriptions [Administration Portal](https://manage.visualstudio.com/) is where the subscriptions will be assigned to subscribers once you become a Visual Studio subscriptions administrator. In MPSA, Visual Studio subscriptions must be provisioned to its respective management portal, which is the Visual Studio Subscriptions Administration Portal. To do that, you need to associate your Purchasing Account to a tenant (i.e. contoso.onmicrosoft.com).

Please note that there are two types of tenants (a managed tenant and an unmanaged tenant). A managed tenant refers to a tenant that is already being managed by the organization as administrators within.

An unmanaged tenant is a tenant without any administrators within and is not usable for Online Services such as Office 365. Unmanaged tenants are also created when registering to the Business Center with an email that is not a Work Account. If you were asked to create a password when registering to the Business Center, then this means that your email was not a Work Account and it created an unmanaged tenant.

Prior to completing the tenant association here are a few requirements/steps needed to become a Visual Studio Subscriptions administrator.

## Pre-tenant association (managed tenant)

- You must be a registered user to the Business Center.
- You must be a User Admin (at minimum) or Global Admin within the tenant that you are part of. (This applies if your company already uses Cloud Services). Either role is needed to be a Visual Studio subscriptions administrator.
- You must be a Global Admin in the tenant that you are part of to be able to associate your Purchasing Account to your tenant.
- You must be an Account Admin or Account Manager in Business Center.
- The “Country or Region” field within your user profile (and any other user) in [Azure](https://portal.azure.com/) needs to be populated appropriately depending on your region (i.e. US, CA, etc.). 

> [!NOTE]
> Any users that you want to make Visual Studio subscriptions administrators are not required to be users in the Business Center, as they only need to meet the criteria in steps 2 and 5.

Once you have met the criteria in the 5 steps above you may proceed to associate your Purchasing Account to your tenant following the steps below.
1. Log in to [Business Center](https://businessaccount.microsoft.com/).
2. Click on the **Account** tab and choose **Associate Domains**.
3. Select your **Purchasing Account** (if you have more than one).
4. Select your **tenant** (i.e. contoso.onmicrosoft.com).
5. Click **Associate Domain**.

Upon association, all users meeting  the needed criteria will typically provision as Visual Studio subscriptions administrators within minutes. However, at times it may take up to 24 hours. Once you provision you will be able to access the Visual Studio Subscriptions Administration Portal. If this takes longer than 24 hours, please contact MPSA Support.

> [!NOTE]
> If there are new users that have met  the criteria in steps 2 and 5 (after association) you must contact MPSA Support. MPSA Support will provide assistance to provision the new Visual Studio Subscriptions administrators.

## Tenant association (unmanaged)

If you registered to the Business Center with an email that was not a Work Account (not registered in the Azure Active Directory “Azure AD”), as explained in paragraph five above, the tenant association will be slightly different. You will need to perform what’s called a "domain take-over". During this process you will make yourself the Global Admin which will change your tenant from unmanaged to managed.

For a more detailed explanation for this process, you may use the [Quick Start guides](https://www.microsoft.com/en-us/Licensing/existing-customer/business-center-training-and-resources.aspx). Please download the guide named *"Setup and Use Your Online Services"* which will guide you through a domain take-over. Once this is completed your Purchasing Account will also be associated to your tenant.

> [!NOTE]
> Once you complete the domain take-over process, you must adhere to the criteria from the five steps in the section for Pre Tenant Association (Managed). Once the criteria are met, it will only be necessary to contact MPSA Support to provision additional Visual Studio subscriptions administrators.

You may contact support via phone or email if you require assistance or have any questions.

MPSA Support: **1-866-200-9611**,  available Monday-Friday 5:30 AM to 5:30 PM Pacific Time

Online:  https://support.microsoft.com/supportrequestform/2afa6f15-b710-db46-909a-8346017c802f?sl=enampsc=US
