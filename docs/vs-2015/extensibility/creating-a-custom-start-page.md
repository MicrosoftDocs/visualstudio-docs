---
title: "Creating a Custom Start Page | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
ms.assetid: d67e0c53-9f5a-45fb-a929-b9d2125c3c82
caps.latest.revision: 19
ms.author: gregvanl
manager: jillfra
---
# Creating a Custom Start Page
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If you cannot create a custom Start Page by using the Start Page project template, as described in [Start Pages](../misc/creating-your-own-start-page.md), you can manually create one by following the steps in this document.  
  
## Creating a Blank Start Page  
 First, make a blank Start Page by creating a .xaml file that has a tag structure that Visual Studio will recognize. Then, add markup and code-behind to produce the appearance and functionality you want.  
  
#### To create a blank Start Page  
  
1. Create a new project of the type **WPF Application** (**Visual C# / Windows Desktop**.  
  
2. Add a reference to `Microsoft.VisualStudio.Shell.14.0`.  
  
3. Open the XAML file in the XML editor and change the top-level \<Window> element to a \<UserControl> element without removing any of the namespace declarations.  
  
4. Remove the `x:Class` declaration from the top-level element. This makes the XAML content compatible with the Visual Studio tool window that hosts the start page.  
  
5. Add the following namespace declarations to the top-level \<UserControl> element.  
  
    ```  
    xmlns:vs="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.14.0"  
    xmlns:vsfx="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.14.0"  
    ```  
  
     These namespaces let you access Visual Studio commands, controls, and UI settings. For more information, see [Adding Visual Studio Commands to a Start Page](../extensibility/adding-visual-studio-commands-to-a-start-page.md).  
  
     The following example shows the markup in the .xaml file for a blank Start Page. Any custom content should go in the inner <xref:System.Windows.Controls.Grid> element.  
  
    ```vb  
    <UserControl  
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"  
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"  
        xmlns:MyNamespace="clr-namespace:ManualStartPage;assembly=ManualStartPage"  
        xmlns:vs="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.14.0"  
                xmlns:vsfx="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.14.0"  
        xmlns:local="clr-namespace:StartPageHost"  
        mc:Ignorable="d"  
         Height="350" Width="525">  
        <Grid>  
        <!--Add content here.-->  
        </Grid>  
    </UserControl>  
    ```  
  
6. Add controls to the empty \<UserControl> element to fill in your custom Start Page. For information about how to add functionality that is specific to Visual Studio, see [Adding Visual Studio Commands to a Start Page](../extensibility/adding-visual-studio-commands-to-a-start-page.md).  
  
## Testing and Applying the Custom Start Page  
 Do not set the primary instance of Visual Studio to run the custom Start Page until you verify that it does not crash Visual Studio. Instead, test it in the experimental instance.  
  
#### To test a manually created custom Start Page  
  
1. Copy your XAML file, and any supporting text files or markup files, to the **%USERPROFILE%\My Documents\Visual Studio 2015\StartPages\\** folder.  
  
2. If your start page references any controls or types in assemblies that are not installed by Visual Studio, copy the assemblies and then paste them in _Visual Studio installation folder_**\Common7\IDE\PrivateAssemblies\\**.  
  
3. At a Visual Studio command prompt, type **devenv /rootsuffix Exp** to open an experimental instance of Visual Studio.  
  
4. In the experimental instance, go to the **Tools / Options / Environment / Startup** page and select your XAML file from the **Customize Start Page** dropdown.  
  
5. On the **View** menu, click **Start Page**.  
  
     Your custom start page should be displayed. If you want to change any files, you must close the experimental instance, make the changes, copy and paste the changed files, and then re-open the experimental instance to view the changes.  
  
#### To apply the custom start page in the primary instance of Visual Studio  
  
- After you have tested your Start Page and found it to be stable, use the **Customize Start Page** option in the **Options** dialog box to select it as the start page in the primary instance of Visual Studio  
  
## See Also  
 [Walkthrough: Adding Custom XAML to the Start Page](../extensibility/walkthrough-adding-custom-xaml-to-the-start-page.md)   
 [Adding User Control to the Start Page](../extensibility/adding-user-control-to-the-start-page.md)   
 [Adding Visual Studio Commands to a Start Page](../extensibility/adding-visual-studio-commands-to-a-start-page.md)   
 [Walkthrough: Saving User Settings on a Start Page](../extensibility/walkthrough-saving-user-settings-on-a-start-page.md)   
 [Deploying Custom Start Pages](../extensibility/deploying-custom-start-pages.md)
