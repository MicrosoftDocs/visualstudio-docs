---
title: Publish and distribute Visual Studio extensions
description: Learn how to publish, distribute, sign, localize, and maintain Visual Studio extensions built with VisualStudio.Extensibility or the Visual Studio SDK.
ms.date: 10/20/2026
ms.topic: overview
ms.author: tinali
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---

# Ship Visual Studio extensions

After you've finished developing your extension, you can install it on other machines, share it with your team, or publish it on the Visual Studio Marketplace. This section covers everything you need to publish and maintain your extension: working with VSIX packages, publishing, localizing, signing, and updating.

## Working with VSIX packages

Visual Studio extensions are distributed as VSIX packages — `.vsix` files that contain your extension's binaries, metadata, and supporting files. Both VisualStudio.Extensibility and VSSDK extensions use the same VSIX package format.

For new projects in Visual Studio 18.11 or later, use the [Modern VSIX Project Template](create-vsix-with-project-sdk.md). If you're using an earlier development environment or maintaining an existing packaging project, see [VSIX packaging for older projects](vsix-projects.md). Choose one project workflow; you don't need to follow both guides to package your extension.

A VSIX package is built automatically when you compile your extension project in **Release** mode. The resulting `.vsix` file is located in your project's output folder (for example, `bin\Release`).

You can use the VSIX format to package extension components, assemblies, and supporting files. The VSIX format uses file-based deployment and follows the Open Packaging Conventions (OPC) standard.

## Publish your extension to Visual Studio Marketplace

You can distribute your extension by simply sharing the `.vsix` file, but the best way to reach a large audience is to publish to the [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/vs). Extensions on the Marketplace are available to all Visual Studio users through the Extension Manager (**Extensions** > **Manage Extensions**).

For a step-by-step walkthrough, see [Publish to the Marketplace](publish-to-marketplace.md). You can also automate publishing using the [VsixPublisher.exe command-line tool](publish-via-command-line.md).

## Private galleries

As you develop extensions for your organization, you can share them by hosting a private gallery on your intranet. Private galleries use Atom (RSS) feeds that Visual Studio can discover through the Extension Manager.

For more information, see [Private galleries](../advanced/private-galleries.md).

## Localize your extension

If you're planning to release your extension in different locales, you should localize it. VisualStudio.Extensibility extensions use `string-resources.json` files for localizing command display names, tooltips, and other metadata.

For details, see [Localize extensions](localize-extensions.md).

## Sign your extension

Adding a digital signature to a VSIX package secures your extension and prevents tampering. During install, the VSIX installer displays the signature and a link to the certificate.

For details, see [Sign VSIX packages](sign-vsix-packages.md).

## Update and version your extension

After you've published your extension, you'll need to update it over time. The Extension Manager detects updates automatically when a newer version is available on the Marketplace or a private gallery.

For details, see [Publish to the Marketplace](publish-to-marketplace.md).

## Related content

|Article|Description|
|---|---|
| [Publish to the Marketplace](publish-to-marketplace.md) | Step-by-step guide for publishing to the Marketplace. |
| [Publish via command line](publish-via-command-line.md) | Automate publishing with VsixPublisher.exe. |
| [Sign VSIX packages](sign-vsix-packages.md) | Digitally sign your extension for security. |
| [Localize extensions](localize-extensions.md) | Provide localized metadata for international users. |
| [Private galleries](../advanced/private-galleries.md) | Distribute extensions within your organization. |
