#include <stdio.h>
#include <stdlib.h>

int main()
{
	int page, chap;
	char cmd[256];
	printf("So trang: "); scanf("%d", &page);
	printf("So chapter: "); scanf("%d", &chap);
	for(int i = 1; i < page; i++)
	{
		
		sprintf(cmd, "cat index%d.html | tr '><' '\\n\\n' | grep '^Chương' | tail -n 30 >> index.txt", i);
		//printf("%s\n",cmd);
		system(cmd);
		
	}

	sprintf(cmd, "cat index%d.html | tr '><' '\\n\\n' | grep '^Chương' | tail -n %d >> index.txt", page, chap%30);
	//printf("%s\n",cmd);
	system(cmd);


	system("sed -i 's/\\n/\\r\\n/g' index.txt");
	
	return 0;
}
