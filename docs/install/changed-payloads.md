---
title: "When package payloads change after a release"
description: "When creating a layout, learn how to determine if package payloads changed after a release has already shipped."
ms.date: 05/22/2019
ms.topic: conceptual
author: et13
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Package payload changes

Some package payloads are allowed to change after a release has already shipped. When you or someone else creates a layout, this behavior might result in different layout content, depending on when a layout was created.

## Verify that a layout includes package payload changes

Here's how to determine if the layout that was previously created has acquired the package payloads that were modified after the release shipped:

1. Open the setup log. The log is typically at `%TEMP%\dd_setup_[date].log` where `[date]` is when the layout operation started in `yyyyMMddHHmmss` format.

2. Look for a line in the log that is structured like the following text:

    `Falling back to signature and signer check because hash verification returned HashMismatch for path: [path]`

3. Then, look for lines later in the log that indicate that the download succeeded for the [path]. They might look similar to the following text:

    `Download of [url] succeeded using engine 'WebClient'`

    `END: Downloading [url] to [path]`

## See also

* [Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
* [Update a networked-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)