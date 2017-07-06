#include <stdio.h>
#include <stdlib.h>








void main(int argc, char* argv[]){
	
		int i;
		int sum = 0;
		
		for(i=0; i<1000; i++){
			if(i%3 == 0 && i%5 ==0){
				sum += i;
			}
			else if(i%3 == 0){
				sum += i;
			}
			else if(i%5 == 0){
				sum += i;
			}
		}
		printf("total = %d\n", sum);
		return 0;
}


//fuck you