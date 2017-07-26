using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour {

    
    public Dropdown Gender_input;
    public InputField input_1;
    public InputField input_2;
    public InputField input_3;
    public Text CalculationOuput;

    private static double val1;//Label
    private static double val2;//Label
    private static double val3;//Label
    private static int valgen;
    public void OnCalculateButtonClick()
    {
        ValueParse();

        if(Gender())
        {
            switch(AgeGroup()){
                case 1:
                    CalculationOuput.text = "U18Male";
                    break;
                default:
                 break;
            }
        }
        else
        {
            CalculationOuput.text = "Girl";
        }
    }
    private static Boolean Gender()
    {
        Boolean gender;//true male; false female
        if(valgen == 0)
        {
            gender = true;
            Debug.Log("Male");
        }
        else
        {
            gender = false;
            Debug.Log("Female");
        }
        return gender;
    }
    private static int AgeGroup()
    {
        int ageGroup;
        if(val1 < 18)
        {
            ageGroup = 1;
        }else if(val1>=18 && val1 < 30)
        {
            ageGroup = 2;
        }
        else
        {
            ageGroup = 0;
        }


        return ageGroup;
    }
    private static Double Weight()
    {
        double weight;
        weight = val2;


        return weight;
    }
    private static Double Height()
    {
        double height;
        height = val2;


        return height;
    }
    private void ValueParse()
    {
        valgen = Gender_input.value;
        try
        {
            val1 = double.Parse(input_1.text);
            val2 = double.Parse(input_2.text);
            val3 = double.Parse(input_3.text);

        }
        catch
        {
            CalculationOuput.text = "Need #";
            Debug.LogError("Need number");
        }
        Debug.Log(valgen + " " + val1 + " " + val2 + " " + val3);
    }

}
