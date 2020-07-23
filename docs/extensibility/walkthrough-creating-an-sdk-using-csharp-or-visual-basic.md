---
title: 'Walkthrough: Creating an SDK using C# or Visual Basic | Microsoft Docs'
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: ef96a249-5eef-402a-a8d5-d74cb49239bd
author: acangialosi
ms.author: anthc
manager: jillfra
ms.workload:
- vssdk
dev_langs:
- CSharp
- VB
---
# Walkthrough: Create an SDK using C# or Visual Basic
In this walkthrough, you'll learn how to create a simple Math Library SDK by using Visual C# and then package the SDK as a Visual Studio Extension (VSIX). You'll complete the following procedures:

- [To create the SimpleMath Windows Runtime component](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md#createClassLibrary)

- [To create the SimpleMathVSIX extension project](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md#createVSIX)
- [To create a sample app that uses the class library](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md#createSample)

## Prerequisites
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

## <a name="createClassLibrary"></a> To create the SimpleMath Windows Runtime component

1. On the menu bar, choose **File** > **New** > **Project**.

2. In the list of templates, expand **Visual C#** or **Visual Basic**, choose the **Windows Store** node, and then choose the **Windows Runtime Component** template.

3. In the **Name** box, specify **SimpleMath**, and then choose the **OK** button.

4. In **Solution Explorer**, open the shortcut menu for the **SimpleMath** project node, and then choose **Properties**.

5. Rename **Class1.cs** to **Arithmetic.cs** and update it to match the following code:

    [!code-csharp[CreatingAnSDKUsingWinRT#3](../extensibility/codesnippet/CSharp/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_1.cs)]
    [!code-vb[CreatingAnSDKUsingWinRT#3](../extensibility/codesnippet/VisualBasic/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_1.vb)]

6. In **Solution Explorer**, open the shortcut menu for the **Solution 'SimpleMath'** node, and then choose **Configuration Manager**.

    The **Configuration Manager** dialog box opens.

7. In the **Active solution configuration** list, choose **Release**.

8. In the **Configuration** column, verify that **SimpleMath** row is set to **Release**, and then choose the **Close** button to accept the change.

   > [!IMPORTANT]
   > The SDK for the SimpleMath component includes only one configuration. This configuration must be the release build, or apps that use the component won't pass certification for the [!INCLUDE[win8_appstore_long](../debugger/includes/win8_appstore_long_md.md)].

9. In **Solution Explorer**, open the shortcut menu for the **SimpleMath** project node, and then choose **Build**.

## <a name="createVSIX"></a> To create the SimpleMathVSIX extension project

1. On the shortcut menu for the **Solution 'SimpleMath'** node, choose **Add** > **New Project**.

2. In the list of templates, expand **Visual C#** or **Visual Basic**, choose the **Extensibility** node, and then choose the **VSIX Project** template.

3. In the **Name** box, specify **SimpleMathVSIX**, and then choose the **OK** button.

4. In **Solution Explorer**, choose the **source.extension.vsixmanifest** item.

5. On the menu bar, choose **View** > **Code**.

6. Replace the existing XML with the following XML:

     [!code-xml[CreatingAnSDKUsingWinRT#1](../extensibility/codesnippet/XML/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_2.xml)]

7. In **Solution Explorer**, choose the **SimpleMathVSIX** project.

8. On the menu bar, choose **Project** > **Add New Item**.

9. In the list of **Common Items**, expand **Data**, and then choose **XML File**.

10. In the **Name** box, specify `SDKManifest.xml`, and then choose the **Add** button.

11. In **Solution Explorer**, open the shortcut menu for `SDKManifest.xml`, choose **Properties**, and then change the value of the **Include in VSIX** property to **True**.

12. Replace the contents of the file with the following XML:

    **C#**

    ```xml
    <FileList
      DisplayName="WinRT Math Library (CS)"
      MinVSVersion="11.0"
      TargetFramework=".NETCore,version=v4.5"
      AppliesTo="WindowsAppContainer"
      SupportsMultipleVersions="Error"
      MoreInfo="https://msdn.microsoft.com/">
    </FileList>
    ```

    **Visual Basic**

    ```xml
    <FileList
      DisplayName="WinRT Math Library (VB)"
      MinVSVersion="11.0"
      TargetFramework=".NETCore,version=v4.5"
      AppliesTo="WindowsAppContainer"
      SupportsMultipleVersions="Error"
      MoreInfo="https://msdn.microsoft.com/">
    </FileList>
    ```

13. In **Solution Explorer**, open the shortcut menu for the **SimpleMathVSIX** project, choose **Add**, and then choose **New Folder**.

14. Rename the folder to `references`.

15. Open the shortcut menu for the **References** folder, choose **Add**, and then choose **New Folder**.

16. Rename the subfolder to `commonconfiguration`, create a subfolder within it, and name the subfolder `neutral`.

17. Repeat the previous four steps, this time renaming the first folder to `redist`.

     The project now contains the following folder structure:

    ```xml
    references\commonconfiguration\neutral
    redist\commonconfiguration\neutral
    ```

18. In **Solution Explorer**, open the shortcut menu for the **SimpleMath** project, and then choose **Open Folder in File Explorer**.

19. In **File Explorer**, navigate to the *bin\Release* folder, open the shortcut menu for the **SimpleMath.winmd** file, and then choose **Copy**.

20. In **Solution Explorer**, paste the file into the *references\commonconfiguration\neutral* folder in the **SimpleMathVSIX** project.

21. Repeat the previous step, pasting the **SimpleMath.pri** file into the *redist\commonconfiguration\neutral* folder in the **SimpleMathVSIX** project.

22. In **Solution Explorer**, choose **SimpleMath.winmd**.

23. On the menu bar, choose **View** > **Properties** (Keyboard: Choose the **F4** key).

24. In the **Properties** window, change the **Build Action** property to **Content**, and then change the **Include in VSIX** property to **True**.

25. In **Solution Explorer**, repeat this process for **SimpleMath.pri**.

26. In **Solution Explorer**, choose the **SimpleMathVSIX** project.

27. On the menu bar, choose **Build** > **Build SimpleMathVSIX**.

28. In **Solution Explorer**, open the shortcut menu for the **SimpleMathVSIX** project, and then choose **Open Folder in File Explorer**.

29. In **File Explorer**, navigate to *\bin\Release* folder, and then run *SimpleMathVSIX.vsix* to install it.

30. Choose the **Install** button, wait for the installation to finish, and then restart Visual Studio.

## <a name="createSample"></a> To create a sample app that uses the class library

1. On the menu bar, choose **File** > **New** > **Project**.

2. In the list of templates, expand **Visual C#** or **Visual Basic**, and then choose the **Windows Store** node.

3. Choose the **Blank App** template, name the project **ArithmeticUI**, and then choose the **OK** button.

4. In **Solution Explorer**, open the shortcut menu for the **ArithmeticUI** project, and then choose **Add** > **Reference**.

5. In the list of reference types, expand **Windows**, and then choose **Extensions**.

6. In the details pane, choose the **WinRT Math Library** extension.

    Additional information about your SDK appears. You can choose the **More Information** link to open https://msdn.microsoft.com/, as you specified in the SDKManifest.xml file earlier in this walkthrough.

7. In the **Reference Manager** dialog box, select the **WinRT Math Library** check box, and then choose the **OK** button.

8. On the menu bar, choose **View** > **Object Browser**.

9. In the **Browse** list, choose **Simple Math**.

     You can now explore what's in the SDK.

10. In **Solution Explorer**, open **MainPage.xaml**, and replace its contents with the following XAML:

    **C#**

    ```xml
    <Page
        x:Class="ArithmeticUI.MainPage"
        IsTabStop="False"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:local="using:SimpleMath"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        mc:Ignorable="d">

        <Grid Background="{StaticResource ApplicationPageBackgroundThemeBrush}">
            <TextBox x:Name="_firstNumber" HorizontalAlignment="Left" Margin="414,370,0,0" TextWrapping="Wrap" Text="First Number" VerticalAlignment="Top" Height="32" Width="135" TextAlignment="Center"/>
            <TextBox x:Name="_secondNumber" HorizontalAlignment="Left" Margin="613,370,0,0" TextWrapping="Wrap" Text="Second Number" VerticalAlignment="Top" Height="32" Width="135" TextAlignment="Center"/>
            <Button Content="+" HorizontalAlignment="Left" Margin="557,301,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="-" HorizontalAlignment="Left" Margin="557,345,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="*" HorizontalAlignment="Left" Margin="557,389,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="/" HorizontalAlignment="Left" Margin="557,433,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="=" HorizontalAlignment="Left" Margin="755,367,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnResultsClick"/>
            <TextBox x:Name="_result" HorizontalAlignment="Left" Margin="809,370,0,0" TextWrapping="Wrap" Text="Result" VerticalAlignment="Top" Height="32" Width="163" TextAlignment="Center" IsReadOnly="True"/>
        </Grid>
    </Page>
    ```

    **Visual Basic**

    ```xml
    <Page
        x:Class="ArithmeticUI.MainPage"
        IsTabStop="False"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:local="using:SimpleMath"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        mc:Ignorable="d">

        <Grid Background="{StaticResource ApplicationPageBackgroundThemeBrush}">
            <TextBox x:Name="_firstNumber" HorizontalAlignment="Left" Margin="414,370,0,0" TextWrapping="Wrap" Text="First Number" VerticalAlignment="Top" Height="32" Width="135" TextAlignment="Center"/>
            <TextBox x:Name="_secondNumber" HorizontalAlignment="Left" Margin="613,370,0,0" TextWrapping="Wrap" Text="Second Number" VerticalAlignment="Top" Height="32" Width="135" TextAlignment="Center"/>
            <Button Content="+" HorizontalAlignment="Left" Margin="557,301,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="-" HorizontalAlignment="Left" Margin="557,345,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="*" HorizontalAlignment="Left" Margin="557,389,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="/" HorizontalAlignment="Left" Margin="557,433,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnOperatorClick"/>
            <Button Content="=" HorizontalAlignment="Left" Margin="755,367,0,0" VerticalAlignment="Top" Height="39" Width="49" Click="OnResultsClick"/>
            <TextBox x:Name="_result" HorizontalAlignment="Left" Margin="809,370,0,0" TextWrapping="Wrap" Text="Result" VerticalAlignment="Top" Height="32" Width="163" TextAlignment="Center" IsReadOnly="True"/>
        </Grid>
    </Page>
    ```

11. Update **MainPage.xaml.cs** to match the following code:

     [!code-csharp[CreatingAnSDKUsingWinRTDemoApp#2](../extensibility/codesnippet/CSharp/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_5.cs)]
     [!code-vb[CreatingAnSDKUsingWinRTDemoApp#2](../extensibility/codesnippet/VisualBasic/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_5.vb)]

12. Choose the **F5** key to run the app.

13. In the app, enter any two numbers, choose an operation, and then choose the **=** button.

     The correct result appears.

    You have successfully created and used an Extension SDK.

## See also
- [Walkthrough: Create an SDK using C++](../extensibility/walkthrough-creating-an-sdk-using-cpp.md)
- [Walkthrough: Create an SDK using JavaScript](../extensibility/walkthrough-creating-an-sdk-using-javascript.md)
- [Create a Software Development Kit](../extensibility/creating-a-software-development-kit.md)
