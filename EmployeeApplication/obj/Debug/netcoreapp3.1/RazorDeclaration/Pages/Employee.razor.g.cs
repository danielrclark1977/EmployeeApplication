#pragma checksum "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\Pages\Employee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee6ca494e03ff7d3df6d1a5e528d0a2ae9efb462"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EmployeeApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\_Imports.razor"
using EmployeeApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\_Imports.razor"
using EmployeeApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\Pages\Employee.razor"
using EmployeeApplicationModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\Pages\Employee.razor"
using EmployeeApplication.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee/{Id:int}")]
    public partial class Employee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\danie\source\repos\EmployeeApplication\EmployeeApplication\Pages\Employee.razor"
       
    private EmployeeApplicationModel.Models.Employees employee;
    [Parameter]
    public int Id { get; set; }
    protected async override Task OnInitializedAsync()
    {
        employee = await employeeService.GetEmployeeAsync(Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591
