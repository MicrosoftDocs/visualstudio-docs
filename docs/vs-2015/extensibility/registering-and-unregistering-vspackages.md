---
title: "Registering and Unregistering VSPackages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "registration, VSPackages"
  - "VSPackages, registering"
ms.assetid: e25e7a46-6a55-4726-8def-ca316f553d6b
caps.latest.revision: 36
ms.author: gregvanl
manager: jillfra
---
# Registering and Unregistering VSPackages
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You use attributes to register a VSPackage, but  
  
## Registering a VSPackage  
 You can use attributes to control the registration of managed VSPackages. All registration information is contained in a .pkgdef file. For more information on file-based registration, see [CreatePkgDef Utility](../extensibility/internals/createpkgdef-utility.md).  
  
 The following code shows how to use the standard registration attributes to register your VSPackage.  
  
```csharp  
[PackageRegistration(UseManagedResourcesOnly = true)]  
[Guid("0B81D86C-0A85-4f30-9B26-DD2616447F95")]  
public sealed class BasicPackage : Package  
{. . .}  
```  
  
## Unregistering an Extension  
 If you have been experimenting with a lot of different VSPackages and want to remove them from the experimental instance, you can just run the **Reset** command. Look for **Reset the Visual Studio Experimental Instance** on the start page of your computer, or run this command from the command line:  
  
```vb  
<location of Visual Studio 2015 install>\"Microsoft Visual Studio 14.0\VSSDK\VisualStudioIntegration\Tools\Bin\CreateExpInstance.exe" /Reset /VSInstance=14.0 /RootSuffix=Exp  
```  
  
 If you want to uninstall an extension that you have installed on your development instance of Visual Studio, go to **Tools / Extensions and Updates**, find the extension, and click **Uninstall**.  
  
 If for some reason neither of these methods succeeds at uninstalling the extension, you can unregister the VSPackage assembly from the command line as follows:  
  
```  
<location of Visual Studio 2015 install>\"Microsoft Visual Studio 14.0\VSSDK\VisualStudioIntegration\Tools\Bin\regpkg” /unregister <pathToVSPackage assembly>  
```  
  
## See Also  
 [VSPackages](../extensibility/internals/vspackages.md)
