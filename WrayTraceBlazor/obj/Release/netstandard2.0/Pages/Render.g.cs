#pragma checksum "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Render.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f228edf9351d1d4b43df0d592e70fadf7c395e27"
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
    using System.Diagnostics;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/render")]
    public class Render : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            builder.OpenElement(1, "p");
            builder.AddContent(2, "Total Time: ");
            builder.AddContent(3, totalTime);
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
            builder.OpenElement(15, "button");
            builder.AddAttribute(16, "class", "btn btn-primary");
            builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(BigTest));
            builder.AddContent(18, "BigTest");
            builder.CloseElement();
            builder.AddContent(19, "\n\n");
            builder.OpenElement(20, "input");
            builder.AddAttribute(21, "type", "checkbox");
            builder.AddAttribute(22, "checked", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(fast));
            builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => fast = __value, fast));
            builder.CloseElement();
            builder.AddMarkupContent(24, "\n\n<div id=\"canvasContainer\"></div>\n\n");
            builder.OpenElement(25, "p");
            builder.AddContent(26, status);
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 20 "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Render.cshtml"
            
    int currentCount = 10;

    String status = "";

    String totalTime;

    int scaleH = 5;
    int widthH = 256;
    int heightH = 4256;

    int scaleL = 50;
    int widthL = 20;
    int heightL = 20;

    int scale = 1;
    int width = 50;
    int height = 50;

    bool fast;
    //String[,] table = new String[100, 100];
    //String[,] table0 = { { "rgb(10,10,10)" }, { "rgb(100,100,100)" } };

    void IncrementCount()
    {
        currentCount++;
    }

    void BigTest()
    {
        JSRuntime.Current.InvokeAsync<string>("canvasFunctions.createCanvas",100,100);
    }

    void RenderTable()
    {
        Stopwatch totalStopwatch = new Stopwatch();

        totalStopwatch.Start();

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

        Camera camera = new Camera(V(2, -4, 4) * 1.5f, V(-.5f, 1, -.75f).Unit(), 1.0f, width, height);
        Parallelogram floor = new Parallelogram(V(-10, 10, 0), V(-10, -10, 0), V(10, -10, 0));
        Parallelepiped cube = new Parallelepiped(V(1, 1, 0), V(1, -1, 0), V(-1, 1, 0), V(1, 1, 2));
        //Parallelepiped cube2 = new Parallelepiped(V(0.866025404f, 0.5f, 2), V(0.5f, -0.866025404f, 2), V(-0.5f, 0.866025404f, 2), V(0.866025404f, 0.5f, 3.41f));
        Sphere sphere = new Sphere(V(2, 0, 0.5f), 1f);
        //Cube cube = new Cube(V(2, 0, 0.5f), 1);

        Light light1 = new Light(V(20, -14, 30), 4000);
        Light light2 = new Light(V(15, -14, 30), 5000);

        List<Element> elements = new List<Element>();
        elements.Add(floor);
        //elements.Add(cube);
        //elements.Add(cube2);
        elements.Add(sphere);
        elements.Add(cube);

        List<Light> lights = new List<Light>();
        lights.Add(light1);

        Scene scene = new Scene(camera);
        scene.elements = elements;
        scene.lights = lights;

        //table = new String[width, height];

        float[,] imageValues = scene.GetIntensityValues(ref status);
        int[,] imageValuesInt = new int[width, height];

        float maxIntensity = (from float v in imageValues select v).Max();

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                int intensity = Convert.ToInt32(imageValues[x, y] / maxIntensity * 255);
                imageValuesInt[y, x] = intensity;
                //table[x, y] = "rgb(" + intensity + "," + intensity + "," + intensity + ")";
            }
        }

        JSRuntime.Current.InvokeAsync<string>("canvasFunctions.displayData", imageValuesInt, width, height);

        totalTime = totalStopwatch.ElapsedMilliseconds / 1000.0 + "s";
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
