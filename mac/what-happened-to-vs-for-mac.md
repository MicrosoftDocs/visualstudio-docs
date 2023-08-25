---
title: "What's happening to Visual Studio for Mac"
description: "Learn about VS for Mac retirement and the new Mac development options."
author: j-martens 
ms.author: jmartens
manager: jmartens
ms.date: 08/30/2023
ms.topic: overview
---
# What's happening to Visual Studio for Mac?

Visual Studio for Mac is scheduled for retirement by August 31, 2024 in accordance with Microsoft’s [Modern Lifecycle Policy](/lifecycle/policies/modern).  You can continue using Visual Studio for Mac as you have.

After years of evolving Visual Studio for Mac, it was decided that _______


## Support timeline

The following notes outline the timeline for support. 

:::row::: 
    :::column span="1"::: 
        **On or before Aug 31, 2024**
    :::column-end::: 
    :::column span="3"::: 
        VS for Mac users can still:
        + Create and maintain Mono, .NET 6, and .NET 7 applications. You can also continue to develop, maintain, and publish your apps to app stores.  
        + Access Microsoft Customer Service and Support for Visual Studio for Mac. 
        + Install product updates we release so you can reliably maintain and publish your mobile applications using the latest Xcode, iOS, and Android versions. Microsoft also releases security updates for Visual Studio for Mac.
        Microsoft doesn't plan to add support for [.NET 8](/dotnet/core/whats-new/dotnet-8/) or [C#12](/dotnet/csharp/whats-new/csharp-12/) to Visual Studio for Mac.  We won't extended to any other workloads before retirement either.
    :::column-end::: 
:::row-end:::
:::row::: 
    :::column span="1"::: 
        **After Aug 31, 2024**
    :::column-end::: 
    :::column span="3":::
        You can continue to use Visual Studio for Mac after its end-of-life date, but you won't receive any updates including for security. 
    :::column-end::: 
:::row-end:::


## Newer options for developing on the Mac

Today, [Visual Studio Code](https://code.visualstudio.com/docs/editor/whyvscode) is a great place for Mac users to do cloud-native .NET development with things like Azure Functions, and more.  As of 2023, premier support is available in [VS Code for .NET cloud, MAUI, and Mobile C# development through the C# Dev Kit](https://code.visualstudio.com/docs/csharp/get-started). The [C# Dev Kit for MAUI](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-maui) offers support for designing, editing, and debugging Unity scripts as well. 


There are a few areas where you might see a slightly different experience. XAML editing on VS Code is limited compared to the experience on both Visual Studio and Visual Studio for Mac. For the best experience, we’d recommend Visual Studio on Windows. Additionally, Android simulator-based development is another area where you may see some challenges since simulators can’t work in a guest virtual machine environment. Also, because Docker development can’t be done on a hosted guest Windows environment, you must work completely in VS Code if you’re on the Mac.


If you prefer to use a full-fledged IDE, you can use the same license for Visual Studio for Mac on **Visual Studio on Windows**. You can use VM hosts like Parallels to set up Windows and work in Visual Studio (Windows). You can also [leverage Microsoft’s Dev Box service to create a Windows VM in the cloud](). 
  

## Get support 

Visual Studio for Mac is licensed under Microsoft’s [Modern Lifecycle Policy](/lifecycle/policies/modern).  Microsoft Customer Service and Support remains available through Visual Studio for Mac’s end-of-life date. You’ll also receive security updates to ensure you can continue to build and publish your existing applications with Visual Studio for Mac.
 

You can continue to submit [Developer Community tickets](/visualstudio/ide/developer-community-guidelines) to report bugs with Visual Studio for Mac before May 2024, but note that Microsoft won't consider suggestions for new features and additional workload support. Additionally, Microsoft might not respond to every ticket, your input is used to help steer investments to ensure Visual Studio for Mac is a quality, performant, and reliable IDE through its end-of-life date. We want to encourage folks to upvote relevant tickets as that will increase visibility on our end. 

## Next steps

Try [the C# Dev Kit](https://code.visualstudio.com/docs/csharp/get-started) for premier support in VS Code for .NET cloud, [MAUI](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-maui), and Mobile C# development.  
