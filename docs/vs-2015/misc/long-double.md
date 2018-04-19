---
title: "Long Double | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "c.types"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "8-byte long double"
  - "16-bit Windows"
  - "80-bit precision"
  - "32-bit Windows"
  - "long double"
  - "10 byte long double"
  - "8 byte long double"
  - "80 bit precision"
ms.assetid: bb581e20-b5c2-4079-8ee8-ac6739a37852
caps.latest.revision: 8
author: "corob-msft"
ms.author: "corob"
manager: "ghogen"
---
# Long Double
Previous 16-bit versions of Microsoft C/C++ and Microsoft Visual C++ supported the `long double`, 80-bit precision data type. In Win32 programming, however, the `long double` data type maps to the `double`, 64-bit precision data type. The Microsoft run-time library provides `long double` versions of the math functions only for backward compatibility. The `long double` function prototypes are identical to the prototypes for their `double` counterparts, except that the `long``double` data type replaces the `double` data type. The `long double` versions of these functions should not be used in new code.  
  
### Double Functions and Their Long Double Counterparts  
  
|Function|Long double<br /><br /> counterpart|Function|Long double<br /><br /> counterpart|  
|--------------|---------------------------------|--------------|---------------------------------|  
|[acos](http://msdn.microsoft.com/library/00b89c48-8faf-4824-aa95-fa4349a4975d)|`acosl`|[frexp](http://msdn.microsoft.com/library/9b020f2e-3967-45ec-a6a8-d467a071aa55)|`frexpl`|  
|[asin](http://msdn.microsoft.com/library/ca05f9ea-b711-49f6-9f32-2f4019abfd69)|`asinl`|[_hypot](http://msdn.microsoft.com/library/6a13887f-bd53-43fc-9d77-5b42d6e49925)|`_hypotl`|  
|[atan](http://msdn.microsoft.com/library/7a87a18e-c94d-4727-9cb1-1bb5c2725ae4)|`atanl`|[ldexp](http://msdn.microsoft.com/library/aa7f5310-3879-4f63-ae74-86a39fbdedfa)|`ldexpl`|  
|[atan2](http://msdn.microsoft.com/library/7a87a18e-c94d-4727-9cb1-1bb5c2725ae4)|`atan2l`|[log](http://msdn.microsoft.com/library/7adc77c2-04f7-4245-a980-21215563cfae)|`logl`|  
|[atof](http://msdn.microsoft.com/library/eb513241-c9a9-4f5c-b7e7-a49b14abfb75)|`_atold`|[log10](http://msdn.microsoft.com/library/7adc77c2-04f7-4245-a980-21215563cfae)|`log10l`|  
|[Bessel functions j0, j1, jn](../misc/bessel-functions-j0-j1-jn.md)|`j0l, j1l, jnl`|[_matherr](http://msdn.microsoft.com/library/b600d66e-165a-4608-a856-8fb418d46760)|`_matherrl`|  
|[Bessel functions y0, y1, yn](http://msdn.microsoft.com/library/96581b10-7ef1-43c5-80c0-5622b2d97bbe)|`y0l, y1l, ynl`|[modf](http://msdn.microsoft.com/library/b1c7abf5-d476-43ca-a03c-02072a86e32d)|`modfl`|  
|[_cabs](http://msdn.microsoft.com/library/fea292ee-1a39-4a0a-b416-4a189346ff26)|`_cabsl`|[pow](http://msdn.microsoft.com/library/e75c33ed-2e59-48b1-be40-81da917324f1)|`powl`|  
|[ceil](http://msdn.microsoft.com/library/f4e5acab-5c8f-4b10-9ae2-9561e6453718)|`ceill`|[sin](http://msdn.microsoft.com/library/737de73e-3590-45f9-8257-dc1c0c489dfc)|`sinl`|  
|[cos](http://msdn.microsoft.com/library/ae90435e-6b68-4a47-a81f-be87d5c08f16)|`cosl`|[sinh](http://msdn.microsoft.com/library/737de73e-3590-45f9-8257-dc1c0c489dfc)|`sinhl`|  
|[cosh](http://msdn.microsoft.com/library/ae90435e-6b68-4a47-a81f-be87d5c08f16)|`coshl`|[sqrt](http://msdn.microsoft.com/library/2ba9467b-f172-41dc-8f10-b86f68fa813c)|`sqrtl`|  
|[exp](http://msdn.microsoft.com/library/7070016d-1143-407e-9e9a-6b059bb88867)|`expl`|[strtod](http://msdn.microsoft.com/library/0444f74a-ba2a-4973-b7f0-1d77ba88c6ed)|`_strtold`|  
|[fabs](http://msdn.microsoft.com/library/23bca210-f408-4f5e-b46b-0ccaaec31e36)|`fabsl`|[tan](http://msdn.microsoft.com/library/36cc0ce8-9c80-4653-b354-ddb3b378b6bd)|`tanl`|  
|[floor](http://msdn.microsoft.com/library/e9955f70-d659-414f-8050-132e13c8ff36)|`floorl`|[tanh](http://msdn.microsoft.com/library/36cc0ce8-9c80-4653-b354-ddb3b378b6bd)|`tanhl`|  
|[fmod](http://msdn.microsoft.com/library/6962d369-d11f-40b1-a6d7-6f67239f8a23)|`fmodl`|||  
  
## See Also  
 [Run-Time Routines by Category](http://msdn.microsoft.com/library/de6f5ac4-2226-4dad-be9f-deeb31138c9d)