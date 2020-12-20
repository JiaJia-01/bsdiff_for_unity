#pragma once

//#pragma warning(disable:4996)
//#pragma warning(disable:4703)

#include <io.h>
#define fseeko fseek
#define ftello ftell
#define DLL _declspec(dllexport)
#define errx err

#define open _open
#define read _read
#define close _close
#define lseek _lseek
#define write _write

#define SET_OPEN_FILE_BINARY_MODE _set_fmode(_O_BINARY);

#if defined(_WIN64)
typedef __int64 ssize_t;
#else
typedef long ssize_t;
#endif

void err(int exitcode, const char* fmt, ...);

DLL int Diff(const char* oldFile, const char* newFile, const char* patchFile);
DLL int Patch(const char* oldFile, const char* newFile, const char* patchFile);
