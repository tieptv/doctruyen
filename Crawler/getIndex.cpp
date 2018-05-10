#include <stdio.h>
#include <stdlib.h>

int main()
{
	char cmd[256];
	int page;
	char link[128];
	
	printf("So trang: "); scanf("%d", &page);
	printf("Link: "); scanf("%s", link);

	sprintf(cmd, "curl %s/ > index%d.html", link, 1);
	system(cmd);
	
	for (int i = 2; i <= page; ++i)
	{
		sprintf(cmd, "curl %s/%d/ > index%d.html", link, i, i);
		system(cmd);
	}

	for (int i = 1; i <= page; ++i)
	{
		sprintf(cmd, "tail -n 1 index%d.html | tr '\"' '\\n' | grep ^%s/ | head -n 35 | tail -n 30 >> index ", i, link);

		system(cmd);
	}
	

	return 0;
}