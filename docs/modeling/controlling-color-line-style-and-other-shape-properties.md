---
title: Control Color, Line Style, and other Shape Properties
description: Provides information about controlling shape properties such as color and line style.
ms.date: 11/04/2016
ms.topic: how-to
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.custom: SEO-VS-2020
ms.workload:
  - "multiple"
---
# Controlling Color, Line Style, and other Shape Properties

Some shape properties such as color can be 'exposed'. That is, the properties can be linked to a domain property of the shape. Others have to be controlled directly.

## Exposing a property
 Some shape properties such as color can be linked to the value of a domain property.

 In the DSL Definition, select a shape, connector or diagram class. On its right-click menu, choose **Add Exposed**, and then choose the property you want, such as Fill Color.

 The shape now has a domain property that you can set in program code or as a user.

## Dynamically updating an exposed property
 Typically you want to make the exposed property dependent on another property. For example, you might want a shape to turn red whenever a particular domain property is less than zero. To make this dependency, create a [rule](../modeling/rules-propagate-changes-within-the-model.md). For example:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
namespace ExampleNamespace
{
 // Attribute associates the rule with class:
 [RuleOn(typeof(CarShape), FireTime = TimeToFire.TopLevelCommit)]
 // The rule is a class derived from one of the abstract rules:
 class CarShapeAddRule : AddRule
 {
 // Override the abstract method:
 public override void ElementAdded(ElementAddedEventArgs e)
 {
 base.ElementAdded(e);
 CarShape shape = e.ModelElement as CarShape;
 Store store = shape.Store;
 // Ignore this call if we're currently loading a model:
 if (store.TransactionManager.CurrentTransaction.IsSerializing)
  return;
 Car car = shape.ModelElement as Car;
 // Code here propagates change as required - for example:
 shape.FillColor = car.Somebool ? System.Drawing.Color.Red : System.Drawing.Color.Green;
 }
}
 // The rule must be registered:
 public partial class ExampleDomainModel
 {
 protected override Type[] GetCustomDomainModelTypes()
 {
  List<Type> types = new List<Type>(base.GetCustomDomainModelTypes());
  types.Add(typeof(CarShapeAddRule));
  // If you add more rules, list them here.
  return types.ToArray();
 }
 }
}
```