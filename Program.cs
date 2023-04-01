//Доходы и расходы
double rashod = 29055.50;

//Распределение расходов
double socialka = 7343.10;
double armiya = 4981.60;
double policia = 4417.10;
double zdrav = 1469.40;
double obrazov = 1392.80;
double zhkh = 604.90;
double ecolog = 342.10;
double culture = 196.10;
double smi = 118.00;
double fizo = 67.90;

//Ввод потраченых денег
Console.WriteLine("Сколько вы потратили денег в прошлом году? (в рублях)");
double my = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

//Расчёт долей
Console.WriteLine("Ваша доля:");
Console.WriteLine("Социалка: " + Math.Floor(socialka/rashod*my*0.2));
Console.WriteLine("Армия: " + Math.Floor(armiya/rashod*my*0.2));
Console.WriteLine("Полиция: " + Math.Floor(policia/rashod*my*0.2));
Console.WriteLine("Медицина: " + Math.Floor(zdrav/rashod*my*0.2));
Console.WriteLine("Образование: " + Math.Floor(obrazov/rashod*my*0.2));
Console.WriteLine("ЖКХ: " + Math.Floor(zhkh/rashod*my*0.2));
Console.WriteLine("Охрана окружающей среды: " + Math.Floor(ecolog/rashod*my*0.2));
Console.WriteLine("Культура: " + Math.Floor(culture/rashod*my*0.2));
Console.WriteLine("СМИ: " + Math.Floor(smi/rashod*my*0.2));
Console.WriteLine("Спорт: " + Math.Floor(fizo/rashod*my*0.2));

Console.ReadKey();