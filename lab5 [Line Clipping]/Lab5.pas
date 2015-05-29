Uses GraphABC;

Type
    Vec2x2 = Record
        x1, y1, x2, y2 : Double;
    end;

Var 
    n, i, wsizeX, wsizeY  : Integer;
    lines : Array of Vec2x2;
    wind, cur : Vec2x2;

Procedure LoadData;
var 
    t : Text; 
    i : Integer;
begin
    Assign(t, 'input.txt');
    Reset(t);
    ReadLn(t, n);
    lines := new Vec2x2[n];
    For i := 0 to n - 1 do
        Readln(t, lines[i].x1, lines[i].y1, lines[i].x2, lines[i].y2);
    Readln(t, wind.x1, wind.y1, wind.x2, wind.y2);
    Close(t);
end;

Procedure TranslateScale;
var
    i : Integer;
    minX, minY, maxX, maxY, sizeX, sizeY : Double;
begin
    minX := wind.x1;
    minY := wind.y1;
    maxX := wind.x2;
    maxY := wind.y2;
    For i := 0 to n - 1 do
    begin
        if minX > lines[i].x1 then minX := lines[i].x1;
        if minX > lines[i].x2 then minX := lines[i].x2;
        if maxX < lines[i].x1 then maxX := lines[i].x1;
        if maxX < lines[i].x2 then maxX := lines[i].x2;
        if minY > lines[i].y1 then minY := lines[i].y1;
        if minY > lines[i].y2 then minY := lines[i].y2;
        if maxY < lines[i].y1 then maxY := lines[i].y1;
        if maxY < lines[i].y2 then maxY := lines[i].y2;
    end;
    sizeX := maxX - minX;
    sizeY := maxY - minY;
    For i := 0 to n - 1 do
    begin
        lines[i].x1 := (lines[i].x1 - minX) / sizeX;
        lines[i].x2 := (lines[i].x2 - minX) / sizeX;
        lines[i].y1 := (lines[i].y1 - minY) / sizeY;
        lines[i].y2 := (lines[i].y2 - minY) / sizeY;
    end;
    wind.x1 := (wind.x1 - minX) / sizeX;
    wind.x2 := (wind.x2 - minX) / sizeX;
    wind.y1 := (wind.y1 - minY) / sizeY;
    wind.y2 := (wind.y2 - minY) / sizeY;
end;

function VisibleLine(var minT, maxT: Double; p, q: double):Boolean;
var
    t: Double;
begin
    Result := true;
    if (p = 0) then begin
        if (q < 0) then
            Result := false;
    end else begin
        t := q / p;
        if (p < 0) then begin
            if (t > maxT) then
                Result := false
            else if (t > minT) then
                minT := t;
        end else begin
            if (t < minT) then
                Result := false
            else if (t < maxT) then
                maxT := t;
        end;
    end;
end;

function CutLine(lin: Vec2x2): Vec2x2;
var
  minT, maxT: double;
  dx, dy: double;
  t: double;
  box: Vec2x2;
  ans: Vec2x2;
begin
  box := wind;
  if box.x1 > box.x2 then
  begin
    t := box.x1;
    box.x1 := box.x2;
    box.x2 := t;
  end;
  if box.y1 < box.y2 then
  begin
    t := box.y1;
    box.y1 := box.y2;
    box.y2 := t;
  end;
  minT := 0;
  maxT := 1;
  dx := lin.x2 - lin.x1;
  dy := lin.y2 - lin.y1;
  ans := lin;
  if (VisibleLine(minT, maxT, -dx, lin.x1 - box.x1)) then
    if (VisibleLine(minT, maxT, dx, box.x2 - lin.x1)) then
      if (VisibleLine(minT, maxT, -dy, lin.y1 - box.y2)) then
        if (VisibleLine(minT, maxT, dy, box.y1 - lin.y1)) then
        begin
            if (maxT < 1) then begin
                ans.x2 := (lin.x1 + maxT * dx);
                ans.y2 := (lin.y1 + maxT * dy);
            end;
            if (minT > 0) then begin
                ans.x1 := (lin.x1 + minT * dx);
                ans.y1 := (lin.y1 + minT * dy);
            end;
        end;
  CutLine := ans;
end;

Procedure CutLineLB (l : Vec2x2);
var
    cur : Vec2x2;
begin
    cur := CutLine(l);
    Line(Round(10+(wsizeX div 2 - 20)*cur.x1), Round(wsizeY-10-(wsizeY-20)*cur.y1),
         Round(10+(wsizeX div 2 - 20)*cur.x2), Round(wsizeY-10-(wsizeY-20)*cur.y2));
end;

Function GetCode(x, y : Double) : Integer;
var code : Integer;
begin
    code := 0;
    if x < wind.x1 then code := code + 8;
    if x > wind.x2 then code := code + 4;
    if y < wind.y1 then code := code + 2;
    if y > wind.y2 then code := code + 1;
    GetCode := code;
end;

Procedure CutLineMP (l : Vec2x2);
const
    eps = 0.00001;
var
    l1, l2 : Vec2x2;
    c1, c2 : Integer;
begin
    c1 := GetCode(l.x1, l.y1);
    c2 := GetCode(l.x2, l.y2);
    
    if (c1 = 0) and (c2 = 0) then
        Line(Round(wsizeX div 2 + 10+(wsizeX div 2 - 20)*l.x1), Round(wsizeY-10-(wsizeY-20)*l.y1),
             Round(wsizeX div 2 + 10+(wsizeX div 2 - 20)*l.x2), Round(wsizeY-10-(wsizeY-20)*l.y2))
    else if ( (c1 and c2) = 0 ) and ( (l.x2-l.x1)*(l.x2-l.x1)+(l.y2-l.y1)*(l.y2-l.y1) > eps ) then begin
        l1 := l;
        l1.x1 := (l.x2 + l.x1) / 2;
        l1.y1 := (l.y2 + l.y1) / 2;
        l2 := l;
        l2.x2 := l1.x1;
        l2.y2 := l1.y1;
        CutLineMP(l2);
        CutLineMP(l1);
    end;
end;

Begin
    LoadData;
    
    TranslateScale;
    
    wsizeX := 1000; wsizeY := 500;
    InitWindow(100, 100, wsizeX, wsizeY, Color.Black);
    SetWindowTitle('Алгоритм Лианга-Барского (слева) и алгоритм средней точки (справа)');
    SetPenColor(Color.White);
    Line(wsizeX div 2, 0, wsizeX div 2, wsizeY);
    
    SetPenColor(Color.Yellow);
    DrawRectangle(Round(10+(wsizeX div 2 - 20)*wind.x1), Round(wsizeY-10-(wsizeY-20)*wind.y1),
                  Round(10+(wsizeX div 2 - 20)*wind.x2), Round(wsizeY-10-(wsizeY-20)*wind.y2));
    DrawRectangle(Round(wsizeX div 2 + 10+(wsizeX div 2 - 20)*wind.x1), Round(wsizeY-10-(wsizeY-20)*wind.y1),
                  Round(wsizeX div 2 + 10+(wsizeX div 2 - 20)*wind.x2), Round(wsizeY-10-(wsizeY-20)*wind.y2));
    
    SetPenColor(Color.Red);
    For i := 0 to n - 1 do
    begin
        Line(Round(10+(wsizeX div 2 - 20)*lines[i].x1), Round(wsizeY-10-(wsizeY-20)*lines[i].y1),
             Round(10+(wsizeX div 2 - 20)*lines[i].x2), Round(wsizeY-10-(wsizeY-20)*lines[i].y2));
        Line(Round(wsizeX div 2 + 10+(wsizeX div 2 - 20)*lines[i].x1), Round(wsizeY-10-(wsizeY-20)*lines[i].y1),
             Round(wsizeX div 2 + 10+(wsizeX div 2 - 20)*lines[i].x2), Round(wsizeY-10-(wsizeY-20)*lines[i].y2));
    end;
    
    SetPenColor(Color.Lime);
    For i := 0 to n - 1 do
    begin
        CutLineLB(lines[i]);
        CutLineMP(lines[i]);
        Line(Round(wsizeX div 2 + 10+(wsizeX div 2 - 20)*cur.x1), Round(wsizeY-10-(wsizeY-20)*cur.y1),
             Round(wsizeX div 2 + 10+(wsizeX div 2 - 20)*cur.x2), Round(wsizeY-10-(wsizeY-20)*cur.y2));
    end;
End.