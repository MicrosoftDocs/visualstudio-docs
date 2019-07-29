---
title: "Walkthrough: Adding Custom XAML to the Start Page | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "custom start page"
  - "xaml start page"
ms.assetid: 9af4d5f9-1cfc-4221-aea7-c8cd3f7571a6
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
monikerRange: vs-2017
---
# Walkthrough: Add custom XAML to the start page

This walkthrough shows how to create a custom Visual Studio start page that contains a Web browser.

## Add custom XAML

1. Create a start page by following the instructions in [Create a custom start page](../extensibility/creating-a-custom-start-page.md).

2. In the *MainWindow.xaml* file, find the \<Grid> section.

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

## Test the custom start page

1. Press **F5**.

     The experimental instance of Visual Studio opens, with the custom start page installed but not selected.

2. In the experimental instance of Visual Studio, open the **Tools /Options / Environment** page.

3. Select **Startup**. On the **Customize Start Page** list, select your *.xaml* file, and click **OK**.

4. On the **View** menu, click **Start Page**.

5. Click the **Bing** tab.

     You should see a Bing web page.

6. Click the **MyButton** tab.

     You should see a **MyProject** button, which opens the **New Project** dialog.

7. Close the experimental instance.

To apply the custom start page, in **Tools** > **Options** > **Environment**, select **Startup**. On the **Customize Start Page** list, select your *.xaml* file, and click **OK**.

## Next steps

The Visual Studio start page now contains a tab that displays a Web browser tab and a MyButton tab. You can create custom start pages that have other functionality by using the *code-behind* model to add a custom .dll, as shown in [Adding User Control to the Start Page](../extensibility/adding-user-control-to-the-start-page.md). You can share custom start pages with other users by publishing the resulting .vsix file to the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) Web site, or to another Web site or network share. For more information, see [Deploying Custom Start Pages](../extensibility/deploying-custom-start-pages.md).

## See also

- [Customize the start page](../ide/customizing-the-start-page-for-visual-studio.md)
- [WPF container controls](https://msdn.microsoft.com/library/a0177167-d7db-4205-9607-8ae316952566)