---
title: "How to: Debug while Running a Test in an ASP.NET Solution"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "ASP.NET applications [Visual Studio ALM], debugging while testing"
  - "tests, debugging ASP.NET applications during"
ms.assetid: de4d7aa1-4a1e-467e-a19b-4a85ec245b8b
caps.latest.revision: 38
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
# How to: Debug while Running a Test in an ASP.NET Solution
You can debug both unit tests and Web tests that you are using to test ASP.NET Web projects. You can also debug your ASP.NET production code while a test is running.  
  
 However, when you are testing ASP.NET code, the test code does not run in the typical way, under the VSTestHost process. Instead, it runs in either the IIS process, or if your Web site is file-based, in an ASP.NET Development Server process. Because the test runs in other than the typical test process, choosing the **Debug Unit Tests** option from the Test menu does not debug while the test is running.  
  
 Similarly, ASP.NET production code cannot be stepped into unless debugging is enabled and the debugger is attached to the ASP.NET Development Server or the IIS process.  
  
 In each of the following procedures, you create an ASP.NET Web site project by using the **New Web Site** dialog box. In this dialog box, you use the **Location** list box to choose a location for the Web site. This choice determines the process to which you will later attach the debugger, and the steps that you follow to debug while running a test in an ASP.NET solution. The two options are IIS and ASP.NET Development Server.  
  
-   [Debugging While Running on IIS](#DebuggingOnIIS)  
  
-   [Debugging While Running on ASP.NET Development Server](#DebuggingOnCassini)  
  
##  <a name="DebuggingOnIIS"></a> Debugging While Running on IIS  
 In the following procedure, you will attach the debugger to a process. The name of the process depends on the operating system you are using, because the operating system determines the version of IIS that is installed.  
  
#### To debug while running an ASP.NET test on IIS  
  
1.  Create an ASP.NET Web site project that you want to test, and an ASP.NET unit test to test it.  
  
     When you create this Web site project, in the **New Web Site** dialog box, select HTTP or FTP as the **Location**. This guarantees that the host process will be IIS.  
  
2.  Enable debugging in the ASP.NET Web project. To do this, edit the project's Web configuration file. If your project already has a Web.config file, go to step 4. If not, add one now: Open the shortcut menu for the Web site project in your solution, and then choose **Add New Item**.  
  
     The **Add New Item** dialog box is displayed.  
  
3.  In the **Add New Item** dialog box, choose **Web Configuration File** and then choose **Add**.  
  
     A Web.config file is added to your Web site project. For more information about how to use Web.config files, see [How to: Enable Debugging for ASP.NET Applications](http://go.microsoft.com/fwlink/?LinkId=55486).  
  
4.  In the Web.config file, change the line that reads `<compilation debug="false"/>` to `<compilation debug="true"/>`.  
  
5.  (Optional) Set breakpoints in the ASP.NET unit test and in the production code for your Web site.  
  
6.  Attach the debugger to the IIS process. To do this, choose **Debug** and then choose **Attach to Process**.  
  
     The **Attach to Process** dialog box is displayed.  
  
7.  Under **Available Processes**, locate the name of the process to which you want to attach the debugger.  
  
     If the process you need is not displayed, you can display more processes that are running. To do this, check **Show processes from all users** and **Show processes in all sessions**.  
  
8.  Under **Available Processes**, choose the name of the process and then choose **Attach**.  
  
     If the process to which you have to attach is not running, choose **Cancel** and then start the process. To do this, in Solution Explorer, open the shortcut menu for the Web site project and then choose **View in Browser**. Next, choose **Debug** and then choose **Attach to Process** one more time; the process has started running and is displayed under **Available Processes**. Choose the process name and then choose **Attach**.  
  
9. Start your test.  
  
     To do this, select the test you want to debug in Unit Test Explorer and then from the **Test** menu, choose **Debug Unit Tests** and then **Selected Tests**.  
  
    > [!NOTE]
    >  When running tests, you can choose **Run Selection** instead of **Debug Selection**. The difference is that if you choose **Debug Selection**, the debugger automatically detaches after the test finishes, but if you choose **Run Selection**, the debugger stays attached. You may find **Run Selection** more useful, especially if you plan to rerun the test several times while debugging, and you do not want to have to reattach the process every time. If you have chosen **Run Selection**, to detach the process when you have finished debugging, choose **Stop Debugging** from the **Debug** menu or press Shift+F5.  
  
##  <a name="DebuggingOnCassini"></a> Debugging While Running on ASP.NET Development Server  
  
#### To debug while running a test on ASP.NET Development Server  
  
1.  Create an ASP.NET Web site project that you want to test, and an ASP.NET unit test to test it.  
  
     When you create this Web site project, in the **New Web Site** dialog box, select File System as the **Location**. This guarantees that the host process will be ASP.NET Development Server.  
  
2.  Enable debugging in the ASP.NET Web project. To do this, edit the project's Web configuration file. If your project already has a Web.config file, go to step 4. If not, add one now: Open the shortcut menu for the Web site project in your solution, and then choose **Add New Item**.  
  
     The **Add New Item** dialog box is displayed.  
  
3.  In the **Add New Item** dialog box, choose **Web Configuration File** and then choose **Add**.  
  
     A Web.config file is added to your Web site project. For more information about how to use Web.config files, see [How to: Enable Debugging for ASP.NET Applications](http://go.microsoft.com/fwlink/?LinkId=55486).  
  
4.  In the Web.config file, change the line that reads `<compilation debug="false"/>` to `<compilation debug="true"/>`.  
  
5.  Add the statement System.Diagnostics.Debugger.Break() to the beginning of your ASP.NET unit test.  
  
    > [!NOTE]
    >  Breakpoints in your code will be hit only if they follow this System.Diagnostics.Debugger.Break() statement.  
  
    > [!NOTE]
    >  In C++, this statement is System::Diagnostics::Debugger::Break(). For information about how to use unit tests in Visual C++, see [Unit Tests and C++](assetId:///ad1c13ee-e2a8-4601-b5c4-de7e38e7907a).  
  
6.  Set breakpoints in the ASP.NET unit test and in the production code for your Web site.  
  
7.  Start your test.  
  
     To do this, select the test you want to debug in Unit Test Explorer and then from the **Test** menu, choose **Debug Unit Tests** and then **Selected Tests**.  
  
8.  As soon as the test starts to run, a dialog box appears. This dialog box indicates that the program has encountered a breakpoint.  
  
9. Choose **Debug**, choose the instance of [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] that has your solution loaded, and then choose **Yes**.  
  
     [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] will attach to the process, with execution paused at the System.Diagnostics.Debugger.Break() statement. You can choose **Continue** from the Debug menu or press F5 to allow execution to continue to your next breakpoint.  
  
    > [!NOTE]
    >  Be sure remove the System.Diagnostics.Debugger.Break() statement when you have finished debugging. Otherwise, the breakpoint dialog box will appear every time that you run the test.  
  
## See Also  
 [How to: Debug while a Test is Running](../test/how-to--debug-while-a-test-is-running.md)   
 [How to: Enable Debugging for ASP.NET Applications](http://go.microsoft.com/fwlink/?LinkId=55486)