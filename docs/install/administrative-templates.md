---
title: Administrative Templates (ADMX)
description: Use Visual Studio Administrative Templates to manage group policy.
ms.date: 12/1/2022
ms.topic: conceptual
ms.custom: acquisition
helpviewer_keywords:
- dev15
- dev16
- dev17
- Visual Studio administrative templates
- Visual Studio admx
- Visual Studio administrator
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Administrative Templates (ADMX) 

[!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
 
IT Administrators in organizations may want to control certain aspects of Visual Studio behavior to achieve consistency, compliance, or compatibility across their client machines. An easy way to accomplish this control is to configure group policies using Visual Studio Administrative Templates (ADMX).
 
The [Visual Studio Administrative Templates (ADMX)](https://aka.ms/vs/admx/details) consolidate the various Visual Studio policies into different categories, making them easily discoverable. IT Administrators can learn what policies are available and then configure and deploy the appropriate settings to the client machines. The ADMX templates can be integrated with standard management and deployment tools such as [Group Policy Editor](/previous-versions/windows/it-pro/windows-server-2012-r2-and-2012/dn265982(v=ws.11)) or [Microsoft Endpoint Manager](https://www.microsoft.com/security/business/microsoft-endpoint-manager).  
 
 The Visual Studio group policy settings contained in the ADMX file are machine-wide for all users, meaning they intend to cover all applicable installed instances, versions, and SKUs of Visual Studio. Sometimes a policy is particular to a specific version of Visual Studio, and the template clearly calls this out. 
 
 ## Visual Studio Policy Categories
 
 There are four main categories of Visual Studio policies that are included in the Visual Studio Administrator Templates (ADMX):
 
  - **Feedback** - controls behavior of the send-a-smile feature.
  - [**Install and Update**](/visualstudio/install/set-defaults-for-enterprise-deployments) - controls product acquisition behavior 
  - [**Live Share**](https://aka.ms/vsls-policies) - controls user and hosts settings
  - **Privacy** - controls [Intellicode](/visualstudio/intellicode/intellicode-privacy) and [Customer Experience Improvement Program](https://aka.ms/vs/admx/telemetry) settings
 
 ## Acquiring the Visual Studio Administrator Templates (ADMX)
 
 The [Visual Studio Administrator Templates (ADMX)](https://aka.ms/vs/admx/details) can be downloaded from the Microsoft Download Center. The default installation path is "C:\Windows\PoliciyDefinitions", a location that makes them instantly visible to the Group Policy Editor (gpedit.exe) tool, but you can install them anywhere. The templates are updated periodically, so if you use this solution we recommend that you check back periodically to get the latest updates. 
 
 ## Using Microsoft Endpoint Manager to deploy the policies
 
 You can use the Visual Studio Administrator Templates (ADMX) within enterprise management tools such as [Microsoft Endpoint Manager](/mem/configmgr/core/understand/introduction) to configure and control client machines. 

For cloud connected environments that are managed by Intune, you can [import the Visual Studio Administrator Templates (ADMX)](/mem/intune/configuration/administrative-templates-import-custom#add-the-admx-and-adml-files) into your Devices | Configuration profiles space, and then [create a customized configuration profiles](/mem/intune/configuration/administrative-templates-import-custom#create-a-profile-using-your-imported-files) based on the imported ADMX files. Eventually, Visual Studio Administrator Templates will be built natively into the [Microsoft Endpoint Manager environment](https://endpoint.microsoft.com), so this manual import step will be unnecessary. 

> [!NOTE]
> The Visual Studio Administrator Templates (ADMX) depend on the Windows administrator template (Windows.admx), so make sure you manually import that one in too.]

[!INCLUDE [install_get_support_md](includes/install_get_support_md.md)]

 ## See also

* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
