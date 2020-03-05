#

#### Scrabble Score Calculator 03.05.2020\_

#### By _**Andrew Philpott and Tiffany Siu**_

## Description

## Specs

- _Spec: A string containing no characters gets a score of 0 points._

  - Input: ""
  - Output: 0

- _Spec: A string containing only a space gets a score of 0 points._

  - Input: " "
  - Output: 0

  - _Spec: Any string containing a non letter gives a score of 0 points._

  - Input: "hi4"
  - Output: 0

- _Spec: A string containing multiple words is not valid option and returns an error._

  - Input: "Multiple Words"
  - Output: "Input is invalid! Please enter a single word only."

- _Spec: A string containing only the letter "A", "E", "I", "O", "U", "L", "N", "R", "S", or "T" gets a score of 1 point._

  - Input: "A"
  - Output: 1

- _Spec: A string containing only the letter "D" or "G" gets a score of 2 points._

  - Input: "D"
  - Output: 2

- _Spec: A string containing only the letter "B", "C", "M", or "P" gets a score of 3 points._

  - Input: "M"
  - Output: 3

- _Spec: A string containing only the letter "F", "H", "V", "W", or "Y" gets a score of 4 points._

  - Input: "H"
  - Output: 4

- _Spec: A string containing only the letter "K" gets a score of 5 points._

  - Input: "K"
  - Output: 5

- _Spec: A string containing only the letter "J" or "X" gets a score of 8 points._

  - Input: "J"
  - Output: 8

- _Spec: A string containing only the letter "Q" or "Z" gets a score of 10 points._

  - Input: "Z"
  - Output: 10

* _Spec: A string containing multiple letters results in a score that is the sum of each letter's score._

  - Input: "Hello"
  - Output: 8

  - _Spec: The application should be able to add up letter scores regardless of casing._

  - Input: "hEllO"
  - Output: 8

## Setup/Installation Requirements

- Clone this repository.
- \$dotnet restore in tests
- \$dotnet build in main project folder

## Known Bugs

- No known bugs

## Support and contact details

- Issues or concerns? Contact us at andrewphilpott92@gmail.com or tsiu88@gmail.com

## Technologies Used

- C#
- .NET Core 2.2

### License

Copyright (c) 2020 **_Andrew Philpott, Tiffany Siu_**

_This software is licensed under the MIT license._
