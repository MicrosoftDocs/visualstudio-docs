---
title: "Deploying Custom Start Pages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "package start page"
  - "deploy start page"
ms.assetid: 4a7eb360-de83-41d5-be53-3cfb160d19f9
caps.latest.revision: 22
ms.author: gregvanl
manager: jillfra
---
# Deploying Custom Start Pages
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can deploy custom Start Pages by using VSIX deployment or by copying the files to the correct locations on the target computer.  
  
## VSIX Deployment By Using the Start Page Project Template  
 When you create a Start Page by using the Start Page project template, and then build the project, Visual Studio creates a .vsix file that you can distribute. Packaging a Start Page in a .vsix file gives you the following options for deployment, depending on your intended audience:  
  
- You can put the .vsix file on a network share or on a public Web site. When someone opens the file, the Start Page is automatically installed.  
  
- You can upload the .vsix file to the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) Web site so that users can install it by using **Extension Manager**.  
  
  The Start Page project template creates a copy of the default Visual Studio Start Page so that you can modify the copy and preserve the original.  
  
  You can obtain the Start Page project template by using **Extension Manager** or by downloading it from the Web site.  
  
## VSIX Deployment Without Using the Start Page Project Template  
 A successful VSIX deployment requires an extension to be installed in folders that are recognized by the VSIX registration process and by **Extension Manager**. Because the Start Page project template already specifies the correct folders, we recommend that you use it whenever you want to package an extension for VSIX deployment. However, if you have a case in which you cannot use the template, you can create a VSIX deployment without using it.  
  
 To create a VSIX deployment without using the Start Page project template, first create a .vsix file for the Start Page in either of these two ways:  
  
- By adding your custom Start Page files to an empty VSIX Project. For more information, see [VSIX Project Template](../extensibility/vsix-project-template.md).  
  
- By manually creating a .vsix file. For more information, see [How to: Manually Package an Extension (VSIX Deployment)](../misc/how-to-manually-package-an-extension-vsix-deployment.md).  
  
  For Visual Studio to recognize a Start Page, the `Content Element` of the VSIX Manifest must contain a `CustomExtension Element` that has the `Type` attribute set to `"StartPage"`. A Start Page extension that has been installed by using VSIX deployment appears in the **Customize Start Page** list on the **Startup** options page as **[Installed Extension]** *Extension Name*.  
  
  If your Start Page package includes assemblies, you must add binding path registration so that they are available when Visual Studio starts. To do this, make sure that your package includes a .pkgdef file that has the following information.  
  
```  
[$RootKey$\BindingPaths\{Insert a new GUID here}]  
"$PackageFolder$"=""  
```  
  
### VSIX Deployment for All Users  
 By default, extensions deployed in VSIX packages install only for the current user. You can make a Start Page install for all users of the target machine by creating an All-Users deployment.  
  
##### To create an All-Users deployment  
  
1. Open the extension.vsixmanifest file in code view.  
  
2. In the `Identifier` element of the vsix manifest, add an `AllUsers` element that has a value of `true`.  
  
    ```  
    <AllUsers>true</AllUsers>  
    ```  
  
     This causes the vsix installer to prompt for administrator permissions, and then install the files to \Common7\IDE\Extensions.  
  
3. Open the .pkgdef file.  
  
4. Modify the .pkgdef to set the default start page under HKLM by adding the following, where *MyStartPage.xaml* is the name of the .xaml file that contains your Start Page.  
  
     [$RootKey$\StartPage\Default]  
  
     "Uri"="$PackageFolder$\\*MyStartPage.xaml*"  
  
     This tells Visual Stood to look in the new Start Page location.  
  
## File Copy Deployment  
 You do not have to create a .vsix file to deploy a custom Start Page. Instead, you can copy the markup and supporting files directly into the user's \StartPages\ folder. The **Customize Start Page** list on the **Startup** options page lists every .xaml file in that folder, together with the path—for example, %USERPROFILE%\My Documents\Visual Studio *version*\StartPages\\*File Name*.xaml. If your Start Page includes references to private assemblies, you must copy them and paste them in the \PrivateAssemblies\ folder.  
  
 To distribute a Start Page that you created without packaging it in a .vsix file, we recommend that you use a basic file copy strategy, for example, a batch script, or any other deployment technology that lets you put the files in the required directories.  
  
#### To manually install a custom Start Page  
  
1. Copy the .xaml file that contains the Start Page markup, together with any supporting files other than assemblies, and paste them in the user's \StartPages\ folder.  
  
2. If the Start Page requires assemblies, copy them and paste them in ..\\*Visual Studio installation folder*\Common7\IDE\PrivateAssemblies\\.  
  
3. In the **Customize Start Page** list on the **Startup** options page, select the new Start Page. For more information, see [Customizing the Start Page](../ide/customizing-the-start-page-for-visual-studio.md).  
  
## See Also  
 [Customizing the Start Page](../ide/customizing-the-start-page-for-visual-studio.md)   
 [Adding User Control to the Start Page](../extensibility/adding-user-control-to-the-start-page.md)
