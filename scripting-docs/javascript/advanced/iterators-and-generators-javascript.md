---
title: "Iterators and Generators (JavaScript) | Microsoft Docs"
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
ms.assetid: 68ef5b2f-0349-492b-b557-73ff2a2f90cf
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Iterators and Generators (JavaScript)
An iterator is an object that is used to traverse a container object like a list. In JavaScript, an iterator object is not a distinct built-in object, but is an object that implements a `next` method to access the next item in the container object.  
  
 In [!INCLUDE[jsv12text](../../javascript/includes/jsv12text-md.md)], you can create your own custom iterators. However, it is generally much easier to use generators, which greatly simplify the creation of iterators. Generators are a type of function that is a factory for iterators. To create a custom iterator using a generator function, see [Generators](#Generators).  
  
> [!CAUTION]
>  Generators are supported in [!INCLUDE[jsv12textExp](../../javascript/includes/jsv12textexp-md.md)].  
  
## Iterators  
 The implementation of a JavaScript iterator involves two or three objects that conform to specific interfaces:  
  
-   Iterable interface  
  
-   Iterator interface  
  
-   IteratorResult interface  
  
 By using these interfaces, you can create custom iterators. This allows you to traverse an iterable object using the `for…of` statement.  
  
### Iterable interface  
 The Iterable interface is the required interface for an iterable object (an object for which an iterator can be obtained). For example, `C` in `for (let e of C)` must implement the Iterable interface.  
  
 An iterable object must provide the Symbol.iterator method, which returns an iterator.  
  
```JavaScript  
obj[Symbol.iterator] = function() { return iterObj; }  
```  
  
 This property must be a function that accepts no arguments and returns an object (`iterObject`) that conforms to the `Iterator` interface.  
  
 Many built-in types, including arrays, are now iterable. The `for…of` loop consumes an iterable object. (However, not all built-in iterables are iterators. For example, an Array object is not an iterator itself, but it is iterable, whereas an ArrayIterator is also iterable.)  
  
### Iterator interface  
 The object returned by the Symbol.iterator method must implement the `next` method. The `next` method has the following syntax.  
  
```JavaScript  
iterObj.next() = function() { return iterResultObj; };  
```  
  
 The `next` method is a function that returns a value. The function returns an object (`iterResultObj`) that conforms to the `IteratorResult` interface. If a previous call to the `next` method of an iterator returned an `IteratorResult` object whose `done` property is true, then iteration is terminated and the `next` method is not called again.  
  
 Iterators may also include a `return` method to ensure that the iterator is disposed properly when the script is finished with it.  
  
### IteratorResult interface  
 The IteratorResult interface is the required interface for the result of the `next` method on an iterator. The object returned by `next` must provide a `done` and `value` property.  
  
```JavaScript  
var iterResultObj = { done: true|false, value: value }  
```  
  
 The `done` property returns the status of an iterator's `next` method call, either true or false. If the end of the iterator was reached, `done` returns true. If the end was not reached, `done` returns false and a value is available. If the `done` property (either its own or an inherited property) does not exist, the result of `done` is treated as false.  
  
 If `done` is false, the `value` property returns the current iteration element value. If `done` is true, this is the return value of the iterator, if a return value is provided. If the iterator does not have a return value, `value` is undefined. In that case, the `value` property may be absent from the conforming object if it does not inherit an explicit value property.  
  
<a name="Generators"></a>   
## Generators  
 To easily create and use custom iterators, create a generator function by using the function* syntax along with one or more `yield` expressions. The generator function returns an iterator (that is, a generator), which enables the generator function body to execute. The function executes to the next `yield` or `return` statement.  
  
 Call the `next` method of the iterator to return the next value from the generator function.  
  
 The following example shows a generator that returns an iterator for a string object.  
  
```JavaScript  
function* stringIter() {  
    var str = "bobsyouruncle";  
    var idx = 0;  
    while(idx < str.length)  
        yield str[idx++];  
}  
  
var si = stringIter();  
  
console.log(si.next().value);  
console.log(si.next().value);  
console.log(si.next().value);  
  
// Output:  
// b  
// o  
// b  
  
```  
  
 In a generator, the yield operand expression terminates the call to `next` and returns an `IteratorResult` object with two properties, `done` (`done=false`) and `value` (`value=operand`). `operand` is optional and if left absent then its value is undefined.  
  
 In a generator, a `return` statement terminates the generator by returning an `IteratorResult` with `done=true` along with the optional operand result for the value property.  
  
 You can also use a `yield*` expression in place of `yield` to delegate to another generator or to another iterable object, such as an array or string.  
  
 If you append the following code to the preceding example, `yield*` delegates to the `stringIter` generator.  
  
```JavaScript  
function* strIter() {  
    yield "jo";  
    yield* stringIter();  
}  
  
var si2 = strIter();  
  
console.log(si2.next().value);  
console.log(si2.next().value);  
console.log(si2.next().value);  
console.log(si2.next().value);  
  
// Output:  
// jo  
// b  
// o  
// b  
```  
  
 You can also create more advanced generators by passing an argument to `next` and using the argument to modify the state of the generator. `next` becomes the result value of the previously executed `yield` expression. In the following example, when you pass a value of 100 to the `next` method, you reset the generator’s internal index value.  
  
```  
function* strIter() {  
    var str = "jobob";  
    var idx = 0;  
    while(idx < str.length) {  
        var modify = yield str[idx++];  
        if(modify == 100) {  
            idx = 0;  
        }  
    }
}
  
var si3 = strIter();  
  
console.log(si3.next().value);  
console.log(si3.next().value);  
console.log(si3.next().value);  
console.log(si3.next(100).value);  
  
// Output:  
// j  
// o  
// b  
// j  
  
```  
  
 Other advanced generators may call the generator’s `throw` method. The thrown error appears to get thrown at the point where the generator is paused (before the next `yield` statement).
