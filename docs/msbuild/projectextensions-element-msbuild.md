---
title: ProjectExtensions Element (MSBuild)
description: Learn about the MSBuildProjectExtensions element, which allows MSBuild project files to contain non-MSBuild information.
ms.date: 03/13/2017
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#ProjectExtensions
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- <ProjectExtensions> element [MSBuild]
- ProjectExtensions element [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# ProjectExtensions element (MSBuild)

Allows MSBuild project files to contain non-MSBuild information. Anything inside of a `ProjectExtensions` element will be ignored by MSBuild.

 \<Project>
 \<ProjectExtensions>

## Syntax

```xml
<ProjectExtensions>
    Non-MSBuild information to include in file.
</ProjectExtensions>
```

## Attributes and elements

 The following sections describe attributes, child elements, and parent elements.

### Attributes

 None

### Child elements

 None

### Parent elements

| Element | Description |
| - | - |
| [Project](../msbuild/project-element-msbuild.md) | Required root element of an MSBuild project file. |

## Remarks

 Only one `ProjectExtensions` element may be used in an MSBuild project.

## Example

 The following code example shows information from the integrated development environment being stored in a `ProjectExtensions` element.

```xml
<ProjectExtensions>
    <VSIDE>
        <External>
            <!--
            Raw XML passed to the IDE by an external source
            -->
        </External>
    </VSIDE>
</ProjectExtensions>
```

## See also

- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
- [MSBuild](../msbuild/msbuild.md)
