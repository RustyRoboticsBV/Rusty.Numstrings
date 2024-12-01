#ifndef __RUSTY_NUMSTRING_FLOAT
#define __RUSTY_NUMSTRING_FLOAT

#include "Struct.h"
#include "String.h"

class Float : Struct
{
	friend Float;
public:
	void Parse(const String str) override;
	const String ToString() const override;
private:
	float value;
};

#endif