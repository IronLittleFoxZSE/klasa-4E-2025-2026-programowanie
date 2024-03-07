// FirstObjectTaskConsoleApplication
//
#include <iostream>

/*
Zdefiniuj klase opisujący punkt na przestrzeni kartezjańskiej. Możliwości klasy:
* konstruktory
* metoda która zwórci odległość tego punktu od poczatku układu współrzednych
* metoda która zwróci odległość od innego punktu
* metoda która zwróci informację w której ćwiartce układu współrzednych się znajduje punkt
* metodę która pokaże informacje o punkcie.

Napisz program który zaprezentuje możliwości obiektu na podstawie tej klasy.

*/

/*
Zdefiniuj klase opisujące konto bankowe. Możliwości klasy:
* konstruktory
* metoda która dokona wpłaty na konto
* metoda która wypłaty z konta
* metoda która wykona przelew na inne konto
* metodę która pokaże informacje o koncie.

Napisz program który zaprezentuje możliwości obiektu na podstawie tej klasy.
*/

class Point2D
{
private:
	double x;
	double y;

public:
	Point2D()
	{
		x = 10;
		y = 6;
	}

	Point2D(double xx)
	{
		x = xx;
		y = 6;
	}

	Point2D(double xx, double yy)
	{
		x = xx;
		y = yy;
	}

	double DistanceFromCenter()
	{
		double distance = sqrt(x * x + y * y);
		return distance;
	}

	double DiastanceBetweenPoints(Point2D secondPoint)
	{
		double distance = sqrt((x - secondPoint.x) * (x - secondPoint.x) + (y - secondPoint.y) * (y - secondPoint.y));
		return distance;
	}
};

int main()
{
	Point2D firstPoint2D;
	std::cout << "Odległość od środka to " << firstPoint2D.DistanceFromCenter() << "\n";
	Point2D secondPoint2D(2, 8.5);

	std::cout << "Odległość pomiędzy dwoma punktami " << secondPoint2D.DiastanceBetweenPoints(firstPoint2D) << "\n";
}

//"Zawsze programuj jak gdyby osoba zajmująca się twoim kodem w przyszłości była agresywnym psychopatą,
//który wie gdzie mieszkasz."
