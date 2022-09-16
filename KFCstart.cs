class KFCstaff
{
    public long KFCmoneystart ;
    public string branch = "";
    public string addess = "";
    public string Mainname = "";
    public string Surname = "";
    public string Idcitizen = "";
     public string Mainname1 = "";
    public string Surname1 = "";
    public string Idcitizen1 = "";
     public string Mainname2 = "";
    public string Surname2 = "";
    public string Idcitizen2 = "";
   
    public static void Userme_Print(KFCstaff user)
    
    {
        Console.WriteLine("----- KFC Information -----");
        Console.WriteLine("Money : {0}", user.KFCmoneystart);
        Console.WriteLine("branch : {0}", user.branch);
        Console.WriteLine("addess : {0}", user.addess);
        Console.WriteLine("----------------------------");
        Console.WriteLine("Main name : {0}", user.Mainname);
        Console.WriteLine("Surname : {0}", user.Surname);
        Console.WriteLine("Id_citizen : {0}", user.Idcitizen);
        Console.WriteLine("----------------------------");
         Console.WriteLine("Main name : {0}", user.Mainname1);
        Console.WriteLine("Surname : {0}", user.Surname1);
        Console.WriteLine("Id_citizen : {0}", user.Idcitizen1);
        Console.WriteLine("----------------------------");
         Console.WriteLine("Main name : {0}", user.Mainname2);
        Console.WriteLine("Surname : {0}", user.Surname2);
        Console.WriteLine("Id_citizen : {0}", user.Idcitizen2);
        Console.WriteLine("----------------------------");
    }
}