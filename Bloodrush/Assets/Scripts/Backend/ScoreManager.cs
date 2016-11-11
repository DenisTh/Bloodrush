using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static int obg;
    private static int cbg;

    public int oxygenBaseGain = 1;
    public int calorieBaseGain = 1;

    public Text CALText;
    public Text O2Text;

    public static ulong oxygen { get; set; }
    public static ulong calories { get; set; }
    public static float multiplier { get; set; }
    public static float calMultiplier { get; set; }

    private string[] numberStrings =
    {
        "n0",
        "#,##0, Thousand",
        "#,##0,, Million",
        "#,##0,,, Billion",
        "#,##0,,,, Trillion",
        "#,##0,,,,, Quadrillion",
        "#,##0,,,,,, Quintillion"
    };

    private int numberString;

    private void Start()
    {
        multiplier = 1;
        calMultiplier = 0;
        obg = oxygenBaseGain;
        cbg = calorieBaseGain;
    }

    private void Update()
    {
        UpdateScoreString();
        O2Text.text = oxygen.ToString(numberStrings[numberString], new CultureInfo("de-DE"));

//        O2Text.text = oxygen.ToString( "n0", new CultureInfo("de-DE"));
        CALText.text = calories.ToString( "n0", new CultureInfo("de-DE") );

        Debug.Log(numberString);
    }

    private void UpdateScoreString()
    {
        if (oxygen >= 1000 && oxygen < 1000000)
            numberString = 1;
        else if (oxygen >= 1000000 && oxygen < 1000000000)
            numberString = 2;
        else if (oxygen >= 1000000000 && oxygen < 1000000000000)
            numberString = 3;
        else if (oxygen >= 1000000000000 && oxygen < 1000000000000000)
            numberString = 4;
        else if (oxygen >= 1000000000000000 && oxygen < 1000000000000000000)
            numberString = 5;
        else if (oxygen >= 1000000000000000000)
            numberString = 6;
    }

    private static ulong CalculateO2Amount()
    {
        var calc = oxygen + obg*multiplier;
        return (ulong) calc;
    }

    private static ulong CalculateCALAmount()
    {
        var calc = calories + cbg*calMultiplier;
        return (ulong) calc;
    }

    public static void IncreaseOxygen()
    {
        oxygen = CalculateO2Amount();
    }

    public static void DecreaseOxygen(ulong amount)
    {
        oxygen = oxygen - amount;
    }

    public static void IncreaseCalories()
    {
        calories = CalculateCALAmount();
    }

    public static void DecreaseCalories(ulong amount)
    {
        calories = calories - amount;
    }

    public static void IncreaseMult(float amount)
    {
        multiplier += amount;
    }

    public static void DecreaseMult(float amount)
    {
        multiplier -= amount;
    }

    public static void IncreaseCALMult(float amount)
    {
        calMultiplier += amount;
    }

    public static void DecreaseCALMult(float amount)
    {
        calMultiplier -= amount;
    }
}