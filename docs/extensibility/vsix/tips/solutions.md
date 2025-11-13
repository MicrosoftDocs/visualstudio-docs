---
title: Working with solutions
description: Tips for working with solutions.
ms.date: 12/01/2021
ms.topic: concept-article
author: madskristensen
ms.author: madsk
manager: pchapman

ms.subservice: extensibility-integration
---
# Working with solutions in Visual Studio extensions

Here's a collection of small code samples on different ways to work with solutions.

## Solution events
Listen to any solution event.

```csharp
VS.Events.SolutionEvents.OnAfterOpenProject += OnAfterOpenProject;

...

private void OnAfterOpenProject(Project obj)
{
    // Handle the event
}
```

## Is a solution open?
Check if a solution is currently open or opening.

```csharp

bool isOpen = await VS.Solutions.IsOpenAsync();
bool isOpening = await VS.Solutions.IsOpeningAsync();
```

## Get all projects in solution
Get a list of all projects in the solution.

```csharp
var projects = await VS.Solutions.GetAllProjectsAsync();
```
