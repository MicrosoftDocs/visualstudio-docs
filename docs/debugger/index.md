<!DOCTYPE html>



  

<html class="no-js" lang="en-us" dir="ltr">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta property="og:title" content="Debugging in Visual Studio">
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
<meta name="gitcommit" content="https://github.com/MicrosoftDocs/DocsProd/blob/56739ad2d5e8afb56d49d808c9db7b9c138dc1db/prod-test/landing/visualstudio/debug/index.md">
<meta name="original_content_git_url" content="https://github.com/MicrosoftDocs/DocsProd/blob/master/prod-test/landing/visualstudio/debug/index.md">
<meta name="document_id" content="8a672671-d674-0c5a-0745-5de6ce6d1402">
<meta name="pagetype" content="Conceptual">
<meta name="toc_rel" content="../../../TOC.json">

    
    
      
    
    <link href="https://docs.microsoft.com/en-us/prod-test/landing/visualstudio/debug/" rel="canonical">
    <title>Debugging in Visual Studio | Microsoft Docs</title>
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
                    
          
            <h1 id="debugging-in-visual-studio" sourcefile="landing/visualstudio/debug/index.md" sourcestartlinenumber="5" sourceendlinenumber="5">Debugging in Visual Studio</h1>
          
          <div><div class="content">
<p>The Visual Studio debugger helps you observe the run-time behavior of your program and find problems. The debugger works with all Visual Studio programming languages and their associated libraries. With the debugger, you can break execution of your program to examine your code, examine and edit variables, view registers, see the instructions created from your source code, and view the memory space used by your application. </p>
<ul class="panelContent cardsFTitle">
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/debugger/debugger-feature-tour">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../debugger/media/i_road-map.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Feature Tour of the Debugger</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/debugger/getting-started-with-the-debugger">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../debugger/media/i_debug.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Get Started with the Debugger</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/debugger/navigating-through-code-with-the-debugger">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../debugger/media/i_debug.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Navigate Code with the Debugger</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
        <li>
        <a href="https://www.youtube.com/watch?v=FtGCi5j30YU&list=PLReL099Y5nRfw6VNvzMkv0sabT2crbSpK&index=6">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../debugger/media/i_video.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Watch a Video on using the Debugger</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/debugger/remote-debugging">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../debugger/media/i_learn.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Learn about Remote Debugging</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/debugger/debug-multithreaded-applications-in-visual-studio">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../debugger/media/i_get-started.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Debug Multi-Threaded Apps</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
        <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/debugger/intellitrace">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../debugger/media/i_learn.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Learn about IntelliTrace (Visual Studio Enterprise)</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/debugger/what-s-new-for-the-debugger-in-visual-studio">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="../debugger/media/i_whats-new.svg" alt="">
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>See What&#39;s New in the Debugger</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
</ul>

<hr>
<h2>Reference</h2>

<ul class="panelContent cardsW">
    <li>
        <a href="https://msdn.microsoft.com/en-us/library/ee661590.aspx">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardText">
                        <h3>IntelliTrace Reference</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/debugger/debug-interface-access/debug-interface-access-sdk">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardText">
                        <h3>Debug Interface Access SDK</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="https://docs.microsoft.com/en-us/visualstudio/debugger/spy-increment-help">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardText">
                        <h3>Spy++</h3>
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