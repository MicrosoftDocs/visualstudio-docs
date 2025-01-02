---
title: Increase the chance of a performance issue being fixed
description: Additional information and best practices for submitting performance issues in Visual Studio
author: madskristensen
ms.author: madsk
manager: mijacobs
ms.subservice: general-ide
ms.date: 11/19/2019
ms.topic: conceptual
---
# Increase the chances of a performance issue being fixed

The "[Report a problem](./how-to-report-a-problem-with-visual-studio.md?view=vs-2019&preserve-view=true)" tool is widely used by Visual Studio users to report a range of problems. The Visual Studio team spots crash and slowness trends in user feedback and addresses issues impacting a broad swath of users. The more actionable a specific feedback ticket is, the more likely it will be diagnosed and resolved quickly by the product team. This document describes the best practices while reporting crash or slowness issues to make them more actionable.

## General best practices

Visual Studio is a large, complex platform that supports a multitude of languages, project types, platforms, and more. How it performs is a function of which components are installed and active in a session, the extensions installed, the Visual Studio settings, machine configuration, and finally the shape of the code that is being edited. Given the number of variables, it is hard to tell whether the problem report from one user has the same underlying issue as a problem report from another user, even though the visible symptom is the same. Given that, here are some best practices to ensure your specific problem report has higher likelihood of being diagnosed.

**Provide as specific a title as possible**

Look for distinct signatures for the problem being reported and include as much as possible in the title. If the title is descriptive, it is less likely that users with unrelated problems (but same superficial symptom) will vote or comment on your ticket, thus making diagnosis of *your* issue harder.

**When in doubt, log a new problem report**

Many problems may not have any distinctive signature or steps to reproduce. In such cases, a new report is better than an upvote or a comment on another report, which is reporting a similar outward *symptom*. Depending on the type of report, include additional diagnostic files to your report as described later in this document.

**Problem-specific best practices**

Described below are problems that are hard to diagnose without good diagnostic files. After identifying the case that best describes your issue, follow the feedback steps specific to that case.

- [Crashes:](#crashes) A crash occurs when the process (Visual Studio) terminates unexpectedly.

- [Unresponsiveness:](#unresponsiveness) VS becomes unresponsive for an extended period of time.

- [Slowness issues:](#slowness-and-high-cpu-issues) Any specific action in VS is slower than desired

- [High CPU:](#slowness-and-high-cpu-issues) Extended periods of unexpectedly high CPU usage

- [Out-Of-Process Issues:](#out-of-process-issues) An issue caused by a Visual Studio satellite process

## Crashes
A crash occurs when the process (Visual Studio) terminates unexpectedly.

**Directly reproducible crashes**

Directly reproducible crashes are cases that have all the following characteristics:

- Can be observed by following a known set of steps

- Can be observed on multiple computers (if available)

- Can be reproduced in sample code or a project that can be linked to or provided as part of the feedback (if the steps involve opening a project or document)

For these issues, follow the steps in "[How to Report a Problem](./how-to-report-a-problem-with-visual-studio.md)"
and be sure to include:

- The steps to reproduce the problem

- A standalone repro project as described above. If standalone repro is not possible, then please include:

  - The language of the open projects (C\#, C++, etc.)

  - The kind of project (Console Application, ASP.NET, etc.)

> [!NOTE]
> **Most valuable feedback:** For this case, the most valuable feedback is the set of steps to reproduce the issue along with sample source code.

**Unknown crashes**

If you're not sure what's causing your crashes or they seem random, then you can capture dumps locally each time Visual Studio crashes and attach those to separate feedback items. To save dumps locally when Visual Studio crashes, run the following commands in an administrator command window:

```
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps\devenv.exe" /v DumpType /t REG_DWORD /d 2
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps\devenv.exe" /v DumpCount /t REG_DWORD /d 2
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps\devenv.exe" /v DumpFolder /t REG_SZ /d "C:\CrashDumps"

reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps\ServiceHub.RoslynCodeAnalysisService32.exe" /v DumpType /t REG_DWORD /d 2
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps\ServiceHub.RoslynCodeAnalysisService32.exe" /v DumpCount /t REG_DWORD /d 2
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps\ServiceHub.RoslynCodeAnalysisService32.exe" /v DumpFolder /t REG_SZ /d "C:\CrashDumps"

reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps\ServiceHub.RoslynCodeAnalysisService.exe" /v DumpType /t REG_DWORD /d 2
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps\ServiceHub.RoslynCodeAnalysisService.exe" /v DumpCount /t REG_DWORD /d 2
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps\ServiceHub.RoslynCodeAnalysisService.exe" /v DumpFolder /t REG_SZ /d "C:\CrashDumps"
```

Customize the dump count and dump folder as appropriate. Find more information on these settings
[here](/windows/win32/wer/collecting-user-mode-dumps).

> [!NOTE]
> Dumps captured using Task Manager are likely to be of the wrong bitness, which makes them less usable. The procedure described above is the
preferred way for capturing a heap dump. If you do want to use Task Manager, close the one that is currently running, launch the 32bit Task Manager (%windir%\\syswow64\\taskmgr.exe) and collect a heap dump from there.

> [!NOTE]
> Each dump file produced by this method will be up to 4 GB in size. Make sure
to set DumpFolder to a location with adequate drive space or adjust the DumpCount appropriately.

Each time Visual Studio crashes, it will create a dump file **devenv.exe.[number].dmp** file in the configured location.

Then, use Visual Studio's "Report a Problem..." feature. It will allow you to attach the appropriate dump.

1. Locate the dump file for the crash you are reporting (look for a file with the correct Creation time)

2. If possible, zip the file (\*.zip) to reduce its size before submitting feedback

3. Follow the steps in "[How to Report a Problem](./how-to-report-a-problem-with-visual-studio.md)", and attach the heap dump to a new feedback item.

> [!NOTE]
> **Most valuable feedback:** For this case, the most valuable feedback is the
heap dump captured at the time of the crash.

## Unresponsiveness
VS becomes unresponsive for an extended period of time.

**Directly reproducible Unresponsiveness**

As described in the corresponding section on crashes, for problems that can be easily reproduced, seen on multiple machines and can be demonstrated in a small sample, the most valuable feedback reports are ones that include steps to reproduce the problem, and include sample source code that demonstrates the problem.

**Unknown Unresponsiveness**

If an unresponsiveness manifests itself in an unpredictable fashion, on the next occurrence, launch a new instance of Visual Studio and report a problem from that instance.
In the "Record" screen, be sure to select the Visual Studio session that is unresponsive. (For more information about how to record actions that we can follow to reproduce the issue, see Step 8 on the [How to report a problem](./how-to-report-a-problem-with-visual-studio.md) page.)

If the Visual Studio instance that is unresponsive was launched in Administrator mode, then the second instance would also need to be launched in Administrator mode.

>[!NOTE]
> **Most valuable feedback:** For this case, the most valuable feedback is the
heap dump captured at the time of the Unresponsiveness.

## Slowness and High CPU Issues

What makes a slowness or high CPU usage issue most actionable is a performance trace captured while the slow operation or high CPU event is in progress.

>[!NOTE]
> When possible, isolate each scenario in a separate, specific feedback report.
For example, if typing and navigation are both slow, follow the steps below once per issue. This helps the product team isolate the cause of specific issues.

For best results in capturing the performance, follow these steps:

1. If not already running, have a copy of Visual Studio open where you will reproduce the problem

    - Have everything set up to reproduce the problem. For example, if you need a particular project to be loaded with a specific file opened, then be sure both of those steps are complete before proceeding.

    - If you are *not* reporting a problem specific to loading a solution, try to wait 5-10 minutes (or more, depending on solution size) after opening the solution before recording the performance trace. The solution load process produces a large amount of data, so waiting for a few minutes helps us focus on the specific problem you are reporting.

2. Start a second copy of Visual Studio *with no solution open*

3. In the new copy of Visual Studio, open the **Report a Problem** tool

4. Follow the steps in [How to Report a Problem](./how-to-report-a-problem-with-visual-studio.md) until you reach the "Provide a trace and heap dump (optional)" step.

5. Choose to record the first copy of Visual Studio (the one encountering performance problem) and start recording.

    - The Steps Recorder application will appear and begin recording.

    - **During the recording,** perform the problematic action in the first copy of Visual Studio. It is difficult for us to correct specific performance problems if they do not appear within the recorded time.

    - If the action is shorter than 30 seconds and can be easily repeated, repeat the action to further demonstrate the problem.

    - For most cases, a trace of 60 seconds is sufficient to demonstrate the problems, especially if the problematic action lasted (or was repeated) for more than 30 seconds. The duration can be adjusted as necessary to capture the behavior you would like fixed.

6. Click "Stop Record" in Steps Recorder as soon as the slow operation or high CPU event you want to report is finished. It may take a few minutes to process the performance trace.

7. Once complete, there will be several attachments to your feedback. Attach any additional files that may help reproduce the problem (a sample project, screenshots, videos, etc.).

8. Submit the feedback.

While recording a performance trace, if the slow operation or high CPU you are reporting comes to an end, then immediately stop the recording. If too much information is collected, the oldest information gets overwritten. If the tracing is not stopped soon (within a few seconds) after the interesting operation, useful trace data will get overwritten.

Do not directly attach performance traces to existing feedback items on Developer Community website. Requesting/providing additional information is a supported workflow in Visual Studio's built-in Report a Problem tool. If a performance trace is required in order to resolve a previous feedback item, we will set the state of the feedback item to "Need More Info", which can be responded to in the same way as reporting a new problem. For detailed instruction, please refer to ["Need More Info"
section](./how-to-report-a-problem-with-visual-studio.md#when-further-information-is-needed) in Report a Problem tool's document.

> [!NOTE]
> **Most valuable feedback:** For almost all slowness/high CPU issues, the most
valuable feedback is a high-level description of what you were trying to do, along with the performance trace (\*.etl.zip) which captures the behavior during that time.

**Advanced Performance Traces**

Trace collection capabilities in the Report-a-problem tool are sufficient for most scenarios. But there are times where more control over trace collection is needed (for example, trace with a larger buffer size), in which case PerfView is a great tool to use. Steps for manually recording performance trace using the PerfView tool can be found on the [Recording performance traces with PerfView](https://github.com/dotnet/roslyn/blob/main/docs/wiki/Recording-performance-traces-with-PerfView.md) page.

## Out-Of-Process Issues

> [!NOTE]
> Starting with Visual Studio 2019 version 16.3, out-of-process logs are automatically attached to feedback submitted using the Report a Problem tool.
However, if the issue is directly reproducible, following the below steps could still help add additional information to help better diagnose the issue.

There are a number of satellite processes that run parallel to Visual Studio and provide various features from outside of the main Visual Studio process. If an error occurs in one of these satellite processes it is usually seen on the Visual Studio side as a 'StreamJsonRpc.RemoteInvocationException' or a 'StreamJsonRpc.ConnectionLostException'.

What makes these types of issues most actionable is to provide additional logs that can be collected by following these steps:

1. If this is a directly reproducible issue, start by deleting the **%temp%/servicehub/logs** folder. If you cannot reproduce this issue please keep this folder intact and ignore the following bullets:

    - Set the global environment variable **ServiceHubTraceLevel** to **All**
    - Reproduce the issue.

2. Download the Microsoft Visual Studio and .NET Framework Log Collection Tool [here](https://www.microsoft.com/download/details.aspx?id=12493).
3. Run the tool. This outputs a zip file to **%temp%/vslogs.zip**. Please attach that file to your feedback.

## Related content

* [Report a problem with C++](/cpp/how-to-report-a-problem-with-the-visual-cpp-toolset)
* [Visual Studio Developer Community](https://developercommunity.visualstudio.com/home)
* [Developer Community data privacy](developer-community-privacy.md)
