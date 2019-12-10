---
title: "Install and use Visual Studio for Mac behind a firewall or proxy server"
description: "This document provides a list of hosts that must be allowed in your firewall to allow Visual Studio for Mac (and its workloads, including Xamarin) to work in a corporate environment."
ms.topic: troubleshooting
ms.assetid: 79C0F1A3-0C13-4E55-A820-1138A4082B77
author: heiligerdankgesang
ms.author: dominicn
ms.date: 09/18/2019
---

# Install and use Visual Studio for Mac behind a firewall or proxy server

If you or your organization uses security measures such as a firewall or a proxy server, then there are domains that you might want to add to an "allow list" and ports and protocols that you might want to open so that you have the best experience when you install and use Visual Studio for Mac and Azure Services.

- [**Install Visual Studio for Mac**](#install-visual-studio-for-mac): These tables include the domains that must allow connectivity so that you have access to all features and workloads of Visual Studio for Mac.

- [**Use Visual Studio for Mac**](#use-visual-studio-for-mac): These tables include domains that must allow connectivity so that you have access to the related features.

## Install Visual Studio for Mac

Because the Visual Studio for Mac Installer downloads from a various domains and download servers, here are the domains and URLs that you may want to add as trusted in your configurations.

### Microsoft domains

| Domain| Purpose |
| ----------------------------------- |---------------------------|
| *.live.com| Credential Management |
| app.vssps.visualstudio.com| Installer Metadata|
| vortex.data.microsoft.com | Crash and Error Reporting |
| az667904.vo.msecnd.net| Crash and Error Reporting |
| xamarin.com | Installer Metadata|
| xampubdl.blob.core.windows.net| Installer Packages|
| download.visualstudio.microsoft.com | Installer Packages|
| xamarin.azureedge.net | Installer Packages|
| developer.xamarin.com | Installer Packages|
| static.xamarin.com | Installer Packages|
| dl.xamarin.com | Installer Packages|
| dc.services.visualstudio.com| Crash Reporting |

### Third party domains

| Domain| Purpose |
| --------------------------|-------------------------|
| dl.google.com | Android SDK |
| download.oracle.com | Java SDK|
| api.apple-cloudkit.com| Apple Security Services |

## Use Visual Studio for Mac

To make sure that you have access to every feature that you need in Visual Studio for Mac while behind a proxy or firewall, we recommend adding the following domains and ports to the allowed-access list.

### General

| Domain | Port(s)|Purpose|
| ----------------------|------------------|------------------|
| go.microsoft.com | 80/443|Microsoft URL Resolution |
| vsstartpage.blob.core.windows.net| 80/443| Start Page Data|
| software.xamarin.com |  80/443|Updater Service|
| addins.monodevelop.com | 80/443| Extension Services |
| visualstudio-devdiv-c2s.msedge.net | 80/443| Experimental Feature and Notifications |
| targetednotifications.azurewebsites.net|  80/443| Used to filter a global list of notifications to a list that is applicable only to specific types of machines/usage scenarios|

### Identity

| Domain | Port(s)|Purpose|
| ----------------------|------------------|------------------|
| login.microsoftonline.com | 80/443| Identity Provider|
| secure.aadcdn.microsoftonline-p.com | 80/443|Identity Provider|
| dc.services.visualstudio.com| 80/443|Crash Reporting|
| management.azure.com|80/443| Azure Services API |

### NuGet

| Domain | Port(s)|Purpose|
| ----------------------|------------------|------------------|
| api.nuget.org | 80/443|NuGet API|
| secure.aadcdn.microsoftonline-p.com |80/443| Identity Provider|

### Android projects

| Domain| Purpose|
| ------------------------------------|------------------------------------|
| time.android.com| Time Server for Android Emulator |
| connectivitycheck.gstatic.com | Connectivity for Android Emulator|
| cloudconfig.googleapis.com| APIs for Android Emulator|

## See also

- [Install and use Visual Studio and Azure Services behind a firewall or proxy server](/visualstudio/install/install-and-use-visual-studio-behind-a-firewall-or-proxy-server)
- [Troubleshoot similar issues on Windows](/visualstudio/install/troubleshooting-network-related-errors-in-visual-studio)
