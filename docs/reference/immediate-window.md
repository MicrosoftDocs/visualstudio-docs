---
title: "Immediate Window"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VS.ImmediateWindow"
helpviewer_keywords: 
  - "design-time expression evaluation"
  - "Immediate window"
  - "first-chance exception notifications"
ms.assetid: d33e7937-73f3-4c69-9df0-777a8713c6f2
caps.latest.revision: 24
ms.author: "kempb"
manager: "ghogen"
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
# Immediate Window
The **Immediate** window is used to debug and evaluate expressions, execute statements, print variable values, and so forth. It allows you to enter expressions to be evaluated or executed by the development language during debugging. To display the **Immediate** window, open a project for editing, then choose **Windows** from the **Debug** menu and select **Immediate**, or press CTRL+ALT+I.  
  
 You can use this window to issue individual [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] commands. The available commands include `EvaluateStatement`, which can be used to assign values to variables. The **Immediate** window also supports IntelliSense.  
  
## Displaying the Values of Variables  
 This window can be particularly useful while debugging an application. For example, to check the value of a variable `varA`, you can use the [Print Command](../reference/print-command.md):  
  
```  
>Debug.Print varA  
```  
  
 The question mark (?) is an alias for `Debug.Print`, so this command can also be written:  
  
```  
>? varA  
```  
  
 Both versions of this command will return the value of the variable `varA`.  
  
> [!NOTE]
>  To issue a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command in the **Immediate** window, you must preface the command with a greater than sign (>). To enter multiple commands, switch to the **Command** window.  
  
## Design Time Expression Evaluation  
 You can use the **Immediate** window to execute a function or subroutine at design time.  
  
#### To execute a function at design time  
  
1.  Copy the following code into a [!INCLUDE[vbprvb](../codequality/includes/vbprvb_md.md)] console application:  
  
    ```  
    Module Module1  
  
        Sub Main()  
            MyFunction(5)  
        End Sub  
  
        Function MyFunction(ByVal input as Integer) As Integer  
            Return input * 2  
        End Function  
  
    End Module  
    ```  
  
2.  On the **Debug** menu, click **Windows**, and then click **Immediate**.  
  
3.  Type `?MyFunction(2)` in the **Immediate** window and press Enter.  
  
     The **Immediate** window will run `MyFunction` and display `4`.  
  
 If the function or subroutine contains a breakpoint, [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] will break execution at the appropriate point. You can then use the debugger windows to examine your program state. For more information see [Walkthrough: Debugging at Design Time](../debugger/walkthrough--debugging-at-design-time.md).  
  
 You cannot use design time expression evaluation in project types that require starting up an execution environment, including [!INCLUDE[trprVSTOshort](../reference/includes/trprvstoshort_md.md)] projects, Web projects, Smart Device projects, and SQL projects.  
  
### Design Time Expression Evaluation in Multi-Project Solutions  
 When establishing the context for design time expression evaluation, [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] references the currently selected project in Solution Explorer. If no project is selected in Solution Explorer, [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] attempts to evaluate the function against the startup project. If the function cannot be evaluated in the current context, you will receive an error message. If you are attempting to evaluate a function in a project that is not the startup project for the solution and you receive an error, try selecting the project in Solution Explorer and attempt the evaluation again.  
  
## Entering Commands  
 You must enter the greater than sign (>) when issuing [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] commands in the **Immediate** window. Use the UP ARROW and DOWN ARROW keys to scroll through previously issued commands.  
  
|Task|Solution|Example|  
|----------|--------------|-------------|  
|Evaluate an expression.|Preface the expression with a question mark (?).|`? a+b`|  
|Temporarily enter Command mode while in Immediate mode (to execute a single command).|Enter the command, prefacing it with a greater than sign (>).|`>alias`|  
|Switch to the Command window.|Enter `cmd` into the window, prefacing it with a greater than sign (>).|`>cmd`|  
|Switch back to the Immediate window.|Enter `immed` into the window without the greater than sign (>).|`immed`|  
  
## Mark Mode  
 When you click on any previous line in the **Immediate** window, you shift automatically into Mark mode. This allows you to select, edit, and copy the text of previous commands as you would in any text editor, and paste them into the current line.  
  
## The Equals (=) Sign  
 The window used to enter the `EvaluateStatement` command determines whether an equals sign (=) is interpreted as a comparison operator or as an assignment operator.  
  
 In the **Immediate** window, an equals sign (=) is interpreted as an assignment operator. So, for example, the command  
  
```  
>Debug.EvaluateStatement(varA=varB)  
```  
  
 will assign to variable `varA` the value of variable `varB`.  
  
 In the **Command** window, by contrast, an equals sign (=) is interpreted as a comparison operator. You cannot use assignment operations in the **Command** window. So, for example, if the values of variables `varA` and `varB` are different, then the command  
  
```  
>Debug.EvaluateStatement(varA=varB)  
```  
  
 will return a value of `False`.  
  
## First-Chance Exception Notifications  
 In some settings configurations, first-chance exception notifications are displayed in the **Immediate** window.  
  
#### To toggle first-chance exception notifications in the Immediate window  
  
1.  On the **View** menu, click **Other Windows**, and click **Output**.  
  
2.  Right-click on the text area of the **Output** window, and select or deselect **Exception Messages**.  
  
## See Also  
 [Navigating through Code with the Debugger](../debugger/navigating-through-code-with-the-debugger.md)   
 [Command Window](../reference/command-window.md)   
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)   
 [Debugger Basics](../debugger/debugger-basics.md)   
 [Walkthrough: Debugging at Design Time](../debugger/walkthrough--debugging-at-design-time.md)   
 [Visual Studio Command Aliases](../reference/visual-studio-command-aliases.md)   
 [Using Regular Expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md)