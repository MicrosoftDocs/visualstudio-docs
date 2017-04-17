---
title: "Install third-party unit test frameworks | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 47893b70-46f8-49dc-84bd-ec820178f683
caps.latest.revision: 10
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Install third-party unit test frameworks
Visual Studio Test Explorer can run any unit test framework that has developed an adapter interface for the Explorer. The install program of the framework installs the binaries and adds Visual Studio project templates for the languages it supports. When you create a project with the template, the framework is registered with Test Explorer. A Visual Studio solution can contain unit test projects that use different frameworks and that are targeted at different languages. Test Explorer runs them all.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, Visual Studio Professional  
  
## Acquiring third-party frameworks  
 You can download and install many third-party unit test frameworks by using the Visual Studio Extension Manager, or from the Visual Studio Gallery on the MSDN website. Frameworks can also be downloaded from other sites such as the website of the framework.  
  
### Installing from Visual Studio  
  
1.  Choose **Tools** on the standard menu, and then choose **Extensions and Updates**.  
  
2.  Expand **Online**, **Visual Studio Gallery**, **Tools**. Choose **Testing**.  
  
3.  Browse the list to find the framework.  
  
4.  Select the framework and choose **Download**.  
  
 For more information see [Finding and Using Visual Studio Extensions](../ide/finding-and-using-visual-studio-extensions.md).  
  
### Installing from the web  
 If you know the framework you are interested in:  
  
1.  Open [Visual Studio Gallery](http://go.microsoft.com/fwlink/?LinkId=236267) on the MSDN website.  
  
2.  Type the name of the framework in the **Find** box.  
  
3.  Choose the framework in the results list to navigate to the Visual Studio Gallery page for the tool.  
  
 To browse a list of frameworks along with other testing tools:  
  
1.  Open [Visual Studio Gallery](http://go.microsoft.com/fwlink/?LinkId=236267) on the MSDN website.  
  
2.  Choose **Browse**.  
  
3.  In the **Category** list, expand the **Tools** node and then choose **Testing**.  
  
4.  Choose a framework in the results list to navigate to a Visual Studio Gallery page for the tool.  
  
## See Also  
 [Unit Test Your Code](../test/unit-test-your-code.md)
