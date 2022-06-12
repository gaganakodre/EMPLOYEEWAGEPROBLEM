namespace EMPLOYEEWAGEPROBLEM
{
    class program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("welcome to employee wage problem");
            CalculatingWagesForMonth prg = new CalculatingWagesForMonth();
            prg.CalculateEmpWage();
        }
    }
}