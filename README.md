# Instructions

- The program should be written using **test driven development**, following the red, green, refactor steps.
- Please use one or more **design patterns** when developing your solution. This is your oportunity to show your skills, use it well.
- Don't sacrifice TDD to complete the solution, this will result in a fail.
- We are looking for the solution to be well factored and to adhere to the **SOLID** principles.
- The candidate should demonstrate **OO** design skills, and apply **GOF** design patterns.

# Gitlab

- Fork the project on gitlab.
- When you start do an empty commit with the message `starting tech test` and when you finish commit with a message `finished tech test`.
- Commit after every refactor cycle at least.
- Don't use branches.
- Try to not spend more than 1 hour to finish the tech test.

-------------------------------------------------------------

# Tech Test

Write a calculator app following the requirements bellow.

- The application should be built to support addition and subtraction only.
- This application should be easily extensible, allowing for further operations to be seamlessly integrated.
- Conditional complexity in the application logic will result in a fail.
 
## Requirements

As a user I would like to be able to perform mathematical calculations on a simple calculator application.

Given the application is running in a console,

When the application starts,
 - Then, the user is prompted for an operation

When the user enters a numeric value,
 - Then, the user is prompted for an operation

When the user enters "+"
 - Then, the user is prompted for a numeric value

When the user enters a numeric value
 - Then, A total of value 1 + value 2 is displayed
 - Then, the user is prompted for an operation

When the user enters "-",
 - Then, the user is prompted for a numeric value

When the user enters a numeric value
 - Then, A total of value 1 - value 2 is displayed
 - Then, the user is prompted for an operation

When the user enters an unsupported Operation
 - Then, "This operation is not supported" is displayed
 - Then, the user is prompted for an operation
