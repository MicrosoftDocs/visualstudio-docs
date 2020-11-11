---
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

You should be able to debug your code with the symbols you generate on the Visual Studio computer. The performance of the remote debugger is much better when you use local symbols.  If you must   use remote symbols, you need to tell the remote debugging monitor to look for symbols on the remote machine.  

Starting in Visual Studio 2013 Update 2, you can use the following msvsmon command-line switch to use remote symbols for managed code: `Msvsmon /FallbackLoadRemoteManagedPdbs`  

For more information, please see the remote debugging help (press **F1** in the remote debugger window, or click **Help > Usage**). You can find more information at [.NET Remote Symbol Loading Changes in Visual Studio 2012 and 2013](https://devblogs.microsoft.com/devops/net-remote-symbol-loading-changes-in-visual-studio-2012-and-2013/)
