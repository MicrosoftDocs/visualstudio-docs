---
title: Exempt from Windows Information Protection
description: Learn about exempting Visual Studio from Windows Information Protection while still allowing it to use enterprise data. 
ms.date: 06/01/2018
ms.topic: article
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Configure Visual Studio as a WIP-exempt app

[Windows Information Protection](/windows/security/information-protection/windows-information-protection/protect-enterprise-data-using-wip) (WIP) helps to protect enterprise data from leaking through apps like email, social media, and the public cloud, which are outside of the enterprise’s control. WIP helps to protect against accidental data leakage on enterprise-owned devices and personal devices, without requiring changes to your environment or other apps.

*Enlightened* apps for WIP are expected to prevent enterprise data from going to unprotected network locations, and to avoid encrypting personal data.​ Visual Studio is not an enlightened app, so it doesn't work in WIP-enabled environments unless you exempt it. Follow the steps in this article to enable Visual Studio to function on a WIP-enabled machine.

## Configure VS as a WIP-exempt app

You can exempt Visual Studio from WIP restrictions but still allow it to use enterprise data. WIP-exempt apps can connect to enterprise cloud resources using an IP address or a hostname. No encryption is applied, and the app can access local files.

To exempt Visual Studio from WIP, follow the [steps to exempt a desktop app](/windows/security/information-protection/windows-information-protection/create-wip-policy-using-intune-azure#exempt-apps-from-a-wip-policy).

## Create a WIP-exempt AppLocker policy file

Because Visual Studio includes multiple binaries, [create a WIP-exempt AppLocker policy file](/windows/security/threat-protection/windows-defender-application-control/applocker/run-the-automatically-generate-rules-wizard). AppLocker allows you to automatically generate rules for all files within a folder.

## Add AppCompat to the Enterprise cloud resource policy

To specify where Visual Studio can access enterprise data on your network, follow these [steps to define where your protected apps can find and send enterprise data](/windows/security/information-protection/windows-information-protection/create-wip-policy-using-intune-azure#choose-where-apps-can-access-enterprise-data). To stop Windows from blocking connections to cloud resources through an IP address, make sure to add the /\*AppCompat\*/ string to the setting.

## Related content

- [App behavior with WIP](/windows/security/information-protection/windows-information-protection/app-behavior-with-wip)
