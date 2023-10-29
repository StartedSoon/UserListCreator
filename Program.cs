Console.WriteLine("Kaç kişilik bir liste oluşturmak istiyorsunuz ?"); //yazı
int maxUser = Math.Clamp(Convert.ToInt32(Console.ReadLine()), 0,1000000); //en fazla kaç kişi olacağını tanımlıyoruz tanım
Console.WriteLine($"{maxUser} kişilik bir liste oluşturuldu"); //yazı grup oluşturuldu
string[] UserList = new string[maxUser]; //tanım-1 liste oluşturuldu
int userID; //kullanıcının sayısının kimliği tanımlandı.
for (userID = 0; userID <= maxUser - 1; userID++)
{
    Console.WriteLine("Listeye eklenecek bir kullanıcı adı giriniz. Eğer durmak istiyorsanız dur yazınız. ");
    string yazi = Console.ReadLine();
    if (yazi == "dur")
    {
        Console.WriteLine("Liste tamamlandı.");
        break;
    }
    else
    {
        UserList[userID] = yazi;
    }
}
Console.WriteLine("Liste Sıralanıyor...");
for (int sira = 0; sira <= userID - 1; sira++)
{
    Console.WriteLine(UserList[sira]);
}

