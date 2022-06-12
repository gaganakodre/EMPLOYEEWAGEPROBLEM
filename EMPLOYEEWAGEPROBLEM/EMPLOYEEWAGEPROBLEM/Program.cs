namespace EMPLOYEEWAGEPROBLEM
{
    class program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("welcome to employee wage problem");
            //UC1
            EmpPresentAbsent prg = new EmpPresentAbsent();
            prg.CheckEmpPresentAbsent();
        }
    }
}