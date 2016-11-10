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

    //private BigInteger BigInteger;
    public static long oxygen { get; set; }
    public static long calories { get; set; }
    public static float multiplier { get; set; }
    public static float calMultiplier { get; set; }

    private long temp;

    private void Start()
    {
        multiplier = 1;
        calMultiplier = 0;
        obg = oxygenBaseGain;
        cbg = calorieBaseGain;
    }

    private void Update()
    {
        O2Text.text = oxygen.ToString( "n0", new CultureInfo("de-DE"));
        CALText.text = calories.ToString( "n0", new CultureInfo("de-DE") );

        //Debug.Log(calMultiplier + " " + cbg);
    }

    private static long CalculateO2Amount()
    {
        var calc = oxygen + obg*multiplier;
        return (long) calc;
    }

    private static long CalculateCALAmount()
    {
        var calc = calories + cbg*calMultiplier;
        return (long) calc;
    }

    public static void IncreaseOxygen()
    {
        oxygen = CalculateO2Amount();
    }

    public static void DecreaseOxygen(long amount)
    {
        oxygen = oxygen - amount;
    }

    public static void IncreaseCalories()
    {
        calories = CalculateCALAmount();
    }

    public static void DecreaseCalories(long amount)
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