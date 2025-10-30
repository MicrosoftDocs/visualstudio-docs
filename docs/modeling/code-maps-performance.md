---
title: Code maps are slow
description: Learn how to improve code map performance and how you can minimize the time required to finish rendering.
ms.date: 05/16/2018
ms.topic: article
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Improve performance for code maps

When you generate a map for the first time, Visual Studio indexes all the dependencies that it finds. This process might take some time, especially for large solutions, but improves later performance. If your code changes, Visual Studio reindexes just the updated code. To minimize the time taken for the map to finish rendering, consider the following suggestions:

- Map only the dependencies that interest you.

- Before you generate the map for an entire solution, reduce the solution scope.

- Turn off automatic build for the solution by selecting **Skip Build** on the code map toolbar.

- Turn off automatic adding of parent items by selecting **Include Parents** on the code map toolbar.

   ![Skip Build and Include Parents buttons](../modeling/media/codemapsfilterskipbuildicons.png)

- Edit the code map file directly to remove nodes and links you don't need. Changing the map doesn't affect the underlying code. See [Customize code maps by editing the DGML files](../modeling/customize-code-maps-by-editing-the-dgml-files.md).

It might take more time to create maps or add items to a map from **Solution Explorer** when a project item's **Copy to Output Directory** property is set to **Copy Always**. To increase performance, change this property to **Copy if newer** or `PreserveNewest`. See [Incremental builds](../msbuild/incremental-builds.md).

The completed map shows dependencies only for successfully built code. If build errors occur for certain components, these errors appear on the map. Make sure that a component actually builds and has dependencies on it before you make architectural decisions based on the map.
