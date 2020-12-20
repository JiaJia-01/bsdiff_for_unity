#include "window_helper.h"
#include <stdio.h>
#include <stdarg.h>

void err(int exitcode, const char* fmt, ...)
{
	va_list valist;
	va_start(valist, fmt);
	vprintf(fmt, valist);
	va_end(valist);
	exit(exitcode);
}
