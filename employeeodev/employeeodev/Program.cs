using employeeodev;

namespace employeeodev;


class program
{
    public static void Main()
    {
        Employee employee = new Employee(19,"Hunkar","arda",0,"Acar");

        Addd ad = new Addd();

        ad.CreateAdd(employee);

        Console.WriteLine(ad.ReadId(0));

        ad.CreateAdd(employee);

        






    }

    
}