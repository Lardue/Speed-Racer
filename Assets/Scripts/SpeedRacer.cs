using UnityEngine;

public class SpeedRacer : MonoBehaviour
{

    // Variables 
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";

    int carWeight = 1609;
    int yearMade = 2009;

    float maxAcceleration = 0.98f;

    bool isCarTypeSedan = false;
    bool hasFrontEngine = true; 

    // Start is called before the first frame update
    void Start()
    {
        print("The car model " + carModel + " has a " + engineType + " engine.");
        
        CheckWeight();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print("The " + carModel + " weighs less than 1500kg.");
        } else
        {
            print("The " + carModel + " weighs over 1500kg.");
        }
    }
}
