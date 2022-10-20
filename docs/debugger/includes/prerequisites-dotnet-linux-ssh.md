---
 title: Prerequisites for .NET Core on Linux and SSH
 description: Prerequisites for debugging .NET Core on Linux and SSH by attaching to a process
 services: ""
 author: mikejo5000
 ms.service: ""
 ms.topic: include
 ms.date: 10/19/2022
 ms.author: mikejo
 ms.custom: include file
---

- On the Visual Studio computer, you need to install either the **ASP.NET and web development** workload or the **.NET Core cross-platform development** workload.

- On the Linux server, you need to install SSH server, unzip and install with either curl or wget. For example, on Ubuntu you can do that by running:

  ``` cmd
  sudo apt-get install openssh-server unzip curl
  ```

  SFTP must be enabled as well as SSH. Most SSH distributions install and enable SFTP by default, but that is not always the case.

- On the Linux server, [install the .NET runtime on Linux](/dotnet/core/install/linux), and find the page matching your Linux distribution (such as Ubuntu). The .NET SDK is not required.

- For comprehensive ASP.NET Core instructions, see [Host ASP.NET Core on Linux with Nginx](/aspnet/core/host-and-deploy/linux-nginx) and [Host ASP.NET Core on Linux with Apache](/aspnet/core/host-and-deploy/linux-apache).
