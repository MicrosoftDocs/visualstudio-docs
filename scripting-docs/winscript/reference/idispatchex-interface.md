---
title: "IDispatchEx Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDispatchEx interface, about IDispatchEx"
  - "IDispatchEx interface"
ms.assetid: 37a3303f-f78e-4b5b-aac8-b836c92819de
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispatchEx Interface
`IDispatchEx`, an extension of the `IDispatch` interface, supports features appropriate for dynamic languages such as scripting languages. This section describes the `IDispatchEx` interface itself, the differences between `IDispatch` and `IDispatchEx`, and the rationale for the extensions. It is expected that readers are familiar with `IDispatch` and have access to the `IDispatch` documentation.  
  
## Remarks  
 `IDispatch` was developed essentially for Microsoft Visual Basic. The primary limitation of `IDispatch` is that it assumes that objects are static. In other words, since objects do not change during run time, type information can fully describe them at compile time. Dynamic run-time models that are found in scripting languages such as Visual Basic Scripting Edition (VBScript) and [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] and object models such as Dynamic HTML require a more flexible interface.  
  
 `IDispatchEx` was developed to provide all the services of `IDispatch` as well as some extensions that are appropriate for more dynamic late-bound languages such as scripting languages. The additional features of `IDispatchEx` beyond those provided by `IDispatch` are:  
  
- Add new members to an object ("expando")—use `GetDispID` with the `fdexNameEnsure` flag.  
  
- Delete members of an object—use `DeleteMemberByName` or `DeleteMemberByDispID`.  
  
- Case-sensitive dispatch operations—use `fdexNameCaseSensitive` or `fdexNameCaseInsensitive`.  
  
- Search for member with implicit name—use `fdexNameImplicit`.  
  
- Enumerate DISPIDs of an object—use `GetNextDispID`.  
  
- Map from DISPID to element name—use `GetMemberName`.  
  
- Obtain properties of object members—use `GetMemberProperties`.  
  
- Method invocation with `this` pointer—use `InvokeEx` with DISPATCH_METHOD.  
  
- Allow browsers that support the concept of name spaces to obtain the name space parent of an object—use `GetNameSpaceParent`.  
  
  Objects that support `IDispatchEx` might also support `IDispatch` for backward compatibility. The dynamic nature of objects that support `IDispatchEx` has a few implications for the `IDispatch` interface of those objects. For example, `IDispatch` makes the following assumption:  
  
- The member and parameter DISPIDs must remain constant for the lifetime of the object. This allows a client to obtain DISPIDs once and cache them for later use.  
  
  Since `IDispatchEx` allows the addition and deletion of members, the set of valid DISPIDs does not remain constant. However, `IDispatchEx` requires that the mapping between DISPID and member name remain constant. This means that if a member is deleted:  
  
- The DISPID cannot be reused until a member with the same name is created.  
  
- The DISPID must remain valid for `GetNextDispID`.  
  
- The DISPID must be accepted gracefully by any of the `IDispatch` or `IDispatchEx` methods—they must recognize the member as deleted and return an appropriate error code (usually DISP_E_MEMBERNOTFOUND or S_FALSE).  
  
## Examples  
 This [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code in the function test() does the following:  
  
- Creates a new object by calling the `Object` constructor and assigns a pointer to the new object to the variable Obj.  
  
- Creates a new element named Elem in the object and assigns to this element a pointer to the function cat.  
  
- Calls this function. Since it is being called as a method, the `this` pointer refers to the object Obj. The function adds a new element, Bar, to the object.  
  
  The full HTML code is:  
  
```html
<html>  
<body>  
<script type="text/javascript">  
function cat()  
{  
   // Create new element and assign the value 10  
   this.Bar = 10;  
}  
  
function test()  
{  
   // Construct new object  
   Obj = new Object();  
  
   // Create new element and assign function pointer  
   Obj.Elem = cat;  
  
   // Call Elem method ("this" == Obj)  
   Obj.Elem();  
  
   // Obj.Bar now exists  
}  
test();  
</script>  
</body>  
</html>  
```  
  
 A control placed on this same Web page could obtain a dispatch pointer to the script engines from the browser. The control could then implement the function test():  
  
```html
<html>  
<body>  
<script type="text/javascript">  
function cat()  
{  
   // Create new element and assign the value 10  
   this.Bar = 10;  
}  
</script>  
<object id="test" <CLASSID="CLSID:9417DB5D-FA2A-11D0-8CB3-00C04FC2B085">>  
</object>  
</body>  
</html>  
```  
  
 Code from the control, test, does the same thing as the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] function `test()`. Note that these dispatch calls are made into the running [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] engine and change the state of the engine:  
  
- Obtains the dispatch pointer to the cat function using `GetDispID()`.  
  
- Obtains the dispatch pointer to the Object function using `GetDispID()`.  
  
- Constructs an object by calling the Object function with `InvokeEx()` and obtains a dispatch pointer to the newly constructed object.  
  
- Creates a new element, Elem, in the object using `GetDispID()` with the `fdexNameEnsure` flag.  
  
- Puts the dispatch pointer to cat in the element using `InvokeEx()`.  
  
- Calls the dispatch pointer to cat as a method by calling `InvokeEx()` and passing in the dispatch pointer to the constructed object as the `this` pointer.  
  
- The cat method creates a new element, Bar, on the current `this` object.  
  
- Verifies that the new element, Bar, was created in the constructed object by enumerating through the elements using `GetNextDispID()`.  
  
  The code for the test control:  
  
```cpp
   BOOL test(IDispatchEx *pdexScript)  
   {  
      HRESULT hr;  
      VARIANT var;  
      DISPID dispid, putid;  
      BOOL retval = FALSE;  
      BSTR bstrName = NULL;  
      IDispatch   *pdispObj = NULL, *pdispCat = NULL;  
      IDispatchEx *pdexObj = NULL;  
      DISPPARAMS dispparams, dispparamsNoArgs = {NULL, NULL, 0, 0};  
  
      // Get dispatch pointer for "cat"  
      bstrName = SysAllocString(OLESTR("cat"));  
         if (bstrName == NULL) goto LDone;  
      hr = pdexScript->GetDispID(bstrName, 0, &dispid);  
         if (FAILED(hr)) goto LDone;  
      SysFreeString(bstrName);  
         bstrName = NULL;  
      hr = pdexScript->InvokeEx(dispid, LOCALE_USER_DEFAULT,   
         DISPATCH_PROPERTYGET, &dispparamsNoArgs,   
         &var, NULL, NULL);  
         if (FAILED(hr)) goto LDone;  
      pdispCat = var.pdispVal;  
  
      // Create object by calling "Object" constructor  
      bstrName = SysAllocString(OLESTR("Object"));  
         if (NULL == bstrName) goto LDone;  
      hr = pdexScript->GetDispID(bstrName, 0, &dispid);  
         if (FAILED(hr)) goto LDone;  
      SysFreeString(bstrName);  
         bstrName = NULL;  
      hr = pdexScript->InvokeEx(dispid, LOCALE_USER_DEFAULT,   
         DISPATCH_CONSTRUCT, &dispparamsNoArgs,   
         &var, NULL, NULL);  
         if (FAILED(hr)) goto LDone;  
      pdispObj = var.pdispVal;  
      hr = pdispObj->QueryInterface(IID_IDispatchEx, (void **)&pdexObj);  
         if (FAILED(hr)) goto LDone;  
  
      // Create new element in object  
      bstrName = SysAllocString(OLESTR("Elem"));  
         if (NULL == bstrName) goto LDone;  
      hr = pdexObj->GetDispID(bstrName, fdexNameEnsure, &dispid);  
         if (FAILED(hr)) goto LDone;  
      SysFreeString(bstrName);  
         bstrName = NULL;  
  
      // Assign "cat" dispatch pointer to element  
      putid = DISPID_PROPERTYPUT;  
      var.vt = VT_DISPATCH;  
      var.pdispVal = pdispCat;  
      dispparams.rgvarg = &var;  
      dispparams.rgdispidNamedArgs = &putid;  
      dispparams.cArgs = 1;  
      dispparams.cNamedArgs = 1;  
      hr = pdexObj->InvokeEx(dispid, LOCALE_USER_DEFAULT,   
         DISPATCH_PROPERTYPUTREF, &dispparams,  
         NULL, NULL, NULL);  
         if (FAILED(hr)) goto LDone;  
  
      // Invoke method with "this" pointer  
      putid = DISPID_THIS;  
      var.vt = VT_DISPATCH;  
      var.pdispVal = pdispObj;  
      dispparams.rgvarg = &var;  
      dispparams.rgdispidNamedArgs = &putid;  
      dispparams.cArgs = 1;  
      dispparams.cNamedArgs = 1;  
      hr = pdexObj->InvokeEx(dispid, LOCALE_USER_DEFAULT,  
         DISPATCH_METHOD, &dispparams,  
            NULL, NULL, NULL);  
         if (FAILED(hr)) goto LDone;  
  
      // Confirm that new element "Bar" is in object  
      hr = pdexObj->GetNextDispID(fdexEnumAll, DISPID_STARTENUM, &dispid);  
      while (hr == NOERROR)  
      {  
            hr = pdexObj->GetMemberName(dispid, &bstrName);  
            if (FAILED(hr)) goto LDone;  
            retval = !wcscmp(bstrName, OLESTR("Bar"));  
            SysFreeString(bstrName);  
            bstrName = NULL;  
            if (retval) goto LDone;  
         hr = pdexObj->GetNextDispID(fdexEnumAll, dispid, &dispid);  
      }  
LDone:  
   SysFreeString(bstrName);  
   if (pdispCat != NULL)  
      pdispCat->Release();  
   if (pdispObj != NULL)  
      pdispObj->Release();  
   if (pdexObj != NULL)  
      pdexObj->Release();  
  
   return retval;  
   }  
```  
  
## Methods  
 [IDispatchEx Methods](../../winscript/reference/idispatchex-methods.md)