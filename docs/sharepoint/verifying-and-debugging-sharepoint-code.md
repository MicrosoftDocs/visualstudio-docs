---
title: "Verifying and Debugging SharePoint Code | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "unit testing [SharePoint development in Visual Studio]"
  - "IntelliTrace [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, IntelliTrace"
  - "SharePoint development in Visual Studio, unit testing"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Verifying and Debugging SharePoint Code
  By using IntelliTrace and unit testing, you can more easily debug your SharePoint solutions and ensure that each method in them works correctly. You can use these features for SharePoint projects in [!INCLUDE[vs_dev11_long](../sharepoint/includes/vs-dev11-long-md.md)] by following the same procedures as for other types of projects.  
  
## IntelliTrace  
 By using IntelliTrace, you can determine not only the current state of your SharePoint solution but also events that occurred in the past and the context in which they occurred. You can navigate back and forth to various points in time in your SharePoint solution where events of interest were recorded and review the states and values of variables at each point. By using this dynamic navigation, you can more quickly and easily debug your SharePoint solutions without having to set numerous breakpoints. You can also save the debugging session to an IntelliTrace log (.iTrace) file, open it later in Visual Studio Ultimate, and perform post-crash debugging. The .iTrace file includes detailed information about when and where specific SharePoint errors happened, so that you can more easily figure out what's causing the errors. The information in the .iTrace file is a subset of the complete error log that the Unified Logging System (ULS) in SharePoint creates. This information includes events that are specific to SharePoint, such as when a user profile is opened or closed and when properties in a SharePoint project are loaded, read, or changed. You can configure which events IntelliTrace records. For more information, see [Using saved IntelliTrace data](/visualstudio/debugger/using-saved-intellitrace-data) and [Configure IntelliTrace](http://msdn.microsoft.com/en-us/7657ecab-e07e-4b1b-872d-f05d966be37e).  
  
 When an error occurs in SharePoint, the error dialog box displays a "correlation ID" identifier for that particular error. You can also get correlation IDs from events that are listed in the .iTrace file. To display a list of all of the events that happened with a given correlation ID, you can enter the ID in the **Analysis** section of the IntelliTrace summary page. In that section, you can choose whether to display only the names of the events that occurred or the names of the events along with their call information, such as the function name, exit and entry points, parameters, and return values.  
  
 You can get Visual Studio events in IntelliTrace by choosing the **F5** key. To get events that are specific to SharePoint, however, you must collect IntelliTrace data in SharePoint solutions by using Microsoft Monitoring Agent. This tool collects IntelliTrace data and creates .iTrace files for applications that are deployed outside of Visual Studio. For more information, see [IntelliTrace Features](/visualstudio/debugger/intellitrace-features) and [Using the IntelliTrace stand-alone collector](/visualstudio/debugger/using-the-intellitrace-stand-alone-collector).  
  
## Unit Testing  
 You can more easily find errors in your code by performing unit testing, in which you write and run test code inside test methods. These methods contain empty variables and an Assert statement that you can use to verify the logic and functionality of your project based on the SharePoint object model. For more information, see [Unit Test Your Code](/visualstudio/test/unit-test-your-code).  
  
### Support for Microsoft Fakes Framework  
 SharePoint projects support Microsoft Fakes, which is an isolation framework in which you can create delegate-based test stubs and shims in applications that are based on the .NET Framework. By using the Fakes framework, you can create, maintain, and inject dummy implementations in your unit tests. These stubs and shims isolate your unit tests from the environment. You can create stubs to test code that consumes interfaces or non-sealed classes with overridable methods. You can create shims to redirect hard-coded calls to sealed classes with static or non-overridable methods to an alternative shim implementation. You can also use delegates with stub types and shim types to dynamically customize the behavior of individual stub members. For more information, see [Isolating Code Under Test with Microsoft Fakes](/visualstudio/test/isolating-code-under-test-with-microsoft-fakes).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[IntelliTrace](/visualstudio/debugger/intellitrace)|Describes how to debug Visual Studio solutions more easily by using IntelliTrace.|  
|[Walkthrough: Debugging a SharePoint Application by Using IntelliTrace](../sharepoint/walkthrough-debugging-a-sharepoint-application-by-using-intellitrace.md)|Demonstrates how to find coding errors in a SharePoint project by using IntelliTrace.|  
|[Unit Test Your Code](/visualstudio/test/unit-test-your-code)|Describes how to find logic errors in your code by using unit tests.|  
  
## See Also  
 [Improve Code Quality](/visualstudio/test/improve-code-quality)  
  
  