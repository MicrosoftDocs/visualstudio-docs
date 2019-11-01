---
title: "Upgrading Projects | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "upgrading VSPackages"
  - "upgrading applications, strategies"
  - "VSPackages, upgrade support"
ms.assetid: e01cb44a-8105-4cf4-8223-dfae65f8597a
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Upgrading Projects
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Changes to the project model from one version of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] to the next may require that projects and solutions be upgraded so that they can run on the newer version. The [!INCLUDE[vsipsdk](../../includes/vsipsdk-md.md)] provides interfaces that can be used to implement upgrade support in your own projects.  
  
## Upgrade Strategies  
 To support an upgrade, your project system implementation must define and implement an upgrade strategy. In determining your strategy, you can choose to support side-by-side (SxS) backup, copy backup, or both.  
  
- SxS backup means that a project copies only those files that need upgrading in place, adding a suitable file name suffix, for example, ".old".  
  
- Copy backup means that a project copies all project items to a user-provided backup location. The relevant files at the original project location are then upgraded.  
  
## How Upgrade Works  
 When a solution created in an earlier version of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] is opened in a newer version, the IDE checks the solution file to determine if it needs to be upgraded. If upgrading is required, the **Upgrade Wizard** is automatically launched to walk the user through the upgrade process.  
  
 When a solution needs upgrading, it queries each project factory for its upgrade strategy. The strategy determines whether the project factory supports copy backup or SxS backup. The information is sent to the **Upgrade Wizard**, which collects the information required for the backup and presents the applicable options to the user.  
  
### Multi-Project Solutions  
 If a solution contains multiple projects and the upgrade strategies differ, such as when a C++ project that only supports SxS backup and a Web project that only support copy backup, the project factories must negotiate the upgrade strategy.  
  
 The solution queries each project factory for <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory>. It then calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject_CheckOnly%2A> to see if global project files need upgrading and to determine the supported upgrade strategies. The **Upgrade Wizard** is then invoked.  
  
 After the user completes the wizard, <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject%2A> is called on each project factory to perform the actual upgrade. To facilitate backup, IVsProjectUpgradeViaFactory methods provide the <xref:Microsoft.VisualStudio.Shell.Interop.SVsUpgradeLogger> service to log the details of the upgrade process. This service cannot be cached.  
  
 After updating all relevant global files, each project factory can choose to instantiate a project. The project implementation must support <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade>. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade.UpgradeProject%2A> method is then called to upgrade all relevant project items.  
  
> [!NOTE]
> The <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject%2A> method does not provide the SVsUpgradeLogger service. This service can be obtained by calling <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider.QueryService%2A>.  
  
## Best Practices  
 Use the <xref:Microsoft.VisualStudio.Shell.Interop.SVsQueryEditQuerySave> service to check if you can edit a file before editing it, and can save it before saving it. This will help your backup and upgrade implementations handle project files under source control, files with insufficient permissions, and so forth.  
  
 Use the <xref:Microsoft.VisualStudio.Shell.Interop.SVsUpgradeLogger> service during all phases of backup and upgrade to provide information on the success or failure of the upgrade process.  
  
 For more information about backing up and upgrading projects, see the comments for IVsProjectUpgrade in vsshell2.idl.  
  
## See Also  
 [Projects](../../extensibility/internals/projects.md)   
 [Upgrading Custom Projects](../../misc/upgrading-custom-projects.md)   
 [Upgrading Project Items](../../misc/upgrading-project-items.md)
