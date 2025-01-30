// See https://aka.ms/new-console-template for more information

// PROJECT TOPIC
// Develope a Student GPA Calculator that will help calculate students' overall Grade Point Average

string studentName = "Sophia Johnson";
string courseName1 = "English 101";
string courseName2 = "Algebra 101";
string courseName3 = "Biology 101";
string courseName4 = "Computer Science I";
string courseName5 = "Psychology 101";

int gradeA = 4;
int gradeB = 3;

int courseCredit1 = 3;
int courseCredit2 = 3;
int courseCredit3 = 4;
int courseCredit4 = 4;
int courseCredit5 = 3;

int courseGrade1 = gradeA;
int courseGrade2 = gradeA;
int courseGrade3 = gradeB;
int courseGrade4 = gradeB;
int courseGrade5 = gradeA;

int englishGrade = courseGrade1 * courseCredit1;
int algebraGrade = courseGrade2 * courseCredit2;
int biologyGrade = courseGrade3 * courseCredit3;
int ComputerGrade = courseGrade4 * courseCredit4;
int psychologyGrade = courseGrade5 * courseCredit5;

int courseGradeSum = (englishGrade + algebraGrade + biologyGrade + ComputerGrade + psychologyGrade);

int gradeTotal = (courseGrade1 + courseGrade2 + courseGrade3 + courseGrade4 + courseGrade5);

decimal finalGPA = (decimal) courseGradeSum / gradeTotal;

int wholeDigit = (int) finalGPA;
int firstDigit = (int) (finalGPA * 10) % 10;
int secondDigit = (int) (finalGPA * 100) % 10;

Console.WriteLine($"Student: {studentName}");
Console.WriteLine();
Console.WriteLine("Course\t\t\tGrade\tHours");
Console.WriteLine($"{courseName1}\t\t{courseGrade1}\t{courseCredit1}");
Console.WriteLine($"{courseName2}\t\t{courseGrade2}\t{courseCredit2}");
Console.WriteLine($"{courseName3}\t\t{courseGrade3}\t{courseCredit3}");
Console.WriteLine($"{courseName4}\t{courseGrade4}\t{courseCredit4}");
Console.WriteLine($"{courseName5}\t\t{courseGrade5}\t{courseCredit5}");
Console.WriteLine();
Console.WriteLine($"Final GPA:\t{wholeDigit}.{firstDigit}{secondDigit}");
