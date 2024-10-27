using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
public class assignment8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ex_1
        //======================================
        Random random_number = new Random();
        while (true)
        {
            sbyte num = (sbyte)random_number.Next(1, 21);
            if (num == 5)
            {
                continue;
            }
            Debug.Log(num);
            if (num == 15)
            {
                break;
            }

            //ex_2
            //===========================================
            string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
            Random rand = new System.Random();
            string sentence = "";
            sbyte counter = 0;

            while (counter < 7)
            {
                sbyte index = (sbyte)rand.Next(words.Length);
                sentence += words[index] + " ";
                counter++;
            }

            Console.WriteLine(sentence.Trim());
        }
    }
}


