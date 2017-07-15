# Hello World Sample

This is a sample project that uses Code Analysis and Stylecop. It is a console application that does almost nothing apart from printing out "Hello World."

### Code Analysis and StyleCop
Example class has some codes. When removing `this.`, Visual Studio will display a warning.

The HelloWorld project has basic StyleCop settings (see HelloWorld/Settings.StyleCop). Rules can be set using Visual Studio (Right click on the project > StyleCop Settings). 

Code Analysis can be found under Analyse > Run Code Analysis.

### Unit Tests
A simple unit test is added. It can be run by going to Test > Run > All Tests. For bigger project, use nUnit + Reshaper.

### Tech
* Visual Studio 2017
* StyleCop