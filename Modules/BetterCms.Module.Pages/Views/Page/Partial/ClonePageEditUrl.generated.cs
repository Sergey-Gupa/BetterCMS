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
    
    #line 1 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Partial/ClonePageEditUrl.cshtml")]
    public partial class _Views_Page_Partial_ClonePageEditUrl_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Page.ClonePageViewModel>
    {
        public _Views_Page_Partial_ClonePageEditUrl_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n");

WriteLiteral("    ");

            
            #line 7 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
Write(Html.Tooltip(PagesGlobalization.ClonePage_NewUrl_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\n    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
                                Write(PagesGlobalization.ClonePage_NewUrl);

            
            #line default
            #line hidden
WriteLiteral("<a");

WriteLiteral(" id=\"bcms-page-editpermalink\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
                                                                                                    Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a></div>\n    <div");

WriteLiteral(" class=\"bcms-editseo-urlpath\"");

WriteLiteral(" id=\"bcms-page-permalink-info\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
                                                                Write(string.IsNullOrWhiteSpace(Model.PageUrl) ? Html.Raw("&nbsp;") : new MvcHtmlString(Html.Encode(Model.PageUrl)));

            
            #line default
            #line hidden
WriteLiteral("</div>\n</div>\n\n<div");

WriteLiteral(" class=\"bcms-edit-urlpath-box\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\n\n");

WriteLiteral("    ");

            
            #line 14 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
Write(Html.Hidden("PageNewUrlHidden", Model.PageUrl, new { @id = "bcms-page-permalink" }));

            
            #line default
            #line hidden
WriteLiteral("\n    <div");

WriteLiteral(" class=\"bcms-custom-input-box\"");

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 16 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
   Write(Html.TextBoxFor(model => model.PageUrl, new { @id = "bcms-page-permalink-edit", @class = "bcms-editor-field-box bcms-js-url-path", @style = "width: 503px;" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("        ");

            
            #line 17 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
   Write(Html.BcmsValidationMessageFor(f => f.PageUrl));

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n    <div");

WriteLiteral(" class=\"bcms-btn-small\"");

WriteLiteral(" id=\"bcms-save-permalink\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
                                                    Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\n    <div");

WriteLiteral(" class=\"bcms-btn-links-small\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\Page\Partial\ClonePageEditUrl.cshtml"
                                 Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\n</div>\n");

        }
    }
}
#pragma warning restore 1591
