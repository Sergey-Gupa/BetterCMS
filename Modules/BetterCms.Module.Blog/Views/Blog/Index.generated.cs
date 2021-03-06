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
    
    #line 28 "..\..\Views\Blog\Index.cshtml"
    using BetterCms.Module.Blog.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Blog\Index.cshtml"
    using BetterCms.Module.Blog.Controllers;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Blog\Index.cshtml"
    using BetterCms.Module.Blog.ViewModels.Blog;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Blog\Index.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\Blog\Index.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 35 "..\..\Views\Blog\Index.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\Blog\Index.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 34 "..\..\Views\Blog\Index.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 36 "..\..\Views\Blog\Index.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/Index.cshtml")]
    public partial class _Views_Blog_Index_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Blog.ViewModels.Filter.BlogsGridViewModel<SiteSettingBlogPostViewModel>>
    {
        public _Views_Blog_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 39 "..\..\Views\Blog\Index.cshtml"
  
    var controller = (CmsControllerBase)ViewContext.Controller;
    var canEdit = controller.SecurityService.IsAuthorized(RootModuleConstants.UserRoles.EditContent);
    var canPublish = controller.SecurityService.IsAuthorized(RootModuleConstants.UserRoles.PublishContent);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 45 "..\..\Views\Blog\Index.cshtml"
 using (Html.BeginForm<BlogController>(f => f.Index(null), FormMethod.Post, new { @id = "bcms-blogs-form", @class = "bcms-ajax-form" }))
{
    
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Blog\Index.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Blog\Index.cshtml"
                       

    
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Blog\Index.cshtml"
Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Blog\Index.cshtml"
                                              


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-top-block-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-top-controls-btn-holder\"");

WriteLiteral(">\r\n");

            
            #line 53 "..\..\Views\Blog\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Blog\Index.cshtml"
             if (canEdit)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" id=\"bcms-create-blog-button\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\Blog\Index.cshtml"
                                                                   Write(BlogGlobalization.SiteSettings_Blogs_AddNew);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 56 "..\..\Views\Blog\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 58 "..\..\Views\Blog\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Blog\Index.cshtml"
             if (canPublish && canEdit)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-btn-opener\"");

WriteLiteral("> </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-btn-opener-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-opener-link\"");

WriteLiteral(" id=\"bcms-import-blogs\"");

WriteLiteral(">");

            
            #line 62 "..\..\Views\Blog\Index.cshtml"
                                                                        Write(BlogGlobalization.SiteSettings_Blogs_Import);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-opener-link\"");

WriteLiteral(" id=\"bcms-export-blogs\"");

WriteLiteral(">");

            
            #line 63 "..\..\Views\Blog\Index.cshtml"
                                                                        Write(BlogGlobalization.SiteSettings_Blogs_Export);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n");

            
            #line 65 "..\..\Views\Blog\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-blogs-search-btn\"");

WriteLiteral(">");

            
            #line 69 "..\..\Views\Blog\Index.cshtml"
                                                                   Write(BlogGlobalization.SiteSettings_Blogs_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">                 \r\n");

WriteLiteral("                    ");

            
            #line 71 "..\..\Views\Blog\Index.cshtml"
               Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-search-field-box bcms-js-search-box bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-top-block-pager\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 76 "..\..\Views\Blog\Index.cshtml"
           Write(Html.Partial("~/Areas/bcms-root/Views/Shared/Partial/Paging.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n    </div>\r\n");

            
            #line 79 "..\..\Views\Blog\Index.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-top-block-filters\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 81 "..\..\Views\Blog\Index.cshtml"
   Write(Html.Partial("~/Areas/bcms-blog/Views/Blog/Partial/BlogsFilterTemplate.cshtml", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 83 "..\..\Views\Blog\Index.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Blog\Index.cshtml"
Write(Html.Partial("~/Areas/bcms-blog/Views/Blog/Partial/BlogsGrid.cshtml", Model));

            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Blog\Index.cshtml"
                                                                                 
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
