#include <iostream>
//#include <cmath>

//Napisz program, który obliczy odległość punktu w przestrzeni 2D od środka układu współrzędnych.
void task1()
{
	double x, y;
	std::cout << "Podaj X:\n";
	std::cin >> x;
	std::cout << "Podaj Y:\n";
	std::cin >> y;

	double d = sqrt(x * x + y * y);

	std::cout << "Odległość do punktu (0,0) punktu (" << x << ", " << y << ") wynosi " << d << "\n";
}

void task2()
{
	double x, y;
	std::cout << "Podaj X:\n";
	std::cin >> x;
	std::cout << "Podaj Y:\n";
	std::cin >> y;

	double x1, y1;
	std::cout << "Podaj X1:\n";
	std::cin >> x1;
	std::cout << "Podaj Y1:\n";
	std::cin >> y1;

	double d = sqrt(x * x + y * y);

	double d1 = sqrt(x1 * x1 + y1 * y1);

	std::cout << "Odległość do punktu (0,0) punktu (" << x << ", " << y << ") wynosi " << d << "\n";
	std::cout << "Odległość do punktu (0,0) punktu (" << x1 << ", " << y1 << ") wynosi " << d1 << "\n";
}

void displayAnswer(double x, double y, double d)
{
	std::cout << "Odległość do punktu (0,0) punktu (" << x << ", " << y << ") wynosi " << d << "\n";
}

double calculateDistance(double x, double y)
{
	double d = sqrt(x * x + y * y);
	return d;
}

void GetCoordinates(double &x, double &y)
{
	std::cout << "Podaj X:\n";
	std::cin >> x;
	std::cout << "Podaj Y:\n";
	std::cin >> y;
}

void task3()
{
	double x = 0, y = 0;
	double x1 = 0, y1 = 0;

	GetCoordinates(x, y);
	GetCoordinates(x1, y1);

	double d = calculateDistance(x, y);
	double d1 = calculateDistance(x1, y1);

	displayAnswer(x, y, d);
	displayAnswer(x1, y1, d1);
}

void task4()
{
	const int size = 3;
	double x[size], y[size];

	for (int i = 0; i < size; i++)
	{
		GetCoordinates(x[i], y[i]);
	}

	double d[size];
	for (int i = 0; i < size; i++)
	{
		d[i] = calculateDistance(x[i], y[i]);
	}

	for (int i = 0; i < size; i++)
	{
		displayAnswer(x[i], y[i], d[i]);
	}
}

int main()
{
	//task1();
	//task2();
	//task3();
	task4();
}