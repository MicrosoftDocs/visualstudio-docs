---
title: Visual Studio enterprise guide
description: Set up and troubleshoot Visual Studio in an enterprise environment.
ms.date: 04/06/2021
ms.custom: vs-acquisition
ms.topic: overview
helpviewer_keywords:
- network installation, Visual Studio
- administrator guide, Visual Studio
- installing Visual Studio, administrator guide
ms.assetid: 
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Visual Studio enterprise guide
If you’re looking to save time while you're getting your company running on Visual Studio, start here. This enterprise guide includes tips that can help you install and update Visual Studio in common enterprise scenarios, get unblocked if you experience issues, and learn how to report a problem if you need more help. 

## Get started 
Learn how to deploy Visual Studio to your enterprise in networked and offline environments.

- **[Enabling Administrator Updates using Microsoft Endpoint Configuration Manager (SCCM)](enabling-administrator-updates.md)**.  Visual Studio updates are included in the [Microsoft Update Catalog](https://www.catalog.update.microsoft.com/Home.aspx) and the [Windows Server Update Services (WSUS)](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus). Enterprise administrators can then download the update and distribute it to Visual Studio client machines across the organization using standard deployment tools such as Microsoft Endpoint Configuration Manager (SCCM).

- **Understand options for enterprise deployment in networked environments**. The [Visual Studio administrator guide](visual-studio-administrator-guide.md) provides scenario-based guidance for system administrators. 

- **[Get troubleshooting tips](troubleshooting-installation-issues.md)**. Get help when you’re installing or updating Visual Studio, and learn how to report a problem if you’re blocked. These tips include step-by-step instructions that should resolve most online or offline installation issues. 

- **[Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)**. If you’re not connected to the Internet or have limited Internet connectivity, find options for installing Visual Studio. 

- **[Create bootstrapper packages](../deployment/creating-bootstrapper-packages.md)**. Learn how to create custom bootstrapper packages by creating product and package manifests. 

- **[Automatically apply product keys when deploying Visual Studio](automatically-apply-product-keys-when-deploying-visual-studio.md)**. You can apply your product key programmatically as part of a script that is used to automate the deployment of Visual Studio. You can set a product key on a device programmatically, either during an installation of Visual Studio, or after an installation completes. 

## Install Visual Studio 

Learn how to install Visual Studio in common enterprise scenarios. 

- **[Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)**. Use a variety of parameters to control or customize your Visual Studio installation. Automate the installation process or create a cache of the installation files for later use. For more information, see [command line parameter examples](command-line-parameter-examples.md).

- **[Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)**. Cache the files for the initial installation along with all product updates to a single folder. 

- **[Install and use Visual Studio and Azure Services behind a firewall or proxy server](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md)**. If your organization uses security measures such as a firewall or a proxy server, then there are domain URLs that you might want to add to an "allowlist" and ports and protocols that you might want to open so that you have the best experience when you install and use Visual Studio and Azure Services. 

- **[Install required certificates for offline installation](../install/install-certificates-for-visual-studio-offline.md)**. Install necessary certificates if the client machine is completely disconnected from the internet.

## Update Visual Studio 

Learn how to update Visual Studio successfully and fix update issues. 

- **[Apply Administrator Updates using Microsoft Endpoint Configuration Manager (SCCM)](../install/applying-administrator-updates.md)**. Learn about distributing Visual Studio feature, security, and quality updates through SCCM. 

- **[Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)**. Update a network installation layout of Visual Studio with the latest product updates so that it can be used both as an installation point for the latest update of Visual Studio and also to maintain installations that are already deployed to client workstations.

- **[Update Visual Studio while on a servicing baseline](update-servicing-baseline.md)**. Understand the value in updating on a baseline and learn the difference between minor releases and servicing updates. 

- **[Update Visual Studio using a minimal offline layout](update-minimal-layout.md)**. For computers that are not connected to the internet, creating a minimal layout is the easiest and fastest way to update your offline Visual Studio instances.

- **[Repair Visual Studio](repair-visual-studio.md) to fix update issues**. Sometimes your Visual Studio installation becomes damaged or corrupted. A repair is useful for fixing install-time issues across all install operations, including updates. 

- **Follow [Windows security baselines](/windows/security/threat-protection/windows-security-baselines)**. Microsoft is dedicated to providing its customers with secure operating systems, such as Windows 10 and Windows Server, and secure apps, such as Microsoft Edge. In addition to the security assurance of its products, Microsoft also enables you to have fine control over your environments by providing various configuration capabilities. 

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also 

- [Productivity guide for Visual Studio](../ide/productivity-features.md)

