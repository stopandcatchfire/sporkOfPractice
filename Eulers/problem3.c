#include <stdio.h>
#include <stdlib.h>

int main(int argc, char* argv[]){
	long long int i;
	//int largest = 1;
	long long int bignum = 600851475143;
	for(i=0;i<600851475143;i++){
		if(bignum%i == 0){
			printf("%11d\n",i);
		}
	}
	//printf("largest = %d\n", largest);
	return 0;
	
}