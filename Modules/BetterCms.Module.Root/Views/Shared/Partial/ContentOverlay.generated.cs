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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Partial/ContentOverlay.cshtml")]
    public partial class _Views_Shared_Partial_ContentOverlay_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderPageViewModel>
    {
        public _Views_Shared_Partial_ContentOverlay_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-content-overlay\"");

WriteLiteral(@">
    <div class=""bcms-content-overlay"">
        <div class=""bcms-content-actions"">
            <div class=""bcms-content-button bcms-content-edit-child""></div>
            <div class=""bcms-content-button bcms-content-history""></div>
            <div class=""bcms-content-button bcms-content-edit""></div>
            <div class=""bcms-content-button bcms-content-configure""></div>
");

            
            #line 36 "..\..\Views\Shared\Partial\ContentOverlay.cshtml"
            
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Shared\Partial\ContentOverlay.cshtml"
             if (!Model.IsReadOnly && Model.HasEditRole)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-content-button bcms-content-delete\"");

WriteLiteral("></div>\r\n");

            
            #line 39 "..\..\Views\Shared\Partial\ContentOverlay.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
