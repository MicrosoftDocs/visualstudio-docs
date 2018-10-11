---
title: "Share the Unity Log Callback with VSTU | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 5d71f906-6e50-4399-b59b-d38c6dfef7ee
caps.latest.revision: 5
author: "TerryGLee"
ms.author: "tglee"
manager: "ghogen"
---
# Share the Unity Log Callback with VSTU
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [Share the Unity Log Callback with VSTU](https://docs.microsoft.com/visualstudio/cross-platform/share-the-unity-log-callback-with-vstu).  
  
  
Visual Studio Tools for Unity registers a log callback with Unity to be able to stream its console to Visual Studio. If your editor scripts also register a log callback with Unity, the VSTU callback might interfere with your callback. To prevent this possibility, use the `VisualStudioIntegration.LogCallback` event to cooperate with VSTU.  
  
## Demonstrates  
 How to share the Unity Log Callback created by Visual Studio Tools for Unity.  
  
## Example  
  
```csharp  
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
```  
  
## See Also  
 [Example: Project File Generation](../cross-platform/customize-project-files-created-by-vstu.md)

