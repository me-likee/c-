
//integer tanımlama şekli
int integer1=5;
int integer2=3;
int integer3=integer1+integer2;
Console.WriteLine(integer3);

//bool tanımlama şekli
bool bool1=10>100;
Console.WriteLine(bool1);

//string tanımlama şekli
string str20="20";
int int20=20;
string yenideger=str20+int20.ToString();
Console.WriteLine(yenideger);

int int21=int20+Convert.ToInt32(str20);
Console.WriteLine(int21);

//try Catch 
try
{
 Console.WriteLine("Yeni Şifre Oluşturunuz!");
 object sifre=Console.ReadLine();
}
//catch(Exception ex)
//{
//Console.WriteLine("Hata :"+ex.HelpLink.ToString());
//}

catch(ArgumentNullException ex)
{
Console.WriteLine("Şifrenizde boşluk olamaz");
}
catch(FormatException ex)
{
Console.WriteLine("Şifrenizde uygun olmayan veri tipi mevcuttur");
}
finally
{
    Console.Write("Şifre Oluşturmaİşlemi Başarılıdır");
}