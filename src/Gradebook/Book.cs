namespace Gradebook
{
    class Book
    { 
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            grades = new List<double>(); 
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public double FindAverage()
        {
            Console.WriteLine($"The average for {name} is {grades.Average()}.");
            return grades.Average();
        }

        public double FindMax()
        {
            double highest = double.MinValue;

            foreach(double num in grades)
            {
                highest = Math.Max(num, highest);
            }

            Console.WriteLine($"The highest grade for {name} is {highest}.");
            return highest;
        }

        public double FindMin()
        {
            double lowest = double.MaxValue;

            foreach(double num in grades)
            {
                lowest = Math.Min(num, lowest);
            }

            Console.WriteLine($"The lowest grade for {name} is {lowest}.");
            return lowest;
        }

        public void showStats() 
        {
            FindMin();
            FindMax();
            FindAverage();
        }
    }
}