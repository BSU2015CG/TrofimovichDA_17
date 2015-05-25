function updateCurrentColor()
{
    $("#currentcolor").css("background-color", "rgb(" + currentColor.r + "," + currentColor.g + "," + currentColor.b + ")");
}

function updateRBGTrackColor(context, isRed, isGreen, isBlue) {
    var grd = context.createLinearGradient(0,0,256,0);
    grd.addColorStop(0, "rgb(" + (isRed?0:RGBredT.value) + "," + (isGreen?0:RGBgreenT.value) + "," + (isBlue?0:RGBblueT.value) + ")");
    grd.addColorStop(1, "rgb(" + (isRed?255:RGBredT.value) + "," + (isGreen?255:RGBgreenT.value) + "," + (isBlue?255:RGBblueT.value) + ")");
    context.fillStyle = grd;
    context.fillRect(0,0,256,20);
}

function updateCMYTrackColor(context, isCyan, isMagenta, isYellow) {
    var grd = context.createLinearGradient(0,0,256,0);
    var leftColor = translateCMYK2RGB({c:isCyan?0:CMYcyanT.value, m:isMagenta?0:CMYmagentaT.value, y:isYellow?0:CMYyellowT.value});
    var rightColor = translateCMYK2RGB({c:isCyan?255:CMYcyanT.value, m:isMagenta?255:CMYmagentaT.value, y:isYellow?255:CMYyellowT.value});
    grd.addColorStop(0, "rgb(" + leftColor.r + "," + leftColor.g + "," + leftColor.b + ")" );
    grd.addColorStop(1, "rgb(" + rightColor.r + "," + rightColor.g + "," + rightColor.b + ")" );
    context.fillStyle = grd;
    context.fillRect(0,0,256,20);
}

function updateHSLTrackColor(context, isHue, isSaturation, isLightness) {
    var grd = context.createLinearGradient(0,0,256,0);
    if ( isHue ) {
        var cols = ["#FF0000","#FFFF00","#00FF00","#00FFFF","#0000FF","#FF00FF","#FF0000"];
        for ( var i = 0 ; i < 7 ; ++ i )
            grd.addColorStop(i/6, cols[i]);
    } else {
        var leftColor = translateHSL2RGB({h: HSLhueT.value, s: isSaturation?0:HSLsaturationT.value, l: isLightness?0:HSLlightnessT.value});
        var rightColor = translateHSL2RGB({h: HSLhueT.value, s: isSaturation?99:HSLsaturationT.value, l: isLightness?99:HSLlightnessT.value});
        grd.addColorStop(0, "rgb(" + leftColor.r + "," + leftColor.g + "," + leftColor.b + ")");
        if ( isLightness ) {
            var midColor = translateHSL2RGB({h: HSLhueT.value, s: HSLsaturationT.value, l: 50});
            grd.addColorStop(0.5, "rgb(" + midColor.r + "," + midColor.g + "," + midColor.b + ")");
        }
        grd.addColorStop(1, "rgb(" + rightColor.r + "," + rightColor.g + "," + rightColor.b + ")");
    }
    context.fillStyle = grd;
    context.fillRect(0,0,256,20);
}

function updateHSLCircle(el) {
    var cont = el.context;
    var radius = el.radius;
    var width = el.cwidth;
    var sradius = el.sradius;
    var qrad = el.qrad;
    var pure = translateHSL2RGB({h:HSLhueT.value, s:99, l:49});
    cont.clearRect(0, 0, 2*radius, 2*radius);
    cont.translate(radius, radius);

    /*Square*/
    var gra = cont.createLinearGradient(-qrad,0,qrad,0);
    gra.addColorStop(0.0,"rgba(128,128,128,1.0)");
    gra.addColorStop(1.0,"rgba(" + pure.r + "," + pure.g + "," + pure.b + ",1.0)");
    cont.fillStyle = gra;
    cont.fillRect(-qrad,-qrad,qrad*2,qrad*2);
    gra = cont.createLinearGradient(0,-qrad,0,qrad);
    gra.addColorStop(0.0,"rgba(255,255,255,1.0)");
    gra.addColorStop(0.5,"rgba(255,255,255,0.0)");
    gra.addColorStop(0.5,"rgba(  0,  0,  0,0.0)");
    gra.addColorStop(1.0,"rgba(  0,  0,  0,1.0)");
    cont.fillStyle = gra;
    cont.fillRect(-qrad,-qrad,qrad*2,qrad*2);

    /*Sectors*/
    var cols = ["#FF0000","#FFFF00","#00FF00","#00FFFF","#0000FF","#FF00FF","#FF0000"];
    cont.lineWidth = width;
    for ( var sec = 0 ; sec < 6 ; ++ sec ) {
        cont.rotate(- Math.PI / 3);
        cont.beginPath();
        gra = cont.createLinearGradient(
            sradius, 0,
            sradius * Math.cos(Math.PI / 3), sradius * Math.sin(Math.PI / 3));
        gra.addColorStop(0.0, cols[sec+1]);
        gra.addColorStop(1.0, cols[sec]);
        cont.strokeStyle = gra;
        cont.arc(0, 0, radius - width / 2, -0.01, Math.PI / 3);
        cont.stroke();
    }

    /*Line*/
    cont.beginPath();
    cont.lineWidth = 1;
    cont.strokeStyle = "white";
    cont.moveTo(HSLsaturationT.value / 99 * 2 * qrad - qrad,
        qrad - HSLlightnessT.value / 99 * 2 * qrad);
    var sr = radius - width/2;
    cont.lineTo(sr * Math.cos(HSLhueT.value * 2*Math.PI / 359), - sr * Math.sin(HSLhueT.value * 2*Math.PI / 359));
    cont.stroke();

    cont.translate(-radius, -radius);
}

function updateLUVTrackColor(context, isL, isU, isV) {
    var step = 4;
    context.clearRect(0, 0, 256, 20);
    var grd = context.createLinearGradient(0, 0, 256, 0);
    for ( var i = 0 ; i <= 256 ; i += step ) {
        var color = translateLUV2RGB({l: isL?(i/256*100):LUVlT.value, u: isU?((i-128)/128*100):LUVuT.value, v: isV?((i-128)/128*100):LUVvT.value});

        var valpha = 1.0;
        if (!f(color)) { color = {r:0,g:0,b:0}; valpha = 0.0; }
        grd.addColorStop(i/256, "rgba(" + color.r + "," + color.g + "," + color.b + "," + valpha + ")");
    }
    context.fillStyle = grd;
    context.fillRect(0, 0, 256, 20);

    function f(rgb) {
        return (rgb.r>=0&&rgb.g>=0&&rgb.b>=0&&rgb.r<=255&&rgb.g<=255&&rgb.b<=255);
    }
}