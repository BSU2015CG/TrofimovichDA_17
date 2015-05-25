// Mouse control

var isMouseDown = false;
$("html")
    .mousedown(function(){ isMouseDown = true; })
    .mouseup(function(){ isMouseDown = false; });

// Trackbar class

function Trackbar(title, onChangeValue, range) {
    var fieldWidth = 256;
    this.elmnt = $("<div>");
    this.title = $("<span class=\"track-title\">" + title + "</span>");
    this.track = $("<div class=\"track\">");
    this.field = $("<canvas class=\"field\" width=\"" + fieldWidth + "\" height=\"20\">");
    this.value = 0;
    this.valel = $("<input type=\"text\" class=\"value\">");
    this.label = $("<div class=\"label\">");
    this.context = this.field[0].getContext("2d");
    this.onChangeValue = onChangeValue;
    this.range = range || {start:0, end:255};
    this.changeValue = function (val) {
        this.valel[0].value = val;
        if ( val < this.range.start || val > this.range.end ) {
            this.label[0].setAttribute("class", "label-broken");
            if ( val < this.range.start )
                val = this.range.start;
            else val = this.range.end;
        } else {
            this.label[0].setAttribute("class", "label");
        }
        this.value = val;
        var offset = Math.round((val - this.range.start) / (this.range.end - this.range.start) * (fieldWidth - 1));
        this.label.css("left", offset+"px");
    };
    this.drag = function (offset) {
        var actual = Math.round(offset / (fieldWidth - 1) * (this.range.end - this.range.start) + this.range.start);
        actual = Math.min(Math.max(actual,this.range.start),this.range.end);
        this.changeValue(actual);
        if ( this.onChangeValue !== undefined )
            this.onChangeValue(this.value);
    };

    var object = this;

    this.field
        .mousedown( function(e){ object.drag(e.offsetX); e.preventDefault(); } ) // Denying selection
        .mousemove( function(e){ if ( isMouseDown ) { object.drag(e.offsetX); } } );

    this.valel.change( function() {
        var actual = Math.min(Math.max(parseInt(this.value)||0,object.range.start),object.range.end);
        object.changeValue(actual);
        if ( object.onChangeValue !== undefined )
            object.onChangeValue(object.value);
    } );

    this.elmnt.append(this.title).append(this.track.append(this.field).append(this.label)).append(this.valel);
}

function HSLCircle(onChangeValueH, onChangeValueSL) {
    this.radius = 128;
    this.cwidth = 30;
    this.sradius = this.radius - this.cwidth;
    this.qrad = this.sradius / Math.sqrt(2);
    this.elmnt = $("<div>");
    this.field = $("<canvas class=\"circle\" width=\"255\" height=\"255\">");
    this.context = this.field[0].getContext("2d");
    this.onChangeValueH = onChangeValueH;
    this.onChangeValueSL = onChangeValueSL;

    this.drag = function (offsetX, offsetY) {
        var r = Math.sqrt(Math.pow(offsetX - this.radius,2) + Math.pow(offsetY - this.radius,2));
        if ( r > this.sradius && r < this.radius ) {
            var valueH;
            valueH = Math.round(Math.atan2(offsetY - this.radius, this.radius - offsetX) / Math.PI * 179 + 180);
            if ( this.onChangeValueH !== undefined )
                this.onChangeValueH(valueH);
        }
        if ( offsetX > this.radius - this.qrad && offsetX < this.radius + this.qrad &&
            offsetY > this.radius - this.qrad && offsetY < this.radius + this.qrad) {
            var valueS, valueL;
            valueS = Math.round((offsetX - this.radius + this.qrad) * this.radius / this.qrad);
            valueL = Math.round((this.radius + this.qrad - offsetY) * this.radius / this.qrad);
            if ( this.onChangeValueSL !== undefined )
                this.onChangeValueSL(valueS, valueL);
        }
    };

    var object = this;

    this.field
        .mousedown( function(e){ object.drag(e.offsetX, e.offsetY); e.preventDefault(); } ) // Denying selection
        .mousemove( function(e){ if ( isMouseDown ) { object.drag(e.offsetX, e.offsetY); } } );

    this.elmnt.append(this.field);
}