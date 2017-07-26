using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculation : MonoBehaviour
{

    // Use this for initialization
    public Button calculateButton;
    public Dropdown Gender_input;
    public InputField input_1;
    public InputField input_2;
    public InputField input_3;
    public Text CalculationOuput;

    private double val1;
    private double val2;
    private double val3;
    void Start()
    {
        Button calcbtn = calculateButton.GetComponent<Button>();
        calcbtn.onClick.AddListener(TaskOnClick);
        Dropdown gender = Gender_input.GetComponent<Dropdown>();
        InputField weight = input_1.GetComponent<InputField>();
        InputField age = input_2.GetComponent<InputField>();
        InputField height = input_3.GetComponent<InputField>();
    }



    // Update is called once per frame
    void Update()
    {
        Button calcbtn = calculateButton.GetComponent<Button>();
        calcbtn.onClick.AddListener(TaskOnClick);
    }
    private void TaskOnClick()
    {
        try{
            val1 = double.Parse(input_1.text);
            val2 = double.Parse(input_2.text);
            val3 = double.Parse(input_3.text);
        }
        catch
        {
            CalculationOuput.text = "Need #";
        }

        if (Gender_input.value == 0)
        {

            if (val1 == 10)
            {
                CalculationOuput.text = "10male";
            }
        }
        else if (Gender_input.value == 1)
        {
        }
        else
        {

        }
    }
}
