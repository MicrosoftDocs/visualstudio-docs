---
title: "Creating Bootstrapper Packages | Microsoft Docs"
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
  - "deploying applications [Visual Studio], prerequisites"
  - "deploying applications [Visual Studio], custom prerequisites"
  - "prerequisites, custom"
  - "RedistList file"
  - "custom prerequisites"
  - "redistributables list"
ms.assetid: ba1a785b-693d-446b-bcae-b88cadee73d1
caps.latest.revision: 47
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Creating Bootstrapper Packages
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Setup program is a generic installer that can be configured to detect and install redistributable components such as Windows Installer (.msi) files and executable programs. The installer is also known as a bootstrapper. It is programmed through a set of XML manifests that specify the metadata to manage the installation of the component.  
  
 The bootstrapper first detects whether any of the prerequisites are already installed. If prerequisites are not installed, first the bootstrapper shows the license agreements. Second, after the end-user accepts the license agreements, the installation begins for the prerequisites. Otherwise, if all the prerequisites are detected, the bootstrapper just starts the application installer.  
  
## Creating Custom Packages  
 You can generate the manifests by using the XML Editor in Visual Studio. For more information, see [How to: Create a Package Manifest](../deployment/how-to-create-a-package-manifest.md) and [How to: Create a Product Manifest](../deployment/how-to-create-a-product-manifest.md). To see an example of creating a bootstrapper package, see [Walkthrough: Creating a Custom Bootstrapper to Show a Privacy Prompt](../deployment/walkthrough-creating-a-custom-bootstrapper-to-show-a-privacy-prompt.md).  
  
 To create a bootstrapper package, you have to supply the redistributable in the form of an EXE or MSI file.to the Bootstrapper Manifest Generator. Then, the Bootstrapper Manifest Generator creates the following files:  
  
- The product manifest, product.xml, which contains any language-neutral metadata for the package. This contains metadata common to all the localized versions of the redistributable component.  
  
- The package manifest, package.xml, which contains language-specific metadata; it typically contains localized error messages. A component must have at least one package manifest for each localized version of that component.  
  
  After these files are created, put the product manifest file into a folder named for the custom bootstrapper. The package manifest file goes into a folder named for the locale. For example, if the package manifest file is for English redistribution, put the file into a folder called en. Repeat this process for each locale, such as ja for Japanese and de for German. The final custom bootstrapper package could have the following folder structure.  
  
  `CustomBootstrapperPackage`  
  
  `product.xml`  
  
  `CustomBootstrapper.msi`  
  
  `de`  
  
  `eula.rtf`  
  
  `package.xml`  
  
  `en`  
  
  `eula.rtf`  
  
  `package.xml`  
  
  `ja`  
  
  `eula.rtf`  
  
  `package.xml`  
  
  Finally, copy the redistributable files into the bootstrapper folder location. For more information, see [How to: Create a Localized Bootstrapper Package](../deployment/how-to-create-a-localized-bootstrapper-package.md).  
  
```  
\Program Files\Microsoft Visual Studio 14.0\SDK\Bootstrapper\Packages  
```  
  
 or  
  
```  
\Program Files (x86)\Microsoft Visual Studio 14.0\SDK\Bootstrapper\Packages  
```  
  
 You can also determine the bootstrapper folder location from the **Path** value in the following registry key:  
  
```  
HKLM\Software\Microsoft\GenericBootstrapper\11.0  
```  
  
 On 64 bit systems, use the following registry key:  
  
```  
HKLM\Software\Wow6432Node\Microsoft\GenericBootstrapper\11.0  
```  
  
 Each redistributable component appears in its own subfolder under the packages directory. The product manifest and redistributable files are put into this subfolder. Localized versions of the component and package manifests are put in subfolders named according to Culture Name.  
  
 After these files are copied into the bootstrapper folder, the bootstrapper package automatically appears in the Visual Studio prerequisites dialog box. If your custom bootstrapper package does not appear, close and then reopen the Prerequisites Dialog Box. For more information, see [Prerequisites Dialog Box](../ide/reference/prerequisites-dialog-box.md).  
  
 The following table shows the properties that are automatically populated by the bootstrapper.  
  
|Property|Description|  
|--------------|-----------------|  
|ApplicationName|The name of the application.|  
|ProcessorArchitecture|The processor and bits-per-word of the platform targeted by an executable. Values include the following:<br /><br /> -   Intel<br />-   IA64<br />-   AMD64|  
|[Version9x](https://msdn.microsoft.com/library/aa372490\(v=vs.140\).aspx)|The version number for Microsoft Windows 95, Windows 98, or Windows ME operating systems. The syntax of the version is Major.Minor.ServicePack.|  
|[VersionNT](/windows/desktop/Msi/versionnt)|The version number for the Windows NT, Windows 2000, Windows XP, Windows Vista, Windows Server 2008, or Windows 7 operating systems. The syntax of the version is Major.Minor.ServicePack.|  
|[VersionMSI](https://msdn.microsoft.com/library/aa372493\(v=vs.140\).aspx)|The version of the Windows Installer assembly (msi.dll) run during the installation.|  
|[AdminUser](https://msdn.microsoft.com/library/aa367545\(v=vs.140\).aspx)|This property is set if the user has administrator privileges. Values are true or false.|  
|InstallMode|The installation mode indicates where the component needs to be installed from. Values include the following:<br /><br /> -   HomeSite - prerequisites are installed from the vendor's Web site.<br />-   SpecificSite - prerequisites are installed from the location that you select.<br />-   SameSite - prerequisites are installed from the same location as the application.|  
  
## Separating Redistributables from Application Installations  
 You can prevent your redistributable files from being deployed in Setup projects. To do this, create a redistributable list in the RedistList folder in your .NET Framework directory:  
  
 `%ProgramFiles%\Microsoft.NET\RedistList`  
  
 The redistributable list is an XML file that you should name using the following format: *Company Name*.*Component Name*.RedistList.xml. So, for example, if the component is called Datawidgets made by Acme, use Acme.DataWidgets.RedistList.xml. An example of the redistributable list's contents might resemble this:  
  
```  
<?xml version="1.0" encoding="UTF-8"?>  
<FileList Redist="Acme.DataWidgets" >  
<File AssemblyName="Acme.DataGrid" Version="1.0.0.0" PublicKeyToken="b03f5f7f11d50a3a" Culture="neutral" ProcessorArchitecture="MSIL" InGAC="true" />  
</FileList>  
```  
  
## See Also  
 [How to: Install Prerequisites with a ClickOnce Application](../deployment/how-to-install-prerequisites-with-a-clickonce-application.md)   
 [Prerequisites Dialog Box](../ide/reference/prerequisites-dialog-box.md)   
 [Product and Package Schema Reference](../deployment/product-and-package-schema-reference.md)   
 [Use the Visual Studio 2005 Bootstrapper to Kick-Start Your Installation](https://go.microsoft.com/fwlink/?LinkId=107537)
