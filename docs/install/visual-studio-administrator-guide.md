---
title: Enterprise management overview for Visual Studio
titleSuffix: ''
description: Choose Visual Studio enterprise deployment and update paths, manage layouts and policies, and find inventory and recovery guidance.
ms.date: 11/18/2026
ms.topic: overview
helpviewer_keywords:
- network installation, Visual Studio
- administrator guide, Visual Studio
- installing Visual Studio, administrator guide
author: madskristensen
ms.author: madsk
ms.subservice: installation
ms.custom: awp-ai
ai-usage: ai-assisted
---
# Manage Visual Studio in your organization

Use this guide to find Visual Studio administration tasks: deploy and maintain Visual Studio, govern extensions, and govern AI. Each section links to the detailed task and reference articles.

Start with the task that matches the machines you manage:

| Your task | Start here | Completion checkpoint |
|---|---|---|
| Deploy Visual Studio to new developer machines | [Choose a golden path](enterprise-deployment-golden-paths.md#choose-a-golden-path) | A pilot developer can build with the approved tools, permissions, and content sources. |
| Update installed instances through Intune or Configuration Manager | [Deploy and verify administrator updates](applying-administrator-updates.md) | The target version is verified on pilot clients before broad rollout. |
| Service installations from an internal or offline source | [Update layout-based clients](update-a-network-installation-of-visual-studio.md) or [service fully offline machines](deploy-fully-offline-workstations.md#6-transfer-and-apply-subsequent-updates) | Update content reaches the intended clients, and their versions and restart state are verified. |
| Configure organization-wide behavior | [Configure Visual Studio policies](configure-policies-for-enterprise-deployments.md) | Effective policies are verified on the intended machines. |

Use the task references in the following sections for an individual operation. Scenario selection and servicing choices are together in the [golden-path overview](enterprise-deployment-golden-paths.md).

## Deploy and maintain Visual Studio

For a new deployment, prepare the content, configure permitted self-service, install each team's tools, and then establish servicing. Follow one [golden path](enterprise-deployment-golden-paths.md) through the pilot instead of treating every linked reference as another required step.

### Plan your deployment

Decide which edition, workloads, languages, update source, and installation permissions your organization needs before the first client installation.

#### System requirements

::: moniker range="=visualstudio"

Check the [Visual Studio system requirements ↗](/visualstudio/releases/2026/vs-system-requirements) for the target machines.

::: moniker-end

::: moniker range="=vs-2022"

Check the [Visual Studio 2022 system requirements ↗](/visualstudio/releases/2022/system-requirements) for the target machines.

::: moniker-end

#### Deployment decisions

Visual Studio doesn't support application virtualization solutions such as Microsoft App-V, MSIX for Windows, or non-Microsoft application virtualization technologies. For an Azure virtual machine, start with [Visual Studio images on Azure](using-visual-studio-vm.md), not an application virtualization workaround.

- [Choose a golden path](enterprise-deployment-golden-paths.md#choose-a-golden-path) based on network access, permissions, and servicing ownership.
- Review [firewall and proxy requirements](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md).
- Plan [subscription administration ↗](/visualstudio/subscriptions/admin-responsibilities), [product keys ↗](/visualstudio/subscriptions/product-keys), and [applying keys during deployment](automatically-apply-product-keys-when-deploying-visual-studio.md).
- Review the [published product lifecycle and servicing policy ↗](/visualstudio/productinfo/vs-servicing) for the version you deploy and the [Windows security baselines ↗](/windows/security/threat-protection/windows-security-baselines).

> [!IMPORTANT]
> Initial installation by using the Visual Studio bootstrapper requires administrative privileges. Delegating updates or modification through the Visual Studio Installer UI with the [`AllowStandardUserControl` policy](configure-policies-for-enterprise-deployments.md) doesn't grant permission to run the bootstrapper as a standard user.

### Acquire and maintain layouts

A layout is a cache of installation content that you can use for initial deployment and subsequent updates. Choose this route when clients need an internal source or have limited internet access.

- [Create and maintain a network layout](create-a-network-installation-of-visual-studio.md).
- [Configure installation defaults with a response file](automated-installation-with-response-file.md).
- [Install the certificates required for offline installation](install-certificates-for-visual-studio-offline.md).
- [Maintain your layout](create-a-network-installation-of-visual-studio.md#maintaining-your-layout) before deploying updates to clients.

### Configure permitted self-service

Before rollout, [configure standard-user control](configure-policies-for-enterprise-deployments.md) if your organization permits manual Installer actions. Confirm the required Installer version and read/execute access to approved content. Keep write access restricted to administrators. Enabling administrator updates is a separate policy decision.

### Deploy to developer machines

- [Choose workloads and components](workload-and-component-ids.md) and reuse or export a reviewed [installation configuration](import-export-installation-configurations.md) for each team.
- [Deploy a layout onto client machines](deploy-a-layout-onto-a-client-machine.md) using the team's *.vsconfig* file.
- [Install Visual Studio](install-visual-studio.md) for the individual installation experience.
- [Use command-line parameters](use-command-line-parameters-to-install-visual-studio.md) and [command-line examples](command-line-parameter-examples.md) for elevated deployment automation.
- [Install Visual Studio Build Tools into containers](build-tools-container.md) for containerized build environments.

### Manage updates

Plan who initiates updates and where each client gets its update content. Keep approved content up to date with security fixes. A deployment approval process isn't a reason to skip security updates.

- [Review the client update experience and update settings](update-visual-studio.md).
- [Deploy and verify administrator updates](applying-administrator-updates.md) for the complete Intune or Configuration Manager workflow, from client preparation through rollout.
- [Update clients installed from a layout](update-a-network-installation-of-visual-studio.md).

Deploying an application through Intune and receiving Visual Studio administrator updates through Windows Update are different operations. Use the administrator-update guidance to check enrollment, policies, and access to update content.

### Inventory and verify

- [Detect and manage Visual Studio instances](tools-for-managing-visual-studio-instances.md) to identify installed versions and components.
- [Import or export installation configurations](import-export-installation-configurations.md) to compare the selected installation configuration with your approved configuration.
- [Disable or move the package cache](disable-or-move-the-package-cache.md) by using the documented cache-management guidance.

### Repair and troubleshoot

- [Troubleshoot installation and upgrade issues ↗](/troubleshoot/developer/visualstudio/installation/troubleshoot-installation-issues).
- [Troubleshoot network errors](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md#troubleshoot-network-related-errors), including access to the layout for the account performing the operation.
- [Repair Visual Studio](repair-visual-studio.md).
- [Uninstall Visual Studio](uninstall-visual-studio.md).

## Govern extensions

Use the canonical article for the specific extension task:

- [Configure extension and update options ↗](../ide/configure-extension-update-options.md).
- [Find, install, and manage extensions ↗](../ide/finding-and-using-visual-studio-extensions.md).
- [Use a private gallery ↗](../extensibility/private-galleries.md).

The Private Marketplace is in preview and scoped to extension acquisition. It doesn't provide comprehensive extension governance: installation enforcement, provenance, inventory or audit, runtime loading or integrity, and status are separate concerns. Don't infer that Marketplace policies cover extensions installed through MSI or EXE packages, or sideloaded VSIX files. The existing private-gallery and Extension Manager articles describe specific sources and settings, not universal controls across those routes.

## Govern AI

AI access and administration depend on the product and provider. GitHub Copilot, local models configured with a bring-your-own-key (BYOK) provider, and Microsoft 365 Copilot aren't interchangeable. Shared editor or chat experiences don't imply the same capabilities or policy controls.

- [Admin controls for GitHub Copilot ↗](../ide/visual-studio-github-copilot-admin.md) documents GitHub Copilot-specific controls.
- [Deploy GitHub Copilot to existing Visual Studio instances ↗](../ide/deploy-copilot-to-enterprise.md) documents its deployment prerequisites.
- [Configure AI models and BYOK ↗](../ide/copilot-select-add-models.md). The article identifies BYOK as a preview and describes its current provider and capability limits; don't treat it as equivalent to GitHub Copilot organization policies.

This guide doesn't define Microsoft 365 Copilot administration or a shared policy surface across these AI paths. Use the canonical administration guidance for each product and verify feature status before describing planned controls as available.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Reference and related content

- [Command-line parameters](use-command-line-parameters-to-install-visual-studio.md)
- [Command-line examples](command-line-parameter-examples.md)
- [Workload and component IDs](workload-and-component-ids.md)
- [Configure Visual Studio policies](configure-policies-for-enterprise-deployments.md)
- [Synchronous extension autoload settings ↗](../extensibility/synchronously-autoloaded-extensions.md)
- [Create custom bootstrapper packages for application prerequisites ↗](../deployment/creating-bootstrapper-packages.md) (application deployment reference, not a recipe for modifying Visual Studio packages)

## See also

- [Golden paths for enterprise deployment](enterprise-deployment-golden-paths.md)
- [Deploy and verify administrator updates](applying-administrator-updates.md)
- [Configure Visual Studio policies](configure-policies-for-enterprise-deployments.md)
