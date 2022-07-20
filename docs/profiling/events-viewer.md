---
title: Events Viewer | Microsoft Docs
description: Learn about the generic events viewer, which helps you better diagnose how your app is doing within the Visual Studio profiler.
ms.custom: SEO-VS-2020
ms.date: 4/30/2020
ms.topic: how-to
helpviewer_keywords: 
  - Profiler, Events Viewer
author: Sagar-S-S
ms.author: sashe
manager: AndSter
ms.workload: 
  - multiple
---
# Events viewer

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The generic events viewer shows app activity through a list of events like module load, thread start, and system configuration. This view helps you better diagnose how your app is doing within the Visual Studio profiler.

## Setup

1. Select **Alt+F2** to open the Performance Profiler in Visual Studio.

1. Select the **Events Viewer** check box.

   ![The Events Viewer check box selected](../profiling/media/eventsviewerselected.png "The Events Viewer check box selected")

1. Select the **Start** button to run the tool.

1. After the tool starts running, go through the scenario to profile in your app. Then select **Stop collection** or close your app to see your data.

   ![A window showing Stop collection](../profiling/media/stopcollectioneventsviewer.png "A window showing Stop collection")

For more information on how to make the tool more efficient, see [Optimizing Profiling settings](../profiling/optimize-profiler-settings.md).

## Understand your data

![An event viewer trace](../profiling/media/eventviewertrace.png "An event viewer trace")

|Column name|Description|
|----------|---------------------|
|Provider Name|The event source|
|Event Name|The event as specified by its provider|
|Text|Descriptions of the provider, event name, and ID for the event|
|Timestamp (ms)|When the event took place|
|Provider Guid|The ID of the event provider|
|Event ID|The ID of the event|
|Process ID|The process from which the event occurred (if known)|
|Process Name|The name of the process if it's actively running|
|Thread ID|The ID of the thread from which the event occurred (if known)|

If any column is missing by default, right-click one of the existing column headers and select the column you want to add.

![Adding columns to the event viewer](../profiling/media/eventvieweraddcolumns.png "Adding columns to the event viewer")

When you select an event, the **Additional Properties** window appears. **Common Properties** shows the list of properties that will appear for any event. **Payload Properties** shows properties specific to the event. For some events, you can also view **Stacks**.

![The event viewer showing stacks](../profiling/media/eventviewerstacks.png "The event viewer showing stacks")

## Organize your data

All columns except for the **Text** column are sortable.

![The event viewer trace](../profiling/media/eventviewertrace.png "The event viewer trace")

The event viewer displays up to 20,000 events at a time. To focus on the events of interest, you can filter the display of events by selecting the event filter. You can also see what percentage of the total number of events occurred for each provider. Hover over a single event filter to see a tooltip that shows the:

- Event name
- Provider
- GUID
- Percentage of total events
- Event count

![The event viewer event filter](../profiling/media/eventviewereventfilter.png "The event viewer event filter")

The provider filter shows what percentage of the total number of events occurred for each provider. Hover over a single provider to see a similar tooltip with provider name, percentage of total events, and event count.

![The event viewer provider filter](../profiling/media/eventviewerproviderfilter.png "The event viewer provider filter")
