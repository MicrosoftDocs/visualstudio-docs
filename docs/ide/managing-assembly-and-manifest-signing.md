---
title: Manage assembly and manifest signing
description: Explore how to manage an assembly and the advantages of strong-name signing, which gives a software component a globally unique identity. 
ms.date: 07/18/2024
ms.subservice: deployment
ms.topic: conceptual
helpviewer_keywords:
- manifests [Visual Studio]
- signing manifests [Visual Studio]
- application manifests [Visual Studio]
- assemblies [Visual Studio], signing
author: mikejo5000
ms.author: mikejo
manager: mijacobs
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

The procedure to sign an assembly depends on which version of the Project Designer your project uses.

For .NET Core (and .NET 5 and later) C# projects in Visual Studio 2022:

1. Open the project properties window (right-click the project node in **Solution Explorer** and select **Properties**).
1. Under **Build**, look for **Strong naming**, and select the **Sign the assembly** checkbox. Additional options for the key file and delay signing appear when you check the box.
1. Specify a key file.

If you don't have a key file, you can use the command line to [create an `.snk` file](/dotnet/standard/assembly/create-public-private-key-pair). You can also use or generate a certificate in a `.pfx` file using the **Publish** process, and in the **Sign manifests** step, you can create a test certificate to use only during development and testing, or for production, use a certificate issued by your IT department or by an authorized source. See [Deploy a .NET Windows Desktop app with ClickOnce](../deployment/quickstart-deploy-using-clickonce-folder.md).

For .NET Framework and Visual Basic projects in Visual Studio 2022, or in Visual Studio 2019:

1. Open the **Signing** tab of the project properties window (right-click the project node in **Solution Explorer** and select **Properties**). Select the **Signing** tab.
1. Select the **Sign the assembly**  check box.
1. Specify a key file. If you choose to create a new key file, new key files are always created in the *.pfx* format. You need a name and password for the new file.

> [!WARNING]
> You should always protect your key file with a password to prevent someone else from using it. You can also secure your keys by using providers or certificate stores.

You can also point to a key you have already created. For more information about creating keys, see [Create a public-private key pair](/dotnet/framework/app-domains/how-to-create-a-public-private-key-pair).

If you only have access to a public key, you can use delay-signing to defer assigning the key. You enable delay signing by selecting the **Delay sign only** check box. A delay-signed project doesn't run, and you can't debug it. However, you can skip verification during development by using the [Sn.exe strong name tool](/dotnet/framework/tools/sn-exe-strong-name-tool) with the `-Vr` option.

For information about signing manifests, see [How to: Sign application and deployment manifests](../ide/how-to-sign-application-and-deployment-manifests.md).

## Related content

- [Strong-named assemblies](/dotnet/framework/app-domains/strong-named-assemblies)
- [Strong-named assemblies (C++/CLI)](/cpp/dotnet/strong-name-assemblies-assembly-signing-cpp-cli)
