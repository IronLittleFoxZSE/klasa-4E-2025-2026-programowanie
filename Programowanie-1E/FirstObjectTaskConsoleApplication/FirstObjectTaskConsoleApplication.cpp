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
};

int main()
{
    Point2D firstPoint2D;

    Point2D secondPoint2D(2, 8.5);
}
