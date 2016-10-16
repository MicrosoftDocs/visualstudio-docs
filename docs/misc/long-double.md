---
title: "Long Double"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
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
ms.author: "corob"
manager: "ghogen"
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
# Long Double
Previous 16-bit versions of Microsoft C/C++ and Microsoft Visual C++ supported the `long double`, 80-bit precision data type. In Win32 programming, however, the `long double` data type maps to the `double`, 64-bit precision data type. The Microsoft run-time library provides `long double` versions of the math functions only for backward compatibility. The `long double` function prototypes are identical to the prototypes for their `double` counterparts, except that the `long``double` data type replaces the `double` data type. The `long double` versions of these functions should not be used in new code.  
  
### Double Functions and Their Long Double Counterparts  
  
|Function|Long double<br /><br /> counterpart|Function|Long double<br /><br /> counterpart|  
|--------------|---------------------------------|--------------|---------------------------------|  
|[acos](../Topic/acos,%20acosf,%20acosl.md)|`acosl`|[frexp](../Topic/frexp.md)|`frexpl`|  
|[asin](../Topic/asin,%20asinf,%20asinl.md)|`asinl`|[_hypot](../Topic/hypot,%20hypotf,%20hypotl,%20_hypot,%20_hypotf,%20_hypotl.md)|`_hypotl`|  
|[atan](../Topic/atan,%20atanf,%20atanl,%20atan2,%20atan2f,%20atan2l.md)|`atanl`|[ldexp](../Topic/ldexp.md)|`ldexpl`|  
|[atan2](../Topic/atan,%20atanf,%20atanl,%20atan2,%20atan2f,%20atan2l.md)|`atan2l`|[log](../Topic/log,%20logf,%20log10,%20log10f.md)|`logl`|  
|[atof](../Topic/atof,%20_atof_l,%20_wtof,%20_wtof_l.md)|`_atold`|[log10](../Topic/log,%20logf,%20log10,%20log10f.md)|`log10l`|  
|[Bessel functions j0, j1, jn](../misc/bessel-functions--_j0--_j1--_jn.md)|`j0l, j1l, jnl`|[_matherr](../Topic/_matherr.md)|`_matherrl`|  
|[Bessel functions y0, y1, yn](../Topic/Bessel%20Functions:%20_y0,%20_y1,%20_yn.md)|`y0l, y1l, ynl`|[modf](../Topic/modf,%20modff,%20modfl.md)|`modfl`|  
|[_cabs](../Topic/_cabs.md)|`_cabsl`|[pow](../Topic/pow,%20powf,%20powl.md)|`powl`|  
|[ceil](../Topic/ceil,%20ceilf,%20ceill.md)|`ceill`|[sin](../Topic/sin,%20sinf,%20sinl,%20sinh,%20sinhf,%20sinhl.md)|`sinl`|  
|[cos](../Topic/cos,%20cosf,%20cosl,%20cosh,%20coshf,%20coshl.md)|`cosl`|[sinh](../Topic/sin,%20sinf,%20sinl,%20sinh,%20sinhf,%20sinhl.md)|`sinhl`|  
|[cosh](../Topic/cos,%20cosf,%20cosl,%20cosh,%20coshf,%20coshl.md)|`coshl`|[sqrt](../Topic/sqrt,%20sqrtf,%20sqrtl.md)|`sqrtl`|  
|[exp](../Topic/exp,%20expf.md)|`expl`|[strtod](../Topic/strtod,%20_strtod_l,%20wcstod,%20_wcstod_l.md)|`_strtold`|  
|[fabs](../Topic/fabs,%20fabsf,%20fabsl.md)|`fabsl`|[tan](../Topic/tan,%20tanf,%20tanl,%20tanh,%20tanhf,%20tanhl.md)|`tanl`|  
|[floor](../Topic/floor,%20floorf,%20floorl.md)|`floorl`|[tanh](../Topic/tan,%20tanf,%20tanl,%20tanh,%20tanhf,%20tanhl.md)|`tanhl`|  
|[fmod](../Topic/fmod,%20fmodf.md)|`fmodl`|||  
  
## See Also  
 [Run-Time Routines by Category](../Topic/Run-Time%20Routines%20by%20Category.md)