---
title: "Review continuous test results after a build"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2a4acf26-d61b-4a23-85b1-d634b87a270d
caps.latest.revision: 9
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
# Review continuous test results after a build
After your build finishes running automated tests using Visual Studio Online or Team Foundation Server, review your test results to start analyzing any problems that you found.  
  
1.  In Visual Studio Online or Team Foundation Server, go to your team project.  
  
2.  Find your build to open the build summary:  
  
     ![Go to Build hub, build definition, build summary](../test/media/vso_openbuildsummary.png "VSO_OpenBuildSummary")  
  
     Then open your test run summary:  
  
     ![Under Test Results, open test run summary](../test/media/vso_reviewtestrunsummary.png "VSO_ReviewTestRunSummary")  
  
3.  View your test results.  
  
     ![View test results from your build](../test/media/vso_viewtestresults.png "VSO_ViewTestResults")  
  
     Find specific results that you want to focus on:  
  
     ![Filter test results](../test/media/build_filtertestresults.png "BUILD_FilterTestResults")  
  
4.  Select a result to analyze it further. You can create a bug or update the result with your findings.  
  
     ![Review your test results from a build](../test/media/vso_reviewtestresults.png "VSO_ReviewTestResults")  
  
## Q & A  
  
### Q: Are there other ways to find a test run?  
 **A:** Yes, you can find your test run here:  
  
 ![Find test run](../test/media/build_findtestrun.png "BUILD_FindTestRun")  
  
## See Also  
 [Run tests with your builds](../test/run-tests-with-your-builds.md)   
 [Set up continuous testing for builds](../test/set-up-continuous-testing-for-builds.md)