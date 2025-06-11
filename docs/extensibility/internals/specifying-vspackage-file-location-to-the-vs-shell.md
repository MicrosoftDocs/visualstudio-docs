---
title: Specifying VSPackage File Location to the VS Shell
description: Learn how you can make it possible for Visual Studio to locate the assembly DLL to load the VSPackage.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- managed VSPackages, file location
- VSPackages, managed package file location
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Specifying VSPackage File Location to the VS Shell

Visual Studio must be able to locate the assembly DLL to load the VSPackage. You can locate it in various ways, as described in the following table.

| Method | Description |
| - | - |
| Use the CodeBase registry key. | The CodeBase key can be used to direct Visual Studio to load the VSPackage assembly from any fully qualified file path. The value of the key should be the file path to the DLL. This is the best way to have Visual Studio load your package assembly. This technique is sometimes referred to as the "CodeBase/private installation directory technique." During registration the value of the codebase is passed to the registration attribute classes through an instance of the <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext> type. |
| Place the DLL into the **PrivateAssemblies** directory. | Place the assembly in the **PrivateAssemblies** subdirectory of the Visual Studio directory. Assemblies located in **PrivateAssemblies** are automatically detected, but are not visible in the **Add References** dialog box. The difference between **PrivateAssemblies** and **PublicAssemblies** is that assemblies in **PublicAssemblies** are enumerated in the **Add References** dialog box. If you chose not to use the "CodeBase/private installation directory" technique, then you should install into the **PrivateAssemblies** directory. |
| Use a strong-named assembly and the Assembly registry key. | The Assembly key can be used to explicitly direct Visual Studio to load a strong named VSPackage assembly. The value of the key should be the strong name of the assembly. |
| Place the DLL into the **PublicAssemblies** directory. | Finally, the assembly can also be placed into the **PublicAssemblies** subdirectory. Assemblies located in **PublicAssemblies** are automatically detected, and will also appear in the **Add References** dialog box in Visual Studio.<br /><br /> VSPackage assemblies should only be placed in the **PublicAssemblies** directory if they contain managed components that are intended to be reused by other VSPackage developers. The majority of assemblies do not meet this criterion. |

> [!NOTE]
> Use strong-named, signed assemblies for all of your dependent assemblies. These assemblies should also be installed in your own directory or the global assembly cache (GAC). This protects against conflicts with assemblies that have the same base file name, known as weak-name binding.
