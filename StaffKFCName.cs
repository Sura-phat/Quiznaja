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