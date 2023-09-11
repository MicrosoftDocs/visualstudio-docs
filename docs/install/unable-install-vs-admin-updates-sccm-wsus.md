---
title: Unable to install VS Admin updates through SCCM and WSUS
titleSuffix: ''
description: Learn how to install VS Admin updates through SCCM and WSUS.
ms.date: 09/08/2023
ms.custom: vs-acquisition
ms.topic: 
f1_keywords:
- install VS Admin
- SCCM and WSUS
author: 
ms.author:
ms.reviewer: khgupta, raviuppa, aartigoyle, v-sidong
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Unable to install VS Admin updates through SCCM and WSUS 

Applies to: Visual Studio 2022 

## Symptoms 

Unable to install Visual Studio 2022 [administrator updates](applying-administrator-updates.md) through SCCM and [Windows Server Update Services](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus) (WSUS). 

## Solution 

To enable Visual Studio client machines to receive updates through WSUS, make sure to prepare the client machines by setting up a few prerequisites. 

1. Ensure that Visual Studio administrator update (for example: Visual Studio 2022 Version 17.5.4 Update) is [imported into WSUS](/mem/configmgr/sum/get-started/synchronize-software-updates), and it is approved. 

1. Enable the client machine to receive administrator updates by setting a registry key on the client machines. 

   - *HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\Setup* 
   - *HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\VisualStudio\Setup* (on 64-bit operating systems) 

   Set AdministratorUpdatesEnabled REG_DWORD key to 1. 

   For more information, see [Enabling administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager](/visualstudio/install/enabling-administrator-updates).

1. The Visual Studio Client Detector Utility ([KB5001148 - Visual Studio Client Detector Utility for Administrator Updates](https://support.microsoft.com/topic/kb5001148-visual-studio-client-detector-utility-for-administrator-updates-ad593454-547c-43c3-b5a3-6f201ae63f03)) must be installed on the client machines in order for the administrator updates to be properly recognized and received. 

   Search for the following product in **Control Panel** > **Programs and Features** windows to confirm if Visual Studio Client Detector Utility is installed. 

   Product Name: Microsoft Visual Studio Setup WMI Provider 
   Version : <Latest> 

1. ChannelURI in "C:\ProgramData\Microsoft\VisualStudio\Packages\_Instances\<RandomID>\state.json" must be pointing to the [release channel](https://aka.ms/vs/17/release/channel).

1. The client machine's SYSTEM account will be downloading and installing the Visual Studio administrator updates, which means that the SYSTEM account must have administrative privileges to the machine, and it must also have access to the internet or the network layout location in order to download the updated product bits.