---
title: Specifying VSPackage File Location to the VS Shell | Microsoft Docs
description: Learn how you can make it possible for Visual Studio to locate the assembly DLL to load the VSPackage.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- managed VSPackages, file location
- VSPackages, managed package file location
ms.assetid: beb8607a-4183-4ed2-9ac8-7527f11513b1
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Specifying VSPackage File Location to the VS Shell
[!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] must be able to locate the assembly DLL to load the VSPackage. You can locate it in various ways, as described in the following table.

| Method | Description |
| - | - |
| Use the CodeBase registry key. | The CodeBase key can be used to direct [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] to load the VSPackage assembly from any fully qualified file path. The value of the key should be the file path to the DLL. This is the best way to have [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] load your package assembly. This technique is sometimes referred to as the "CodeBase/private installation directory technique." During registration the value of the codebase is passed to the registration attribute classes through an instance of the <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext> type. |
| Place the DLL into the **PrivateAssemblies** directory. | Place the assembly in the **PrivateAssemblies** subdirectory of the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] directory. Assemblies located in **PrivateAssemblies** are automatically detected, but are not visible in the **Add References** dialog box. The difference between **PrivateAssemblies** and **PublicAssemblies** is that assemblies in **PublicAssemblies** are enumerated in the **Add References** dialog box. If you chose not to use the "CodeBase/private installation directory" technique, then you should install into the **PrivateAssemblies** directory. |
| Use a strong-named assembly and the Assembly registry key. | The Assembly key can be used to explicitly direct [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] to load a strong named VSPackage assembly. The value of the key should be the strong name of the assembly. |
| Place the DLL into the **PublicAssemblies** directory. | Finally, the assembly can also be placed into the **PublicAssemblies** subdirectory. Assemblies located in **PublicAssemblies** are automatically detected, and will also appear in the **Add References** dialog box in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].<br /><br /> VSPackage assemblies should only be placed in the **PublicAssemblies** directory if they contain managed components that are intended to be reused by other VSPackage developers. The majority of assemblies do not meet this criterion. |

> [!NOTE]
> Use strong-named, signed assemblies for all of your dependent assemblies. These assemblies should also be installed in your own directory or the global assembly cache (GAC). This protects against conflicts with assemblies that have the same base file name, known as weak-name binding.
