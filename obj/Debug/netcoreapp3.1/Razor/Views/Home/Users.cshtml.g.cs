#pragma checksum "/Users/johnlondono/Desktop/Coding_Dojo/C#/Wk_1_Assign/View_Model_Fun/Views/Home/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "293ea628669d0ce138b36daaf87b1f9ec78ea354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
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
#line 1 "/Users/johnlondono/Desktop/Coding_Dojo/C#/Wk_1_Assign/View_Model_Fun/Views/_ViewImports.cshtml"
using View_Model_Fun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/johnlondono/Desktop/Coding_Dojo/C#/Wk_1_Assign/View_Model_Fun/Views/_ViewImports.cshtml"
using View_Model_Fun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"293ea628669d0ce138b36daaf87b1f9ec78ea354", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07fbdc6204ebb5aa5300dbcadd95071bd0db0db", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Here are some users!</h2>\n");
#nullable restore
#line 3 "/Users/johnlondono/Desktop/Coding_Dojo/C#/Wk_1_Assign/View_Model_Fun/Views/Home/Users.cshtml"
 foreach(User person in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 5 "/Users/johnlondono/Desktop/Coding_Dojo/C#/Wk_1_Assign/View_Model_Fun/Views/Home/Users.cshtml"
  Write(person.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 5 "/Users/johnlondono/Desktop/Coding_Dojo/C#/Wk_1_Assign/View_Model_Fun/Views/Home/Users.cshtml"
                     Write(person.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 6 "/Users/johnlondono/Desktop/Coding_Dojo/C#/Wk_1_Assign/View_Model_Fun/Views/Home/Users.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
