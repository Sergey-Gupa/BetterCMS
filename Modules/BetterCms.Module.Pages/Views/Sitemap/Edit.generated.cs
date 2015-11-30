﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 28 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Pages.ViewModels.Sitemap;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Root.ViewModels.Tags;
    
    #line default
    #line hidden
    
    #line 34 "..\..\Views\Sitemap\Edit.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Sitemap/Edit.cshtml")]
    public partial class _Views_Sitemap_Edit_cshtml : System.Web.Mvc.WebViewPage<SitemapViewModel>
    {
        public _Views_Sitemap_Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 36 "..\..\Views\Sitemap\Edit.cshtml"
  
    var tagsTemplateViewModel = new TagsTemplateViewModel
    {
        TooltipDescription = NavigationGlobalization.Sitemap_EditDialog_AddTags_Tooltip_Description
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-tab-header bcms-js-tab-header\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item bcms-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">Properties</div>\r\n        <div");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">Nodes</div>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 49 "..\..\Views\Sitemap\Edit.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"bcms-window-tabbed-options\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" id=\"bcms-sitemap-addnode\"");

WriteLiteral(">\r\n            ");

WriteLiteral("\r\n");

            
            #line 53 "..\..\Views\Sitemap\Edit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Sitemap\Edit.cshtml"
             using (Html.BeginForm<SitemapController>(f => f.EditSitemap(null), FormMethod.Post, new
        {
            @class = "bcms-sitemap-form bcms-ajax-form",
            data_readonly = Model.IsReadOnly.ToString().ToLower()
        }))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-form-block-holder\"");

WriteLiteral(">\r\n                        <div>\r\n                            <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 63 "..\..\Views\Sitemap\Edit.cshtml"
                                                            Write(NavigationGlobalization.Sitemap_EditDialog_SitemapTitle_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                                ");

            
            #line 64 "..\..\Views\Sitemap\Edit.cshtml"
                           Write(Html.Tooltip(NavigationGlobalization.Sitemap_EditDialog_SitemapTitle_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 66 "..\..\Views\Sitemap\Edit.cshtml"
                               Write(Html.TextBoxFor(model => model.Title, new { @class = "bcms-field-text", data_bind = "value: title, valueUpdate: 'afterkeydown', hasfocus: true" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 67 "..\..\Views\Sitemap\Edit.cshtml"
                               Write(Html.BcmsValidationMessageFor(f => f.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 68 "..\..\Views\Sitemap\Edit.cshtml"
                               Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 69 "..\..\Views\Sitemap\Edit.cshtml"
                               Write(Html.HiddenFor(m => m.Version));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n   " +
"                         <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(" data-bind=\"with: tags\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 73 "..\..\Views\Sitemap\Edit.cshtml"
                           Write(Html.Partial("~/Areas/bcms-root/Views/Tags/TagsTemplate.cshtml", tagsTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"             <div>\r\n");

            
            #line 77 "..\..\Views\Sitemap\Edit.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 77 "..\..\Views\Sitemap\Edit.cshtml"
                             if (Model.AccessControlEnabled)
                            {
                                
            
            #line default
            #line hidden
            
            #line 79 "..\..\Views\Sitemap\Edit.cshtml"
                           Write(Html.Partial(RootModuleConstants.AccessControlTemplate));

            
            #line default
            #line hidden
            
            #line 79 "..\..\Views\Sitemap\Edit.cshtml"
                                                                                        
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n                    </div>\r\n                </div" +
">\r\n");

WriteLiteral("                <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n                    <!-- ko with: sitemap -->\r\n                    <div");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-bind=\"visible: showLanguages, with: language\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-top-block-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-language-selector-box\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 89 "..\..\Views\Sitemap\Edit.cshtml"
                                                            Write(NavigationGlobalization.Sitemap_EditDialog_LanguageSelectionTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n                                    <select");

WriteLiteral(" data-bind=\"options: languages, optionsText: \'value\', optionsValue: \'key\', value:" +
" languageId, select2: { minimumResultsForSearch: -1 }\"");

WriteLiteral("></select>\r\n                                </div>\r\n                            <" +
"/div>\r\n                        </div>\r\n                    </div>\r\n             " +
"       <div");

WriteLiteral(" class=\"bcms-content-dialog-title\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles-helper\"");

WriteLiteral(">");

            
            #line 97 "..\..\Views\Sitemap\Edit.cshtml"
                                                           Write(NavigationGlobalization.Sitemap_EditDialog_PageLink_Header);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                        <div");

WriteLiteral(" class=\"bcms-tree-expander bcms-tree-expander-close\"");

WriteLiteral(" data-bind=\"click: callExpandOrCollapse, css: { \'bcms-tree-expander-close\' : allN" +
"odesExpanded()}, text: allNodesExpanded() ? \'");

            
            #line 99 "..\..\Views\Sitemap\Edit.cshtml"
                                                                                                                                                                                                         Write(PagesGlobalization.CategoryTree_Button_CollapseAll);

            
            #line default
            #line hidden
WriteLiteral("\' : \'");

            
            #line 99 "..\..\Views\Sitemap\Edit.cshtml"
                                                                                                                                                                                                                                                                 Write(PagesGlobalization.CategoryTree_Button_ExpandAll);

            
            #line default
            #line hidden
WriteLiteral("\'\"");

WriteLiteral("></div>\r\n                    </div>\r\n                    <!-- /ko -->\r\n          " +
"          <div");

WriteLiteral(" class=\"bcms-tree-zones-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-tree-drag-area-ui\"");

WriteLiteral(" data-bind=\"template: { name: \'bcms-navigation-pagelinks-template\' }\"");

WriteLiteral("></div>\r\n\r\n                        <div");

WriteLiteral(" class=\"bcms-tree-drop-area-ui\"");

WriteLiteral(">\r\n                            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 5943), Tuple.Create("\"", 6028)
, Tuple.Create(Tuple.Create("", 5951), Tuple.Create("bcms-addnode-placement-holder", 5951), true)
            
            #line 106 "..\..\Views\Sitemap\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 5980), Tuple.Create<System.Object, System.Int32>(Model.IsReadOnly ? "-readonly" : string.Empty
            
            #line default
            #line hidden
, 5980), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 107 "..\..\Views\Sitemap\Edit.cshtml"
                           Write(Html.Partial("Partial/Sitemap", new SitemapNodeViewModel()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"         </div>\r\n                </div>\r\n");

            
            #line 112 "..\..\Views\Sitemap\Edit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n\r\n");

WriteLiteral("        ");

            
            #line 115 "..\..\Views\Sitemap\Edit.cshtml"
   Write(Html.Partial("Partial/SitemapTemplate", new SitemapNodeViewModel()));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-navigation-pagelinks-template\"");

WriteLiteral(">\r\n    <div class=\"bcms-sidebar-search\">\r\n        <div class=\"bcms-field-wrapper\"" +
">\r\n            <input type=\"text\" class=\"bcms-field-text\" placeholder=\"");

            
            #line 121 "..\..\Views\Sitemap\Edit.cshtml"
                                                               Write(NavigationGlobalization.Sitemap_EditDialog_AddPageLink_SearchPlaceHolder);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                   data-bind=\"hasfocus: hasfocus, value: searchQuery, valueUpd" +
"ate: \'afterkeydown\', enterPress: searchForPageLinks\" />\r\n        </div>\r\n       " +
" <div class=\"bcms-btn-search\" data-bind=\"click: searchForPageLinks\">");

            
            #line 124 "..\..\Views\Sitemap\Edit.cshtml"
                                                                      Write(NavigationGlobalization.Sitemap_EditDialog_AddPageLink_SearchButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n\r\n    <div class=\"bcms-drag-zone");

            
            #line 127 "..\..\Views\Sitemap\Edit.cshtml"
                          Write(Model.IsReadOnly ? "-read-only" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\" data-bind=\"template: { name: \'bcms-navigation-pagelink-template\', foreach: page" +
"Links }\"></div>\r\n</script>\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-navigation-pagelink-template\"");

WriteLiteral(">\r\n    <!-- ko if: isVisible() || isCustom() -->\r\n    <div class=\"bcms-drag-zone-" +
"box\" data-bind=\"");

            
            #line 131 "..\..\Views\Sitemap\Edit.cshtml"
                                           Write(!Model.IsReadOnly ? "draggable: $parentContext.$index, " : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(@"css: { 'bcms-node-box-drag': isBeingDragged() }, style: { borderColor: isOnSitemap() == true ? '#dc4250' : '' }"">
        <div class=""bcms-drag-zone-title"" data-bind=""text: title()""></div>
        <div class=""bcms-drag-zone-path"">
            <a data-bind=""text: url, attr: { href: url }"" href="""" target=""_blank""></a>
        </div>
    </div>
    <!-- ko if: isBeingDragged() -->
    <div class=""bcms-node-drop-zone""></div>
    <!-- /ko -->
    <!-- /ko -->
</script>");

        }
    }
}
#pragma warning restore 1591
