 // For an introduction to the Blank template, see the following documentation:  
// http://go.microsoft.com/fwlink/?LinkId=232509  
(function () {  
    "use strict";  
  
    var app = WinJS.Application;  
  
    app.onactivated = function (eventObject) {  
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {  
            if (eventObject.detail.previousExecutionState !== Windows.ApplicationModel.Activation.ApplicationExecutionState.terminated) {  
                // TODO: This application has been newly launched. Initialize   
                // your application here.  
            } else {  
                // TODO: This application has been reactivated from suspension.   
                // Restore application state here.  
            }  
            WinJS.UI.processAll();  
  
        }  
    };  
  
    app.oncheckpoint = function (eventObject) {  
        // TODO: This application is about to be suspended. Save any state  
        // that needs to persist across suspensions here. You might use the   
        // WinJS.Application.sessionState object, which is automatically  
        // saved and restored across suspension. If you need to complete an  
        // asynchronous operation before your application is suspended, call  
        // eventObject.setPromise().   
    };  
  
    app.start();  
    var callTrack = "module function";  
    example1();  
  
    function example1()  
    {  
        var a = 1;  
        var b = 2;  
        callTrack += "->example1";  
        return a + b;  
    }  
  
    function example2()  
    {  
        var a = 3;  
        callTrack += "->example2 ";  
        var x = example2_a();  
        var y = example2_a();  
        var z = example2_b();  
    }  
  
    function example2_a()  
    {  
        var b = 3;  
        callTrack += "->example2_a ";  
        return b;  
    }  
  
    function example2_b()  
    {  
        var c = 3;  
        callTrack += "->example2_b ";  
        return c;  
    }  
  
    function example3() {  
        var s = "";  
        for (var i = 0; i < 1000; i++) {  
            s += i.toString() + "\n";  
        }  
        callTrack += "->example3 ";  
        return 1;  
  
    }  
  
    function example4() {  
        var b = 4;  
        var a = example4_a(2);  
        callTrack += "->example4";  
        var multiplyByA = multiClosure(a);  
        a = 20;  
        var x = multiplyByA(b);  
        return x;  
    }  
  
    function example4_a(x) {  
        var y = 2;  
        return x + y;  
    }  
  
    function multiClosure(num) {  
        var a = num;  
        function multiplyXby(b) {  
            callTrack += "->multiplyXby";  
            return a * b;  
        }  
        return multiplyXby;  
    }  
  
    function example5() {  
         var a = 1;  
         callTrack += "->example5";  
         a += example5_a();  
         return a;  
     }  
  
     function example5_a() {  
         var a = 1;  
         callTrack += "->example5_a";  
         a += example5_b();  
         return a;  
     }  
  
     function example5_b() {  
         var a = 1;  
         callTrack += "->example5_b";  
         a += example5_c();  
         return a;  
     }  
  
     function example5_c() {  
         var a = 1;  
         callTrack += "->example5_c";  
         a += example5_d();  
         return a;  
     }  
  
     function example5_d() {  
         var a = 1;  
         callTrack += "->example5_d";  
         a += example5_e();  
         return a;  
     }  
  
     function example5_e() {  
         var a = 1;  
         callTrack += "->example5_e";  
         return a;  
     }  
  
 })();