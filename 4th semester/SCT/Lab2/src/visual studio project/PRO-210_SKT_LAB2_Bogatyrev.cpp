// PRO-210_SKT_LAB2_Bogatyrev.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <math.h>
#include <stdio.h>
#include <time.h>
#include <stdlib.h>

#define N 200000000

double sum(int,int);

int main()
{
	printf("Calculating sum...\n");
	for (int i = 1; i <= 4; i *= 2) {
		printf("Threads = %d\n", i);
		clock_t begin = clock();
		printf("Sum = %f\n", sum(N, i));
		clock_t end = clock();
		printf("Time = %f\n\n", ((double)(end - begin)) / CLOCKS_PER_SEC);
	}
	system("pause");
    return 0;
}

double sum(int n, int threads) {
	if (n < 2) {
		return 0;
	}
	double sum = 0;
#pragma omp parallel for reduction(+:sum) num_threads(threads)
	for (int i = 2; i <= n; i++) {
		double ln = log(i);
		sum += 1 / (ln * ln * i);
	}
	return sum;
}

