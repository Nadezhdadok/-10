using System.Xml.XPath;
using Задача_10;
int gradus_ = Convert.ToInt32(Console.ReadLine());
int min_ = Convert.ToInt32(Console.ReadLine());
int sec_ = Convert.ToInt32(Console.ReadLine());

Navigator navigator = new Navigator (gradus_, min_, sec_);

//Navigator navigator = new Navigator() { gradus= gradus_, min=min_, sec=sec_};
//navigator.gradus = Convert.ToInt32(Console.ReadLine());
//navigator.min = Convert.ToInt32(Console.ReadLine());
//navigator.sec = Convert.ToInt32(Console.ReadLine());
double totalradians = navigator.ToRadians();
Console.Write(totalradians);

