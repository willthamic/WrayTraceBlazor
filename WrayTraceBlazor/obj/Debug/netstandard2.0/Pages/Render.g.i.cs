#pragma checksum "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Render.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d81165fe17353059c0ac47bd4e6439c5d76a178"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#line 28 "C:\Users\Will\OneDrive\Mine\Code\C#\WrayTraceBlazor\WrayTraceBlazor\Pages\Render.cshtml"
            
    int currentCount = 10;

    String status = "";

    String totalTime;

    int scaleH = 5;
    int widthH = 200;
    int heightH = 200;

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

        Camera camera = new Camera(V(2, -4, 4) * 1.5f, V(-.5f, 1, -.75f).Unit(), 1.2f, width, height);
        Parallelogram floor = new Parallelogram(V(-10, 10, 0), V(-10, -10, 0), V(10, -10, 0));
        //Paralleloid cube = new Paralleloid(V(1, 1, 0), V(1, -1, 0), V(-1, 1, 0), V(1, 1, 2));
        //Paralleloid cube2 = new Paralleloid(V(0.866025404f, 0.5f, 2), V(0.5f, -0.866025404f, 2), V(-0.5f, 0.866025404f, 2), V(0.866025404f, 0.5f, 3.41f));
        Sphere sphere = new Sphere(V(0, 0, 1), 2f);

        Light light1 = new Light(V(20, -14, 30), 4000);
        Light light2 = new Light(V(15, -14, 30), 5000);

        List<Element> elements = new List<Element>();
        elements.Add(floor);
        //elements.Add(cube);
        //elements.Add(cube2);
        elements.Add(sphere);

        List<Light> lights = new List<Light>();
        lights.Add(light1);

        Scene scene = new Scene(camera);
        scene.elements = elements;
        scene.lights = lights;

        table = new String[width, height];

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
