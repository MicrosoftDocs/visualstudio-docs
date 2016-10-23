---
title: "How to: Brand a VSPackage (C# and Visual Basic)"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 705a41c3-63d6-4c1e-9f82-771be9191579
caps.latest.revision: 16
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# How to: Brand a VSPackage (C# and Visual Basic)
To appear in the **About** dialog box and the splash screen, VSPackages must implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsInstalledProduct?qualifyHint=False> interface. This provides the following information to Visual Studio:  
  
-   Name  
  
-   ID, such as serial or version number  
  
-   Information  
  
-   Logo icon  
  
 The following code is from [VSSDK Samples](../VS_not_in_toc/VSSDK-Samples.md).  
  
### To implement the IVsInstalledProduct interface  
  
1.  Add the <xref:Microsoft.VisualStudio.Shell.InstalledProductRegistrationAttribute?qualifyHint=False> attribute to the class that implements the VSPackage. This class must derive from both <xref:Microsoft.VisualStudio.Shell.Package?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsInstalledProduct?qualifyHint=False>.  
  
     [!CODE [VSSDKPackageSplashHelpAboutLoadKey#1](../CodeSnippet/VS_Snippets_VSSDK/vssdkpackagesplashhelpaboutloadkey#1)]  
  
     The first argument, <xref:Microsoft.VisualStudio.Shell.InstalledProductRegistrationAttribute.UseInterface?qualifyHint=False>, of the <xref:Microsoft.VisualStudio.Shell.InstalledProductRegistrationAttribute?qualifyHint=False> attribute tells Visual Studio to use <xref:Microsoft.VisualStudio.Shell.Interop.IVsInstalledProduct?qualifyHint=False> to obtain product information, instead of the InstalledProducts registry key. The remaining arguments select string resources to display the product name, details, and ID, respectively. However, because the first argument is `true`, the remaining arguments are `null`.  
  
2.  Right-click <xref:Microsoft.VisualStudio.Shell.Interop.IVsInstalledProduct?qualifyHint=False>, point to **Implement Interface**, and then click **Implement Interface**.  
  
3.  Implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsInstalledProduct?qualifyHint=False> by using the following code.  
  
     [!CODE [VSSDKPackageSplashHelpAboutLoadKey#2](../CodeSnippet/VS_Snippets_VSSDK/vssdkpackagesplashhelpaboutloadkey#2)]  
  
     Visual Studio calls these methods to obtain information for branding the VSPackage. The GetResourceString method is used to localize this information.  
  
    > [!NOTE]
    >  Code comments are deleted for brevity. You can find them in [VSSDK Samples](../VS_not_in_toc/VSSDK-Samples.md).  
  
### To maintain the product information strings  
  
1.  Double-click the .resx resource file associated with the VSPackage.  
  
     The resource editor opens.  
  
2.  Find or add the product name, information, and ID.  
  
     The following resource strings are from the [VSSDK Samples](../VS_not_in_toc/VSSDK-Samples.md).  
  
     @101  
     Package Splash screen and Help About Official Name (C#).  
  
     @102  
     This package demonstrates how to display text and image in the splash screen and the help about.  
  
     @104  
     8.0  
  
3.  Select and edit this information as you want.  
  
### To maintain the product icons and bitmaps  
  
1.  Add the bitmaps and icons to the project as project resources.  
  
     For more information, see [NOT IN BUILD: Adding and Editing Resources (Visual C#)](assetId:///95f15d03-bed0-410c-8d1f-dece5199ba1e).  
  
2.  Close the resource editor and reopen the .resx file in an XML or text editor.  
  
    > [!NOTE]
    >  The resource editor does not support assigning resource IDs to items other than strings.  
  
3.  Find or add the icon and bitmap resources to the .resx file. The following resources are from [VSSDK Samples](../VS_not_in_toc/VSSDK-Samples.md).  
  
    ```  
    <data name="300" type="System.Resources.ResXFileRef, System.Windows.Forms">  
        <value>GenericPackage.bmp;System.Drawing.Bitmap, System.Drawing,  
            Version=2.0.0.0, Culture=neutral,         PublicKeyToken=b03f5f7f11d50a3a</value>  
    </data>  
    <data name="400" type="System.Resources.ResXFileRef, System.Windows.Forms">  
        <value>GenericPackage.ico;System.Drawing.Icon, System.Drawing,  
            Version=2.0.0.0, Culture=neutral,         PublicKeyToken=b03f5f7f11d50a3a</value>  
    </data>  
    ```  
  
### To test the About dialog box and splash screens  
  
-   To test your VSPackage, see [How to: Test the Help About and Splash Screens](../VS_not_in_toc/How-to--Test-the-Help-About-and-Splash-Screens.md).  
  
## See Also  
 [VSPackage Branding](../VS_not_in_toc/VSPackage-Branding.md)