# Calculator-SolbegSoft-
                                                                    User's Guide
1.	When the application is opened from the top there will be available operations
2.	You can write an example that you want to solve in the line  Then press Enter and the example will be solved.
3.	To continue the solution, you need to write the operation and the number on the next line
4.	You can also write the solution of the example from a new line.
5.	If you want to start writing the example again, you need to enter the letter C
6.	After step 5, you can solve new examples again

                                                             Application Architecture  
1.  The application contains 2 classes
2.  The class that starts the application is called the StartClass. It contains the Main method, which starts the program
3.  The class that contains the app logic is called ExucutionLogic. It contains 3 methods: Calculation, Start Program, Main Info
4. The main Info method outputs information about the application to the console that can help the user. The Start Program method starts the program and reads the values entered by the user
and sends them to the Calculation method for further calculation.The Calculation method performs calculations and outputs the resulting value to the console.
5. The application is able to work with 2 numbers. And perform the operations +, -,*,/. And also the application can clear all the information by pressing the C key
