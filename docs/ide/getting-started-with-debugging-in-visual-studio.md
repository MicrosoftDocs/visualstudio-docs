---
title: "Getting started with debugging in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "12/14/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c3a14d28-d811-4ff3-bd09-21dce14025ca
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Get started with debugging in Visual Studio
Visual Studio provides a powerful integrated set of project build and debugging tools. In this topic, find out how to start using the most basic set of debugging UI features.  

## My code doesn't work. Help me, Visual Studio!  
 So you've figured out the editor and you've created some code. Now, you want to start debugging that code. In Visual Studio, as with most IDEs, there are two phases to debugging: building the code to catch and resolve project and compiler errors; and running that code in the environment to catch and resolve run-time and dynamic errors.  

### Build your code  
 There are two basic types of build configuration: **Debug** and **Release**. The first configuration produces a slower, larger executable that allows for a richer interactive run-time debugging experience, but should never be shipped. The second builds a faster, more optimized executable that's appropriate to ship (at least from the perspective of the compiler). The default build configuration is **Debug**.

The easiest way to build your project is to press **F7**, but you can also start the build by selecting **Build > Build Solution** from the main menu.  

 ![Visual Studio build project menu selection](../ide/media/vs_ide_gs_debug_build_menu_item.png "Vs_ide_gs_debug_build_menu_item")  

 You can observe the build process in the **Output** status window at the bottom of the Visual Studio UI. Errors, warnings, and build operations are displayed here. If you have errors (or if you have a warnings above a configured level), your build will fail. You can click on the errors and warnings to go to the line where they occurred. Rebuild your project by pressing either **F7** again (to recompile only the files with errors) or **Ctrl+Alt+F7** (for a clean and complete rebuild).  

 There are two build tabbed windows in the results window below the editor: the **Output** window, which contains the raw compiler output (including error messages); and the **Error List** window, which provides a sortable and filterable list of all errors and warnings.  

 When successful, you will see results like this in the **Output** window.  

 ![Visual Studio successful build output](../ide/media/vs_ide_gs_debug_success_build.PNG "vs_ide_gs_debug_success_build")  

### Review the Error List  
 Unless you've made no modifications to code you've previously and successfully compiled, you probably have an error. If you're new to coding, you probably have lots of them. Errors are sometimes obvious, such as a simple syntax error or incorrect variable name, and sometimes they are difficult to understand, with only a cryptic code to guide you. For a cleaner view of the issues, navigate to the bottom of the build **Output** window, and click the **Error List** tab. This takes you to a more organized view of the errors and warnings for your project, and gives you some extra options as well.  

 ![Visual Studio Output and Error List](../ide/media/vs_ide_gs_debug_bad_build_error_list.PNG "Vs_ide_gs_debug_bad_build_error_list")  

 Click on the error line in the **Error List** window and jump to the line the error occurs in. (Or turn on line numbers by clicking in the **Quick Launch** bar in the upper-right, typing "line numbers" into it, and pressing Enter. This is the fastest way to get to **Options** window entry where you can turn on line numbers. Learn to use the **Quick Launch** bar and save yourself a lot of UI clicks!)  

 ![Visual Studio editor with line numbers](../ide/media/vs_ide_gs_debug_line_numbers.png "Vs_ide_gs_debug_line_numbers")  

 ![Visual Studio line numbers option](../ide/media/vs_ide_gs_debug_options_line_numbers.png "Vs_ide_gs_debug_options_line_numbers")  

 Use **Ctrl+G** to quickly jump to the line number where the error occurred.  

 The error is identified by a red "squiggle" underscore. Hover over it for additional details. Make the fix and it will go away, although you may introduce a new error with the correction. (This is called a "regression".)  

 ![Visual Studio error hover](../ide/media/vs_ide_gs_debug_error_hover1.png "Vs_ide_gs_debug_error_hover1")  

 Walk through the error list and address all the errors in your code.  

 ![Visual Studio Debug errors window](../ide/media/vs_ide_gs_debug_error_list.PNG "Vs_ide_gs_debug_error_list")  

### Review errors in detail  
 Many errors may make no sense to you, phrased as they are in the terms of the compiler. In those cases, you will need additional information. From the **Error List** window, you can do an automatic Bing search for more information on the error (or warning) by right-clicking on the corresponding entry line and selecting **Show Error Help** from the context menu.  

 ![Visual Studio error list Bing search](../ide/media/vs_ide_gs_debug_error_list_error_help.png "Vs_ide_gs_debug_error_list_error_help")  

 This launches a tab inside Visual Studio that hosts the results of a Bing search for the error code and text. The results are from many different sources on the Internet, and not all may be helpful.  

 Alternatively, you can click on the hyperlinked error code value in the **Code** column of the **Error List**. This will launch a Bing search for just the error code.  

### Use Light Bulbs to fix or refactor code  
 Light Bulbs are a new feature for Visual Studio that let you refactor code inline. They are an easy way to fix common warnings quickly and effectively. To access them, right-click on a warning squiggle (or press **Ctrl+**. while hovering over the squiggle), and then select **Quick Actions**.  

 ![Visual Studio Light Bulb quick options](../ide/media/vs_ide_gs_debug_light_bulb1.png "Vs_ide_gs_debug_light_bulb1")  

 You will see a list of possible fixes or refactors you can apply to that line of code.  

 ![Visual Studio Light Bulb preview](../ide/media/vs_ide_gs_debug_light_bulb_preview_changes.PNG "Vs_ide_gs_debug_light_bulb_preview_changes")  

 Light Bulbs can be used wherever the code analyzers determine there is an opportunity to fix, refactor, or improve your code. Click on any line of code, right-click to open the context menu, and select **Quick Actions** (or, again, if you prefer efficiency, press **Ctrl+**.). If there are refactoring or improvement options available, they will be displayed; otherwise, the message `No quick options available here` will be displayed in the lower-left corner bezel of the IDE.  

 ![Visual Studio Light Bulb 'no option' text](../ide/media/vs_ide_gs_debug_light_bulb_no_options.PNG "Vs_ide_gs_debug_light_bulb_no_options")  

 With experience, you can quickly use the arrow keys and **Ctrl+**. to check for Quick Option refactoring opportunities and clean up your code!  

 For more information on Light Bulbs, read [Perform quick actions with light bulbs](../ide/perform-quick-actions-with-light-bulbs.md).  

### Debug Your running code  
 Now that you've successfully built your code and performed a little clean up, run it by pressing **F5** or selecting **Debug > Start Debugging**. This will start your app in a debug environment so you can observe its behavior in detail. The Visual Studio IDE changes while your app is running: the **Output** window is replaced by two new ones (in the default window configuration), the **Autos/Locals/Watch** tabbed window and the **Call Stack/Breakpoints/Exception Settings/Output** tabbed window. These windows have multiple tabs which allow you to inspect and evaluate your app's variables, threads, call stacks, and various other behaviors as it runs.  

 ![Visual Studio Autos and Call Stack Windows](../ide/media/vs_ide_gs_debug_autos_and_call_stack.PNG "Vs_ide_gs_debug_autos_and_call_stack")  

 You can stop your app by pressing **Shift+F5** or by clicking the **Stop** button. Or, you can simply close the app's main window (or command line dialog).  

 If your code ran perfectly and exactly as expected, congratulations! However, if it hung, or crashed, or gave you some strange results, you'll need to find the source of those problems and fix the bugs.  

### Set simple breakpoints  
 Breakpoints are the most basic and essential feature of reliable debugging. A breakpoint indicates where Visual Studio should suspend your running code so you can take a look at the values of variables, or the behavior of memory, or whether or not a branch of code is getting run. You do NOT need to rebuild a project after setting and removing breakpoints.  

 Set a breakpoint by clicking in the far margin of the line where you want the break to occur, or press **F9** to set a breakpoint on the current line of code. When you run your code, it will pause (or *break*) before the instructions for this line of code are executed.  

 ![Visual Studio breakpoint](../ide/media/vs_ide_gs_debug_breakpoint1.png "Vs_ide_gs_debug_breakpoint1")   

 Common uses for breakpoints include:  

1.  To narrow down the source of a crash or hang, scatter them throughout and around the code of the method call you think is causing the failure. As you run code in the debugger, remove and then reset the breakpoints closer together until you find the offending line of code.  See the next section to learn how to run code in the debugger.

2.  When you introduce new code, set a breakpoint at the beginning of it and run the code to make sure it is behaving as expected.

3.  If you have implemented a complicated behavior, set breakpoint(s) for the algorithmic code so you can inspect the values of the variables and data when the program breaks.  

4.  If you are writing C or C++ code, use breakpoints to stop the code so you can inspect address values (look for NULL) and reference counts when debugging for memory-related failures.  

 For more information on using breakpoints, read [Using Breakpoints](../debugger/using-breakpoints.md).  

### Inspect your code at run-time  
 When your running code hits a breakpoint and pauses, the line of code marked in yellow (the current statement) has not executed yet. At this point, you may want to execute the current statement and then inspect the changed values. You can use several *step* commands to execute code in the debugger. If the marked code is a method call, you can step into it by pressing **F11**. You can also *step over* the line of code by pressing **F10**. For additional commands and details on how to step through code, read [Navigate code with the debugger](../debugger/navigating-through-code-with-the-debugger.md).

 ![Visual Studio run&#45;time value inspection](../ide/media/vs_ide_gs_debug_hit_breakpoint.PNG "vs_ide_gs_debug_inspect_value") 

 In the preceding illustration, you can advance the debugger one statement by pressing either **F10** or **F11** (since there is no method call here, both commands have the same result).

 While the debugger is paused, you can inspect your variables and call stacks to determine what is going on. Are the values in the ranges you expect to see? Are calls being made in the right order?  

 ![Visual Studio run&#45;time value inspection](../ide/media/vs_ide_gs_debug_inspect_value.PNG "vs_ide_gs_debug_inspect_value")  

 Hover over a variable to see the value(s) and reference(s) it currently contains. If you see a value you didn't expect, you probably have a bug in the preceding or calling lines of code.  For more in-depth information, [learn more](../debugger/getting-started-with-the-debugger.md) about using the debugger. 

 Additionally, Visual Studio displays the Diagnostic Tools window, where you can observe your app's CPU and memory usage over time. Later in your app development, you can use these tools to look for unanticipated heavy CPU usage or memory allocation. Use it in conjunction with the **Watch** window and breakpoints to determine what's causing unexpected heavy usage or unreleased resources.  For more information, see [Profiling feature tour](../profiling/profiling-feature-tour.md).

### Run unit tests  
 Unit tests are your first line of defense against code bugs because, when done correctly, they test a single "unit" of code, typically a single function, and are usually much easier to debug than debugging your full program. Visual Studio installs the Microsoft unit testing frameworks for both managed and native code. Use a unit testing framework to create unit tests, run them, and report the results of these tests. Rerun unit tests when you make changes to test that your code is still working correctly. When you use Visual Studio Enterprise edition, you can run tests automatically after every build.  

 To get started, read [Generate unit tests for your code with IntelliTest](../test/generate-unit-tests-for-your-code-with-intellitest.md).  

 To learn more about unit tests in Visual Studio and how they can help you create better quality code, read [Unit Test Basics](../test/unit-test-basics.md).  

### Perform static code analysis  
 "Static code analysis" is a fancy way of saying "automatically check my code for common problems that can lead to run-time errors or problems in code management". Get in the habit of running it once you've cleaned up the obvious errors preventing build, and take some time to address the warnings it may produce. You'll save yourself some headaches down the road, as well as learn a few code style techniques.  

 Press **Alt+F11** (or select **Analyze > Run Code Analysis on Solution** from the top menu) to start static code analysis. This may take some time if you have a lot of code.  

 ![Visual Studio Code Analysis menu item](../ide/media/vs_ide_gs_debug_run_code_analysis.png "Vs_ide_gs_debug_run_code_analysis")  

 Any new or updated warnings will appear in the **Error List** tab at the bottom of the IDE. Click on the warnings to jump to them.  

 ![Visual Studio Error List with Warnings](../ide/media/vs_ide_gs_debug_code_analysis_warning_error_list.PNG "vs_ide_gs_debug_code_analysis_warning_error_list")  

 The warnings will be identified with a bright yellow-green squiggle instead of a red one. Hover over them for more detail, and right-click on them to get a context menu to assist in fixes or refactoring options.  

 ![Visual Studio Code Analysis Warning hover](../ide/media/vs_ide_gs_debug_code_analysis_warning_hover.png "vs_ide_gs_debug_code_analysis_warning_hover")  

## See Also  
 [Debugger Feature Tour](../debugger/debugger-feature-tour.md)  
 [Learn more about using the debugger](../debugger/getting-started-with-the-debugger.md)
