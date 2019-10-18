---
title: "Creating Your Own Start Page | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "Create start page"
  - "custom start page"
  - "customize start page"
ms.assetid: a0df5b9c-0932-4e54-86f0-28530ad9d684
caps.latest.revision: 22
manager: jillfra
---
# Creating Your Own Start Page
You can create a custom Start Page either by using the Start Page Project Template or by creating a blank Start Page.  
  
 The XAML designer may not provide fully accurate visual representations of custom Start Pages because of dependencies on the Visual Studio application model.  
  
## Using the Project Template  
 The Start Page project template creates a Start Page project that is a complete copy of the Visual Studio Start Page. You can then edit the Start Page to your specifications.  
  
#### To create a custom Start Page by using the Start Page project template  
  
1. Download and install the [Start Page project template](http://go.microsoft.com/fwlink/?LinkId=186204) from Visual Studio Gallery.  
  
    > [!WARNING]
    > At this time the Visual Studio 2010 Start Page project template has not been upgraded. For information about how to upgrade this template, see [How to: Upgrade a Visual Studio Custom Start Page](../misc/how-to-upgrade-a-visual-studio-custom-start-page.md).  
  
2. After you have installed the template, create a new start page project with it.  
  
3. In the left pane of the New Project dialog box, under **Installed Templates**, expand the **Other Project Types** node, and then click **Extensibility**.  
  
4. In the middle pane, click **Custom Start Page**, and then name your project and click **OK**.  
  
     Visual Studio creates a Start Page project that is a complete copy of the Visual Studio Start Page.  
  
5. From **Solution Explorer**, open **StartPage.xaml**.  
  
6. Edit StartPage.xaml.  
  
     You can view your work by pressing F5 to open an experimental instance of Visual Studio with the custom Start Page installed.  
  
## Creating a Blank Start Page  
 The easiest way to create a blank Start Page is to use the Start Page project template and then remove the content.  
  
#### To create a blank Start Page by using the Start Page project template  
  
1. Create a Start Page project by using the Start Page project template, as described in the previous procedure.  
  
2. Open StartPage.xaml.  
  
3. Remove all of the page content, leaving only the outer xml elements and the containing grid <xref:System.Windows.Controls.Grid> element, so that your .xaml file resembles the following example.  
  
   ```xaml
      <Grid xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
                xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
                xmlns:sp="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.StartPage"
                xmlns:vs="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.10.0"
                xmlns:vsfx="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.10.0"
            mc:Ignorable="d" 
                d:DesignHeight="600" d:DesignWidth="800">
       <Grid>
           <!--Add content here.-->
       </Grid>
   </Grid>
   ```
      
4. Remove any supporting files you do not intend to use.  
  
    You should keep the .vsix and .pkgdef files for deployment purposes.  
  
   Alternatively, you can create a blank Start Page by creating a XAML file with the correct tag structure to be recognized by Visual Studio. You can then add markup and code-behind to get the desired appearance and functionality. For more information, see [Creating a Custom Start Page](../extensibility/creating-a-custom-start-page.md).  
  
## Testing and Applying the Custom Start Page  
 Do not set the primary instance to run the custom Start Page until you verify that it does not crash. When you have tested your custom Start Page, you can apply it to your system by repeating the last three steps of this procedure in the primary instance of Visual Studio.  
  
#### To test a custom Start Page  
  
1. Press F5.  
  
    The experimental instance of Visual Studio opens with the new Start Page installed but not selected.  
  
2. In the experimental instance of Visual Studio, on the **Tools** menu, click **Options**.  
  
3. In the **Options** dialog box, under **Environment**, select **Startup**. Then, on the **Customize Start Page** list, select your .xaml file, and click **OK**.  
  
4. On the **View** menu, click **Start Page**.  
  
    The working Start Page is displayed. You must close the experimental instance, re-copy any changed files, and then re-open the experimental instance to see new changes.  
  
   You can share your custom Start Page by uploading the .vsix file from your bin\debug directory to the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) Web site, or to another Web site or intranet share. For more information, see [Deploying Custom Start Pages](../extensibility/deploying-custom-start-pages.md).  
  
## See also  
 [Customizing the Start Page](../ide/customizing-the-start-page-for-visual-studio.md)   
 [Walkthrough: Adding Custom XAML to the Start Page](../extensibility/walkthrough-adding-custom-xaml-to-the-start-page.md)