#pragma checksum "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f535765a70408a0706ffb1b2eca60e5302ea942f"
// <auto-generated/>
#pragma warning disable 1591
namespace WrayTraceBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using WrayTraceBlazor;
    using WrayTraceBlazor.Shared;
    using System.Drawing;
    using Vector;
    using WrayTrace;
    using Geometry;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n");
            builder.OpenComponent<WrayTraceBlazor.Pages.Render>(1);
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
