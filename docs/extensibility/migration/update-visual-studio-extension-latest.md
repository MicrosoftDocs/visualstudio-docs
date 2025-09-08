---
title: Update a Visual Studio extension for the Insiders pre-release
description: Update your Visual Studio extension for .NET or C++ to work with the latest Insiders version of Visual Studio, including running code in extensions and shared projects for multi-targeting.
ms.date: 9/08/2025
ms.topic: conceptual
author: kalaskarsanket
ms.author: skalaskar
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: "visualstudio"

---
# Update extensions for Visual Studio

With the latest Insiders pre-release version of Visual Studio, you can easily install Visual Studio 2022 extensions.

Since there are minimal breaking changes, updating your extension should be straightforward. With the pre-release version of Visual Studio, you can test your existing extension and provide us with your feedback.

To install and test your extension:

1. Install the latest [Visual Studio (Insiders)](https://aka.ms/vs/insiders?cid=learn-onpage-download-install-visual-studio-page-cta).

1. Navigate to **Extension Manager**.

1. Use the search function to find your extension.

1. Install it and confirm that it operates as expected. 

If your extension is an MSI, you might need to modify the installer to allow the installation of Visual Studio 2022 extensions on the latest pre-release version of Visual Studio. 

:::image type="content" alt-text="Screenshot of Visual Studio Extension Manager." source="media/visualstudio/visual-studio-extension.png" lightbox="media/visualstudio/visual-studio-extension.png" :::

At present, there are no instructions for creating extensions for the pre-release Insiders version of Visual Studio. Further details will be shared as soon as they are available. In the meantime, you can test Visual Studio 2022 extensions with the Insiders pre-release.

To learn more about Breaking Changes, please refer [Breaking changes for Visual Studio Extensibility](https://github.com/microsoft/VSExtensibility/blob/main/docs/breaking_changes.md). 

## Feedback and Issue Reporting 

If you encounter issues with your extensions in the Insiders pre-release version of Visual Studio, please report the problem [here](https://aka.ms/ExtensionFeedback) and include a reference to the ticket.
