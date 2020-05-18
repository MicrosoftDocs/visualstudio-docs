---
title: "Events Viewer | Microsoft Docs"
ms.date: "4/30/2020"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Profiler, Events Viewer"
author: "Sagar-S-S"
ms.author: "sashe"
manager: AndSter
ms.workload:
  - "multiple"
---

# Events Viewer

The generic events viewer allows you to view the activity of your application through a list of events such module load, thread start, and system configurations to help better diagnose how your application is performing right within the Visual Studio profiler.


## Setup

1. Open the Performance Profiler (**Alt + F2)** in Visual Studio.
2. Select the **Events Viewer** checkbox.

![Event Viewer Selected](../profiling/media/eventsviewerselected.png "Event Viewer Selected")

3. Click the **Start** button to run the tool.

4. Once the tool starts running, go through the desired scenario in your app, then press **Stop Collection** or close your app to see your data.

![Stop Collection](../profiling/media/stopcollectioneventsviewer.png "Stop Collection")

For more information on how to make the tool more performant see [Optimizing Profiling Settings](../profiling/optimizing-profiler-settings.md).

## Understand Your Data

![Event Viewer Trace](../profiling/media/eventviewertrace.png "Event Viewer Trace")

|Column Name|Description|
|----------|---------------------|
|Provider Name|Shows the event source.|
|Event Name|Shows the event that took place as specified by the provider.|
|Text|Provides descriptions about the provider, event name, and IDs for a given event|
|Timestamp (ms)|Shows the time that event took place.|
|Provider Guid|The ID of the event provider.|
|Event ID|The ID of the event that fired.|
|Process ID|The process from which the event was fired (if known).|
|Process Name|Name of the process if it is actively running.|
|Thread ID|The ID of the thread from which the event was fired (if known).|

If a few of the columns are missing by default, right click on one of the existing column headers and select the column you would like to add.

![Event Viewer Add Columns](../profiling/media/eventvieweraddcolumns.png "Event Viewer Add Columns")

When you click on a given event the additional properties window pops up. The **Common Properties** are the list of properties that will show up for any event. The **Payload Properties** are properties specific to that event. For some events you can also view **Stacks**.

![Event Viewer Stacks](../profiling/media/eventviewerstacks.png "Event Viewer Stacks")

## Organize Your Data

All of the columns except for the text column are all sortable. 

![Event Viewer Trace](../profiling/media/eventviewertrace.png "Event Viewer Trace")

The event viewer displays up to 20,00 events at a time. To focus on the events of interest you can filter the display of events by clicking on the Event Filter. You can also see what percentage of the total number of events were fired by each provider. Hovering over a single event filter brings up a tooltip showing the event name, provider, GUID, % of total events, and event count. 

![Event Viewer Event Filter](../profiling/media/eventviewereventfilter.png "Event Viewer Event Filter")

You can filter by provider using the **Provider Filter**, which shows what percentage of the total number of events were fired by each one. Hovering over a single provider also brings up a similar tooltip with provider name, % of total events, and event count.

![Event Viewer Provider Filter](../profiling/media/eventviewerproviderfilter.png "Event Viewer Provider Filter")
