// Программа,  которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = 3;
int y1 = 6;
int z1 = 8;

int x2 = 2;
int y2 = 1;
int z2 = -7;

int a = x2 - x1;
int b = y2 - y1;
int c = z1 - z2;

double length = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine($"Длинна отрезка {length}");
