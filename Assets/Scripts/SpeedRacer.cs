using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public class Fuel
    {
        // Variables Fuel 
        public int fuelLevel; 

        public Fuel (int pAmount)
        {
            fuelLevel = pAmount;
        }
    }

    // Variables SpeedRacer
    public Fuel carFuel = new Fuel(100);

    public string carMaker;

    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";

    public int carWeight = 1609;
    public int yearMade = 2009;

    public float maxAcceleration = 0.98f;

    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    // Start is called before the first frame update
    void Start()
    {
        print("The car model is " + carModel + " " + carMaker + ". It has a " + engineType + " engine.");
        
        CheckWeight();

        if (yearMade <= 2009)
        {
            print("The car was introduced in the year " + yearMade);

            int carAge = CalculateAge(yearMade);

            print("It is " + carAge + " years old.");
        } 
        else
        {
            print("The car was introduced in the 2010's.");
            print("The maximum acceleration is " + maxAcceleration + ".");
        }

        print(CheckCharacteristics());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // Checks if the weigth of the car model is over 1500 kg 
    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print("The " + carModel + " weighs less than 1500kg.");
        } 
        else
        {
            print("The " + carModel + " weighs over 1500kg.");
        }
    }

    // Calculates the age of the car 
    int CalculateAge (int pAge)
    {
        return 2021 - pAge;
    }

    // Checks characteristics
    string CheckCharacteristics()
    {
        if (isCarTypeSedan == true)
        {
            return "The car typ is a sedan."; 
        } 
        else if (hasFrontEngine == true)
        {
            return "The car is not a sedan, but has a front engine.";
        } 
        else
        {
            return "The car is neither a sedan nor does it have a front engine.";
        }
    }

    // Funtction lets car consumes fuel
    void ConsumeFuel ()
    {
        carFuel.fuelLevel -= 10; 
    }

    // Checks the fuel level of the car
    void CheckFuelLevel ()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("The fuel level is nearing two-thirds.");
                break;
            case 50:
                print("The fuel level is at half amount.");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("There's nothing to report regarding the fuel level.");
                break;
        }
    }

}
