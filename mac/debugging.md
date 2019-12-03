---
title: Debugging with Xamarin
description: Debugging is a common, and necessary, part of programming. As a mature IDE, Visual Studio for Mac contains a whole suite of features to make debugging easy. From safe debugging, to data visualization, this article will explain how to use the full potential of debugging in Visual Studio for Mac.
author: jmatthiesen
ms.author: jomatthi
ms.date: 05/06/2018
ms.technology: vs-ide-debug
ms.assetid: BB7A084D-9AC2-48B5-8076-6C8518796BBA
---
# Debugging with Xamarin

Visual Studio for Mac has a native debugger allowing debugging support for Xamarin.iOS, Xamarin.Mac, and Xamarin.Android applications.

Visual Studio for Mac uses the [*Mono Soft Debugger*](https://www.mono-project.com/docs/advanced/runtime/docs/soft-debugger/), which is implemented into the Mono runtime, allowing Visual Studio for Mac to debug managed code across all platforms.

## The Debugger

Visual Studio for Mac uses the Mono Soft Debugger to debug managed (C# or F#) code in all Xamarin applications. The Mono Soft debugger is different from regular debuggers in that it is a co-operative debugger that is built into the Mono runtime; the generated code and Mono runtime co-operate with the IDE to provide a debugging experience. The Mono runtime exposes the debugging functionality through a wire protocol, which you can read more about [in the Mono documentation](https://www.mono-project.com/docs/advanced/runtime/docs/soft-debugger-wire-format/).

Hard debuggers, such as [LLDB]( http://lldb.llvm.org/index.html) or [GDB]( https://www.gnu.org/software/gdb/), control a program without the knowledge or cooperation from the debugged program, but can still be useful when debugging Xamarin applications in the event that you need to debug native iOS or Android code.

## Using the debugger

To start debugging any application, always ensure that the configuration is set to  **Debug**. The debug configuration provides a helpful set of tools to support debugging, such as breakpoints, using data visualizers, and viewing the call stack:

![Debug configuration](media/debugging-image_0.png)

## Setting a breakpoint

To set a breakpoint in your IDE, click on the margin area of your editor, next to the line number of the code where you wish to break:

![Setting breakpoint in margin](media/debugging-image0.png)

You can view all the breakpoints that have been set in your code by going to the  **Breakpoints pad**:

![List of breakpoints](media/debugging-image0a.png)

## Start debugging

To start debugging, select the target device or similar/emulator in your IDE:

![Select target device](media/debugging-image1.png)

Then deploy your application by pressing the  **Play** button, or  **Cmd + return**. When you hit a breakpoint, the code will be highlighted yellow:

![Highlight showing breakpoint has been hit](media/debugging-image2.png)

Debugging tools, such as the one used to inspect the values of objects, can be used at this point to get more information about what is happening in your code:

![Debug visualizations](media/debugging-image3.png)

## Conditional breakpoints

You can also set rules dictating the circumstances under which a breakpoint should occur, this is known as adding a *conditional breakpoint*. To set a conditional breakpoint, access the  **Breakpoint Properties window**, which can be done in two ways:

* To add a new conditional breakpoint, right-click on the editor margin, to the left of the line number for the code you wish to set a breakpoint on, and select New Breakpoint:

 ![Breakpoint context menu](media/debugging-image4.png)

* To add a condition to an existing breakpoint, right-click on the breakpoint and select  **Breakpoint Properties**, or, in the  **Breakpoints Pad**, select the Edit Breakpoint button illustrated below:

 ![Edit existing Breakpoint in Breakpoints Pad](media/debugging-image5.png)

You can then enter the condition under which you want the breakpoint to occur:

 ![Edit Breakpoint conditions](media/debugging-image6.png)

## Stepping through code

When a breakpoint has been reached, the Debug tools enable you to get control over the program's execution. Visual Studio for Mac will display four buttons, allowing you to run and step through the code. In Visual Studio for Mac, they will look like the following:

 ![Buttons to step through code](media/debugging-image7.png)

Here are the four buttons:

* **Play** - This will begin executing the code, until the next breakpoint.
* **Step Over** - This will execute the next line of code. If the next line is a function call, Step Over will execute the function, and will stop at the next line of code *after* the function.
* **Step Into** - This will also execute the next line of code. If the next line is a function call, Step Into will stop at the first line of the function, allowing you to continue line-by-line debugging of the function. If the next line is not a function, it will behave the same as Step Over.
* **Step Out** - This will return to the line where the current function was called.

## Debugging Mono's class libraries

Xamarin products ship with the source code for Mono's class libraries, and you can use this to single step from the debugger to inspect how things are working under the hood.

Since this feature consumes more memory during debugging, it is turned off by default.

To enable this feature, browse to  **Visual Studio for Mac > Preferences > Debugger** and ensure that the "**Debug project code only; do not step into framework code.**" option is **unselected**, as illustrated below:

![Do not step into framework code option](media/debugging-image8.png)

## See also

- [Debugging in Visual Studio (on Windows)](/visualstudio/debugger/)