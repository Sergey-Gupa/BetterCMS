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
    
    #line 28 "..\..\Views\SiteSettings\Container.cshtml"
    using BetterCms.Core.Modules.Projections;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\SiteSettings\Container.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SiteSettings/Container.cshtml")]
    public partial class _Views_SiteSettings_Container_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.Models.SiteSettingsMenu.SiteSettingsContainerViewModel>
    {
        public _Views_SiteSettings_Container_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" id=\"bcms-site-settings\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-settings-frame\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-settings-menu\"");

WriteLiteral(" id=\"bcms-site-settings-menu\"");

WriteLiteral(">\r\n");

            
            #line 35 "..\..\Views\SiteSettings\Container.cshtml"
            
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\SiteSettings\Container.cshtml"
              
                var lastItemIsHr = true;
                foreach (var menuItem in Model.MenuItems.Projections)
                {
                    if (menuItem is SeparatorProjection)
                    {
                        if (!lastItemIsHr)
                        {
                            lastItemIsHr = true;
                        }
                    }
                    else
                    {
                        if (menuItem.Render(Model.MenuItems.Page, (ViewContext.Controller as CmsControllerBase).SecurityService, Html))
                        {
                            lastItemIsHr = false;
                        }
                    }
                }
            
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-settings-window bcms-js-settings-window\"");

WriteLiteral(" id=\"bcms-spinner-target-1\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"bcms-site-settings-placeholder\"");

WriteLiteral("> </div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
