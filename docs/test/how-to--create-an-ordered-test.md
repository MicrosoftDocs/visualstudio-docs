---
title: "How to: Create an Ordered Test"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.ordered.window"
helpviewer_keywords: 
  - "ordered tests"
  - "ordered tests, creating"
ms.assetid: 4f0e4035-41de-450c-b1d8-44292aafa285
caps.latest.revision: 33
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
# How to: Create an Ordered Test
An *ordered test* is a container that holds other tests and guarantees that tests run in a specific order.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
> [!WARNING]
>  In an ordered test, each test is self-contained and independent. So the environment state is not retained between each test that is run.  
  
> [!NOTE]
>  Before you start this procedure, you must have other tests available to include in the ordered test.  
  
### To create an ordered test  
  
1.  In Solution Explorer, open the shortcut menu on a unit test project or a coded UI test project, choose **Add**, and then choose **Ordered Test**.  
  
     The ordered test opens in the main document editing window. You will use this window to select and include tests in the new ordered test.  
  
2.  (Optional) Change the selection of tests to choose from. Choose the down arrow under **Select project to view tests**, and then choose the test project in your solution.  
  
3.  Under **Available tests**, choose a test to select it. You can select multiple tests by using SHIFT+click and CTRL+click.  
  
4.  To move the test or tests into the ordered test, choose the right arrow.  
  
    > [!NOTE]
    >  You can add the same test multiple times to the same ordered test. When you do this, the test will be run as many times as it appears in the ordered test, in the order listed.  
  
     To remove a test from the ordered test, choose the test in the **Selected tests** pane and then choose the left arrow. To remove multiple tests at one time, select them by using SHIFT+click or CTRL+click, and then choose the left arrow.  
  
5.  (Optional) Re-order the tests within the ordered test by choosing a test in the **Selected tests** pane and then choosing the up or down arrow. To re-order multiple tests at one time, select them by using SHIFT+click or CTRL+click, and then choose the up or down arrow.  
  
    > [!NOTE]
    >  Checking **Continue after failure** means that the ordered test will run regardless of the failure of one or more tests. Leaving **Continue after failure** unchecked means that the ordered test will stop running after the first occurrence of a test failure.  
  
 The ordered test is ready to run. For more information about how to run tests, see [How to: Run Tests from Microsoft Visual Studio](../test/how-to--run-tests-from-microsoft-visual-studio.md).  
  
## See Also  
 [How to: Run Tests from Microsoft Visual Studio](../test/how-to--run-tests-from-microsoft-visual-studio.md)