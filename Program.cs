Console.Title = "Automated Student Grading";
Console.WriteLine("Welcome to the Automated Student Grading application.");
string[] studentNames = File.ReadAllLines(@"C:\Users\chunk\Documents\Programming Stuff\Foreach-And-If-Elseif-Else-Arrays\Student-Names.txt");

Console.Write("How many exams were there this year? ");
int numberOfExams = Convert.ToInt32(Console.ReadLine());

foreach (string studentName in studentNames)
{
    int[] examScores = new int[numberOfExams];
    int examScoresTotal = 0;
    
    for (int i = 0; i < examScores.Length; i++)
    {
        int currentIndex = i;
        Console.Write($"{studentName.Trim()} Exam {currentIndex + 1} score: ");
        int minimumScore = 0;
        int maximumScore = 100;

        while (currentIndex <= examScores.Length)
        {
            examScores[currentIndex] = Convert.ToInt32(Console.ReadLine());
            if (examScores[currentIndex] < minimumScore || examScores[currentIndex] > maximumScore)
            {
                Console.Write("The number you entered is invalid. Please enter a value between 0-100: ");
                continue;
            }

            break;
        }

        examScoresTotal += examScores[currentIndex];
    }

    decimal examScoresAverage = (decimal)examScoresTotal / numberOfExams;
    Console.WriteLine($"{studentName} Exam Scores Average: {examScoresAverage}");

    
}
