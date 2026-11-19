---
title: Golden path for fully offline Visual Studio workstations
description: Acquire, transfer, install, verify, and update Visual Studio for developers whose workstations have no internet access.
ms.date: 11/18/2026
ms.topic: how-to
author: madskristensen
ms.author: madsk
ms.subservice: installation
monikerRange: "visualstudio"
ms.custom: awp-ai
ai-usage: ai-assisted
---
# Deploy and maintain fully offline Visual Studio workstations

Your developers work in a disconnected environment. Their workstations can't reach Microsoft download services, and IT must approve every transfer into the environment. This golden path separates connected acquisition from offline installation and servicing.

The recommended flow is a full layout for the initial package source, a scenario-specific *.vsconfig* file for each developer role, and minimal offline layouts for subsequent updates when their version and configuration requirements match your clients.

If developers have access to an internal file share that IT maintains, use [Deploy restricted-network workstations for standard users](deploy-restricted-network-standard-users.md). This path instead uses a stable local layout folder on each workstation.

## Prerequisites

- [Visual Studio ↗](https://aka.ms/vs/download/?cid=learn-onpage-download-install-visual-studio-page-cta) installation media for your licensed edition, acquired on an internet-connected administrative machine.
- Workstations that meet the [Visual Studio system requirements ↗](/visualstudio/releases/2026/vs-system-requirements).
- An approved process for transferring complete layouts, certificates, configuration files, and subsequent update content into the disconnected environment.
- An elevated IT execution context for installation and scripted servicing, with permission to run the bootstrapper and Visual Studio Installer.
- Enough storage for the full layout, the installed product, and servicing content.
- A licensing plan that meets your offline-use requirements. Review [product keys](automatically-apply-product-keys-when-deploying-visual-studio.md) before rollout; a layout doesn't grant a license or remove sign-in requirements.

> [!IMPORTANT]
> Don't use **Download all, then install** as transferable installation media. That download is customized for the machine where it runs. For deployment to other machines, create a layout.

## 1. Define the offline installation

Record the edition, version, languages, workloads, and components for each developer role. Export and review a [*.vsconfig* file](import-export-installation-configurations.md). The file selects workloads and components; it isn't an enforcement policy and doesn't specify product UI languages. Include each required language in the layout and select it with `--addProductLang` during installation.

Plan dependencies outside Visual Studio separately. If your configuration includes extensions, check their supported installation routes and stage approved payloads at locations accessible inside the disconnected environment. [Extension references in a layout configuration aren't copied into the layout](create-a-network-installation-of-visual-studio.md#use-a-configuration-file-to-initialize-the-contents-of-a-layout).

**Checkpoint:** Your deployment plan includes both the Visual Studio configuration and the separate package feeds, SDKs, extensions, and licensing arrangements needed for a representative offline build.

## 2. Acquire and verify content on the connected machine

Download the [bootstrapper for the approved edition and version](create-a-network-installation-of-visual-studio.md#download-the-visual-studio-bootstrapper-to-create-the-layout). In an elevated Command Prompt, create the full layout for the required languages. For example, these commands acquire and verify Visual Studio Enterprise product content for English:

```shell
vs_enterprise.exe --layout C:\VSLayout --lang en-US
vs_enterprise.exe --layout C:\VSLayout --verify
```

Add your required languages when creating the layout. Don't pass a scenario-specific `--config` during full-layout creation: that option limits the acquired content to the configuration. Use the configuration for client installation instead.

Follow [layout maintenance guidance](create-a-network-installation-of-visual-studio.md) to include the Installer version your clients need. Resolve missing or invalid packages on the connected machine before transfer.

> [!TIP]
> If acquisition passes through a proxy, validate the [installation endpoint allow list and proxy requirements](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md) by using the account that acquires the content.

**Checkpoint:** Verification succeeds, the layout contains the required product and Installer content, and IT records the approved version and configuration.

## 3. Transfer content and prepare client trust

Transfer the complete layout folder, the reviewed *.vsconfig* files, and approved external dependencies through your organization's transfer process. Stage the layout at a stable local path such as `C:\VSLayout` on each workstation.

Prepare [offline root and intermediate certificates](install-certificates-for-visual-studio-offline.md) through your organization's trust-management process. Keep Microsoft package signatures intact; don't re-sign installation packages to work around verification failures.

Configure [installation defaults](automated-installation-with-response-file.md#configure-the-response-file-used-when-installing-from-a-layout), including an update source inside the disconnected environment. The layout's default update source can point to Microsoft-hosted services, so review it before installation.

**Checkpoint:** The deployment account can read the local content, package signatures validate, and neither the configuration nor the update source depends on an internet-only location.

## 4. Install from the local layout

On the offline workstation, use an elevated Command Prompt to run the bootstrapper from the transferred layout. For example, stage your configuration at `C:\VSConfig\Developer.vsconfig`, then run:

```shell
C:\VSLayout\vs_enterprise.exe --config "C:\VSConfig\Developer.vsconfig" --addProductLang en-US --noWeb --passive --wait --norestart
```

`--noWeb` prevents acquisition of missing Visual Studio product packages from Microsoft-hosted services. Installation fails if required content is missing. This option doesn't provision external dependencies or make other developer services offline-capable.

Wait for both the Installer and the product installation to finish. Interpret the [return code](use-command-line-parameters-to-install-visual-studio.md#error-codes) and handle a required restart before marking the workstation ready.

Keep the local layout at the recorded path for later operations. See [local-layout path requirements](create-an-offline-installation-of-visual-studio.md#step-3---install-visual-studio-from-the-local-layout). Don't edit the instance's state files to relocate its source.

**Checkpoint:** Visual Studio installs without internet access, and the installation result and any restart requirement are recorded.

## 5. Validate as an offline developer

Before rollout, test a workstation with no internet access:

1. Use [instance-detection tools](tools-for-managing-visual-studio-instances.md) to record the edition, version, installation path, and required components.
1. Launch Visual Studio as the developer's standard-user account and confirm the licensing experience works for your organization.
1. Build and restore a representative solution using only approved offline dependencies.
1. Check the client update source and confirm the local layout remains accessible.
1. If IT permits manual servicing, validate the exact operation with the latest required Installer and [`AllowStandardUserControl`](configure-policies-for-enterprise-deployments.md). Otherwise, retain elevated IT servicing.

Standard-user policy doesn't allow a developer to run the bootstrapper or unattended installation commands. No step in this path requires giving developers general administrator rights.

**Checkpoint:** Both installation and the representative development workflow work while disconnected. Failed restore, licensing, or extension acquisition is a rollout blocker even if setup succeeded.

## 6. Transfer and apply subsequent updates

Inventory client base versions and configurations before acquiring the next update. On the connected acquisition machine, follow [Update Visual Studio using a minimal offline layout](update-minimal-layout.md) to preview, generate, and verify an update layout for the required base-to-target version range, product, workloads, and languages.

Transfer the entire minimal layout through the approved process. On each target, follow that article's two-stage sequence: update the Installer from the supplied offline content, then update the intended Visual Studio instance with `--noWeb`. IT runs scripted servicing with administrative privileges. Check completion and restart requirements after each stage, then repeat the offline pilot checks.

Keep the full layout available for new installations, adding content, and recovery. Maintain the full source separately; the minimal layout supplies update packages, not a repair source. Its **Verify** and **Fix** operations check the layout, not whether a workstation meets compliance requirements.

For a new workstation that needs the newer version directly, [update or recreate the full layout for that version](update-minimal-layout.md#install-a-new-machine-after-updating-existing-clients), then repeat this path's transfer, installation, and pilot steps. Don't transfer only the minimal layout or assume setup combines it with the older full source.

**Checkpoint:** The pilot reaches the approved target version without internet access, and IT can reproduce the update for every applicable base-version group.

## Recover a blocked deployment

| Problem | Action |
|---|---|
| Setup requests unavailable content or fails with `--noWeb` | Compare the client configuration with the transferred layout. Acquire missing content on the connected machine, validate it, and repeat the approved transfer. |
| Signature verification fails | Review [offline certificate preparation](install-certificates-for-visual-studio-offline.md) and package integrity instead of bypassing trust checks. |
| An update doesn't apply to a workstation | Verify its base version, edition, installed components, target version, and the minimal layout's scope. |
| Repair needs packages absent from the minimal layout | Restore access to the appropriate complete source and follow [Repair Visual Studio](repair-visual-studio.md). |
| A build or extension still needs the internet | Provision its separate approved source; an installation layout doesn't mirror external services or feeds. |

## See also

- [Golden paths for enterprise deployment](enterprise-deployment-golden-paths.md)
- [Package Visual Studio for managed deployment](package-visual-studio-for-enterprise-deployment.md)
- [Deploy Visual Studio from a layout](deploy-a-layout-onto-a-client-machine.md)
- [Update Visual Studio using a minimal offline layout](update-minimal-layout.md)
