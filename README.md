# WrayTraceBlazor

A web version of my ray tracer.


## A timeline of rendering efficiency (or lack there-of):

The image that is rendered is the following 200x200 pixel image with 2 cubes, a ground plane and a single light. All of these numbers could be described as iffy at best but as a general rule seem to demonstrate that it gets faster as I add improvements to the various algorithms.

All values are the average of 3 trials ran on my laptop with minimal other programs open. 

### Initial: *3:36.181s*
The ray-tracer ran attrociously slowly at first but this was due to a variety of issues that I slowly whittled away at.

### Switched to new ray-triangle intersection algorithm: *2:09.260s*
I initial wrote my own algorithm to determine if a ray in 3-space passes through a triangle defined by three points. I did this by calculating the angle between the point of intersection on the triangle's plane and the vertices of the triangle. They should add up to 360 degrees if the point is inside the triangle but this turns out to be a bit slow. I switch to a new algorithm I found online that compares various normals to essentially determine if it is inside or not. This dramamtically improves performance.

### Switched to Firefox *38.276s*
It turns out firefox's webassembly engine is way better that chrome's engine. This is probably going to be the largest speed increase in the renderer I will ever see.

### Parallelized the C# rendering loop *55.665s*
Turns out this isn't well optimized in firefox (or any broswer at this time). Only about 25% of the cpu is used for the processing compared to around 100% when I run this natively. Let's undo that.

### Adding inscribed spheres and spherical envelopes **
