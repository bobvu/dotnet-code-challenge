# About

This program will fetch data from xml and json files and output a list of horses with name and price in ascending order

## Thoughts

When it comes, I believe it is more than just a simple file parser in front of me. My plan is to provide a end-to-end solution with covering most of the best BackEnd Practices. Let's start.

First of all, as doing Unit tests is a critical part of the software developement proccess, I want to design classes in a way that: 
-  Easy to test. The tests must cover all sorts of aspects from opening files, process files, parsing files to rasing expected exceptions.
- Strictly follow SOLID design principles
- Handle or raise proper exceptions where appropriate.

Second, deploy using docker. No matter how awesome a product is, it can’t survive if it fails to provide a always-online service and catch up the business capacity expansion. Containerised application is definitely an option especially when it is working with tools like Kubernetes, stability and scalability can both be achieved and controlled with a very low risk.

## Guidelines

- clone the repository into a folder
- using VS 2017 to open the solution, after that you can run or test from there
- Or you can build docker image and run on the program on the local machine using: docker build, and docker run -it --rm yourImage
