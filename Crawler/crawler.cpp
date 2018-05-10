#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <termios.h>
#include <unistd.h>



int main()
{
	char cmd[256];
	int page, chap;
	char link[128];
	
	printf("So trang: "); scanf("%d", &page);
	printf("So chuong: "); scanf("%d", &chap);
	printf("Link: "); scanf("%s", link);

	// getIndex
	sprintf(cmd, "curl %s/ > index%d.html", link, 1);
	system(cmd);
	
	for (int i = 2; i <= page; ++i)
	{
		sprintf(cmd, "curl %s/%d/ > index%d.html", link, i, i);
		system(cmd);
	}

	system("rm index index.txt");

	for (int i = 1; i <= page; ++i)
	{
		sprintf(cmd, "cat index%d.html | tr '\"' '\\n' | grep '^%s/.' | tail -n %d >> index ", i, link, i==page ? chap%30 : 30);

		system(cmd);
	}
	
	printf("getIndex done\n");
	getchar();
	//getChapterName
	for(int i = 1; i < page; i++)
	{
		
		sprintf(cmd, "cat index%d.html | tr '><' '\\n\\n' | grep '^Chương' | tail -n 30 >> index.txt", i);
		
		system(cmd);
		
	}

	sprintf(cmd, "cat index%d.html | tr '><' '\\n\\n' | grep '^Chương' | tail -n %d >> index.txt", page, chap%30);
	system(cmd);

	system("sed -i 's/\\n/\\r\\n/g' index.txt");

	printf("getChapterName done\n");
	getchar();
	getchar();

	//get
	FILE* index = fopen("index", "r");
	char buf[1024];
	
	for(int i = 1; i <= chap; i++)
	{
		if (!fgets(buf, sizeof(buf), index))
			break;
		buf[strlen(buf) - 1] = 0;
		//printf("%s", buf);
		sprintf(cmd, "curl %s > chuong_%d.html", buf, i);
		//printf("%s\n", cmd);
		system(cmd);
	}
	fclose(index);

	//cut

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

	system("rm *.html temp");

	return 0;
}