#include<stdio.h>
#include<conio.h>
#include<ctype.h>
int main(void)
{
	char ch;
	while ((ch = _getch()) != 'q')
	{
		printf("%c\n", ch);
		if (isupper(ch))
			printf("buyuk harf\n");
		else if (islower(ch))
			printf("kucuk harf\n");
		else if (isdigit(ch))
			printf("digit karakter\n");
		else if (isspace(ch))
			printf("bosluk karakterlerinden biri\n");
		else if (ispunct(ch))
			printf("noktalama karakterlerinden biri\n");
		else
			printf("diger bir karakter\n");
	}
	
	printf("Bir Karakter Giriniz...!");
		
	
	/*while (ch = _getch() != 'q')
	{
		ch = toupper(ch);
		printf("%c\n", ch);
	}*/

		return 0;
}