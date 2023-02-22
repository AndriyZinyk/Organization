namespace Organization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Organization Strajdannia3 = new Organization("Strajdannia3", 1_000_000M);
            Strajdannia3.PositionList = new List<Position>();

            Employee VladCherkys = new Employee("Vlad", "Cherkys");
            Employee AndriyZinyk = new Employee("Andriy", "Zinyk");
            Employee LiliaDerkach = new Employee("Lilia", "Derkach");
            Employee IlliaMychailovskyi = new Employee("Illia", "Mychailovskyi");
            Employee DinaNevhod = new Employee("Dina", "Nevhod");
            Employee AndriyDemianenko = new Employee("Andriy", "Demianenko");
            Employee IvanMaksymcha = new Employee("Ivan", "Maksymcha");
            Employee ArtemAlimov = new Employee("Artem", "Alimov");
            Employee MariaDanylova = new Employee("Maria", "Danylova");
            Employee ValeriiYstenko = new Employee("Valerii", "Ystenko");
            Employee JaroslavSchevchenko = new Employee("Jaroslav", "Schevchenko");
            Employee SerhiiBykov = new Employee("Serhii", "Bykov");
            Employee StanislavShkvyrskyi = new Employee("Stanislav", "Shkvyrskyi");
            Employee OleksandrVorona = new Employee("Oleksandr", "Vorona");
            Employee EvheniiElhort = new Employee("Evhenii", "Elhort");
            Employee IlliaKandybolotskyi = new Employee("Illia", "Kandybolotskyi");

            Position batko = new Position(VladCherkys, "batko", 50_000M);
            Position student1 = new Position(AndriyZinyk, "student1", 20_000M);
            Position student2 = new Position(LiliaDerkach, "student2", 20_000M);
            Position student3 = new Position(IlliaMychailovskyi, "student3", 20_000M);
            Position student4 = new Position(DinaNevhod, "student4", 20_000M);
            Position student5 = new Position(AndriyDemianenko, "student5", 20_000M);
            Position student6 = new Position(IvanMaksymcha, "student6", 20_000M);
            Position student7 = new Position(ArtemAlimov, "student7", 20_000M);
            Position student8 = new Position(MariaDanylova, "student8", 20_000M);
            Position student9 = new Position(ValeriiYstenko, "student9", 20_000M);
            Position student10 = new Position(JaroslavSchevchenko, "student10", 20_000M);
            Position student11 = new Position(SerhiiBykov, "student11", 20_000M);
            Position student12 = new Position(StanislavShkvyrskyi, "student12", 20_000M);
            Position student13 = new Position(OleksandrVorona, "student13", 20_000M);
            Position student14 = new Position(EvheniiElhort, "student14", 20_000M);
            Position student15 = new Position(IlliaKandybolotskyi, "student15", 20_000M);

            Strajdannia3.PositionList.Add(batko);
            Strajdannia3.PositionList.Add(student1);
            Strajdannia3.PositionList.Add(student2);
            Strajdannia3.PositionList.Add(student3);
            Strajdannia3.PositionList.Add(student4);
            Strajdannia3.PositionList.Add(student5);
            Strajdannia3.PositionList.Add(student6);
            Strajdannia3.PositionList.Add(student7);
            Strajdannia3.PositionList.Add(student8);
            Strajdannia3.PositionList.Add(student9);
            Strajdannia3.PositionList.Add(student10);
            Strajdannia3.PositionList.Add(student11);
            Strajdannia3.PositionList.Add(student12);
            Strajdannia3.PositionList.Add(student13);
            Strajdannia3.PositionList.Add(student14);
            Strajdannia3.PositionList.Add(student15);

            string projectName = "Default name";

            while (true)
            {
                Console.WriteLine(new string('*',30));
                Console.WriteLine("Select operation, please: \n" +
                                "1 - Make salary payment \n" +
                                "2 - Finish project and get income \n" +
                                "3 - Exit");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Strajdannia3.SalaryPayment();
                }                    
                else if (choice == "2")
                {
                    Console.Write("Input project name: ");
                    projectName = Console.ReadLine();
                    Strajdannia3.Budget += Strajdannia3.ProjectIncome(projectName);
                    Console.Write("We've got an income and now our budget equals ");
                    Console.WriteLine(Strajdannia3.Budget);
                }
                else if (choice == "3")
                {
                    break;
                }                    
                else
                {
                    Console.WriteLine("Make validate choice, please");
                }                                   
            }
        }
    }
}