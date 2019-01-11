window.canvasFunctions = {
    createCanvas: function (width, height) {
        var element = document.getElementById("canvasContainer");
        element.innerHTML = '<canvas id="renderCanvas" width="' + width + '" height="' + height + '"></canvas>';
    },
    displayData: function (data, width, height) {
        var element = document.getElementById("canvasContainer");
        element.innerHTML = '<canvas id="renderCanvas" width="' + width + '" height="' + height + '"></canvas>';
        var canvas = document.getElementById("renderCanvas");
        var ctx = canvas.getContext("2d");
        var imgData = ctx.createImageData(width, height);

        console.log(imgData);

        for (var i = 0; i < data.length; i += 1) {
            //var x = Math.floor((i / 4) % width);
            //var y = Math.floor(i / (4 * width));
            imgData.data[4 * i + 0] = data[i];
            imgData.data[4 * i + 1] = data[i];
            imgData.data[4 * i + 2] = data[i];
            imgData.data[4 * i + 3] = 255;
        }
        console.log(imgData);
        ctx.putImageData(imgData, 0, 0);
    }
};