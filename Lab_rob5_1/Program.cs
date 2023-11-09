//абстрактний клас Parent, що описує літак
abstract class Parent
{
    public double pole1; //швидкість
    public double pole2; //висота
    public double pole3; //вартість
    public Parent(double pole1, double pole2)
    {
        this.pole1 = pole1;
        this.pole2 = pole2;
    }
    public abstract string Info(); //інформація про поля об'єкта
    public abstract void Metod(); //обчислення вартості об'єкта для pole3
}
//дочірній клас Child1, що описує пасажирський літак
class Child1 : Parent
{
    public Child1(double pole1, double pole2) : base(pole1, pole2)
    {

    }
    public override string Info()
    {
        return "Пасажирський: швидкiсть = " + pole1 + ", висота = " + pole2 + ", вартiсть = " + pole3;
    }
    public override void Metod()
    {
        pole3 = pole1 * 1000 + pole2 * 100;
    }
}
//дочірній клас Child2, що описує винищувач 
class Child2 : Parent
{
    public Child2(double pole1, double pole2) : base(pole1, pole2)
    {

    }
    public override string Info()
    {
        return "Винищувач: швидкiсть = " + pole1 + ", висота = " + pole2 + ", вартiсть = " + pole3;
    }
    public override void Metod()
    {
        pole3 = pole1 * 3000 + pole2 * 200;
    }
}
//дочірній клас Child3, що описує бомбардувальник
class Child3 : Parent
{
    public double pole4; //кількість бомб
    public Child3(double pole1, double pole2, double pole4) : base(pole1, pole2)
    {
        this.pole4 = pole4;
    }
    public override string Info()
    {
        return "Бомбардувальник: швидкiсть = " + pole1 + ", висота = " + pole2 + ", кiлькiсть бомб = " + pole4 + ", вартiсть = " + pole3;
    }
    public override void Metod()
    {
        pole3 = pole1 * 1500 + pole2 * 150 + pole4 * 50;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random o = new Random();
        for (int i = 0; i < 5; i++)
        {
            int type = o.Next(1, 4);
            double speed = o.Next(100, 2500);
            double height = o.Next(10, 30);
            double bombs = o.Next(1, 20);

            if (type == 1)
            {
                Child1 a = new Child1(speed, height);
                a.Metod();
                Console.WriteLine(a.Info());
            }
            else if (type == 2)
            {
                Child2 b = new Child2(speed, height);
                b.Metod();
                Console.WriteLine(b.Info());
            }
            else
            {
                Child3 c = new Child3(speed, height, bombs);
                c.Metod();
                Console.WriteLine(c.Info());
            }
        }
    }
}
