// GeometryConsoleApplication.cpp 
#include <iostream>

//Kwadrat, trapez, prostokąt

class Quadrangle //ang. czworokąt
{
protected:
	double sideA, sideB, sideC, sideD;
public:
	Quadrangle(double a, double b, double c, double d)
	{
		sideA = a;
		sideB = b;
		sideC = c;
		sideD = d;
	}

	double GetPerimeter()
	{
		return sideA + sideB + sideC + sideD;
	}
};

class Square : public Quadrangle
{
protected:

public:
	Square(double a) :Quadrangle(a, a, a, a)
	{

	}
};

class Trapeze : public Quadrangle
{
protected:

public:
	Trapeze(double a, double b, double c, double d) :Quadrangle(a, b, c, d)
	{
		/*sideA = a;
		sideB = b;
		sideC = c;
		sideD = d;*/
	}
};

class Rectangle : public Quadrangle
{
protected:

public:
	Rectangle(double a, double b) :Quadrangle(a, b, a, b)
	{
		/*sideA = a;
		sideB = b;
		sideC = a;
		sideD = b;*/
	}

	double GetArea()
	{
		return sideA * sideB;
	}
};

int main()
{
	Rectangle r(1, 2);
	std::cout << "Obwód prostokąta: " << r.GetPerimeter() << "\n";

	Trapeze t(1, 2, 3, 4);
	std::cout << "Obwód trapezu: " << t.GetPerimeter() << "\n";

	Square s(5);
	std::cout << "Obwód kwadratu: " << s.GetPerimeter() << "\n";
}