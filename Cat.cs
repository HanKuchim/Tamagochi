namespace Тамагочи
{
    public struct Food
    {
        public int heath;
        public string type;
    }
    class Cat
    {
        private string name;
        private int satiety;

        public Cat(string name = "Homeless", int hunger = 0)
        {
            this.name = name;
            this.satiety = hunger;
        }
        public void Meow() //Мяу!
        {
            Console.WriteLine("Meow");
        }
        public void Eat(Food food)
        {
            Console.WriteLine($"Cat eat {food.type}. {food.type} got {food.heath} Satiety.");
            satiety += food.heath;
        }

        public static void Info(Cat a) //информация о кошке
        {
            Console.WriteLine($"{a.name}, {a.satiety}");
        }
        public void CheckHunger()
        {
            Console.WriteLine($"Satiety: {satiety}");
        }
        public void Play() //играем с кошкой
        {
            Console.WriteLine($"{name} playing whih a toy!");
            satiety -= 5;
            if (satiety < 0)
            {
                Console.WriteLine($"{name} died of hunger!");
            }
            else
            {
                Console.WriteLine($"{name} is tired...");
                CheckHunger();
            }
        }

        public void Run() //кошка бегает за мышкой
        {
            Console.WriteLine($"{name} is running for a mouse!");
            satiety -= 10;
            if (satiety < 0)
            {
                Console.WriteLine($"{name} died of hunger!");
            }
            else
            {
                Console.WriteLine($"{name} is tired...");
                CheckHunger();
            }
        }
        public bool IsAlive()  //проверка на голод
        {
            bool flag = true;
            if (satiety < 0)
            {
                flag = false;
            }
            return flag;
        }
    }

}