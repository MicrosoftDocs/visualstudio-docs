---
title: Debugging with Xamarin
description: Debugging is a common, and necessary, part of programming. As a mature IDE, Xamarin Studio contains a whole suite of features to make debugging easy. From safe debugging, to data visualization, this article will explain how to use the full potential of debugging in Xamarin Studio.
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: BB7A084D-9AC2-48B5-8076-6C8518796BBA
---


#Overview


Xamarin Studio has a native debugger allowing debugging support for Xamarin.iOS, Xamarin.Mac and Xamarin.Android applications.
Xamarin Studio uses the [*Mono Soft Debugger*](http://www.mono-project.com/docs/advanced/runtime/docs/soft-debugger/), which is implemented into the Mono runtime allowing Xamarin Studio (and Visual Studio, with the Xamarin add-in installed) to debug managed code across all platforms.


In this article, we will look the debugger, how to set a breakpoint, and how to step through code. In the accompanying article we will look at the new debugger visualizers, introduced in Xamarin Studio 5.9.

#Requirements
Xamarin Studio 5.9 is required to take advantage of the new data visualizers when debugging.

#The Debugger
Xamarin Studio, and Xamarin for Visual Studio, uses the Mono Soft Debugger to debug managed (C# or F#) code in all Xamarin applications. The Mono soft debugger is different to regular debuggers in that in that it is a co-operative debugger that is built into the Mono runtime; the generated code and Mono runtime co-operate with the IDE to provide a debugging experience. The Mono runtime exposes the debugging functionality through a wire protocol; you can read more about this [here]( http://www.mono-project.com/docs/advanced/runtime/docs/soft-debugger-wire-format/).


Hard debuggers, such as [LLDB]( http://lldb.llvm.org/index.html) or [GDB]( https://www.gnu.org/software/gdb/) control a program without the knowledge or cooperation from the debugged program, but can still be useful when debugging Xamarin applications, in the event that you need to debug native iOS or Android code.

#Using the Debugger

To start debugging any application, always ensure that the configuration is set to  <span class="UIItem">Debug</span>, as this contains a helpful set of tools to support debugging such as breakpoints, using data visualizers, and viewing the call stack:

![](Images/debugging-image_0.png)

##Setting a breakpoint 

To set a breakpoint in your IDE, click on the margin area of your editor, next to the line number of the code you wish to break at:

![](Images/debugging-image0.png)


You can view all the breakpoints that have been set in your code by going to the  <span class="UIItem">Breakpoints pad</span>:

![](Images/debugging-image0a.png)


##Start Debugging
To start debugging, select the target device or similar/emulator in your IDE:

![](Images/debugging-image1.png)
 
Then deploy your application by pressing the  <span class="UIItem">Play</span> button, or  <span class="UIItem">Cmd + return</span>. When you hit a breakpoint, the code will be highlighted yellow:

![](Images/debugging-image2.png)
 
Debugging tools, such as inspecting the values of objects, can be used at this point to get more information about what is happening in your code:

![](Images/debugging-image3.png)
 
##Conditional Breakpoints
You can also set rules dictating the circumstances under which a breakpoint should occur, this is know as adding a *conditional breakpoint*. To set a conditional breakpoint, access the  <span class="UIItem">Breakpoint Properties window</span>, which can be done in two ways:


* To add a new conditional breakpoint, right-click on the editor margin, to the left of the line number for the code you wish to set a breakpoint on, and select New Breakpoint:

 
 ![](Images/debugging-image4.png)

* To add a condition to an existing breakpoint, right-click on the breakpoint and select  <span class="UIItem">Breakpoint Properties</span> **OR** in the  <span class="UIItem">Breakpoints Pad</span> select the properties button illustrated below: 


 ![](Images/debugging-image5.png)


You can then enter the condition under which you want to breakpoint to occur:

 ![](Images/debugging-image6.png)
 
##Stepping through code
When a breakpoint has been reached, the Debug tools enable you to get control over the program’s execution. The IDE will display four buttons, allowing you to run and step through the code. In Xamarin Studio they will look like the following:

 ![](Images/debugging-image7.png)

These are:


*	**Play** – This will begin executing the code, until the next breakpoint.
*	**Step Over** – This will execute the next line of code. If the next line is a function call, step over will execute the function, and will stop at the next line of code *after* the function.
*	**Step Into** – This will also execute the next line of code. If the next line is a function call, Step Into will stop at the first line of the function, allowing you to continue line-by-line debugging of the function. If the next line is not a function, it will behave the same as Step Over.
*	**Step Out** – This will return to the line where the current function was called.


#Debugging Mono’s Class Libraries
Xamarin products ship with the source code for Mono's class libraries, and you can use this to single step from the debugger to inspect how things are working under the hood.

Since this feature consumes more memory during debugging, it is turned off by default. To enable this feature, browse to  <span class="UIItem">Xamarin Studio > Preferences > Debugger</span> and ensure that the "**Debug project code only; do not step into framework code**" option is **unselected**, as illustrated below:

 ![](Images/debugging-image8.png)


