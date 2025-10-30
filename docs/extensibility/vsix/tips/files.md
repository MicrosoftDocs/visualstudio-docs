---
title: Working with files
description: Tips for working with files.
ms.date: 12/01/2021
ms.topic: concept-article
author: madskristensen
ms.author: madsk
manager: pchapman

ms.subservice: extensibility-integration
---
# Working with files and documents in Visual Studio extensions

Here's a collection of small code samples on different ways to work with files and documents.

## Get active text view
Get the current active text view to manipulate its text buffer text.

```csharp
DocumentView docView = await VS.Documents.GetActiveDocumentViewAsync();
if (docView?.TextView == null) return; //not a text window
SnapshotPoint position = docView.TextView.Caret.Position.BufferPosition;
docView.TextBuffer?.Insert(position, "some text"); // Inserts text at the caret
```

## File icon associations
To associate an icon with a file extension in Solution Explorer, add the `[ProvideFileIcon()]` attribute to your package class.

```csharp
[ProvideFileIcon(".abc", "KnownMonikers.Reference")]
public sealed class MyPackage : ToolkitPackage
{
    ...
}
```

See the thousands of available icons in the `KnownMonikers` collection using the KnownMonikers Explorer tool window. Find it under **View > Other Windows** in the main menu.

## Open file
Use the `Microsoft.VisualStudio.Shell.VsShellUtilities` helper class.

```csharp
string fileName = "c:\\file.txt";
await VS.Document.OpenAsync(fileName);
```

## Open file via project
Use this method when the file you open is part of the solution.

```csharp
string fileName = "c:\\file.txt";
await VS.Documents.OpenViaProjectAsync(fileName);
```

## Open file in Preview tab
The Preview tab, also known as the Provisional tab, is a temporary tab that opens on the right side of the document well. Open any file in the Preview tab like this:

```csharp
string fileName = "c:\\file.txt";
await VS.Documents.OpenInPreviewTabAsync(fileName);
```

## Get file name from ITextBuffer
Use the extension method `buffer.GetFileName()` located in the `Microsoft.VisualStudio.Text` namespace.

```csharp
string fileName = buffer.GetFileName();
```

## SolutionItem from file
Find the `SolutionItem` from an absolute file path.

```csharp
string fileName = "c:\\file.txt";
PhysicalFile item = await PhysicalFile.FromFileAsync(fileName);
```
