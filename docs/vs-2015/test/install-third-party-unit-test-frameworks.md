---
title: "Install third-party unit test frameworks | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: 47893b70-46f8-49dc-84bd-ec820178f683
caps.latest.revision: 12
ms.author: jillfra
manager: jillfra
---
# Install third-party unit test frameworks
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio Test Explorer can run any unit test framework that has developed an adapter interface for the Explorer. The install program of the framework installs the binaries and adds Visual Studio project templates for the languages it supports. When you create a project with the template, the framework is registered with Test Explorer. A Visual Studio solution can contain unit test projects that use different frameworks and that are targeted at different languages. Test Explorer runs them all.

 **Requirements**

- Visual Studio Enterprise, Visual Studio Professional

## Acquiring third-party frameworks
 You can download and install many third-party unit test frameworks by using the Visual Studio Extension Manager, or from the Visual Studio Gallery on the MSDN website. Frameworks can also be downloaded from other sites such as the website of the framework.

### Installing from Visual Studio

1. Choose **Tools** on the standard menu, and then choose **Extensions and Updates**.

2. Expand **Online**, **Visual Studio Gallery**, **Tools**. Choose **Testing**.

3. Browse the list to find the framework.

4. Select the framework and choose **Download**.

   For more information see [Finding and Using Visual Studio Extensions](../ide/finding-and-using-visual-studio-extensions.md).

### Installing from the web
 If you know the framework you are interested in:

1. Open [Visual Studio Marketplace](https://marketplace.visualstudio.com).

2. Type the name of the framework in the **Find** box.

3. Choose the framework in the results list to navigate to the Visual Studio Gallery page for the tool.

   To browse a list of frameworks along with other testing tools:

4. Open [Visual Studio Marketplace](https://marketplace.visualstudio.com).

5. Choose **Browse**.

6. In the **Category** list, expand the **Tools** node and then choose **Testing**.

7. Choose a framework in the results list to navigate to a Visual Studio Gallery page for the tool.

## See Also
 [Unit Test Your Code](../test/unit-test-your-code.md)
