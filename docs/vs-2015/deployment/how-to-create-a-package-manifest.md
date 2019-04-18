---
title: "How to: Create a Package Manifest | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "package files [Windows Installer]"
  - "package files [ClickOnce]"
  - "prerequisites, custom bootstrapper package"
  - "dependencies, custom bootstrapper packages"
ms.assetid: 5aecc507-2764-42f2-ae6f-c227971cf0af
caps.latest.revision: 14
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Create a Package Manifest
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To deploy prerequisites for your application, you can use a bootstrapper package. A bootstrapper package contains a single product manifest file but a package manifest for each locale. Shared functionality across different localized versions should go into the product manifest.  
  
 For more information about package manifests, see [How to: Create a Product Manifest](../deployment/how-to-create-a-product-manifest.md).  
  
## Creating the Package Manifest  
  
#### To create the package manifest  
  
1. Create a directory for the bootstrapper package. This example uses C:\package.  
  
2. Create a subdirectory with the name of the locale, such as en for English.  
  
3. In Visual Studio, create an XML file that is named `package.xml`, and save it to the C:\package\en folder.  
  
4. Add XML to list the name of the bootstrapper package, the culture for this localized package manifest, and the optional license agreement. The following XML uses the variables `DisplayName` and `Culture`, which are defined in a later element.  
  
    ```  
    <Package  
        xmlns="http://schemas.microsoft.com/developer/2004/01/bootstrapper"  
        Name="DisplayName"  
        Culture="Culture"  
        LicenseAgreement="eula.txt">  
    ```  
  
5. Add XML to list all the files that are in the locale-specific directory. The following XML uses a file that is named eula.txt that is applicable for the **en** locale.  
  
    ```  
    <PackageFiles>  
      <PackageFile Name="eula.txt"/>  
    </PackageFiles>  
    ```  
  
6. Add XML to define localizable strings for the bootstrapper package. The following XML adds error strings for the en locale.  
  
    ```  
      <Strings>  
        <String Name="DisplayName">Custom Bootstrapper Package</String>  
        <String Name="CultureName">en</String>  
        <String Name="NotAnAdmin">You must be an administrator to install   
    this package.</String>  
        <String Name="GeneralFailure">A general error has occurred while   
    installing this package.</String>  
    </Strings>  
    ```  
  
7. Copy the C:\package folder to the Visual Studio bootstrapper directory. For Visual Studio 2010, this is the \Program Files\Microsoft SDKs\Windows\v7.0A\Bootstrapper\Packages directory.  
  
## Example  
 The package manifest contains locale-specific information, such as error messages, software license terms, and language packs.  
  
```  
<?xml version="1.0" encoding="utf-8" ?>  
<Package  
  xmlns="http://schemas.microsoft.com/developer/2004/01/bootstrapper"  
  Name="DisplayName"  
  Culture="Culture"  
  LicenseAgreement="eula.txt">  
  
  <PackageFiles>  
    <PackageFile Name="eula.txt"/>  
  </PackageFiles>  
  
  <Strings>  
    <String Name="DisplayName">Custom Bootstrapper Package</String>  
    <String Name="Culture">en</String>  
    <String Name="NotAnAdmin">You must be an administrator to install this package.</String>  
    <String Name="GeneralFailure">A general error has occurred while   
installing this package.</String>  
  </Strings>  
</Package>  
```  
  
## See Also  
 [Product and Package Schema Reference](../deployment/product-and-package-schema-reference.md)
