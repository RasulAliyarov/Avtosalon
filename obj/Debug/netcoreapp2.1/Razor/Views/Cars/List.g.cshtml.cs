#pragma checksum "C:\Users\Owner\source\repos\Avtosolon\Avtosolon\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "753e5264c1d82adb820dc5a0731d37ad850b5532"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/List.cshtml", typeof(AspNetCore.Views_Cars_List))]
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
#line 1 "C:\Users\Owner\source\repos\Avtosolon\Avtosolon\Views\_ViewImports.cshtml"
using Avtosolon.ViewResultModel;

#line default
#line hidden
#line 1 "C:\Users\Owner\source\repos\Avtosolon\Avtosolon\Views\Cars\List.cshtml"
using Avtosolon.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"753e5264c1d82adb820dc5a0731d37ad850b5532", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"141572808c28ec50ed9ab96e5984b8f22828d08c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3, true);
            WriteLiteral("   ");
            EndContext();
            BeginContext(33, 13, true);
            WriteLiteral("<h2>   <br />");
            EndContext();
            BeginContext(47, 16, false);
#line 2 "C:\Users\Owner\source\repos\Avtosolon\Avtosolon\Views\Cars\List.cshtml"
        Write(Model.somestring);

#line default
#line hidden
            EndContext();
            BeginContext(63, 40, true);
            WriteLiteral("</h2>\r\n    <div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 4 "C:\Users\Owner\source\repos\Avtosolon\Avtosolon\Views\Cars\List.cshtml"
          
            foreach (InfoCar el in Model.info)
            {
                

#line default
#line hidden
            BeginContext(195, 27, false);
#line 7 "C:\Users\Owner\source\repos\Avtosolon\Avtosolon\Views\Cars\List.cshtml"
           Write(Html.Partial("AllCars", el));

#line default
#line hidden
            EndContext();
#line 7 "C:\Users\Owner\source\repos\Avtosolon\Avtosolon\Views\Cars\List.cshtml"
                                            
           
            }
        

#line default
#line hidden
            BeginContext(263, 12, true);
            WriteLiteral("    </div>\r\n");
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
