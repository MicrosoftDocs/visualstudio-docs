---
title: Issues signing in to Visual Studio subscriptions
author: evanwindom
ms.author: amast
manager: shve
ms.date: 03/06/2024
ms.topic: conceptual
description: Review potential sign-in issues for Visual Studio subscriptions, including Microsoft Accounts (MSA) limitations, failures due to aliases or deleted addresses.
---

# Issues signing in to Visual Studio subscriptions

To use your Visual Studio subscription, you must first sign in. Depending on your subscription, you might have either a Microsoft account (MSA) or a Microsoft Entra identity. This article discusses some of the issues you might encounter while signing in to your subscription.

## Microsoft Accounts (MSA) can't be created using work/school email addresses

Creating a new personal Microsoft Account (MSA) using a work/school email address is no longer allowed when the email domain is configured in Microsoft Entra ID. What does this mean? If your organization uses Microsoft 365 or other business services from Microsoft that rely on Microsoft Entra ID, and if you added a domain name to your Microsoft Entra tenant, users are no longer able to create a new personal Microsoft account using an email address in your domain.

### Why was this change made?

Having a personal Microsoft Account with a work address as a username is fraught with issues for end-users and IT departments alike. For example:
+ Users might think that their personal Microsoft account is business-compliant and that they're in compliance when they save business document to their OneDrive
+ Users who leave an organization generally lose access to their work email address. When they do, they might not be able to get back into their personal Microsoft account if they forget their password. Conversely, their IT department could reset their password and get into the personal account of former employees.
+ IT departments have a false sense of account ownership and security. But users only need to roundtrip a code to their work email address once, and can rename their account at any time in the future.

The situation is confusing for users who have two accounts with the same email address (one in Microsoft Entra ID & one Microsoft account).

### What does the experience look like?

If you try to sign up for a Microsoft consumer app with a work or school email address, you see this message:

   > [!div class="mx-imgBorder"]
   > ![Can't create an account with work email](_img/sign-in-issues/cannot-use-work-email.png "Screenshot of the Create account dialog showing the error message.")

However, if you try to sign up for a Microsoft app that supports personal and work/school accounts, you should see this message:

   > [!div class="mx-imgBorder"]
   > ![Work/school accounts supported](_img/sign-in-issues/existing-account.png "Screenshot showing the error message for existing work accounts.")

### Are existing accounts affected?

The sign-up block described here only prevents the creation of new accounts. It has no effect on users who already have a Microsoft Account with a work/school email address. If you're already in this situation, we make it easier to rename a personal Microsoft account. This [support article](https://windows.microsoft.com/Windows/rename-personal-microsoft-account) provides simple step-by-step guidance. Renaming your personal Microsoft account involves changing the username, and doesn't affect your work email or how you sign in to business services such as Microsoft 365. It also doesn't affect your personal stuff—it just changes the way you sign in to it. You can use another (personal) email address, get a new @outlook.com email address from Microsoft, or use your phone number as a new username.

> [!NOTE]
> If your IT department asked you to create a personal Microsoft account with your work/school email, for example to access Microsoft business services like Premier Support, then talk to your admin team before renaming your account.

## Signing in fails when using GCC High tenants

Visual Studio [subscription portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs) and [admin portal](https://manage.visualstudio.com) don't support [GCC High tenants](https://learn.microsoft.com/office365/servicedescriptions/office-365-platform-service-description/office-365-us-government/gcc-high-and-dod), also known as private or government domains. This limitation also applies to subscribers attempting to sign into the Visual Studio IDE. To access Visual Studio subscriptions, your organization needs to have a public tenant. For further assistance creating a public tenant, contact [Azure support](https://azure.microsoft.com/support/create-ticket/). 

## Deleting a sign-in address can prevent access to a subscription

If you delete one or more identities (MSA or Microsoft Entra ID) associated with your subscription, your subscriber information including your user name and sign-in ID might be rendered anonymous. "Anonymization" results in the loss of access to your subscription.

To avoid impacts to your subscription access, use one of these techniques.
+ Deploy a single identity management system--either MSA or Microsoft Entra ID--but not both.
+ Associate the Microsoft Entra ID and MSA identities via the tenant.

## Signing in can fail when using aliases

Depending on the account type used to sign in, available subscriptions might not be correctly displayed when signing in to [https://my.visualstudio.com](https://my.visualstudio.com?wt.mc_id=o~msft~docs). One potential cause is the use of "aliases" or "friendly names" in place of the sign-in identity to which the subscription is assigned. This technique is called "aliasing."

### What is aliasing?

The term “aliasing” refers to users having different identities to sign in to Windows (or your Active Directory) and to access email.

Aliasing can be encountered when a company has a Microsoft Online Service for their directory sign-in but users access their email accounts using aliases or friendly names. For example, a user's work email name might be `johnd@contoso.com`, but they might use `John.Doe@contoso.com`. For many customers who manage their subscriptions through the Volume Licensing Service Center (VLSC), sign-in fails. The sign-in email address must match the one listed in the "Work or School Account" option.

### What options do I have?

From a subscriber perspective, it's important to first work with your admin to understand your company’s identity configuration. If necessary, your admin might have to update your account settings from their admin portal, or you might need to create a Microsoft Account (MSA) using your corporate email address. Before taking the steps to create an MSA, speak with your admin regarding any policies or issues with taking this action.

## Resources

For assistance with sales, subscriptions, accounts, and billing for Visual Studio Subscriptions, see Visual Studio [Subscriptions support](https://aka.ms/vssubscriberhelp). 

## See also

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps Services documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)

## Next steps

+ Learn more about [anonymization](anonymization.md).
