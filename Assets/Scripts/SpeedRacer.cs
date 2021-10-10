using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    float maxAcceleration = 40.0f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;
    int carAge;


    // Start is called before the first frame update
    void Start()
    {
        print(carModel+" "+ engineType);
        print("previous step");
        CheckWeight();
        if (yearMade>=2009)
        {
            print("what year the car was introduced in, using the "+ yearMade);
            carAge = CalculateAge(yearMade);
            print("the age of the car" + carAge);
        }
        else
        {
              print("the car was introduced in the 2010’s");
            print("car’s maximum acceleration" + maxAcceleration);
        }

        CheckCharacteristics();


    }

    // Update is called once per frame
    void Update()
    {
       
    }

   function CheckWeight()
    {
        if (carWeight < 1500)
        {
            print(carModel +"less than 1500 kg ");
        }
        else
        {
            print(carModel + "over 1500 kg ");
        }
    }

    function int CalculateAge(int firstNumber)
    {
        return firstNumber
    }

    function string CheckCharacteristics()
    {
       if(isCarTypeSedan==true)
        {
            return "car type is a sedan"
        }
        else
        {
            if (hasFrontEngine == true)
            {
                return " car is neither a sedan nor does it have a front engine.";

            }
        }
           
    }
}
