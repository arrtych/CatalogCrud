#pragma checksum "E:\TUNK\C#\asp.net\github_project\CatalogCrud\CatalogCrud\CatalogCrud\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f650feaa47e7a2e2ef6211d16b2cf577e8fd5b85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\TUNK\C#\asp.net\github_project\CatalogCrud\CatalogCrud\CatalogCrud\Views\_ViewImports.cshtml"
using CatalogCrud;

#line default
#line hidden
#line 2 "E:\TUNK\C#\asp.net\github_project\CatalogCrud\CatalogCrud\CatalogCrud\Views\_ViewImports.cshtml"
using CatalogCrud.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f650feaa47e7a2e2ef6211d16b2cf577e8fd5b85", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e752cfe05d0a4a30157cda2bfa5f7d86803f47", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\TUNK\C#\asp.net\github_project\CatalogCrud\CatalogCrud\CatalogCrud\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2757, true);
            WriteLiteral(@"


<div class=""row"">
    <div class=""col-md-12"">
        <h3 class=""header-st"">Books catalog sorted by creation date </h3>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-6"">
        <div class=""form-group"">
            <label class=""sr-only"" for=""search"">Search</label>

            <div class=""input-group"">
                <input type=""text"" class=""form-control search-input"" ng-model=""search[searchBy]"" placeholder=""Search"">
                <span class=""input-group-addon""><span class=""glyphicon glyphicon-search"" aria-hidden=""true""></span></span>
            </div>
        </div>
    </div>
    <div class=""col-md-6""></div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""table-responsive table-st"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""active"">
                        <th>
                            Date
                        </th>
                        <th>
      ");
            WriteLiteral(@"                      Name
                        </th>
                        <th>
                            Author
                        </th>
                        <th>
                            Category
                        </th>
                        <th>
                            Description
                        </th>
                        <th>
                            Pages
                        </th>
                        <th>
                            Price
                        </th>



                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat=""b in Books | filter:search"">
                        <td class=""col-md-2"">
                            {{b.creationDate.replace(""T"", ""-"").substring(0, 19)}}
                        </td>
                        <td class=""col-md-2"">
                            {{b.name}}
                        </td>
                        <td class=""col-md-1"">
");
            WriteLiteral(@"                            {{b.author}}
                        </td>
                        <td class=""col-md-2"">
                            {{b.categoryName.name}}
                        </td>
                        <td class=""col-md-3"">
                            {{b.description.substring(0,75)}}...
                        </td>
                        <td class=""col-md-1"">
                            {{b.pagesNumber}}
                        </td>
                        <td class=""col-md-1"">
                            {{b.price}} $
                        </td>

                    </tr>

                </tbody>
            </table>
        </div>

    </div>
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
