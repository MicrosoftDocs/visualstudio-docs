---
title: "Generic Test Sample"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "samples, testing [Visual Studio ALM]"
  - "Generic Test sample [Visual Studio ALM]"
  - "testing, samples"
  - "generic tests, samples"
ms.assetid: 5a54859d-0c21-4587-9eb3-b89b389ec828
caps.latest.revision: 21
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
# Generic Test Sample
The "EvenOdd" sample is a project that you can build into a simple program. You can then wrap this program as a generic test. The files of this sample are provided for the following walkthrough: [Walkthrough: Creating and Running a Generic Test](../test/walkthrough--creating-and-running-a-generic-test.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Sample Code  
 The code for this sample is available here:  
  
 [!code[EvenOdd#1](../test/codesnippet/CSharp/generic-test-sample_1.cs)]  
  
## Working with the Code  
 To work with this code, you first have to create a project for it in [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)]. Follow the steps in the "Prepare the Walkthrough" section in [Walkthrough: Creating and Running a Generic Test](../test/walkthrough--creating-and-running-a-generic-test.md).  
  
## About the EvenOdd Sample Program  
 The EvenOdd sample is a Visual C# console application. It returns a value of either 1 or 0, depending on the argument you pass it:  
  
-   If you pass no argument and the seconds field of the current system time is even, the program returns 0. If you pass no argument and the value of the seconds field is odd, the program returns 1.  
  
-   If you pass a single numeric argument, and the number you pass is even, the program returns 0. If the number you pass is odd, the program returns 1. If you pass a non-numeric argument, the program returns 1. This causes the generic test that wraps the program to produce a Failed result.  
  
-   If you pass two arguments and the second argument represents a file that exists in the same directory as the program, the program returns 0; otherwise, the program returns 1.  
  
-   All other cases will fail.  
  
## See Also  
 [Walkthrough: Creating and Running a Generic Test](../test/walkthrough--creating-and-running-a-generic-test.md)