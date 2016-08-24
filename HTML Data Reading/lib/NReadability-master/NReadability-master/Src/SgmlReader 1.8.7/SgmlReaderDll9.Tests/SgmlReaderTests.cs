﻿using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using NUnit.Framework;
using Sgml;

namespace SgmlReaderDll9.Tests
{
  [TestFixture]
  public class SgmlReaderTests
  {
    private SgmlReader _sgmlReader;

    #region SetUp and  TearDown

    [SetUp]
    public void SetUp()
    {
      _sgmlReader =
        new SgmlReader
          {
            CaseFolding = CaseFolding.ToLower,
            DocType = "HTML",
            WhitespaceHandling = WhitespaceHandling.None
          };
    }

    [TearDown]
    public void TearDown()
    {
      if (_sgmlReader != null)
      {
        ((IDisposable)_sgmlReader).Dispose();
      }
    }

    #endregion

    #region Tests

    [Test]
    public void Builder_handles_UTF16()
    {
      // arrange
      const string htmlContent = "﻿<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\n<html xmlns=\"http://www.w3.org/1999/xhtml\" dir=\"ltr\" lang=\"pl-PL\">\n<head profile=\"http://gmpg.org/xfn/11\">\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\" />\n<title>Jak zwiększyć swoją pewność siebie | Michalpasterski.pl | świadomie o rozwoju osobistym</title>\n<meta name=\"generator\" content=\"WordPress abc\" /> <!-- leave this for stats -->\n<link rel=\"stylesheet\" href=\"http://michalpasterski.pl/wp-content/themes/newtheme/style.css\" type=\"text/css\" media=\"screen\" />\n<link rel=\"alternate\" type=\"application/rss+xml\" title=\"RSS 2.0\" href=\"http://michalpasterski.pl/feed/\" />\n<link rel=\"alternate\" type=\"text/xml\" title=\"RSS .92\" href=\"http://michalpasterski.pl/feed/rss/\" />\n<link rel=\"alternate\" type=\"application/atom+xml\" title=\"Atom 0.3\" href=\"http://michalpasterski.pl/feed/atom/\" />\n<link rel=\"pingback\" href=\"http://michalpasterski.pl/xmlrpc.php\" />\n<link rel=\"alternate\" type=\"application/rss+xml\" title=\"Michalpasterski.pl | świadomie o rozwoju osobistym &raquo; Jak zwiększyć swoją pewność siebie Kanał z komentarzami\" href=\"http://michalpasterski.pl/2008/11/jak-zwiekszyc-swoja-pewnosc-siebie/feed/\" />\n<link rel='stylesheet' id='wp-polls-css'  href='http://michalpasterski.pl/wp-content/plugins/wp-polls/polls-css.css?ver=2.50' type='text/css' media='all' />\n<script type='text/javascript' src='http://michalpasterski.pl/wp-includes/js/jquery/jquery.js?ver=1.4.2'></script>\n<script type='text/javascript' src='http://michalpasterski.pl/wp-content/themes/newtheme/js/js.js?ver=abc'></script>\n<link rel=\"EditURI\" type=\"application/rsd+xml\" title=\"RSD\" href=\"http://michalpasterski.pl/xmlrpc.php?rsd\" />\n<link rel=\"wlwmanifest\" type=\"application/wlwmanifest+xml\" href=\"http://michalpasterski.pl/wp-includes/wlwmanifest.xml\" /> \n<link rel='index' title='Michalpasterski.pl | świadomie o rozwoju osobistym' href='http://michalpasterski.pl/' />\n<link rel='start' title='Jak tworzyć wizualizacje, które zmienią Twoje życie' href='http://michalpasterski.pl/2008/06/jak-tworzyc-wizualizacje/' />\n<link rel='prev' title='Wyjątkowy wpis integracyjny :)' href='http://michalpasterski.pl/2008/11/wyjatkowy-wpis-integracyjny/' />\n<link rel='next' title='O neuronach' href='http://michalpasterski.pl/2008/11/o-neuronach/' />\n<link rel='shortlink' href='http://michalpasterski.pl/?p=217' />\n\n<!-- All in One SEO Pack 1.6.11 by Michael Torbert of Semper Fi Web Design[306,438] -->\n<meta name=\"description\" content=\"Jeśli czujesz, że brakuje Ci pewności siebie, koniecznie przeczytaj ten artykuł. Pokażę Ci dokładnie co należy zrobić aby zacząć wierzyć we własne możliwości!\" />\n<meta name=\"keywords\" content=\"pewność siebie, pewny siebie, pewność, samoocena, nlp, osiąganie celów,nlp,osiąganie celów\" />\n<link rel=\"canonical\" href=\"http://michalpasterski.pl/2008/11/jak-zwiekszyc-swoja-pewnosc-siebie/\" />\n<!-- /all in one seo pack -->\n\n<!-- Start Of Script Generated By cforms v11.6.1 [Oliver Seidel | www.deliciousdays.com] -->\n<link rel=\"stylesheet\" type=\"text/css\" href=\"http://michalpasterski.pl/wp-content/plugins/cforms/styling/cforms.css\" />\n<script type=\"text/javascript\" src=\"http://michalpasterski.pl/wp-content/plugins/cforms/js/cforms.js\"></script>\n<!-- End Of Script Generated By cforms -->\n\n<meta name=\"robots\" content=\"index,follow\" />\n\n	<!-- Google Ajax Search -->\n\n	\n	<link href=\"http://www.google.com/uds/css/gsearch.css\" type=\"text/css\" rel=\"stylesheet\"/>\n	<style>	\n	\n	/* Width */\n	.gsc-control {\n	  	width: 280px;\n		overflow: hidden\n	}\n	.gs-result .gs-title,\n	.gs-result .gs-title * {\n		font-size: em;\n	  	color: #549AD8;\n	}\n	.gsc-results .gsc-trailing-more-results,\n	.gsc-results .gsc-trailing-more-results * {\n	  	color: #549AD8;\n	}\n	.gs-result a.gs-visibleUrl,\n	.gs-result .gs-visibleUrl {\n	  	color: #;\n	}\n	.gs-result a.gs-clusterUrl,\n	.gs-result .gs-clusterUrl {\n	  	color: #;\n	}\n	.gsc-resultsbox-visible {\n		display: table;\n		width: 100%;\n		overflow: hidden\n	}\n	</style>\n\n\n	<style>\n	img.gsc-branding-img {\n	display: none;\n	}\n	td.gsc-branding-text div.gsc-branding-text {\n	display: none;\n	}	\n	</style>\n\n		\n	<script src='http://www.google.com/uds/api?file=uds.js&amp;v=1.0&key=ABQIAAAANUD_QVL2ucyKWo8cO8gN3RQq1_6xPedlnuzKZU469BjL0S3e3RRAcBEuKaFsEQuOvP-1uqyW7gA6Bg' type='text/javascript'></script>\n	<!-- Google AjaxSearch Plugin for WordPress initialization -->\n	<script type='text/javascript'> \n\n\n\n\n	function OnLoad()\n		{\n			\n			var searchControl = new GSearchControl();\n			searchControl .setLinkTarget(GSearch.LINK_TARGET_SELF); \n			var webSearch = new GwebSearch();   \n			webSearch.setSiteRestriction(\"http://michalpasterski.pl\");\n			webSearch.setUserDefinedLabel(\"Results\");\n			webSearch.setUserDefinedClassSuffix(\"webSearch\");\n							var blogSearch = new GblogSearch(); \n			blogSearch.setSiteRestriction(\"http://michalpasterski.pl\");\n			blogSearch.setUserDefinedLabel(\"Blog Search\");\n			blogSearch.setUserDefinedClassSuffix(\"siteSearch\");\n			blogSearch.setResultOrder(GSearch.ORDER_BY_DATE);\n											var options = new GsearcherOptions();\n			options.setExpandMode(GSearchControl.EXPAND_MODE_OPEN);\n			searchControl.addSearcher(webSearch, options);\n							searchControl.addSearcher(blogSearch, options);\n											\n\n			var drawOptions = new GdrawOptions();\n			drawOptions.setDrawMode(GSearchControl.DRAW_MODE_TABBED);\n			searchControl.draw(document.getElementById(\"searchcontrol\"),drawOptions);\n\n		}\n		GSearch.setOnLoadCallback(OnLoad);\n\n	</script>\n	<!-- Google Maps Plugin for WordPress (end) -->\n\n<link rel=\"stylesheet\" type=\"text/css\" href=\"http://michalpasterski.pl/wp-content/plugins/pdf24-post-to-pdf/styles/lp/default_dfl.css\" />\n<link rel='shortcut icon' href='http://michalpasterski.pl/favicon.ico' />\n<script type=\"text/javascript\" src=\"http://michalpasterski.pl/wp-content/plugins/wordpress-tweaks/tweaks.php?js=targetblank\"></script>\n<style type=\"text/css\">\n.wp-polls .pollbar {\n	margin: 1px;\n	font-size: 8px;\n	line-height: 10px;\n	height: 10px;\n	background-image: url('http://michalpasterski.pl/wp-content/plugins/wp-polls/images/default_gradient/pollbg.gif');\n	border: 1px solid #ffffff;\n}\n</style>\n</head>\n<body>Some body</body>";
      XDocument xDocument;

      // act
      using (var sr = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(htmlContent))))
      {
        _sgmlReader.InputStream = sr;

        xDocument = XDocument.Load(_sgmlReader);
      }

      string serializedHtmlContent = xDocument.ToString();

      // assert
      MyAssert.AssertSubstringCount(1, serializedHtmlContent, "<html");
    }

    #endregion
  }
}
