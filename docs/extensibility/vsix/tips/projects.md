---
title: Working with projects
description: Tips for working with projects.
ms.date: 12/01/2021
ms.topic: conceptual
author: madskristensen
ms.author: madsk
manager: pchapman

ms.subservice: extensibility-integration
---
# Working with projects in Visual Studio extensions

Here's a collection of small code samples on different ways to work with projects.

## Get project from contained file
This is how to get the project from one of its files.

```csharp
 string fileName = "c:\\file\\in\\project.txt";
 PhysicalFile item = await PhysicalFile.FromFileAsync(fileName);
 Project project = item.ContainingProject;
```

## Add files to project
Here's how to add files from disk to the project.

```csharp
Project project = await VS.Solutions.GetActiveProjectAsync();

var file1 = "c:\\file\\in\\project\\1.txt";
var file2 = "c:\\file\\in\\project\\2.txt";
var file3 = "c:\\file\\in\\project\\3.txt";

await project.AddExistingFilesAsync(file1, file2, file3);
```

## Find type of project
Find out what type of project you're dealing with.

```csharp
bool isCsharp = await project.IsKindAsync(ProjectTypes.CSHARP);
```
