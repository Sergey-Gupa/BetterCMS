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
    
    #line 28 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Core.DataContracts.Enums;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Pages.ViewModels.SiteSettings;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 34 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Partial/SiteSettingsPagesList.cshtml")]
    public partial class _Views_Page_Partial_SiteSettingsPagesList_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Filter.PagesGridViewModel<SiteSettingPageViewModel>>
    {
        public _Views_Page_Partial_SiteSettingsPagesList_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 37 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
 if (Model == null)
{
    return;
}

            
            #line default
            #line hidden
WriteLiteral("    \r\n");

            
            #line 42 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"bcms-top-block-holder\"");

WriteLiteral(">\r\n");

            
            #line 44 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
         if ((ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.EditContent))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" id=\"bcms-create-page-button\"");

WriteLiteral(">");

            
            #line 46 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
                                                               Write(PagesGlobalization.SiteSettings_Pages_AddNew);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 47 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-pages-search-btn\"");

WriteLiteral(">");

            
            #line 50 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
                                                               Write(PagesGlobalization.SiteSettings_Pages_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 52 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
           Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-search-field-box bcms-js-search-box bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("                      \r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-top-block-pager\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 57 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
       Write(Html.Partial("~/Areas/bcms-root/Views/Shared/Partial/Paging.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-top-block-filters\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 62 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
   Write(Html.Partial("~/Areas/bcms-pages/Views/Filter/PagesFilterTemplate.cshtml", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n");

WriteLiteral("    ");

            
            #line 65 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
Write(Html.Partial("~/Areas/bcms-pages/Views/Page/Partial/PagesGrid.cshtml", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
