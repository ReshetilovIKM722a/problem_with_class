/* Створити клас. Описати поля та методи класу. Надіслати гітхаб репозиторій із створеним класом у гул клас.
Інтернет-провайдер
*/
using problem_with_class;

var Internet = new Internet(100, "Triolan", 240, "Ethernet");

Internet.DisplayInfo();

Internet.UpdateSpeed(100);

if (Internet.NeedsService())
{
    Console.WriteLine("You need to call the master");
    Internet.ResetSpeed();
}
else
{
    Console.WriteLine("Everything is fine");
}

Internet.UpdateSpeed(80);

if (Internet.NeedsService())
{
    Console.WriteLine("You need to call the master");
    Internet.ResetSpeed();
}
else
{
    Console.WriteLine("Everything is fine");
}