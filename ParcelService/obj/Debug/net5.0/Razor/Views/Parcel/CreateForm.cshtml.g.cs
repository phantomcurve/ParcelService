#pragma checksum "/Users/phantom/Desktop/Parcel/ParcelService/Views/Parcel/CreateForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e5d94c24d79d73dc832a48c2aef935a82cc1304"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parcel_CreateForm), @"mvc.1.0.view", @"/Views/Parcel/CreateForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5d94c24d79d73dc832a48c2aef935a82cc1304", @"/Views/Parcel/CreateForm.cshtml")]
    public class Views_Parcel_CreateForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<form action=""/parcels"" method=""post"">
  <label for=""length"">Enter parcel length</label>
  <input id=""length"" name=""length"" type=""text"">
  <label for=""height"">Enter parcel height</label>
  <input id=""height"" name=""height"" type=""text"">
  <label for=""width"">Enter parcel width</label>
  <input id=""width"" name=""width"" type=""text"">
  <label for=""weight"">Enter parcel weight</label>
  <input id=""weight"" name=""weight"" type=""text"">
  <button type=""submit"">Submit</button>
</form>
");
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