---
title: "How to: Debug while a Test is Running"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "tests, debugging during"
  - "testing, debugging during"
  - "debugging [Visual Studio ALM], during tests"
  - "code, debugging while testing"
ms.assetid: 76d82c42-08f3-421a-953c-0a4f707cb501
caps.latest.revision: 43
ms.author: "ahomer"
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
# How to: Debug while a Test is Running
You can debug your code while a unit test is running. There are two ways to do this:  
  
-   If your production code or the test itself is running in either an IIS process or in the ASP.NET Development Server process, use the procedure that is described in [How to: Debug while Running a Test in an ASP.NET Solution](../test/how-to--debug-while-running-a-test-in-an-asp.net-solution.md).  
  
-   In all other cases, use the procedure that is described in this topic.  
  
### How to debug code while running a unit test  
  
1.  (Optional) Set one or more breakpoints in your code.  
  
2.  Press **CTRL+R** and then **CTRL+T**.  
  
     \- or -  
  
     On the Test menu, choose **Debug** and then choose **Selected Tests**.  
  
     The first unit test runs until a breakpoint is encountered in your code. While the test is running, you can use the usual debugging commands, such as **Continue** and **Step Out**. The unit test does not produce a final result until the code path through the method has been completed.  
  
     If you selected multiple tests in **Test Explorer** window, or if you chose **Debug All Tests**, the test run continues with subsequent tests. In those tests as well, the test runs until encountering a breakpoint.  
  
    > [!NOTE]
    >  You can do this only while you are running tests locally, that is, on your own computer. You cannot debug while you are running tests remotely, by using a test controller and test agents.  
  
## See Also  
 [How to: Run Tests from Microsoft Visual Studio](../test/how-to--run-tests-from-microsoft-visual-studio.md)   
 [How to: Debug while Running a Test in an ASP.NET Solution](../test/how-to--debug-while-running-a-test-in-an-asp.net-solution.md)