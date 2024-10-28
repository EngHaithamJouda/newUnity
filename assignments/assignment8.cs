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
        Random random_nber = new Random();
        while (true)
        {
            int n = random_nber.Next(1, 21);
            if (n == 5)
            {
                continue;
            }
            Debug.Log(n);
            if (n == 15)
            {
                break;
            }
        }
        //ex_2
        //===========================================
        string[] w = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        Random random_2 = new System.Random();
        string funnySentence;
        int i = 0;

        while (i < 7)
        {
            int index = random_2.Next(w.Length);
            funnySentence += w[index] + " ";
            counter++;
            int index = random_2.Next(words.Length);
            funnySentence += words[index] + " ";
            i++;
           
        }
         Debug.Log(funnySentence + ".");
    }
}
