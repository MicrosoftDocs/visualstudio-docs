---
title: Publish multiple VSIX payloads in one Marketplace entry
description: Publish and maintain VSIX packages for different Visual Studio API versions and architectures under one Marketplace entry.
ms.date: 10/15/2026
ms.topic: how-to
author: murphymcquet-msft
ms.author: murphymcquet
ms.subservice: extensibility-integration
monikerRange: "visualstudio"
---

# Publish multiple VSIX payloads in one Marketplace entry

You can publish separate `.vsix` packages, or *payloads*, under one Visual Studio Marketplace entry. Use multiple payloads when your extension needs different builds for different Visual Studio API versions or processor architectures. Customers discover the same extension, and Visual Studio requests a compatible payload.

This article describes API-version-based publishing for Visual Studio 2026 version 18.12 and later. It applies to VSIX packages, not MSI installers, executable installers, or referral links.

## Prerequisites

- A Marketplace publisher account with permission to publish and manage the extension.
- A tested `.vsix` package for each API version and architecture you support.
- The same VSIX ID in every payload, and the same publisher and Marketplace internal name for every upload.
- For payloads targeting API version 18.x, current VSSDK build tools that generate the required `TargetSdk` metadata in `catalog.json`.

To create the packages, see [Create an extension with the Modern VSIX Project template](create-vsix-with-project-sdk.md). Test each package in its supported Visual Studio configurations before publishing.

## Plan payload identities and versions

Keep the following values distinct:

| Value | Purpose |
|-------|---------|
| Marketplace publisher and internal name | Identify the single Marketplace entry, such as `MyPublisherName.MyExtension`. |
| VSIX ID | Identifies the installed extension and its updates. Keep this value unchanged across payloads. |
| Extension version | Identifies a release of your extension, such as `1.0.0`. This isn't a Visual Studio API version. |
| Minimum supported Visual Studio API version | Declares the oldest API version that the payload requires, such as `17.14` or `18.12`. |
| Visual Studio edition and architecture | Identify the editions and processor architectures supported by the payload. |

Marketplace validates version progression for each combination of edition, minimum API version, and architecture. Use the usual inclusive minimum in your installation targets. A new payload for an existing target must have a higher extension version than the payload already published for that target.

For example, you can publish these three packages under one entry:

| Package | Extension version | Minimum API version | Architecture |
|---------|-------------------|---------------------|--------------|
| `MyExtension-vs17-amd64.vsix` | `1.0.0` | `17.14` | `amd64` |
| `MyExtension-vs18-amd64.vsix` | `1.0.0` | `18.12` | `amd64` |
| `MyExtension-vs18-arm64.vsix` | `1.0.0` | `18.12` | `arm64` |

Assume each package declares the editions you support. The filenames help you organize the packages locally; changing a filename doesn't create a different installation target.

To service the `18.12` `amd64` target, publish a new package with version `1.0.1` for that target. You don't need to republish the `17.14` or `arm64` packages. The same extension version can be used for different targets, but it can't replace an already-published version for the same target.

### Check the built package metadata

Inspect the generated package, not just the project settings:

- Verify the VSIX ID, extension version, and installation targets in `extension.vsixmanifest`.
- Set the minimum API version to the oldest version whose APIs the payload actually uses.
- Verify the product architecture for every installation target. For example, the manifest value for an x64 Visual Studio installation is `amd64`.
- Verify that the package includes its generated SDK metadata and declares its prerequisites.

Changing only the upper bound of an installation target doesn't create a new API-version target. Under the API-version compatibility model, don't use upper bounds to keep an older payload from competing with a newer payload. See [Extension compatibility](../how-it-works/models/vssdk-and-compatibility.md#extension-compatibility-model).

## How Visual Studio selects a payload

For API-version-based selection, Visual Studio requests payloads compatible with its supported API version, edition, and architecture. Among matching targets with validated payloads, the highest supported minimum API version takes precedence. For that target, the highest validated extension version is selected.

For the packages in the preceding example, assuming their other prerequisites are satisfied:

| Customer configuration | Selected package |
|------------------------|------------------|
| Visual Studio with API version `17.14`, `amd64` | `MyExtension-vs17-amd64.vsix` |
| Visual Studio with API version `18.11`, `amd64` | `MyExtension-vs17-amd64.vsix` |
| Visual Studio with API version `18.12`, `amd64` | `MyExtension-vs18-amd64.vsix` |
| Visual Studio with API version `18.12`, `arm64` | `MyExtension-vs18-arm64.vsix` |

Customers on an older API version can continue to receive their compatible payload even after you publish a payload that uses newer APIs. Publishing a new payload doesn't add those newer APIs to older Visual Studio installations.

> [!IMPORTANT]
> Test acquisition and updates from each Visual Studio version you support. Earlier clients can use extension-version-first selection rather than the API-version-first selection described here, so don't assume that every client chooses between compatible payloads in the same order.

## Publish the payloads

Choose either workflow:

- [Upload packages in the Marketplace publisher portal](publish-to-marketplace.md#update-a-published-extension).
- [Publish each package with VsixPublisher.exe](publish-via-command-line.md#publish-multiple-vsix-payloads).

Create the entry with the first package, then upload the remaining packages to that entry. Don't create a new Marketplace entry for each API version or architecture.

An existing VSIX entry can transition to multiple payloads when you add a package for a different supported target. Keep its Marketplace identity and VSIX ID. This doesn't merge separate Marketplace entries that you've already published.

After every upload, review validation status and verify that all intended targets are still represented. A successful upload alone doesn't establish that customers can install and run every payload.

## Update or replace a payload

To change the binary for an existing target:

1. Keep the VSIX ID and Marketplace identity unchanged.
1. Increment the extension version for that target.
1. Rebuild and test the package.
1. Upload it to the existing Marketplace entry by using either publishing workflow.
1. Verify installation and updates for that target, and confirm that the other targets still receive their intended packages.

Published payloads aren't edited in place. Don't delete a version and re-upload different bytes with the same version as a replacement strategy. Publish a higher version, including when you need to restore a previously working implementation.

Marketplace listing metadata and payload compatibility aren't interchangeable. For example, editing the overview doesn't change the APIs used by a package. To change VSIX-supplied version or installation-target metadata, rebuild and publish the package.

## Remove published packages

Use the publisher portal to [delete an eligible version](publish-to-marketplace.md#deleting-versions).

The version-level **Delete** action removes all packages with that extension version. It doesn't remove just one architecture or API-version payload within the version. Review the expanded package list before confirming.

> [!WARNING]
> A version that isn't the entry's newest version can still be the only compatible release for some customers. Removing it can remove support for those customers. Publish and verify a replacement before removing a version they need.

The portal protects the latest version and doesn't allow you to remove the only remaining version. If you need to stop distributing one target while retaining other packages at the same extension version, the version-level delete action isn't a selective removal mechanism.

`VsixPublisher.exe deleteExtension` deletes the entire Marketplace entry. It doesn't delete one version or payload.

## Troubleshoot publishing

| Symptom | What to check |
|---------|---------------|
| An upload reuses an existing version for the same target | Increment the extension version. Changing the filename or only the installation target's upper bound isn't enough. |
| The version must be higher than an existing version | Compare against the latest published version for every target declared by the new package. A package can declare more than one target. |
| Marketplace reports a different VSIX ID | Use the existing entry's VSIX ID in every payload. Don't generate a new ID for each build. |
| An API 18.x package is missing SDK metadata | Rebuild with current VSSDK build tools and verify the generated `TargetSdk` metadata in `catalog.json`. Don't fix this by lowering the declared API requirement. |
| The package requires an API version that isn't accepted for publishing | Use a supported stable API version. Preview API access during development doesn't by itself grant permission to publish that package. |
| The publisher portal doesn't show **Add version**, or rejects a minor-version target | Confirm that the API-version-based publishing experience is available for the entry. Earlier publishing behavior has different targeting restrictions. |
| **Add version** is disabled after editing listing metadata | Save or revert the metadata changes before adding a package. |
| A customer gets a different payload than expected | Check the client's API version, architecture, edition, package prerequisites, and payload versions. Test in the actual client, not only by downloading from the website. |
| **Delete** isn't available for a version | Check whether it's the latest or only remaining version. Don't delete the entire entry to work around version deletion restrictions. |

## Related content

- [Publish an extension to the Marketplace](publish-to-marketplace.md)
- [Publish an extension via command line](publish-via-command-line.md)
- [Create an extension with the Modern VSIX Project template](create-vsix-with-project-sdk.md)
- [VSSDK users and extension compatibility](../how-it-works/models/vssdk-and-compatibility.md)
