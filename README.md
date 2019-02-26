# _WordCounter.Solution_

#### _Word counter program for Epicodus, 2.21.2019_

#### By _**Young Liu**_

## Description

_This program takes in a word and sentence input, and tells you how many times the word appears in the sentence._

## Specifications

* _Program will return an error if multiple words are entered for the search word._
  * _Example input: "bob foo" entered for word to search_
  * _Example output: Error message saying that multiple words were entered for the search word._
* _Program will return a message saying that there are no matches if there are no matches of the search word in the sentence._
  * _Example input: "bob" is the search word for the sentence "the quick brown fox jumped over the lazy dog."_
  * _Example output: Message is outputted saying that the search word was not found._
* _Program will return a count of how many times the search word appears in the sentence._
  * _Example input: "quick" is the search word for the sentence "the quick quick brown fox jumped over the lazy dog."_
  * _Example output: Message is outputted saying that two instances of the word were found._
* _Program will ignore case._
  * _Example input: "QUICK" is the search word for the sentence "the quick quick brown fox jumped over the lazy dog."_
  * _Example output: Message is outputted saying that two instances of the word were found._
* _Program will ignore punctuation at the end of a word._
  * _Example input: "fire" is the search word for the sentence "The room caught on fire, everything was on fire!"_
  * _Example output: Message is outputted saying that two counts of the word were found._


## Setup/Installation Requirements

* _Download .NET Core 1.1.4 SDK, .NET Core Runtime 1.1.2 and Mono, and install them._
* _Clone this Repository ($ git clone https://github.com/youngzliu/WordCounter.Solution name)_
* _Change into the work directory ($ cd WordCounter.Solution)_
* _To edit the project, open the project in your preferred text editor._
* _To run the program, navigate to the directory of WordCounter, and then compile and execute ($ cd WordCounter $mcs Program.cs Models/RepeatCounter.cs; mono Program.exe)_
* _To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test_

## Support and contact details

_For support find me at Epicodus._

## Technologies Used

_This website was created using C#, the NET framework, and Mono._

### License

*MIT License*

*Copyright (c) 2019 Young Liu*

*Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:*

*The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.*

*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.*
