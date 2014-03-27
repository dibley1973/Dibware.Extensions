Dibware.Extensions
==================

A C# .Net 4.5 assembly of extensions

##Classes
### StringExtensions.cs
#### Members
* Boolean HasValue
* Boolean IsDateTime
* Boolean IsInt16
* Boolean IsInt32
* Boolean IsInt64
* Boolean IsNullOrEmpty
* Boolean IsNullOrWhiteSpace
* Boolean IsNullOrEmptyOrWhiteSpace
* Boolean IsNumeric
* Boolean IsNumericCsv
* Boolean IsValidEmailAddress

##### Boolean HasValue
Returns true if the string has a value, i.e. is not null or empty.

##### Boolean IsDateTime
Returns true if the string has a value and the value can be parsed into a DataTime object

##### Boolean IsInt16
Returns true if the string has a value and the value can be parsed into a Int16 number

##### Boolean IsInt32
Returns true if the string has a value and the value can be parsed into a Int32 number

##### Boolean IsInt64
Returns true if the string has a value and the value can be parsed into a Int64 number

##### Boolean IsNullOrEmpty
Returns true of the string is null or empty

##### Boolean IsNullOrWhiteSpace
Returns true of the string is null or is filled with white space

##### Boolean IsNullOrEmptyOrWhiteSpace
Returns true of the string is null, empty or is filled with white space

##### Boolean IsNumeric
Returns true if the string has a value and the value can be parsed to a double precision floating point number

##### Boolean IsNumericCsv
Returns true if the string has a value and the value can be parsed to a numeric comma seperated value (CSV) list



## Git Commits
* Name your commits in the following format YYYYMMDD-HHMM-IINN COMMENT
* Where YYYY    = Year
* Where MM      = Month
* Where DD      = Day
* Where HH      = Hour (24)
* Where MM      = Minute
* Where II      = Initials of developer (2-4 chars)
* Where NN      = Machine name identifier checked in from (2-4 chars)
    * DT = Desktop
    * LT = Laptop 
    * BS = Build Server
* Where COMMENT = The work that has been carried out for this commit
* Example 20140321-0525-DWDT WebPrinciple and WebIdentity added

## Standards
* Follow Microsoft C# general standards. 
* Suggest use Resharper tools and follow suggestions where appropriate.

### Code Blocks
* All code blocks must be wrapped in braces, even if just one line

### Commenting
* Comment all code, implementation and method signatures 
* Suggest that GhostDoc is used for methods, and contenet edited as appropriate
* Keep comments up to date with changes

### Referenced DLLs
* Do not use packages from Nuget in the project or solution- I feel these make the solution messy
* Add referenced .dlls to a "Library" directory in each project and reference from there
* Remove unused references where known
* Remove unused "usings" from classes and modules

### Regions
* Use region directives to split up logical blocks of code Constructors, Properties, Methods, interface implentations, etc.

### Text Strings
* All text strings must be held in a resource file in the Resources directory

### Unit Tests
* Each project in the solution must have an accompanying TEST project
* Each TEST project must have the same name as the project it is to test but with ".Tests" suffix to the name
* All code must have an accompanying test where possible
* File locations of tests must emulate the location of the class being tested
* Test method names must be in the format of "Test_ActionBeingTested_Conditions_ExpectedResult" where possible
