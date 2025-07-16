---
title: "Log info with tracepoints"
description: Set tracepoints to log info to Output without modifying or stopping your code. Just specify an output string under the Action checkbox in Breakpoint Settings.
ms.date: 08/26/2022
ms.topic: "how-to"
helpviewer_keywords:
  - "tracepoints, about tracepoints"
author: MikeJo5000
ms.author: mikejo
manager: AndSter
ms.subservice: debug-diagnostics
---
# Log info to the Output window using tracepoints in Visual Studio

Tracepoints allow you to log information to the Output window under configurable conditions without modifying or stopping your code. This feature is supported for both managed languages (C#, Visual Basic, F#) and native code as well as languages such as JavaScript and Python.

> [!NOTE]
> For information on logging information to the Output window programmatically using .NET APIs, see [Send messages to the Output window](../debugger/diagnostic-messages-in-the-output-window.md).

## Let&#39;s take an example

::: moniker range="vs-2019"

The following example program is a simple `for` loop with a counter variable that increases by one every time the loop runs another iteration.

:::image type="content" source="../debugger/media/counterexample.png" alt-text="Screenshot of a sample counter program.":::
::: moniker-end

::: moniker range=">=vs-2022"

The following example program is a simple `for` loop with a counter variable that increases by one every time the loop runs another iteration.

```csharp

using System.Diagnostics;

namespace Tracepoints
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            for (int i=0; i<=10; i++)
            {
                counter +=1;
            }
        }
    }
}
```

::: moniker-end

## Set tracepoints in source code

::: moniker range="vs-2019"

You can set tracepoints by specifying an output string under the **Action** checkbox in the **Breakpoint Settings** window.

1. To initialize a tracepoint, first click on the gutter to the left of the line number where you want to set the tracepoint.

   :::image type="content" source="../debugger/media/breakpointinitialization.png" alt-text="Screenshot showing the Breakpoint Initialization in the sample code.":::

1. Hover over the red circle and then click the gear icon.
1. This action opens the **Breakpoint Settings** window.

   :::image type="content" source="../debugger/media/breakpointwindow.png" alt-text="Screenshot showing Breakpoint Window.":::

1. Select the **Action** checkbox.

   :::image type="content" source="../debugger/media/checkedactionsbox.png" alt-text="Screenshot of breakpoint window with Actions Box checked.":::

   Notice how the red circle changes to a diamond indicating that you've switched from a breakpoint to tracepoint.

1. Enter the message you want to log into the **Show a message in the Output Window** text box (for details, see later sections in this article).

   Your tracepoint is now set. Hit the &quot;Close&quot; button if all you want to do is log some information to the Output Window.

1. If you want to add conditions that determine whether your message is displayed, select the **Conditions** checkbox.

   :::image type="content" source="../debugger/media/checkedconditionsbox.png" alt-text="Screenshot of breakpoint window with Conditions Box checked.":::

   You have three choices for conditions: **Conditional Expression**, **Filter**, and **Hit Count**.

::: moniker-end

::: moniker range=">=vs-2022"

You can set tracepoints by specifying an output string under the **Action** checkbox in the **Breakpoint Settings** window.

1. To initialize a tracepoint, first click on the gutter to the left of the line number where you want to set the tracepoint.

   :::image type="content" source="../debugger/media/vs-2022/breakpoint-initialization.png" alt-text="Screenshot showing the Breakpoint Initialization in the sample code.":::

1. Hover over the red circle and click on the gear icon to open the **Breakpoint Settings** window.

   :::image type="content" source="../debugger/media/vs-2022/breakpoint-window.png" alt-text="Screenshot showing Breakpoint Window.":::

1. Select the **Action** checkbox.

   :::image type="content" source="../debugger/media/vs-2022/checked-actions-box.png" alt-text="Screenshot of breakpoint window with Actions Box checked.":::

   Notice how the red circle changes to a diamond indicating that you've switched from a breakpoint to tracepoint.

1. Enter the message you want to log into the **Show a message in the Output Window** text box (for details, see later sections in this article).

   Your tracepoint is now set. Hit the &quot;Close&quot; button if all you want to do is log some information to the Output Window.

1. If you want to add conditions that determine whether your message is displayed, select the **Conditions** checkbox.

   :::image type="content" source="../debugger/media/vs-2022/checked-conditions-box.png" alt-text="Screenshot of breakpoint window with Conditions Box checked.":::

   You have three choices for conditions: **Conditional Expression**, **Filter**, and **Hit Count**.

::: moniker-end

## Actions menu

::: moniker range="vs-2019"

This menu allows you to log a message to the Output window. Type the strings you want to output into the message box (no quotes necessary). If you want to display values of variables, make sure you enclose it in curly braces.

For example, if you want to display the value of the `counter` variable in the output console, type {counter} in the message text box.

:::image type="content" source="../debugger/media/counteroutputmessage.png" alt-text="Screenshot showing Counter Output Message.":::

If you click **Close** and then debug the program (**F5**), you see the following output in the Output window.

:::image type="content" source="../debugger/media/actionsmessageinoutputwindow.png" alt-text="Screenshot showing Actions Message In Output Window.":::

You can also use special keywords to display more specific information. Enter the keyword exactly as shown below (use a "$" in front of each keyword and all caps for the keyword itself).

| Keyword | What is Displayed |
| --- | --- |
| $ADDRESS | Current instruction |
| $CALLER | Calling function name |
| $CALLSTACK | Call stack |
| $FUNCTION | Current function name |
| $PID | Process ID |
| $PNAME | Process name |
| $TID | Thread ID |
| $TNAME   | Thread name |
| $TICK | Tick count (from Windows GetTickCount) |

::: moniker-end

::: moniker range=">=vs-2022"

This menu allows you to log a message to the Output window. Type the strings you want to output into the message box (no quotes necessary). If you want to display values of variables, make sure you enclose it in curly braces.

For example, if you want to display the value of the `counter` variable in the output console, type `{counter}` in the message text box.

:::image type="content" source="../debugger/media/vs-2022/counter-output-message.png" alt-text="Screenshot showing Counter Output Message.":::
  
If you click **Close** and then debug the program (**F5**), you see the following output in the Output window.

:::image type="content" source="../debugger/media/actionsmessageinoutputwindow.png" alt-text="Screenshot showing Actions Message In Output Window.":::

You can also use special keywords to display more specific information. Enter the keyword exactly as shown below (use a "$" in front of each keyword and all caps for the keyword itself).

| Keyword | What is Displayed |
| --- | --- |
| `$ADDRESS` | Current instruction |
| `$CALLER` | Calling function name |
| `$CALLSTACK` | Call stack |
| `$FUNCTION` | Current function name |
| `$PID` | Process ID |
| `$PNAME` | Process name |
| `$TID` | Thread ID |
| `$TNAME`   | Thread name |
| `$TICK` | Tick count (from Windows GetTickCount) |

::: moniker-end

## Conditions menu

Conditions allow you to filter your output messages, so they display only under certain scenarios. There are three main kinds of conditions available to you.

### Conditional expression

::: moniker range="vs-2019"

For a conditional expression, an output message displays only when certain conditions are met.

For conditional expressions, you can either set the tracepoint to output a message when a certain condition is true or when it has changed. For example, if you only want to display the value of counter during even iterations of the `for` loop, you could select the **Is true** option and then type `i%2 == 0` in the message text box.

:::image type="content" source="../debugger/media/conditionalexpressionistrue.png" alt-text="Screenshot showing Conditional Expression Is True.":::

If you want to print the value of counter when the iteration of the `for` loop changes, select the **When changed** option and type `i` in the message text box.

:::image type="content" source="../debugger/media/conditionalexpressionwhenchanged.png" alt-text="Screenshot showing when Conditional Expression is Changed.":::

The behavior of the  **When changed**  option is different for different programming languages.

- For native code, the debugger doesn't consider the first evaluation of the condition to be a change, so doesn't hit the tracepoint on the first evaluation.
- For managed code, the debugger hits the tracepoint on the first evaluation after **When changed**  is selected.

For a more comprehensive look at valid expressions you can use while setting conditions, see [Expressions in the debugger](expressions-in-the-debugger.md).

::: moniker-end

::: moniker range=">=vs-2022"

For a conditional expression, an output message displays only when certain conditions are met.

For conditional expressions, you can either set the tracepoint to output a message when a certain condition is true or when it has changed. For example, if you only want to display the value of counter during even iterations of the `for` loop, you could select the **Is true** option and then type `i%2 == 0` in the message text box.

:::image type="content" source="../debugger/media/vs-2022/conditional-expression-is-true.png" alt-text="Screenshot showing Conditional Expression Is True.":::

If you want to print the value of counter when the iteration of the `for` loop changes, select the **When changed** option and type `i` in the message text box.

:::image type="content" source="../debugger/media/vs-2022/conditional-expression-when-changed.png" alt-text="Screenshot showing when Conditional Expression is Changed.":::

The behavior of the  **When changed**  option is different for different programming languages.

- For native code, the debugger doesn't consider the first evaluation of the condition to be a change, so doesn't hit the tracepoint on the first evaluation.
- For managed code, the debugger hits the tracepoint on the first evaluation after **When changed**  is selected.

You can also set the condition when the tracepoint can be enabled by inserting a Breakpoint to any particular section of the code and selecting the checkbox **Only enable when the following breakpoint is hit:** option in the **Breakpoint Settings** menu. You can choose any breakpoint from the list of choices.

:::image type="content" source="../debugger/media/vs-2022/enable-at-breakpoint.png" alt-text="Screenshot showing enable when a breakpoint is hit checked.":::

For a more comprehensive look at valid expressions you can use while setting conditions, see [Expressions in the debugger](expressions-in-the-debugger.md).

::: moniker-end

### Hit count

::: moniker range="vs-2019"

A hit count condition allows you to send output only after the line of code where the tracepoint is set has executed a specified number of times.

For hit count, you can choose to output a message when the line of code where the tracepoint is set has been executed a particular number of times. Based on requirement it can be equal to, or is a multiple of, or is greater than or equal to the specified hit count value. Choose the option that best suits your needs and type an integer value in the field (for example, 5) that represents that iteration of interest.

:::image type="content" source="../debugger/media/conditionalexpressionhitcount.png" alt-text="Screenshot showing Conditional Expression Hit Count.":::

::: moniker-end

::: moniker range=">=vs-2022"

A hit count condition allows you to send output only after the line of code where the tracepoint is set has executed a specified number of times.

For hit count, you can choose to output a message when the line of code where the tracepoint is set has been executed a particular number of times. Based on requirement it can be equal to, or is a multiple of, or is greater than or equal to the specified hit count value. Choose the option that best suits your needs and type an integer value in the field (for example, 5) that represents that iteration of interest.

:::image type="content" source="../debugger/media/vs-2022/conditional-expression-hit-count.png" alt-text="Screenshot showing Conditional Expression Hit Count.":::

You can also remove the breakpoint on the first hit by enabling the checkbox **Remove breakpoint once hit**.

:::image type="content" source="../debugger/media/vs-2022/remove-breakpoint-on-hit.png" alt-text="Screenshot showing Remove breakpoint on first hit.":::

::: moniker-end

### Filter

::: moniker range="vs-2019"

For a filter condition, specify which devices, processes, or threads output is shown for.

:::image type="content" source="../debugger/media/conditionalexpressionfilter.png" alt-text="Screenshot showing Conditional Expression Filter.":::

List of filter expressions:

- MachineName = "name"
- ProcessId = value
- ProcessName = "name"
- ThreadId = value
- ThreadName = "name"

Enclose strings (such as names) in double quotes. Values can be entered without quotes. You can combine clauses using `&` (`AND`), `||` (`OR`), `!` (`NOT`), and parentheses.

::: moniker-end

::: moniker range=">=vs-2022"

For a filter condition, specify which devices, processes, or threads output is shown for.

:::image type="content" source="../debugger/media/vs-2022/conditional-expression-filter.png" alt-text="Screenshot showing Conditional Expression Filter.":::

List of filter expressions:

- `MachineName` = "name"
- `ProcessId` = value
- `ProcessName` = "name"
- `ThreadId` = value
- `ThreadName` = "name"

Enclose strings (such as names) in double quotes. Values can be entered without quotes. You can combine clauses using `&` (`AND`), `||` (`OR`), `!` (`NOT`), and parentheses.

::: moniker-end

## Considerations

While tracepoints are intended to make debugging a cleaner, and smoother experience. There are some considerations you should be aware of when it comes to using them.

Sometimes when you inspect a property or attribute of an object, its value can change. If the value changes during inspection, it's not a bug caused by the tracepoint feature itself. However, using tracepoints to inspect objects doesn't avoid these accidental modifications.

The way that expressions are evaluated in the **Action** message box may be different than the language you're currently using for development. For example, to output a string you don't need to wrap a message in quotes even if you normally would while using `Debug.WriteLine()` or `console.log()`. Also, the curly brace syntax (`{ }`) to output expressions may also be different than the convention for outputting values in your development language. (However, the contents within the curly braces (`{ }`) should still be written using your development language’s syntax).

If you're trying to debug a live application, and looking for a similar feature, check out our log point feature in the Snapshot Debugger. The snapshot debugger is a tool used to investigate issues in production applications. Logpoints also allow you to send messages to the Output Window without having to modify source code and don't affect your running application. For more information, see [Debug live Azure application](../debugger/debug-live-azure-applications.md).

## Related content

- [What is debugging?](../debugger/what-is-debugging.md)
- [Write better C# code using Visual Studio](../debugger/write-better-code-with-visual-studio.md)
- [First look at debugging](../debugger/debugger-feature-tour.md)
- [Expressions in the debugger](expressions-in-the-debugger.md)
- [Use breakpoints](../debugger/using-breakpoints.md)
- [Debug live Azure applications](../debugger/debug-live-azure-applications.md)
