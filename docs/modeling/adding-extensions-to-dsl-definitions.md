---
title: Adding Extensions to DSL Definitions
description: Learn how the DSL Definition extension allows you to create a package of extensions to a domain-specific language (DSL).
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
  - "multiple"
---
# Add Extensions to DSL Definitions

DSL Definition extension allows you to create a package of extensions to a domain-specific language (DSL). The DSL extension, which is contained in a Visual Studio Integration Extension (VSIX), can be installed on a user's computer in the same manner as a DSL. The additional features can be dynamically enabled and disabled at run time. DSLs do not have to be explicitly designed for extension, and extensions can be designed later, or by third parties, without altering the extended DSL.

DSL extensions can include the following features:

- Properties for model and presentation elements

- Decorators for shapes and connectors

- Classes, relationships, shapes, and connectors

- Validation constraints

- Toolbox items and tabs

A user of an extended DSL can create and save a model that contains instances of the additional features. The model can be read by other users who have installed the appropriate extension. Users who have not installed the extension cannot use the additional features, but they can update and save a model without losing the additional features.

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

## See also

- [Related blog posts](https://devblogs.microsoft.com/devops/the-visual-studio-modeling-sdk-is-now-available-with-visual-studio-2017/)
