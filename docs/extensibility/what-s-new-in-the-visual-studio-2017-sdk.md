---
title: "What&#39;s New in the Visual Studio 2017 SDK | Microsoft Docs"
ms.custom: ""
ms.date: "10/31/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9efcf0a3-dbde-4cab-8ed3-425826a48b2e
caps.latest.revision: 1
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
---
# What&#39;s 在 Visual Studio 2017 SDK 中有什麼新功能

The Visual Studio SDK has the following new and updated features for Visual Studio 2017.

## VSIX 提升到 v3 的格式

為了支援 Visual Studio 2017 全新的輕量化安裝程式，VSIX 擴充清單格式已經提升到版本 3 (VSIX v3).

這個全新的 v3 格式支援如下:

* 在透過 VSIXInstaller 安裝 VSIX 封裝時，它對自動明確的偵測此 VSXI 安裝包需要那些先決條件 (prerequisites).
* 開始支援在 VSIX 安裝包理將 Assembly 註冊到 Ngenn.
* 允許將 VSIX 安裝包裡面的資產安裝在 Extension folder 以外的地方

想要對這些修改有更多的了解，請參閱以下主題：:

* [Changes to extensibility for 2017](breaking-changes-2017.md)
* [Ngen support in VSIX v3](ngen-support.md)
* [Installing outside the extensions folder](set-install-root.md)
* [Frequently Asked Questions for Visual Studio 2017 extensibility](faq-2017.md)

## 將 .NET 擴充性專案移轉到 Visual Studio 2017 的版本

如果您想要了解如何將您的擴充性專案以及相關的項目及其 VSIX 擴充清單更新到 Visual Studio 2017 的格式，, 可參考： [How to: Migrate Extensibility Projects to Visual Studio 2017](how-to-migrate-extensibility-projects-to-visual-studio-2017.md).

## 自訂 Visual Studio 的專案與專案項目

從 Visual Studio 2017 開始，不會在自動的掃瞄掃描 VSIX 內的自定義樣板與項目. 反而是, 該擴充套件必須提自行提供描述這些樣板安裝的位置，與的樣板清單描述文件(Menifest)。 您可以使用 Visual Studio 2017 來升級您的 VSIX 擴充套件. 如果您要使用 MSI 封裝檔來部署您的擴充套件, 您必須自己手動生成樣板清單描述文件(Menifest)。. 要取得更多資訊, 可參考 [Upgrading Custom Project and Item Templates for Visual Studio 2017](../extensibility/upgrading-custom-project-and-item-templates-for-visual-studio-2017.md). 這個樣板相關的描述定義說明文件在 [Visual Studio Template Manifest Schema Reference](../extensibility/visual-studio-template-manifest-schema-reference.md).

## 更新的擴充套件效能指南

There is a new [How to: Diagnose extension performance](how-to-diagnose-extension-performance.md) topic under [Managing VSPackages](managing-vspackages.md) 以顯示如何偵測與分析當 Visual Studio 啟動和載入方案時時間其擴充套件對效能產生的影響.
