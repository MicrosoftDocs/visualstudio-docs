---
title: "Walkthrough: Creating an SDK using C++ | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
ms.assetid: 36ea793b-3832-41a1-b906-69e680ad5e1d
caps.latest.revision: 33
ms.author: gregvanl
manager: jillfra
---
# Walkthrough: Creating an SDK using C++
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough shows how to create a native C++ math library SDK, package the SDK as a Visual Studio Extension (VSIX), and then use it to create an app. The walkthrough is divided into these steps:  
  
- [To create the native and Windows Runtime libraries](../extensibility/walkthrough-creating-an-sdk-using-cpp.md#createClassLibrary)  
  
- [To create the NativeMathVSIX extension project](../extensibility/walkthrough-creating-an-sdk-using-cpp.md#createVSIX)  
  
- [To create a sample app that uses the class library](../extensibility/walkthrough-creating-an-sdk-using-cpp.md#createSample)  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).  
  
## <a name="createClassLibrary"></a> To create the native and Windows Runtime libraries  
  
1. On the menu bar, choose **File**, **New**, **Project**.  
  
2. In the list of templates, expand **Visual C++**, **Windows Store**, and then select the **DLL (Windows Store apps)** template. In the **Name** box, specify `NativeMath`, and then choose the **OK** button.  
  
3. Update NativeMath.h to match the following code.  
  
     [!code-cpp[CreatingAnSDKUsingCpp#1](../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemath/nativemath.h#1)]  
  
4. Update NativeMath.cpp to match this code:  
  
     [!code-cpp[CreatingAnSDKUsingCpp#2](../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemath/nativemath.cpp#2)]  
  
5. In **Solution Explorer**, open the shortcut menu for **Solution 'NativeMath'**, and then choose **Add**, **New Project**.  
  
6. In the list of templates, expand **Visual C++**, and then select the **Windows Runtime Component** template. In the **Name** box, specify `NativeMathWRT`, and then choose the **OK** button.  
  
7. Update Class1.h to match this code:  
  
     [!code-cpp[CreatingAnSDKUsingCpp#3](../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemathwrt/class1.h#3)]  
  
8. Update Class1.cpp to match this code:  
  
     [!code-cpp[CreatingAnSDKUsingCpp#4](../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemathwrt/class1.cpp#4)]  
  
9. On the menu bar, choose **Build**, **Build Solution**.  
  
## <a name="createVSIX"></a> To create the NativeMathVSIX extension project  
  
1. In **Solution Explorer**, open the shortcut menu for **Solution ‘NativeMath’**, and then choose **Add**, **New Project**.  
  
2. In the list of templates, expand **Visual C#**, **Extensibility**, and then select **VSIX Package**. In the **Name** box, specify **NativeMathVSIX**, and then choose the **OK** button.  
  
3. When the VSIX manifest designer appears, close it.  
  
4. In **Solution Explorer**, open the shortcut menu for **source.extension.vsixmanifest**, and then choose **View Code**.  
  
5. Use the following XML to replace the existing XML.  
  
    [!code-xml[CreatingAnSDKUsingCpp#6](../../extensibility/codesnippet/XML/walkthrough-creating-an-sdk-using-cpp_6.xml)]
  
6. In **Solution Explorer**, open the shortcut menu for the **NativeMathVSIX** project, and then choose **Add**, **New Item**.  
  
7. In the list of **Visual C# Items**, expand **Data**, and then select **XML File**. In the **Name** box, specify `SDKManifest.xml`, and then choose the **OK** button.  
  
8. Use this XML to replace the contents of the file:  
  
     [!code-xml[CreatingAnSDKUsingCpp#5](../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcpp/cpp/nativemathvsix/sdkmanifest.xml#5)]  
  
9. In **Solution Explorer**, in the **NativeMathVSIX** project, create this folder structure:  
  
    ```  
  
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
  
10. In **Solution Explorer**, open the shortcut menu for **Solution ‘NativeMath’**, and then choose **Open Folder in File Explorer**.  
  
11. In **File Explorer**, copy \NativeMath\NativeMath.h, and then in **Solution Explorer**, in the **NativeMathVSIX** project, paste it in the \DesignTime\CommonConfiguration\Neutral\Include\ folder.  
  
     Copy \Debug\NativeMath\NativeMath.lib, and then paste it in the \DesignTime\Debug\x86\ folder.  
  
     Copy \Debug\NativeMath\NativeMath.dll and paste it in the \Redist\Debug\x86\ folder.  
  
     Copy DebugNativeMathWRTNativeMathWRT.dll and paste it in the RedistDebugx86 folder.  
  
     Copy DebugNativeMathWRTNativeMathWRT.winmd and paste it in the ReferencesCommonConfigurationNeutral folder.  
  
     Copy DebugNativeMathWRTNativeMathWRT.pri and paste it in the ReferencesCommonConfigurationNeutral folder.  
  
12. In the \DesignTime\Debug\x86\ folder, create a text file that’s named NativeMathSDK.props, and then paste the following contents in it:  
  
    [!code-xml[CreatingAnSDKUsingCpp#7](../../extensibility/codesnippet/XML/walkthrough-creating-an-sdk-using-cpp_7.xml)]  
  
13. On the menu bar, choose **View**, **Other Windows**, **Properties Window** (Keyboard: Choose the F4 key).  
  
14. In **Solution Explorer**, select the **NativeMathWRT.winmd** file. In the **Properties** window, change the **Build Action** property to **Content**, and then change the **Include in VSIX** property to **True**.  
  
     Repeat this process for the **SimpleMath.pri** file.  
  
     Repeat this process for the **NativeMath.Lib** file.  
  
     Repeat this process for the **NativeMathSDK.props** file.  
  
15. In **Solution Explorer**, select the **NativeMath.h** file. In the **Properties** window, change the **Include in VSIX** property to **True**.  
  
     Repeat this process for the **NativeMath.dll** file.  
  
     Repeat this process for the **NativeMathWRT.dll** file.  
  
     Repeat this process for the **SDKManifest.xml** file.  
  
16. On the menu bar, choose **Build**, **Build Solution**.  
  
17. In **Solution Explorer**, open the shortcut menu for the **NativeMathVSIX** project, and then choose **Open Folder in File Explorer**.  
  
18. In **File Explorer**, navigate to the \bin\Debug\ folder, and then run NativeMathVSIX.vsix to begin the installation.  
  
19. Choose the **Install** button, wait for the installation to finish, and then restart Visual Studio.  
  
## <a name="createSample"></a> To create a sample app that uses the class library  
  
1. On the menu bar, choose **File**, **New**, **Project**.  
  
2. In the list of templates, expand **Visual C++**, **Windows  Store**, and then select **Blank App**. In the **Name** box, specify **NativeMathSDKSample**, and then choose the **OK** button.  
  
3. In **Solution Explorer**, open the shortcut menu for the **NativeMathSDKSample** project, and then choose **Add**, **Reference**.  
  
4. On the **Common Properties**, **Framework and References** property page, in the list of reference types, expand **Windows**, and then select **Extensions**. In the details pane, select the **Native Math SDK** extension, and then choose the **Add New Reference** button.  
  
5. In the **Add Reference** dialog box, select the **Native Math SDK** check box, and then choose the **OK** button.  
  
6. Display the project properties for NativeMathSDKSample.  
  
    The properties that you defined in NativeMathSDK.props were applied when you added the reference. You can verify this by examining the **VC++ Directories** property of the project's **Configuration Properties**.  
  
7. In **Solution Explorer**, open MainPage.xaml, and then use the following XAML to replace its content:  
  
    [!code-xml[CreatingAnSDKUsingCppDemoApp#1](../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcppdemoapp/cpp/mainpage.xaml#1)]  
  
8. Update Mainpage.xaml.h to match this code:  
  
    [!code-cpp[CreatingAnSDKUsingCppDemoApp#2](../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcppdemoapp/cpp/mainpage.xaml.h#2)]  
  
9. Update MainPage.xaml.cpp to match this code:  
  
     [!code-cpp[CreatingAnSDKUsingCppDemoApp#3](../snippets/cpp/VS_Snippets_VSSDK/creatingansdkusingcppdemoapp/cpp/mainpage.xaml.cpp#3)]  
  
10. Choose the F5 key to run the app.  
  
11. In the app, enter any two numbers, select an operation, and then choose the **=** button.  
  
     The correct result appears.  
  
    This walkthrough showed how to create and use an Extension SDK to call into a [!INCLUDE[wrt](../includes/wrt-md.md)] library and a non-[!INCLUDE[wrt](../includes/wrt-md.md)] library.  
  
## Next Steps  
  
## See Also  
 [Walkthrough: Creating an SDK using C# or Visual Basic](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md)   
 [Creating a Software Development Kit](../extensibility/creating-a-software-development-kit.md)
