
<!DOCTYPE html>



  

<html class="no-js" lang="en-us" dir="ltr">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta property="og:title" content="Profiling in Visual Studio">
    <meta property="og:image" content="https://docs.microsoft.com/en-us/_themes/images/microsoft-header.png">
    
    <meta name="search.ms_sitename" content="Docs">
<meta name="search.ms_docsetname" content="prod-test">
<meta name="version" content="0">
<meta name="locale" content="en-us">
<meta name="site_name" content="Docs">
<meta name="search.ms_product" content="MSDN">
<meta name="depot_name" content="MSDN.prod-test">
<meta name="author" content="jasongroce">
<meta name="updated_at" content="2017-02-18 06:16 PM">
<meta name="gitcommit" content="https://github.com/MicrosoftDocs/DocsProd/blob/56739ad2d5e8afb56d49d808c9db7b9c138dc1db/prod-test/landing/visualstudio/performance/index.md">
<meta name="original_content_git_url" content="https://github.com/MicrosoftDocs/DocsProd/blob/master/prod-test/landing/visualstudio/performance/index.md">
<meta name="document_id" content="a9cd4666-9fd6-8d26-c9f0-0c2f0e552269">
<meta name="pagetype" content="Conceptual">
<meta name="toc_rel" content="../../../TOC.json">

    
    
      
    
    <link href="https://docs.microsoft.com/en-us/prod-test/landing/visualstudio/performance/" rel="canonical">
    <title>Profiling in Visual Studio | Microsoft Docs</title>
    <link rel="stylesheet" href="../../../_themes/css/d1d5acab8c02cc720733.landingpage.css ">
    <script>
	var msDocs = {
		data:{
			contentLocale: 'en-us'
		},
		functions:{},
		settings:{
			extendBreadcrumb: false
		}
	};
	</script>

<script>
	msDocs.data.pathToTheme = '../../../_themes/';
	msDocs.data.brand = '';
</script>


<!--[if lt IE 9]>
	<script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.12.4.min.js"></script>
	<script src="../../../_themes/global/js/polyfills/all.js"></script>
<![endif]-->
<!--[if gte IE 9]><!-->
	<script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.2.4.min.js"></script>
<!--<![endif]-->
<script>window.jQuery || document.write('<script src="../../../_themes/global/js/jquery/jquery-1.12.4.min.js"><\/script>')</script>

<script src="https://assets.onestore.ms/cdnfiles/external/uhf/long/6cd17f63f634a900b40eb670c61866e8e1385b9f/js/uhf-main.var.min.js" async="" defer=""></script>
<script src="https://mem.gfx.ms/meversion?partner=msdocs&market=en-us" async="" defer=""></script>

  <script src="../../../_themes/global/js/global.min.js?v=32"></script>

  </head>
  <body>



<header id="header" ms.pgarea="header">
    <div id="uhfPlaceHolder" class="c-me"></div>

    
    <div id="msdn-redirection-notification" class="shell-notification" style="display:none;" ms.cmpgrp="notifications">
        <div class="shell-notification-grid-row shell-notification-clearfix">
            <span id="msdn.redirection.text" class="notification-txt">You were redirected to this page from MSDN.  We are in the process of migrating all technical content to docs.microsoft.com.</span>
            <span class="notification-action">
            <a id="redirect-notification-close" tabindex="1">
                <i class="shell-icon-close"></i>
            </a>
            </span>
        </div>        
    </div>

    <div id="sub-header" class="container" ms.cmpgrp="breadcrumb" role="navigation" aria-label="breadcrumb">    
        <div id="sub-header-content">
            <div class="content">
                <ul class="breadcrumbs"></ul>
            </div>
        </div>
    </div>





</header>

    <main>
      <div class="container" ms.pgarea="body">

        <div id="sidebar" ms.cmpgrp="left toc" role="navigation" aria-label="main navigation">
          <div id="sidebarContent">
            <div class="filterHolder"></div>
            <nav class="toc"></nav>          
            <div class="pdfDownloadHolder"></div>
          </div>
          <div class="tocSpace"></div>
        </div>

        <div id="menu-nav" class="dropdown-container">
          <div class="dropdown dropdown-full mobilenavi">
            <select>
            </select>
          </div>
        </div>

        <div id="main" role="main" ms.pgarea="content">
          <div id="langDisclaimer" class="disclaimer" style="display:none;"><span class="icon icon-disclaimer"></span><span class="disclaimertext">This content is not available in your language but here is the English version.</span></div>
                    
          
            <h1 id="profiling-in-visual-studio" sourcefile="landing/visualstudio/performance/index.md" sourcestartlinenumber="5" sourceendlinenumber="5">Profiling in Visual Studio</h1>
          
          <div><div class="content">
<p>Profiling and diagnostics tools help you diagnose memory and CPU usage and other application-level issues. With these tools, you can accumulate data (such as variable values, function calls, and events) over the time you run your application in the debugger. You can view the state of your application at different points during the execution of your code. </p>
<ul class="panelContent cardsFTitle">
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/profiling/profiling-feature-tour">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../debugger/media/i_road-map.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Feature Tour of the Profiler</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/profiling/beginners-guide-to-performance-profiling">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../profiling/media/i_code-performance.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Get Started with the Diagnostics Tools (CPU Usage)</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://www.youtube.com/watch?v=e-3txyAFzmw">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../profiling/media/i_video.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Watch a Video on the Diagnostics Tools (VS 2015)</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/profiling/memory-usage">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../profiling/media/i_code-performance.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Analyze Memory Usage</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
        <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/profiling/application-timeline">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../profiling/media/i_learn-about.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Analyze Resource Consumption (XAML)</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/profiling/network-usage">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../profiling/media/i_learn-about.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Analyze Network Usage (UWP Apps)</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/debugger/gpu-usage">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../profiling/media/i_learn-about.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Analyze GPU Usage (Direct3D)</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    
        <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/profiling/analyze-energy-use-in-store-apps">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../profiling/media/i_learn-about.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Analyze Energy Use (Store Apps)</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/profiling/what-s-new-in-profiling-tools">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../profiling/media/i_whats-new.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>See What&#39;s New in Profiling Tools</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
</ul></div></div>
        </div>
      </div>

    </main>

    <div id="footerPlaceholder"></div>

    
    <script src="../../../_themes/javascript/d1d5acab8c02cc720733.landingpage.js"></script>
  </body>
</html>