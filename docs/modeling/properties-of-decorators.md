---
title: Properties of Decorators
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
  - "Domain-Specific Language, decorators"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Properties of Decorators
Decorators are icons, text, or expand/collapse chevrons that can appear on shapes or connectors on the diagram. The following tables show the properties for the three kinds of decorator. Some of the properties appear only on shape decorators or only on connector decorators.

 For more information, see [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md). For more information about how to use these properties, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

## Expand/Collapse Decorator

|Property|Description|Default|
|-|-|-|
|DisplayName|The name of the decorator that will be displayed in the generated designer.|Expand Collapse Decorator|
|Name|The name of the decorator.|ExpandCollapseDecorator|
|Notes|Informal notes that are associated with this decorator.|\<none>|
|HorizontalOffset|The horizontal offset, relative to the default position of the decorator, in inches. (On shapes only.)|0|
|VerticalOffset|The vertical offset, relative to the default position of the decorator, in inches. (On shapes only.)|0|
|OffsetFromLine|The offset of the decorator from the line, relative to its default position, in inches. (On connectors only.)|0|
|OffsetFromShape|The offset of the decorator from the shape, relative to its default position, in inches. (On connectors only.)|0|
|Position|The default position of the decorator.|SourceTop|

## Icon Decorator

|Property|Description|Default|
|-|-|-|
|DefaultIcon|The path of the icon or image file to be displayed.|\<none>|
|DisplayName|The name of the decorator to be displayed in the generated designer.|Icon Decorator|
|Name|The name of the decorator.|IconDecorator|
|Notes|Informal notes that are associated with the decorator.|\<none>|
|HorizontalOffset|The horizontal offset, relative to the default position of the decorator, in inches. (On shapes only.)|0|
|VerticalOffset|The vertical offset, relative to the default position of the decorator, in inches. (On shapes only.)|0|
|OffsetFromLine|The offset of the decorator from the line, relative to its default position, in inches. (On connectors only.)|0|
|OffsetFromShape|The offset of the decorator from the shape, relative to its default position, in inches. (On connectors only.)|0|
|Position|The default position of the decorator.|SourceTop|

## TextDecorator

|Property|Description|Default|
|-|-|-|
|DefaultText|The default text to be displayed.|Label|
|DisplayName|The name of the decorator to be displayed in the generated designer.|Label|
|FontSize|The font size for the text that is displayed in the decorator.|8|
|FontStyle|The font style for the text that is displayed in the decorator.|Regular|
|Name|The name of the decorator.|Label|
|Notes|Informal notes that are associated with the decorator.|\<none>|
|HorizontalOffset|The horizontal offset, relative to the default position of the decorator, in inches. (On shapes only.)|0|
|VerticalOffset|The vertical offset, relative to the default position of the decorator, in inches. (On shapes only.)|0|
|OffsetFromLine|The offset of the decorator from the line, relative to its default position, in inches. (On connectors only.)|0|
|OffsetFromShape|The offset of the decorator from the shape, relative to its default position, in inches. (On connectors only.)|0|
|Position|The default position of the decorator.|TargetBottom|

## See also

- [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)