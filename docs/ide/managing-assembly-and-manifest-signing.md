---
title: "Managing Assembly and Manifest Signing | Microsoft Docs"
ms.custom: ""
ms.date: "02/17/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "manifests [Visual Studio]"
  - "signing manifests [Visual Studio]"
  - "application manifests [Visual Studio]"
  - "assemblies [Visual Studio], signing"
ms.assetid: 6c1ef36b-25f7-4ad0-b29a-51801b7a5420
caps.latest.revision: 15
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
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
# Managing Assembly and Manifest Signing
Strong-name signing gives a software component a globally unique identity. Strong names are used to guarantee that the assembly cannot be spoofed by someone else, and to ensure that component dependencies and configuration statements map to the correct component and component version.  
  
 A strong name consists of the assembly's identity (simple text name, version number, and culture information), plus a public key token and a digital signature.  
  
 For information about signing assemblies in Visual Basic and C# projects, see [Creating and Using Strong-Named Assemblies](http://msdn.microsoft.com/Library/ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9).  
  
 For information about signing assemblies in Visual C++ projects, see [Strong Name Assemblies (Assembly Signing) (C++/CLI)](/cpp/dotnet/strong-name-assemblies-assembly-signing-cpp-cli).  

> [!NOTE]
>  Strong-name signing does not protect against reverse-engineering of the assembly.  To protect against reverse-engineering, see [Dotfuscator Community Edition (CE)](dotfuscator/index.md).
  
## Asset Types and Signing  
 You can sign .NET assemblies and application manifests. These include the following:  
  
-   executables (.exe)  
  
-   application manifests (.exe.manifest)  
  
-   deployment manifests (.application)  
  
-   shared component assemblies (.dll)  
  
 You must sign the following types of asset:  
  
1.  assemblies, if you want to deploy them to the global assembly cache (GAC).  
  
2.  [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application and deployment manifests. Visual Studio enables signing by default for these applications.  
  
3.  Primary interop assemblies, which are used for COM interoperability. The TLBIMP utility enforces strong-naming when creating a primary interop assembly from a COM type library.  
  
 In general you should not sign executables. A strongly-named component cannot reference a non-strongly-named component that is deployed with the application. Visual Studio does not sign application executables, but instead signs the application manifest, which points to the weak-named executable. You should generally avoid signing components that are private to your application, because signing can make it more difficult to manage dependencies.  
  
## How to Sign an Assembly in Visual Studio  
 You sign an application or component by using the **Signing** tab of the project properties window (right-click the project node in the **Solution Explorer** and select **Properties**, or type **project properties** in the **Quick Launch** window, or press ALT+ ENTER inside the **Solution Explorer** window). Select the **Signing** tab, then select the **Sign the assembly**  check box.  
  
 Specify a key file. If you choose to create a new key file, note that new key files are always created in the .pfx format. You need a name and password for the new file.  
  
> [!WARNING]
>  You should always protect your key file with a password to prevent someone else from using it. You can also secure your keys by using providers or certificate stores.  
  
 You can also point to a key you have already created. For more information about creating keys, see [How to: Create a Public-Private Key Pair](http://msdn.microsoft.com/Library/05026813-f3bd-4d7c-9e0b-fc588eb3d114).  
  
 If you have access only to a public key, you can use delay signing to defer assigning the key. You enable delay signing by selecting the **Delay sign only** check box. A delay-signed project won’t run, and you can’t debug it. However, you can skip verification during development by using the [Sn.exe (Strong Name Tool)](http://msdn.microsoft.com/Library/c1d2b532-1b8e-4c7a-8ac5-53b801135ec6) with the `-Vr` option.  
  
 For information about signing manifests, see [How to: Sign Application and Deployment Manifests](../ide/how-to-sign-application-and-deployment-manifests.md).  
  
## See Also  
 [Strong-Named Assemblies](http://msdn.microsoft.com/Library/d4a80263-f3e0-4d81-9b61-f0cbeae3797b)   
 [Strong Name Assemblies (Assembly Signing) (C++/CLI)](/cpp/dotnet/strong-name-assemblies-assembly-signing-cpp-cli)