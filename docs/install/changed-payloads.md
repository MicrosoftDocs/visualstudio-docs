---
title: "Payloads modified after a release"
description: "Learn how to determine if payloads were modified after a release when creating a layout."
ms.date: 05/21/2019
ms.topic: conceptual
author: et13
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Payloads modified after a release

When creating a layout, some payloads are allowed to change after the release was shipped. This behavior can result in different layout content depending on when the layout was created.

Here's how to determine if the layout creation acquired payloads that were modified after the release shipped:

1. Open the setup log. The log is typically at `%TEMP%\dd_setup_[date].log` where `[date]` is when the layout operation started in `yyyyMMddHHmmss` format.

2. Look for a line in the log structured like

    `Falling back to signature and signer check because hash verification returned HashMismatch for path: [path]`

3. Then look for lines later in the log indicting that the download succeeded for the `[path]`

    `Download of [url] succeeded using engine 'WebClient'`

    `END: Downloading [url] to [path]`


## See also

* [Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
* [Update a networked-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)