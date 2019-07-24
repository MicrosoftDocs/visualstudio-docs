---
title: "Walkthrough: Adding Custom XAML to the Start Page | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "custom start page"
  - "xaml start page"
ms.assetid: 9af4d5f9-1cfc-4221-aea7-c8cd3f7571a6
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Walkthrough: Adding Custom XAML to the Start Page
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough shows how to create a custom Visual Studio Start Page that contains a Web browser.  
  
## Adding Custom XAML  
  
1. Create a Start Page by following the instructions in [Creating a Custom Start Page](../extensibility/creating-a-custom-start-page.md).  
  
2. In the MainWindow.xaml file, find the \<Grid> section.  
  
3. Add a \<TabControl> element and a \<TabItem> inside the \< Grid> element, as shown in the following example.  
  
    ```xml  
    <Grid>  
        <TabControl>  
            <TabItem Header="Bing" Height="Auto">  
                <Frame Source="http://www.bing.com" />  
            </TabItem>  
        </TabControl>  
    </Grid>  
    ```  
  
4. Add a second \<TabItem>, with a \<Button> element that opens a new project:  
  
    ```xml  
    <Grid>  
        <TabControl>  
            <TabItem Header="MyButton" Height="Auto">  
                <Button Name="btnNewProj" Content="New Project"   
                    Command="{x:Static vscom:VSCommands.ExecuteCommand}"  
                    CommandParameter="File.NewProject" >  
                </Button>  
            </TabItem>  
            <TabItem Header="Bing" Height="Auto">  
                <Frame Source="http://www.bing.com" />  
            </TabItem>  
        </TabControl>  
    </Grid>  
    ```  
  
## Testing the Custom Start Page  
  
1. Press F5.  
  
     The experimental instance of Visual Studio opens, with the custom Start Page installed but not selected.  
  
2. In the experimental instance of Visual Studio, open the **Tools /Options / Environment** page.  
  
3. Select **Startup**. On the **Customize Start Page** list, select your .xaml file, and click **OK**.  
  
4. On the **View** menu, click **Start Page**.  
  
5. Click the **Bing** tab.  
  
     You should see a Bing web page.  
  
6. Click the **MyButton** tab.  
  
     You should see a **MyProject** button, which opens the **New Project** dialog.  
  
7. Close the experimental instance.  
  
## Applying the Custom Start Page  
  
#### To test the custom Start Page  
  
1. In **Tools / Options / Environment**, select **Startup**. On the **Customize Start Page** list, select your .xaml file, and click **OK**.  
  
## Next Steps  
 The Visual Studio Start Page now contains a tab that displays a Web browser tab and a MyButton tab. You can create custom Start Pages that have other functionality by using the *code-behind* model to add a custom .dll, as shown in [Adding User Control to the Start Page](../extensibility/adding-user-control-to-the-start-page.md). You can share custom Start Pages with other users by publishing the resulting .vsix file to the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) Web site, or to another Web site or network share. For more information, see [Deploying Custom Start Pages](../extensibility/deploying-custom-start-pages.md).  
  
## See Also  
 [Customizing the Start Page](../ide/customizing-the-start-page-for-visual-studio.md)   
 [WPF Container Controls](https://msdn.microsoft.com/a0177167-d7db-4205-9607-8ae316952566)
