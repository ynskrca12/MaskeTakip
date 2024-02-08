

using Business.Concrete;
using Entities.Concrete;

SelamVer("engin");
SelamVer("yunus");
SelamVer();
SelamVer();

int sonuc = Topla();

Person person1 = new Person();
person1.FirstName = "YUNUS";
person1.LastName = "KIRCA";
person1.DateOfBirthYear = 1998;
person1.NationalIdentity = 21332576032;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);




Console.ReadLine();


static void SelamVer(String isim ="isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla()
{
    return 5;
}