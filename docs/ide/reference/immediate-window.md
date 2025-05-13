---
title: Use the Immediate Window
description: Learn how to use the Immediate window to debug and evaluate expressions, execute statements, and print variable values.
ms.date: 02/25/2019
ms.topic: how-to
dev_langs:
- VB
f1_keywords:
- VS.ImmediateWindow
helpviewer_keywords:
- design-time expression evaluation
- Immediate window
- first-chance exception notifications
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Use the Immediate window

Use the **Immediate** window to debug and evaluate expressions, execute statements, and print variable values. The **Immediate** window evaluates expressions by building and using the currently selected project.

To display the **Immediate** window, open a project for editing, and then choose **Debug** > **Windows** > **Immediate** or press **Ctrl**+**Alt**+**I**. You can also enter **Debug.Immediate** in the **Command** window.

The **Immediate** window supports IntelliSense.

## Display the values of variables

The **Immediate** window is particularly useful when you're debugging an app. For example, to check the value of a variable `varA`, you can use the [Print command](../../ide/reference/print-command.md):

```cmd
>Debug.Print varA
```

The question mark (?) is an alias for `Debug.Print`, so this command can also be written:

```cmd
? varA
```

Both versions of this command return the value of the variable `varA`.

> [!TIP]
> To issue a Visual Studio command in the **Immediate** window, you must preface the command with a greater than sign (>). To enter multiple commands, switch to the [Command window](command-window.md).

## Design-time expression evaluation

You can use the **Immediate** window to execute a function or subroutine at design time.

### Execute a function at design time

1. Copy the following code into a Visual Basic console app:

   ```vb
   Module Module1

       Sub Main()
           MyFunction(5)
       End Sub

       Function MyFunction(ByVal input as Integer) As Integer
           Return input * 2
       End Function

   End Module
   ```

2. On the **Debug** menu, choose **Windows** > **Immediate**.

3. Type `?MyFunction(2)` in the **Immediate** window and press **Enter**.

    The **Immediate** window runs `MyFunction` and displays `4`.

If the function or subroutine contains a breakpoint, Visual Studio breaks execution at the appropriate point. You can then use the debugger windows to examine your program state. For more information, see [Walkthrough: Debugging at Design Time](../../debugger/walkthrough-debugging-at-design-time.md).

You can't use design-time expression evaluation in project types that require starting up an execution environment, including Visual Studio Tools for Office projects, web projects, Smart Device projects, and SQL projects.

### Design-time expression evaluation in multi-project solutions

When establishing the context for design-time expression evaluation, Visual Studio references the currently selected project in Solution Explorer. If no project is selected in Solution Explorer, Visual Studio attempts to evaluate the function against the startup project. If the function cannot be evaluated in the current context, you'll receive an error message. If you're attempting to evaluate a function in a project that's not the startup project for the solution and you receive an error, try selecting the project in Solution Explorer and attempt the evaluation again.

## Enter commands

Enter the greater than sign (>) when issuing Visual Studio commands in the **Immediate** window. Use the **Up arrow** and **Down arrow** keys to scroll through your previously used commands.

|Task|Solution|Example|
|----------|--------------|-------------|
|Evaluate an expression.|Preface the expression with a question mark (?).|`? a+b`|
|Temporarily enter Command mode while in Immediate mode (to execute a single command).|Enter the command, prefacing it with a greater than sign (>).|`>alias`|
|Switch to the Command window.|Enter `cmd` into the window, prefacing it with a greater than sign (>).|`>cmd`|
|Switch back to the Immediate window.|Enter `immed` into the window without the greater than sign (>).|`immed`|

## Mark mode

When you click on any previous line in the **Immediate** window, you shift automatically into Mark mode. This allows you to select, edit, and copy the text of previous commands as you would in any text editor, and paste them into the current line.

## Examples

The following example shows four expressions and their result in the **Immediate** window for a Visual Basic project.

```cmd
j = 2
Expression has been evaluated and has no value

? j
2

j = DateTime.Now.Day
Expression has been evaluated and has no value

? j
26
```

## First-chance exception notifications

In some settings configurations, first-chance exception notifications are displayed in the **Immediate** window.

### Toggle first-chance exception notifications in the Immediate window

1. On the **View** menu, click **Other Windows**, and click **Output**.

2. Right-click on the text area of the **Output** window, and then select or deselect **Exception Messages**.

## See also

- [Navigating through Code with the Debugger](../../debugger/navigating-through-code-with-the-debugger.md)
- [Command Window](../../ide/reference/command-window.md)
- [First look at the debugger](../../debugger/debugger-feature-tour.md)
- [Walkthrough: Debugging at Design Time](../../debugger/walkthrough-debugging-at-design-time.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
- [Using Regular Expressions in Visual Studio](../../ide/using-regular-expressions-in-visual-studio.md)
