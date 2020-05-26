---
title: Work with accounts that require multi-factor authentication
ms.date: 05/22/2020
ms.topic: conceptual
author: ornellaalt
ms.author: ornella
manager: jillfra
ms.workload:
- multiple
monikerRange: ">=vs-2019"
---
# How to use Visual Studio with accounts that require multi-factor authentication

## What is multi-factor authentication?
When collaborating with external guest users, it's a good idea to protect your apps and data with **conditional access (CA)** policies such as **multi-factor authentication (MFA)**.  

Once enabled, guest users will need more than just a username and password to access your resources, and must satisfy additional security requirements. MFA policies can be enforced at the tenant, app, or individual guest user level, the same way that they are enabled for members of your own organization. 

## How is the Visual Studio experience affected when using CA policies such as MFA?
Versions of Visual Studio prior to 16.6 may have degraded authentication experiences when used with accounts that have enabled CA policies such as MFA, and are associated with two or more tenants.

## Using Visual Studio with MFA policies
In the 16.6 release, we added new capabilities to Visual Studio 2019 that streamline how users can access resources secured via CA policies such as MFA. To use this enhanced workflow, you'll need to opt into using your system's default web browser as the mechanism to add and reauthenticate Visual Studio accounts.  

> [!WARNING]
> Not using this workflow could trigger a degraded experience resulting in multiple additional authentication prompts when adding or reauthenticating Visual Studio accounts. 

### Enabling system web browser  
To enable this workflow, go to Visual Studio's Options dialog **(Tools > Options…)**, select the **Accounts** tab and pick **System web browser** under the **Add and reauthenticate accounts using:** dropdown. 

:::image type="content" source="media/select-system-web-browser.png" alt-text="Select system web browser from the menu.":::

### Sign into additional accounts with MFA policies 
Once the system web browser workflow is enabled, you can sign in or add accounts to Visual Studio as you normally would, via the Account Settings dialog **(File > Account Settings…)**.   

:::image type="content" source="media/add-personalization-account.png" alt-text="Add a new personalization account to Visual Studio." border="false":::

This action will open your system's default web browser, ask you to sign into your account, and validate any required MFA policy. 

> [!NOTE] 
> Keep your browser open through the whole process for the best experience, as closing the browser might trigger additional authorization prompts. 

## Reauthenticating an account  
If there's a problem with your account, Visual Studio might ask you to reenter your account credentials.  

:::image type="content" source="media/reauthenticate-account.png" alt-text="Reauthenticate your Visual Studio account.":::

Clicking on **Reenter your credentials** will open your system's default web browser and attempt to automatically refresh your credentials. If unsuccessful, you'll be asked to sign into your account and validate any required MFA policy. 

> [!NOTE] 
> Keep your browser open through the whole process for the best experience as closing the browser might trigger additional authorization prompts. 