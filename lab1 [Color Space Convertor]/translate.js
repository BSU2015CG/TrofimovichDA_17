function translateRGB2CMYK(rgb) {
    var c = 255 - rgb.r,
        m = 255 - rgb.g,
        y = 255 - rgb.b,
        k = Math.min(c, m, y);

    return {c:c, m:m, y:y, k:k};
}

function translateCMYK2RGB(cmyk) {
    var r = Math.round(255 - cmyk.c),
        g = Math.round(255 - cmyk.m),
        b = Math.round(255 - cmyk.y);

    return {r:r, g:g, b:b};
}

function translateRGB2HSL(rgb) {
    var r = ( rgb.r / 255 );                    //RGB from 0 to 255
    var g = ( rgb.g / 255 );
    var b = ( rgb.b / 255 );

    var vmin = Math.min( r, g, b );   //Min. value of RGB
    var vmax = Math.max( r, g, b );   //Max. value of RGB
    var dmax = vmax - vmin;            //Delta RGB value

    var l = ( vmax + vmin ) / 2;
    var h;
    var s;

    if ( dmax == 0 ) {                    //This is a gray, no chroma...
        h = 0;                               //HSL results from 0 to 1
        s = 0;
    } else {                                   //Chromatic data...
        if ( l < 0.5 ) s = dmax / ( vmax + vmin );
        else           s = dmax / ( 2 - vmax - vmin );

        var dr = ( ( ( vmax - r ) / 6 ) + ( dmax / 2 ) ) / dmax;
        var dg = ( ( ( vmax - g ) / 6 ) + ( dmax / 2 ) ) / dmax;
        var db = ( ( ( vmax - b ) / 6 ) + ( dmax / 2 ) ) / dmax;

        if      ( r == vmax ) h = db - dg;
        else if ( g == vmax ) h = ( 1 / 3 ) + dr - db;
        else if ( b == vmax ) h = ( 2 / 3 ) + dg - dr;

        if ( h < 0 ) h += 1;
        if ( h > 1 ) h -= 1;
    }
    return { h:Math.round(h*359), s:Math.round(s*99), l:Math.round(l*99) };
}

function translateHSL2RGB(hsl) {
    var h = hsl.h/359;
    var s = hsl.s/99;
    var l = hsl.l/99;
    var R, G, B, var_1, var_2;
    if ( s == 0 )                       //HSL from 0 to 1
    {
        R = l * 255;                      //RGB results from 0 to 255
        G = l * 255;
        B = l * 255;
    }
    else
    {
        if ( l < 0.5 ) var_2 = l * ( 1 + s );
        else           var_2 = ( l + s ) - ( s * l );

        var_1 = 2 * l - var_2;

        R = 255 * Hue_2_RGB( var_1, var_2, h + ( 1 / 3 ) );
        G = 255 * Hue_2_RGB( var_1, var_2, h );
        B = 255 * Hue_2_RGB( var_1, var_2, h - ( 1 / 3 ) );
    }
    return {r:Math.round(R), g:Math.round(G), b:Math.round(B)};

    function Hue_2_RGB( v1, v2, vH )             //Function Hue_2_RGB
    {
        if ( vH < 0 ) vH += 1;
        if ( vH > 1 ) vH -= 1;
        if ( ( 6 * vH ) < 1 ) return ( v1 + ( v2 - v1 ) * 6 * vH );
        if ( ( 2 * vH ) < 1 ) return ( v2 );
        if ( ( 3 * vH ) < 2 ) return ( v1 + ( v2 - v1 ) * ( ( 2 / 3 ) - vH ) * 6 );
        return ( v1 )
    }
}

function translateXYZ2LUV(xyz) {
    var Yn = 100.0;
    var Y_Yn = xyz.y / Yn;
    var La = ( Y_Yn <= Math.pow(6/29, 3) )
            ? Math.pow(29/3, 3) * Y_Yn
            : 116 * Math.pow(Y_Yn, 1/3) - 16;
    var den = xyz.x + 15 * xyz.y + 3 * xyz.z;
    var L = xyz.y;
    var u1 = 4 * xyz.x / den;
    var v1 = 9 * xyz.y / den;
    return { l: Math.round(L),
             u: Math.round(u1*100),
             v: Math.round(v1*100)
            };
}

function translateLUV2XYZ(luv) {
    var Y = luv.l;
    var u = luv.u / 100;
    var v = luv.v / 100;
    var X = Y * ( 9 * u ) / ( 4 * v );
    var Z = Y * ( 12 - 3 * u - 20 * v ) / ( 4 * v );
    return {x:X, y:Y, z:Z};
}

function translateRGB2XYZ(rgb) {
    var var_R = ( rgb.r / 255 );        //R from 0 to 255
    var var_G = ( rgb.g / 255 );        //G from 0 to 255
    var var_B = ( rgb.b / 255 );        //B from 0 to 255

    if ( var_R > 0.04045 ) var_R = Math.pow ( ( ( var_R + 0.055 ) / 1.055 ) , 2.4 );
    else                   var_R = var_R / 12.92;
    if ( var_G > 0.04045 ) var_G = Math.pow ( ( ( var_G + 0.055 ) / 1.055 ) , 2.4 );
    else                   var_G = var_G / 12.92;
    if ( var_B > 0.04045 ) var_B = Math.pow ( ( ( var_B + 0.055 ) / 1.055 ) , 2.4 );
    else                   var_B = var_B / 12.92;

    var_R = var_R * 100;
    var_G = var_G * 100;
    var_B = var_B * 100;

    //Observer. = 2°, Illuminant = D65
    return { x: var_R * 0.4124 + var_G * 0.3576 + var_B * 0.1805,
             y: var_R * 0.2126 + var_G * 0.7152 + var_B * 0.0722,
             z: var_R * 0.0193 + var_G * 0.1192 + var_B * 0.9505 }
}

function translateXYZ2RGB(xyz) {
    var var_X = xyz.x / 100;        //X from 0 to  95.047      (Observer = 2°, Illuminant = D65)
    var var_Y = xyz.y / 100;        //Y from 0 to 100.000
    var var_Z = xyz.z / 100;        //Z from 0 to 108.883

    var var_R = var_X * ( 3.2406)  + var_Y * (-1.5372) + var_Z * (-0.4986);
    var var_G = var_X * (-0.9689)  + var_Y * (1.8758 ) + var_Z * ( 0.0415);
    var var_B = var_X * ( 0.0557)  + var_Y * (-0.2040) + var_Z * ( 1.0570);

    if ( var_R > 0.0031308 ) var_R = 1.055 * ( Math.pow( var_R , ( 1 / 2.4 ) ) ) - 0.055;
    else                     var_R = 12.92 * var_R;
    if ( var_G > 0.0031308 ) var_G = 1.055 * ( Math.pow( var_G , ( 1 / 2.4 ) ) ) - 0.055;
    else                     var_G = 12.92 * var_G;
    if ( var_B > 0.0031308 ) var_B = 1.055 * ( Math.pow( var_B , ( 1 / 2.4 ) ) ) - 0.055;
    else                     var_B = 12.92 * var_B;

    return { r:Math.round(var_R * 255),
             g:Math.round(var_G * 255),
             b:Math.round(var_B * 255) };
}

function translateLUV2RGB(luv) {
    if (luv.l == 0) return {r:0, g:0, b:0};
    return translateXYZ2RGB(translateLUV2XYZ(luv));
}

function translateRGB2LUV(rgb) {
    if (rgb.r == 0 && rgb.b == 0 && rgb.g == 0)
        return {l:0, u:20, v:47};
    return translateXYZ2LUV(translateRGB2XYZ(rgb));
}