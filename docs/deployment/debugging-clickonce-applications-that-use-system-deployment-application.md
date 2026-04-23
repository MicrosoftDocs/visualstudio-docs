---
title: Debug ClickOnce apps that use System.Deployment.Application
description: Learn how to use and customize advanced ClickOnce deployment features by accessing the deployment object model provided by System.Deployment.Application.
ms.date: 11/06/2025
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce deployment, debugging
  - debugging, ClickOnce applications
  - debugging, System.Deployment
  - deploying applications [ClickOnce], debugging
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Debug ClickOnce applications that use System.Deployment.Application

In Visual Studio, ClickOnce deployment allows you to configure how an application is updated. However, if you want to use and customize advanced ClickOnce deployment features, you need access to the deployment object model provided by <xref:System.Deployment.Application>. You can use the <xref:System.Deployment.Application> APIs for advanced tasks such as:

- Creating an "Update Now" option in your application

- Conditional, on-demand downloads of various application components

- Updates integrated directly into the application

- Guaranteeing that the client application is always up-to-date

  Because the <xref:System.Deployment.Application> APIs work only when an application is deployed with ClickOnce technology, the only way to debug them is to deploy the application using ClickOnce, attach to it, then debug it. It can be difficult to attach the debugger early enough, because this code often runs when the application starts up and executes before you can attach the debugger. A solution is to place breaks (or stops, for Visual Basic projects) before your update check code or on-demand code.

  The recommended debugging technique is as follows:

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-support-application-deployment-api.md)]

1. Before you start, make sure the symbol (.pdb) files and source files are archived.

2. Deploy version 1 of the application.

3. Create a new blank solution. From the **File** menu, select **New**, then **Project**. In the **New Project** dialog box, open the **Other Project Types** node, then select the **Visual Studio Solutions** folder. In the **Templates** pane, select **Blank Solution**.

4. Add the archived source location to the properties for this new solution. In **Solution Explorer**, right-click the solution node, then select **Properties**. In the **Property Pages** dialog box, select **Debug Source Files**, then add the directory of the archived source code. Otherwise, the debugger finds the out-of-date source files, because the source file paths are recorded in the *.pdb* file. If the debugger uses out-of-date source files, you see a message telling you that the source doesn't match.

5. Make sure the debugger can find the *.pdb* files. If you deployed the files with your application, the debugger finds them automatically. It always looks next to the assembly in question first. Otherwise, you need to add the archive path to your list of symbol file locations.
   
   ::: moniker range="visualstudio"

   Open the **Tools** (or **Debug**) > **Options** pane, and expand the **All Settings** > **Debugging** > **Symbols** > **Search Locations** section. Add, change order, or remove items from the **Symbol file (.pdb) locations** list.

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   Open the **Tools** (or **Debug**) > **Options** dialog, and expand the **Debugging** > **Symbols** section. Add, change order, or remove items from the **Symbol file (.pdb) search locations** list.

   ::: moniker-end

6. Debug what happens between the `CheckForUpdate` and `Download`/`Update` method calls.

    For example, the update code might be as follows:

   ```vb
       Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
           If My.Application.Deployment.IsNetworkDeployed Then

               If (My.Application.Deployment.CheckForUpdate()) Then

                   My.Application.Deployment.Update()
                   Application.Restart()

               End If

           End If
       End Sub
   ```

7. Deploy version 2.

8. Attempt to attach the debugger to the version 1 application while it downloads an update for version 2. Alternatively, you can use the `System.Diagnostics.Debugger.Break` method or simply `Stop` in Visual Basic. Of course, you shouldn't leave these method calls in production code.

    For example, assume you're developing a Windows Forms application, and you have an event handler for this method with the update logic in it. To debug this, simply attach before the button is pressed, then set a breakpoint (make sure that you open the appropriate archived file and set the breakpoint there).

   Use the <xref:System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed%2A> property to invoke the <xref:System.Deployment.Application> APIs only when the application is deployed; the APIs shouldn't be invoked during debugging in Visual Studio.

## Related content
- <xref:System.Deployment.Application>