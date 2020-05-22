---
title: Work with accounts that require multi-factor authentication
ms.date: 05/22/2020
ms.topic: conceptual
author: ornellaalt
ms.author: ornella
manager: jillfra
ms.workload:
- multiple
---
# How to use Visual Studio with accounts that require multi-factor authentication

## What is multi-factor authentication?
When collaborating with external guest users, it's a good idea to protect your apps and data with conditional access (CA) policies such as multi-factor authentication (MFA).  

Once enabled, guest users will need more than just a username and password to access your resources as they'll need to satisfy additional security requirements to access them. MFA policies can be enforced at the tenant, app, or individual guest user level, the same way that they are enabled for members of your own organization. 

## How is the Visual Studio experience impacted when using CA policies such as MFA? 
Placeholder 

## What's the recommended way to use Visual Studio when MFA policies are enabled? 
Visual Studio 2019 Update 16.6 added new capabilities that streamline how users can access resources secured via CA policies such as MFA. To access this enhanced workflow, users must opt into using their system's default web browser as the mechanism to add and re-authenticate Visual Studio accounts.  

Warning: Not using this workflow could trigger a degraded experience resulting in multiple additional authentication prompts when adding or re-authenticating Visual Studio accounts. 

### Enabling system web browser  

 

To enable this workflow, go to Visual Studio's Options dialog (Tools > Options…), select the "Accounts" tab and pick "System web browser" under the "Add and reauthenticate accounts using:" dropdown. 

 

 

### Sign in or adding additional accounts with CA / MFA policies 

 

Once the System web browser flow is enabled, you can add accounts to Visual Studio as you normally would via the Account Settings dialog (File > Account Settings…).   

 

 

 

 

Both actions will open your system's default web browser and ask you to sign into your account and validate any required MFA policy. 

 

> [!NOTE] Keep your browser open through the whole process for the best experience as closing the browser might trigger additional authorization prompts. 

 

## Reauthenticating an account  

 

If there's a problem with your account, Visual Studio might ask you to reenter your account credentials.  

 

 

Clicking on "Reenter your credentials" will open your system's default web browser and attempt to refresh your credentials without your input. If not possible, you'll be asked to sign into your account and validate any required MFA policy. 

 

> [!NOTE] Keep your browser open through the whole process for the best experience as closing the browser might trigger additional authorization prompts. 