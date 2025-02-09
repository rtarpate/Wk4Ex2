//decalares variable assignment grade
double GradeAssignment = 0;

//declares variale for midterm
double GradeMidterm = 0;

//decalres variable for exam
double GradeExam = 0;

//decalres variable for final grade
double FinalGrade = 0;

//method for final grade
static double GradeFinal(double GradeAssignment, double GradeMidterm, double GradeExam)
{
    double retVal = double.MaxValue;

    //caluates the wieghted grade
    retVal = (GradeAssignment * 0.2) + (GradeMidterm * 0.3) + (GradeExam * 0.5);



    return retVal;
}

try
{
    //promt user to input grad for assignment
    Console.WriteLine(" please input grade for assignment: ");

    //collects user input and converts it to doble
    GradeAssignment = Convert.ToDouble(Console.ReadLine());

    //promt user to input grad for assignment
    Console.WriteLine(" please input grade for Midterm: ");

    //collects user input and converts it to doble
    GradeMidterm = Convert.ToDouble(Console.ReadLine());

    //promt user to input grad for assignment
    Console.WriteLine(" please input grade for Exam: ");

    //collects user input and converts it to doble
    GradeExam = Convert.ToDouble(Console.ReadLine());

}
catch (Exception e)
{
    Console.WriteLine(" invalid input ");
}

//uses method to set finalgrade equal to gradefinal
FinalGrade = GradeFinal(GradeAssignment, GradeMidterm, GradeExam);

//outputs final grade
Console.WriteLine(" the final grade is " + FinalGrade);
Console.Read();