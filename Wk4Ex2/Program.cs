//intructions:
//create mthods for calucationg the grades for assignmets midterms final
//create method for finalgrade
//lets user input scores
//display final grade based on weighted (assignmern = 40% midterm=30%  exam=30% + final)


//decalares variable assignment grade
double GradeAssignment = double.MaxValue;

//declares variale for midterm
double GradeMidterm = double.MaxValue;

//decalres variable for exam
double GradeExam = double.MaxValue;

//decalres variable for final grade
double FinalGrade = double.MaxValue;

//method for final grade
static double GradeFinal()
{
    double retVal = double.MaxValue;





    return retVal;
}

try
{
    //promt user to input grad for assignment
    Console.WriteLine(" please input grade for assignment in decmial: ");

    //collects user input and converts it to doble
    GradeAssignment = Convert.ToDouble(Console.ReadLine());

    //promt user to input grad for assignment
    Console.WriteLine(" please input grade for Midterm in decmial: ");

    //collects user input and converts it to doble
    GradeMidterm = Convert.ToDouble(Console.ReadLine());

    //promt user to input grad for assignment
    Console.WriteLine(" please input grade for Exam in decmial: ");

    //collects user input and converts it to doble
    GradeExam = Convert.ToDouble(Console.ReadLine());

}
catch (Exception e)
{
    Console.WriteLine(" invalid input ");
}

//outputs final grade
Console.WriteLine(" the final grade is " + FinalGrade);
Console.Read();

