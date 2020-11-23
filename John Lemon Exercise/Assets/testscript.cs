using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class testscript : MonoBehaviour
{
    // public UnityEvent NumberChange;
   

    public int m_valueOne;
    public int m_valueTwo;

    public bool minValue = false;
    public bool maxValue = false;

    public bool enter = false;

    private string function;
   


    // Start is called before the first frame update
    void Start()
    {
       

    }


    // Update is called once per frame
   

    private void Update()
    {
        if (minValue == true)
        {
            maxValue = false;
            function = "MinValue";
        }
         if (maxValue == true)
        {
            minValue = false;
            function = "MaxValue";
        }
        else if (minValue == false && maxValue == false)
        {
            function = "nuFunction";
        }

     

        if (enter == true)
        {
            Debug.Log(NumberComparison(m_valueOne, m_valueTwo, function));
            enter = false;
            
        }

    }
    private string NumberComparison(int valueOne, int ValueTwo, string function)
    {
        if (function == "MinValue")
        {
            int outcome = Mathf.Min(valueOne, ValueTwo);

            return ("The smallest value is: " + outcome.ToString());
        }
         if (function == "MaxValue")
        {

             int outcome = Mathf.Max(valueOne, ValueTwo);
             return ("The largest value is: " + outcome.ToString());

        }
         if (function == "noFunction")
        {
            return ("select a function");
        }


        else
        {
            return null;  
        }
    
    }

}
