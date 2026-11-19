---
title: Golden path for packaging Visual Studio deployments
description: Define a repeatable Visual Studio deployment handoff with source content, configuration, execution, detection, and servicing.
ms.date: 11/18/2026
ms.topic: how-to
author: madskristensen
ms.author: madsk
ms.subservice: installation
monikerRange: "visualstudio"
ms.custom: awp-ai
ai-usage: ai-assisted
---
# Package Visual Studio for managed deployment

Your organization separates application packaging from endpoint deployment. The packaging team prepares a reviewed Visual Studio release. The deployment team distributes it to workstations whose developers are standard users.

This golden path defines the handoff between those teams. Use a layout as the package source and the supported bootstrapper and Installer commands to install and maintain Visual Studio. Packaging here means preparing a deployment payload and its execution contract, not converting Visual Studio into a new installer format.

## Prerequisites

- [Visual Studio ↗](https://aka.ms/vs/download/?cid=learn-onpage-download-install-visual-studio-page-cta) installation content for your licensed edition and approved version.
- A selected network path: [an internal file-share layout](deploy-restricted-network-standard-users.md) or [transferred content for fully offline workstations](deploy-fully-offline-workstations.md).
- Workstations that meet the [Visual Studio system requirements ↗](/visualstudio/releases/2026/vs-system-requirements).
- An endpoint-management tool or IT deployment process that can run elevated commands, wait for completion, collect results, detect the intended instance, and handle restarts.
- Security approval for the bootstrapper, Visual Studio Installer, package trust, and the deployment account.

## 1. Agree on the deployment contract

Record the following information before creating the deployment:

| Decision | Handoff requirement |
|---|---|
| Product | Edition, version, languages, licensing, and target architecture. |
| Configuration | Reviewed *.vsconfig* files for the supported developer roles, including any recommended or optional components the roles need. |
| Source | A full layout at a stable file-share or local path, its approved version, and who maintains it. |
| Execution | The account that runs installation, how it receives elevation, and how it accesses all source content. |
| Result | The installation command, return-code handling, restart behavior, and log collection. |
| Detection | The intended instance's edition, version, installation path, required components, and completion state. |
| Servicing | The approved update source, update owner, pilot process, and whether manual standard-user Installer operations are permitted. |

Visual Studio doesn't support application virtualization through App-V, MSIX for Windows, or non-Microsoft application virtualization technologies. See the [administrator guide](visual-studio-administrator-guide.md#deployment-decisions). Don't replace the supported installation process with copied program files or modified Microsoft packages.

## Select the deployment system

Use the endpoint management system your organization already operates to run the supported Visual Studio setup process. For example, Microsoft Intune or Configuration Manager (SCCM) can distribute an application package, run its install command in the required deployment context, and report deployment results. Configure policies through the policy-management method appropriate to your devices; application deployment doesn't automatically apply Visual Studio policies.

Administrator updates are a separate servicing mechanism. Intune enrollment for application deployment doesn't by itself enable Visual Studio administrator updates through Windows Update. Configuration Manager can also distribute supported administrator updates when its update point and client prerequisites are configured. To select a channel, prepare clients, and roll out updates, see [Deploy and verify administrator updates](applying-administrator-updates.md).

## 2. Prepare the payload and configuration

Create and verify the full layout by following [Create and maintain a network installation](create-a-network-installation-of-visual-studio.md). Keep the complete product source separate from the [*.vsconfig* file](import-export-installation-configurations.md) that selects what each client installs.

Include these items in the handoff:

| Item | How the deployment uses it |
|---|---|
| Full layout, including its bootstrapper, manifests, and packages | The execution account reads the share, or the deployment stages the complete content at the approved local path. |
| Role-specific *.vsconfig* file | The bootstrapper imports it for initial installation. Configuration import is additive, not an enforcement or removal rule. |
| Reviewed `response.json` | Supplies bootstrapper defaults, including the intended update source. Command-line options can override defaults; review the effective configuration. |
| Certificate-preparation procedure | Prepares offline clients to verify signed installation content. Distribute trust through the approved enterprise process. |
| Approved extension and external dependency payloads | Remain a separate acquisition and validation responsibility. Layout creation doesn't copy extension payloads referenced in a configuration. |
| Installation and detection instructions | Define execution, success criteria, restart handling, and the next servicing operation. |

Don't put license keys or credentials into a broadly readable payload. Follow [product-key deployment guidance](automatically-apply-product-keys-when-deploying-visual-studio.md) and your organization's secret-handling process.

**Checkpoint:** The deployment team can locate the exact reviewed content and configuration without interpreting the packaging team's interactive environment.

## 3. Run initial installation in the deployment context

For a file-share layout, run the following example from an elevated Command Prompt on a pilot workstation after preparing the referenced configuration:

```shell
\\server\VSLayout\vs_enterprise.exe --config "C:\VSConfig\Developer.vsconfig" --noWeb --quiet --wait --norestart
```

Replace the source and configuration paths with your approved locations. For local staging, invoke the bootstrapper at its stable local layout path. The deployment account must be able to read the source; a successful test as the signed-in administrator doesn't prove that a system-context process can read a network share.

This example uses a file share, not an intranet web-hosted layout. `--noWeb` fails for web-hosted layouts and also fails if requested product content is absent. Use the separate [intranet deployment instructions](deploy-a-layout-onto-a-client-machine.md#install-from-an-internal-intranet-location) if that is your chosen topology.

> [!TIP]
> For a proxy-connected acquisition or deployment process, test [installation network requirements](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md) as the actual execution account. The IDE's proxy configuration isn't a substitute for configuring a deployment process's network access.

> [!IMPORTANT]
> Initial installation still requires an elevated IT process. `AllowStandardUserControl` doesn't authorize standard-user `--quiet` or `--passive` execution or bootstrapper use. If policy blocks the Installer itself, resolve that prerequisite with security rather than attempting a different package wrapper.

**Checkpoint:** The command runs under the intended deployment account and reads only approved content sources.

## 4. Handle completion, detection, and retries

Wait for both the Visual Studio Installer and product setup. The bootstrapper's `--wait` option keeps it running until installation finishes. Configure your deployment tool to wait for that process and capture its return code. See [command-line waiting examples](command-line-parameter-examples.md#using---wait).

| Return code | Deployment action |
|---|---|
| `0` | Run instance detection and post-installation checks before recording the deployment as complete. |
| `3010` | Record successful setup with a required restart, schedule the restart, and verify readiness afterward. |
| `1641` | Account for the restart initiated by setup and verify the machine afterward. |
| `1001`, `1003`, or `1618` | Setup or Visual Studio is already in use. Follow the documented condition, arrange a maintenance window, and retry rather than treating it as success. |
| Other codes | Interpret the [return-code reference](use-command-line-parameters-to-install-visual-studio.md#error-codes), retain installation logs, and investigate the failure. |

Use [instance-detection tools](tools-for-managing-visual-studio-instances.md) such as `vswhere` or the Setup Configuration API. Detect the intended instance and required components, not just the presence of the Visual Studio Installer or a bootstrapper file. If an existing instance needs more components, use the documented `modify` operation; `update` doesn't add the configuration's missing components.

**Checkpoint:** The endpoint-management result distinguishes completed installations, restart-required installations, and failures. A retry doesn't create an unintended second instance.

## 5. Validate the developer and servicing handoff

On the pilot, launch Visual Studio as a standard user, build a representative solution, and check licensing and separately acquired dependencies.

Give the deployment team the next update procedure as part of the same handoff:

1. Record the detected client base versions and configurations.
1. Acquire and validate the next release on the connected acquisition machine, and update the full source that the deployment uses.
1. Distribute the update content, then test Installer and product servicing with the actual deployment account.
1. Recheck the instance version, components, restart state, and representative build before expanding rollout.

Keep initial deployment, policy delivery, and administrator-update delivery separate. Deploying Visual Studio through an Intune application doesn't itself enable Visual Studio updates through Windows Update. Use [Deploy and verify administrator updates](applying-administrator-updates.md) only when that delivery path's enrollment and connectivity prerequisites are met. For disconnected clients, follow the transferred-content path instead.

If IT permits self-service, apply [`AllowStandardUserControl`](configure-policies-for-enterprise-deployments.md) separately and test the allowed manual operation in the installed Installer. A managed deployment package doesn't automatically grant that permission.

**Checkpoint:** Packaging and deployment teams share a verified installation result and an executable servicing plan, not just a one-time payload.

## See also

- [Golden paths for enterprise deployment](enterprise-deployment-golden-paths.md)
- [Deploy restricted-network workstations for standard users](deploy-restricted-network-standard-users.md)
- [Deploy and maintain fully offline workstations](deploy-fully-offline-workstations.md)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
