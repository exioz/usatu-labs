#include <stdlib.h>
#include <stdio.h>
#include <time.h>
#include <omp.h>
#include <math.h>

#define N 800000000

double sum(int,int);

int main(int argc, char* argv[]) {
	printf("Calculating sum...\n");
	for (int i = 1; i <=4; i*=2) {
		printf("Thread = %d\n", i);
		double begin = omp_get_wtime();
		printf("Sum = %f\n", sum(N,i));
		double end = omp_get_wtime();
		printf ("Time = %f\n\n", end - begin);
	}
	printf("Press \"Enter\" to exit...");
	getchar();
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
		sum += 1 / (ln*ln*i);
	}
	return sum;
}
