using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerMTA.Model
{
    public static class ExamMTA
    {
        public static string ExamName => "MTA 98-361";
        public static double Score => Exams98_361.Count(x => x.IsCorrect);
        public static double CountAll => Exams98_361.Count;
        public static double CountFlagged => Exams98_361.Count(x => x.IsFlagged);
        public static double CountNotAnswered => Exams98_361.Count(x => x.Answers.Any(i => i.IsSelected) == false);
        public static bool AllowShowAnswer { get; set; }
        public static bool ShuffleAnswer { get; set; }
        public static bool ShuffleQeustion { get; set; }
        private static Random Random => new();
        public static void SortQeustion() => Exams98_361.OrderBy(x => x.ID);
        public static void SortAnswer() => Exams98_361.ForEach(x => x.Answers.OrderBy(x => x.ID));
        public static void ShuffleQeustions() => Exams98_361.Shuffle();
        public static void ShuffleAnswers() => Exams98_361.ForEach(x => x.Answers.Shuffle());
        public static void ClearRadioAnswer(Exam exam) => exam.Answers.ForEach(x => x.IsSelected = false);
        public static void ResetExam() => Exams98_361.ForEach(x =>
        {
            (x.IsCorrect, x.IsFlagged) = (false, false);
            x.Answers.ForEach(i => i.IsSelected = false);
        });
        public static void Numrize(int Number = 1) => Exams98_361.ForEach(x => x.Num = Number++);

        private static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public static List<Exam> Exams98_361 { get; set; } = new()
        {
            new(1, new()
            {
                new(1, @"You should consider making use of the flowchart method.", true),
                new(2, @"You should consider making use of the pivotchart method."),
                new(3, @"You should consider making use of the data table method."),
                new(4, @"You should consider making use of the XML method."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.  
You have been asked to create a new program for xyz.com.
Prior to creating the new program, you plan to create an algorithm to fully comprehend how the processes of the program must run. 
The algorithm will list the required actions for completing a process in the appropriate sequence.  
You are informed that your method for creating the algorithm should be as simple, and clear as possible.  
What option should you use?"),
            new(2, new()
            {
                new(1, @"CIL is the highest-level human-readable programming language defined by the Common Language Infrastructure specification.", true),
                new(2, @"CIL is the lowest-level human-readable programming language defined by the Common Language Infrastructure specification."),
                new(3, @"CIL is an object-oriented assembly language, and is entirely stack-based.", true),
                new(4, @"CIL is an object-oriented assembly language, but is not stack-based."),
            }, @"You are employed as a developer at xyz.com. You are creating a .NET Framework application.
You have been instructed to make sure that you make use of Common Intermediate Language (CLI) for programming the application.
What options are TRUE with regards to CLI? (Choose all that apply.)", ControlType.CheackBox),
            new(3, new()
            {
                new(1, @"myArray[1]"),
                new(2, @"myArray[2]", true),
                new(3, @"myArray[3]"),
                new(4, @"myArray[4]"),
                new(5, @"myArray[5]"),
                new(6, @"myArray[6]"),
            }, @"You are employed as a developer at xyz.com. You make use of Visual Basic .Net for development purposes.
You have written the code shown below for declaring an array of a new application:
Dim myArray as String = { apples, pears, plums, grapes, oranges, bananas}
You want to return the third item in your array.
What code would you employ?"),
            new(4, new()
            {
                new(1, @"You should consider making use of the void keyword in the method declaration.", true),
                new(2, @"You should consider making use of the sealed C# statement in the method declaration."),
                new(3, @"You should consider making use of the internal C# statement in the method declaration."),
                new(4, @"You should consider making use of the public C# statement in the method declaration."),
                new(5, @"You should consider making use of the protected C# statement in the method declaration."),
            }, @"You are employed as a developer at xyz.com.
You are in the process of creating code for a method that does not retrieve a value for the calling code.
You want to make sure that this is reflected when declaring the method.
What option should you use?"),
            new(5, new()
            {
                new(1, @"You should consider making use of the foreach C# statement."),
                new(2, @"You should consider making use of the while C# statement."),
                new(3, @"You should consider making use of the protected C# statement."),
                new(4, @"You should consider making use of the switch statement.", true),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You have received instructions to create a new program for xyz.com using C#.
You are informed that the new program should allow for intricate multi-way branching.
Furthermore, the code used must not be difficult to make sense of.
What is the option you should use?"),
            new(6, new()
            {
                new(1, @"You should consider making use of the switch C# statement as part of your code."),
                new(2, @"You should consider making use of the void keyword as part of your code."),
                new(3, @"You should consider making use of the foreach C# statement as part of your code.", true),
                new(4, @"You should consider making use of the interface keyword as part of your code."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You have been tasked with creating a new program for xyz.com using C#. 
The new program will iterate throughout an assortment of lists and arrays.
Every element in this assortment must be processed just one time.
You are then informed that reading and debugging your code should not be difficult.
What action should you take?"),
            new(7, new()
            {
                new(1, @"int count = 1; 
while (count <= 7) {
Console.WriteLine(""The value of count = {0}"" , count);
count++; }", true),
                new(2, @"int count = 0; 
while (count <= 7){
Console.WriteLine(""The value of count = {7}"" , count);
count++; }"),
                new(3, @"int count = 1; 
while (count <= 7) {
Console.WriteLine(""The value of count = {7}"" , count);
count++; }"),
                new(4, @"int count = 0; 
while (count <= 7) {
Console.WriteLine(""The value of count = {0}"" , count);
count++; }"),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You have been instructed to create a new application for xyz.com using C#. 
The new application must process a loop repeatedly for precisely 7 times.
Which of the following represents the code you should write?"),
            new(8, new()
            {
                new(1, @"You should consider making use of the static data type."),
                new(2, @"You should consider making use of the string data type."),
                new(3, @"You should consider making use of the private data type."),
                new(4, @"You should consider making use of the long data type.", true),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You have been instructed to create a new program for xyz.com. 
The program should be able to affect integer values, which may be positive or negative and be greater than twelve characters.
You have to make sure that you are able to store this type of variable.
What is the option you should take?"),
            new(9, new()
            {
                new(1, @"return n * Factorial(n - 1);", true),
                new(2, @"return n;"),
                new(3, @"return n * Factorial(n - 0);"),
                new(4, @"return 0;"),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP .NET for development purposes.
You have been instructed to create a new application that should include a recursive method that computes the factorial of a number.
You have written the following code for the method:
01: public static int Factorial(int n)
02:{
03: if (n = 0)
04 {
05: return 1
06:}
07: else
08:{
09:
10:}    
11:}
You have to insert suitable code at line 09 to make sure that the proper outcome is reached.
What line of code should be inserted?"),
            new(10, new()
            {
                new(1, @"int count = O; 
while (count < 6) {
when (count == 6)
break;
count++;
}"),
                new(2, @"int count = O; 
while (count < 7) {
if (count == 5)
break;
count++;
}", true),
                new(3, @"int count = 1; 
while (count < 6) {
if (count == 6)
break;
count++;
}"),
                new(4, @"int count = 1; 
while (count < 7) {
when (count == 5)
break;
count++;
}"),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You are writing code for a new xyz.com application. 
The code includes the while statement.
You want to make sure that a control enters the while loop six times.
VVhich of the following suitably represents the written code?"),
            new(11, new()
            {
                new(1, @"You should consider making use of the public C# statement."),
                new(2, @"You should consider making use of the sealed C# statement."),
                new(3, @"You should consider making use of the private C# statement."),
                new(4, @"You should consider making use of the do-while C# statement.", true),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You have been instructed to create a new program for xyz.com.
You have to include a repetition structure that allows for the termination condition test to execute at the bottom of the loop not the top.
What action should you take?"),
            new(12, new()
            {
                new(1, @"You should consider making use of the public C# statement."),
                new(2, @"You should consider making use of the for C# statement.", true),
                new(3, @"You should consider making use of the private C# statement."),
                new(4, @"You should consider making use of the sealed C# statement."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You have been instructed to create a program that includes code that allows the program to iterate a set amount of times.
Regardless of whether the loop body includes complex code, the written code should be understandable and easily maintainable.
What option should you use?"),
            new(13, new()
            {
                new(1, @"You should consider making use of the private access modifier for distinguishing the percentValue variable.", true),
                new(2, @"You should consider making use of the void access modifier for distinguishing the percentValue variable."),
                new(3, @"You should consider making use of the string access modifier for distinguishing the percentValue variable."),
                new(4, @"You should consider making use of the protected access modifier for distinguishing the percentValue variable."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You have received instructions to create a method for determining the concession for products xyz.com sold.
A variable, named percentValue, is of the type double and must be only be available in the method.
Which of the following actions should you take?"),
            new(14, new()
            {
                new(1, @"{
retrieve length + width;
}"),
                new(2, @"{
length = l;
width = w;
}", true),
                new(3, @"{
retrieve length - width;
}"),
                new(4, @"{
retrieve length + width;
}"),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You are planning to make use of an InitFields method that obtains two parameters of data type double, but does not retrieve a value for the calling code.
You start writing code to define the InitFields method as shown below:
public void InitFields(double l, double w)
What code should you use to complete the code?"),
            new(15, new()
            {
                new(1, @"You are unable to make use of the virtual modifier with the static, abstract, private or override modifiers.", true),
                new(2, @"You are able to make use of the virtual modifier with the static, abstract, private or override modifiers."),
                new(3, @"The use of the virtual modifier prevents inheritance of the class."),
                new(4, @"e virtual modifier is used in a class declaration to indicate that a class is intended only to be a base class of other classes."),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You are in the process of creating a class that makes use of a method using the virtual modifier.
Which of the following is TRUE with regards to the virtual modifier? (Choose all that apply.)"),
            new(16, new()
            {
                new(1, @"You should consider making use of the sealed keyword.", true),
                new(2, @"You should consider making use of the static keyword."),
                new(3, @"You should consider making use of the public keyword."),
                new(4, @"You should consider making use of the int keyword."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You are in the process of defining a class to provide functionality for executing custom pivot transforms on big data sets.
You have been informed that derived classes should be prevented from inheriting the functionality of the class.
What action should you take?"),
            new(17, new()
            {
                new(1, @"You should consider developing a classified interface that is employed by all of the classes."),
                new(2, @"You should consider configuring a customized interface for each class."),
                new(3, @"You should consider configuring a unique interface for each class."),
                new(4, @"You should consider developing a common interface that is employed by all of the classes.", true),
            }, @"You are employed as a developer at xyz.com.
You are in the process of creating a new application that includes numerous classes, with dissimilar algorithms.
You have been instructed to make sure that these classes are configured to print, regardless of their dissimilar algorithms.
Which of the following actions should you take?"),
            new(18, new()
            {
                new(1, @"You should consider making use of a method.", true),
                new(2, @"You should consider making use of an element."),
                new(3, @"You should consider making use of the while statement."),
                new(4, @"You should consider making use of the foreach statement."),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You are in the process creating a class, named TKMovies. 
You want to make sure that you have the ability to retrieve a list of all movies, which are arranged by the producer's surname.
You have to make sure that this feature of the class is suitably classified by the code you insert.
What action should you take?"),
            new(19, new()
            {
                new(1, @"You should consider creating an element in the class."),
                new(2, @"You should consider creating a constructor in the class", true),
                new(3, @"You should consider creating a customized interface for the class."),
                new(4, @"You should consider developing a common interface for the class."),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You have been instructed to create a new class.
The new class must allow for the immediate initialization of its data members every time an object of the class is created.
Which of the following actions should you take?"),
            new(20, new()
            {
                new(1, @"You should consider defining the Area method for the derivative of the Shape class using public new void.", true),
                new(2, @"You should consider defining the Area method for the derivative of the Shape class using private new void."),
                new(3, @"You should consider defining the Area method for the derivative of the Shape class using public sealed void."),
                new(4, @"You should consider defining the Area method for the derivative of the Shape class using private sealed void."),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You are in the process of developing a new derivative of the Shape class. 
The Shape class makes use of public virtual void to define the Area method.
You want to make sure that the Area method in the Shape class allows for new operations, while keeping the execution of the Area method of the Shape class concealed.
What option should you use?"),
            new(21, new()
            {
                new(1, @"class Rectangle : IConvertible {
public double Length { get; set; }
public double Width { get; set; }
public double GetArea(){ return Length * Width;}
public intCompareTo(object obj){
Rectangle target = (Rectangle)obj;
double diff = this.GetArea() - target.GetArea();
if (diff == 0) return 0;
else if (diff > 0) return 1;
else return -1; }}", true),
                new(2, @"class Rectangle : IComparable {
public  Length { get; set; }
public  Width { get; set; }
public double GetArea(){return Area;}
public intCompareTo(object obj){
Rectangle target = (Rectangle)obj;
double diff = this.GetArea() - target.GetArea();
if (diff == 0) return 0;
else if (diff > 0) return 1;
else return -1;}}"),
                new(3, @"class Rectangle : IComparable {
public double Length { get; set; }
public double Width { get; set; }
public double GetArea() {return Length * Width;}
public intCompareTo(object obj){
Rectangle target = (Rectangle)obj;
double diff = this.GetArea() - target.GetArea();
if (diff == 0) return 0;
else if (diff > 0) return 1;
else return -1;}}"),
                new(4, @"class Rectangle : IComparable {
public  Length { get; set; }
public  Width { get; set; }
public double GetArea() {return Area;}
public intCompareTo(object obj){
Rectangle target = (Rectangle)obj;
double diff = this.GetArea() - target.GetArea();
if (diff == 0) return 0;
else if (diff > 0) return 1;
else return -1;}}"),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You are instructed to develop a new Rectangle class. 
The new class should allow for Rectangle objects to be compared.
What option suitably represents the necessary code?"),
            new(22, new()
            {
                new(1, @"You should consider including the namespace C# keyword in your code.", true),
                new(2, @"You should consider including the int C# keyword in your code."),
                new(3, @"You should consider including the void C# key-vvord in your code."),
                new(4, @"You should consider including the static C# keyword in your code."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You are in the process of creating an application using C#.
You have just developed a class that has the same name as a class in a third-party library you are using.
You are informed that making use of this class in your code should not affect the clarity of your code.
VVhat action should you take?"),
            new(23, new()
            {
                new(1, @"You should consider making use of an abstract keyword."),
                new(2, @"You should consider making use of a string keyword."),
                new(3, @"You should consider making use of a virtual keyword."),
                new(4, @"You should consider making use of a static keyword.", true),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You have received instructions to create a new C# program for xyz.com.
You want to write code that declares members that belong to the actual class, not to specific objects.
What is the action you should take?"),
            new(24, new()
            {
                new(1, @"You should consider including a class.", true),
                new(2, @"You should consider including a delegate."),
                new(3, @"You should consider including a method."),
                new(4, @"You should consider including a property."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You are in the process of creating a new program using C#. 
Your code has to include an element that meets the following requirements:
*Specifies the template for an object.
*Must be a characterization of a new data type.
What action should you take?"),
            new(25, new()
            {
                new(1, @"You should consider declaring the class using the public access modifier"),
                new(2, @"You should consider declaring the class using the void access modifier"),
                new(3, @"You should consider declaring the class using the private access modifier", true),
                new(4, @"You should consider declaring the class using the string access modifier"),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You have been instructed to develop a new Windows application for xyz.com. 
You are in the process of defining a new class. You want to make sure that code outside the assembly is prevented from accessing the class.
Code packaged in the same assembly should however have the ability to access this class, regardless of whether they inherit directly or indirectly from the class.
action should you take?"),
            new(26, new()
            {
                new(1, @"You should consider making use of the actual keyword."),
                new(2, @"You should consider making use of the limit keyword."),
                new(3, @"You should consider making use of the interface keyword."),
                new(4, @"You should consider making use of the concrete keyword.", true),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You have been instructed to develop a new Windows application for xyz.com.
You are in the process of defining a new common base class that must be used by various derived classes. 
You want to declare the new base class.
What is the option you should use?"),
            new(27, new()
            {
                new(1, @"It will enable derived classes to share common functionality with base classes, but prevent them from defining their own unique behavior."),
                new(2, @"It will prevent derived classes from sharing common functionality with base classes, while allowing them to define their own unique behavior."),
                new(3, @"It will prevent derived classes to share common functionality with base classes, and also prevent them from defining their own unique behavior."),
                new(4, @"allowing them to define their own unique behavior.", true),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You have been instructed to develop a new Windows application for xyz.com. 
You have decided to make use of the inheritance object oriented programming concept.
What will this allow for?"),
            new(28, new()
            {
                new(1, @"You should consider performing a requirements analysis.", true),
                new(2, @"You should consider choosing a suitable design model."),
                new(3, @"You should consider selecting a suitable backup strategy."),
                new(4, @"You should consider selecting a release date."),
            }, @"You are employed as a software system developer at xyz.com.
You are in the process of developing a new software system for xyz.com.
You are asked to identify the steps required in the development process.
What option suitably describes the FIRST step?"),
            new(29, new()
            {
                new(1, @"Plans.", true),
                new(2, @"Modes", true),
                new(3, @"Architecture."),
                new(4, @"Hardware application."),
            }, @"You are employed as a software system developer at xyz.com.
You are preparing the development of a new software system for xyz.com.
You are currently analyzing the results of the design process, prior to development.
What options form part of the results you are analyzing?", ControlType.CheackBox),
            new(30, new()
            {
                new(1, @"An architect develops system content."),
                new(2, @"An architect develops the system's technical blueprint.", true),
                new(3, @"An architect deals with quality control."),
                new(4, @"An architect develops system manuals and help files."),
            }, @"You are employed as a software system developer at xyz.com.
You have received a request for the development of a new software system. 
You require the assistance of various types of developers during the development process, of which one is an architect.
What is the purpose of an architect?"),
            new(31, new()
            {
                new(1, @"A technical writer develops system content."),
                new(2, @"A technical writer develops the system's technical blueprint."),
                new(3, @"A technical writer deals with quality control."),
                new(4, @"A technical writer develops system manuals and help files.", true),
            }, @"You are employed as a software system developer at xyz.com.
You have received a request for the development of a new software system.
You require the assistance of various types of developers during the development process, of which one is a technical writer.
What is the purpose of a technical writer?"),
            new(32, new()
            {
                new(1, @"It allows you to ascertain whether the program execution meets the initial requirements.", true),
                new(2, @"It allows you to optimize the program for performance and security."),
                new(3, @"It allows you to employ a data structure that serves as a buffer for overflow capacity."),
                new(4, @"It allows you to analyze the packaging, deployment, delivery, and support plan for the program."),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You have been instructed to create a new program for xyz.com.
You have reached the testing stage of the development process.
What is the reason for the testing stage?"),
            new(33, new()
            {
                new(1, @"A release manager develops system content."),
                new(2, @"A release manager creates a rollout plan and certifies release candidates for shipment or deployment.", true),
                new(3, @"A release manager deals with quality control."),
                new(4, @"A release manager develops system manuals and help files."),
            }, @"You are employed as a software system developer at xyz.com.
You have received a request for the development of a new software system.
You require the assistance of various people during the development process, ofwhich one is a release manager.
What is the purpose of a release manager?"),
            new(34, new()
            {
                new(1, @"Merger."),
                new(2, @"Improvement."),
                new(3, @"Rejection"),
                new(4, @"Regression", true),
            }, @"You are employed as a developer at xyz.com. 
You have been instructed to create a new program for xyz.com.
You want to make sure that when you fix a problem with the program, it does not negatively affect the rest of the program.
You need to employ a suitable testing strategy.
What option should you use?"),
            new(35, new()
            {
                new(1, @"White-box testing allows for testing every imaginable combination of end-user activities."),
                new(2, @"White-box testing requires the creation test cases by studying the code to identiW any possible failure scenarios.", true),
                new(3, @"You are allowed to make use of sample applications to integrate and test the application block for white box testing."),
                new(4, @"White-box testing is also known as glass box, clear box, and open box testing.", true),
            }, @"You are employed as a senior developer at xyz.com. 
You are responsible for running training exercises for junior developers.
During one of the training exercises, you are discussing testing. You are explaining what white-box testing entails.
What is TRUE with regards to white-box testing? (Choose all that apply.)", ControlType.CheackBox),
            new(36, new()
            {
                new(1, @"Black-box testing allows for testing every imaginable combination of end-user activities.", true),
                new(2, @"Black-box testing requires the creation test cases by studying the code to identiW any possible failure scenarios."),
                new(3, @"You are allowed to make use of sample applications to integrate and test the application block for black box testing.", true),
                new(4, @"Black-box testing is also known as glass box, clear box, and open box testing."),
            }, @"You are employed as a senior developer at xyz.com.
You are responsible for running training exercises for junior developers.
During one of the training exercises, you are discussing testing. 
You are explaining what black-box testing entails.
What is TRUE with regards to black-box testing? (Choose all that apply.)", ControlType.CheackBox),
            new(37, new()
            {
                new(1, @"It is a contiguous collection of data items that can be accessed by an ordinal index."),
                new(2, @"It does not allow random access.", true),
                new(3, @"It does not support chaining, splitting, cycles, or other features that can leave the queue in a conflicting state."),
                new(4, @"It is the most commonly used data structure."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You have been instructed to create a new program for xyz.com. 
You are planning to make use of a queue data structure.
Which of the following options are TRUE with regards to the queue data structure?"),
            new(38, new()
            {
                new(1, @"It is a contiguous collection of data items that can be accessed by an ordinal index."),
                new(2, @"It does not support chaining, splitting, cycles, or other features that can leave the stack in a conflicting state."),
                new(3, @"It processes items on a first come, last served system.", true),
                new(4, @"It is the most commonly used data structure."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You have been instructed to create a new program for xyz.com.
You are planning to make use of a stack data structure.
which of the following options are TRUE with regards to the stack data structure?"),
            new(39, new()
            {
                new(1, @"You should consider making use of the contains queue operation.", true),
                new(2, @"You should consider making use of the holds queue operation."),
                new(3, @"You should consider making use of controls queue operation."),
                new(4, @"You should consider making use of retains queue operation."),
            }, @"You are employed as a developer at xyz.com. 
xyz.com makes use of SQL Server databases in their environment.
xyz.com has an application that employs a queue data structure for influencing data. 
A fellow developer, named Kara Lang, wants to know if the queue includes a data item without having to process the data item.
What option would you use?"),
            new(40, new()
            {
                new(1, @"You should consider making use of the view queue operation."),
                new(2, @"You should consider making use of the glance queue operation."),
                new(3, @"You should consider making use of the peek queue operation.", true),
                new(4, @"You should consider making use of the stare queue operation."),
            }, @"You are employed as a developer at xyz.com.
You have created a new application for xyz.com.
The new application makes use of a stack data structure to handle data.
You want to perform a queue operation that enables you to locate the data item that is next in line for processing, without processing that data item.
VVhat option should you make use of?"),
            new(41, new()
            {
                new(1, @"MergeSort"),
                new(2, @"BubbleSort", true),
                new(3, @"BitonicSort"),
                new(4, @"CounterSort"),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You are in the process of developing a new application. 
You are making use of an algorithm in your code that requires making use of the comparison and swap techniques.
What algorithm are you using?"),
            new(42, new()
            {
                new(1, @"It allows you to navigate all of the list's nodes.", true),
                new(2, @"It prevents you from navigating to any list node."),
                new(3, @"It prevents you from randomly accessing the list's items."),
                new(4, @"It allows you to store linked list items in a contiguous memory location."),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You are in the process of developing a new application for xyz.com.
The application must make use of a list that has multiple nodes.
You link the application to only the head node.
What is TRUE for this scenario?"),
            new(43, new()
            {
                new(1, @"An array data structure."),
                new(2, @"A linked list data structure.", true),
                new(3, @"A stack data structure."),
                new(4, @"A queue data structure."),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You have been instructed to create a new xyz.com application that makes use of a data structure that satisfies the following requirements:
*Prohibits random access to its items.
*Are extremely fast in executing insert and delete operations.
*Are not stored in contiguous memory locations.
What data structure should you make use of?"),
            new(44, new()
            {
                new(1, @"Doubly linked lists are able to store each of the elements they contain in different and unrelated storage locations.", true),
                new(2, @"It allocates all elements contiguously in memory, and keeps a count of the current number of elements."),
                new(3, @"It allows one to handle the structure by a single pointer, instead of two."),
                new(4, @"You are able insert or delete a node in a constant number of operations given only that node's address."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You are creating a new application using a doubly linked list data structure.
What is a TRUE statement with regards to this type of data structure?"),
            new(45, new()
            {
                new(1, @"It defines how elements are presented and where they are placed on the Web page.", true),
                new(2, @"It consists of a directive, which could extended with one or more attributes, within angle brackets."),
                new(3, @"It is used is used to create interactive web applications that are supported by the Netscape browser."),
                new(4, @"It is a collection of documents containing cross-reference links that can be used interactively by a user to move directly from one topic to another."),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You have received instructions to create a Web page for xyz.com. 
You are planning to make use of Cascading Style Sheet (CSS) for the Web page.
What is TRUE with regards to using Cascading Style Sheet (CSS)?"),
            new(46, new()
            {
                new(1, @"You should consider making use of the <IMG> HTML tag.", true),
                new(2, @"You should consider making use of the <HTTP> HTML tag."),
                new(3, @"You should consider making use of the <PIC> HTML tag."),
                new(4, @"You should consider making use of the <URL> HTML tag."),
            }, @"You are employed as a developer at xyz.com. 
You make use of C# and ASP.NET for development purposes.
You have recently developed a Web page for xyz.com. 
xyz.com has informed that a picture that resides on a different web server must be presented to users when they access the Web page. 
The picture can be retrieved via a public URL.
What action should you take?"),
            new(47, new()
            {
                new(1, @"It defines the shape, coordinates, and related URL of a single hyperlink region within a client-side image map"),
                new(2, @"It allows you to create hyperlinks on your web page to access other pages on the Internet.", true),
                new(3, @"It enables the current document to establish links to external documents."),
                new(4, @"It inserts an image or a video clip in the document."),
            }, @"You are employed as a developer at xyz.com. 
You are in the process of creating a new Web page for xyz.com.
You are planning to set the HREF attribute of an anchor element.
What is TRUE with this setting?"),
            new(48, new()
            {
                new(1, @"It will allow you to make sure that Web pages take the least time to load.", true),
                new(2, @"An architect develops the system's technical blueprint."),
                new(3, @"It will prevent you from altering the JavaScript code.", true),
                new(4, @"It will increase the amount of data transmitted over the network."),
            }, @"You are employed as a developer at xyz.com.
You are in the process of creating a new Web page for xyz.com.
You have written JavaScript code for your Web site in a different file.
You then set the SRC attribute of the", ControlType.CheackBox),
            new(49, new()
            {
                new(1, @"It is only used in 11S 6.0."),
                new(2, @"It is responsible for supporting the ASP.NET functionality.", true),
                new(3, @"It is considered an application pool process."),
                new(4, @"It is used in 11S 5.0 and earlier.", true),
            }, @"You are employed as a senior developer at xyz.com.
xyz.com makes use of ASP .NET for developing Web applications.
You are currently running a training exercise for potential developers. 
You are discussing the aspnet_wp.exe worker process.
What is TRUE with regards to the aspnet_wp.exe worker process? (Choose all that apply.)", ControlType.CheackBox),
            new(50, new()
            {
                new(1, @"An architect develops system content.", true),
                new(2, @"The Page Load method will be prevented from completing."),
                new(3, @"The Page Load method will be validated prior to firing."),
                new(4, @"The Page Load method will not be validated prior to firing."),
            }, @"You are employed as a developer at xyz.com. 
           You are using ASP.NET to develop a new Web page for xyz.com.
You have recently written code for a Page Load method.
You then configured the AutoEventWireup attribute of the @page directive to be TRUE.
which of the following describes the results of this configuration?"),
            new(51, new()
            {
                new(1, @"You should consider making use of the browser's History tab."),
                new(2, @"You should consider making use of the browser's Favorites tab."),
                new(3, @"You should consider making use of cookies.", true),
                new(4, @"You should consider making use of the browser's Feeds tab."),
            }, @"You are employed as a developer at xyz.com.
You are using ASP.NET and C# to develop a new Web site for xyz.com.
The Web site will be used to find places of interest.
You are instructed to make sure that the Web pages presents a list, in the bottom left-hand side, of the places of interest that were browsed in recent times.
Furthermore, you are infonned that the browsing data should be accessible to all Web pages, even if the user restarts the browser.
You want to complete your task using as little administrative effort, and without making use of server side resources.
What option should you take?"),
            new(52, new()
            {
                new(1, @"You should consider making sure that all client workstations have Windows 7 installed."),
                new(2, @"You should consider making sure that all client workstations have the necessary hardware requirements."),
                new(3, @"You should consider making sure that all client workstations are password protected."),
                new(4, @"You should consider making sure that all client workstations have a suitable Web browser installed.", true),
            }, @"You are employed as a developer at xyz.com.
You make use of ASP.NET and C# for development purposes.
xyz.com has an Internet Information Services (IIS) server, named xyz-SR07, which hosts a newly developed Web application.
You are then informed that you must ensure that all xyz.com's staff is able to make use of the new Web application.
Which of the following actions should you take?"),
            new(53, new()
            {
                new(1, @"It specifies that you want to expose the method as part of the Web service.", true),
                new(2, @"It prevents you from exposing the method as part of the Web service."),
                new(3, @"It allows you to make use of the properties of this attribute to further configure the behavior of the Web service method.", true),
                new(4, @"Further configuration of the behavior of the Web service method is disallowed."),
            }, @"You are employed as a developer at xyz.com.
You are in the process of creating a Web service using ASP.NET.
You have attached the WebMethod attribute to a Public method.
Which of the following options describe your reasons for doing this? (Choose all that apply.)", ControlType.CheackBox),
            new(54, new()
            {
                new(1, @"You should analyze the test page that is shown in the Web browser after using Visual Studio to execute the Web services project.", true),
                new(2, @"You should consider making use of black-box testing."),
                new(3, @"You should consider making use of black-box testing."),
                new(4, @"You should consider making use of alpha testing -box testing."),
            }, @"You are employed as a developer at xyz.com. 
xyz.com uses Visual Studio in their business.
You recently made use of C# to develop a new Web service that supports mapping data.
You want to make sure that the Web service produces the proper output using the least amount of effort.
Which of the following actions should you take?"),
            new(55, new()
            {
                new(1, @"You should consider inserting the reference in the machine.config file"),
                new(2, @"You should consider inserting the reference in the app.config file"),
                new(3, @"You should consider inserting the reference in the Web.config file."),
                new(4, @"You should consider configuring a Web reference to identify the Web service.", true),
            }, @"You are employed as a developer at xyz.com. 
You are using ASP.NET to develop a new Web application, named TKWebApp for xyz.com.
TKWebApp makes use of a Web service to obtain data.
You want to make sure that you are able to make use of the methods of this Web service inside TKWebApp by creating the client-side proxy classes.
Which of the following actions should you take?"),
            new(56, new()
            {
                new(1, @"You should consider generating a custom control for the unique user interface.", true),
                new(2, @"You should consider generating a Web Form"),
                new(3, @"You should consider generating a Windows Service."),
                new(4, @"You should consider generating a new User Form."),
            }, @"You are employed as a developer at xyz.com. 
You have received instructions to create a new Windows application for xyz.com.
You are informed that the application should include a unique user interface element that allows for user contribution. 
Furthermore, you are informed that a number of additional applications will be employing this unique user interface.
You have noticed that the Visual Studio toolbox does not have suitable tools to complete your task. 
You then decide to create the necessary code from scratch.
What option should you make use of?"),
            new(57, new()
            {
                new(1, @"It allows the user interface component the react to user actions.", true),
                new(2, @"It prevents the user interface component from reacting to user actions."),
                new(3, @"It allows the user interface component to send messages to the Event Log."),
                new(4, @"It prevents the user interface component from sending messages to the Event Log."),
            }, @"You are employed as a developer at xyz.com.
You have been instructed to create a user interface component for a new xyz.com application.
You are required to make use of an event programming construct.
What is the reason for this?"),
            new(58, new()
            {
                new(1, @"It is made up of one or more independent windows, which appears separately on the Windows desktop.", true),
                new(2, @"It is made up of a single main window, and the application's windows are contained within or float on top of the main window."),
                new(3, @"It is an interface that enables business managers to track and manage all the business processes from SharePoint Team Services."),
                new(4, @"It includes only the signatures of methods, delegates or events."),
            }, @"You are employed as a developer at xyz.com. 
You have received instructions to create a new Windows application for xyz.com.
You are planning to create a Single Document Interface (SDI) application.
What option is TRUE with regards to using Single Document Interface (SDI)?"),
            new(59, new()
            {
                new(1, @"You should consider developing a custom control."),
                new(2, @"You should consider developing a stored procedure."),
                new(3, @"You should consider developing a custom user interface."),
                new(4, @"You should consider developing a console application.", true),
            }, @"You are employed as a developer at xyz.com.
You have been instructed to create a new application for xyz.com. 
The application must be configured to update records on a daily basis.
The application should be configured to store error messages that take place while the application is running in a .txt file.
You should also make sure that the application starts automatically, without human input.
You have been informed that your solution should reduce the amount of processes required for development, installation, and updates.
What option should you use?"),
            new(60, new()
            {
                new(1, @"You should consider creating a Windows Service application project, and configuring the Output type as Console Application."),
                new(2, @"You should consider creating a Windows Forms application project with the Output type set to Console Application.", true),
                new(3, @"You should consider creating a Web application project with the Output type set to Windows Forms Application."),
                new(4, @"You should consider creating a Console Application project with the Output type set to Windows Forms."),
            }, @"You are employed as a developer at xyz.com.
You have received instructions to create a new application for entering data.
You have been informed that users will enter data via a keyboard or a bar-code scanner.
Furthermore, an image of an item must be displayed onscreen as soon as a code is entered.
To keep an eye on communication with the bar-code scanner, the application must log its operation to a console window.
Which of the following actions should you take?"),
            new(61, new()
            {
                new(1, @"You should consider creating a Windows Service application.", true),
                new(2, @"You should consider creating an Active Directory application."),
                new(3, @"You should consider creating a Federated application."),
                new(4, @"You should consider creating a Global Service application."),
            }, @"You are employed as a developer at xyz.com.
You have been instructed to create a new application for xyz.com.
You want to make sure that the application allows for:
*Internet communication via Electronic Data Interface (EDI).
*Continual execution in the background.
*Messages to be written to the Windows application event log, and has no user interface.
*A user to log off without interrupting the application's processes.
What option should you make use of?"),
            new(62, new()
            {
                new(1, @"You should consider accessing the Event Viewer on the local workstation.", true),
                new(2, @"You should consider accessing the app.config file on the local workstation."),
                new(3, @"You should consider accessing the machine.config file on the local workstation."),
                new(4, @"You should consider accessing the web.config file on the local workstation."),
            }, @"You are employed as a developer at xyz.com.
You have recently created a new application for xyz.com.
Messages written by the new application will be stored in the Windows application event log of the local workstation.
You want to examine these messages on a daily basis.
What option should you make use of?"),
            new(63, new()
            {
                new(1, @"It installs an executable containing classes that expand ServiceBase."),
                new(2, @"It installs a class that expands ServiceBase to execute a service.", true),
                new(3, @"It specifies a description for a property or event."),
                new(4, @"It permits declarative service controller permission checks."),
            }, @"You are employed as a developer at xyz.com.
You are making use of .NET Framework 4.5 to develop Windows service applications.
You have been instructed to create a new service application for xyz.com.
Your code will include the System.ServiceProcess.ServiceInstaller class.
VVhat is a TRUE statement with regards to this class?"),
            new(64, new()
            {
                new(1, @"You should consider configuring the CanPauseAndContinue property of the service to true.", true),
                new(2, @"You should consider configuring the CanShutdown property of the service to false."),
                new(3, @"You should consider configuring the CanStop property of the service to true."),
                new(4, @"You should consider configuring the ExitCode property of the service to true."),
            }, @"You are employed as a developer at xyz.com.
You have been instructed to create an order processing Windows service application.
Your solution should allow for the postponement of the process when system maintenance is required, as well as the resumption
of the process subsequent to the maintenance being completed.
Which of the following actions should you take?"),
            new(65, new()
            {
                new(1, @"You should consider configuring the Windows service project to include an application installer."),
                new(2, @"You should consider configuring the Windows service project to include an SMS installer."),
                new(3, @"You should consider configuring the Windows service project to include a Custom Installation Wizard."),
                new(4, @"You should consider configuring the Windows service project to include a service installer.", true),
            }, @"You are employed as a developer at xyz.com.
xyz.com makes use of SQL Server databases in their environment.
You have been instructed to create a Windows service application for xyz.com.
The application will include a trio of Windows services that are dissimilar.
You want to make sure that the services are operational by installing them prior to use.
You are then informed that the services must be installed using a suitable Windows installer tool.
Which of the following actions should you take?"),
            new(66, new()
            {
                new(1, @"The Source property is used to set the source name to register and use when writing to the event log.", true),
                new(2, @"The Source property is used to set the object used to marshal the event handler calls issued as a result of an EventLog entry written event."),
                new(3, @"The Source property is used to set the name of the log to read from or write to."),
                new(4, @"The Source property is used to set the contents of the event log."),
            }, @"You are employed as a developer at xyz.com.
xyz.com makes use of SQL Server databases in their environment.
You have been instructed to create a new windows program for xyz.com. 
The program must be able to record messages in the event log. 
You have decided to include the Source property of the EventLog class in your code.
Which of the following best describes the purpose of the Source property in the EventLog class?"),
            new(67, new()
            {
                new(1, @"You should consider executing this service using the LocalSystem account.", true),
                new(2, @"You should consider executing this service using the GlobalSystem account."),
                new(3, @"You should consider executing this service using the Admin account."),
                new(4, @"You should consider executing this service using the GlobalService account."),
            }, @"You are employed as a developer at xyz.com. 
xyz.com makes use of SQL Server in their environment.
You have been instructed to create a Windows service.
This Windows service must have the ability to retrieve data hosted by the Windows Registry.
What action should you take?"),
            new(68, new()
            {
                new(1, @"It enables you to alter the display and performance of the form to an MDI parent form.", true),
                new(2, @"It obtains a value indicating whether the form is a MDI child form."),
                new(3, @"It prevents you from altering the display and performance of the form to an MDI parent form."),
                new(4, @"It obtains a value indicating whether the form is a MDI parent form."),
            }, @"You are employed as a developer at xyz.com.
You are making use of .NET Framework 4.5 to develop Windows Forms applications.
You have just completed creating a new Windows Forms application for xyz.com.
You are preparing to configure the IsMdiContainer property of the form.
Which of the following is TRUE with regards to this configuration?"),
            new(69, new()
            {
                new(1, @"You should consider making use of MdiLayout.TileVertical.", true),
                new(2, @"You should consider making use of MdiLayout.TilePerpendicular."),
                new(3, @"You should consider making use of MdiLayout.TileParallel."),
                new(4, @"You should consider making use of MdiLayout.TileDiagonal."),
            }, @"You are employed as a developer at xyz.com.
You have receive instructions to create a new multiple document interface (MDI) Windows Form.
You want to make sure that the code you create allows for the child windows to be displayed perpendicularly inside the client area of the MDI parent form.
What option should you use in your code?"),
            new(70, new()
            {
                new(1, @"You should consider making use of the Fill method."),
                new(2, @"You should consider making use of the StreamWriter class."),
                new(3, @"You should consider executing the Dfsutil.exe command."),
                new(4, @"You should consider making use of the Console.Read method.", true),
            }, @"You are employed as a developer at xyz.com.
You have been instructed to create a new command-line application for xyz.com.
You want to make sure that you are able to retrieve a response from the command-line.
What option should you make use of?"),
            new(71, new()
            {
                new(1, @"You should consider making use of the net start command.", true),
                new(2, @"You should consider making use of the Nslookup command."),
                new(3, @"An architect deals with quality control."),
                new(4, @"You should consider making use of the net use command."),
            }, @"You are employed as a developer at xyz.com.
xyz.com makes use of SQL Server databases in their environment.
You have recently created a Windows service for xyz.com. 
You are then instructed to run a newly created Windows service from the command-line.
What is the option you should take?"),
            new(72, new()
            {
                new(1, @"You should consider executing the Snmputil.exe command."),
                new(2, @"You should consider executing the Fed-Util.exe command."),
                new(3, @"You should consider executing the InstallUtil.exe command.", true),
                new(4, @"You should consider executing the Dfsutil.exe command."),
            }, @"You are employed as a developer at xyz.com.
You have just completed the creation of a Windows service.
You are now preparing to apply the service by installing it.
What option should you use?"),
            new(73, new()
            {
                new(1, @"You should consider making use of the DMLWriter class."),
                new(2, @"You should consider making use of the StreamWriter class.", true),
                new(3, @"You should consider making use of the DDLWriter class."),
                new(4, @"You should consider making use of the SSLWriter class."),
            }, @"You are employed as a developer at xyz.com. 
xyz.com makes use of SQL Server in their environment.
You are creating a new application for xyz.com.
The new application should be configured to xyz.com's client list in a .txt file.
You have been informed that your solution should allow for the file to be accessed by ordinary text editors.
You have also been informed that the file should take up as little space as possible.
What action should you take?"),
            new(74, new()
            {
                new(1, @"You should consider making use of the SqlCommand.ExecuteReader method."),
                new(2, @"You should consider making use of the SqlCommand.ExecuteScalar method.", true),
                new(3, @"You should consider making use of the SqlCommand.ExecuteXmlReader method."),
                new(4, @"You should consider making use of the SqlCommand.BeginExecuteXmlReader method."),
            }, @"You are employed as a developer at xyz.com. 
You are using ASP.NET and C# to develop a new Web site for xyz.com.
You have created a new application for xyz.com using C#. 
The new application must be able to retrieve a single value from a xyz.com SQL Server database.
You want to make sure that this process takes as little time as possible.
What option should you make use of?"),
            new(75, new()
            {
                new(1, @"You should consider making use of the FILL SQL statement."),
                new(2, @"You should consider making use of the DISCONTINUE SQL statement."),
                new(3, @"You should consider making use of the REFRESH SQL statement."),
                new(4, @"You should consider making use of the DELETE SQL statement.", true),
            }, @"You are employed as a developer at xyz.com. 
xyz.com makes use of SQL Server in their environment.
xyz.com has a database table, named TKItems. 
You want to make sure that obsolete items are expunged from TKItems when you update it.
What action should you take?"),
            new(76, new()
            {
                new(1, @"You should consider configuring the DataTable class to store the data."),
                new(2, @"You should consider configuring the DataSet class to store the data.", true),
                new(3, @"You should consider configuring the OleDbDataReader class to store the data."),
                new(4, @"You should consider configuring the StreamReader class to store the data."),
            }, @"You are employed as a developer at xyz.com. 
xyz.com makes use of SQL Server databases in their environment.
You have been instructed to create a new program for xyz.com. 
the program must be able to return a list of data from a xyz.com database and allow you to view the returned data,
regardless of whether you are linked to the SQL server or not.
What action should you take?"),
            new(77, new()
            {
                new(1, @"It writes characters using an encoding value to convert the characters to bytes."),
                new(2, @"It allows characters to be read using an encoding value to convert the characters from bytes."),
                new(3, @"It writes basic types in binary to a stream and supports writing strings in a specific encoding.", true),
                new(4, @"It writes a forward-only stream of data rows to a data source."),
            }, @"You are employed as a developer at xyz.com.
xyz.com makes use of SQL Server databases in their environment.
You have been instructed to create a new program for xyz.com.
This new program must be able to write information to a flat file.
You decide to include a BinaryWriter class in your code.
What is TRUE with regards to the BinaryWriter class?"),
            new(78, new()
            {
                new(1, @"You should consider making use of the Fill method in the written code.", true),
                new(2, @"You should consider making use of the Copy method in the written code."),
                new(3, @"You should consider making use of the Duplicate method in the written code."),
                new(4, @"You should consider making use of the ReturnData method in the written code."),
            }, @"You are employed as a developer at xyz.com.
You have received instructions to create a new application for xyz.com. 
The new application must have the ability to duplicate information hosted by a xyz.com SQL server data table in a Dataset.
What action should you take?"),
            new(79, new()
            {
                new(1, @"Stored procedures can improve the security of your application.", true),
                new(2, @"Stored procedures prevent modular programming."),
                new(3, @"Stored procedures are created once, and can be called any number of times in your program.", true),
                new(4, @"Stored procedures are stored locally on client computers."),
            }, @"You are employed as a developer at xyz.com.
xyz.com makes use of SQL Server databases in their environment.
You are currently running a training exercise for potential developers.
You are in the process of discussing stored procedures.
That are options that suitably describe the advantages of making use of stored procedures in SQL Server? (Choose all that apply.)", ControlType.CheackBox),
        };

    }
}
