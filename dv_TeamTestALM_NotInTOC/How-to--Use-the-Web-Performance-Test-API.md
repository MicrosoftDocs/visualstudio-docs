---
title: "How to: Use the Web Performance Test API"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 93a6a1dd-663b-4ab5-8760-7d6b081561d3
caps.latest.revision: 47
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Use the Web Performance Test API
You can write code for your Web performance tests. The Web performance test API is used to create coded Web performance tests, Web performance test plug-ins, request plug-ins, requests, extraction rules, and validation rules. The classes that make up these types are the core classes in this API. The other types in this API are used to support creating <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTest?qualifyHint=False>, <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestPlugin?qualifyHint=False>, <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRequestPlugin?qualifyHint=False>, <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRequest?qualifyHint=False>, <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRule?qualifyHint=False>, and <xref:Microsoft.VisualStudio.TestTools.WebTesting.ValidationRule?qualifyHint=False> objects. You use the <xref:Microsoft.VisualStudio.TestTools.WebTesting?qualifyHint=False> namespace to create customized Web performance tests.  
  
 You can also use the Web performance test API to programmatically create and save declarative Web performance tests. To do this, use the <xref:Microsoft.VisualStudio.TestTools.WebTesting.DeclarativeWebTest?qualifyHint=False> and <xref:Microsoft.VisualStudio.TestTools.WebTesting.DeclarativeWebTestSerializer?qualifyHint=False> classes.  
  
> [!TIP]
>  Use the object browser to examine the <xref:Microsoft.VisualStudio.TestTools.WebTesting?qualifyHint=False> namespace. Both the Visual C# and Visual Basic editors offer IntelliSense support for coding with the classes in the namespace.  
  
 You can also create plug-ins for load tests. For more information, see [How to: Use the Load Test API](../dv_TeamTestALM/How-to--Use-the-Load-Test-API.md) and [How to: Create a Load Test Plug-In](../dv_TeamTestALM/How-to--Create-a-Load-Test-Plug-In.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To use the WebTesting namespace  
  
1.  Open a Web performance and load test project that contains a Web performance test.  
  
     For more information, see [Creating and Editing Web Performance Tests](assetId:///8bf5f2a7-c693-47d6-9282-5946480151dc).  
  
2.  Add a Visual C# or a Visual Basic class library project to your test solution.  
  
3.  Add a reference in the Web performance and load test project to the class library project.  
  
4.  Add a reference to the Microsoft.VisualStudio.QualityTools.WebTestFramework DLL in the class library project.  
  
5.  In the class file that is located in the class library project, add a `using` statement for the <xref:Microsoft.VisualStudio.TestTools.WebTesting?qualifyHint=False> namespace.  
  
6.  Create a class that implements the <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestPlugin?qualifyHint=False> interface.  
  
7.  Build the project.  
  
8.  Add the new Web performance test plug-in by using the Web Performance Test Editor:  
  
    1.  Choose **Add Web Test Plug-in** on the toolbar.  
  
         The **Add Web Test Plug-in** dialog box is displayed.  
  
    2.  Under **Select a plug-in**, select your Web performance test plug-in class.  
  
    3.  In the **Properties for selected plug-in** pane, set the initial values for the plug-in to use at run time.  
  
        > [!NOTE]
        >  You can expose as many properties as you want from your plug-ins; just make them public, settable, and of a base type such as Integer, Boolean, or String. You can also edit the Web performance test plug-in properties later by using the Properties window.  
  
    4.  Choose **OK**.  
  
9. Run your Web performance test.  
  
     For an example implementation of <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestPlugin?qualifyHint=False>, see [How to: Create a Web Performance Test Plug-In](../dv_TeamTestALM/How-to--Create-a-Web-Performance-Test-Plug-In.md).  
  
## See Also  
 <xref:Microsoft.VisualStudio.TestTools.WebTesting?qualifyHint=False>   
 [Create custom code and plug-ins for load tests](../dv_TeamTestALM/Create-custom-code-and-plug-ins-for-load-tests.md)   
 [How to: Use the Load Test API](../dv_TeamTestALM/How-to--Use-the-Load-Test-API.md)   
 [How to: Create a Web Performance Test Plug-In](../dv_TeamTestALM/How-to--Create-a-Web-Performance-Test-Plug-In.md)