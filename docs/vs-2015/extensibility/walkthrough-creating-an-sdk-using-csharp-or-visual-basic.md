---
title: "Walkthrough: Creating an SDK using C# or Visual Basic | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
ms.assetid: ef96a249-5eef-402a-a8d5-d74cb49239bd
caps.latest.revision: 21
ms.author: gregvanl
manager: jillfra
---
# Walkthrough: Creating an SDK using C# or Visual Basic
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this walkthrough, you’ll learn how to create a simple Math Library SDK by using Visual C# and then package the SDK as a Visual Studio Extension (VSIX). You’ll complete the following procedures:  
  
- [To create the SimpleMath Windows Runtime component](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md#createClassLibrary)  
  
- [To create the SimpleMathVSIX extension project](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md#createVSIX)  
  
- [To create a sample app that uses the class library](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md#createSample)  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).  
  
## <a name="createClassLibrary"></a> To create the SimpleMath Windows Runtime component  
  
1. On the menu bar, choose **File**, **New**, **New Project**.  
  
2. In the list of templates, expand **Visual C#** or **Visual Basic**, choose the **Windows Store** node, and then choose the **Windows Runtime Component** template.  
  
3. In the **Name** box, specify **SimpleMath**, and then choose the **OK** button.  
  
4. In **Solution Explorer**, open the shortcut menu for the **SimpleMath** project node, and then choose **Properties**.  
  
5. Rename **Class1.cs** to **Arithmetic.cs** and update it to match the following code:  
  
     [!code-csharp[CreatingAnSDKUsingWinRT#3](../snippets/csharp/VS_Snippets_VSSDK/creatingansdkusingwinrt/cs/winrtmath/arithmetic.cs#3)]
     [!code-vb[CreatingAnSDKUsingWinRT#3](../snippets/visualbasic/VS_Snippets_VSSDK/creatingansdkusingwinrt/vb/winrtmath/arithmetic.vb#3)]  
  
6. In **Solution Explorer**, open the shortcut menu for the **Solution 'SimpleMath'** node, and then choose **Configuration Manager**.  
  
     The **Configuration Manager** dialog box opens.  
  
7. In the **Active solution configuration** list, choose **Release**.  
  
8. In the **Configuration** column, verify that **SimpleMath** row is set to **Release**, and then choose the **Close** button to accept the change.  
  
    > [!IMPORTANT]
    > The SDK for the SimpleMath component includes only one configuration. This configuration must be the release build, or apps that use the component won't pass certification for the[!INCLUDE[win8_appstore_long](../includes/win8-appstore-long-md.md)].  
  
9. In **Solution Explorer**, open the shortcut menu for the **SimpleMath** project node, and then choose **Build**.  
  
## <a name="createVSIX"></a> To create the SimpleMathVSIX extension project  
  
1. On the shortcut menu for the **Solution ‘SimpleMath’** node, choose **Add**, **New Project**.  
  
2. In the list of templates, expand **Visual C#** or **Visual Basic**, choose the **Extensibility** node, and then choose the **VSIX Project** template.  
  
3. In the **Name** box, specify **SimpleMathVSIX**, and then choose the **OK** button.  
  
4. In **Solution Explorer**, choose the **source.extension.vsixmanifest** item.  
  
5. On the menu bar, choose **View**, **Code**.  
  
6. Replace the existing XML with the following XML:  
  
     [!code-xml[CreatingAnSDKUsingWinRT#1](../../extensibility/codesnippet/XML/walkthrough-creating-an-sdk-using-csharp-or-visual-basic_2.xml)]
  
7. In **Solution Explorer**, choose the **SimpleMathVSIX** project.  
  
8. On the menu bar, choose **Project**, **Add New Item**.  
  
9. In the list of **Common Items**, expand **Data**, and then choose **XML File**.  
  
10. In the **Name** box, specify `SDKManifest.xml`, and then choose the **Add** button.  
  
11. In **Solution Explorer**, open the shortcut menu for `SDKManifest.xml`, choose **Properties**, and then change the value of the **Include in VSIX** property to **True**.  
  
12. Replace the contents of the file with the following XML:  
  
     [!code-xml[CreatingAnSDKUsingWinRT#1](../snippets/csharp/VS_Snippets_VSSDK/creatingansdkusingwinrt/cs/winrtmathvsix/sdkmanifest.xml#1)]
     [!code-xml[CreatingAnSDKUsingWinRT#1](../snippets/visualbasic/VS_Snippets_VSSDK/creatingansdkusingwinrt/vb/winrtmathvsix/sdkmanifest.xml#1)]  
  
13. In **Solution Explorer**, open the shortcut menu for the **SimpleMathVSIX** project, choose **Add**, and then choose **New Folder**.  
  
14. Rename the folder to `references`.  
  
15. Open the shortcut menu for the **References** folder, choose **Add**, and then choose **New Folder**.  
  
16. Rename the subfolder to `commonconfiguration`, create a subfolder within it, and name the subfolder `neutral`.  
  
17. Repeat the previous four steps, this time renaming the first folder to `redist`.  
  
     The project now contains the following folder structure:  
  
    ```  
    references\commonconfiguration\neutral  
    redist\commonconfiguration\neutral  
    ```  
  
18. In **Solution Explorer**, open the shortcut menu for the **SimpleMath** project, and then choose **Open Folder in File Explorer**.  
  
19. In **File Explorer**, navigate to the bin\Release folder, open the shortcut menu for the SimpleMath.winmd file, and then choose **Copy**.  
  
20. In **Solution Explorer**, paste the file into the references\commonconfiguration\neutral folder in the **SimpleMathVSIX** project.  
  
21. Repeat the previous step, pasting the SimpleMath.pri file into the redist\commonconfiguration\neutral folder in the **SimpleMathVSIX** project.  
  
22. In **Solution Explorer**, choose **SimpleMath.winmd**.  
  
23. On the menu bar, choose **View**, **Properties** (Keyboard: Choose the F4 key).  
  
24. In the **Properties** window, change the **Build Action** property to **Content**, and then change the **Include in VSIX** property to **True**.  
  
25. In **Solution Explorer**, repeat this process for **SimpleMath.pri**.  
  
26. In **Solution Explorer**, choose the **SimpleMathVSIX** project.  
  
27. On the menu bar, choose **Build**, **Build SimpleMathVSIX**.  
  
28. In **Solution Explorer**, open the shortcut menu for the **SimpleMathVSIX** project, and then choose **Open Folder in File Explorer**.  
  
29. In **File Explorer**, navigate to \bin\Release folder, and then run SimpleMathVSIX.vsix to install it.  
  
30. Choose the **Install** button, wait for the installation to finish, and then restart Visual Studio.  
  
## <a name="createSample"></a> To create a sample app that uses the class library  
  
1. On the menu bar, choose **File**, **New**, **New Project**.  
  
2. In the list of templates, expand **Visual C#** or **Visual Basic**, and then choose the **Windows Store** node.  
  
3. Choose the **Blank App** template, name the project **ArithmeticUI**, and then choose the **OK** button.  
  
4. In **Solution Explorer**, open the shortcut menu for the **ArithmeticUI** project, and then choose **Add**, **Reference**.  
  
5. In the list of reference types, expand **Windows**, and then choose **Extensions**.  
  
6. In the details pane, choose the **Simple Math SDK** extension.  
  
    Additional information about your SDK appears. You can choose the **More Information** link to open http://www.msdn.microsoft.com, as you specified in the SDKManifest.xml file earlier in this walkthrough.  
  
7. In the **Reference Manager** dialog box, select the **Simple Math SDK** check box, and then choose the **OK** button.  
  
8. On the menu bar, choose **View**, **Object Browser**.  
  
9. In the **Browse** list, choose **Simple Math**.  
  
     You can now explore what’s in the SDK.  
  
10. In **Solution Explorer**, open MainPage.xaml, and replace its contents with the following XAML:  
  
     [!code-xml[CreatingAnSDKUsingWinRTDemoApp#1](../snippets/csharp/VS_Snippets_VSSDK/creatingansdkusingwinrtdemoapp/cs/winrtmathtest/mainpage.xaml#1)]
     [!code-xml[CreatingAnSDKUsingWinRTDemoApp#1](../snippets/visualbasic/VS_Snippets_VSSDK/creatingansdkusingwinrtdemoapp/vb/winrtmathtest/mainpage.xaml#1)]  
  
11. Update MainPage.xaml.cs to match the following code:  
  
     [!code-csharp[CreatingAnSDKUsingWinRTDemoApp#2](../snippets/csharp/VS_Snippets_VSSDK/creatingansdkusingwinrtdemoapp/cs/winrtmathtest/mainpage.xaml.cs#2)]
     [!code-vb[CreatingAnSDKUsingWinRTDemoApp#2](../snippets/visualbasic/VS_Snippets_VSSDK/creatingansdkusingwinrtdemoapp/vb/winrtmathtest/mainpage.xaml.vb#2)]  
  
12. Choose the F5 key to run the app.  
  
13. In the app, enter any two numbers, choose an operation, and then choose the **=** button.  
  
     The correct result appears.  
  
    You have successfully created and used an Extension SDK.  
  
## See Also  
 [Walkthrough: Creating an SDK using C++](../extensibility/walkthrough-creating-an-sdk-using-cpp.md)   
 [Walkthrough: Creating an SDK using JavaScript](walkthrough-creating-an-sdk-using-javascript.md)   
 [Creating a Software Development Kit](../extensibility/creating-a-software-development-kit.md)
