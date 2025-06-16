---
title: What's New in the Visual Studio 2019 SDK
description: The Visual Studio SDK the new and updated features for Visual Studio 2019, including editor registration enhancements.
ms.date: 03/29/2019
ms.topic: conceptual
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# What's New in the Visual Studio 2019 SDK

The Visual Studio SDK has the following new and updated features for Visual Studio 2019.

## Synchronously autoloaded extensions warning

Users will now see a warning if any of their installed extensions are synchronously autoloaded on startup. You can learn more about the warning at [Synchronously autoloaded extensions](synchronously-autoloaded-extensions.md).

## Single, unified Visual Studio SDK

You can now get all Visual Studio SDK assets through a single NuGet package [Microsoft.VisualStudio.SDK](https://www.nuget.org/packages/microsoft.visualstudio.sdk).

## Editor Registration Enhancements

Since its creation, Visual Studio has supported custom editor registration where an editor can declare its affinity for specific extensions (for example, .xaml and .rc), or that it is suitable for any extension (.*). Starting in Visual Studio 2019 version 16.1, we broaden the support for editor registration.

### Filenames

In addition to, or instead of, registering support for a particular file extension, an editor can register that it supports specific filenames by applying the new `ProvideEditorFilename` attribute to the editor's package.

For example, an editor that supports all .json files would apply this `ProvideEditorExtension` attribute to its package:

```cs
[ProvideEditorExtension(typeof(MyEditor), ".json", MyEditor.Priority)]
```

Starting with 16.1, if MyEditor only supports a couple of well-known .json files, it can instead apply these `ProvideEditorFilename` attributes to its package:

```cs
[ProvideEditorFilename(typeof(MyEditor), "particular.json", MyEditor.Priority)]
[ProvideEditorFilename(typeof(MyEditor), "special.json",    MyEditor.Priority)]
```

### UIContexts

An editor can register one or more UIContexts that represent when it's enabled. UIContexts are registered by applying one or more instances of `ProvideEditorUIContextAttribute` to the package that registers the editor.

If an editor has registered UIContexts:

- If at least one of its registered UIContexts is active when a file with the given extension is opened, the editor is included in the editor search.
- If none of the registered UIContexts is active, the editor is not included in the editor search.

If an editor doesn't register any UIContexts, it is always included in the editor search for that extension.

For example, if an editor is only available when a C# project is open, it can declare this affinity by applying a `ProvideEditorUIContext` attribute:

```cs
[ProvideEditorUIContext(typeof(MyEditor), KnownUIContexts.CSharpProjectContext)]
```
