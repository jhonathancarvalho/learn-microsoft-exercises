namespace MicrosoftLearnTraining.Module_2
{
    public class Module2_Exercise7
    {
        private string[] students = { "Sophia", "Andrew", "Emma", "Logan" };
        private decimal[] examScores = { 92.2m, 89.6m, 85.6m, 91.2m };
        private decimal[,] extraCredit = {
        { 5, 7, 9 },
        { 4, 6, 5 },
        { 6, 8, 10 },
        { 5, 5, 6 }
    };

        public void Execute()
        {
            Console.WriteLine("Module 2 - Exercise 7:");
            Console.WriteLine("Student         Exam Score      Overall       Grade   Extra       Credit\n");

            for (int i = 0; i < students.Length; i++)
            {
                decimal totalExtraCredit = 0;
                for (int j = 0; j < extraCredit.GetLength(1); j++)
                {
                    totalExtraCredit += extraCredit[i, j];
                }

                decimal averageExamScore = examScores[i];
                decimal finalScore = (averageExamScore + (0.1m * totalExtraCredit)) / 1.1m;

                string overallGrade = GetGrade(finalScore);
                decimal extraCreditPoints = (0.1m * totalExtraCredit) / extraCredit.GetLength(1);

                Console.WriteLine($"{students[i],-15} {examScores[i],-15:F1} {finalScore,-15:F2} {overallGrade,-7} {totalExtraCredit,-9} ({extraCreditPoints:F2} pts)");
            }
        }

        private string GetGrade(decimal score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 80)
                return "B";
            else if (score >= 70)
                return "C";
            else if (score >= 60)
                return "D";
            else
                return "F";
        }
    }
}

