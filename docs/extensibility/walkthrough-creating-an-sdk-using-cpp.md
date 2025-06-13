---
title: 'Walkthrough: Creating an SDK using C++'
description: Learn how to create a native C++ math library SDK, package the SDK as a Visual Studio Extension, and then use it to create an app by using this walkthrough.
ms.date: 11/04/2016
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Walkthrough: Create an SDK using C++

This walkthrough shows how to create a native C++ math library SDK, package the SDK as a Visual Studio Extension (VSIX), and then use it to create an app. The walkthrough is divided into these steps:

- [To create the native and Windows Runtime libraries](../extensibility/walkthrough-creating-an-sdk-using-cpp.md#createClassLibrary)

- [To create the NativeMathVSIX extension project](../extensibility/walkthrough-creating-an-sdk-using-cpp.md#createVSIX)

- [To create a sample app that uses the class library](../extensibility/walkthrough-creating-an-sdk-using-cpp.md#createSample)

## Prerequisites
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

## <a name="createClassLibrary"></a> To create the native and Windows Runtime libraries

1. On the menu bar, choose **File** > **New** > **Project**.

2. In the list of templates, expand **Visual C++** > **Windows Universal**, and then select the **DLL (Windows Universal apps)** template. In the **Name** box, specify `NativeMath`, and then choose the **OK** button.

3. Update *NativeMath.h* to match the following code.

     :::code language="cpp" source="../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemath/nativemath.h" id="Snippet1":::

4. Update *NativeMath.cpp* to match this code:

     :::code language="cpp" source="../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemath/nativemath.cpp" id="Snippet2":::

5. In **Solution Explorer**, open the shortcut menu for **Solution 'NativeMath'**, and then choose **Add** > **New Project**.

6. In the list of templates, expand **Visual C++**, and then select the **Windows Runtime Component** template. In the **Name** box, specify `NativeMathWRT`, and then choose the **OK** button.

7. Update *Class1.h* to match this code:

     :::code language="cpp" source="../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemathwrt/class1.h" id="Snippet3":::

8. Update *Class1.cpp* to match this code:

     :::code language="cpp" source="../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemathwrt/class1.cpp" id="Snippet4":::

9. On the menu bar, choose **Build** > **Build Solution**.

## <a name="createVSIX"></a> To create the NativeMathVSIX extension project

1. In **Solution Explorer**, open the shortcut menu for **Solution 'NativeMath'**, and then choose **Add** > **New Project**.

2. In the list of templates, expand **Visual C#** > **Extensibility**, and then select **VSIX Project**. In the **Name** box, specify **NativeMathVSIX**, and then choose the **OK** button.

3. In **Solution Explorer**, open the shortcut menu for **source.extension.vsixmanifest**, and then choose **View Code**.

4. Use the following XML to replace the existing XML.

    :::code language="xml" source="../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemathvsix/source.extension.vsixmanifest" id="Snippet6":::

5. In **Solution Explorer**, open the shortcut menu for the **NativeMathVSIX** project, and then choose **Add** > **New Item**.

6. In the list of **Visual C# Items**, expand **Data**, and then select **XML File**. In the **Name** box, specify `SDKManifest.xml`, and then choose the **OK** button.

7. Use this XML to replace the contents of the file:

    :::code language="xml" source="../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemathvsix/sdkmanifest.xml" id="Snippet5":::

8. In **Solution Explorer**, under the **NativeMathVSIX** project, create this folder structure:

    ```xml
    \DesignTime
          \CommonConfiguration
                \Neutral
                      \Include
          \Debug
                \x86
    \Redist
          \Debug
                \x86
    \References
          \CommonConfiguration
                \Neutral
    ```

9. In **Solution Explorer**, open the shortcut menu for **Solution 'NativeMath'**, and then choose **Open Folder in File Explorer**.

10. In **File Explorer**, copy *$SolutionRoot$\NativeMath\NativeMath.h*, and then in **Solution Explorer**, under the **NativeMathVSIX** project, paste it in the *$SolutionRoot$\NativeMathVSIX\DesignTime\CommonConfiguration\Neutral\Include\\* folder.

     Copy *$SolutionRoot$\Debug\NativeMath\NativeMath.lib*, and then paste it in the *$SolutionRoot$\NativeMathVSIX\DesignTime\Debug\x86\\* folder.

     Copy *$SolutionRoot$\Debug\NativeMath\NativeMath.dll* and paste it in the *$SolutionRoot$\NativeMathVSIX\Redist\Debug\x86\\* folder.

     Copy *$SolutionRoot$\Debug\NativeMathWRT\NativeMathWRT.dll* and paste it in the *$SolutionRoot$\NativeMathVSIX\Redist\Debug\x86* folder.
     Copy *$SolutionRoot$\Debug\NativeMathWRT\NativeMathWRT.winmd* and paste it in the *$SolutionRoot$\NativeMathVSIX\References\CommonConfiguration\Neutral* folder.

     Copy *$SolutionRoot$\Debug\NativeMathWRT\NativeMathWRT.pri* and paste it in the *$SolutionRoot$\NativeMathVSIX\References\CommonConfiguration\Neutral* folder.

11. In the *$SolutionRoot$\NativeMathVSIX\DesignTime\Debug\x86\\* folder, create a text file that's named *NativeMathSDK.props*, and then paste the following contents in it:
   
    ```xml
    <Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
      <PropertyGroup>
        <NativeMathSDKPath>$(FrameworkSDKRoot)\..\..\UAP\v0.8.0.0\ExtensionSDKs\NativeMathSDK\1.0\</NativeMathSDKPath>
        <IncludePath>$(NativeMathSDKPath)DesignTime\CommonConfiguration\Neutral\Include;$(IncludePath)</IncludePath>
        <LibraryPath>$(NativeMathSDKPath)DesignTime\Debug\x86;$(LibraryPath)</LibraryPath>
      </PropertyGroup>
      <ItemDefinitionGroup Condition="'$(Configuration)|$(Platform)'=='Debug|Win32'">
         <Link>
           <AdditionalDependencies>NativeMath.lib;%(AdditionalDependencies)</AdditionalDependencies>
         </Link>
      </ItemDefinitionGroup>
    </Project>
    ```

12. On the menu bar, choose **View** > **Other Windows** > **Properties Window** (Keyboard: Choose the **F4** key).

13. In **Solution Explorer**, select the **NativeMathWRT.winmd** file. In the **Properties** window, change the **Build Action** property to **Content**, and then change the **Include in VSIX** property to **True**.

     Repeat this process for the **NativeMath.h** file.

     Repeat this process for the **NativeMathWRT.pri** file.

     Repeat this process for the **NativeMath.Lib** file.

     Repeat this process for the **NativeMathSDK.props** file.

14. In **Solution Explorer**, select the **NativeMath.h** file. In the **Properties** window, change the **Include in VSIX** property to **True**.

     Repeat this process for the **NativeMath.dll** file.

     Repeat this process for the **NativeMathWRT.dll** file.

     Repeat this process for the **SDKManifest.xml** file.

15. On the menu bar, choose **Build** > **Build Solution**.

16. In **Solution Explorer**, open the shortcut menu for the **NativeMathVSIX** project, and then choose **Open Folder in File Explorer**.

17. In **File Explorer**, navigate to the *$SolutionRoot$\NativeMathVSIX\bin\Debug* folder, and then run *NativeMathVSIX.vsix* to begin the installation.

18. Choose the **Install** button, wait for the installation to finish, and then open Visual Studio.

## <a name="createSample"></a> To create a sample app that uses the class library

1. On the menu bar, choose **File** > **New** > **Project**.

2. In the list of templates, expand **Visual C++** > **Windows Universal** and then select **Blank App**. In the **Name** box, specify **NativeMathSDKSample**, and then choose the **OK** button.

3. In **Solution Explorer**, open the shortcut menu for the **NativeMathSDKSample** project, and then choose **Add** > **Reference**.

4. In the **Add Reference** dialog box, in the list of reference types, expand **Universal Windows**, and then select **Extensions**. Finally, Select the **Native Math SDK** check box, and then choose the **OK** button.

5. Display the project properties for NativeMathSDKSample.

    The properties that you defined in *NativeMathSDK.props* were applied when you added the reference. You can verify the properties were applied by examining the **VC++ Directories** property of the project's **Configuration Properties**.

6. In **Solution Explorer**, open **MainPage.xaml**, and then use the following XAML to replace its content:

    :::code language="xml" source="../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcppdemoapp/cpp/mainpage.xaml" id="Snippet1":::

7. Update *Mainpage.xaml.h* to match this code:

    :::code language="cpp" source="../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcppdemoapp/cpp/mainpage.xaml.h" id="Snippet2":::

8. Update *MainPage.xaml.cpp* to match this code:

    :::code language="cpp" source="../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcppdemoapp/cpp/mainpage.xaml.cpp" id="Snippet3":::

9. Choose the **F5** key to run the app.

10. In the app, enter any two numbers, select an operation, and then choose the **=** button.

     The correct result appears.

    This walkthrough showed how to create and use an Extension SDK to call into a Windows Runtime library and a non-Windows Runtime library.

## Related content
- [Walkthrough: Create an SDK using C# or Visual Basic](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md)
- [Create a software development kit](../extensibility/creating-a-software-development-kit.md)
