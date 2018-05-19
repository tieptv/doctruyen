#include <stdio.h>
#include <stdlib.h>

int main()
{
	int chap;
	printf("So chuong: "); scanf("%d", &chap);

	char cmd[256];

	for(int i = 1; i <= chap; i++)
	{
		sprintf(cmd, "tr '\\r' ' ' < chuong_%d.txt > temp && cat temp > chuong_%d.txt", i, i);
		system(cmd);
	}
	system("rm temp");
}