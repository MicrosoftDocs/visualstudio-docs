---
title: "Visual Studio Administrator Guide | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-install"
ms.topic: conceptual
helpviewer_keywords: 
  - "network installation, Visual Studio"
  - "administrator guide, Visual Studio"
  - "installing Visual Studio, administrator guide"
ms.assetid: 4af353f5-6cfd-4ebe-bcfb-f42306e451a0
caps.latest.revision: 76
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# Visual Studio Administrator Guide
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see the [Visual Studio administrator guide](/visualstudio/install/visual-studio-administrator-guide).

You can deploy Visual Studio 2015 on a network as long as each target computer meets the [minimum installation requirements](https://visualstudio.microsoft.com/vs/older-downloads/). You can create a network share by running the installation file with the /layout switch (as described on the [Create an Offline Installation of Visual Studio](../install/create-an-offline-installation-of-visual-studio.md) page) and then copying it from the local machine to the network share. If you are using an ISO, you can mount the ISO and share it or copy the ISO to a network share.  
  
 Note that installations from a network share “remember” the source location they came from. This means that a repair of a client machine might need to return to the network share that the client originally installed from. Choose your network location carefully so that it aligns to the lifetime you expect to have Visual Studio 2015 clients running in your organization.  
  
## Detection and Servicing Keys  
 You can use detection subkeys in the registry to determine whether a Visual Studio product is already installed on a computer. You would use these detection keys in an automated deployment to determine whether it was necessary to proceed with an installation.  See [Detecting System Requirements](../extensibility/internals/detecting-system-requirements.md)[Detecting System Requirements].  
  
## Avoiding Reboots  
 You can reduce reboots by making sure that you meet the appropriate Visual Studio prerequisites before you deploy Visual Studio. For the .NET Framework, you might need to reboot computers that are running Windows 8 if you deploy Visual Studio 2015 on them without first installing the .NET Framework 4.6.  
  
 For Windows and Android device emulation, you might need to reboot computers if you do not already have Windows feature Hyper-V turned on. For Web development, you may need to reboot computers if you do not already have the Windows feature Web Server turned on. For Office development, you may need to reboot computers if you do not already have Windows feature Windows Identify Foundation turned on. reboot computers if you do not already have the Windows feature Web Server turned on. For Office development, you may need to reboot computers if you do not already have Windows feature Windows Identify Foundation turned on. To learn more about how to automate the detection and installation of Windows features, see [Installing a server role on a server running a Server Core installation of Windows Server 2008 R2](https://technet.microsoft.com/library/ee441260(v=ws.10).aspx).  
  
## Error Return Codes  
 The following table lists important error codes. You can use these error codes in your automation to decide if a reboot is required and if the install succeeded. If you receive an error code, consider the troubleshooting steps on the [Install Visual Studio](../install/install-visual-studio-2015.md) page.  
  
|Setup Status|Restart not required|Restart required|Description|  
|------------------|--------------------------|----------------------|-----------------|  
|Success|0x00000000 [0]|0x00000bc2 [3010]|Successful installation.|  
|Block|0x80044000 [-2147205120]|0x8004C000 [-2147172352]|If the only block to be reported is “Reboot Pending,” the returned value is the Incomplete-Reboot Required value (0x80048bc7).|  
|Cancel|0x00000642 [1602]|0x80048642 [-2147187134]|When the Reboot value is returned, the Return Code is 1602.|  
|Incomplete-Reboot Required|N/A|0x80048bc7 [-2147185721]|Restart is required before installation can continue.|  
|Failure|0x00000643 [1603]|0x80048643 [-2147187133]|When the Reboot value is returned, the Return Code is 1603.|  
  
## Interactive Administrator Installer  
 If you are creating an interactive installer on top of the Visual Studio install, you can view progress from the Visual Studio installer. The Visual Studio 2015 installer is built on the open source Windows Installer XML (WiX) chainer technology, also known as “burn.” The burn technology supports two communication protocols: burn and netfx4. For a brief reference, please see the description of the Protocol attribute in the documentation for the ExePackage element at [wixtoolset.org](https://wixtoolset.org/). A review of the WiX open source implementation of this Protocol attribute may be required for integration.  
  
## Controlling What Is Installed  
 If you want to control what your end user can install, there are two options: the administrator file install and the command-line options. Select the administrator file install if your goal is to restrict what your end user can choose from their Visual Studio installer experience. Select the command-line parameters if you want to create an initial configuration but allow your end user to choose their own Visual Studio installer experience.  
  
 For more information on the administrator file experience, see [How to: Create and Run an Unattended Installation of Visual Studio](../install/how-to-create-and-run-an-unattended-installation-of-visual-studio.md) and [How to: Automatically apply product keys when deploying Visual Studio](../install/how-to-automatically-apply-product-keys-when-deploying-visual-studio.md).  For more information on the command-line controls, see the [Use Command-Line Parameters to Install Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md) page.  
  
## Specifying Customer Feedback Settings  

By default, the Visual Studio installation enables customer feedback. You can configure Visual Studio to disable customer feedback on individual computers by changing the value of the following registry key to string "0":  
  
**HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\VisualStudio\SQM**  
**OptIn**  
  
(For example, change it to HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\VisualStudio\SQM OptIn="0")  
  
## Related Topics  
  
|Topic|Description|  
|-----------|-----------------|  
|[How to: Install a Specific Release of Visual Studio](../install/how-to-install-a-specific-release-of-visual-studio.md)|Describes how to install specific configurations of the current version of  [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|  
|[How to: Create and Run an Unattended Installation of Visual Studio](../install/how-to-create-and-run-an-unattended-installation-of-visual-studio.md)|Describes how to install [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] in unattended mode.|  
|[How to: Automatically apply product keys when deploying Visual Studio](../install/how-to-automatically-apply-product-keys-when-deploying-visual-studio.md)|Describes how to apply product keys when deploying to multiple machines.|  
|[Help Viewer Administrator Guide](../ide/help-viewer-administrator-guide.md)|Provides information about  how to manage local Help installations for network environments that either have or do not have internet access.|  
|[Install Visual Studio](../install/install-visual-studio-2015.md)|Provides instructions and  links to topics that describe how to install [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|