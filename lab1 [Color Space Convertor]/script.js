var currentColor = {r:0, g:0, b:0};

// #### RGB
function setByRGB() { currentColor = {r:RGBredT.value, g:RGBgreenT.value, b:RGBblueT.value} }
function recalcRGB() {
    RGBredT.changeValue(currentColor.r);
    RGBgreenT.changeValue(currentColor.g);
    RGBblueT.changeValue(currentColor.b);
}
function RGBchanged() { setByRGB(); recalcCMY(); recalcHSL(); recalcLUV(); updateColors(); }
var RGBredT = new Trackbar("R: ", RGBchanged);
var RGBgreenT = new Trackbar("G: ", RGBchanged);
var RGBblueT = new Trackbar("B: ", RGBchanged);
$("#rgbtrackbox").append(RGBredT.elmnt).append(RGBgreenT.elmnt).append(RGBblueT.elmnt);

// #### CMYK
function setByCMY() { currentColor = translateCMYK2RGB({c:CMYcyanT.value, m:CMYmagentaT.value, y:CMYyellowT.value}) }
function recalcCMY() {
    var col = translateRGB2CMYK(currentColor);
    CMYcyanT.changeValue(col.c);
    CMYmagentaT.changeValue(col.m);
    CMYyellowT.changeValue(col.y);
    CMYblackL.html("K:   " + col.k);
}
function CMYchanged() { setByCMY(); recalcRGB(); recalcHSL(); recalcLUV(); updateColors(); CMYblackL.html("K:   " + translateRGB2CMYK(currentColor).k);}
var CMYcyanT = new Trackbar("C: ", CMYchanged);
var CMYmagentaT = new Trackbar("M: ", CMYchanged);
var CMYyellowT = new Trackbar("Y: ", CMYchanged);
var CMYblackL = $("<span>K:  ???</span>");
$("#cmyktrackbox").append(CMYcyanT.elmnt).append(CMYmagentaT.elmnt).append(CMYyellowT.elmnt).append(CMYblackL);

// #### HSL
function setByHSL() { currentColor = translateHSL2RGB({h:HSLhueT.value, s:HSLsaturationT.value, l:HSLlightnessT.value}) }
function recalcHSL() {
    var col = translateRGB2HSL(currentColor);
    HSLhueT.changeValue(col.h);
    HSLsaturationT.changeValue(col.s);
    HSLlightnessT.changeValue(col.l);
}
function HSLchanged() { setByHSL(); recalcRGB(); recalcCMY(); recalcLUV(); updateColors(); }
var HSLhueT = new Trackbar("H: ", HSLchanged, {start:0, end:359});
var HSLsaturationT = new Trackbar("S: ", HSLchanged, {start:0, end:99});
var HSLlightnessT = new Trackbar("L: ", HSLchanged, {start:0, end:99});
$("#hsltrackbox").append(HSLhueT.elmnt).append(HSLsaturationT.elmnt).append(HSLlightnessT.elmnt);

// #### HSL Circle
var HSLCircleT = new HSLCircle(function(h){
    HSLhueT.drag(Math.round(h/359*255));
}, function(s, l){
    HSLsaturationT.drag(s);
    HSLlightnessT.drag(l);
});
$("#hslcirclebox").append(HSLCircleT.elmnt);

// #### LUV
function setByLUV() { currentColor = translateLUV2RGB({l:LUVlT.value, u:LUVuT.value, v:LUVvT.value}) }
function recalcLUV() {
    var col = translateRGB2LUV(currentColor);
    LUVlT.changeValue(col.l);
    LUVuT.changeValue(col.u);
    LUVvT.changeValue(col.v);
}
function LUVchanged() { setByLUV(); recalcRGB(); recalcCMY(); recalcHSL(); updateColors(); }
var LUVlT = new Trackbar("L: ", LUVchanged, {start:0, end:100});
var LUVuT = new Trackbar("U: ", LUVchanged, {start:-100, end:100});
var LUVvT = new Trackbar("V: ", LUVchanged, {start:-100, end:100});
$("#luvtrackbox").append(LUVlT.elmnt).append(LUVuT.elmnt).append(LUVvT.elmnt);


// #### #### #####
function updateColors() {
    updateCurrentColor();

    updateRBGTrackColor(RGBredT.context,true,false,false);
    updateRBGTrackColor(RGBgreenT.context,false,true,false);
    updateRBGTrackColor(RGBblueT.context,false,false,true);

    updateCMYTrackColor(CMYcyanT.context,true,false,false);
    updateCMYTrackColor(CMYmagentaT.context,false,true,false);
    updateCMYTrackColor(CMYyellowT.context,false,false,true);

    updateHSLTrackColor(HSLhueT.context,true,false,false);
    updateHSLTrackColor(HSLsaturationT.context,false,true,false);
    updateHSLTrackColor(HSLlightnessT.context,false,false,true);

    updateHSLCircle(HSLCircleT);

    updateLUVTrackColor(LUVlT.context,true,false,false);
    updateLUVTrackColor(LUVuT.context,false,true,false);
    updateLUVTrackColor(LUVvT.context,false,false,true);
}

RGBredT.changeValue(0);
RGBgreenT.changeValue(0);
RGBblueT.changeValue(0);
RGBchanged();