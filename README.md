# GlobalX
GlobalX code assessment sort name problem

## Files Outline
- **name-sorter.cs** :  source code file, all source code is in this file

- **name-sorter.exe** : the executable file, generated by running "csc name-sorter.cs"

- **unsorted-names-list.txt** : the names to be sorted in the specification

- **sorted-names-list.txt** : the output file

- **test-case-1.txt** : test if code sort correctly when some last names are same

- **test-case-1-expected** : the expected result of test case 1

- **test-case-2.txt** : test if code sort correctly when some firt names are same

- **test-case-2-expected** : the expected result of test case 2

- **test-case-3.txt** : test if code sort correctly when some names are same

- **test-case-3-expected** : the expected result of test case 3


## How to run?
run **name-sorter ./unsorted-names-list.txt** , and check sorted-names-list.txt, also the output is printed to console.

## How to run test?
take test case 1 as an example:

run **name-sorter ./test-case-1.txt**

then you can ***either*** manually and visually compare sorted-names-list.txt with test-case-1-expected.txt

***or*** use windows fc(file compare) command to compare, e.g. **fc sorted-names-list.txt test-case-1-expected.txt**



