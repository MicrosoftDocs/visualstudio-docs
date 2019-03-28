---
title: "Unmanaged API reference (Office development in Visual Studio)"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office development in Visual Studio, reference"
  - "Office development in Visual Studio, unmanaged API reference"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Unmanaged API reference (Office development in Visual Studio)

Starting with the 2007 Microsoft Office system, Office applications use the [IManagedAddin interface](../vsto/imanagedaddin-interface.md) interface to call into a VSTO Add-in loader component that is included with the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)]. This component is used to help load-managed VSTO Add-ins. You can create your own VSTO Add-in loader component by implementing this interface.

> [!NOTE]
> Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.

## In this section

[IManagedAddin interface](../vsto/imanagedaddin-interface.md)

A COM interface that you can implement to load and unload managed VSTO Add-ins in Office applications.
