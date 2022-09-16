using System;
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
    public string Position = "";
    public string nameagain = "";
    public string surnameagain = "";
    public string age = "";
    public string Money = "";
        public string Position1 = "";
    public string nameagain1 = "";
    public string surnameagain1 = "";
    public string age1 = "";
    public string Money1 = "";
        public string Position2 = "";
    public string nameagain2 = "";
    public string surnameagain2 = "";
    public string age2 = "";
    public string Money2 = "";
        public string Position3 = "";
    public string nameagain3 = "";
    public string surnameagain3 = "";
    public string age3 = "";
    public string Money3 = "";
        public string Position4 = "";
    public string nameagain4 = "";
    public string surnameagain4 = "";
    public string age4 = "";
    public string Money4 = "";

   
    public static void Userme_Print(KFCstaff user)
    
    {
        Console.WriteLine("----- KFC Information -----");
        Console.WriteLine("Money : {0}", user.KFCmoneystart);
        Console.WriteLine("branch : {0}", user.branch);
        Console.WriteLine("addess : {0}", user.addess);
        Console.WriteLine("----------------------------");
        Console.WriteLine("===========Owner in KFC=========");
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
        Console.WriteLine("============Employeeeeeeee========");
        Console.WriteLine("What position in KFC : {0}", user.Position);
        Console.WriteLine("Name : {0}",user.nameagain);
        Console.WriteLine("Surname : {0}", user.surnameagain);
        Console.WriteLine("Age : {0}",user.age);
        Console.WriteLine("Jobmoney : {0}",user.Money);
        Console.WriteLine("----------------------------");
        Console.WriteLine("What position in KFC : {0}", user.Position1);
        Console.WriteLine("Name : {0}",user.nameagain1);
        Console.WriteLine("Surname : {0}", user.surnameagain1);
        Console.WriteLine("Age : {0}",user.age1);
        Console.WriteLine("Jobmoney : {0}",user.Money1);
        Console.WriteLine("----------------------------");
        Console.WriteLine("What position in KFC : {0}", user.Position2);
        Console.WriteLine("Name : {0}",user.nameagain2);
        Console.WriteLine("Surname : {0}", user.surnameagain2);
        Console.WriteLine("Age : {0}",user.age2);
        Console.WriteLine("Jobmoney : {0}",user.Money2);
        Console.WriteLine("----------------------------");
        Console.WriteLine("What position in KFC : {0}", user.Position3);
        Console.WriteLine("Name : {0}",user.nameagain3);
        Console.WriteLine("Surname : {0}", user.surnameagain3);
        Console.WriteLine("Age : {0}",user.age3);
        Console.WriteLine("Jobmoney : {0}",user.Money3);
        Console.WriteLine("----------------------------");
        Console.WriteLine("What position in KFC : {0}", user.Position4);
        Console.WriteLine("Name : {0}",user.nameagain4);
        Console.WriteLine("Surname : {0}", user.surnameagain4);
        Console.WriteLine("Age : {0}",user.age4);
        Console.WriteLine("Jobmoney : {0}",user.Money4);
        Console.WriteLine("----------------------------");


    }
}