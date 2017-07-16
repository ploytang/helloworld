# Hello World Sample

This is a sample project that uses Code Analysis and Stylecop. 
It is a console application that prints out "Hello World."

### Code Analysis and StyleCop
Example class has some codes. When removing `this.` then build, the build will fail (StyleCop.MSBuild).

The HelloWorld project has basic StyleCop settings (see HelloWorld/Settings.StyleCop).
Rules can be set using Visual Studio (Right click on the project > StyleCop Settings).

Code Analysis can be found under Analyse > Run Code Analysis.

### Unit Tests
A simple unit test is added. It can be run by going to Test > Run > All Tests. 
For bigger project, use nUnit + Reshaper.
Currently StyleCop is not enabled on the Test Project.

### Tech
* Visual Studio 2017
* [StyleCop] - Install the plugin (Should work for 2015 as well)
* StyleCop.MSBuild - treating StyleCop Warnings as Errors.

[StyleCop]: <https://marketplace.visualstudio.com/items?itemName=ChrisDahlberg.StyleCop>