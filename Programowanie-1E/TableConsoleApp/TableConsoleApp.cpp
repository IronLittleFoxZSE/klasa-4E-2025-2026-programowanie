#include <iostream>

void task1()
{
	int a;
	int tab[50];//0,1,2

	a = 5;
	tab[0] = 5;
	tab[1] = 3;
	tab[2] = 87;

	a = a * tab[1];


	int x, y, z;
	std::cin >> x;
	std::cin >> y;
	std::cin >> z;

	std::cin >> tab[0];
	std::cin >> tab[1];
	std::cin >> tab[2];

	for (int i = 0; i < 3; i++)
	{
		std::cin >> tab[i];
	}

}

/*
Wyświetl największą liczbę ze zbioru
*/
void task2()
{
	const int size = 10;

	int tabOfNumbers[size];

	srand(time(NULL));
	for (int i = 0; i < size; i++)
	{
		tabOfNumbers[i] = rand() % 10 + 1;
	}

	std::cout << "Liczby w tablicy:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbers[i] << "\n";
	}

	//szukanie największej
	int max = tabOfNumbers[0];
	for (int i = 1; i < size; i++)
	{
		if (max < tabOfNumbers[i])
			max = tabOfNumbers[i];
	}
	std::cout << "Największa liczba w zbiorze to " << max << "\n";

	//szukanie najmniejszej
	int min = tabOfNumbers[0];
	for (int i = 1; i < size; i++)
	{
		if (min > tabOfNumbers[i])
			min = tabOfNumbers[i];
	}

	std::cout << "Najmniejsza liczba w zbiorze to " << min << "\n";

	float sum = 0;
	for (int i = 0; i < size; i++)
		sum = sum + tabOfNumbers[i];

	std::cout << "Suma liczb: " << sum << "\n";
	std::cout << "Średnia liczb:" << sum / size << "\n";

	int count = 0;
	float average = sum / size;
	for (int i = 0; i < size; i++)
		if (tabOfNumbers[i] > average)
			count++;
	std::cout << "Ilość liczb większa od średniej " << count << "\n";
}

/*Zaimplementuj algorytm sortowania przez wybór*/
void task3()
{
	const int size = 10;

	int tabOfNumbers[size];

	srand(time(NULL));
	for (int i = 0; i < size; i++)
	{
		tabOfNumbers[i] = rand() % 10 + 1;
	}

	std::cout << "Liczby w tablicy:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbers[i] << ", ";
	}
	std::cout << "\n";

	for (int i = 0; i < size; i++)
	{
		int min = i;
		for (int j = i + 1; j < size; j++)
		{
			if (tabOfNumbers[min] > tabOfNumbers[j])
				min = j;
		}
		int tmp = tabOfNumbers[i];
		tabOfNumbers[i] = tabOfNumbers[min];
		tabOfNumbers[min] = tmp;
	}

	std::cout << "Liczby w tablicy po posortowaniu:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbers[i] << ", ";
	}
	std::cout << "\n";

}

/*Zaimplementuj algorytm sortowania bąbelkowego*/
void task4()
{
	const int size = 10;

	int tabOfNumbers[size];

	srand(time(NULL));
	for (int i = 0; i < size; i++)
	{
		tabOfNumbers[i] = rand() % 10 + 1;
	}

	std::cout << "Liczby w tablicy:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbers[i] << ", ";
	}
	std::cout << "\n";

	for (int i = 0; i < size - 1; i++)
	{
		for (int j = 0; j < size - 1; j++)
		{
			if (tabOfNumbers[j] > tabOfNumbers[j + 1])
			{
				int tmp = tabOfNumbers[j];
				tabOfNumbers[j] = tabOfNumbers[j + 1];
				tabOfNumbers[j + 1] = tmp;
			}
		}
	}

	std::cout << "Liczby w tablicy po posortowaniu:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbers[i] << ", ";
	}
	std::cout << "\n";

}

/*
Napisz program/funkcję która dla tablicy z liczbami pseudolosowymi policzy
średnią arytmetyczną tych liczb.
*/
void task5()
{
	const int size = 10;
	const int lowerRange = 1;
	const int upperRange = 10;

	int tabOfNumbers[size];

	srand(time(NULL));
	for (int i = 0; i < size; i++)
	{
		tabOfNumbers[i] = rand() % (upperRange - lowerRange + 1) + lowerRange;
	}

	std::cout << "Liczby w tablicy:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbers[i] << ", ";
	}
	std::cout << "\n";

	int sum = 0;
	for (int i = 0; i < size; i++)
	{
		sum += tabOfNumbers[i];
	}

	int average = sum / size;
	std::cout << "Średnia liczb to " << average << "\n";

	//Napisz funkcję, która dla kolekcji danych liczbowych policzy ile jest liczb większych od średniej arytmetycznej.
	int amount = 0;
	for (int i = 0; i < size; i++)
	{
		if (tabOfNumbers[i] > average)
			amount++;
	}
	std::cout << "Ilość liczb większych od średniej to " << amount << "\n";
}

//Napisz funkcje, która dla kolekcji danych liczbowych przeniesie te liczby do innej kolekcji w odwrotnej kolejności.
void task6()
{
	const int size = 10;
	const int lowerRange = 1;
	const int upperRange = 10;

	int tabOfNumbers[size];
	int tabOfNumbersReverse[size];

	srand(time(NULL));
	for (int i = 0; i < size; i++)
	{
		tabOfNumbers[i] = rand() % (upperRange - lowerRange + 1) + lowerRange;
	}

	std::cout << "Liczby w tablicy:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbers[i] << ", ";
	}
	std::cout << "\n";
	/*
	for (int i = 0; i < size; i++)
	{
		tabOfNumbersReverse[i] = tabOfNumbers[size - i - 1];
	}
	*/
	for (int i = 0, j = size - 1; i < size; i++, j--)
	{
		tabOfNumbersReverse[i] = tabOfNumbers[j];
	}

	std::cout << "Liczby w tablicy odwróconej:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbersReverse[i] << ", ";
	}
	std::cout << "\n";
}

//Napisz funkcje, która dla kolekcji danych liczbowych obliczy częstotliwość występowania danej liczby.
void task7()
{
	const int size = 10;
	const int lowerRange = 0;
	const int upperRange = 5;

	int tabOfNumbers[size];
	int tabOfFrequentyNumbers[upperRange - lowerRange + 1];

	srand(time(NULL));
	for (int i = 0; i < size; i++)
	{
		tabOfNumbers[i] = rand() % (upperRange - lowerRange + 1) + lowerRange;
	}

	std::cout << "Liczby w tablicy:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbers[i] << ", ";
	}
	std::cout << "\n";

	for (int i = 0; i < upperRange - lowerRange + 1; i++)
	{
		tabOfFrequentyNumbers[i] = 0;
	}

	for (int i = 0; i < size; i++)
	{
		tabOfFrequentyNumbers[tabOfNumbers[i] - lowerRange]++;
	}

	std::cout << "Częstotliwość liczb: \n";
	for (int i = 0; i < upperRange - lowerRange + 1; i++)
	{
		std::cout << "Liczba " << (i + lowerRange) << " wystąpiła " << tabOfFrequentyNumbers[i] << " razy \n";
	}
}

//Napisz funkcję, która dla kolekcji danych liczbowych znajdzie najdłuższy rosnący podciąg.
void task8()
{
	const int size = 20;
	const int lowerRange = 0;
	const int upperRange = 5;

	int tabOfNumbers[size];

	srand(time(NULL));
	for (int i = 0; i < size; i++)
	{
		tabOfNumbers[i] = rand() % (upperRange - lowerRange + 1) + lowerRange;
	}

	std::cout << "Liczby w tablicy:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbers[i] << ", ";
	}
	std::cout << "\n";

	int maxSubsequenceLength = 1;
	int currentSubsequenceLength = 1;
	for (int i = 1; i < size; i++)
	{
		if (tabOfNumbers[i] >= tabOfNumbers[i - 1])
			currentSubsequenceLength++;
		else if (currentSubsequenceLength > maxSubsequenceLength)
		{
			maxSubsequenceLength = currentSubsequenceLength;
			currentSubsequenceLength = 1;
		}
		else
			currentSubsequenceLength = 1;
	}

	if (currentSubsequenceLength > maxSubsequenceLength)
		maxSubsequenceLength = currentSubsequenceLength;

	std::cout << "Długość największego rosnącego podciągu to " << maxSubsequenceLength << "\n";
}

//Napisz funkcję, która dla kolekcji danych liczbowych przeniesie te liczby do osobnych kolekcji liczb parzystych i nieparzystych.
void task9()
{
	const int size = 20;
	const int lowerRange = 0;
	const int upperRange = 5;

	int tabOfNumbers[size];
	int tabOfEventNumbers[size];
	int tabOfOddNumbers[size];
	int countEvent = -1;
	int countOdd = -1;

	srand(time(NULL));
	for (int i = 0; i < size; i++)
	{
		tabOfNumbers[i] = rand() % (upperRange - lowerRange + 1) + lowerRange;
	}

	std::cout << "Liczby w tablicy:\n";
	for (int i = 0; i < size; i++)
	{
		std::cout << tabOfNumbers[i] << ", ";
	}
	std::cout << "\n";

	for (int i = 0; i < size; i++)
	{
		if (tabOfNumbers[i] % 2 == 0)
		{
			countEvent++;
			tabOfEventNumbers[countEvent] = tabOfNumbers[i];
		}
		else
		{
			countOdd++;
			tabOfOddNumbers[countOdd] = tabOfNumbers[i];
		}
	}

	std::cout << "Liczby parzyste:\n";
	for (int i = 0; i < countEvent; i++)
	{
		std::cout << tabOfEventNumbers[i] << ", ";
	}
	std::cout << "\n";

	std::cout << "Liczby nieparzyste:\n";
	for (int i = 0; i < countOdd; i++)
	{
		std::cout << tabOfOddNumbers[i] << ", ";
	}
}

int main()
{
	setlocale(LC_CTYPE, "polish");
	//std::cout << "dfgjdfg" << std::endl << "dfgj\ndfgh" << '\n' << std::endl;
	task8();
}