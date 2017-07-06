#include <stdlib.h>
#include <stdio.h>

void main(int argc, char* argv[]){
	int previous=1;
	int second=2;
	int sum = 0;
	int temp = 0;
	
	while(second<4000000){
		if(second%2 == 0){
			sum += second;
			//printf("%d\n",sum);
		}
		//printf("first = %d, second = %d\n",previous,second);
		temp = second;
		second = previous + second;
		previous = temp;
	}
	printf("total = %d\n", sum);
	return 0;
}