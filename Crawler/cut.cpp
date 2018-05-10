#include <stdio.h>
#include <stdlib.h>
#include <string.h>


int main()
{

	char cmd[256];
	int chap;
	printf("So chuong: "); scanf("%d", &chap);
	for(int i = 1; i <= chap; i++)
	{

		sprintf(cmd, "tr '\\n' ' ' < chuong_%d.html > temp", i);
		system(cmd);

		sprintf(cmd, "sed -i 's/<!--<p>-->/\\r\\n/g' temp");
		system(cmd);

		sprintf(cmd, "sed -i 's/<!--<\\/p>-->/\\r\\n/g' temp");
		system(cmd);

		sprintf(cmd, "head -n 2 temp | tail -n 1 > chuong_%d.txt", i);
		system(cmd);

		sprintf(cmd, "sed -i 's/<br\\/>/\\r\\n/g' chuong_%d.txt", i);
		system(cmd);	
	}


	return 0;
}
