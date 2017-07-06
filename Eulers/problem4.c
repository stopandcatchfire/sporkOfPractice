#include <stdio.h>
#include <stdlib.h>

int main(int argc, char* argv[]){
	int number=0;
	 = 0;
	
	
	for(int i=999; i>0; i--){
		for(int j=999; j>0; j--){
			
		}
	}
	
	return 0;
}

char * toArray(int number){
	int n = log10(number) + 1;
	int i;
	char *numberArray = calloc(n, sizeof(char));
		for(i = 0; i < n; ++i, number /= 10)
		{
			numberArray[i] = number % 10;
		}
		return numberArray;
}