---
title: Working with builds
description: Tips for working with builds.
ms.date: 12/01/2021
ms.topic: concept-article
author: madskristensen
ms.author: madsk
manager: pchapman

ms.subservice: extensibility-integration
---
# Working with builds in Visual Studio extensions 

Here's a collection of small code samples on different ways to work with builds.

## Build solution
To build the entire solution, call the `BuildAsync()` method.

```csharp
bool buildStarted = await VS.Build.BuildSolutionAsync(BuildAction.Build);
```

## Build project
You can build any project by passing it to the method.

```csharp
Project project = await VS.Solutions.GetActiveProjectAsync();
await project.BuildAsync(BuildAction.Rebuild);
```

## Set build property
Shows how to set a build property on the project.

```csharp
Project project = await VS.Solutions.GetActiveProjectAsync();
bool succeeded = await project.TrySetAttributeAsync("propertyName", "value");
```

## Get build property
Shows how to get a build property of any project or project item.

```csharp
Project item = await VS.Solutions.GetActiveProjectAsync();
string value = await item.GetAttributeAsync("propertyName");
```
