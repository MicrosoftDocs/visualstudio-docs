---
title: "Visual Studio Profiler API Reference (Native)"
titleSuffix: ""
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "performance tools, API"
  - "Profiler, API"
ms.assetid: a0c3be92-c263-4678-9fb9-bafead3bd5f5
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "cplusplus"
---
# Visual Studio profiler API reference (native)
Visual Studio profiler APIs allow you to programmatically control the amount of data collected, and insert both timestamp and profile marks during profiling. To use native APIs, you include *VSPerf.h* header file and add the *VSPerf.lib* in your project.

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).

## In this section
[CommentMarkAtProfile](../profiling/commentmarkatprofile.md)

[CommentMarkProfile](../profiling/commentmarkprofile.md)

[MarkProfile](../profiling/markprofile.md)

[NameProfile](../profiling/nameprofile.md)

[ResumeProfile](../profiling/resumeprofile.md)

[StartProfile](../profiling/startprofile.md)

[StopProfile](../profiling/stopprofile.md)

[SuspendProfile](../profiling/suspendprofile.md)

[PROFILE_CURRENTID](../profiling/profile-currentid.md)

## See also

- [Profiling tools APIs](../profiling/profiling-tools-apis.md)
- [Walkthrough: Using profiler APIs](../profiling/walkthrough-using-profiler-apis.md)
