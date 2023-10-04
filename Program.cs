Buffet buffet = new Buffet();
Ninja ninja = new Ninja();
while (ninja.IsFull == false)
{
    ninja.Eat(buffet.Serve());
}

class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy;
    public bool IsSweet;

    public Food(string name, int calories, bool isSpicy, bool isSweet)
    {
        Name = name;
        Calories = calories;
        IsSpicy = isSpicy;
        IsSweet = isSweet;
    }
}

class Buffet
{
    public List<Food> Menu;

    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Porotos", 100, false, false),
            new Food("Chorillana", 200, false, false),
            new Food("Lentejas", 100, false, false),
            new Food("Cazuela", 100, false, false),
            new Food("Pastel de Choclo", 100, false, false),
            new Food("Pie de limon", 300, false, true),
            new Food("Burritos picantes", 400, true, false),
        };
    }

    public Food Serve()
    {
        Random rand = new Random();
        int randFood = rand.Next(Menu.Count);
        return Menu[randFood];
    }
}

class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;

    // add a constructor
    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }
    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
        get
        {
            if (calorieIntake > 1200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    // build out the Eat method
    public void Eat(Food item)
    {
        if (IsFull == false)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine(item.Name);
            if (item.IsSpicy == true)
            {
                Console.WriteLine("Esto es picante");
            }
            if (item.IsSweet == true)
            {
                Console.WriteLine("Esto es dulce");
            }
        }
        else
        {
            Console.WriteLine("El ninja esta satisfecho y no puede comer mas");
        }
    }
}