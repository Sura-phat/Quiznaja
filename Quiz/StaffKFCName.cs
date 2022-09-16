using System;
class StaffKFCname
{
    public static void Main(string[] args)
    {
        KFCstaff user = new KFCstaff();
        
        Console.Write("Please input start money : ");
        user.KFCmoneystart = StoL(Input());
        Console.Write("Branch name : ");
        user.branch = Input ();
        Console.Write("addess : ");
        user.addess = Input();
        Console.Write("Main name : ");
        user.Mainname = Input();
        Console.Write("Surname : ");
        user.Surname = Input();
        Console.Write("Id_citizen : ");
        user.Idcitizen = Input();
         Console.Write("Main name : ");
        user.Mainname1 = Input();
        Console.Write("Surname : ");
        user.Surname1 = Input();
        Console.Write("Id_citizen : ");
        user.Idcitizen1 = Input();
         Console.Write("Main name : ");
        user.Mainname2 = Input();
        Console.Write("Surname : ");
        user.Surname2 = Input();
        Console.Write("Id_citizen : ");
        user.Idcitizen2 = Input();
        Console.Write("Position in KFC : ");
        user.Position = Input();
        Console.Write("Name in KFC : ");
        user.nameagain = Input();
        Console.Write("Surname in KFC: ");
        user.surnameagain = Input();
        Console.Write("Age : ");
        user.age = Input();
        Console.Write("Jobmoney :");
        user.Money = Input();
        Console.Write("Position in KFC : ");
        user.Position1 = Input();
        Console.Write("Name in KFC : ");
        user.nameagain1 = Input();
        Console.Write("Surname in KFC: ");
        user.surnameagain1 = Input();
        Console.Write("Age : ");
        user.age1 = Input();
        Console.Write("Jobmoney :");
        user.Money1 = Input();
        Console.Write("Position in KFC : ");
        user.Position2 = Input();
        Console.Write("Name in KFC : ");
        user.nameagain2 = Input();
        Console.Write("Surname in KFC: ");
        user.surnameagain2 = Input();
        Console.Write("Age : ");
        user.age2 = Input();
        Console.Write("Jobmoney :");
        user.Money2 = Input();
        Console.Write("Position in KFC : ");
        user.Position3 = Input();
        Console.Write("Name in KFC : ");
        user.nameagain3 = Input();
        Console.Write("Surname in KFC: ");
        user.surnameagain3 = Input();
        Console.Write("Age : ");
        user.age3 = Input();
        Console.Write("Jobmoney :");
        user.Money3 = Input();
        Console.Write("Position in KFC : ");
        user.Position4 = Input();
        Console.Write("Name in KFC : ");
        user.nameagain4 = Input();
        Console.Write("Surname in KFC: ");
        user.surnameagain4 = Input();
        Console.Write("Age : ");
        user.age4 = Input();
        Console.Write("Jobmoney :");
        user.Money4 = Input();
    
        KFCstaff.Userme_Print(user);
    }
    public static long StoL(string Input)
    {
        if(long.TryParse(Input,out long result))
        {
            return result;
        }
        throw new Exception("Pls Input again");
    }
    public static string Input()
    {
        return Console.ReadLine();
    }
}