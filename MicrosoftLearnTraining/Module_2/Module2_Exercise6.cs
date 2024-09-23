namespace MicrosoftLearnTraining.Module_2
{
    public class Module2_Exercise6
    {
        public string Name { get; set; }
        public int[] Scores { get; set; }

        public Module2_Exercise6(string name, int[] scores)
        {
            Name = name;
            Scores = scores;
        }

        public decimal CalculateAverage()
        {
            int sum = 0;
            int gradedAssignments = Scores.Length;

            for (int i = 0; i < Scores.Length; i++)
            {
                sum += Scores[i];
            }

            for (int i = 5; i < Scores.Length; i++)
            {
                sum += (int)(Scores[i] * 0.1);
            }

            return (decimal)sum / gradedAssignments;
        }

        public string GetLetterGrade(decimal average)
        {
            if (average >= 97) return "A+";
            else if (average >= 93) return "A";
            else if (average >= 90) return "A-";
            else if (average >= 87) return "B+";
            else if (average >= 83) return "B";
            else if (average >= 80) return "B-";
            else if (average >= 77) return "C+";
            else if (average >= 73) return "C";
            else if (average >= 70) return "C-";
            else if (average >= 67) return "D+";
            else if (average >= 63) return "D";
            else if (average >= 60) return "D-";
            else return "F";
        }

        public void Execute()
        {
            Console.WriteLine("Module 2 - Exercise 6:");

            Module2_Exercise6[] students = new Module2_Exercise6[]
            {
            new Module2_Exercise6("Sophia", new int[] { 90, 86, 87, 98, 100, 94, 90 }),
            new Module2_Exercise6("Andrew", new int[] { 92, 89, 81, 96, 90, 89 }),
            new Module2_Exercise6("Emma", new int[] { 90, 85, 87, 98, 68, 89, 89 }),
            new Module2_Exercise6("Logan", new int[] { 90, 95, 87, 88, 96, 96 })
            };

            Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

            foreach (var student in students)
            {
                decimal average = student.CalculateAverage();
                string letterGrade = student.GetLetterGrade(average);
                Console.WriteLine($"{student.Name}\t\t{average:F1}\t{letterGrade}");
            }

            Console.WriteLine();
        }
    }
}
