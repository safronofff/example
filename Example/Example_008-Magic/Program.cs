﻿Console.Clear();

//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 20;
int ya = 1;
int xb = 1;
int yb = 20;
int xc = 40;
int yc = 20;

/*int xa = 20, ya = 1,
	xb = 1, yb = 20,
	xc = 40, yc = 20;*/

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0;

while (count < 10000)
{
	int what = new Random().Next(0, 3); //[0,3) 0,1,2

	if (what == 0)
	{
		x = (x + xa) / 2;
		y = (y + ya) / 2;
	}

	if (what == 1)
	{
		x = (x + xb) / 2;
		y = (y + yb) / 2;
	}

	if (what == 2)
	{
		x = (x + xc) / 2;
		y = (y + yc) / 2;
	}

	Console.SetCursorPosition(x, y);
	Console.WriteLine("+");
	count++;
}