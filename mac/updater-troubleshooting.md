---
title: "Updater has errors retrieving information"
description: "Instructions on how to fix when you see the error 'Error retrieving update information'. in Visual Studio 2019 for Mac"
ms.topic: troubleshooting
author: heiligerdankgesang
ms.author: dominicn
ms.date: 04/13/2019
ms.technology: vs-ide-install
ms.assetid: 31AF914A-C66B-4CD3-9429-39695E0E94AE
---

# Troubleshooting: Updater has errors retrieving information

On a rare occasion, you may see the error message "Error retrieving update information" displayed when you try to [update Visual Studio for Mac](update.md). If this happens, try the following steps to fix it:

- Check your internet connection. A drop in the connection is the most common cause of this error.
  - If a component fails to download, you can click the retry button next to the component name to try the download again.
- Restart the IDE.
- If you continue to see this error message, you can also try to update using the Installer, if the **.dmg** is still on your machine, or you can download it from [visualstudio.com](https://visualstudio.microsoft.com/vs/mac/)
  - The installer will update any installed components on your machine.
  - By re-running the installer, you'll also be able to install any missing components that you had not previously installed.
- You can also try clearing your cached downloads, by deleting the file located at `~/Library/Caches/VisualStudio/7.0/TempDownload/index.xml`.
