---
title: "How to: Import a Virtual Machine or Template from SCVMM"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio ALM, import virtual machines"
  - "Visual Studio ALM, import templates"
ms.assetid: 571cc1ca-e3ae-4971-a053-56de57add531
caps.latest.revision: 39
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Import a Virtual Machine or Template from SCVMM
Virtual machines and templates are the basic building blocks for creating SCVMM environments in [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. However, before you can create an SCVMM environment in [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], you must import the initial virtual machines and templates from the System Center Virtual Machine Manager (SCVMM) library into your team project. For more information about how to create the initial virtual machines and templates in SCVMM, see [Create and Store Virtual Machines and Templates Ready for Lab Management](../test/create-and-store-virtual-machines-and-templates-ready-for-lab-management.md).  
  
 When you import a virtual machine or a template from SCVMM, [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] does not create a new copy. Instead, [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] creates a reference to the original virtual machine or template stored in SCVMM.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
## Importing a Virtual Machine or Template  
 The following illustration shows the major steps for importing a virtual machine or a template.  
  
 ![Steps to import a VM or template from SCVMM](../test/media/importvm_vmm.png "ImportVM_VMM")  
  
#### To import a virtual machine or a template into the team project  
  
1.  Open [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
     (Go to **Start**, **All Programs**, **Microsoft Visual Studio**, **Microsoft Test Manager**.  
  
2.  Choose **Lab Center**, choose **Library**, and then choose **Virtual Machines and Templates**.  
  
3.  Choose **Import**.  
  
4.  Follow the steps in the wizard and enter the required information on the **Name and machine** and **Machine properties** pages. For more information about individual properties, see [(superseded) How to: Set the Properties of a Virtual Machine or Template](assetId:///09964b12-0115-4bfd-95aa-3dea22bc5093)  
  
    > [!NOTE]
    >  Under **Machine Properties**, the option to edit **Hardware Profile** and **OS profile** information is not available in Microsoft Test Manager. To edit the properties, you must use the System Center Virtual Machine Manager console.  
  
    > [!NOTE]
    >  When you import a template from SCVMM, the secured administrator password and product key in the template are removed. You must re-enter this information. If the operating system is [!INCLUDE[win7](../codequality/includes/win7_md.md)], [!INCLUDE[winsvr08](../test/includes/winsvr08_md.md)] and later, or [!INCLUDE[windowsver](../deployment/includes/windowsver_md.md)], leave the password field blank. If the operating system is [!INCLUDE[winxp](../codequality/includes/winxp_md.md)] or [!INCLUDE[winxpsvr](../debugger/includes/winxpsvr_md.md)], type an asterisk (*) to indicate a blank password.  
  
5.  On the **Summary** wizard page, review the information. Choose **Finish** to import the virtual machine or the template.  
  
 If you make any changes to the original virtual machine or a template in SCVMM after importing it, the changes are not automatically propagated to the imported virtual machine or template. You have to manually open and change the imported virtual machine or the template by using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
 An alternative way to add virtual machines and templates into a team project is by saving the virtual machines within an existing environment. For more information, see [How to: Store a Virtual Machine or Template](../test/how-to--store-a-virtual-machine-or-template.md).  
  
## Deleting a Virtual Machine or Template  
 If you delete an imported virtual machine or a template in [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], the underlying virtual machine or the template is not deleted in SCVMM. If you delete a stored virtual machine or template that was created from a virtual machine in a deployed environment, the stored virtual machine or template is deleted.  
  
#### To delete a virtual machine or a template in Microsoft Test Manager  
  
1.  Open **Lab Center**.  
  
2.  Choose the **Library** tab, **Virtual Machines and Templates**, and then choose the virtual machine or the template to be deleted.  
  
3.  Choose the **X** (Delete) button.