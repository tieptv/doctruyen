#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main()
{
	FILE* index;
	char buf[1024];
	char cmd[1024];
	int chap = 1;

		index = fopen("index", "r");
		
		while(fgets(buf, sizeof(buf), index))
		{
			
			buf[strlen(buf) - 1] = 0;
			//printf("%s", buf);
			sprintf(cmd, "curl %s > chuong_%d.html", buf, chap);
			//printf("%s\n", cmd);
			system(cmd);
			chap++;
	
		}
		
	
	
	

}
