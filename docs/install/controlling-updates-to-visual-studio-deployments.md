---
title: Control updates to deployments
description: Learn how to change where Visual Studio looks for an update when you install from a network.
ms.date: 11/23/2021
ms.topic: how-to
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
---
# Control updates to network-based Visual Studio deployments

> [!WARNING]
> THIS CONTENT IS INTENDED TO BE DEPRECATED AS IT'S BEEN MERGED INTO OTHER PAGES. This page has been removed from the TOC.

Enterprise administrators often create a layout and host it on a network file share to deploy to their end users. This page describes how to configure your network layout options properly.

## Controlling where Visual Studio looks for updates

**Scenario 1: Client originally installed from a layout, but is configured to receive updates from either the network layout location or the web**

By default, Visual Studio continues to look online for updates even if the installation was originally deployed from a network share. If an update is available on the web, then the user can install it. Although the network layout cache is inspected first for any updated product bits, if they are not found there, then Visual Studio will look for and download updated product bits from the web.

**Scenario 2: Client originally installed and should only receive updates from the network layout**

If you want to control where the Visual Studio client looks for updates, for example, if your client machine does not have internet access and you want to ensure that it only and always installs from the layout, then you can configure the location where the client's installer looks for updated product bits. It is best to make sure this setting is configured correctly before the client does the initial install from the layout.

1. Create an offline layout:

   ```shell
   vs_enterprise.exe --layout C:\vsoffline --lang en-US
   ```

2. Copy it to the file share where you want to host it:

   ```shell
   xcopy /e C:\vsoffline \\server\share\VS
   ```

3. Modify the `response.json` file in the layout and change the `channelUri` value to point to a copy of the channelManifest.json that the admin controls.

   Be sure to escape backslashes in the value, as in the following example:

   ```json
   "channelUri":"\\\\server\\share\\VS\\ChannelManifest.json"
   ```

   Now end users can run setup from this share to install Visual Studio.

   ```shell
   \\server\share\VS\vs_enterprise.exe
   ```

When an enterprise administrator determines it is time for their users to update to a newer version of Visual Studio, they can [update the layout location](update-a-network-installation-of-visual-studio.md) to incorporate the updated files, as follows.

1. Use a command that is similar to the following command:

   ```shell
   vs_enterprise.exe --layout \\server\share\VS --lang en-US
   ```

2. Ensure that the `response.json` file in the updated layout still contains your customizations, specifically the channelUri modification, as follows:

   ```json
   "channelUri":"\\\\server\\share\\VS\\ChannelManifest.json"
   ```

Existing Visual Studio installs from this layout look for updates at `\\server\share\VS\ChannelManifest.json`. If the channelManifest.json is newer than what the user has installed, Visual Studio notifies the user that an update is available.

Any installation update initiated from the client will automatically install the updated version of Visual Studio directly from the layout.

**Scenario 3: Client originally installed from the web, but now should only receive updates from a network layout**

In some cases, the client machine may have already installed Visual Studio from the web, but now the administrator wants to have all future updates come from a managed layout. The only supported way to do this is to create a network layout with the desired version of the product, and then on the client machine, run the bootstrapper *from the layout location* (e.g. `\\server\share\vs_enterprise.exe`). Ideally, the original client install would have happened using the bootstrapper from the network layout with the correctly configured ChannelURI, but running the updated bootstrapper from the network layout location will also work. Either one of these actions would embed, on the client machine, a connection with that particular layout location. The only caveat for this scenario to work correctly is that the “ChannelURI” in the layout’s `response.json` file must be the same as the ChannelURI that was set on the client’s machine when the original install happened. Most likely this value was originally set to the internet [release channel](https://aka.ms/vs/16/release/channel).

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Enabling administrator updates](enabling-administrator-updates.md)
* [Applying administrator updates](applying-administrator-updates.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Tools for managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [Visual Studio product lifecycle and servicing](/visualstudio/productinfo/vs-servicing)
