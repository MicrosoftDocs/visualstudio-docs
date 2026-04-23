---
ms.topic: include
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
### System requirements

The remote tools support the same system requirements as Visual Studio, with some changes. For details, see the system requirements for your version of Visual Studio:

::: moniker range=">=visualstudio"
- [Remote Tools for Visual Studio 2026 system requirements](/visualstudio/releases/2026/vs-system-requirements#remote-tools-for-visual-studio-system-requirements)
- [Remote Tools for Visual Studio 2022 system requirements](/visualstudio/releases/2022/system-requirements#remote-tools-and-intellitrace-standalone-collector-for-visual-studio-2022-system-requirements)
- [Remote Tools for Visual Studio 2019 system requirements](/visualstudio/releases/2019/system-requirements#remote-tools-performance-tools-and-intellitrace-standalone-collector-for-visual-studio-2019-system-requirements)
::: moniker-end
::: moniker range="vs-2022"
- [Remote Tools for Visual Studio 2022 system requirements](/visualstudio/releases/2022/system-requirements#remote-tools-and-intellitrace-standalone-collector-for-visual-studio-2022-system-requirements)
- [Remote Tools for Visual Studio 2019 system requirements](/visualstudio/releases/2019/system-requirements#remote-tools-performance-tools-and-intellitrace-standalone-collector-for-visual-studio-2019-system-requirements)
::: moniker-end

### Network configuration

The remote computer and the Visual Studio computer must be connected over a network, workgroup, or homegroup, or else connected directly through an Ethernet cable. Debugging between two computers connected through a proxy isn't supported. Debugging over a high latency or low bandwidth connection, such as dialup Internet, or over the Internet across countries/regions isn't recommended and may fail or be unacceptably slow.