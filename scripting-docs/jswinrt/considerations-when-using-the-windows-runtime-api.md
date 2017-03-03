---
title: "Considerations when Using the Windows Runtime API | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "JavaScript, Windows Runtime API"
ms.assetid: 2f56d70c-c80d-4876-8e6a-8ae031d31c22
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Considerations when Using the Windows Runtime API
You can use nearly every element of the Windows Runtime API in JavaScript. However, there are some aspects of the JavaScript representation of Windows Runtime elements that you should keep in mind.  
  
> [!IMPORTANT]
>  For information about creating Windows Runtime components in C++, C#, or Visual Basic and consuming them in JavaScript, see [Creating Windows Runtime Components](../Topic/Creating%20Windows%20Runtime%20Components.md).  
  
## Special Cases in the JavaScript Representation of Windows Runtime Types  
  
-   Strings: An uninitialized string is passed to a Windows Runtime method as the string "undefined", and a string set to `null` is passed as the string "null". (This is true whenever a `null` or `undefined` value is coerced to a string.) Before you pass a string to a Windows Runtime method, you should initialize it as the empty string ("").  
  
-   Interfaces: You cannot implement a Windows Runtime interface in JavaScript.  
  
-   Arrays: Windows Runtime arrays are not resizable, so methods that resize arrays in JavaScript do not work on Windows Runtime arrays.  
  
-   Arrays: If you pass a JavaScript array value to a Windows Runtime method, the array is copied. The Windows Runtime method is not able to modify the array or its members and return it to your JavaScript app. However, you can use typed arrays (for example, [Int32Array Object](../javascript/reference/int32array-object.md)), which are not copied.  
  
-   Structures: Windows Runtime structures are objects in JavaScript. If you want to pass a Windows Runtime structure to a Windows Runtime method, don't instantiate the structure with the `new` keyword. Instead, create an object and add the relevant members and their values. The names of the members should be in camel case: `SomeStruct.firstMember`.  
  
-   Objects: JavaScript objects aren't the same as managed code objects (`System.Object`). You can't pass a JavaScript object to a Windows Runtime method that requires a `System.Object`.  
  
-   Object identity: In most cases, the objects passed back and forth between the Windows Runtime and JavaScript do not change. The JavaScript engine maintains a map of known objects. When an object is returned from the Windows Runtime it is matched against the map, and if it does not exist a new object is created. The same procedure is followed for objects that represent interfaces that are returned by Windows Runtime methods. There are two kinds of exceptions:  
  
    -   Objects that are returned from a Windows Runtime call, and then have new (expando) properties added, don't retain their new properties when they are passed back to the Windows Runtime. However, when they are returned to the JavaScript app, because they're matched to the existing object, the returned object does have the expando properties.  
  
    -   Structures and delegates in Windows Runtime can't be identified as identical to previously-used structures or delegates. Every time a structure or delegate is returned, it gets a new reference.  
  
-   Name collisions: Multiple Windows Runtime interfaces may have members with the same names. If they are combined in a single JavaScript object (which can be a representation of a runtime class or an interface), the members are represented with fully-qualified names. You can call these members by using the following syntax: `Class["MemberName"](parameter)`.  
  
     In the following code, two interfaces have a Draw method, and a runtime class implements both interfaces.  
  
    ```cpp#  
    namespace CollisionExample {  
        interface InterfaceA  
        {  
            HRESULT Draw([in] Int32 a);  
        }  
        interface InterfaceB  
        {  
            HRESULT Draw([in] HString a);  
        }  
        runtimeclass ExampleObject {  
          interface InterfaceA  
          interface InterfaceB  
        }  
    }  
    ```  
  
     Here is how you can call the above code in JavaScript.  
  
    ```javascript  
    var example = new ExampleObject();  
    example["CollisionExample.InterfaceA.draw"](12);  
    example["CollisionExample.InterfaceB.draw"]("hello");  
    ```  
  
-   `Out` parameters: If a Windows Runtime method has multiple `out` parameters, in JavaScript the method has a JavaScript object as its return value, and the object has properties that correspond to the `out` parameter. For example, consider the following Windows Runtime signature in C++.  
  
    ```cpp#  
    void ExampleMethod(  
      [OutAttribute] char^ first,   
      [OutAttribute] char^ second  
    )  
    ```  
  
     The JavaScript version of this signature is:  
  
    ```javascript  
    var returnValue = exampleMethod();  
  
    ```  
  
     In this example, `returnValue` is a JavaScript object that has two fields: `first` and `second`.  
  
-   Static members: The Windows Runtime defines both static members and instance members. In JavaScript, static members are added to the object that is associated with the Windows Runtime class or interface.  
  
    ```javascript  
    // Static method.   
    var accel = Windows.Devices.Sensors.Accelerometer.getDefault();   
    // Instance method.   
    var reading = accel.getCurrentReading();            
    ```  
  
 For more information about the JavaScript representation of Windows Runtime basic types, see [JavaScript Representation of Windows Runtime Types](../jswinrt/javascript-representation-of-windows-runtime-types.md).