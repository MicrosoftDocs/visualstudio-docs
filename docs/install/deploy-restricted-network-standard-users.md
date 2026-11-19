---
title: Deploy Visual Studio to restricted-network workstations for standard users
description: Deploy Visual Studio from an approved layout to restricted-network workstations with standard-user developers.
ms.date: 11/18/2026
ms.topic: how-to
author: madskristensen
ms.author: madsk
ms.subservice: installation
monikerRange: ">=vs-2022"
ms.custom: awp-ai
ai-usage: ai-assisted
---
# Deploy restricted-network Visual Studio workstations for standard users

Use this path when developer workstations have restricted internet access, developers don't have administrator permissions, and IT provides an approved Visual Studio layout. IT performs the initial installation and maintains the installation content. Your organization then chooses whether IT or developers initiate subsequent servicing.

For example, a security-conscious financial-services organization supports thousands of developers with different workload needs. IT wants one complete product source, role-specific initial installations, and an explicit choice about self-service. This [golden path](enterprise-deployment-golden-paths.md) walks through that scenario without claiming that a layout alone satisfies compliance requirements.

The recommended flow is **prepare the full layout > configure permitted self-service > capture each team's configuration and install > keep installations current**. A full layout makes product content available; it doesn't mean every developer installs every workload. This path uses an elevated IT process for initial deployment and an explicit policy decision for subsequent developer actions. Linked task articles provide additional parameters and version-specific requirements.

## When to use a different path

If a client can't access an internal layout, use the [fully offline golden path](deploy-fully-offline-workstations.md) and your approved content-transfer process. For Azure VM images or containerized Build Tools, see [other environments](enterprise-deployment-golden-paths.md#other-environments).

Installing Visual Studio doesn't make every developer service available offline. Review the [firewall and proxy guidance](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md) for the services your developers need.

## Prerequisites

- Target workstations meet the system requirements for the Visual Studio version and edition you select.
- An administrator has access to a connected machine to acquire and maintain the layout, and to an elevated process for the initial client installation.
- Your organization has approved the edition, languages, workloads, license entitlements, and content-transfer or distribution process.
- The account that runs the installation or update can read the layout. Check the account used by your deployment tool; don't rely on an administrator's interactive access as evidence that a system-context process can access the share.
- Offline clients have the [certificates required to verify installation content](install-certificates-for-visual-studio-offline.md).
- If you delegate manual servicing, the client has the latest Visual Studio Installer required by the [standard-user policy](configure-policies-for-enterprise-deployments.md).

> [!IMPORTANT]
> Both bootstrapper-based deployment and subsequent servicing use the Visual Studio Installer. If application-control rules prevent the Installer from running, obtain security approval for the supported workflow before piloting. A layout or a *.vsconfig* file doesn't bypass that restriction.

### System requirements

::: moniker range="=visualstudio"

Check the [Visual Studio system requirements ↗](/visualstudio/releases/2026/vs-system-requirements).

::: moniker-end

::: moniker range="=vs-2022"

Check the [Visual Studio 2022 system requirements ↗](/visualstudio/releases/2022/system-requirements).

::: moniker-end

## 1. Create and verify the layout

On the acquisition machine, follow [Create and maintain a network installation](create-a-network-installation-of-visual-studio.md). Start with a full layout, which makes the complete product content available from the approved source. Use the bootstrapper for your selected edition and version. Acquire the approved workloads, components, dependencies, and languages. Use a partial layout only when the scenario intentionally limits available content and the requested installation is covered by that content.

For example, in an elevated Command Prompt, acquire all product workloads and components for English and verify the source:

```shell
vs_enterprise.exe --layout C:\VSLayout --lang en-US
vs_enterprise.exe --layout C:\VSLayout --verify
```

Add any other languages your organization needs. Creating a layout downloads installation content; it doesn't install Visual Studio. Review the content through your organization's security and compliance process before publishing it. Host the verified content on an approved file share, allow clients to read and execute it through both share and NTFS permissions, and restrict write access to administrators. Prepare a distribution plan for your workstation count and locations; a single pilot doesn't establish capacity for thousands of concurrent installations.

> [!TIP]
> If the acquisition machine uses a proxy, review the [installation endpoint allow list and network guidance](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md). Validate access as the account that acquires content. Don't assume that a developer's IDE proxy settings apply to the Installer or a system-context process.

Before distributing content to the client environment, use the layout article's verification guidance. Follow [Automate installation with a response file](automated-installation-with-response-file.md) to configure initial installation defaults and the intended update source.

If you use a partial layout, confirm that it includes every component the installation requests. When a requested component isn't in the layout, the installer can attempt to acquire it from Microsoft-hosted servers.

**Expected result:** The verified layout contains the approved content, and its installation defaults identify the intended source.

## 2. Choose who can initiate servicing

Decide who can initiate self-service before you deploy to developers. Keep servicing IT-controlled if your organization doesn't permit developers to initiate updates. Use the elevated command-line guidance or, when its prerequisites are met, [Deploy and verify administrator updates](applying-administrator-updates.md).

If your organization permits manual developer servicing, configure [`AllowStandardUserControl`](configure-policies-for-enterprise-deployments.md) through your approved policy-delivery mechanism:

- Value `1` permits manual updates and rollback through the Installer UI.
- Value `2` permits all manual Installer UI functionality, including **Modify** and **Install** from the **Available** tab. Use it only if your organization approves that broader control.

Check the canonical policy reference for all allowed operations and the latest Installer requirement. Neither value permits standard users to run unattended `--quiet` or `--passive` operations, or to run the bootstrapper. If you allow modification, supply the approved components in the layout so that a user doesn't request unavailable content.

If IT needs to prepare the Installer before installing the product, the documented [`--installerOnly` parameter](use-command-line-parameters-to-install-visual-studio.md) installs the Installer without installing Visual Studio. Run that bootstrapper preparation with administrative privileges. It isn't necessary as a separate step when IT installs the product through the elevated process later in this path.

For the scenario where developers need to add workloads themselves, IT must explicitly approve value `2`. After deployment, developers open the installed **Visual Studio Installer**, select the intended instance, and use **Modify**. Test this action without supplying an administrator password. The policy delegates Installer operations; it doesn't grant general Windows elevation. Value `2` is broader than modification, so use value `1` or retain IT servicing if that broader control isn't acceptable.

**Expected result:** IT selects and delivers the intended policy. After installation, IT verifies the permitted manual action by using a standard-user account on a pilot workstation.

## 3. Define the approved configuration

Select [workloads and components](workload-and-component-ids.md) and use a scenario-specific [installation configuration file](import-export-installation-configurations.md) to describe the intended installation. A *.vsconfig* file records configuration; it doesn't enforce organizational policy. Include any recommended or optional components that your developers need. The file doesn't specify product UI languages; select those with `--addProductLang` when you install.

For example, an initial configuration for a .NET desktop team can contain:

```json
{
  "version": "1.0",
  "components": [
    "Microsoft.VisualStudio.Workload.ManagedDesktop"
  ]
}
```

Reuse a project-tested configuration if your team already maintains one. Otherwise, review and export configurations from representative installations rather than assuming that this small example covers every team. Keep role-specific files separate from the full source. Using `--config` during layout creation limits the layout content instead of merely selecting each client's installation.

Choose the installation edition and arrange [product-key deployment](automatically-apply-product-keys-when-deploying-visual-studio.md) if your licensing model requires it. Record the update source and who is responsible for acquiring, validating, and distributing each update.

**Expected result:** IT has an approved configuration and an owner for the layout and client servicing.

## 4. Prepare client access and trust

Follow the client preparation guidance in [Deploy a layout onto a client machine](deploy-a-layout-onto-a-client-machine.md). Confirm access to the share for the account that runs the deployment.

For offline clients, follow [Install certificates required for offline installation](install-certificates-for-visual-studio-offline.md). Use the documented trust preparation process; don't alter or re-sign Microsoft installation packages.

If separate teams package and deploy the application, use the [managed packaging golden path](package-visual-studio-for-enterprise-deployment.md) to agree on content, commands, execution accounts, detection, and return-code handling before rollout.

**Expected result:** The deployment account can access the layout and the client can verify the signed installation content.

## 5. Perform the elevated initial deployment

Use the documented instructions in [Deploy from a network layout](deploy-a-layout-onto-a-client-machine.md#install-from-a-network-layout) through your elevated IT deployment process. That article documents the `--noWeb` option for preventing installation from acquiring product packages from the internet. Use its guidance when clients must install only from layout content.

For example, after staging the role-specific configuration on a client, run this command in an elevated Command Prompt:

```shell
\\server\VSLayout\vs_enterprise.exe --config "C:\VSConfig\Desktop.vsconfig" --addProductLang en-US --noWeb --passive --wait --norestart
```

Replace the paths with your approved locations, and pass each required product UI language with `--addProductLang`; the layout must contain those languages. Review the layout's `response.json` before deployment: configure its `channelUri` for the intended internal update source rather than retaining a Microsoft-hosted default. Bootstrapper defaults aren't a machine-wide policy, and the installed Installer doesn't reread that response file for every action.

This path uses a file-share layout. The documented `--noWeb` option doesn't work with intranet web-hosted layouts and fails if selected content is missing. Check [client preparation for offline installation](deploy-a-layout-onto-a-client-machine.md#install-on-a-client-that-doesnt-have-internet-access) before deployment.

Wait for both the Installer and the product installation to finish, and inspect the documented [command-line completion and error codes](use-command-line-parameters-to-install-visual-studio.md) before treating the deployment as successful.

> [!IMPORTANT]
> Developers remaining standard users isn't a standard-user bootstrapper installation scenario. IT must supply the administrative privileges for this step. The standard-user policy selected earlier doesn't replace this requirement.

**Expected result:** The intended Visual Studio instance and Installer are installed, and IT has recorded the installation result.

## 6. Verify the pilot installation

Before expanding deployment:

1. Use [tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md) to confirm the instance, version, installation path, and required components.
1. Compare the selected installation configuration with the approved configuration by using [installation configuration guidance](import-export-installation-configurations.md).
1. Review [client update settings](update-visual-studio.md) and confirm the intended layout is the update source.
1. Confirm that the account responsible for the next update can still access the layout.
1. If you delegated manual servicing, test the approved action in the Installer UI as a standard user. Otherwise, verify your elevated IT servicing process.

**Expected result:** The pilot has the approved configuration, a verified update source, and a servicing process that works with the intended account and permissions.

## 7. Prepare and deploy the next update

Choose how to supply the update content without rebuilding and redistributing the entire product for every servicing event:

| Update path | What IT does | Who initiates the client operation |
|---|---|---|
| Update the existing complete source (recommended) | [Maintain the full layout](create-a-network-installation-of-visual-studio.md#maintaining-your-layout), then [update layout-based clients](update-a-network-installation-of-visual-studio.md). | IT, or a developer using the installed Installer UI if policy explicitly permits the action. |
| Optional: transfer a smaller update source to a bandwidth-constrained or disconnected segment | [Generate, verify, and apply a minimal offline layout](update-minimal-layout.md) for the clients' base versions and configurations. | An elevated IT process; don't treat its bootstrapper commands as standard-user self-service. |

Keep the full layout current for new installations, modifications, and recovery. Verify the resulting instance version and configuration again, and confirm the next update source still matches your plan. Changing an existing instance's update source doesn't apply the update, and changing the original layout's `response.json` doesn't redirect existing instances.

If you use administrator updates, follow [Deploy and verify administrator updates](applying-administrator-updates.md). The workflow includes client enrollment, content-source preparation, and rollout. Deploying the original application through Intune doesn't itself enable Windows Update administrator-update delivery.

Plan timely security servicing and keep the approved source current.

## Troubleshoot the path

| Symptom | Check first | Documented recovery |
|---|---|---|
| The installation or update can't read the share | Access as the account actually running the operation, not just the signed-in administrator | [Troubleshoot network errors](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md#check-access-to-an-internal-layout) |
| A requested workload or component isn't available offline | The layout contents and installation configuration | [Create and maintain layouts](create-a-network-installation-of-visual-studio.md) and [deploy from a layout](deploy-a-layout-onto-a-client-machine.md) |
| Installation content fails trust verification | Required root and intermediate certificates on the client | [Offline certificate preparation](install-certificates-for-visual-studio-offline.md) |
| A standard user can't perform the intended action | Effective policy, Installer version, whether the action is manual UI or unattended, and source access | [Visual Studio policy reference](configure-policies-for-enterprise-deployments.md) |
| No expected update is available | Client update source and whether the layout contains the update | [Update a layout-based client](update-a-network-installation-of-visual-studio.md) |
| An update is blocked or fails | Whether Visual Studio is in use, completion status, and installation logs | [Apply administrator updates](applying-administrator-updates.md) and [troubleshoot installation issues ↗](/troubleshoot/developer/visualstudio/installation/troubleshoot-installation-issues) |

Use [Repair Visual Studio](repair-visual-studio.md) when the documented diagnosis calls for repair. Verify that required installation content remains accessible.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

- [Golden paths for enterprise deployment](enterprise-deployment-golden-paths.md)
- [Enterprise management task hub](visual-studio-administrator-guide.md)
- [Deploy and verify administrator updates](applying-administrator-updates.md)
- [Command-line parameter examples](command-line-parameter-examples.md)
- [Configure Visual Studio policies](configure-policies-for-enterprise-deployments.md)
