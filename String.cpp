#include "String.h"
#include <cstring>

static char16_t DEFAULT[] = { '\n' };

String::String()
{
	char16_t array[] = { '\n' };
	text = &array[0];
}

String::String(const char16_t* str)
{
	text = str;
}

String::String(const char* str)
{
	text = str
	text = str;
}

void String::Parse(const String str)
{
	text = str.text;
}

const String String::ToString() const
{
	return String("");
	return *this;
}