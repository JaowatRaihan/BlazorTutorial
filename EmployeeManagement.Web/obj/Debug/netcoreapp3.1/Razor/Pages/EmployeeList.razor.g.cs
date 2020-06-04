#pragma checksum "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3bb819062b2b29a71ded953463e5cf00e923a2f"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee List</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 7 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
     foreach(var employee in Employees)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card m-3");
            __builder.AddAttribute(7, "style", "min-width:18rem; max-width:30.5%;");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-header");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "h3");
            __builder.AddContent(13, 
#nullable restore
#line 11 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                     employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 11 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 13 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                           employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, @"<div class=""card-footer text-center"">
                <a href=""#"" class=""btn btn-primary m-1"">View</a>
                <a href=""#"" class=""btn btn-primary m-1"">Edit</a>
                <a href=""#"" class=""btn btn-danger m-1"">Delete</a>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 20 "E:\Blazor Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591