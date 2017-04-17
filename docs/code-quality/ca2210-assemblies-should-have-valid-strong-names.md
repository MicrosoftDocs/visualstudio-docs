---
title: "CA2210: Assemblies should have valid strong names | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "AssembliesShouldHaveValidStrongNames"
  - "CA2210"
helpviewer_keywords: 
  - "AssembliesShouldHaveValidStrongNames"
  - "CA2210"
ms.assetid: 8ed33d1c-8ec6-4b47-a692-e22dc8693088
caps.latest.revision: 23
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# CA2210: Assemblies should have valid strong names
|||  
|-|-|  
|TypeName|AssembliesShouldHaveValidStrongNames|  
|CheckId|CA2210|  
|Category|Microsoft.Design|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An assembly is not signed with a strong name, the strong name could not be verified, or the strong name would not be valid without the current registry settings of the computer.  
  
## Rule Description  
 This rule retrieves and verifies the strong name of an assembly. A violation occurs if any of the following are true:  
  
-   The assembly does not have a strong name.  
  
-   The assembly was altered after signing.  
  
-   The assembly is delay-signed.  
  
-   The assembly was incorrectly signed, or signing failed.  
  
-   The assembly requires registry settings to pass verification. For example, the Strong Name tool (Sn.exe) was used to skip verification for the assembly.  
  
 The strong name protects clients from unknowingly loading an assembly that has been tampered with. Assemblies without strong names should not be deployed outside very limited scenarios. If you share or distribute assemblies that are not correctly signed, the assembly can be tampered with, the common language runtime might not load the assembly, or the user might have to disable verification on his or her computer. An assembly without a strong name has from the following drawbacks:  
  
-   Its origins cannot be verified.  
  
-   The common language runtime cannot warn users if the contents of the assembly have been altered.  
  
-   It cannot be loaded into the global assembly cache.  
  
 Note that to load and analyze a delay-signed assembly, you must disable verification for the assembly.  
  
## How to Fix Violations  
 **To create a key file**  
  
 Use one of the following procedures:  
  
-   Use the Assembly Linker tool (Al.exe) provided by the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] SDK.  
  
-   For the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] v1.0 or v1.1, use either the <xref:System.Reflection.AssemblyKeyFileAttribute?displayProperty=fullName> or <xref:System.Reflection.AssemblyKeyNameAttribute?displayProperty=fullName> attribute.  
  
-   For the [!INCLUDE[dnprdnlong](../code-quality/includes/dnprdnlong_md.md)], use either the `/keyfile` or `/keycontainer` compiler option [/KEYFILE (Specify Key or Key Pair to Sign an Assembly)](/cpp/build/reference/keyfile-specify-key-or-key-pair-to-sign-an-assembly) or [/KEYCONTAINER (Specify a Key Container to Sign an Assembly)](/cpp/build/reference/keycontainer-specify-a-key-container-to-sign-an-assembly) linker option in C++).  
  
 **To sign your assembly with a strong name in Visual Studio**  
  
1.  In [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], open your solution.  
  
2.  In **Solution Explorer**, right-click your project and then click **Properties.**  
  
3.  Click the **Signing** tab, and select the **Sign the assembly** check box.  
  
4.  From **Choose a strong name key file**, select **New**.  
  
     The **Create Strong Name Key** window will display.  
  
5.  In **Key file name**, type a name for your strong name key.  
  
6.  Choose whether to protect the key with a password, and then click **OK**.  
  
7.  In **Solution Explorer**, right-click your project and then click **Build**.  
  
 **To sign your assembly with a strong name outside Visual Studio**  
  
-   Use the strong name tool (Sn.exe) that is provided by the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] SDK. For more information, see [Sn.exe (Strong Name Tool)](http://msdn.microsoft.com/Library/c1d2b532-1b8e-4c7a-8ac5-53b801135ec6).  
  
## When to Suppress Warnings  
 Only suppress a warning from this rule if the assembly is used in an environment where tampering with the contents is not a concern.  
  
## See Also  
 <xref:System.Reflection.AssemblyKeyFileAttribute?displayProperty=fullName>   
 <xref:System.Reflection.AssemblyKeyNameAttribute?displayProperty=fullName>   
 [How to: Sign an Assembly with a Strong Name](http://msdn.microsoft.com/Library/2c30799a-a826-46b4-a25d-c584027a6c67)   
 [Sn.exe (Strong Name Tool)](http://msdn.microsoft.com/Library/c1d2b532-1b8e-4c7a-8ac5-53b801135ec6)