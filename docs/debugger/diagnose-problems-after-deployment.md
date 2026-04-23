---
title: Diagnose problems after deployment
description: Diagnose problems after deployment using IntelliTrace in Visual Studio. Include build information with your release. Release and monitor your app to find the problem.
ms.date: 10/28/2025
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Diagnose problems after deployment using IntelliTrace (C#, Visual Basic)

This article provides recommendations for diagnosing problems after deployment.

## <a name="TFS2017"></a> Azure DevOps, Visual Studio, and Team Foundation Server 2017

Visual Studio 2017 and later versions don't include the *BuildInfo.config* file, which was deprecated and then removed. This file was required to use IntelliTrace with deployed ASP.NET apps. To debug apps after deployment, use one of the following methods:

* For deployment to Azure, use [Application Insights](/azure/application-insights/).

* If you need to use IntelliTrace, open the project in Visual Studio and load the symbol files from the matching build. You can load symbol files from the **Modules** window or by configuring symbols in the **Tools** > **Options** or **Debug** > **Options** menu.

   :::moniker range="visualstudio"

   Open the **Tools** > **Options** pane and expand the **All Settings** > **Debugging** > **Symbols** section.

   :::moniker-end
   :::moniker range="<=vs-2022"

   Open the **Tools** > **Options** dialog and expand the **Debugging** > **Symbols** section.

   :::moniker-end

   You can also collect IntelliTrace diagnostic and method data for web, SharePoint, WPF, and Windows Form apps on remote machines without changing the target environment by using the IntelliTrace stand-alone collector. However, the stand-alone collector can have a significant performance impact. See [Using the IntelliTrace stand-alone collector](../debugger/using-the-intellitrace-stand-alone-collector.md).

## <a name="TFS2013"></a> Older versions of Team Foundation Server (ASP.NET)

For ASP.NET apps, you can set up your build process to create a build manifest (*BuildInfo.config* file) for your web project and include this manifest with your release. This manifest contains information about the project, source control, and build system that were used to create a specific build. This information helps Visual Studio find the matching source and symbols after you open the IntelliTrace log to review the recorded events.

For more information, see [Diagnose problems after deployment (Visual Studio 2015)](/previous-versions/visualstudio/visual-studio-2015/debugger/diagnose-problems-after-deployment?view=vs-2015&preserve-view=true).

> [!IMPORTANT]
> Use of Microsoft Monitoring Agent (MMA) with IntelliTrace is no longer supported when Microsoft Monitoring Agent reaches end-of-life on August 31, 2024. For more information, see [Migrate to Azure Monitor Agent from Log Analytics agent](/azure/azure-monitor/agents/azure-monitor-agent-migration).

## <a name="InvestigateEvents"></a> Find the problem using IntelliTrace

 You need Visual Studio Enterprise on your development computer or another computer to review the recorded events and debug your code using IntelliTrace. You can also use tools like CodeLens, debugger maps, and code maps to help you diagnose the problem.

 If you do use IntelliTrace to investigate issues, see [Find the problem](/previous-versions/visualstudio/visual-studio-2015/debugger/diagnose-problems-after-deployment?view=vs-2015&preserve-view=true#InvestigateEvents) for more in-depth instructions.