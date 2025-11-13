---
title: Source Control Design Decisions
description: Learn about several key design decisions to consider for projects when implementing source control.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- source control [Visual Studio SDK], design decisions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Source Control Design Decisions

The following design decisions should be considered for projects when implementing source control.

## Will information be shared or private?
 The most important design decision you can make is what information is sharable and what is private. For example, the list of files for the project is shared, but within this list of files, some users might want to have private files. Compiler settings are shared, but the start-up project is generally private. Settings are either purely shared, shared with an override, or purely private. By design, private items, such as Solution user options (.suo) files, are not checked into Visual SourceSafe. Be sure to store any private information in private files such as the .suo file, or a specific private file you create, for example, a .csproj.user file for Visual C# or a .vbproj.user file for Visual Basic.

 This decision is not all-inclusive and can be made on an item-by-item basis.

## Will the project include special files?
 Another important design decision is whether your project structure uses special files. Special files are hidden files that underlie the files that are visible in Solution Explorer and in the check-in and check-out dialog boxes. If you use special files, follow these guidelines:

1. Do not associate special files with the project root node—that is, with the project file itself. Your project file must be a single file.

2. When special files are added, removed, or renamed in a project, the appropriate <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocumentsEvents2> events must be fired with the flag set that indicates the files are special files. These events are called by the environment in response to the project calling the appropriate <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2> methods.

3. When your project or editor calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A> for a file, the special files associated with that file are not automatically checked out. Pass the special files in along with the parent file. The environment will detect the relationship between all files that are passed in and appropriately hide the special files in the check-out UI.

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocumentsEvents2>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2>
- [Supporting Source Control](../../extensibility/internals/supporting-source-control.md)
