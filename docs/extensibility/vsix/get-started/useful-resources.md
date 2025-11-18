---
title: Useful resources
description: A list of handy resources that help you better navigate the world of VS extensibility.
ms.date: 12/01/2021
ms.topic: article
author: madskristensen
ms.author: madsk
manager: pchapman

ms.subservice: extensibility-integration
---
# Useful resources on Visual Studio extensions

These resources can help you better navigate the world of Visual Studio extensibility.

The following video introduces useful resources for Visual Studio extension authors.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=6348394e-2792-47d4-813c-7f01d6e343fa]

## Resources
Here are some useful resources that can help you in your extension journey.

* [VSIX Community on GitHub](https://github.com/VsixCommunity)
* [VSIX Community Samples repo](https://github.com/VsixCommunity/Samples)
* [Official VSSDK documentation](../../index.yml)
* [VSSDK Samples repo](https://github.com/Microsoft/VSSDK-Extensibility-Samples)
* [Extensibility chatroom on Gitter.im](https://gitter.im/Microsoft/extendvs)

## Know how to search for help
Writing extensions is a bit of a niche activity, so searching for help online doesn’t always return relevant results. However, there are ways we can optimize our search terms to generate better results.

* Use the precise interface and class names as part of the search term.
* Try adding the words *VSIX*, *VSSDK* or *Visual Studio* to the search terms.
* Search directly on GitHub instead of Google/Bing when possible.
* Ask questions to other extenders on the [Gitter.im](https://gitter.im/Microsoft/extendvs) chatroom.

## Use open source as a learning tool
You probably have ideas about what you want your extension to do and how it should work. But what APIs should you use and how do you hook it all up correctly? These are difficult questions and a lot of people give up when these go unanswered.

A good way is to find extensions on the Marketplace that do similar things or use elements similar to what you want to do. Then find the source code for those extensions and look at what they did and what APIs they used and go from there.

## Book
To jump start your learning of the Visual Studio extensibility model, consider the [Visual Studio Extensibility Development](https://www.amazon.com/Visual-Studio-Extensibility-Development-Productivity/dp/1484258525) book by Rishabh Verma.

:::image type="content" source="../media/book.png" alt-text="Visual Studio Extensibility Development book cover.":::

It's the best book available to learn from.

## Glossary
To better understand this community toolkit and being able to search for help online, having a shared vocabulary of extensibility terms is critical. Here's an alphabetical list of concepts and words that are important for extenders to know.

### DTE
*EnvDTE is an assembly-wrapped COM library containing the objects and members for Visual Studio core automation*. Or, an easy-to-use interface for interacting with Visual Studio.

### Marketplace
The [Visual Studio Marketplace](https://marketplace.visualstudio.com) is the public extension store used by extenders to share their extensions with the world. It's owned and maintained by Microsoft and is the only official extension marketplace.

### MEF
The Managed Extensibility Framework is used by several components inside Visual Studio - predominantly the editor. It's a different way to register extension points than a *Package*.

### Package
Sometimes referred to as *Package class*. Its `InitializeAsync(...)` method is called by Visual Studio to initialize your extension. It's from here you add event listeners and register commands, tool windows, settings and other things. During compilation, the attributes on the *Package class* are used to generate a .pkgdef file, which is added to the extension automatically.

### .pkgdef
This is a Package containing keys and values to be added to Visual Studio's private registry. You can either generate this file automatically from a Package class, or create the .pkgdef file manually and included it as an `<Asset>` in the .vsixmanifest file.

### VSCT
The Visual Studio Command Table file. This is where menus, commands, and key bindings are declared.

### VSIX
Refers to the file extension of a Visual Studio extension (.vsix) and also as a pseudonym for Visual Studio extensibility all up.

### VSSDK
This is short for the *Visual Studio SDK* which are the classes, services, and component that make up the public surface are of Visual Studio's extensibility API. It's usually used when referring to the [Microsoft.VisualStudio.SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK/) NuGet package.

Find more information in the [Visual Studio SDK Glossary](../../visual-studio-sdk-glossary.md).
