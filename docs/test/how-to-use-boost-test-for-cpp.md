---
title: "How to use Boost.Test for C++ in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/07/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2e0710a8-8e8a-4f6e-8415-5ab3eb830079
caps.latest.revision: 14
ms.author: mblome
manager: ghogen
---

# How to use Boost.Test for C++ in Visual Studio
In **Visual Studio 2017 version 15.5** and later, Boost.Test is integrated into the Visual Studio IDE as a component of the **Desktop Develoment with C++** workload. To install it on your machine, open the Visual Studio Installer and find **Boost.Test Adapter** under the list of workload components:

![Install Boost Test](media/cpp-boost-component.png "Install Boost.Test for C++")

## Install Boost

 Boost.Test requires [Boost](http://www.boost.org/)! If you do not have Boost installed, we recommend that you use the Vcpkg package manager. 

1. Follow the instructions at [Vcpkg: a C++ Package Manager for Windows](/cpp/vcpkg) to install vcpkg (if you don't already have it) and then use it to install the Boost libraries.
2. Run the `vcpkg integrate install` command to configure Visual Studio with the library and include paths to the Boost headers and binaries. 

## Create a project for your tests
**Visual Studio 2017 version 15.5** No project or item templates are currently available for Boost.Test. Templates are planned for inclusion in a future version of Visual Studio.

1. In **Solution Explorer**, right click on the solution node and choose **Add | New Project**. 
2. In the left pane, choose **Windows Desktop** and then choose **Windows Console Application** in the center pane. 
3. Give the project a name and click **OK**. 

## Add include directives
In your test .cpp file, add any needed `#include` directives to make your program's types and functions visible to the test code. Typically, the program is up one level in the folder hierarchy. If you type `#include "../"`
an IntelliSense window will appear and enable you to select the full path to the header file.

![Add #include directives](media/cpp-gtest-includes.png "Add include directives to the test .cpp file")

At a minimum you need to include `unit_test.hpp` and define `BOOST_TEST_MODULE`. The following example is sufficient for the test to be discoverable in **Test Explorer**:

```cpp
#include "stdafx.h"
#define BOOST_TEST_MODULE MyTest
#include <boost/test/included/unit_test.hpp>
#include "../utils/utils.h" // project being tested
#include <string>

BOOST_AUTO_TEST_CASE(my_boost_test)
{
	md_utils mdu;
	std::string s("foo");
	BOOST_CHECK(mdu.get_title(s).length() > 0);
}
```

## Write and run tests
You are now ready to write and run Boost Tests. See the [Boost Test Library Documentation](http://www.boost.org/doc/libs/1_38_0/libs/test/doc/html/index.html) for information about the test macros. See [Run unit tests with Test Explorer](run-unit-tests-with-test-explorer.md) for information about discovering, running, and grouping your tests by using **Test Explorer**.

## See Also
[Writing Unit Tests for C/C++](writing-unit-tests-for-c-cpp.md)


  







