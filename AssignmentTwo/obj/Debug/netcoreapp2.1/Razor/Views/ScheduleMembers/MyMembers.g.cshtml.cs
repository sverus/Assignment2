#pragma checksum "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\ScheduleMembers\MyMembers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b5276ddb29e83f16dd9725306b484f2340ea3fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ScheduleMembers_MyMembers), @"mvc.1.0.view", @"/Views/ScheduleMembers/MyMembers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ScheduleMembers/MyMembers.cshtml", typeof(AspNetCore.Views_ScheduleMembers_MyMembers))]
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
#line 1 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\_ViewImports.cshtml"
using AssignmentTwo;

#line default
#line hidden
#line 2 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\_ViewImports.cshtml"
using AssignmentTwo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b5276ddb29e83f16dd9725306b484f2340ea3fd", @"/Views/ScheduleMembers/MyMembers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ecad10167ff3f672f4915b95532897b676a5cd9", @"/Views/_ViewImports.cshtml")]
    public class Views_ScheduleMembers_MyMembers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AssignmentTwo.Models.ScheduleMembers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
#line 3 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\ScheduleMembers\MyMembers.cshtml"
  
    ViewData["Title"] = "My Members";

#line default
#line hidden
            BeginContext(110, 204, true);
            WriteLiteral("\r\n    <h2>My Enrolled Members</h2>\r\n<p>This page will only populate if you have members enrolled to your schedule.</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(315, 46, false);
#line 13 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\ScheduleMembers\MyMembers.cshtml"
           Write(Html.DisplayNameFor(model => model.ScheduleId));

#line default
#line hidden
            EndContext();
            BeginContext(361, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(417, 47, false);
#line 16 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\ScheduleMembers\MyMembers.cshtml"
           Write(Html.DisplayNameFor(model => model.MemberEmail));

#line default
#line hidden
            EndContext();
            BeginContext(464, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(520, 46, false);
#line 19 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\ScheduleMembers\MyMembers.cshtml"
           Write(Html.DisplayNameFor(model => model.CoachEmail));

#line default
#line hidden
            EndContext();
            BeginContext(566, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\ScheduleMembers\MyMembers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(701, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(762, 45, false);
#line 29 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\ScheduleMembers\MyMembers.cshtml"
               Write(Html.DisplayFor(modelItem => item.ScheduleId));

#line default
#line hidden
            EndContext();
            BeginContext(807, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(875, 46, false);
#line 32 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\ScheduleMembers\MyMembers.cshtml"
               Write(Html.DisplayFor(modelItem => item.MemberEmail));

#line default
#line hidden
            EndContext();
            BeginContext(921, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(989, 45, false);
#line 35 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\ScheduleMembers\MyMembers.cshtml"
               Write(Html.DisplayFor(modelItem => item.CoachEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 46, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 39 "D:\BIT\HIT339\Assignment2\Assignment2\assignment2\AssignmentTwo\Views\ScheduleMembers\MyMembers.cshtml"
        }

#line default
#line hidden
            BeginContext(1091, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AssignmentTwo.Models.ScheduleMembers>> Html { get; private set; }
    }
}
#pragma warning restore 1591