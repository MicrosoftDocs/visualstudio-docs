---
title: Source control guidelines for projects and editors
description: Learn about the guidelines that projects and editors should adhere to in order to support source control.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source control [Visual Studio SDK], guidelines for projects and editors
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Additional source control guidelines for projects and editors

There are a number of guidelines that projects and editors should adhere to in order to support source control.

## Guidelines
 Your project or editor should also do the following to support source control:

|Area|Project|Editor|Details|
|----------|-------------|------------|-------------|
|Private copies of files|X||The environment supports private copies of files. That is, each person enlisted in the project has his/her own private copy of the files in that project.|
|ANSI/Unicode persistence|X|X|If you write the persistence code, persist files in the ANSI form because most source control programs do not currently support Unicode.|
|Enumerate files|X||The project must contain a specific list of all files within it and must be able to enumerate the list of files using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProject2> or <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A> (VSH_PROPID_First_Child/Next_Sibling). The project should also expose item names through its <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject.GetMkDocument%2A> implementation and support name lookup (including special files) through its <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject.IsDocumentInProject%2A> implementation.|
|Text format|X|X|When possible, files should be in text format to support the merging of different versions. Files that are not in text format cannot be merged with other versions of the file later on. The preferred text format is XML.|
|Reference-based|X||Reference-based projects are readily supported in source control. However, directory-based projects are also supported by source control as long as the project can produce a list of its files on demand, regardless of whether those files exist on disk. When opening a project from source control, the project file is brought down first before any of its files.|
|Persist objects and properties in predictable order|X|X|Persist your files in a predictable order, such as alphabetical order, to facilitate merging.|
|Reload|X|X|When a file changes on disk, your editor must be able to reload it. When you participate in source control, the environment will reload data for you by calling your <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2.ReloadDocData%2A> implementation. The most difficult reload case is when a checkout occurs when you have called IVsQueryEditQuerySave::<xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A> and are processing information. However, your reload code must be able to run in this situation.<br /><br /> The environment automatically reloads project files. However, a project must implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2> if it has nested hierarchies in order to support reloading nested project files.|

## Related content
- [Support source control](../../extensibility/internals/supporting-source-control.md)
