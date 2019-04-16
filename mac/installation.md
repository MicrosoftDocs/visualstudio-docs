---
title: "맥용 비주얼 스튜디오 2019 설치"
description: "맥용 비주얼 스튜디오 2019 및 크로스 플랫폼 개발에 필요한 추가 구성 요소를 설치하는 방법에 대한 지침."
author: conceptdev
ms.author: crdun
ms.date: 04/02/2019
ms.technology: vs-ide-install
ms.assetid: 22B1F2CD-32AE-464D-80AC-C8AB4786B015
ms.custom: video
---
# 맥용 비주얼 스튜디오 2019 설치

맥OS에서 네이티브, 크로스 플랫폼 .NET 응용 프로그램을 개발하려면 다음 단계에 따라 맥용 비주얼 스튜디오 2019를 설치하십시오.

## 요구사항

- 맥OS 하이 시에라 10.12이상이 설치된 맥.

iOS나 맥OS용 Xamarin 앱을 빌드하려면 다음 사항이 필요합니다. 

- Xcode 11.0이상. 보통은 최신 안정 버전을 권장합니다.
- 애플 ID. 애플 ID가 아직 없다면 https://appleid.apple.com 에서 새로 만들수 있습니다. Xcode를 설치하고 서명하려면 애플ID가 있어야 합니다.

## 설치 방법

1. [맥용 비주얼 스튜디오 다운로드 페이지](https://aka.ms/vsmac)에서 인스톨러를 다운로드 합니다.
2. 다운로드가 완료되면 **VisualStudioforMacInstaller.dmg**를 클릭하여 인스톨러를 마운트 한 다음, 화살표 로고를 더블클릭하여 실행합니다.

    [![설치를 시작하려면 큰 화살표를 클릭하세요.](media/install-installer-sml.png)](media/install-installer.png#lightbox)

3. 인터넷에서 다운로드되는 응용 프로그램에 대한 경고가 표시 될 수 있습니다. **열기**을 클릭하세요.
4. 다음과 같이 인스톨러가 시스템을 확인하는 동안 기다리세요.

    [![인스톨러가 시스템에 설치된 구성요소를 확인합니다](media/install-checking-sml.png)](media/install-checking.png#lightbox)

5. 개인 정보 및 사용권 조항을 확인하라는 경고 메시지가 나타납니다. 링크를 따라 읽으십시오. 동의하면 다음과 같이 **계속하기**를 클릭하세요.

    [![개인 정보 및 약관 링크를 클릭 한 다음 동의하면 계속 진행하십시오.](media/install-privacy-sml.png)](media/install-privacy.png#lightbox)

6. 사용 가능한 워크로드 목록이 표시됩니다. 다음과 같이 사용할 항목을 선택하십시오.

    [![설치하려는 워크로드 기능 선택](media/install-selection-sml.png)](media/install-selection.png#lightbox)

7. 선택을 마쳤으면 **설치** 버튼을 누르세요.
8. 인스톨러에서는 맥용 비주얼 스튜디오 및 선택한 워크로드를 다운로드하여 설치하면서 진행 상황을 표시합니다. 설치에 필요한 권한을 부여하려면 암호를 입력하라는 메시지가 표시 될 수 있습니다.

기업의 환경에 설치하는 동안 네트워크 문제가 발생하면 [방화벽 또는 프록시를 통한 설치](https://docs.microsoft.com/visualstudio/mac/installation#install-visual-studio-for-mac-behind-a-firewall-or-proxy-server) 지침을 검토하십시오.

[릴리즈 노트](https://docs.microsoft.com/visualstudio/releasenotes/vs2019-mac-relnotes)의 변경사항을 자세히 알아보세요.

> [!NOTE]
> 설치 진행중에 플랫폼이나 도구를 설치하지 않기로 선택한 경우 (6 단계에서 선택 취소) 나중에 구성 요소를 추가하려면 설치 프로그램을 다시 실행해야 합니다.

## 방화벽 또는 프록시 서버 뒤에 맥용 비주얼 스튜디오 설치

방화벽 뒤에 맥용 비주얼 스튜디오를 설치하려면 소프트웨어에 필요한 도구와 업데이트를 다운로드 할 수 있도록 특정 끝점에 액세스 할 수 있어야 합니다.

다음 위치에 대한 액세스를 허용하도록 네트워크를 구성하십시오.

- [비주얼 스튜디오 끝점](/visualstudio/install/install-visual-studio-behind-a-firewall-or-proxy-server)

## 다음 단계

맥용 비주얼 스튜디오를 설치하면 응용 프로그램용 코드를 작성할 수 있습니다. 다음 가이드에서는 프로젝트 작성 및 배포의 다음 단계를 안내합니다.

### iOS

1. [Hello, iOS](https://developer.xamarin.com/guides/ios/getting_started/hello,_iOS/)
2. [장치 프로비저닝](https://developer.xamarin.com/guides/ios/getting_started/installation/device_provisioning)(장치에서 응용 프로그램을 실행하려면).

### 안드로이드

1. [Xamarin Android SDK Manager 사용하기](https://developer.xamarin.com/guides/android/getting_started/installation/android-sdk/?ide=xs)
2. [Android SDK Emulator](https://developer.xamarin.com/guides/android/getting_started/installation/android-emulator/)
4. [개발 장비 설정](https://developer.xamarin.com/guides/android/getting_started/installation/set_up_device_for_development/)

### .NET Core 앱, ASP.NET Core 웹 앱, Unity 게임 개발

다른 워크로드의 경우 [워크로드](/visualstudio/mac/workloads) 페이지를 참조하세요.

## 연관 비디오

> [!Video https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Visual-Studio-for-Mac-Acquisition/player]

## 참고

- [윈도우에 비주얼 스튜디오 설치하기](/visualstudio/install/install-visual-studio)
