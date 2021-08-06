---
title: VSCT XML Schema Conditional Attributes | Microsoft Docs
description: Learn how to apply conditional attributes to VSCT XML schema lists and items. Attributes evaluate to true or false, controlling the resulting output.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSCT XML schema elements, conditional attributes
- conditional attributes (VSCT XML schema)
ms.assetid: 754d4f32-319b-44c9-915f-f7c60e53222e
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# VSCT XML schema conditional attributes
You can apply conditional attributes to all lists and items. Logical operators and symbol expansion expressions evaluate to true or false. If true, the associated list or item is included in the resulting output.

 You can test token expansions against other token expansions or constants. The function `Defined()` tests whether a particular name has been defined, even if it has no value.

 When a Condition attribute is applied to a list, the condition is applied to every child element in the list. If a child element itself contains a Condition attribute, then its condition is combined with the parent expression by an AND operation.

 The values 1, '1' and 'true' are evaluated as true, and 0, '0' and 'false' are evaluated as false.

## Operators
 Use the following operators to evaluate conditional expressions.

|Operator|Definition|
|--------------|----------------|
|(,)|Grouping|
|!|Logical not|
|\<, >, \<=, >=, ==, !=|Relational and Equality|
|and|Boolean|
|or|Boolean|

## Examples

```xml
<Menu Condition="Defined(DEBUG)" ...
</Menu>

<Menu Condition="%(SKU_MODE) = 'Demo'" ...
</Menu>

<Menus Condition="Defined(DEBUG)">
    <Menu ...
    </Menu>
</Menus>

<Menus Condition="Defined(DEMO_SKU)">
    <Menus Condition="!Defined(DEBUG)">
        <Menu ...
        </Menu>
    </Menus>

    <Menu ...
    </Menu>
</Menus>

<Menus Condition="(Defined(DEMO_SKU) or Defined(SAMPLE_SKU))
and !Defined(DEBUG)">
    <Menu ...
    </Menu>
</Menus>
```

## See also
- [Visual Studio command table (.Vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
