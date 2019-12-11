---
title: Manage assembly and manifest signing
ms.date: 02/17/2017
ms.technology: vs-ide-deployment
ms.topic: conceptual
helpviewer_keywords:
  - "manifests [Visual Studio]"
  - "signing manifests [Visual Studio]"
  - "application manifests [Visual Studio]"
  - "assemblies [Visual Studio], signing"
ms.assetid: 6c1ef36b-25f7-4ad0-b29a-51801b7a5420
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Manage assembly and manifest signing

Strong-name signing gives a software component a globally unique identity. Strong names are used to guarantee that the assembly cannot be spoofed by someone else, and to make sure that component dependencies and configuration statements map to the correct component and component version.

A strong name consists of the assembly's identity (simple text name, version number, and culture information), plus a public key token and a digital signature.

For information about signing assemblies in Visual Basic and C# projects, see [Create and use strong-named assemblies](/dotnet/framework/app-domains/create-and-use-strong-named-assemblies).

For information about signing assemblies in C++ projects, see [Strong-named assemblies (C++/CLI)](/cpp/dotnet/strong-name-assemblies-assembly-signing-cpp-cli).

> [!NOTE]
> Strong-name signing does not protect against reverse-engineering of the assembly. To protect against reverse-engineering, see [Dotfuscator Community](dotfuscator/index.md).

## Asset types and signing

You can sign .NET assemblies and application manifests:

- Executables (*.exe*)

- Application manifests (*.exe.manifest*)

- Deployment manifests (*.application*)

- Shared component assemblies (*.dll*)

Sign the following types of asset:

1. Assemblies, if you want to deploy them to the global assembly cache (GAC).

2. ClickOnce application and deployment manifests. Visual Studio enables signing by default for these applications.

3. Primary interop assemblies, which are used for COM interoperability. The TLBIMP utility enforces strong-naming when creating a primary interop assembly from a COM type library.

In general, you should not sign executables. A strongly named component cannot reference a non-strongly-named component that is deployed with the application. Visual Studio does not sign application executables, but instead signs the application manifest, which points to the weak-named executable. Avoid signing components that are private to your application, because signing can make it more difficult to manage dependencies.

## How to sign an assembly in Visual Studio

You sign an application or component by using the **Signing** tab of the project properties window (right-click the project node in **Solution Explorer** and select **Properties**). Select the **Signing** tab, then select the **Sign the assembly**  check box.

Specify a key file. If you choose to create a new key file, new key files are always created in the *.pfx* format. You need a name and password for the new file.

> [!WARNING]
> You should always protect your key file with a password to prevent someone else from using it. You can also secure your keys by using providers or certificate stores.

You can also point to a key you have already created. For more information about creating keys, see [Create a public-private key pair](/dotnet/framework/app-domains/how-to-create-a-public-private-key-pair).

If you only have access to a public key, you can use delay-signing to defer assigning the key. You enable delay signing by selecting the **Delay sign only** check box. A delay-signed project doesn't run, and you can't debug it. However, you can skip verification during development by using the [Sn.exe strong name tool](/dotnet/framework/tools/sn-exe-strong-name-tool) with the `-Vr` option.

For information about signing manifests, see [How to: Sign application and deployment manifests](../ide/how-to-sign-application-and-deployment-manifests.md).

## See also

- [Strong-named assemblies](/dotnet/framework/app-domains/strong-named-assemblies)
- [Strong-named assemblies (C++/CLI)](/cpp/dotnet/strong-name-assemblies-assembly-signing-cpp-cli)
