#pragma checksum "C:\Users\Cloud Analogy\source\repos\CrudUsingAjax\CrudUsingAjax\Views\Organisation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bad909684aac2ee9fc073227b5fd5440c29bbcfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organisation_Index), @"mvc.1.0.view", @"/Views/Organisation/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Cloud Analogy\source\repos\CrudUsingAjax\CrudUsingAjax\Views\_ViewImports.cshtml"
using CrudUsingAjax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cloud Analogy\source\repos\CrudUsingAjax\CrudUsingAjax\Views\_ViewImports.cshtml"
using CrudUsingAjax.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bad909684aac2ee9fc073227b5fd5440c29bbcfa", @"/Views/Organisation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17eae55713e149663798eeeff9e15c1daa301591", @"/Views/_ViewImports.cshtml")]
    public class Views_Organisation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrudUsingAjax.Models.Organisation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Cloud Analogy\source\repos\CrudUsingAjax\CrudUsingAjax\Views\Organisation\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>

<button class=""btn btn-info"" id=""btnRefresh"" style=""float: right;""> Refresh </button>

<script>
    $(document).ready(function () {
         function getData(){
             $.ajax({
                type: ""GET"",
                url: '");
#nullable restore
#line 19 "C:\Users\Cloud Analogy\source\repos\CrudUsingAjax\CrudUsingAjax\Views\Organisation\Index.cshtml"
                 Write(Url.Action("List", "Organisation"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                success: function (data) {
                    setInterval(""btnRefresh()"", 2000);
                    var tr = """";
                    for (let i = 0; i < data.length; i++)
                    {
                        tr += ""<tr>"";
                        tr += ""<td>"" + data[i].organisationId + ""</td>"";
                        tr += ""<td>"" + data[i].organisationName + ""</td>"";
                        tr += ""<td>"" + data[i].organisationAddress + ""</td>"";
                        tr += ""</tr>"";
                    }
                    $(""#Output"").html(tr);
                }

             });
        }

        getData();
        $(""#btnRefresh"").on(""click"", function () {
            getData();
        })
    });

</script>

<div class=""text-center"">

    <h1 class=""display-4"">Organisation List</h1>

    <table class=""table table-bordered"">

        <tr class=""table-head"">

            <th> OrganisationId</th>

            <th> OrganisationName</th>

   ");
            WriteLiteral("         <th> OrganisationAddress</th>\r\n\r\n        </tr>\r\n\r\n        <tbody id=\"Output\">\r\n        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrudUsingAjax.Models.Organisation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
