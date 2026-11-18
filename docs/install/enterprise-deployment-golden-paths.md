---
title: Golden paths for enterprise Visual Studio deployment
description: Choose an end-to-end Visual Studio deployment scenario for enterprise environments, virtual desktops, and controlled servicing.
ms.date: 11/18/2026
ms.topic: overview
author: madskristensen
ms.author: madsk
ms.subservice: installation
monikerRange: "visualstudio"
ms.custom: awp-ai
ai-usage: ai-assisted
---
# Golden paths for enterprise Visual Studio deployment

A *golden path* is a recommended, end-to-end workflow for a specific environment. Instead of starting with a list of installation features, start with your organization's situation and follow a path from acquiring content through deploying, verifying, and maintaining Visual Studio.

## Follow the deployment sequence

For layout-based deployment, follow this sequence. Team configuration comes after preparing the approved package source and deciding which self-service actions to permit.

1. **Prepare the files.** [Create and verify a full layout](create-a-network-installation-of-visual-studio.md), review its content through your organization's security and compliance process, and publish the approved source. Creating a layout doesn't install Visual Studio.
1. **Enable permitted self-service.** [Configure standard-user access](configure-policies-for-enterprise-deployments.md) and content permissions before rollout. IT decides which manual Installer actions to delegate; it supplies administrative privileges for bootstrapper-based installation.
1. **Install each team's tools.** Reuse or export a reviewed [team configuration](import-export-installation-configurations.md), then [deploy from the approved layout](deploy-a-layout-onto-a-client-machine.md). A *.vsconfig* file selects tools; it isn't a policy-enforcement mechanism.
1. **Keep installations current.** [Update the full layout](update-a-network-installation-of-visual-studio.md), [configure the client update source](update-a-network-installation-of-visual-studio.md#manually-configure-where-the-visual-studio-client-looks-for-updates), and apply and verify the update. Configuring the source doesn't install an update. The same full layout remains the source for new installations, modifications, and recovery.

## Choose a golden path

Start with the path that addresses your main deployment need. These paths can be combined: managed packaging can deliver either restricted-network or fully offline installations, and LTSC servicing can apply to workstations or virtual desktop images.

| Your situation | Recommended path | Result |
|---|---|---|
| A security-conscious organization, such as a financial-services organization, supports thousands of standard-user developers with access to an internal file share. | [Deploy restricted-network workstations for standard users](deploy-restricted-network-standard-users.md) | IT provides a full layout and scenario-specific configurations, performs the elevated initial deployment, and explicitly chooses which manual Installer operations developers can perform. |
| Developers have no internet access, and installation content must cross an approved transfer boundary. | [Deploy and maintain fully offline workstations](deploy-fully-offline-workstations.md) | IT acquires and validates content on a connected machine, transfers it into the disconnected environment, installs from a stable local source, and repeats the process for updates. |
| A packaging team must hand a repeatable Visual Studio deployment to an endpoint-management team. | [Package Visual Studio for managed deployment](package-visual-studio-for-enterprise-deployment.md) | The teams agree on the source, configuration, execution account, installation command, detection criteria, return codes, and servicing handoff. |
| Each developer uses a dedicated, persistent virtual desktop, such as a Windows 365 Cloud PC, provisioned from a shared base image. | [Deploy Visual Studio in persistent virtual desktops](deploy-visual-studio-in-persistent-virtual-desktops.md) | The image team confirms the environment is supported, validates the base image, and services each desktop in place. Pooled, multisession, and nonpersistent desktops aren't supported. |
| Your organization needs a stable servicing baseline and a planned transition to the next supported release. | [Control Visual Studio servicing with LTSC](control-visual-studio-servicing-with-ltsc.md) | IT validates a supported channel, stages updates, keeps the baseline secure, and plans migration before support ends. |

The packaging path can support either network arrangement and can use the deployment system your organization already operates. Keep application deployment, policy delivery, and administrator-update delivery distinct. For example, an Intune application deployment installs a package; it doesn't by itself enroll clients for Visual Studio administrator updates through Windows Update. See [Deploy and verify administrator updates](applying-administrator-updates.md) for current Intune and Configuration Manager requirements.

### Other environments

For connected workstations that don't need an internal source, use an elevated [command-line installation](use-command-line-parameters-to-install-visual-studio.md) with an approved [team configuration](import-export-installation-configurations.md). Confirm access to the required Microsoft endpoints.

For an existing Azure image, check [Visual Studio images on Azure](using-visual-studio-vm.md). For containerized build environments, follow [Install Build Tools into containers](build-tools-container.md); that workflow isn't for the Visual Studio IDE.

## Choose how to service installations

Choose the servicing method separately from the initial installation source. Apply it after the first deployment passes its pilot.

| Who initiates servicing | Workflow | Check before rollout |
|---|---|---|
| IT through Intune or Configuration Manager | [Deploy and verify administrator updates](applying-administrator-updates.md) | Client enrollment, package applicability, product-source access, and a verified pilot. |
| IT through an elevated script | [Update layout-based clients](update-a-network-installation-of-visual-studio.md) | The execution account, installed instance, current layout content, completion result, and restart state. |
| A developer through the Installer UI | [Configure permitted standard-user actions](configure-policies-for-enterprise-deployments.md#controlling-installation-download-and-update-behavior) and [update Visual Studio](update-visual-studio.md) | Effective policy, a supporting Installer, and access to the approved source. |
| IT in a disconnected environment | [Transfer and apply offline updates](deploy-fully-offline-workstations.md#6-transfer-and-apply-subsequent-updates) | A matching base-to-target update source and the documented Installer-then-product sequence. |

For persistent virtual desktops, service each desktop in place and update the base image for new desktops. LTSC is a channel decision, not a separate delivery mechanism; check eligibility and support dates in the [LTSC workflow](control-visual-studio-servicing-with-ltsc.md).

## Understand the shared deployment model

For layout-based enterprise deployments, keep these artifacts separate:

| Artifact | Purpose | Boundary |
|---|---|---|
| Full layout | Supplies Visual Studio product packages for the selected edition and languages, including workloads different developer teams need. | It doesn't install everything on each client or automatically include external dependencies and extension payloads. |
| Scenario-specific *.vsconfig* file | Selects the workloads and components for a developer role or project. | Import is additive; the file doesn't remove unlisted components or enforce an allow list. |

For most connected and restricted-network environments, updating the full layout is the simplest way to service clients. Fully offline environments that must minimize transferred content can also use a [minimal offline layout](update-minimal-layout.md) for updates; the [offline path](deploy-fully-offline-workstations.md) explains its limits.

## Establish permissions before deployment

IT supplies administrative privileges for initial bootstrapper-based installation. Developers can remain standard users.

If your organization permits self-service, the [`AllowStandardUserControl` policy](configure-policies-for-enterprise-deployments.md) delegates specific manual actions through an already-installed Visual Studio Installer. It doesn't give developers general administrator rights or allow them to run the bootstrapper or unattended `--quiet` or `--passive` operations as standard users.

If the Installer is blocked by your organization's application-control rules, resolve that restriction with your security team before piloting the path. Neither a layout nor a *.vsconfig* file replaces the Installer.

> [!TIP]
> If your acquisition machine or connected clients use a proxy, review [installation endpoints and network troubleshooting](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md) before acquiring content. The IDE's [custom proxy settings ↗](../ide/reference/proxy-settings.md) apply to the experiences listed in that article; don't assume they configure the Installer or a system-context deployment.

## Check the complete developer workflow

Installing Visual Studio isn't the same as provisioning every dependency for development. Test representative builds, package restore, licensing, extensions, and any connected services separately. An installation layout doesn't make GitHub Copilot, cloud services, or external package feeds available offline.

Use the [administrator guide](visual-studio-administrator-guide.md) to find an individual task or policy reference without following a complete golden path.

## See also

- [Visual Studio administrator guide](visual-studio-administrator-guide.md)
- [Deploy and verify administrator updates](applying-administrator-updates.md)
- [Configure Visual Studio policies](configure-policies-for-enterprise-deployments.md)
