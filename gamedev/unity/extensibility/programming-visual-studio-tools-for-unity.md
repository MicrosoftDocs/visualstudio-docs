---
title: "Programming Visual Studio Tools for Unity | Microsoft Docs"
description: See examples of programming using the Visual Studio Tools for Unity (VSTU) API. Customize project files created by VSTU. Share the Unity log callback with VSTU.
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: vs-unity-tools
ms.prod: visual-studio-dev16
ms.topic: "conceptual"
ms.assetid: a5758cb0-e73b-45f5-8cae-c0eb40491026
author: therealjohn
ms.author: johmil
manager: crdun
ms.workload:
  - "unity"
---
# Program Visual Studio Tools for Unity
In this section, you'll find examples for using the Visual Studio Tools for Unity API.

## Examples
 Here are some examples that show how you can use the Visual Studio Tools for Unity APIs.

### Customize project files created by VSTU
 Visual Studio Tools for Unity provides a Unity-style callback during project file generation. To learn how you can modify the project file whenever it's regenerated, see [Example: Project file generation](./customize-project-files-created-by-vstu.md).

### Share the Unity log callback with VSTU
 Visual Studio Tools for Unity registers a log callback with Unity to be able to stream its console to Visual Studio. If your editor scripts also register a log callback with Unity, the VSTU callback might interfere with it. To learn how you can share the Unity log callback with VSTU, see [Example: Log callback](./share-the-unity-log-callback-with-vstu.md).
