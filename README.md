# Whitespace Trim
A simple Test-Driven implementation of a Whitespace Trimming code Kata

## The Kata
When editing text files often times one ends up putting extra spaces and tabs at the end of each line.
Develop a simple algorithm to remove these extra characters.
It shall take an input string and produce a right-trimmed output string.

### Examples
* "abc" -> "abc"
* “abc “ -> “abc”
* "abc\t" -> "abc"
* " abc" -> " abc" (does not remove beginning whitespace)
* "ab\r\n cd \r\n" -> "ab\r\ncd\r\n" (removes whitespace at end of second line)
* “\r\n” -> “\r\n”

##### Credit
All credit goes to [Chillisoft](http://www.chillisoft.co.za/) who provided me with the Katas and the training to solve these problems.