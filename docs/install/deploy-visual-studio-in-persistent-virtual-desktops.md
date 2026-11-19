---
title: Deploy Visual Studio in persistent virtual desktops
description: Prepare, validate, and service Visual Studio on dedicated, persistent virtual desktops such as Windows 365 Cloud PCs.
ms.date: 11/18/2026
ms.topic: how-to
author: madskristensen
ms.author: madsk
ms.subservice: installation
monikerRange: "visualstudio"
ms.custom: awp-ai
ai-usage: ai-assisted
---
# Deploy Visual Studio in persistent virtual desktops

Use this path when each developer has a dedicated, persistent virtual desktop, such as a Windows 365 Cloud PC or a desktop in an Azure Virtual Desktop personal host pool. These desktops can start from a shared base image, but each one is assigned to one user and keeps its state between sessions, like a physical workstation.

## Confirm the environment is supported

Before you build an image, compare your desktop model with the [Visual Studio system requirements ↗](/visualstudio/releases/2026/vs-system-requirements). Visual Studio doesn't support:

- Virtual machine environments that aren't persistent or don't have a full Windows operating system.
- Application virtualization solutions, such as Microsoft App-V, MSIX for Windows, or third-party app virtualization technologies.
- Multiple simultaneous users on the same machine, including shared virtual desktop infrastructure or a pooled Azure Virtual Desktop host pool.
- FSLogix roaming profiles.

If your desktops are pooled, multisession, or reset after sign-out, this path doesn't apply. Also confirm the [product lifecycle and servicing policy ↗](/visualstudio/productinfo/vs-servicing) and the licensing terms that apply to your edition and users.

## 1. Choose the platform and desktop size

Follow your platform's current guidance for dedicated desktops. For Azure Virtual Desktop personal host pools, use the [Azure Virtual Desktop golden image guidance ↗](/azure/virtual-desktop/set-up-golden-image). Size each desktop for the developer's workloads by using the processor, memory, and disk guidance in the system requirements.

Record how developers receive project files, credentials, and package caches, and how you back up user data on the desktop.

## 2. Prepare the Visual Studio source

Choose how the base image or each desktop receives Visual Studio:

- Start with a current [Visual Studio image in Azure Marketplace](using-visual-studio-vm.md) when its edition, included components, and servicing state fit your needs.
- Or use a supported Visual Studio bootstrapper and a [full layout](create-a-network-installation-of-visual-studio.md) as the package source when you need to control acquisition or use an internal source.

If you install from a layout, every desktop created from the image keeps that layout as its update source. Keep the layout share reachable from each desktop for as long as the desktops use it, or point the desktops to a different source before you retire it. You can change the source with the [`--channelUri` parameter](update-a-network-installation-of-visual-studio.md#programmatically-update-the-client-machines) or the [update channel policy settings](configure-policies-for-enterprise-deployments.md#configuring-source-location-for-updates). For more information, see [Update a Visual Studio client that was installed from a layout](update-a-network-installation-of-visual-studio.md#manually-configure-where-the-visual-studio-client-looks-for-updates).

Choose the workloads and components for each developer role. A [`.vsconfig` file](import-export-installation-configurations.md) records the requested components; it doesn't enforce an allow list or remove unlisted components. A full layout is a source, not a requirement to install every package. Plan extensions and external dependencies separately because layout creation doesn't copy extension payloads referenced by a configuration.

## 3. Build and capture a versioned base image

1. Create a clean staging desktop that matches the target operating system, platform, and image-generation procedure.
1. Install Visual Studio from the selected source with the approved configuration. Keep a record of the Visual Studio channel, version, edition, configuration file, image version, and separately installed dependencies.
1. Install only the extensions, tools, and dependencies intended for every user of the image. Follow each extension's supported enterprise deployment and update method.
1. Prepare and capture the image by using the platform's documented generalization and image-capture procedure. Don't copy Visual Studio program files between machines as a substitute for setup.
1. Retain the previous approved image and its source until the new image passes the pilot.

If you use a custom image process, verify that it doesn't invalidate Visual Studio setup state, licensing, or the platform's support conditions.

## 4. Pilot the developer desktop

Provision a new desktop from the image, assign it to a representative developer, and verify:

- Visual Studio launches with the expected edition, workloads, components, and licensing.
- The developer can open and build a representative solution, restore required packages, and access required services.
- Approved extensions and settings are available through the intended per-machine or per-user route.
- Settings, extensions, and credentials remain after the developer signs out and back in, and after the desktop restarts.
- The desktop has adequate resources for realistic workloads.

Treat image deployment, Windows update servicing, Visual Studio servicing, and extension updates as separate responsibilities. A successful image build doesn't validate every development service or external package source.

## 5. Service existing desktops and the base image

Because each desktop persists, service installed Visual Studio instances in place, as you would physical workstations:

1. Choose a servicing method from [Golden paths for enterprise deployment](enterprise-deployment-golden-paths.md#choose-how-to-service-installations), such as [administrator updates](applying-administrator-updates.md) through Intune or Configuration Manager.
1. Pilot each update on a small set of desktops, then roll it out broadly.
1. Update the base image on a regular cadence so newly provisioned desktops start at a current, approved version. Recheck workloads, representative builds, licensing, and extensions before publishing it.
1. Record the image version and retire old images and content according to your retention policy. Don't retire a layout share while existing desktops still use it as their update source.

For supported update behavior and channels, see [Update Visual Studio](update-visual-studio.md) and the [Visual Studio product lifecycle and servicing policy ↗](/visualstudio/productinfo/vs-servicing).

## See also

- [Golden paths for enterprise deployment](enterprise-deployment-golden-paths.md)
- [Package Visual Studio for managed deployment](package-visual-studio-for-enterprise-deployment.md)
- [Visual Studio images on Azure](using-visual-studio-vm.md)
- [Visual Studio system requirements ↗](/visualstudio/releases/2026/vs-system-requirements)
