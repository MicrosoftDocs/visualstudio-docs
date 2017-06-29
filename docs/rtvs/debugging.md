---
title: Debugging with the R Tools for Visual Studio | Microsoft Docs
ms.custom: ""
ms.date: 5/1/2017
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-r"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: cb5fe5f8-03bc-42bf-8346-c845036a9c6c
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "es-es"
  - "ja-jp"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
  - "ko-kr"
  - "cs-cz"
  - "de-de"
  - "fr-fr"
  - "it-it"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---

# Debugging R in Visual Studio

R Tools for Visual Studio (RTVS) integrates with the full debugging experience of Visual Studio (see [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md), including breakpoints, attaching to running processes, inspecting and watching variables, inspecting the call stack, and so on. This topic, then, explores those aspects of debugging that are unique to R and RTVS.

Starting the debugger for an the startup R file in an R project is the same as for other project types: use **Debug > Start Debugging**, the F5 key, or the **Source startup file** on the debug toolbar shown below. To change the startup file, right-click a file in Solution Explorer and select **Set As Startup R Script**.

![Debugger start button for R](media/debugger-start-button.png)

In all cases, starting the debugger "sources" the file in the interactive window, which means loading it and running it there. When you start debugging, in fact, you'll see output like this in the interactive window:

```output
> rtvs::debug_source("c:/proj/rproject1/rproject1/script.R")
Sourcing: c:\proj\rproject1\rproject1\script.R
Sourcing: c:\proj\rproject1\rproject1\Settings.R
```

You'll notice that we are using the `rtvs::debug_source` function to source the script. This is required because RTVS needs to modify your code in preparation for debugging. If you are using any of the RTVS commands (e.g., by right-clicking on a file in Solution Explorer and running the **Source selected file(s)** command), we'll automatically redirect the call to `rtvs::debug_source` if the debugger is attached.

You can also manually attach the debugger from the interactive window directly using the **R Tools > Session > Attach Debugger** command, the **Debug > Attach to R Interactive** command, or the **Attach Debugger** command on the interactive window's toolbar. Once you have done so, it is your responsiblity to source the files that you want to debug. If you want to manually source the files, make sure that you use `rtvs::debug_source` and not the regular `source` command in R. You may find that this works in _some_ cases, but we cannot guarantee that debugging will work in all cases unless you use the `rtvs::debug_source` command.

This connection between the debugger and the interactive window makes it easier to do things like calling (and debugging) a function with different parameter values. For example, supposed you have a function like the following in a sourced file (meaning it's been loaded into the session):

```R
add <- function(x, y) {
    return(x + y)
}
```

Then you set a breakpoint on the `return` statement. Now, in the interactive window, if you enter `add(4,5)`, you'll see that the debugger stops on your breakpoint.


## Environment browser in the interactive window

When you're stopped in the debugger, you're also stopped at the Environment Browser prompt in the [interactive window](interactive-repl.md). The prompt appears as `Browse[n]>` where n is a number.

The Environment Browser supports a number of special commands:

| Command | Description | 
| --- | --- |
| n | next: runs the next statement in the code file (same as step over). |
| s | step into: runs the next statement in the code file, stepping into a function scope if the next statement is a function call. | 
| f | finish: runs the remainder of the current function scope and returns to the caller (same as step out). |
| c, cont | continue: runs the program to the next breakpoint. | 
| Q | quits: ends the debugging session. |
| where | show stack: displays the call stack in the interactive window. |
| help | show help: displays available commands in the interactive window. |
| &lt;expr&gt; | evaluate the expression in *expr*. |

![Environment Browser in the interactive window](media/debugger-environment-browser.png)
