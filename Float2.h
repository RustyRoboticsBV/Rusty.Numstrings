#ifndef __RUSTY_NUMSTRING_FLOAT2
#define __RUSTY_NUMSTRING_FLOAT2

#include "Struct.h"
#include "String.h"
#include "Float.h"

class Float2 : Struct
{
	friend Float2;
public:
	void Parse(const String str) override;
    const String ToString() const override;
private:
	Float x;
	Float y;
};

#endif