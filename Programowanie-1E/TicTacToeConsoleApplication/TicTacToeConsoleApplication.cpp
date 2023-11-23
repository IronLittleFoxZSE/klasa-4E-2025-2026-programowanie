#include <iostream>

const char EMPTY_SIGN = ' ';

void clearBoard(char board[], int size)
{
	for (int i = 0; i < size * size; i++)
	{
		board[i] = EMPTY_SIGN;
	}
}

void drawHorizontalFields(char board[], int size, int row)
{
	for (int col = 0; col < size; col++)
	{
		std::cout << " " << board[row * size + col] << " ";
		if (col != size - 1)
			std::cout << "|";
	}
	std::cout << "\n";
}

void drawHorizontalFrame(int size)
{
	for (int col = 0; col < size; col++)
	{
		std::cout << "---";
		if (col != size - 1)
			std::cout << "+";
	}
	std::cout << "\n";
}

void drawBoard(char board[], int size)
{
	for (int row = 0; row < size; row++)
	{
		//     |   |   |
		drawHorizontalFields(board, size, row);

		if (row != size - 1)
		{
			//	---+---+---+---
			drawHorizontalFrame(size);
		}
	}
}

bool checkRow(int row, char board[], int size, char currentPlayerSign)
{
	for (int fieldNumber = size * row; fieldNumber < size * row + size; fieldNumber++)
	{
		if (board[fieldNumber] != currentPlayerSign)
			return false;
	}
	return true;
}

bool checkRows(char board[], int size, char currentPlayerSign)
{
	for (int row = 0; row < size; row++)
	{
		if (checkRow(row, board, size, currentPlayerSign))
			return true;
	}
	return false;
}

bool checkColumn(int column, char board[], int size, char currentPlayerSign)
{
	for (int fieldNumber = column; fieldNumber < size * size; fieldNumber = fieldNumber + size)
	{
		if (board[fieldNumber] != currentPlayerSign)
			return false;
	}
	return true;
}

bool checkColumns(char board[], int size, char currentPlayerSign)
{
	for (int column = 0; column < size; column++)
	{
		if (checkColumn(column, board, size, currentPlayerSign))
			return true;
	}
	return false;
}

bool checkLeftDiagonal(char board[], int size, char currentPlayerSign)
{
	for (int fieldNumber = 0; fieldNumber < size * size; fieldNumber = fieldNumber + size + 1)
	{
		if (board[fieldNumber] != currentPlayerSign)
			return false;
	}

	return true;
}

bool checkRightDiagonal(char board[], int size, char currentPlayerSign)
{
	for (int fieldNumber = size - 1; fieldNumber < size * size - 1; fieldNumber = fieldNumber + size - 1)
	{
		if (board[fieldNumber] != currentPlayerSign)
			return false;
	}

	return true;
}

bool checkDiagonals(char board[], int size, char currentPlayerSign)
{
	if (checkLeftDiagonal(board, size, currentPlayerSign))
		return true;

	if (checkRightDiagonal(board, size, currentPlayerSign))
		return true;

	return false;
}

bool checkWin(char board[], int size, char currentPlayerSign)
{
	if (checkRows(board, size, currentPlayerSign))
		return true;

	if (checkColumns(board, size, currentPlayerSign))
		return true;

	if (checkDiagonals(board, size, currentPlayerSign))
		return true;

	return false;
}

bool checkDraw(char board[], int size)
{
	for (int fieldNumber = 0; fieldNumber < size * size; fieldNumber++)
	{
		if (board[fieldNumber] == EMPTY_SIGN)
			return false;
	}
	return true;
}

int GetPlace(char playersSymbols[], int currentPlayerNumber)
{
	int chosenPlace;
	std::cout << "Aktualny gracz " << playersSymbols[currentPlayerNumber] << "\n";
	std::cout << "Podaj miejsce na planszy \n";
	std::cin >> chosenPlace;
	return chosenPlace;
}

int main()
{
	//Gracze
	const int numberOfPlayers = 2;
	int currentPlayerNumber = 0;
	int chosenPlace;
	char playersSymbols[numberOfPlayers] = { 'O', 'X' };

	//plansza
	const int size = 3;
	char board[size * size];

	clearBoard(board, size);

	do
	{
		system("cls");

		drawBoard(board, size);

		chosenPlace = GetPlace(playersSymbols, currentPlayerNumber);

		if (chosenPlace < 0
			|| chosenPlace >= size * size
			|| board[chosenPlace] != EMPTY_SIGN)
			continue;

		board[chosenPlace] = playersSymbols[currentPlayerNumber];

		if (checkWin(board, size, playersSymbols[currentPlayerNumber]))
		{
			system("cls");
			drawBoard(board, size);
			std::cout << "Wygrana przez " << playersSymbols[currentPlayerNumber] << "\n";
			break;
		}

		if (checkDraw(board, size))
		{
			system("cls");
			drawBoard(board, size);
			std::cout << "Remis!!!\n";
			break;
		}

		//zmieniamy aktualnego gracza na kolejnego
		currentPlayerNumber = (currentPlayerNumber + 1) % numberOfPlayers;

	} while (true);

}

/*
 0   1   2

 0 | 1 | 2		0
---+---+---
 3 | 4 | 5		1
---+---+---
 6 | 7 | 8		2


 0	1	2	3
 4	5	6	7
 8	9	10	11
 12	13	14	15

 0	1	2	3	4
 5	6	7	8	9
 10	11	12	13	14
 15	16	17	18	19
 20	21	22	23	24

   */

