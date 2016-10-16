---
title: "How to: Install a Custom Diagnostic Data Adapter"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Diagnostic Data Adapter, installing"
ms.assetid: 907e65d8-0408-44b3-9e5e-e631892c1726
caps.latest.revision: 34
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
# How to: Install a Custom Diagnostic Data Adapter
If you have created a custom diagnostic data adapter, or you have been provided with a custom diagnostic data adapter to use, you can install your diagnostic data adapter assembly by copying the assembly file for it into the correct directory on your local machine.  
  
 If you want to use your custom diagnostic data adapter for a role in an environment, you must install your diagnostic data adapter on all the machines that run test agents that can be used for this role.  
  
 Use the following procedure to install your custom diagnostic adapter in the appropriate locations. You will need administrative permissions on any machine where you install the diagnostic data adapter.  
  
## Installing a Custom Diagnostic Data Adapter  
  
#### To install a custom diagnostic data adapter  
  
1.  To use the diagnostic data adapter when you run tests on your client machine or on an agent machine, copy all files from your build directory to the following directory on the target machine based on the installation path:  
  
     **Program Files\Microsoft Visual Studio 12.0\Common7\IDE\PrivateAssemblies\DataCollectors**  
  
     The files to copy are:  
  
    -   The diagnostic data adapter assembly (.dll) (required).  
  
    -   The debug data file (.pdb) for your adapter (optional).  
  
    -   The configuration file for your adapter (`<diagnostic data adapter name>.dll.config`), if you have default configuration settings (optional).  
  
    -   The configuration editor assembly if you have created one to edit configuration settings for the adapter (optional). This is only for client machines. Agent machines do not use the editor.  
  
    > [!NOTE]
    >  Although your diagnostic data adapter and your configuration editor can be created in the same project and built into the same assembly, you can use separate projects and create separate assemblies for them, if you prefer.  
  
     For more information about how to configure your test settings to use an environment when you run your tests, see [Collect more diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md) or [Create Test Settings for Automated System Tests Using Microsoft Test Manager](../test_notintoc/create-test-settings-for-automated-system-tests-using-microsoft-test-manager.md).  
  
2.  To select your diagnostic data adapter for a test, you must first select an existing test settings or create a new one from [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] or Visual Studio and then select your diagnostic data adapter on the **Data and Diagnostics** tab of the selected test settings.  
  
3.  If you have created and installed a diagnostic data adapter configuration editor, to configure your diagnostic data adapter for your test settings, choose **Configure** next to your adapter and make any changes. Then choose **Save**. For more information about how to create a configuration editor for your diagnostic data collector, see [How to: Create a Custom Editor for Data for Your Diagnostic Data Adapter](../test/how-to--create-a-custom-editor-for-data-for-your-diagnostic-data-adapter.md).  
  
4.  If you are running your tests from [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], you can assign these test settings to your test plan before you run your tests or use the **Run with Options** command to assign test settings and override test settings. For more information about test settings, see [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md).  
  
     If you are running your tests from Visual Studio, you must set these test settings to be active. For more information about test settings, see [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md).  
  
5.  Run your tests using the test settings with the diagnostic data adapter selected.  
  
## See Also  
 [How to: Create a Diagnostic Data Adapter](../test/how-to--create-a-diagnostic-data-adapter.md)   
 [How to: Create a Custom Editor for Data for Your Diagnostic Data Adapter](../test/how-to--create-a-custom-editor-for-data-for-your-diagnostic-data-adapter.md)   
 [Sample Project for Creating a Diagnostic Data Adapter](../test/sample-project-for-creating-a-diagnostic-data-adapter.md)   
 [Creating a Diagnostic Data Adapter to Collect Custom Data or Affect a Test Machine](../test/creating-a-diagnostic-data-adapter-to-collect-custom-data-or-affect-a-test-machine.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)