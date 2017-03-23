---
title: "Managing event listeners | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 87717f5d-b0c6-4c8d-a293-476002b7bfcf
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Managing event listeners
If the lifetime of a DOM element or object is different from the lifetime of its associated event listener, you might need to use the [removeEventListener](http://msdn.microsoft.com/library/ie/ff975250\(v=vs.85\).aspx)method to avoid memory leaks.  
  
## Event listeners and object scope  
 The following code example shows code that might result in a memory leak when the `dataObjFactory()` function is called. In this code, an event listener is registered for a data object each time a new data object is created. To make the current data object available in the `dataReady()` event handler, the [bind Method (Function)](../../javascript/reference/bind-method-function-javascript.md) is used in `addEventListener`.  
  
```JavaScript  
 var data;  
 var dataObj;  
  
 var dataReadyEvent = document.createEvent("Event");  
 dataReadyEvent.initEvent("dataReady", true, false);  
  
 function DataObject() {  
  
     this.name = "Data Object";  
     this.data = function () {  
         return data;  
     }  
     this.onDataCompleted = dataReady;  
     // this.handlerRef = this.onDataCompleted.bind(this);  
  
     // document.addEventListener('dataReady', this.handlerRef);  
     document.addEventListener('dataReady', this.onDataCompleted.bind(this));  
 }  
  
 // Runs when the data is available.  
 function dataReady() {  
     if (console && console.log) {  
         console.log("object value: " + this.name);  
         console.log("object value: " + this.data());  
     }  
 }  
  
setTimeout(function () {  
    // Generate data after a timeout period.  
    data = [0, 1, 2, 3];  
    document.dispatchEvent(dataReadyEvent);  
}, 10000);  
  
function dataObjFactory() {  
     for (var x = 0; x < 100; x++) {  
         if (dataObj) {  
             // The following line of code has no effect.  
             document.removeEventListener('dataReady', dataObj.onDataCompleted);  
             dataObj = null;  
         }  
         dataObj = new DataObject();  
     }  
 }  
  
 dataObjFactory();  
```  
  
 The listener for each data object is registered with the `document` object, which has a different lifetime than the data objects. The registered event listener for each data object prevents it from being garbage collected as long as the `document` object remains in scope. (In some modern JavaScript design patterns, the document object will remain in scope for the lifetime of the web app.) To prevent a memory leak, `removeEventListener` is called in the `dataObjFactory` function. However, this code fails because `removeEventListener` has not been called on the bound version of the event handler that is returned by the `bind`function.  
  
 To fix this code and make the data objects available for garbage collection, you must first store a reference to the bound version of the event handler, as shown in this code, and then pass the stored reference to `addEventListener`. Here's the corrected code for `DataObject`:  
  
```JavaScript  
function DataObject() {  
  
    this.name = "Data Object";  
    this.data = function () {  
        return data;  
    }  
    this.onDataCompleted = dataReady;  
    this.handlerRef = this.onDataCompleted.bind(this);  
  
    document.addEventListener('dataReady', this.handlerRef);  
    // document.addEventListener('dataReady', this.onDataCompleted.bind(this));  
}  
  
```  
  
 Finally, you need to call `removeEventListener` on the stored reference (`handlerRef`) of the bound function. Here's the corrected code for `dataObjFactory`:  
  
```JavaScript  
function dataObjFactory() {  
     for (var x = 0; x < 100; x++) {  
         if (dataObj) {  
             document.removeEventListener('dataReady', dataObj.handlerRef);  
         }  
         dataObj = new DataObject();  
     }  
 }  
  
```  
  
 Now the call to `removeEventListener` works, and the unneeded data objects can be garbage collected even while the `document` object remains in scope.