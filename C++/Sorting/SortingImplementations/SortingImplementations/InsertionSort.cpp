#include "pch.h"
#include "Common.h"

void insertionSort(int arr[], int n)
{
	int i, j, k;
	for (i = 1; i < n; i++)
	{
		k = arr[i];
		j = i - 1;

		/* Move elements of arr[0..i-1], that are
		   greater than key, to one position ahead
		   of their current position */
		while (j >= 0 && arr[j] > k)
		{
			arr[j + 1] = arr[j];
			j = j - 1;
		}
		arr[j + 1] = k;
	}

	//2nd impl
	/*int i, j;
	for (i = 1; i < n; i++) {
		int tmp = arr[i];
		for (j = i; j > 0 && arr[j - 1] > tmp; j--) {
			arr[j] = arr[j - 1];
		}
		arr[j] = tmp;
	}*/

	//3rd impl
	//int i, j, key;
	//for (j = 1; j < n; j++)    // Start with 1 (not 0)
	//{
	//	key = arr[j];
	//	for (i = j - 1; (i >= 0) && (arr[i] < key); i--)   // Smaller values move up
	//	{
	//		arr[i + 1] = arr[i];
	//	}
	//	arr[i + 1] = key;    //Put key into its proper location
	//}
}