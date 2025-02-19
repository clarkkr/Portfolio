# Parser Plan

Our plan with our Rules Engine is to have a Python program that interacts with the our Rules Engine provided by GoRules. It will use the Rules Engine to run checks on the input data to verify whether the data being ran through the program is acceptable, and if it is to make sure that it is in the right format and nothing is out of the ordinary.

# Scheduler Plan

After the Python parser interacts with the GoRules rules engine, it will send that file off to a Java program that will then filter the employees that are working by their preferred shift pattern and schedule them up to the number of desired shifts they would like to work that week. Afterwards, it will output the Employee ID's of those who will be scheduled that week on our server's website.

## Why Python?

Python is our program of choice for multiple reasons. For starters, the GoRules rules engine only lets us choose from Rust, NodeJS, or Python in terms of the languages it supports. None of us know Rust, NodeJS is too complicated for us to learn in such a short amount of time and Python some of us know, but not all of us. 

## Why Java?

Java is our choice for a lot of different reasons. Mainly, because it is the program that we as students have been working with throughout our college career. We are very familiar with Java and its capability and we saw it as a perfect fit for outputting out schedule to our webpage.

## Input

The input to our overall engine program will be the Rules JSON, and a CSV/JSON file. With these it will filter through any of the incorrect data provided in the input file in order to get out the necessary data.

## Output

Our output will be multiple schedules that the user can pick and choose their overall favorite from. 