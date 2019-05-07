---
title: "Servicing Guidelines for Isolated Shell Applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio Shell integrated mode, serviceability"
  - "Shell integrated mode [Visual Studio], serviceability"
ms.assetid: 747d1a47-b8b3-4e8b-93c0-768724be48f2
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# Servicing Guidelines for Isolated Shell Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you distribute a Visual Studio isolated shell application, you must be able to provide software updates for your application after it is installed. To do this, you must install your application by using a Microsoft Installer (MSI) file. This kind of installation allows software updates provided by Microsoft to be redistributed by Web download and consumed by your customers without custom intervention.  
  
## Servicing Requirements  
 You can ensure that your isolated shell installation can allow updates by making sure your installation program meets the following three criteria.  
  
### Redistribute by Using an MSI  
 You must use an MSI to redistribute your application, because an MSI preserves product identity and makes sure that the application has a physical location on the client computer. Merge modules (.msm files) do not provide such assurances and should not be used.  
  
### Accounting for Custom Actions  
 Custom actions are nonstandard installation directives in an installer program. Custom actions change parameters such as file locations, registry settings, user settings, or other installation items. Custom actions might manipulate data at installation time.  
  
 When you use custom actions in an installation program, you must ensure that every install-time custom action must have a corresponding custom action to undo the action when the user uninstalls the application. If your installation program fails to provide corresponding uninstall custom action, removing your application will leave it partially installed.  
  
- A custom action that relies on a specific version of a file or hash values will fail when software updates change these versions or hash values. In this case your custom action must manually update these values. An additional problem occurs if versions of a file or hash values are shared between product versions. Avoid this dependency whenever possible.  
  
### Accounting for Shared Files  
 Shared files have the same names and are installed to the same location by multiple products. These products may differ in version, Stock Keeping Unit (SKU), or both, and the products can co-exist on a given computer. However, shared files create servicing problems for several reasons:  
  
- Updating shared files can cause application compatibility issues because an update to one application may change the version of a file used by a second application that has not been updated. Installers for products that share files count references to the shared files. Therefore, uninstalling a product does not affect shared files beyond decrementing the count of installed instances.  
  
- The Quick Fix Engineering (QFE) installer reverts versions of files to the versions of the products that the QFE installer serviced. This process potentially breaks an application that had delivered an updated shared file.
