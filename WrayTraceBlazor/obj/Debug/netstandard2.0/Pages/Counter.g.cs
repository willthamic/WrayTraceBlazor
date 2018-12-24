#pragma checksum "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a5c1208947733e6a2def5a9756362310df333b"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            builder.OpenElement(1, "p");
            builder.AddContent(2, "Current count: ");
            builder.AddContent(3, currentCount);
            builder.CloseElement();
            builder.AddContent(4, "\n\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(IncrementCount));
            builder.AddContent(8, "Click me");
            builder.CloseElement();
            builder.AddContent(9, "\n\n");
            builder.OpenElement(10, "button");
            builder.AddAttribute(11, "class", "btn btn-primary");
            builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(RenderTable));
            builder.AddContent(13, "Render");
            builder.CloseElement();
            builder.AddContent(14, "\n\n");
            builder.OpenElement(15, "input");
            builder.AddAttribute(16, "type", "checkbox");
            builder.AddAttribute(17, "checked", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(fast));
            builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => fast = __value, fast));
            builder.CloseElement();
            builder.AddContent(19, "\n\n");
            builder.OpenElement(20, "p");
            builder.AddContent(21, status);
            builder.CloseElement();
            builder.AddContent(22, "\n\n");
            builder.OpenElement(23, "div");
            builder.AddAttribute(24, "style", "display:flex; flex-direction:row;");
            builder.AddContent(25, "\n");
#line 16 "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Counter.cshtml"
     for (int i = 0; i < table.GetLength(0); i++)
    {

#line default
#line hidden
            builder.AddContent(26, "    ");
            builder.OpenElement(27, "div");
            builder.AddAttribute(28, "style", "display:flex; flex-direction:column;");
            builder.AddContent(29, "\n");
#line 19 "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Counter.cshtml"
         for (int j = 0; j < table.GetLength(1); j++)
        {

#line default
#line hidden
            builder.AddContent(30, "            ");
            builder.OpenElement(31, "div");
            builder.AddAttribute(32, "style", "background-color:" + " " + (table[i, j]) + ";" + " width:calc(" + (scale) + " *" + " 1px);" + " height:calc(" + (scale) + " *" + " 1px)");
            builder.CloseElement();
            builder.AddContent(33, "\n");
#line 22 "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Counter.cshtml"
        }

#line default
#line hidden
            builder.AddContent(34, "    ");
            builder.CloseElement();
            builder.AddContent(35, "\n");
#line 24 "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Counter.cshtml"
    }

#line default
#line hidden
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 27 "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Counter.cshtml"
            
    int currentCount = 10;

    String status = "";

    int scaleH = 10;
    int widthH = 100;
    int heightH = 100;

    int scaleL = 50;
    int widthL = 20;
    int heightL = 20;

    int scale = 1;
    int width = 50;
    int height = 50;

    bool fast;
    String[,] table = new String[100, 100];
    String[,] table0 = { { "rgb(10,10,10)" }, { "rgb(100,100,100)" } };

    void IncrementCount()
    {
        currentCount++;
    }

    void RenderTable()
    {
        if (fast)
        {
            width = widthL;
            height = widthL;
            scale = scaleL;
        }
        else
        {
            width = widthH;
            height = widthH;
            scale = scaleH;
        }

        Camera camera = new Camera(V(2, -4, 4) * 1.5f, V(-.5f, 1, -.75f).Unit(), 1.2f, width, height);
        Parallelogram floor = new Parallelogram(V(-10, 10, 0), V(-10, -10, 0), V(10, -10, 0));
        Paralleloid cube = new Paralleloid(V(1, 1, 0), V(1, -1, 0), V(-1, 1, 0), V(1, 1, 2));
        Paralleloid cube2 = new Paralleloid(V(0.866025404f, 0.5f, 2), V(0.5f, -0.866025404f, 2), V(-0.5f, 0.866025404f, 2), V(0.866025404f, 0.5f, 3.41f));

        Light light1 = new Light(V(20, -14, 30), 4000);
        Light light2 = new Light(V(15, -14, 30), 5000);


        List<Element> elements = new List<Element>();
        elements.Add(floor);
        elements.Add(cube);
        elements.Add(cube2);

        List<Light> lights = new List<Light>();
        lights.Add(light1);

        Scene scene = new Scene(camera);
        scene.elements = elements;
        scene.lights = lights;

        //Color[,] color = scene.Render(ref status);

        table = new String[width, height];
        //for (int i = 0; i < width; i++)
        //{
        //    for (int j = 0; j < height; j++)
        //    {
        //        table[i, j] = "rgb(" + color[i, j].R + "," + color[i, j].G + "," + color[i, j].B + ")";
        //    }
        //}

        float[,] imageValues = scene.GetIntensityValues(ref status);
        float maxIntensity = (from float v in imageValues select v).Max();

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {

                int intensity = Convert.ToInt32(imageValues[x, y] / maxIntensity * 255);
                table[x, y] = "rgb(" + intensity + "," + intensity + "," + intensity + ")";

            }
        }
    }

    static Vector3 V(float x0, float y0, float z0)
    {
        return new Vector3(x0, y0, z0);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591