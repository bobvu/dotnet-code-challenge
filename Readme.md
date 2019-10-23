# About

This program will fetch data from xml and json files and output a list of horses with name and price in ascending order

## Thoughts

When it comes, I believe it is more than just a simple file parser in front of me. My plan is to provide a end-to-end solution with covering most of the best BackEnd Practices. Let's start.

First of all, as doing Unit tests is a critical part of the software developement proccess, I want to design classes in a way that: 
- Easy to test. The tests must cover all sorts of aspects from opening files, process files, parsing files to rasing expected exceptions.
- Strictly follow SOLID design principles
- Handle or raise proper exceptions where appropriate.
- The Stategy Pattern is what I used in this project. There are two Parsers (CaulfieldParser and WolferHamptonParser) both implement IParticipants interface which has one method GetHorses()
-  All implementation classes depend on abstractions (Interface) rather than concrete implementations. For example, WolferHamptonParser got injected by IJsonReader or CaulfieldParser got injected by IXmlReader, making them compliant to Dependency Inversion Principle and the Dependency Injection pattern, also very easy to test. You can easily test WolferHamptonParser with a real JsonReader instance or any mock object that implement IJSonReader interface.

Second, deploy using docker. No matter how awesome a product is, it can’t survive if it fails to provide a always-online service and catch up the business capacity expansion. Containerised application is definitely an option especially when it is working with tools like Kubernetes, stability and scalability can both be achieved and controlled with a very low risk.

## Guidelines

- Clone the repository into a folder, make sure you can find xml and json files in "FeedData" folders in both donet-code-challenge and dotnet-code-challenge.tests projects, if not, some of the test cases will fail.
- Using VS 2017 or VSCode to open the solution, after that you can run or test from there. 
- Or you can build docker image and run on the program on the local machine using: docker build, and docker run -it --rm yourImage

## Outstandings
Due to the time limit, I couldn't make it as perfect as I expected. There are couple improvements that I want to make to the project: 
+ Creating Mock objects of IXmlReader, IJsonReader and test the Parsers based on those mock objects, so our test cases won't depend on external files anymore.
+ Add some more test cases.
+ Put file paths to the xml and json files to appsetting.json, and try to read it from there in the program.cs
+ Create a service that can combine all the results from parsers, and output a sorted list of participants based on Price. After that, create some test cases to test this service.


