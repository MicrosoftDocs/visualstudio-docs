---
title: "How to: Retrieve Query String Information in an Online ClickOnce Application"
ms.custom: na
ms.date: 10/04/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 48ce098a-a075-481b-a5f5-c8ba11f63120
caps.latest.revision: 19
manager: wpickett
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
# How to: Retrieve Query String Information in an Online ClickOnce Application
The *query string* is the portion of a URL beginning with a question mark (?) that contains arbitrary information in the form *name=value*. Suppose you have a ClickOnce application named `WindowsApp1` that you host on `servername`, and you want to pass in a value for the variable `username` when the application launches. Your URL might look like the following:  
  
 `http://servername/WindowsApp1.application?username=joeuser`  
  
 The following two procedures show how to use a ClickOnce application to obtain query string information.  
  
> [!NOTE]
>  You can only pass information in a query string when your application is being launched using HTTP, instead of using a file share or the local file system.  
  
 The first procedure shows how your ClickOnce application can use a small piece of code to read these values when the application launches.  
  
 The next procedure shows how to configure your ClickOnce application using MageUI.exe so that it can accept query string parameters. You will need to do this whenever you publish your application.  
  
> [!NOTE]
>  See the "Security" section later in this topic before you make a decision to enable this feature.  
  
 For information about how to create a ClickOnce deployment using Mage.exe or MageUI.exe, see [Walkthrough: Manually Deploying a ClickOnce Application](../VS_IDE/Walkthrough--Manually-Deploying-a-ClickOnce-Application.md).  
  
> [!NOTE]
>  Starting in .NET Framework 3.5 SP1, it is possible to pass command-line arguments to an offline ClickOnce application. If you want to supply arguments to the application, you can pass in parameters to the shortcut file with the .APPREF-MS extension.  
  
### To obtain query string information from a ClickOnce application  
  
1.  Place the following code in your project. In order for this code to function, you will have to have a reference to System.Web and add `using` or `Imports` statements for System.Web, System.Collections.Specialized, and System.Deployment.Application.  
  
     [!CODE [ClickOnceQueryString#1](../CodeSnippet/VS_Snippets_Winforms/ClickOnceQueryString#1)]  
  
2.  Call the function defined previously to retrieve a <xref:System.Collections.DictionaryBase.Dictionary?qualifyHint=False> of the query string parameters, indexed by name.  
  
### To enable query string passing in a ClickOnce application with MageUI.exe  
  
1.  Open the .NET Command Prompt and type:  
  
    ```  
    MageUI  
    ```  
  
2.  From the **File** menu, select **Open**, and open the deployment manifest for your ClickOnce application, which is the file ending in the `.application` extension.  
  
3.  Select the **Deployment Options** panel in the left-hand navigation window, and select the **Allow URL parameters to be passed to application** check box.  
  
4.  From the **File** menu, select **Save**.  
  
> [!NOTE]
>  Alternately, you can enable query string passing in Visual Studio. Select the **Allow URL parameters to be passed to application** check box, which can be found by opening the **Project Properties**, selecting the **Publish** tab, clicking the **Options** button, and then selecting **Manifests**.  
  
## Robust Programming  
 When you use query string parameters, you must give careful consideration to how your application is installed and activated. If your application is configured to install on the user's computer from the Web or from a network share, it is likely that the user will activate the application only once through the URL. After that, the user will usually activate your application using the shortcut in the **Start** menu. As a result, your application is guaranteed to receive query string arguments only once during its lifetime. If you choose to store these arguments on the user's machine for future use, you are responsible for storing them in a safe and secure manner.  
  
 If your application is online only, it will always be activated through a URL. Even in this case, however, your application must be written to function properly if the query string parameters are missing or corrupted.  
  
## .NET Framework Security  
 Allow passing URL parameters to your ClickOnce application only if you plan to cleanse the input of any malicious characters before using it. A string embedded with quotes, slashes, or semicolons, for example, might perform arbitrary data operations if used unfiltered in a SQL query against a database. For more information on query string security, see [Script Exploits Overview](../Topic/Script%20Exploits%20Overview.md).  
  
## See Also  
 [Securing ClickOnce Applications](../VS_IDE/Securing-ClickOnce-Applications.md)