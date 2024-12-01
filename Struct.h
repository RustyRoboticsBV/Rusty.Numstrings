#ifndef __RUSTY_NUMSTRING_STRUCT
#define __RUSTY_NUMSTRING_STRUCT

#include "typedefs.h"

class String;

class Struct
{
public:
	virtual void Parse(const String str);
	virtual const String ToString() const;
};

#endif