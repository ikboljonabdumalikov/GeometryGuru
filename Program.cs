// 3-dars vazifasi: Foydalanuvchidan ikkita son qabul qilib, 4 ta arifmetik amal bajarish


// Console.WriteLine("Iltimos, birinchi raqamni kiriting:");
// double firstNumber = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Iltimos, ikkinchi raqamni kiriting:");
// double secondNumber = Convert.ToDouble(Console.ReadLine());

// double sum = firstNumber + secondNumber;
// double difference = firstNumber - secondNumber;
// double multipliedSum = firstNumber * secondNumber;
// double quotient = firstNumber / secondNumber;
// Console.WriteLine($"Yig'indi: {sum}");
// Console.WriteLine($"Ayirma: {difference}");
// Console.WriteLine($"Ko'paytma: {multipliedSum}");
// Console.WriteLine($"Bo'linma: {quotient}");





// 4-dars vazifasi: Ixtiyoriy matematik/geometrik formulani olib, kodda ifoda qilish

Console.WriteLine("Bu dastur uchburchakning gipotenuzasini topish uchun ishlatiladi! \n");

Console.WriteLine("Iltimos, birinchi sonni kiriting:");
double firstNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Iltimos, ikkinchi sonni kiriting:");
double secondNum = Convert.ToDouble(Console.ReadLine());

double hypotenuse = Math.Sqrt((firstNum * firstNum) + (secondNum * secondNum));
Console.WriteLine($"Uchburchakning yuzi {hypotenuse} ga teng");
