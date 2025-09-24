---
title: Administrative Templates (ADMX)
description: Configure and deploy group policy settings to the client machines in the Visual Studio ADMX Template and control Visual Studio behavior.
ms.date: 9/23/2025
ms.topic: conceptual
ms.custom: vs-acquisition
helpviewer_keywords:
- dev15
- dev16
- dev17
- Visual Studio administrative templates
- Visual Studio admx
- Visual Studio administrator
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
---
# Administrative Templates (ADMX) 
 
IT Administrators in organizations may want to control certain aspects of Visual Studio behavior to achieve consistency, compliance, or compatibility across their client machines. An easy way to accomplish this level of control is to configure and then deploy group policy settings to the client machines. The Visual Studio policies are consolidated in the [Visual Studio ADMX Template](https://aka.ms/vs/admx/details) into different categories, making them easily understandable and discoverable.   

The recommended approach to discover and configure Visual Studio policies across your organization is to use the [Microsoft Intune settings catalog](/mem/intune/configuration/settings-catalog). Alternative approaches are described below.

The Visual Studio group policy settings contained in the ADMX file are machine-wide for all users, meaning they intend to cover all applicable installed instances, versions, and SKUs of Visual Studio. Sometimes a policy is particular to a specific version of Visual Studio, and the template clearly calls this out. 
 
 ## Visual Studio policy categories
 
 The following are the main categories of Visual Studio policies that are included in the Visual Studio Administrative Templates (ADMX):
 
  - [**Copilot**](../ide/visual-studio-github-copilot-admin.md#disable-copilot-skus) - controls Copilot SKUs and agent mode 
  - [**Dev Tunnels**](https://aka.ms/devtunnels/vs/admx) - controls test functionality
  - [**Feedback**](./feedback-survey-policies.md) - controls behavior of feedback and survey avenues.
  - [**Install and Update**](./configure-policies-for-enterprise-deployments.md) - controls product acquisition behavior.
  - [**Live Share**](https://aka.ms/vsls-policies) - controls user and hosts settings.
  - **Privacy** - controls [Intellicode](/visualstudio/intellicode/intellicode-privacy) and [Customer Experience Improvement Program](https://aka.ms/vs/admx/telemetry) settings.


 ## Acquiring the Visual Studio Administrative Template (ADMX)
 
 The [Visual Studio Administrative Template (ADMX)](https://aka.ms/vs/admx/details) can be downloaded from the Microsoft Download Center. The default installation path is `C:\Windows\PolicyDefinitions`, a location that makes them instantly visible to the Group Policy Editor (gpedit.exe) tool, but you can install them anywhere. The templates are updated periodically, so if you use them we recommend that you check back periodically to get the latest updates. 

 ## Deploying the policies

For cloud connected environments managed by Microsoft Intune, you have two choices for configuring and deploying Visual Studio policies.

1. You can access Visual Studio policies through the [settings catalog](/mem/intune/configuration/settings-catalog).
2. You can also [import the Visual Studio Administrative Templates (ADMX)](/mem/intune/configuration/administrative-templates-import-custom#add-the-admx-and-adml-files) into your **Devices** > **Configuration profiles**, and then [create a customized **Configuration profile**](/mem/intune/configuration/administrative-templates-import-custom#create-a-profile-using-your-imported-files) based on the imported ADMX files. The Visual Studio Administrative Templates (ADMX) depend on the [Windows administrative template (Windows.admx)](/mem/intune/configuration/administrative-templates-windows), so make sure you manually import that one in too.

For machines within a corporate network, you can use the [Group Policy editor](/previous-versions/windows/it-pro/windows-server-2012-r2-and-2012/dn265982(v=ws.11)) or [Microsoft Endpoint Manager (SCCM)](/mem/configmgr/core/understand/introduction) to deploy Visual Studio policies.

[!INCLUDE [install_get_support_md](includes/install_get_support_md.md)]

 ## Related content

* [Visual Studio Administrators Guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Admin controls for GitHub Copilot](../ide/visual-studio-github-copilot-admin.md)
