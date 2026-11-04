---
title: Private galleries for Visual Studio extensions
description: Learn how to distribute Visual Studio extensions within your organization using private galleries with Atom feeds and the Extension Manager.
ms.date: 04/01/2026
ms.topic: how-to
ms.author: tinali
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---

# Private galleries for Visual Studio extensions

You can share extensions within your organization by hosting them on a private gallery on your intranet or other internal infrastructure. Private galleries currently use Atom (RSS) feeds to list available extensions that Visual Studio can discover through the Extension Manager.

> [!NOTE]
> A new private gallery model is being developed. The Atom-based approach described here continues to work, but watch for announcements about the updated mechanism.

## Set up a private gallery

A private gallery is an Atom feed (XML file) that describes the available extensions. You host this feed on a web server, network share, or any location accessible to your target users.

For details on creating the Atom feed, see [Create an Atom feed for a private gallery ↗](/visualstudio/extensibility/how-to-create-an-atom-feed-for-a-private-gallery). You can also use the VsixUtil tool to generate feeds — see [Create a VSIX feed for a private gallery ↗](/visualstudio/extensibility/how-to-create-vsix-feed-for-private-gallery).

## Add a private gallery in Visual Studio

1. In Visual Studio, go to **Tools** > **Options**.
2. Navigate to **Environment** > **Extensions**.
3. Select **Add** to add a new gallery.
4. In the **Name** field, enter a name for your private gallery (for example, `My Organization Extensions`).
5. In the **URL** field, enter the URL to the Atom feed or other feed hosting the extensions.
6. Select **OK** to save.

The private gallery now appears in the **Extensions** > **Manage Extensions** dialog under **Online**.

## Install extensions from a private gallery

1. In Visual Studio, go to **Extensions** > **Manage Extensions**.
2. Select **Online** and choose your private gallery from the list on the left.
3. Browse or search for the extension you want to install.
4. Select **Download** to schedule the installation.
5. Close all instances of Visual Studio to complete the installation.

## Update extensions from a private gallery

When an updated version of an extension is available in the private gallery, Visual Studio detects the update automatically. Check for updates in **Extensions** > **Manage Extensions** > **Updates**.

## Manage private galleries using registry settings

You can also add private galleries through the Windows registry or distribute a `.pkgdef` file with your extension that registers the gallery automatically. For more information, see [Manage a private gallery using registry settings ↗](/visualstudio/extensibility/how-to-manage-a-private-gallery-by-using-registry-settings).

## Related content

- [Publish and distribute extensions](../ship/overview.md)
- [Publish to the Marketplace](../ship/publish-to-marketplace.md)
