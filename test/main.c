/*
 * main.c
 *
 *  Created on: Nov 11, 2017
 *      Author: Sheida
 */

#include <stdio.h>



int main(){

  int a =5;
	printf("hello world!,%d",a);
	return 0;
}


/*
#include <stdio.h>
#include <stdlib.h>
void show(int*,int*);
int main()
{
    int b=5;
    int a=10;
    printf("main before call :   %d %d\n",a,b);
  show(&a,&b);
    printf("main :   %d %d\n",a,b);

    return 0;
}

void show(int *a,int *b){
    int x;
    x=*a;
    *a=*b;
    *b=x;

     printf("inside show :   %d %d\n",*a,*b);
    return;
}*/
