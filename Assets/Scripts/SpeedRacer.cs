using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carMaker;

    public string carModel = "GTR R35";

    public string engineType = "V6, Twin Turbo";

    public int carWeight = 1609;

    public int yearMade = 2009;

    public float maxAcceleration = 0.98f;

    public bool isCarTypeSedan = false;

    public bool hasFrontEngine = true;

    //A class that holds all properties and function of the car's fuel tank
    public class Fuel
    {
        //private property
        int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }

        //public property accessors
        public int getFuelLevel() => fuelLevel;

        public void setFuelLevel(int amount) => fuelLevel = amount;


        //updates fuel level based on car fuel consumption
        public void ConsumeFuel()
        {
            fuelLevel -= 10;
        }

        //notifies client on specific fuel level  
        public void CheckFuelLevel()
        {
            switch (fuelLevel)
            {
                case 70:
                    print("fuel level is nearing two - thirds.");
                    break;

                case 50:
                    print("fuel level is at half amount");
                    break;

                case 10:
                    print("Warning! Fuel level is critically low.");
                    break;

                default:
                    print("There is nothing to report.");
                    break;

            }
        }

    }

    public Fuel carFuel = new Fuel(100);

    // Start is called before the first frame update
    void Start()
    {
        print($"The car model is {carModel}, {carMaker} car, with a {engineType} engine type");

        //check car's weight
        CheckWeight();

        //checking if car was introduced after 2010
        if(yearMade <= 2009)
        {
            int carAge = CalculateAge(yearMade);

            print($"This car was made in the year {yearMade}");

            print($"This car is {carAge} years old");
        }
        else
        {
            print("This car was probably introduced in the 2010s");

            print($"This car has a maximum acceleration of {maxAcceleration}, woo crazy fast / slow, I dunno!");
        }

        print(CheckCharacteristics());

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            carFuel.ConsumeFuel();
            carFuel.CheckFuelLevel();
        }
    }

    //checks the car weight 
    void CheckWeight()
    {
        int maxWeight = 1500;

        if (carWeight < maxWeight)
        {
            print($"Car weight is less than {maxWeight}kg");
        }
        else
        {
            print($"Car weighs over {maxWeight}kg");
        }

    }

    //calculates the age of the car
    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan) return "This is a Sedan Car";

        if (hasFrontEngine) return "This isn't a Sedan Car, but it does have a front engine hm..";

        return "This Car isn't a Sedan and doesn't have a front engine";
    }
}
