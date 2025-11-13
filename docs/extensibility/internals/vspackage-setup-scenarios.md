---
title: VSPackage Setup Scenarios
description: Learn about best practices for supporting side-by-side installations of Visual Studio with either shared or side-by-side installations of your VSPackage.
ms.date: 11/04/2016
ms.topic: install-set-up-deploy
helpviewer_keywords:
- VSPackages, deployment considerations
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# VSPackage Setup Scenarios

It is important to design your VSPackage installer for flexibility. For example, you might need to release a security patch in the future, or you might change a business strategy that requires thorough side-by-side versioning support.

In [Supporting Multiple Versions of Visual Studio](../../extensibility/supporting-multiple-versions-of-visual-studio.md), you can read about the advantages and issues of supporting side-by-side installations of Visual Studio with either shared or side-by-side installations of your VSPackage. In short, side-by-side VSPackages give you the most flexibility to support new features of Visual Studio.

The scenarios discussed in this topic are not your only choices, but they are presented as suggested best practices.

## Components, Privacy, and Sharing

### Make your components independent

Once you identify and populate a component, assign a `GUID`, and deploy the component, you cannot change its composition. If you do change a component's composition, the resulting component must be a new component with a new `GUID`. Given these facts, the greatest versioning flexibility is afforded by making each component independent, self-reliant unit. For more information about rules governing components, see [Changing the Component Code](/windows/desktop/Msi/changing-the-component-code) and [What Happens if the Component Rules Are Broken?](/windows/desktop/Msi/what-happens-if-the-component-rules-are-broken).

### Do not mix shared and private resources in a component

Reference counting occurs on the component level. Consequently, mixing shared and private resources in one component makes it impossible to update private resources, such as an executable file, without also overwriting shared resources. This scenario creates backward-compatibility issues and restricts you from creating side-by-side capability.

For example, registry values used to register your VSPackage with the Visual Studio SDK should be kept in a component separate from one used to register your VSPackage with Visual Studio. Shared files or registry values go in yet another component.

## Scenario 1: Shared VSPackage

In this scenario, a shared VSPackage (a single binary that supports multiple versions of Visual Studio is shipped in a Windows Installer package. Registering with each version of Visual Studio is controlled by user-selectable features. It also means that when assigned to separate features, each component can be selected individually for installation or uninstallation, putting the user in control of integrating the VSPackage into different versions of Visual Studio. (See [Windows Installer Features](/windows/desktop/Msi/windows-installer-features) for more information on using features in Windows Installer packages.)

![VS Shared VSPackage installer](../../extensibility/internals/media/vs_sharedpackage.gif "VS_SharedPackage")

As shown in the illustration, shared components are made part of the Feat_Common feature, which is always installed. By making the Feat_VS2002 and Feat_VS2003 features visible, users can choose at install-time into which versions of Visual Studio they want the VSPackage to integrate. Users can also use Windows Installer maintenance mode to add or remove features, which in this case adds or removes the VSPackage registration information from different versions of Visual Studio.

> [!NOTE]
> Setting a feature's Display column to 0 hides it. A low Level column value, such as 1, ensures it will always be installed. For more information, see [INSTALLLEVEL Property](/windows/desktop/Msi/installlevel) and [Feature Table](/windows/desktop/Msi/feature-table).

## Scenario 2: Shared VSPackage Update

In this scenario, an updated version of the VSPackage installer in scenario 1 is shipped. For the sake of discussion, the update adds support for Visual Studio, but it could also be a simpler security patch or bug-fix service pack. Windows Installer's rules for installing newer components require that unchanged components already on the system are not recopied. In this case, a system with version 1.0 already present will overwrite the updated component Comp_MyVSPackage.dll and let users choose to add the new feature Feat_VS2005 with its component Comp_VS2005_Reg.

> [!CAUTION]
> Whenever a VSPackage is shared among multiple versions of Visual Studio, it is essential that subsequent releases of the VSPackage maintain backward compatibility with prior versions of Visual Studio. Where you cannot maintain backward compatibility, you must use side-by-side, private VSPackages. For more information, see [Supporting Multiple Versions of Visual Studio](../../extensibility/supporting-multiple-versions-of-visual-studio.md).

![VS Shared VS Package Update installer](../../extensibility/internals/media/vs_sharedpackageupdate.gif "VS_SharedPackageUpdate")

This scenario presents a new VSPackage installer, taking advantage of Windows Installer's support for minor upgrades. Users simply install version 1.1 and it upgrades version 1.0. However, it is not necessary to have version 1.0 on the system. The same installer will install version 1.1 on a system without version 1.0. The advantage to provide minor upgrades in this manner is that it is not necessary to go through the work of developing an upgrade installer and a full-product installer. One installer does both jobs. A security fix or service pack might instead take advantage of Windows Installer patches. For more information, see [Patching and Upgrades](/windows/desktop/Msi/patching-and-upgrades).

## Scenario 3: Side-by-Side VSPackage

This scenario presents two VSPackage installers — one for each version of Visual Studio .NET 2003 and Visual Studio. Each installer installs a side-by-side, or private, VSPackage (one that is specifically built and installed for a particular version of Visual Studio). Each VSPackage is in its own component. Consequently, each can be individually serviced with patches or maintenance releases. Because the VSPackage DLL is now version-specific, it is safe to include its registration information in the same component as the DLL.

![VS Side-by-Side VS Package installer](../../extensibility/internals/media/vs_sbys_package.gif "VS_SbyS_Package")

Each installer also includes code that is shared between the two installers. If the shared code is installed to a common location, installing both .msi files will install the shared code only once. The second installer just increments a reference count on the component. The reference count ensures that if one of the VSPackages is uninstalled, the shared code will remain for the other VSPackage. If the second VSPackage is uninstalled as well, the shared code will be removed.

## Scenario 4: Side-by-Side VSPackage Update

In this scenario, your VSPackage for Visual Studio suffered from a security vulnerability and you need to issue an update. As in scenario 2, you can create a new .msi file that updates an existing installation to include the security fix, as well as deploy new installations with the security fix already in place.

In this case, the VSPackage is a managed VSPackage installed in the global assembly cache (GAC). When you rebuild it to include the security fix, you must change the revision number portion of the assembly version number. The registration information for the new assembly version number overwrites the previous version, causing Visual Studio to load the fixed assembly.

![VS Side-by-Side VS Package Update installer](../../extensibility/internals/media/vs_sbys_packageupdate.gif "VS_SbyS_PackageUpdate")

For more information on deployment of side-by-side assemblies, see [Simplifying Deployment and Solving DLL Hell with the .NET Framework](/previous-versions/dotnet/articles/ms973843(v=msdn.10)).

## Related content

- [Windows Installer](/windows/desktop/Msi/windows-installer-portal)
- [Supporting Multiple Versions of Visual Studio](../../extensibility/supporting-multiple-versions-of-visual-studio.md)
