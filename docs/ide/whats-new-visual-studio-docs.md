---
title: "Visual Studio docs: What's new for May 2021"
titleSuffix: ""
description: "What's new in the Visual Studio docs for May 2021."
ms.date: 06/01/2021
helpviewer_keywords:
  - "Visual Studio, what's new, docs"
  - "what's new [Visual Studio]"
ms.assetid: 89844796-621B-4EF5-9D76-197084B011CB
author: JoshuaPartlow
ms.author: joshuapa
manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.topic: conceptual
ms.workload:
  - "multiple"
---

# Visual Studio docs: What's new for May 2021

Welcome to what's new in the Visual Studio docs for May 2021. This article lists some of the major changes to docs during this period. For information about what was new in previous months, see the [what's new history](#whats-new-history) section.

## Code quality

**New articles**

- [Code metrics - Cyclomatic complexity](../code-quality/code-metrics-cyclomatic-complexity.md) - Code metrics updates for cyclomatic complexity and depth of inheritance
- [Code metrics - Depth of inheritance (DIT)](../code-quality/code-metrics-depth-of-inheritance.md) - Code metrics updates for cyclomatic complexity and depth of inheritance
- [Code analysis FAQ](../code-quality/analyzers-faq.yml) - FAQ.md converted into yml
- [Frequently asked questions about legacy FxCop and .NET analyzers](../code-quality/net-analyzers-faq.yml) - FAQ.md converted into yml

**Updated articles**

- [Suppress code analysis violations](../code-quality/in-source-suppression-overview.md) - Refactoring docs on suppression of CA rules

## Containers

**New articles**

- [Manage launch profiles for Docker Compose (Preview)](../containers/launch-profiles.md) - Container Tools - launch settings

## Debugger

**New articles**

- [Frequently Asked Questions for snapshot debugging in Visual Studio](../debugger/debug-live-azure-apps-faq.yml) - FAQ.md converted into yml
- [FAQ - Find the debugging feature you need in Visual Studio](../debugger/find-your-debugging-task.yml) - FAQ.md converted into yml

**Updated articles**

- [Troubleshooting data breakpoint errors](../debugger/troubleshoot-data-breakpoint-errors.md) - Update troubleshooting data breakpoint errors doc

## IDE

**Updated articles**

- [/ResetSettings (devenv.exe)](./reference/resetsettings-devenv-exe.md) - More fixes
- [Quickstart: Create your first Node.js app with Visual Studio](./quickstart-nodejs.md) - Suggested edits

## Install

**Updated articles**

- [Update Visual Studio using a minimal offline layout](../install/update-minimal-layout.md)
  - Add multiple products examples to MinLayout docs
  - Reflect removal of of --productId in VS 2017 docs and all examples
  - Reflect removal of '--productIds' option in MinimalLayout docs
- [Modify Visual Studio workloads, components, and language packs](../install/modify-visual-studio.md) - Simplify instructions for performance

## MSBuild

**New articles**

- [MSB8006: The Platform for project 'project-name.vcxproj' is invalid.](../msbuild/errors/msb8006.md) - Update MSB8xxx F1 content
- [MSB8013: This project doesn't contain the Configuration and Platform combination specified.](../msbuild/errors/msb8013.md) - Update MSB8xxx F1 content
- [MSB8027: Two or more files with the name of filename will produce outputs to the same location.](../msbuild/errors/msb8027.md) - Update MSB8xxx F1 content
- [MSB8037: The Windows SDK version for Desktop C++ Apps wasn't found.](../msbuild/errors/msb8037.md) - Update MSB8xxx F1 content
- [MSB8042: ATL or MFC libraries with Spectre Mitigations are required for this project.](../msbuild/errors/msb8042.md) - Update MSB8xxx F1 content
- [MSB3721: The command 'command' exited with code 'error-code'](../msbuild/errors/msb3721.md) - MSBuild error pages
- [MSB3821: Couldn't process file 'path' due to its being in the Internet or Restricted zone or having the mark of the web on the file](../msbuild/errors/msb3821.md) - MSBuild error pages

**Updated articles**

- [MSBuild conditions](../msbuild/msbuild-conditions.md) - MSBuild version comparisons
- [Property functions](../msbuild/property-functions.md) - MSBuild version comparisons

## Python

**Updated articles**

- [Step 2: Create a Django app with views and page templates](../python/learn-django-in-visual-studio-step-02-create-an-app.md) - Separated Visual Studio 2017 and 2019 information
- [Create a C++ extension for Python](../python/working-with-c-cpp-python-in-visual-studio.md) - Article reviewed and updated

## Test

**New articles**

- [Live Unit Testing frequently asked questions](../test/live-unit-testing-faq.yml) - FAQ.md converted into yml

## XAML tools

**New articles**

- [Use design-time sample data with the XAML Designer in Visual Studio](../xaml-tools/xaml-design-time-sample-data.md) - Added XAML Design-time Sample Data Documentation

## Community contributors in May

The following people contributed to the Visual Studio docs during this period. Thank you! Learn how to contribute by following the links under "Get involved" in the [what's new landing page](index.yml).

- [7sharp9](https://github.com/7sharp9) - Dave Thomas (1)
- [heath-hamilton](https://github.com/heath-hamilton) - Heath Hamilton (1)

## What's new history

### April 2021

#### Azure

**Updated articles**

- [Create and deploy to Cloud Services (extended support) in Visual Studio](../azure/cloud-services-extended-support.md) - Cloud Services (extended support) - changes for GA

#### Containers

**New articles**

- [Use managed identity with Bridge to Kubernetes](../containers/managed-identity.md) - Managed Identity for Bridge to Kubernetes

**Updated articles**

- [Docker Compose build properties](../containers/docker-compose-properties.md) - Compose property additions
- [How Visual Studio builds containerized apps](../containers/container-build.md) - Update for LTS

#### Debugger

**New articles**

- [IDiaSymbol::get_framePadOffset](../debugger/debug-interface-access/idiasymbol-get-framepadoffset.md) - DIA SDK additions
- [IDiaSymbol::get_framePadSize](../debugger/debug-interface-access/idiasymbol-get-framepadsize.md) - DIA SDK additions
- [IDiaSymbol::get_isRTCs](../debugger/debug-interface-access/idiasymbol-get-isrtcs.md) - DIA SDK additions
- [How to debug a managed memory dump with .NET Diagnostic Analyzers](../debugger/how-to-debug-managed-memory-dump.md) - Vs memory dump analyzers

**Updated articles**

- [Dump files in the Visual Studio debugger](../debugger/using-dump-files.md) - Vs memory dump analyzers
- [How to debug for absolute beginners](../debugger/debugging-absolute-beginners.md) - Adding VB to beginners guide

#### Get started

**Updated articles**

- [Tutorial: Extend a simple C# console app](../get-started/csharp/tutorial-console-part-2.md) - Clarify steps and add full code to extend sidewalk tutorial

#### IDE

**Updated articles**

- [F1 help: match not found](./not-in-toc/default.md) - Update default.md
- [Developer Command Prompt and Developer PowerShell](./reference/command-prompt-powershell.md) - Content performance improvements
- [Connect to projects in Team Explorer](./connect-team-project.md) - Revise the VS 2019 version of the "Connect to projects in Team Explorer" page

#### Install

**Updated articles**

- [Create an offline installation of Visual Studio](../install/create-an-offline-installation-of-visual-studio.md) - Update use-command-line-parameters-to-install-visual-studio.md
- [Use command-line parameters to install Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md) - Update use-command-line-parameters-to-install-visual-studio.md
- [Set defaults for enterprise deployments of Visual Studio](../install/set-defaults-for-enterprise-deployments.md) - Fix typos related to admin updates and and removed unnecessary caveat from enterprise deployments defaults
- [Visual Studio build numbers and release dates](../install/visual-studio-build-numbers-and-release-dates.md) - add Patch Tuesday updates
- [Applying administrator updates that use Microsoft Endpoint Configuration Manager](../install/applying-administrator-updates.md) - Admin updates
- [Control updates to network-based Visual Studio deployments](../install/controlling-updates-to-visual-studio-deployments.md) - Admin updates
- [Create a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md) - Admin updates
- [Enabling administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager](../install/enabling-administrator-updates.md) - Admin updates
- [Tools for detecting and managing Visual Studio instances](../install/tools-for-managing-visual-studio-instances.md) - Admin updates
- [Update Visual Studio to the most recent release](../install/update-visual-studio.md) - Admin updates
- [Visual Studio administrator guide](../install/visual-studio-administrator-guide.md) - Admin updates
- [Visual Studio enterprise guide](../install/visual-studio-enterprise-guide.md) - Admin updates

#### MSBuild

**New articles**

- [MSB8066:  Custom build for 'item-list' exited with code 'error code'](../msbuild/errors/msb8066.md) - new page draft for msb8066
- [MSB8040: Spectre-mitigated libraries are required for this project](../msbuild/errors/msb8040.md) - MSBuild C++ error messages
- [MSB8041: MFC Libraries are required for this project](../msbuild/errors/msb8041.md) - MSBuild C++ error messages
- [MSB3277: Found conflicts between different versions of 'assembly' that could not be resolved](../msbuild/errors/msb3277.md) - MSBuild error MSB3277

#### Python

**Updated articles**

- [Create a C++ extension for Python](../python/working-with-c-cpp-python-in-visual-studio.md)
  - Small updates to address GH issues
  - Improve working-with-c-cpp-python-in-visual-studio.md

#### SharePoint

**Updated articles**

- [Create an association between entities](../sharepoint/creating-an-association-between-entities.md) - Moving sample files and updating code references (part 1) - 6
- [How to: Add a custom SharePoint node to Server Explorer](../sharepoint/how-to-add-a-custom-sharepoint-node-to-server-explorer.md) - Moving sample files and updating code references (part 1) - 6
- [How to: Retrieve the SharePoint project service](../sharepoint/how-to-retrieve-the-sharepoint-project-service.md) - Moving sample files and updating code references (part 1) - 6
- [Save data in extensions of the SharePoint project system](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md) - Moving sample files and updating code references (part 1) - 6
- [Walkthrough: Create a custom action project item with an item template, part 2](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-2.md) - Moving sample files and updating code references (part 1) - 6
- [Walkthrough: Create a custom deployment step for SharePoint projects](../sharepoint/walkthrough-creating-a-custom-deployment-step-for-sharepoint-projects.md) - Moving sample files and updating code references (part 1) - 6
- [Walkthrough: Create a SharePoint application page](../sharepoint/walkthrough-creating-a-sharepoint-application-page.md) - Moving sample files and updating code references (part 1) - 6
- [Walkthrough: Create a site column project item with a project template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md) - Moving sample files and updating code references (part 1) - 6
- [Walkthrough: Create a web part for SharePoint by using a designer](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint-by-using-a-designer.md) - Moving sample files and updating code references (part 1) - 6
- [Walkthrough: Create a web part for SharePoint](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint.md) - Moving sample files and updating code references (part 1) - 6
- [Walkthrough: Extend Server Explorer to display web parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md) - Moving sample files and updating code references (part 1) - 6

#### Test

**Updated articles**

- [Get started with unit testing](../test/getting-started-with-unit-testing.md) - Adding VB to beginners guide
- [Get started with Live Unit Testing](../test/live-unit-testing-start.md) - Moving sample files and updating code references (part 1) - 7

#### VSTO

**Updated articles**

- [Walkthrough: Display custom task panes with email messages in Outlook](../vsto/walkthrough-displaying-custom-task-panes-with-e-mail-messages-in-outlook.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Import a form region that is designed in Outlook](../vsto/walkthrough-importing-a-form-region-that-is-designed-in-outlook.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Insert data into a workbook on a server](../vsto/walkthrough-inserting-data-into-a-workbook-on-a-server.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Insert text into a document from an actions pane](../vsto/walkthrough-inserting-text-into-a-document-from-an-actions-pane.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Program against events of a NamedRange control](../vsto/walkthrough-programming-against-events-of-a-namedrange-control.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Retrieve cached data from a workbook on a server](../vsto/walkthrough-retrieving-cached-data-from-a-workbook-on-a-server.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Simple data binding in a document-level project](../vsto/walkthrough-simple-data-binding-in-a-document-level-project.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Simple data binding in VSTO Add-in Project](../vsto/walkthrough-simple-data-binding-in-vsto-add-in-project.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Synchronize a custom task pane with a Ribbon button](../vsto/walkthrough-synchronizing-a-custom-task-pane-with-a-ribbon-button.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Update a chart in a document using radio buttons](../vsto/walkthrough-updating-a-chart-in-a-document-using-radio-buttons.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Updating a Chart in a Worksheet Using Radio Buttons](../vsto/walkthrough-updating-a-chart-in-a-worksheet-using-radio-buttons.md) - Moving sample files and updating code references (part 1) - 11
- [Walkthrough: Update the controls on a ribbon at run time](../vsto/walkthrough-updating-the-controls-on-a-ribbon-at-run-time.md) - Moving sample files and updating code references (part 1) - 11
- [Troubleshoot errors in Office solutions](../vsto/troubleshooting-errors-in-office-solutions.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Add controls to a document at run time in a VSTO Add-in](../vsto/walkthrough-adding-controls-to-a-document-at-run-time-in-a-vsto-add-in.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Add controls to a worksheet at run time in VSTO add-in project](../vsto/walkthrough-adding-controls-to-a-worksheet-at-run-time-in-vsto-add-in-project.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Automate an application from a custom task pane](../vsto/walkthrough-automating-an-application-from-a-custom-task-pane.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Bind content controls to custom XML parts](../vsto/walkthrough-binding-content-controls-to-custom-xml-parts.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Bind data to controls on a Word actions pane](../vsto/walkthrough-binding-data-to-controls-on-a-word-actions-pane.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Bind data to controls on an Excel actions pane](../vsto/walkthrough-binding-data-to-controls-on-an-excel-actions-pane.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Bind to data from a service in a VSTO Add-in project](../vsto/walkthrough-binding-to-data-from-a-service-in-a-vsto-add-in-project.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Call code in a VSTO Add-in from VBA](../vsto/walkthrough-calling-code-in-a-vsto-add-in-from-vba.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Change cached data in a workbook on a server](../vsto/walkthrough-changing-cached-data-in-a-workbook-on-a-server.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Change document formatting using CheckBox controls](../vsto/walkthrough-changing-document-formatting-using-checkbox-controls.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Change worksheet formatting using CheckBox controls](../vsto/walkthrough-changing-worksheet-formatting-using-checkbox-controls.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Collect data by using a Windows Form](../vsto/walkthrough-collecting-data-using-a-windows-form.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Complex data binding in a document-level project](../vsto/walkthrough-complex-data-binding-in-a-document-level-project.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Complex data binding in VSTO Add-in project](../vsto/walkthrough-complex-data-binding-in-vsto-add-in-project.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Create a custom tab by using Ribbon XML](../vsto/walkthrough-creating-a-custom-tab-by-using-ribbon-xml.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Create a custom tab by using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Create a master detail relation using a cached dataset](../vsto/walkthrough-creating-a-master-detail-relation-using-a-cached-dataset.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Create a template by using content controls](../vsto/walkthrough-creating-a-template-by-using-content-controls.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Create shortcut menus for bookmarks](../vsto/walkthrough-creating-shortcut-menus-for-bookmarks.md) - Moving sample files and updating code references (part 1) - 10
- [Walkthrough: Create your first VSTO Add-in for Outlook](../vsto/walkthrough-creating-your-first-vsto-add-in-for-outlook.md) - Moving sample files and updating code references (part 1) - 10
- [How to: Programmatically populate Word tables with document properties](../vsto/how-to-programmatically-populate-word-tables-with-document-properties.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically print documents](../vsto/how-to-programmatically-print-documents.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically print worksheets](../vsto/how-to-programmatically-print-worksheets.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically protect documents and parts of documents](../vsto/how-to-programmatically-protect-documents-and-parts-of-documents.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically protect workbooks](../vsto/how-to-programmatically-protect-workbooks.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically reset ranges in Word documents](../vsto/how-to-programmatically-reset-ranges-in-word-documents.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically restore selections after searches](../vsto/how-to-programmatically-restore-selections-after-searches.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically run Excel calculations](../vsto/how-to-programmatically-run-excel-calculations-programmatically.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically save documents](../vsto/how-to-programmatically-save-documents.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically save Visio documents](../vsto/how-to-programmatically-save-visio-documents.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically save workbooks](../vsto/how-to-programmatically-save-workbooks.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically search for and replace text in documents](../vsto/how-to-programmatically-search-for-and-replace-text-in-documents.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically search for Text in worksheet ranges](../vsto/how-to-programmatically-search-for-text-in-worksheet-ranges.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically sort data in worksheets](../vsto/how-to-programmatically-sort-data-in-worksheets.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically store and retrieve date values in Excel ranges](../vsto/how-to-programmatically-store-and-retrieve-date-values-in-excel-ranges.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically update bookmark text](../vsto/how-to-programmatically-update-bookmark-text.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically use built-in dialog boxes in Word](../vsto/how-to-programmatically-use-built-in-dialog-boxes-in-word.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Protect parts of documents by using content controls](../vsto/how-to-protect-parts-of-documents-by-using-content-controls.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Read from and write to document properties](../vsto/how-to-read-from-and-write-to-document-properties.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Resize Bookmark controls](../vsto/how-to-resize-bookmark-controls.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Resize ListObject controls](../vsto/how-to-resize-listobject-controls.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Resize NamedRange controls](../vsto/how-to-resize-namedrange-controls.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Update a data source with data from a host control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Validate data when a new row is added to a ListObject control](../vsto/how-to-validate-data-when-a-new-row-is-added-to-a-listobject-control.md) - Moving sample files and updating code references (part 1) - 9
- [Late binding in Office solutions](../vsto/late-binding-in-office-solutions.md) - Moving sample files and updating code references (part 1) - 9
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md) - Moving sample files and updating code references (part 1) - 9
- [Persist dynamic controls in Office documents](../vsto/persisting-dynamic-controls-in-office-documents.md) - Moving sample files and updating code references (part 1) - 9
- [How to: Programmatically apply color to Excel ranges](../vsto/how-to-programmatically-apply-color-to-excel-ranges.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically apply styles to ranges in workbooks](../vsto/how-to-programmatically-apply-styles-to-ranges-in-workbooks.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically cache a data source in an Office document](../vsto/how-to-programmatically-cache-a-data-source-in-an-office-document.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically change formatting in worksheet rows containing selected cells](../vsto/how-to-programmatically-change-formatting-in-worksheet-rows-containing-selected-cells.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically close documents](../vsto/how-to-programmatically-close-documents.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically close workbooks](../vsto/how-to-programmatically-close-workbooks.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically collapse ranges or selections in documents](../vsto/how-to-programmatically-collapse-ranges-or-selections-in-documents.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically count characters in documents](../vsto/how-to-programmatically-count-characters-in-documents.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically create new Visio documents](../vsto/how-to-programmatically-create-new-visio-documents.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically create Word tables](../vsto/how-to-programmatically-create-word-tables.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically display documents in Print Preview](../vsto/how-to-programmatically-display-documents-in-print-preview.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically exclude paragraph marks when creating ranges](../vsto/how-to-programmatically-exclude-paragraph-marks-when-creating-ranges.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically Extend ranges in documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically hide text in documents](../vsto/how-to-programmatically-hide-text-in-documents.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically insert text into Word documents](../vsto/how-to-programmatically-insert-text-into-word-documents.md) - Moving sample files and updating code references (part 1) - 8
- [How to: Programmatically loop through found items in documents](../vsto/how-to-programmatically-loop-through-found-items-in-documents.md) - Moving sample files and updating code references (part 1) - 8
- [Access a form region at run time](../vsto/accessing-a-form-region-at-run-time.md) - Moving sample files and updating code references (part 1) - 7
- [Access the Ribbon at run time](../vsto/accessing-the-ribbon-at-run-time.md) - Moving sample files and updating code references (part 1) - 7
- [Actions pane overview](../vsto/actions-pane-overview.md) - Moving sample files and updating code references (part 1) - 7
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md) - Moving sample files and updating code references (part 1) - 7
- [Extend Word documents and Excel workbooks in VSTO add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Add an Actions Pane to Word Documents or Excel Workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Add Bookmark controls to Word documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Add Content controls to Word documents](../vsto/how-to-add-content-controls-to-word-documents.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Add custom XML parts to documents by using VSTO Add-ins](../vsto/how-to-add-custom-xml-parts-to-documents-by-using-vsto-add-ins.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Fill ListObject controls with data](../vsto/how-to-fill-listobject-controls-with-data.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Manage control layout on actions panes](../vsto/how-to-manage-control-layout-on-actions-panes.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Map ListObject columns to data](../vsto/how-to-map-listobject-columns-to-data.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Programmatically add and delete worksheet comments](../vsto/how-to-programmatically-add-and-delete-worksheet-comments.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Programmatically add headers and footers to documents](../vsto/how-to-programmatically-add-headers-and-footers-to-documents.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Programmatically add pictures and Word Art to documents](../vsto/how-to-programmatically-add-pictures-and-word-art-to-documents.md) - Moving sample files and updating code references (part 1) - 7
- [How to: Programmatically add rows and columns to Word tables](../vsto/how-to-programmatically-add-rows-and-columns-to-word-tables.md) - Moving sample files and updating code references (part 1) - 7

#### XAML Tools

**Updated articles**

- [Use Design Time Data with the XAML Designer in Visual Studio](../xaml-tools/xaml-designtime-data.md) - Added UWP Example for Listviews

### March 2021

#### Code quality

**Updated articles**

- [Enable or install first-party .NET analyzers](../code-quality/install-net-analyzers.md) - GitHub issue fixes

#### Containers

**Updated articles**

- [Use Bridge to Kubernetes](../containers/bridge-to-kubernetes.md) - Bridge to Kubernetes: Use .NET todo-app sample
- [Docker Compose build properties](../containers/docker-compose-properties.md) - Adding ComposeProjectName
- [How Bridge to Kubernetes works](../containers/overview-bridge-to-kubernetes.md) - Bridge to Kubernetes: Update Limitations section
- [Tutorial: Create a multi-container app with Docker Compose](../containers/tutorial-multicontainer.md) - Container Tools multicontainer tutorial: fix image link

#### Debugger

**Updated articles**

- [How to: Debug from a DLL project in Visual Studio (C#, C++, Visual Basic, F#)](../debugger/how-to-debug-from-a-dll-project.md) - Refresh how to debug from a DLL
- [Specify symbol (.pdb) and source files in the Visual Studio debugger (C#, C++, Visual Basic, F#)](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md) - Refresh how to debug from a DLL
- [C/C++ Assertions](../debugger/c-cpp-assertions.md) - GitHub issue fixes
- [IDiaDataSource::loadDataForExe](../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) - GitHub issues work
- [Format specifiers for C++ in the Visual Studio debugger](../debugger/format-specifiers-in-cpp.md) - GitHub issues work
- [Configure Windows Firewall for remote debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md) - GitHub issue fixes
- [Remote Debug ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-7-5-computer.md) - Updates to remote debugging docs for IIS and Azure
- [Remote Debug ASP.NET Core on a Remote IIS Computer in Visual Studio](../debugger/remote-debugging-aspnet-on-a-remote-iis-computer.md) - Updates to remote debugging docs for IIS and Azure
- [Remote Debug ASP.NET Core on IIS in Azure in Visual Studio](../debugger/remote-debugging-azure.md) - Updates to remote debugging docs for IIS and Azure

#### Deployment

**Updated articles**

- [How to: Publish a WPF application with visual styles enabled](../deployment/how-to-publish-a-wpf-application-with-visual-styles-enabled.md) - Developer Command Prompt and Developer PowerShell
- [Deploy an app to a folder using Visual Studio](../deployment/quickstart-deploy-to-local-folder.md) - Updates to remote debugging docs for IIS and Azure

#### Extensibility

**Updated articles**

- [Visual language dictionary](../extensibility/ux-guidelines/visual-language-dictionary-for-visual-studio.md) - add missing Markdown brackets to fix icon rendering error
- [Troubleshooting template installation](../extensibility/troubleshooting-template-discovery.md) - Developer Command Prompt and Developer PowerShell

#### Get started

**Updated articles**

- [Tutorial: Open a project from a repo](../get-started/tutorial-open-project-from-repo-visual-studio-2019.md)
  - update topics with side-by-side comparison of Git & Team Explorer link
  - add sign-in links for more info to the sign-in section
- [Tutorial: Get started with C# and ASP.NET Core in Visual Studio](../get-started/csharp/tutorial-aspnet-core.md) - Update tutorial-aspnet-core.md

#### IDE

**New articles**
- [How Visual Studio makes source control easy](../version-control/git-visual-studio-source-control.md) - create new Visual Studio Source Control topic
- [Developer Command Prompt and Developer PowerShell](./reference/command-prompt-powershell.md) - Developer Command Prompt and Developer PowerShell
- [Side-by-side comparison of Git and Team Explorer](../version-control/git-team-explorer-feature-comparison.md) - add new side-by-side comparison page of Team Explorer and new Git features

**Updated articles**

- [System-generated logs collected by Visual Studio](./diagnostic-data-collection.md) - Update diagnostic-data-collection.md
- [Visual Studio Customer Experience Improvement Program](./visual-studio-experience-improvement-program.md) - Update visual-studio-experience-improvement-program.md
- [Customize project and item templates](./customizing-project-and-item-templates.md) - add links about customizing templates and using the command line
- [How to: Create project templates](./how-to-create-project-templates.md) - add links about customizing templates and using the command line
- [Code editor F1 help](./not-in-toc/default-f1-text-editor.md) - Link updates for F1 default pages
- [F1 help](./not-in-toc/default.md) - Link updates for F1 default pages
- [Quickstart: Use Visual Studio to create your first Node.js app](./quickstart-nodejs.md) - AngularJS updates
- [Extract a method refactoring](./reference/extract-method.md) - Update extract-method.md
- [XAML Designer options page](./reference/xaml-designer.md) - Add information about newly added options inside the XAML designer
- [What's new in Visual Studio 2019](./whats-new-visual-studio-2019.md)
  - add Intelligent Search Service info
  - add new CSharp 9 link to See Also
- [Developer Command Prompt and Developer PowerShell](./reference/command-prompt-powershell.md)
  - Update feature titles and remove prereqs section
  - Update heading hierarchy
  - Developer Command Prompt and Developer PowerShell
- [Connect to projects in Team Explorer](./connect-team-project.md) - update topics with side-by-side comparison of Git & Team Explorer link
- [Git experience in Visual Studio](./git-with-visual-studio.md)
  - add Azure DevOps to existing remote statement
  - add new side-by-side comparison page of Team Explorer and new Git features
  - -b argument missing in git-with-visual-studio.md
- [Default keyboard shortcuts in Visual Studio](./default-keyboard-shortcuts-in-visual-studio.md) - add missing Set Breakpoint Conditions keyboard shortcut
- [User permissions and Visual Studio](./user-permissions-and-visual-studio.md) - add procedure to set Admin perms on the shortcut
- [Generate Equals and GetHashCode method overrides in Visual Studio](./reference/generate-equals-gethashcode-methods.md)
  - reduce screenshot size and add minor edit to an instruction
  - add code to pair with screenshots
- [Use regular expressions in Visual Studio](./using-regular-expressions-in-visual-studio.md) - fix wrong regex
- [Customize build and debug tasks for Open Folder development](./customize-build-and-debug-tasks-in-visual-studio.md) - Developer Command Prompt and Developer PowerShell
- [Visual Studio productivity guide for C# developers](./csharp-developer-productivity.md) - update code inspection extension list for VS2019

#### Install

**New articles**
- [Applying administrator updates that use Microsoft Endpoint Configuration Manager](../install/applying-administrator-updates.md) - Created new content about applying administrator updates
- [Enabling administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager](../install/enabling-administrator-updates.md) - Created new content about enabling administrator updates

**Updated articles**

- [Visual Studio build numbers and release dates](../install/visual-studio-build-numbers-and-release-dates.md)
  - Update visual-studio-build-numbers-and-release-dates.md
  - add 16.9.2 release data
  - Patch Tuesday updates
  - update date of build numbers page
  - build numbers for 16.9 GA and 16.10 Preview 1
  - Update for new releases
- [Create an offline installation of Visual Studio](../install/create-an-offline-installation-of-visual-studio.md) - Admin update doc edits
- [Install certificates required for Visual Studio offline installation](../install/install-certificates-for-visual-studio-offline.md) - Admin update doc edits
- [Install Visual Studio versions side-by-side](../install/install-visual-studio-versions-side-by-side.md) - Admin update doc edits
- [Install and use Visual Studio and Azure Services behind a firewall or proxy server](../install/install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md) - Updated article.

#### JavaScript

**Updated articles**

- [JavaScript and TypeScript in Visual Studio # Required; page title displayed in search results. Include the brand. < 60 chars.](../javascript/index.yml) - AngularJS updates
- [Quickstart: Use Visual Studio to create your first Vue.js app](../javascript/quickstart-vuejs-with-nodejs.md) - AngularJS updates
- [Tutorial: Create an ASP.NET Core app with TypeScript in Visual Studio](../javascript/tutorial-aspnet-with-typescript.md)
  - AngularJS updates
  - visualstudio-docs/issues/6457 -- missing version
- [Tutorial: Create a Node.js and Express app in Visual Studio](../javascript/tutorial-nodejs.md) - AngularJS updates
- [Learn to use the code editor for JavaScript](../javascript/write-and-edit-code.md) - AngularJS updates
- [Unit testing JavaScript and TypeScript in Visual Studio](../javascript/unit-testing-javascript-with-visual-studio.md)
  - Unit tests for ASP.NET Core and TypeScript
  - Developer Command Prompt and Developer PowerShell
  - GitHub issue fixes
- [Manage npm packages in Visual Studio](../javascript/npm-package-management.md) - GitHub issue fixes

#### MSBuild

**Updated articles**

- [How MSBuild builds projects](../msbuild/build-process-overview.md) - Fix bad element name.
- [CreateCSharpManifestResourceName task](../msbuild/createcsharpmanifestresourcename-task.md) - fix incorrect cross-referencing typo
- [How to: Extend the Visual Studio build process](../msbuild/how-to-extend-the-visual-studio-build-process.md) - Fix XML indentation
- [MIDL task](../msbuild/midl-task.md) - Update midl-task.md
- [Common MSBuild project items](../msbuild/common-msbuild-project-items.md) - Add in-article toc and improve formatting
- [Item element (MSBuild)](../msbuild/item-element-msbuild.md) - Add in-article toc and improve formatting
- [Exec task](../msbuild/exec-task.md) - Add doc for Utf8Encoding parameter

#### Profiling

**Updated articles**

- [Measure application performance from the command line](../profiling/profile-apps-from-command-line.md) - GitHub issue fixes
- [First look at profiling tools](../profiling/profiling-feature-tour.md) - Discovery work for .NET Counters tool

#### Python

**Updated articles**

- [Tutorial: Get started with the Flask web framework in Visual Studio](../python/learn-flask-visual-studio-step-01-project-solution.md)
  - Updated code and text about query parameters
  - Removed Polls template content from Visual Studio 2019 Python tutorials
- [Tutorial: Get started with the Django web framework in Visual Studio](../python/learn-django-in-visual-studio-step-01-project-and-solution.md) - Removed Polls template content from Visual Studio 2019 Python tutorials
- [Step 5: Authenticate users in Django](../python/learn-django-in-visual-studio-step-05-django-authentication.md) - Removed Polls template content from Visual Studio 2019 Python tutorials
- [Step 6: Use the Polls Django Web Project template](../python/learn-django-in-visual-studio-step-06-polls-django-web-project-template.md) - Removed Polls template content from Visual Studio 2019 Python tutorials
- [Step 4: Use the full Flask Web Project template](../python/learn-flask-visual-studio-step-04-full-flask-project-template.md) - Removed Polls template content from Visual Studio 2019 Python tutorials
- [Step 5: Use the Polls Flask Web Project template](../python/learn-flask-visual-studio-step-05-polls-flask-web-project-template.md) - Removed Polls template content from Visual Studio 2019 Python tutorials
- [Django web project template](../python/python-django-web-application-project-template.md) - Removed Polls template content from Visual Studio 2019 Python tutorials
- [Python web application project templates](../python/python-web-application-project-templates.md) - Removed Polls template content from Visual Studio 2019 Python tutorials
- [Install debugging symbols for Python interpreters](../python/debugging-symbols-for-mixed-mode-c-cpp-python.md) - Add the last 3 releases of Python 2.7

#### Test

**New articles**

- [Upgrade from  *.testsettings* to *.runsettings*](../test/migrate-testsettings-to-runsettings.md) - add migrate to runsettings doc
- [Upgrade from MSTestV1 to MSTestV2](../test/mstest-update-to-mstestv2.md) - Add doc on upgrading from MSTestV1 to MSTestv2

**Updated articles**

- [Create unit test method stubs from code](../test/create-unit-tests-menu.md) - visualstudio-docs/issues/6484 -- update link
- [First look at testing tools in Visual Studio](../test/improve-code-quality.md) - visualstudio-docs/issues/6429 -- update lab links
- [Configure unit tests by using a *.runsettings* file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)
  - Developer Command Prompt and Developer PowerShell
  - Fixed typos
- [VSTest.Console.exe command-line options](../test/vstest-console-options.md) - Developer Command Prompt and Developer PowerShell

### February 2021

#### Debugger

**Updated articles**

- [Use breakpoints in the Visual Studio debugger](../debugger/using-breakpoints.md) - Updates for accessibility

#### Get started

**Updated articles**

- [Tutorial: Open a project from a repo in Visual Studio 2017](../get-started/tutorial-open-project-from-repo-visual-studio-2017.md) - update See Also links in VS2017 Open Project from a Repo
- [Tutorial: Open a project from a repo](../get-started/tutorial-open-project-from-repo-visual-studio-2019.md) - Add link to VS2017 version of the 'Open a project from a repo' page

#### IDE

**Updated articles**

- [Troubleshoot and create logs for MSBuild problems](./msbuild-logs.md) - Add instructions on using the project system tools extension

#### Install

**Updated articles**

- [Update Visual Studio using a minimal offline layout](../install/update-minimal-layout.md)
  - Add 2017 example in options table
  - Add examples for VS2017

#### MSBuild

**New articles**

- [MSB3644: The reference assemblies for 'FrameworkVersion' were not found](../msbuild/errors/msb3644.md) - MSBuild errors
- [MSB8036: The Windows SDK 'version' was not found](../msbuild/errors/msb8036.md) - MSBuild errors

#### Test

**Updated articles**

- [Use the Microsoft Unit Testing Framework for C++ in Visual Studio](../test/how-to-use-microsoft-test-framework-for-cpp.md) -  Small content refresh and edit
- [Write unit tests for C++ DLLs in Visual Studio](../test/how-to-write-unit-tests-for-cpp-dlls.md) - Small content refresh and edit
- [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md) - Updates for accessibility
- [Walkthrough: Create and run unit tests for managed code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md) - Updates for accessibility
- [Isolate code under test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md) - Explicitly mention .NET 5.0 in Fakes docs