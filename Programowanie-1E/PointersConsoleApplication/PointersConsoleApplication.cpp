#include <iostream>

int firstNumber = 2;

void f1()
{
    int x;
}

int main()
{
    int number = 5;
    std::cout << number << "\n";
    std::cout << &number << "\n";
    
    int* adr;
    adr = &number;

    std::cout << adr << "\n";
    *adr = 78;
    std::cout << number << "\n";

    adr = new int;

    *adr = 88;
    std::cout << adr << "\n";
    std::cout << *adr << "\n";

    short* adr2;
    //adr2 = &number;

    short shortNumber;
    std::cout << "Wielkość zmiennej number " << sizeof(number) << "\n";
    std::cout << "Wielkość zmiennej shortNumber " << sizeof(shortNumber) << "\n";
    std::cout << "Wielkość zmiennej adr " << sizeof(adr) << "\n";
    std::cout << "Wielkość zmiennej adr2 " << sizeof(adr2) << "\n";

}