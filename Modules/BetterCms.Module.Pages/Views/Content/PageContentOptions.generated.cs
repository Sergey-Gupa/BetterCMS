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
    
    #line 28 "..\..\Views\Content\PageContentOptions.cshtml"
    using BetterCms.Module.Pages;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Content\PageContentOptions.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Content\PageContentOptions.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Content\PageContentOptions.cshtml"
    using BetterCms.Module.Root.ViewModels.Option;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\Content\PageContentOptions.cshtml"
    using BetterCms.Module.Root.ViewModels.Shared;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\Content\PageContentOptions.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/PageContentOptions.cshtml")]
    public partial class _Views_Content_PageContentOptions_cshtml : System.Web.Mvc.WebViewPage<ContentOptionValuesViewModel>
    {
        public _Views_Content_PageContentOptions_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Views\Content\PageContentOptions.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-window-options\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

            
            #line 42 "..\..\Views\Content\PageContentOptions.cshtml"
            
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Content\PageContentOptions.cshtml"
             using (Html.BeginForm<ContentController>(c => c.PageContentOptions((ContentOptionValuesViewModel)null), FormMethod.Post, new
            {
                @id = "bcms-options-form",
                @class = "bcms-ajax-form",
                data_readonly = Model.IsReadOnly.ToString().ToLower()
            }))
        {
            
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Content\PageContentOptions.cshtml"
       Write(Html.Partial(PagesConstants.OptionValuesGridTemplate, new EditableGridViewModel{CanAddNewItems = false}));

            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Content\PageContentOptions.cshtml"
                                                                                                                     

                
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Content\PageContentOptions.cshtml"
           Write(Html.HiddenFor(model => model.OptionValuesContainerId));

            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Content\PageContentOptions.cshtml"
                                                                       
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
