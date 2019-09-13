---
title: "Use tracepoints in the debugger | Microsoft Docs"
ms.date: "9/4/2019"
ms.topic: "conceptual"
helpviewer_keywords:
  - "tracepoints, about tracepoints"
ms.assetid: 75593c5f-5706-4151-bdeb-4dbb625e91bb
author: "Sagar-S-S"
ms.author: "sashe"
manager: AndSter
ms.workload:
  - "multiple"
---


## Use Tracepoints in the Visual Studio debugger

Tracepoints allow you to log information to the Output window under configurable conditions without modifying or stopping your

code. This feature is supported for both managed and native code as well as several languages such as JavaScript and C#.

## Let&#39;s Take an Example

The following example program is a simple for loop with a counter variable that increases by 1 every time the loop runs another iteration.

![Counter Example](../debugger/media/counterexample.png "Counter Example")

## Set tracepoints in source code

Summary - Click on the far-left margin next to a line of code -> Click the Gear Icon -> Check Actions Box -> Input Message -> Hit Close Button. Check Conditions box and add if you need them. You can also right-click and select  **tracepoint**  ->  **Insert tracepoint**.

1. To initialize a tracepoint first click on the gutter to the left of the line number of interests.

![Breakpoint Initialization](../debugger/media/breakpointinitialization.png "Breakpoint Initialization")

2.Hover over the red circle and then click on the gear icon.
3.This should bring up the following menu

![Breakpoint Window](../debugger/media/breakpointwindow.png "Breakpoint Window")

4.Check the Actions box.

![Checked Actions Box](../debugger/media/checkedactionsbox.png "Checked Actions Box")

Notice how to red circle changes to a diamond indicating that you have switched from a tracepoint to tracepoint.

5.Enter the message you want to log into the field titled &quot;Show a message in the Output Window&quot; (more information below)

Your tracepoint is now set. Hit the &quot;Close&quot; button if all you want to do is log some information to the Output Window.

6.If you want to add some conditions on when your message is displayed check the conditions box

![Checked Conditions Box](../debugger/media/checkedconditionsbox.png "Checked Conditions Box")

You have three choices: Conditional Expression, Filter, and Hit Count.

## Actions Menu

This menu allows you to log a message to the Output console. Simply type whatever strings you want into the message box (no quotes necessary). If you want to display values of variables, make sure you enclose it in curly braces.

For example, if we want to display the value of our counter variable in the output console we would type {counter} in the message field.

![Counter Output Message](../debugger/media/counteroutputmessage.png "Counter Output Message")

If you hit the close button and Debug the program (F5) you should see the following Output in the console.

![Actions Message In Output Window](../debugger/media/actionsmessageinoutputwindow.png "Actions Message In Output Window")

You can also use special Keywords to display some more specific information. Input the keyword exactly as shown below ($ in front of keywords and all caps).

| Keyword | What is Displayed |
| --- | --- |
| $ADDRESS | Current instruction |
| $CALLER | Calling function name |
| $CALLSTACK | Call stack |
| $FUNCTION | Current function name |
| $PID | Process id |
| $PNAME | Process name |
| $TID | Thread id |
| $TNAME   | Thread name |
| $TICK | Tick count (from Windows GetTickCount) |

## Conditions Menu

Conditions allow you to filter your output messages, so they displayed only under certain scenarios. There are three main kinds of conditions available to you.

 **1. Conditional Expression**: Output message displayed only when certain conditions are met.

For conditional expressions you can either set the tracepoint to output a message when a certain condition is true or when it has changed. For example if you only wanted to display the value of counter during even iterations of the for loop, you could select the &quot;is true&quot; option and then type &quot;i%2 == 0&quot; (without the quotes) in the expression field.

![Conditional Expression Is True](../debugger/media/conditionalexpressionistrue.png "Conditional Expression Is True")

If you wanted to print the value of counter when the iteration of the for loop changes, select the &quot;when changes&quot; option and type &quot;i&quot; (without the quotes) in the expression field.

![Conditional Expression When Changed](../debugger/media/conditionalexpressionwhenchanged.png "Conditional Expression When Changed")

An important note on the "When changed" field from our tracepoint doc: [https://docs.microsoft.com/en-us/visualstudio/debugger/using-tracepoints?view=vs-2019](https://docs.microsoft.com/en-us/visualstudio/debugger/using-tracepoints?view=vs-2019)

&quot;The behavior of the  **When changed**  field is different for different programming languages.

- For native code, the debugger doesn&#39;t consider the first evaluation of the condition to be a change, so doesn&#39;t hit the tracepoint on the first evaluation.
- For managed code, the debugger hits the tracepoint on the first evaluation after  **When changed**  is selected.&quot;

For a more comprehensive look at valid expressions you can use while setting conditions, see this doc: [https://docs.microsoft.com/en-us/visualstudio/debugger/expressions-in-the-debugger?view=vs-2019](https://docs.microsoft.com/en-us/visualstudio/debugger/expressions-in-the-debugger?view=vs-2019)

**2. Hit Count**: This condition allows you to output only after a pre-specified number of times the line the tracepoint was set on has been executed.

For hit count, you can choose to output a message when the number of times the tracepoint line has been executed is equal to, is a multiple of, or is greater than or equal to a pre-specified value. Choose the option that best suits your needs and type an integer value in the field (ex: 5) that represents that iteration of interest.

![Conditional Expression Hit Count](../debugger/media/conditionalexpressionhitcount.png "Conditional Expression Hit Count")

**3. Filter**: Specify which devices, processes or threads output is shown for.

![Conditional Expression Filter](../debugger/media/conditionalexpressionfilter.png "Conditional Expression Filter")

List of Filter Expressions:

- MachineName = "name”
- ProcessId = value
- ProcessName = "name"
- ThreadId = value
- ThreadName = "name"

Enclose strings (such as names) in double quotes. Values can be entered without quotes. You can combine clauses using & (AND), || (OR), ! (NOT), and parentheses.

## Considerations

While tracepoints aim to make debugging a cleaner and smoother experience, there are some considerations you should be aware of when it comes to using them.

Sometimes when you inspect a property or attribute of an object its value can change. This is not a bug caused by tracepoints itself, but it is worth mentioning that utilizing tracepoints to inspect objects does not avoid these accidental modifications.

Another consideration to think about is that the way expressions are evaluated in the action’s message box may be different than the language you are currently developing in. For example to output a string you do not need to wrap a message in quotes even if you normally would while using Debug.WriteLine() or console.log(). Also the curly brace syntax { } to output expressions may also be different than the convention for outputting values in your development language (one important note is that the contents within the { } should still be written using your development language’s syntax).
