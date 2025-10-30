---
title: "Verifying and Debugging SharePoint Code"
description: Verify and debug SharePoint code. Use IntelliTrace to examine past events and current state in your solution. Use unit testing to ensure your methods work correctly.
ms.date: "02/02/2017"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "unit testing [SharePoint development in Visual Studio]"
  - "IntelliTrace [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, IntelliTrace"
  - "SharePoint development in Visual Studio, unit testing"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Verify and debug SharePoint code

By using IntelliTrace and unit testing, you can more easily debug your SharePoint solutions and ensure that each method in them works correctly. You can use these features for SharePoint projects in Visual Studio by following the same procedures as for other types of projects.

## Intellitrace
By using IntelliTrace, you can determine not only the current state of your SharePoint solution but also events that occurred in the past and the context in which they occurred. You can navigate back and forth to various points in time in your SharePoint solution where events of interest were recorded and review the states and values of variables at each point. By using this dynamic navigation, you can more quickly and easily debug your SharePoint solutions without having to set numerous breakpoints. You can also save the debugging session to an IntelliTrace log (*.iTrace*) file, open it later in Visual Studio Enterprise, and perform post-crash debugging. The *.iTrace* file includes detailed information about when and where specific SharePoint errors happened, so that you can more easily figure out what's causing the errors. The information in the *.iTrace* file is a subset of the complete error log that the Unified Logging System (ULS) in SharePoint creates. This information includes events that are specific to SharePoint, such as when a user profile is opened or closed and when properties in a SharePoint project are loaded, read, or changed. You can configure which events IntelliTrace records. For more information, see [Using saved IntelliTrace data](../debugger/using-saved-intellitrace-data.md).

When an error occurs in SharePoint, the error dialog box displays a "correlation ID" identifier for that particular error. You can also get correlation IDs from events that are listed in the *.iTrace* file. To display a list of all of the events that happened with a given correlation ID, you can enter the ID in the **Analysis** section of the IntelliTrace summary page. In that section, you can choose whether to display only the names of the events that occurred or the names of the events along with their call information, such as the function name, exit and entry points, parameters, and return values.

You can get Visual Studio events in IntelliTrace by choosing the **F5** key. To get events that are specific to SharePoint, however, you must collect IntelliTrace data in SharePoint solutions by using Microsoft Monitoring Agent. This tool collects IntelliTrace data and creates *.iTrace* files for applications that are deployed outside of Visual Studio. For more information, see [IntelliTrace Features](../debugger/intellitrace-features.md) and [Using the IntelliTrace stand-alone collector](../debugger/using-the-intellitrace-stand-alone-collector.md).

## Unit Test
You can more easily find errors in your code by performing unit testing, in which you write and run test code inside test methods. These methods contain empty variables and an Assert statement that you can use to verify the logic and functionality of your project based on the SharePoint object model. For more information, see [Unit Test Your Code](../test/unit-test-your-code.md).

### Support for Microsoft Fakes framework
SharePoint projects support Microsoft Fakes, which is an isolation framework in which you can create delegate-based test stubs and shims in applications that are based on the .NET Framework. By using the Fakes framework, you can create, maintain, and inject dummy implementations in your unit tests. These stubs and shims isolate your unit tests from the environment. You can create stubs to test code that consumes interfaces or non-sealed classes with overridable methods. You can create shims to redirect hard-coded calls to sealed classes with static or non-overridable methods to an alternative shim implementation. You can also use delegates with stub types and shim types to dynamically customize the behavior of individual stub members. For more information, see [Isolating Code Under Test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md).

## Related articles

|Title|Description|
|-----------|-----------------|
|[IntelliTrace](../debugger/intellitrace.md)|Describes how to debug Visual Studio solutions more easily by using IntelliTrace.|
|[Walkthrough: Debug a SharePoint application by using IntelliTrace](../sharepoint/walkthrough-debugging-a-sharepoint-application-by-using-intellitrace.md)|Demonstrates how to find coding errors in a SharePoint project by using IntelliTrace.|
|[Unit Test Your Code](../test/unit-test-your-code.md)|Describes how to find logic errors in your code by using unit tests.|

## Related content

- [Improve Code Quality](../test/improve-code-quality.md)
