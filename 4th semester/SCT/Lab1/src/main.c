#include <math.h>
#include <time.h>
#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int N = 400000000;

double sum(int);

int main(int argc, char* argv[]) {
	setlocale(LC_ALL, "Russian");

	clock_t start = clock();
	printf("Сумма ряда для N=%d: %f\n", N, sum(N));
	clock_t end = clock();

	printf("Затраченное время: %f\n", (double)(end-start) / CLOCKS_PER_SEC);
	system("pause");
	return 0;
}

double sum(int n) {
	if (n < 2) {
		return 0.0;
	}
	double sum = 0.0;
	for (int i = 2; i < n; i++) {
		double ln = log(i);
		sum += 1.0 / (i* ln * ln);
	}
	return sum;
}