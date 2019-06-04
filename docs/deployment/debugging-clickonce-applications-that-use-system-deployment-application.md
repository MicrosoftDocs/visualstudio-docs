---
title: "Debug ClickOnce apps that use System.Deployment.Application"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "ClickOnce deployment, debugging"
  - "debugging, ClickOnce applications"
  - "debugging, System.Deployment"
  - "deploying applications [ClickOnce], debugging"
ms.assetid: 86f31948-2ca8-47c0-8e8b-c2b817bbf79f
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Debug ClickOnce applications that use System.Deployment.Application
In [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)], [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment allows you to configure how an application is updated. However, if you need to use and customize advanced [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment features, you will need to access the deployment object model provided by <xref:System.Deployment.Application>. You can use the <xref:System.Deployment.Application> APIs for advanced tasks such as:

- Creating an "Update Now" option in your application

- Conditional, on-demand downloads of various application components

- Updates integrated directly into the application

- Guaranteeing that the client application is always up-to-date

  Because the <xref:System.Deployment.Application> APIs work only when an application is deployed with [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] technology, the only way to debug them is to deploy the application using [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)], attach to it, then debug it. It can be difficult to attach the debugger early enough, because this code often runs when the application starts up and executes before you can attach the debugger. A solution is to place breaks (or stops, for Visual Basic projects) before your update check code or on-demand code.

  The recommended debugging technique is as follows:

1. Before you start, make sure the symbol (.pdb) and source files are archived.

2. Deploy version 1 of the application.

3. Create a new blank solution. From the **File** menu, click **New**, then **Project**. In the **New Project** dialog box, open the **Other Project Types** node, then select the **Visual Studio Solutions** folder. In the **Templates** pane, select **Blank Solution**.

4. Add the archived source location to the properties for this new solution. In **Solution Explorer**, right-click the solution node, then click **Properties**. In the **Property Pages** dialog box, select **Debug Source Files**, then add the directory of the archived source code. Otherwise, the debugger will find the out-of-date source files, since the source file paths are recorded in the .pdb file. If the debugger uses out-of-date source files, you see a message telling you that the source does not match.

5. Make sure the debugger can find the *.pdb* files. If you have deployed them with your application, the debugger finds them automatically. It always looks next to the assembly in question first. Otherwise, you will need to add the archive path to the **Symbol file (.pdb) locations** (to access this option, from the **Tools** menu, click **Options**, then open the **Debugging** node, and click **Symbols**).

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

8. Attempt to attach the debugger to the version 1 application as it downloads an update for version 2. Alternatively you can use the `System.Diagnostics.Debugger.Break` method or simply `Stop` in Visual Basic. Of course, you should not leave these method calls in production code.

    For example, assume you are developing a Windows Forms application, and you have an event handler for this method with the update logic in it. To debug this, simply attach before the button is pressed, then set a breakpoint (make sure that you open the appropriate archived file and set the breakpoint there).

   Use the <xref:System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed%2A> property to invoke the <xref:System.Deployment.Application> APIs only when the application is deployed; the APIs should not be invoked during debugging in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].

## See also
- <xref:System.Deployment.Application>