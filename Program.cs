Console.Title = "Automated Student Grading";
Console.WriteLine("Welcome to the Automated Student Grading application.");
string[] studentNames = File.ReadAllLines(@"C:\Users\chunk\Documents\Programming Stuff\Foreach-And-If-Elseif-Else-Arrays\Student-Names.txt");

Console.Write("How many assignments were there this year? ");
int numberOfAssignments = Convert.ToInt32(Console.ReadLine());

int[] assignmentScores = new int[numberOfAssignments];
int minimumScore = 0;
int maximumScore = 100;
decimal assignmentScoresTotal = 0;
decimal assignmentScoresAverage = 0;

Console.Clear();
Console.WriteLine("Student\t\tGrade\n");

foreach (string studentName in studentNames)
{
    for (int i = 0; i < assignmentScores.Length; i++)
    {
        string currentStudent = studentName;
        decimal currentStudentGrade = 0;
        string currentStudentLetterGrade = "";
        int currentIndex = i;
        Console.Write($"{studentName.Trim()} \tExam {currentIndex + 1} score: ");
       
        while (currentIndex <= assignmentScores.Length)
        {
            assignmentScores[currentIndex] = Convert.ToInt32(Console.ReadLine());
            if (assignmentScores[currentIndex] < minimumScore || assignmentScores[currentIndex] > maximumScore)
            {
                Console.Write("The number you entered is invalid. Please enter a value between 0-100: ");
                continue;
            }

            break;
        }

        assignmentScoresTotal = assignmentScores.Sum();

        if (assignmentScores[currentIndex] >= 97)
        {
            currentStudentLetterGrade = "A+";
        }
        else if (assignmentScores[currentIndex] >= 93 && assignmentScores[currentIndex] < 97)
        {
            currentStudentLetterGrade = "A";
        }
        else if (assignmentScores[currentIndex] >= 90 && assignmentScores[currentIndex] < 93)
        {
            currentStudentLetterGrade = "A-";
        }
        else if (assignmentScores[currentIndex] >= 87 && assignmentScores[currentIndex] < 90)
        {
            currentStudentLetterGrade = "B+";
        }
        else if (assignmentScores[currentIndex] >= 83 && assignmentScores[currentIndex] < 87)
        {
            currentStudentLetterGrade = "B";
        }
        else if (assignmentScores[currentIndex] >= 80 && assignmentScores[currentIndex] < 90)
        {
            currentStudentLetterGrade = "B-";
        }
        else if (assignmentScores[currentIndex] >= 77 && assignmentScores[currentIndex] < 90)
        {
            currentStudentLetterGrade = "C+";
        }
        else if (assignmentScores[currentIndex] >= 73 && assignmentScores[currentIndex] < 90)
        {
            currentStudentLetterGrade = "C";
        }
        else if (assignmentScores[currentIndex] >= 70 && assignmentScores[currentIndex] < 90)
        {
            currentStudentLetterGrade = "C-";
        }
        else if (assignmentScores[currentIndex] >= 67 && assignmentScores[currentIndex] < 90)
        {
            currentStudentLetterGrade = "D+";
        }
        else if (assignmentScores[currentIndex] >= 63 && assignmentScores[currentIndex] < 90)
        {
            currentStudentLetterGrade = "D";
        }
        else if (assignmentScores[currentIndex] >= 60 && assignmentScores[currentIndex] < 90)
        {
            currentStudentLetterGrade = "D-";
        }
        else if (assignmentScores[currentIndex] < 60)
        {
            currentStudentLetterGrade = "F";
        }
    }

    Console.Write("How many extra credit assignments did the student complete, if any? ");
    int extraCreditAssignments = Convert.ToInt32(Console.ReadLine());

    if (extraCreditAssignments != 0)
    {
        int highestExamScore = assignmentScores.Max();
        decimal extraCreditWeight = (highestExamScore * 0.10M) * extraCreditAssignments;
        assignmentScoresTotal += extraCreditWeight;
    }

    assignmentScoresAverage = (decimal)assignmentScoresTotal / numberOfAssignments;

    if (assignmentScoresAverage > 100) assignmentScoresAverage = 100;
}
