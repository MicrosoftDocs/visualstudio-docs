---
title: "Debug live ASP.NET Azure apps - Visual Studio | Microsoft Docs"
ms.date: "12/06/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "debugger"
ms.assetid: adb22512-4d4d-40e5-9564-1af421b7087e
caps.latest.revision: 1
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "aspnet"
  - "azure"
---
# Debug live ASP.NET Azure apps using the Snapshot Debugger

The Snapshot Debugger takes a snapshot of your in-production apps when code that you are interested in executes. To instruct the debugger to take a snapshot, you set snappoints and logpoints in your code. The debugger lets you see exactly what went wrong, without impacting traffic of your production application. The Snapshot Debugger can help you dramatically reduce the time it takes to resolve issues that occur in production environments.

Snappoints and logpoints are similar to breakpoints. Unlike breakpoints, snappoints do not halt the application when hit. Typically, capturing a snapshot at a snappoint takes 10-20 milliseconds. 

Snapshot collection is available for the following web apps running in Azure App Service:

- ASP.NET applications running on .NET Framework 4.6.1 or later.
- ASP.NET Core applications running on .NET Core 2.0 or later on Windows.

Additionally, the Snapshot Debugger is only available for Visual Studio 2017 Enterprise version 15.5 or higher and Basic or higher App Service plans. 

## Start the Snapshot Debugger

1. Install [Visual Studio 2017 Enterprise version 15.5](https://www.visualstudio.com/downloads/) or later. If you are updating from a previous Visual Studio 2017 installation, run the Visual Studio Installer and check the Snapshot Debugger component in the ASP.NET and web development workload.

2. Open the project you would like to snapshot debug. 

    > [!IMPORTANT] 
    > In order to snapshot debug, you need to open the **same version of source code** that is published to your Azure App Service. 

3. In the Cloud Explorer (select **View > Cloud Explorer**), right click the Azure App Service your project is deployed to and select **Attach Snapshot Debugger** to start the Snapshot Debugger.

   ![Launch the snapshot debugger](../debugger/media/snapshot-launch.png "Launch the snapshot debugger")

    The first time you select **Attach Snapshot Debugger**, you are prompted to install the Snapshot Debugger site extension on your Azure App Service. This installation requires a restart of your Azure App Service. 

   Visual Studio is now in snapshot debugging mode.

    > [!NOTE]
    > The Application Insights site extension also supports Snapshot Debugging. If you encounter a "site extension out of date" error message, please see [troubleshooting tips and known issues for snapshot debugging](../debugger/debug-live-azure-apps-troubleshooting.md) for upgrading details.

   ![Snapshot debugging mode](../debugger/media/snapshot-message.png "Snapshot debugging mode")

   The **Modules** window shows you when all the modules have loaded for the Azure App Service (choose **Debug / Windows / Modules** to open this window).

   ![Check the Modules window](../debugger/media/snapshot-modules.png "Check the Modules window")

## Set a snappoint

1. In the code editor, click the left gutter next to a line of code you are interested in to set a snappoint. Make sure it is code that you know will execute.

   ![Set a snappoint](../debugger/media/snapshot-set-snappoint.png "Set a snappoint")

2. Click **Start Collection** to turn on the snappoint.  

   ![Turn on the snappoint](../debugger/media/snapshot-start-collection.png "Turn on the snappoint")

    > [!TIP]
    > You cannot step when viewing a snapshot, but you can place multiple snappoints in your code to follow execution at different lines of code. If you have multiple snappoints in your code, the Snapshot Debugger ensures that the corresponding snapshots are from the same end-user session, even if there are multiple users hitting your app.

## Take a snapshot

When a snappoint is turned on, it will capture a snapshot whenever the line of code where the snappoint is placed is executed. This execution can be caused by a real request on your server. To force your snappoint to hit, you can also go to the browser view of your web site and take any actions required that cause your snappoint to be hit.

## Inspect snapshot data

1. When the snappoint is hit, a snapshot appears in the Diagnostic Tools window. Choose **Debug / Windows / Show Diagnostic Tools** to open this window.

   ![Open a snappoint](../debugger/media/snapshot-diagsession-window.png "Open a snappoint")

1. Double-click the snappoint to open the snapshot in the code editor.

   ![Inspect snapshot data](../debugger/media/snapshot-inspect-data.png "Inspect snapshot data")

   From this view, you can hover over variables to view DataTips, use the **Locals**, **Watches**, and **Call Stack** windows, and also evaluate expressions.

    The website itself is still live and end users are not impacted.Only one snapshot is captured per snappoint by default: after a snapshot is captured the snappoint turns off. If you want to capture another snapshot at the snappoint, you can turn the snappoint back on by clicking **Update Collection**.

You can also add more snappoints to your app and turn them on with the **Update Collection** button.

**Need help?** See the [Troubleshooting and known issues](../debugger/debug-live-azure-apps-troubleshooting.md) and [FAQ for snapshot debugging](../debugger/debug-live-azure-apps-faq.md) pages.

## Set a conditional snappoint

If it is difficult to recreate a particular state in your app, consider whether the use of a conditional snappoint can help. You can use conditional snappoints to avoid taking a snapshot until the app enters a desired state, such as when a variable has a particular value you're interested in. You can set conditions using expressions, filters, or hit counts.

#### To create a conditional snappoint

1. Right-click a snappoint icon (the hollow ball) and choose **Settings**.

   ![Choose Settings](../debugger/media/snapshot-snappoint-settings.png "Choose Settings")

1. In the snappoint settings window, type an expression.

   ![Type an expression](../debugger/media/snapshot-snappoint-conditions.png "Type an expression")

   In the preceding illustration, the snapshot is only taken for the snappoint when `visitor.FirstName == "Dan"`.

## Set a logpoint

In addition to taking a snapshot when a snappoint is hit, you can also configure a snappoint to log a message (that is, create a logpoint). You can set logpoints without having to redeploy your app. Logpoints are executed virtually and cause no impact or side effects to your running application.

#### To create a logpoint

1. Right-click a snappoint icon (the blue hexagon) and choose **Settings**.

1. In the snappoint settings window, select **Actions**.

    ![Create a logpoint](../debugger/media/snapshot-logpoint.png "Create a logpoint")

1. In the Message field, you can enter the new log message you want to log. You can also evaluate variables in your log message by placing them inside curly braces.

    If you choose **Send to Output Window**, when the logpoint is hit, the message appears in the Diagnostic Tools window.

    ![Logpoint data in the .diagsession window](../debugger/media/snapshot-logpoint-output.png "Logpoint data in the .diagsession window")

    If you choose **Send to application log**, when the logpoint is hit, the message appears anywhere that you can see messages from `System.Diagnostics.Trace` (or `ILogger` in .NET Core), such as [App Insights](/azure/application-insights/app-insights-asp-net-trace-logs).

## Next steps

- To learn how to inspect variables while viewing a snapshot, see [Debugger Feature Tour](../debugger/debugger-feature-tour.md).
- View the [FAQ for snapshot debugging](../debugger/debug-live-azure-apps-faq.md).
- View [troubleshooting tips and known issues for snapshot debugging](../debugger/debug-live-azure-apps-troubleshooting.md).
- If you want to view snapshots in Application Insights when your app hits an exception, you can do that. For more information, see [Debug snapshots on exceptions in .NET apps](/azure/application-insights/app-insights-snapshot-debugger). Application Insights supports Service Fabric apps in addition to Azure App Service.
