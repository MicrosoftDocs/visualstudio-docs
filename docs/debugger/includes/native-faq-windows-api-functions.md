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
To set a breakpoint on a Windows API function with NT symbols loaded:

- In the [function breakpoint](../debugger/using-breakpoints.md#BKMK_Set_a_breakpoint_in_a_source_file), enter the function name together with the name of the DLL where the function resides (see the [context operator](../debugger/context-operator-cpp.md)). In 32-bit code, use the decorated form of the function name. To set a breakpoint on **MessageBeep**, for example, you must enter the following.

  ```cpp
  {,,USER32.DLL}_MessageBeep@4
  ```

  To obtain the decorated name, see [Viewing Decorated Names](/previous-versions/5x49w699(v=vs.140)).

  You can test the decorated name and view it in disassembly code. While paused at the function in the Visual Studio debugger, right-click the function in the code editor or call stack window and choose **Go to Disassembly**.

- In 64-bit code, you can use the undecorated name.

  ```cpp
  {,,USER32.DLL}MessageBeep
  ```
