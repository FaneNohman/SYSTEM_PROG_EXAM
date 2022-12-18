#pragma once

#ifdef MYDLL_EXPORTS
#define MYDLL_API __declspec(dllexport)
#else
#define MYDLL_API __declspec(dllimport)
#endif

extern "C" MYDLL_API int my_sum(int a, int b);
extern "C" MYDLL_API int my_sub(int a, int b);
extern "C" MYDLL_API int my_mult(int a, int b);
extern "C" MYDLL_API int my_div(int a, int b);
