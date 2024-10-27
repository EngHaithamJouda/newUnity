using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{


    void Start()
    {

        // sbyte[] arr = { 5, 1, 50, 4, 2, 8, 1, 0, 3 };
        // int a = arr.Length;

        // string errorMassage_1 = "Just for assignment this is an  error";
        // string warningMassage_1 = "by bubble sort this is the sorted array coppy writeing by Haitham:";
        // BubbleSortArray(arr);

        // Debug.LogError(errorMassage_1);
        // Debug.LogWarning(warningMassage_1);
        // Debug.Log(" The numbr of elements is " + a);
        // foreach (int num in arr)
        // {
        //     Debug.Log(num);
        // }
        // string name = "Haitham";
        // int id = 1;
        // double amount = 500;
        // name = System.Console.ReadLine();
        // id = int.Parse(System.Console.ReadLine());
        // amount = double.Parse(System.Console.ReadLine());
        // Names.Add(name);
        // Id.Add(id);
        // Amount.Add(amount);
        sbyte[] arr_1 = { 10, 7, 8, 4, 15, 78, 0, 1 };
        BubbleSortArray(arr_1);
        foreach (sbyte num in arr_1)
        {
            Debug.Log(num);
        }
    }

    public static void BubbleSortArray(sbyte[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    sbyte temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }



    // List<string> Names = new List<string>();
    // List<int> Id = new List<int>();
    // List<double> Amount = new List<double>();

    // public void view_bank_account(int acc_id)
    // {

    //     Debug.Log("Displaying accounts in the bank:");
    //     foreach (int number in Id)
    //     {
    //         Debug.Log(number);
    //     }
    //     foreach (string n in Names)
    //     {
    //         Debug.Log(n);
    //     }
    //     foreach (double amounts in Amount)
    //     {
    //         Debug.Log(Amount);
    //     }

    // }

}



