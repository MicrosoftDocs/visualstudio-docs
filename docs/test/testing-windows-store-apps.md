---
title: "Testing Windows Store apps"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "tests, running"
  - "Test Runner, running on a device"
  - "manual tests, running on a device"
  - "Test Runner, running manual tests"
ms.assetid: e10d1cad-ebea-43ed-92ac-3391e5119fe7
caps.latest.revision: 44
ms.author: "ahomer"
manager: "douge"
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
# Testing Windows Store apps
You have two options if you want to test Windows Store apps on a phone, tablet, or other device:  
  
-   Plan and perform your tests using the web portal, using a browser on the device or on another computer. When you use the web portal for testing, the test runner doesn’t interact with the software that you’re testing; it simply acts as a checklist of the test steps. Therefore, you don’t have to run it on the device that you’re testing.  
  
     This option requires no special preparation on the device, other than installing the software.  
  
-   Couple the device to your computer, and run the tests using Microsoft Test Manager. This option allows you to capture screenshots and [collect diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md) from the device.  
  
     You can perform manual tests of Windows Store apps on any type of Windows 8 remote device.  
  
### Prepare the Windows 8 device for testing  
  
1.  If possible, use the same user credentials or the same Microsoft Live ID on the Windows 8 device and on the computer that is running Microsoft Test Manager. If the user is different, the machine that you are running Microsoft Test Manager from will display a credentials dialog box when you try to connect.  
  
2.  Install the Remote Debugger on the device that you want to test. See [Installing the Remote Debugger](../debugger/run-windows-store-apps-on-a-remote-machine.md#BKMK_Installing_the_Remote_Tools). (This is only supported for Windows 8 client operating systems. Windows Server 2012 is not supported.)  
  
     The Microsoft Test Tools Adapter Configuration Tool will appear on the device as a new tile.  
  
3.  Choose the Microsoft Test Tools Adapter Configuration Tool tile in Windows 8.  
  
4.  Choose **Start Service** in the configuration dialog box for Microsoft Test Tools Adapter to configure the Microsoft Test Tools Adapter.  
  
### Connect to the remote device  
  
1.  On the machine that you are testing from, [open Microsoft Test Manager](../test/connect-microsoft-test-manager-to-your-team-project-and-test-plan.md).  
  
     [Create some test cases](../test/plan-manual-tests-with-microsoft-test-manager.md) if you haven’t already done so.  
  
2.  On the **Run Tests** page, choose the **Modify** link next to **Perform tests using:** to specify the remote Windows 8 device.  
  
     ![Select where to run your manual test](../test/media/mtr_win8_whererun.png "MTR_Win8_WhereRun")  
  
3.  Choose the **Remote device** option and enter the name of the device that you want to test.  
  
     ![Select where to run test](../test/media/mtr_win8_whererun2.png "MTR_Win8_WhereRun2")  
  
     By default, port 6905 is used by Microsoft Test Manager to communicate with remote devices. If you want to use a different port, enter the remote device as *deviceName***:***port*. For example, `mySlateDevice1:8001`.  You must also change the port on the remote device by opening the service configuration file mttaservice.exe.config in the Visual Studio installation folder.  
  
4.  Choose the **Test** link to verify that Microsoft Test Manager can communicate with the remote device.  
  
### Install your Windows Store app  
  
1.  Choose **Install Windows Store App**, and then enter the path and name of the .appx file for the Windows Store app that you want to install.  
  
     ![Install Windows Store app from MTM](../test/media/mtr_win8_installwindowsstyleapp.png "MTR_Win8_InstallwindowsStyleApp")  
  
2.  Follow the steps in the installation wizard.  
  
     ![Tailored Application Installation Steps](../test/media/mtr_win8_tailoredappinstallstepsdialog.png "MTR_Win8_TailoredAppInstallStepsDialog")  
  
     ![Test certificate dialog](../test/media/mtr_win8_testcertdialog.png "MTR_Win8_TestCertDialog")  
  
### Test your Windows Store app  
  
1.  Choose **Start Test**.  
  
     Test Runner opens.  
  
2.  Perform the steps in the test on the remote device.  
  
     As you complete each step of the test, [mark it passed or failed on the host computer](../test/run-manual-tests-with-microsoft-test-manager.md).  
  
     The following features are supported while you test on a Windows 8 Remote device:  
  
    |Feature|Support|  
    |-------------|-------------|  
    |System info|Yes|  
    |Capture screenshot|Yes|  
    |[Event logs](../test/collect-more-diagnostic-data-in-manual-tests.md)|Yes.|  
    |Action record/playback|Windows Web apps – Yes.<br /><br /> Windows desktop and store apps – No.|  
    |Create a bug|Yes|  
    |Create environment snapshot of the servers in [an SCVMM lab environment](../test/scvmm--virtual--environments.md).|Yes|  
  
## Security  
 Verify that the share location where the .appx file and certificates are stored is properly secured.