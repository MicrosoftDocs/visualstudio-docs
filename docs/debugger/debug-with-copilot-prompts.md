---
title: Debug with Copilot Prompts
description: Master prompt techniques for the Debugger Agent to leverage its full capabilities across reproduce, instrument, isolate, and fix workflows.
#customer intent: As a developer, I want to master prompt techniques for the Debugger Agent, so that I can leverage its full capabilities across reproduce, instrument, isolate, and fix workflows.
ms.date: 07/02/2026
author: hharshada
ms.reviewer: hharshada
ms.topic: concept-article
ms.service: visual-studio-windows
f1_keywords:
  - "vs.debug.copilot.prompts"
---

# Debugger Agent concepts

The *Debugger Agent* is an AI-powered debugging assistant that works through GitHub Copilot Chat to help you reproduce, isolate, and fix bugs by controlling execution and validating work against live runtime state. The agent is most powerful when you give it a clear goal and let it manage the debugging workflow end-to-end.

The Debugger Agent excels at scenarios where you need to prove a bug exists, verify that a fix works, instrument code with breakpoints and tracepoints, and analyze complex call stacks. By combining natural language requests with debugger control, you can move through reproduce-instrument-isolate-fix workflows more efficiently than manual debugging alone.

## How to access the Debugger Agent

1. Open the Copilot Chat window (**View** > **GitHub Copilot Chat**).

1. Select **Debugger** from the mode dropdown in the lower-left corner of the chat window, or type `@debugger` in the chat input while in Agent mode.

1. Enter a prompt describing your debugging task, replacing placeholder text with the specifics of your scenario.

## Bug reproduction and diagnosis

The Debugger Agent can reproduce bugs from issue descriptions and confirm they exist in your runtime environment. Start by pointing the agent at a bug description, GitHub issue link, or Azure DevOps bug, and let it drive the full loop.

**Example prompts:**

``` Investigate/fix/debug the bug described in <issue link>. Reproduce the failure, find the root cause with the debugger, and propose a fix. ```

``` When I <do these steps>, I expect <expected result> but instead I see <actual result>. Debug the problem, find where the code goes wrong, and suggest a fix.```

``` Create a minimal repro for the following issue, then run it under the debugger to confirm the failure and show me the runtime state that causes it: <bug description>.```

## Fix verification and validation

Once you have a fix whether created by the agent or by you use the Debugger Agent to verify that the fix resolves the problem and that all significant code paths are exercised. 

**Example prompts:**

Give the agent a self-contained way to prove the fix works a unit test or a small console repro then have it verify specific runtime behavior.

```  Set breakpoints at <specific locations>, debug, and verify that <variable> has the value <expected value> and that <behavior> happens as expected. ```



``` I'm working on a change to make my code handle <new feature>. As part of that, I broke the following scenario: <repro steps>. Debug the problem and find where my code went wrong. Here are my changes: <paste diff here>```

## Instrumentation and runtime inspection

The Debugger Agent can set conditional breakpoints and tracepoints precisely where you need them, then run your project to collect the data you need. This approach gives you more visibility without manually editing your code.

**Example prompts:**

```Set a breakpoint at the start of ProcessFile that breaks only when the file name starts with "data12345", then launch my project.```

``` I need more visibility into <area of code>. Add tracepoints that log <the values you care about> at the key points in this flow, then run my project and show me the trace output.```

## Call stack analysis and control flow

When you're paused at a breakpoint or exception and need to understand the execution path, the Debugger Agent can analyze your call stack and explain what the current thread is doing, including asynchronous flow.

**Example prompts:**

 ``` Analyze the current call stack and explain what this thread is doing and how it got here, including the async flow. Point out the frame most likely responsible for <the problem>.```

``` Why is my code taking the wrong branch and not reaching <this line>? Set a breakpoint there and run the app. If it isn't hit, set breakpoints at the upstream decision points and inspect the actual condition values to find where control flow diverges.```

> [!TIP]
> You can also get call stack analysis with one click: in the **Call Stack** window select **Analyze with Copilot**, or use **Analyze with Copilot** in the **Parallel Stacks** / **Threads** view for multithreaded scenarios.

## Unit test debugging

The Debugger Agent can debug failing tests directly from chat without requiring you to start the debugger first.

**Example prompt:**

``` The test <TestName> is failing. Debug it, find the root cause of the failure, and suggest a fix.```

> [!TIP]
> You can also start debugging a failing test from **Test Explorer** or the CodeLens indicator above the test in the editor, then continue the conversation with the Debugger Agent from there. This is an easy way to hand the failing test's context to Copilot.

## Best practices for the Debugger Agent

* **Provide data, not commands.** The Debugger Agent doesn't have shell or PowerShell access, so it can't run tools like `git.exe` for you. Instead, paste the actual output. For example, paste the text of a diff rather than telling the agent to run a diff command.

* **Let the agent control execution when it instruments code.** Copilot can correct mistakes in conditional breakpoints and tracepoints only when it's driving the run. Prefer "set a conditional breakpoint ... and run my project" over "set a conditional breakpoint" on its own.

* **Let the agent finish when it enters break state.** If the agent is controlling execution and the chat still shows Copilot working, you don't need to do anything. To take back control, select the **stop** button in chat.
## Related content
- [Debug with Copilot](debug-with-copilot.md)
