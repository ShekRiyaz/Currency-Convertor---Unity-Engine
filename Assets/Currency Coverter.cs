using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrencyCoverter : MonoBehaviour
{
    public TMP_Dropdown format1;
    public TMP_Dropdown format2;
    public TMP_InputField input;
    public TMP_InputField output;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (input.text != string.Empty)
        {
            INR();
            USD();
            EURO();
            YEN();
        }

        
       
    }
    void INR()
    {
        // INR
        if (format1.value == 0)
        {
           //INR to INR
           if (format2.value == 0)
            {
                //yet to be converted - ytbc
                output.text = input.text;

            }
            // INR to USD
            else if (format2.value == 1)
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 0.012).ToString();

            }
            // INR to EURO
            else if (format2.value == 2)
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 0.011).ToString();

            }
            //INR to YEN
            else if (format2.value == 3 )
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 1.93).ToString();

            }
        }
    }
     void USD()
    {
        // USD
        if (format1.value == 1)
        {
           // USD to INR
           if (format2.value == 0)
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 83.59).ToString();

            }
            // USD to USD
            else if (format2.value == 1)
            {
                //yet to be converted - ytbc
                output.text = input.text;

            }
            // USD to EURO
            else if (format2.value == 2)
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 0.92).ToString();

            }
            // USD to YEN
            else if (format2.value == 3 )
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 161.57).ToString();

            }
        }
    }
    void EURO()
    {
        // EURO
        if (format1.value == 2)
        {
            // EURO to INR
            if (format2.value == 0)
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 90.71).ToString();

            }
            // EURO to USD
            else if (format2.value == 1)
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 1.09).ToString();

            }
            // EURO to EURO
            else if (format2.value == 2)
            {
                //yet to be converted - ytbc
                output.text = input.text;
                

            }
            // EURO to YEN
            else if (format2.value == 3)
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 175.31).ToString();

            }
        }
    }
    void YEN()
    {
        // YEN
        if (format1.value == 3)
        {
            // YEN to INR
            if (format2.value == 0)
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 0.52).ToString();

            }
            // YEN to USD
            else if (format2.value == 1)
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 0.0062).ToString();

            }
            // YEN to EURO
            else if (format2.value == 2)
            {
                //yet to be converted - ytbc
                int ytbc = int.Parse(input.text);
                output.text = (ytbc * 0.0057).ToString();

            }
            // YEN to YEN
            else if (format2.value == 3)
            {
                //yet to be converted - ytbc
                output.text = input.text;

            }
        }
    }
}
