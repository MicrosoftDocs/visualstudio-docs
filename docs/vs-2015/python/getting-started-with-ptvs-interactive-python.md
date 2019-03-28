---
title: "Getting Started with PTVS: Interactive Python | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-python
ms.topic: conceptual
ms.assetid: fa594314-bdd0-4da5-874a-57b03414b675
caps.latest.revision: 5
author: "kraigb"
ms.author: "kraigb"
manager: jillfra
---
# Getting Started with PTVS: Interactive Python
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Interactive prompts or read-eval-print loops (REPLs) are a key tool for productive programming languages.  They allow you to execute snippets of code to discover and learn APIs, experiment with using API, and interactively develop working code to include in projects or programs.  
  
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=yc2CROtTsC0&index=5&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff).  
  
 In the Python Environments window, you see a list of all your Python environments.  You can select any one of them to Open an Interactive Window or REPL.  If you’ve ever run Python.exe in a command prompt, then you’ve seen a python REPL before.  The REPL prompts you, and you can enter code, press enter, and immediately see the results of your code.  This is a live execution context that includes all the state of all your executions, variable assignments, etc.  You can refer to variables holding results in later submissions to the REPL prompt.  You can write multiple lines of code and execute them all at once (for example, a method declaration or multiple statements).  
  
 When you start using a new library, the REPL is a great way to try out the library.  You can import the library, inspect the sub packages, classes, and functions.  Python can tell you all of this info through its `help()` function.  Also, Python Tools for Visual Studio (PTVS) gives you suggestions and documentation based on its code modeling used in the editor, which it does without needing to execute the library.  When you do execute code, PTVS uses information from the Python runtime to improve PTVS suggestions.  
  
 The Interactive Window is also useful for iterative or evolutionary code development, including testing your code as you develop it.  You can select a function in an editor window, press the right pointer button, and choose Send to Interactive.  This command copies the selection to the Interactive Window as the next input and executes it.  You immediately see the results.  If you need to make changes to previous input, you can press up arrow to get the code back, modify it, and the press Ctrl+Enter to execute the code.  Pressing Enter at the end of input executes it, but pressing Enter in the middle of input inserts a newline.  
  
 You can open an Interactive Window for each Python installation, as many as you like.  There are buttons at the top of the window to clear the display, reset the execution context, etc.  Your history will remain intact.  
  
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=yc2CROtTsC0&index=5&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff).  
  
## See Also  
 [Wiki documentation](https://github.com/Microsoft/PTVS/wiki/Interactive-REPL)   
 [PTVS Getting Started and Deep Dive Videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)
