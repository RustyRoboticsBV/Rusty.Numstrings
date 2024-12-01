#ifndef __RUSTY_NUMSTRING_STRING
#define __RUSTY_NUMSTRING_STRING

#include "Struct.h"

class String : Struct
{
	friend String;
public:
	String();
	String(const char* str);
	String(const char16_t* str);

	void Parse(const String str) override;
	const String ToString() const override;
private:
	const char16_t* text;
};

#endif