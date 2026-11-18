---
title: Control Visual Studio servicing with LTSC
description: Plan a supported Visual Studio baseline, staged updates, and a transition from an LTSC channel.
ms.date: 11/18/2026
ms.topic: how-to
author: madskristensen
ms.author: madsk
ms.subservice: installation
monikerRange: "visualstudio"
ms.custom: awp-ai
ai-usage: ai-assisted
---
# Control Visual Studio servicing with LTSC

Use this path when your organization needs time to validate Visual Studio feature releases before adopting them across the fleet. Visual Studio 2026 follows the Modern Lifecycle Policy. Long-Term Servicing Channels (LTSCs) provide a supported servicing baseline for eligible editions; they don't remove the need to deploy security updates or plan the next supported baseline.

Channel names, eligible editions, release dates, and support dates can change. Before you choose a channel, check the current [Visual Studio product lifecycle and servicing policy ↗](/visualstudio/productinfo/vs-servicing) and [release history ↗](/visualstudio/releases/2026/release-history). Use the published dates and edition eligibility, not a locally copied schedule.

## 1. Choose the baseline and servicing owner

1. Identify the Visual Studio edition, version, and channel your developers need. Check that the edition is eligible for the LTSC channel you intend to use.
1. Decide who evaluates feature changes, tests security updates, approves a rollout, and schedules the transition to the next supported baseline.
1. Select representative solutions, workloads, extensions, SDKs, and external dependencies for compatibility testing.
1. Record the channel's end-of-support date and begin planning the next baseline before that date.

## 2. Acquire the matching release

Use the bootstrapper and source for the chosen release and channel. For a controlled internal source, create and maintain a [network layout](create-a-network-installation-of-visual-studio.md) using the matching bootstrapper.

Configure client update sources so they point to the intended Microsoft channel or approved layout. Follow [Update Visual Studio](update-visual-studio.md#configure-source-location-of-updates) and, when using a layout, [Update a network installation](update-a-network-installation-of-visual-studio.md). Validate the channel and version on a pilot client before broad deployment.

Initial bootstrapper-based installation requires administrative privileges. If standard users will perform specific manual operations in the installed Visual Studio Installer, review the exact limits of [`AllowStandardUserControl`](configure-policies-for-enterprise-deployments.md#controlling-installation-download-and-update-behavior). It doesn't authorize standard-user bootstrapper or unattended installation.

## 3. Pilot the baseline and stage rollout

Install or update a pilot group from the selected channel and source. Validate representative builds, required components, extensions, licensing, package restore, and connected services. Record the baseline version and the results so that a later update can be compared against the same checks.

Expand deployment in stages after the pilot passes. Use the deployment and servicing systems your organization already operates, such as Microsoft Intune or Configuration Manager, for the specific supported task. Application deployment, policy delivery, and Visual Studio administrator-update delivery are separate workflows; follow the appropriate prerequisites for each.

## 4. Keep the baseline secure

Continue to evaluate and deploy applicable security updates while maintaining the feature baseline. Visual Studio administrator updates aren't initial installations and still require the client to reach its configured product update source. Follow [Deploy and verify administrator updates](applying-administrator-updates.md) for channel selection, client preparation, and rollout.

Don't assume every update type is available through every channel or management system. Check current release and administrator-update documentation before deciding how to distribute a specific feature, quality, or security update.

## 5. Plan the next baseline before support ends

Before the LTSC end-of-support date:

1. Select the next supported release and channel by using the current lifecycle and release-history pages.
1. Update the staging source, then test representative solutions, workloads, extensions, licensing, and user workflows.
1. Deploy the new baseline to a pilot group and resolve compatibility issues while the existing baseline remains supported.
1. Roll out the new baseline in stages and verify installed versions and required components.
1. Retire the old channel and source only after the transition and any required recovery window are complete.

## See also

- [Golden paths for enterprise deployment](enterprise-deployment-golden-paths.md)
- [Visual Studio product lifecycle and servicing ↗](/visualstudio/productinfo/vs-servicing)
- [Visual Studio release history ↗](/visualstudio/releases/2026/release-history)
- [Create and maintain a network installation](create-a-network-installation-of-visual-studio.md)
- [Apply administrator updates](applying-administrator-updates.md)
