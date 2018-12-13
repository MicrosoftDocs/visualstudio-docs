---
title: "Share the Unity Log Callback with VSTU | Microsoft Docs"
ms.custom: ""
ms.date: "07/26/2018"
ms.technology: vs-unity-tools
ms.topic: "conceptual"
ms.assetid: 5d71f906-6e50-4399-b59b-d38c6dfef7ee
author: therealjohn
ms.author: johmil
manager: crdun
ms.workload:
  - "unity"
---
# Share the Unity log callback with VSTU
Visual Studio Tools for Unity registers a log callback with Unity to be able to stream its console to Visual Studio. If your editor scripts also register a log callback with Unity, the VSTU callback might interfere with your callback. To prevent this possibility, use the `VisualStudioIntegration.LogCallback` event to cooperate with VSTU.

## Demonstrates
 How to share the Unity Log Callback created by Visual Studio Tools for Unity.

## Example

```csharp
#if ENABLE_VSTU
using System;

using UnityEngine;
using UnityEditor;

using SyntaxTree.VisualStudio.Unity.Bridge;

[InitializeOnLoad]
public class LogCallbackHook
{
    static LogCallbackHook()
    {
        VisualStudioIntegration.LogCallback += (string condition, string trace, LogType type) =>
        {
            // place code that implements your log callback here
        };
    }
}
#endif
```

## See also
 [Example: Project file generation](../cross-platform/customize-project-files-created-by-vstu.md)
