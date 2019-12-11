---
title: "Graphics State | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.graphics.statewindow"
ms.assetid: 97e7757e-c372-4626-8149-99a81367a0e1
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Graphics State
The State window in Visual Studio graphics Diagnostics helps you understand the graphics state that is active at the time of the current event, such as a draw call.

## Understanding the State window
 The state window collects together the state that affects rendering and presents it hierarchically, in one place. Depending on the version of Direct3D your app uses, the information presented in the state window might have differences.

### State views
 You can view the state table in several different ways:

|View|Description|
|----------|-----------------|
|API input state view|This view presents the state in a similar layout to the Direct3D objects that make up the state.|
|Logical input state view|This view presents the state in a logical view that does not mirror the layout of the Direct3D objects that make up the state.|
|Pinned state view|Instead of a hierarchy, the Pinned state view presents pinned state items in a flat list with fully-qualified names. This view makes is possible to view many state items from different bundles of state in a small number of lines.|

##### To change the state view

- In the State window, in the upper left-hand just below the titlebar, choose the button that corresponds to the state view style you want to use.

  - **Show API input state view**

  - **Show Logical state view**

  - **Show Pinned state view**

> [!IMPORTANT]
> You must pin state in the **Show API input state** or **Show Logical state** views for it to be displayed in the **Show Pinned state view**.

### State table format
 The State window presents several columns of information.

|Column|Description|
|------------|-----------------|
|Name|The name of the state item. If this item represents a bundle of state, the item can be expanded to display it.<br /><br /> In the **API input state view** and **Logical state view** states, names are indented to show the hierarchical relationship between states.<br /><br /> In the **Pinned state view** state, fully-qualified names are displayed in a flat list.|
|Value|The value of the state item.|
|Type|The type of the state item.|

### Changed state
 Graphics state typically changes incrementally between subsequent draw calls, and many kinds of rendering problems are caused when state is changed incorrectly. To help you find which state has changed since the previous draw call, state that's been changed is marked with an asterisk and displayed in red—this applies not just to the state itself, but to its parent state item as well, so that you can easily spot changed state at the highest level and then drill-down to the details.

### Pinning state
 Because many apps render similar objects sequentially, changing a known set of state, it's sometimes useful to pin the changing states in place so that you can watch how it changes as you move from draw call to draw call.

 This can also be useful if you've isolated the source of a problem to be due to a change in a particular state.

##### To pin state in place

1. In the State window, locate the state that you're interested in. You might have to expand higher-level state to locate the details you're interested in.

2. Place the cursor over the state that you're interested in. A Pin icon appears to the left of the state item.

3. Choose the Pin icon to pin the state item in place.
