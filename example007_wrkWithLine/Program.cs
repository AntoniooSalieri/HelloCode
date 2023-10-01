Console.Clear();
Console.SetCursorPosition(101, 1);
Console.WriteLine("+");
Console.SetCursorPosition(1, 20);
Console.WriteLine("-");

int printX, printY, y;
int lineX=1;
int lineY=1;
while (lineX<101)
{
    Console.SetCursorPosition(lineX ,10);
    Console.WriteLine("-");
    lineX = lineX + 1;
}
while (lineY<20)
{
    Console.SetCursorPosition(51 ,lineY);
    Console.WriteLine("|");
    lineY = lineY + 1;
}
//чертит ость координат

int nummS=0;




int x=nummS;     //созранеие x

while (x<51){

    y=(int)Math.Round(Math.Sin(x));

    printX=51-x*2;
    printY=10-y;
    if (printX>0)
        if (printX<102)
            if (printY>0)
                if (printY<21)
                {
                    Console.SetCursorPosition(printX ,printY);
                    Console.WriteLine("o");
                }

    x=x+1;
}
//чертит до x=0

x=nummS;
while (x>-51){

    y=(int)Math.Round(Math.Sin(x));

    printX=51-x*2;
    printY=10-y;
    if (printX>0)
        if (printX<102)
            if (printY>0)
                if (printY<21)
                {
                    Console.SetCursorPosition(printX ,printY);
                    Console.WriteLine("o");
                }

    x=x-1;
}
//чертит до x=0

Console.SetCursorPosition(20 ,21);


//int xa =1, ya=1, xb=1, yb=30