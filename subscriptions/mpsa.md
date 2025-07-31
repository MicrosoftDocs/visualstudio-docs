---
title: Visual Studio Subscriptions in MPSA
author: joseb-rdc
ms.author: amast
manager: shve
ms.date: 09/16/2024
ms.topic: conceptual
description: Manage Visual Studio subscriptions in a Microsoft Products and Services Agreement (MPSA), and review configuration differences between managed and unmanaged tenants.
ms.custom: sfi-ga-nochange
---

# Visual Studio subscriptions in a Microsoft Products and Services Agreement (MPSA)

If you purchase Visual Studio Subscriptions through the MPSA program, there are a few things to be aware of before you can become a Visual Studio subscriptions admin and assign subscriptions to your users. If you're already an admin, you can go directly to the Visual Studio subscriptions [Admin Portal](https://manage.visualstudio.com/).

MPSA customers manage assets purchased through MPSA in a portal called the [Business Center](https://businessaccount.microsoft.com/Customer) (Similar to how the Volume Licensing Service Center (VLSC) is used to manage volume licensing assets). In the Business Center, MPSA customers can view their License Summary, Orders, Downloads, Keys, Users, etc. However, there are some key differences between VLSC and MPSA subscriptions. The Business Center uses work accounts to sign in, instead of Microsoft Accounts (MSA). If you access services like Microsoft Entra ID or Office 365, your email is already a work account. You can register for access to Business Center with your business email and password combination, like other cloud services.  If your organization isn't using cloud services and your email isn't a work account, you can use a different email to register for access to the Business Center and create a password at the time of registration.

The Visual Studio subscriptions [Admin Portal](https://manage.visualstudio.com/) is where you'll assign subscriptions after you become a Visual Studio subscriptions admin. Visual Studio subscriptions purchased through MPSA must be provisioned in the Visual Studio Subscriptions Admin Portal by an admin. To do that, your Purchasing Account must be associated with a tenant (example: `contoso.onmicrosoft.com`).

There are two types of tenants - managed tenants and unmanaged tenants. A managed tenant refers to a tenant that admins within the organization managed.

An unmanaged tenant doesn't have admins assigned and isn't usable for Online Services such as Office 365. Unmanaged tenants are created when registering to the Business Center with an email that isn't a work account. If you were prompted to create a password when you registered for Business Center access, the email you used wasn't a work account. This condition is how an unmanaged tenant can be created.

Prerequisites to become a Visual Studio subscriptions admin:

## Managed tenant

Follow these steps to set up a managed tenant:

1. The Purchasing Account must be associated with your company domain/tenant. The association is performed in the Business Center Portal. 
To associate your account, you must
   + Be a registered user in the Business Center Portal with an Account Administrator or Account Manager role
   + Be a Global Administrator (Company Administrator) or a Billing Administrator in the tenant to which you'd like to link your Purchasing Account.

   After you ensure you have these roles assigned to the same work account, follow the below steps to perform the association:

   1. Sign in to Business Center.
   2. Select the **Account** tab and choose **Associate Domains**.
   3. Select your **Purchasing Account** (if you have more than one).
   4. Select your **tenant** (example: `contoso.onmicrosoft.com`).
   5. Select Associate Domain.

   For a more detailed explanation of this process, use the Quick Start guides. Download the guide named "Set up and Use Your Online Services."

   If you're experiencing issues with the domain association or would like more guidance, Business Center support can assist.

2. After the Purchasing Account is associated with your domain, you must be a User Admin (at minimum) or Global Admin within the tenant that you’re part of to administer Visual Studio subscriptions on the Visual Studio Subscriptions Admin Portal. Ensure that the “Country or Region” and “Postal code” fields within your Azure user profile are populated appropriately depending on your region (such as: US, CA, etc.). After the domain association, if you have the correct permissions listed above you'll be able to access the Visual Studio Subscriptions Admin Portal within 24 hours. If you don't have access after 24 hours, contact Business Center support.

> [!NOTE]
> Granting BCP users permissions to view licenses, including Visual Studio Subscription licenses, in Business Center, is completely separate from granting users permissions on the Visual Studio Subscriptions Admin Portal.

Similarly, having admin permissions on the Visual Studio Subscriptions Admin portal doesn't mean that the VSS Admin can view the licenses in Business Center.

## Unmanaged tenant

If you registered to the Business Center with an email that wasn't a work account (not registered in the Microsoft Entra ID), as explained previously, the tenant association is slightly different. You need to perform a "domain take-over." During this process, you make yourself the Global Administrator (Company Administrator) which changes your tenant from "unmanaged" to "managed."

For a more detailed explanation for this process, you can use the Quick Start guides. Download the guide named "Setup and Use Your Online Services" for steps to perform a domain take-over (pg. 7-8).

After you complete the domain take-over process, you must adhere to the two criteria from section “Managed Tenant” to administer Visual Studio subscriptions on the Visual Studio Subscriptions Admin Portal. In you encounter problems, contact Business Center support.

## Support resources

For assistance with administration of Visual Studio Subscriptions, contact [Visual Studio subscriptions support](https://aka.ms/vsadminhelp).

## See also

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)

## Next steps

Learn more about managing Visual Studio subscriptions.
+ [Assign individual subscriptions](assign-license.md)
+ [Assign multiple subscriptions](assign-license-bulk.md)
+ [Edit subscriptions](edit-license.md)
+ [Delete subscriptions](delete-license.md)
+ [Determine maximum usage](maximum-usage.md)