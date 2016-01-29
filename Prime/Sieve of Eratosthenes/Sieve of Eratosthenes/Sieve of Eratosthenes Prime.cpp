#include <stdio.h>      /* printf, scanf, NULL */
#include <string.h>

int main()
{
	int prime = 10000;
	int primeArray[10001] = { 0 };
	int counter = 0;
	int listOfPrime[10000] = { 0 };
	for (int i = 2; i <= prime; i++)
	{
		if (primeArray[i] != 1)
		{
			listOfPrime[counter] = i;
		}
		else
		{
			continue;
		}

		for (int w = i; w <= prime; w += i)
		{
			primeArray[w] = 1;
		}
		counter++;
	}

}