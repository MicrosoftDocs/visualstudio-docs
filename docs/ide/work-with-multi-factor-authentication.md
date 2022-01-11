---
title: Multi-factor authentication with Visual Studio sign-ins
titleSuffix: "" 
ms.date: 05/27/2020
ms.custom: SEO-VS-2020
ms.topic: how-to
description: "Learn how to use Visual Studio with accounts that require multi-factor authentication."
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: ">=vs-2019"
---

# Use Visual Studio with accounts that require multi-factor authentication (MFA)

When collaborating with external guest users, it's a good idea to protect your apps and data with **conditional access (CA)** policies such as **multi-factor authentication (MFA)**.  

Once enabled, guest users will need more than just a username and password to access your resources, and must satisfy additional security requirements. MFA policies can be enforced at the tenant, app, or individual guest user level, the same way that they are enabled for members of your own organization. 

## How is the Visual Studio experience affected by MFA policies?
Versions of Visual Studio prior to 16.6 may have degraded authentication experiences when used with accounts that have enabled CA policies such as MFA, and are associated with two or more tenants.

These issues can cause your instance of Visual Studio to prompt reauthentication multiple times per day. You may have to reenter your credentials for previously authenticated tenants, even during the course of the same Visual Studio session.

## Using Visual Studio with MFA policies
In the 16.6 release, we added new capabilities to Visual Studio 2019 that streamline how users can access resources secured via CA policies such as MFA. To use this enhanced workflow, you'll need to opt into using your system's default web browser as the mechanism to add and reauthenticate Visual Studio accounts.  

> [!WARNING]
> Not using this workflow could trigger a degraded experience resulting in multiple additional authentication prompts when adding or reauthenticating Visual Studio accounts. 

### Enabling system web browser

> [!NOTE] 
> For the best experience, we recommend that you clear your system’s default web browser data before proceeding with this workflow. Additionally, if you have Work or School accounts in your Windows 10 Settings under **Access work or school**, please verify that they are properly authenticated.

To enable this workflow, go to Visual Studio's Options dialog **(Tools > Options…)**, select the **Accounts** tab and pick **System web browser** under the **Add and reauthenticate accounts using:** dropdown. 

:::image type="content" source="media/select-system-web-browser.png" alt-text="Select system web browser from the menu.":::

### Sign into additional accounts with MFA policies 
Once the system web browser workflow is enabled, you can sign in or add accounts to Visual Studio as you normally would, via the Account Settings dialog **(File > Account Settings…)**.   
</br>
:::image type="content" source="media/add-personalization-account.png" alt-text="Add a new personalization account to Visual Studio." border="false":::

This action will open your system's default web browser, ask you to sign into your account, and validate any required MFA policy.

During the sign in process, you may receive an additional prompt asking you to stay signed in. This prompt will likely show up the second time an account is used to sign in. To minimize the need to re-enter your credentials, we recommend that you select **Yes**, as this ensures your credentials are preserved across browser sessions.

:::image type="content" source="media/kmsi.png" alt-text="Stay signed in?":::

Based on your development activities and resource configuration, you may still be prompted to reenter your credentials during your session. This can occur when you add a new resource, or try accessing a resource without having previously met its CA/MFA authorization requirements.

## Reauthenticating an account  
If there's a problem with your account, Visual Studio might ask you to reenter your account credentials.  

:::image type="content" source="media/reauthenticate-account.png" alt-text="Reauthenticate your Visual Studio account.":::

Clicking on **Reenter your credentials** will open your system's default web browser and attempt to automatically refresh your credentials. If unsuccessful, you'll be asked to sign into your account and validate any required CA/MFA policy.

> [!NOTE] 
> For the best experience, keep your browser open until all CA/MFA policies are validated for your resources. Closing the browser may result in losing the previously built MFA state, and may prompt additional authorization prompts.

## How to opt out of using a specific Azure Active Directory tenant in Visual Studio

Visual Studio 2019 version 16.6 offers the flexibility to filter out tenants individually or globally, effectively hiding them from Visual Studio. Filtering eliminates the need to authenticate with that tenant, but it also means that you won't be able to access any associated resources.

This functionality is useful when you have multiple tenants, but want to optimize your development environment by targeting a specific subset. It can also help in instances when you can't validate a particular CA/MFA policy, as you can filter out the offending tenant. 

### How to filter out all tenants
To globally filter out all tenants, open the Account Settings dialog **(File > Account Settings…)** and deselect the **Authenticate Across all Azure Active Directories** checkbox.

Deselecting that option ensures you’ll only authenticate with the account’s default tenant. It also means that you won't be able to access any resources associated with other tenants your account might be a guest on.

### How to filter out individual tenants
To filter tenants that are associated with  your Visual Studio account, open the Account Settings dialog **(File > Account Settings…)** and click on **Apply filter**. 
</br>
</br>

:::image type="content" source="media/apply-filter.png" alt-text="Apply filter." border="false":::

The **Filter account** dialog will appear, allowing you to select which tenants you want to use with your account. 

:::image type="content" source="media/select-filter-account.png" alt-text="Select account to filter.":::

## See also

- [Sign in to Visual Studio](signing-in-to-visual-studio.md)
- [Sign in to Visual Studio for Mac](/visualstudio/mac/signing-in)
- [Work with multiple user accounts](work-with-multiple-user-accounts.md)
