using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //==========================================
        // ex1 
        /*
                true && true = true
            true && false = false
            false && false = false
            true || false = true
            false || false = false
            !true = false
            !(false || true) = !(true) = false
            (5 > 3) && (2 < 4) = true && true = true
            (10 == 10) || (5 != 5)  = true || false = true
            (3 >= 2) && !(6 < 3) true && (!false)= true && true = true
            */

        bool a = true;
        bool b = false;
        bool result_1 = !(b || a);
        bool result_2 = (5 > 3) && (2 < 4);
        bool result_3 = (10 == 10) || (5 != 5);
        bool result_4 = (3 >= 2) && !(6 < 3);
        // print 
        Debug.Log(a && a);
        Debug.Log(a && b);
        Debug.Log(b && b);
        Debug.Log(a || b);
        Debug.Log(b || b);
        Debug.Log(!a);
        Debug.Log(result_1);
        Debug.Log(result_2);
        Debug.Log(result_3);
        Debug.Log(result_4);

        //===========================================
        // ex 2 

        /*

    wx 2 :
----------------------------------------------
     (5 + 3) * 2 - 4 / 2  
        1- (5+3)=8
        2- 8*2 = 16
        3- 4/2 = 2
        4- 16-2 = 14
        result is 14
------------------------------
    10 - 3 * 2 + 4 = 5
        1- 3*2 = 6
        2- 10- 6 = 4
        3- 4+4 = 8
        result is 8
-----------------------------
    2 + 3 * 4 > 10 && 4 <= 4
        1- 3*4 = 12
        2- 2+12 = 14
        3- 14 > 10 = true 
        4- 4<=4 = true 
        5- true && true = true 
    result = true 
 --------------------------------
 !(10 >= 5) || 7 != 3
    1- (10 >= 5) = true
    2- !true = false 
    3- 7 != 3 = true 
    4- false || true = true 
    result = true
-------------------------------
    (8 % 3 + 2) * 4 - 6
        1- 8 % 3 = 2
        2- 2+2 = 4 
        3- 4*4 = 16
        4- 16-6 = 10
     result = 10
-------------------------------
    10 == 5 + 5 && 4 > 2 || 3 < 1
        1- 5+5 = 10 
        2- 10 ==10 = true 
        3- 4>2 = true 
        4- true && true = true 
        5- 3< 1 = false 
        6- true || false = true 
        result is true
-----------------------------------
    ++x * 2 - --y / 2 (Assume x = 3 and y = 5)
    1- ++x =4
    2- 4*2 = 8
    3- --y = 4
    4- 4/2 = 2
    5- 8 - 2 = 6
    result is 6
----------------------------------------
    (4 + 5 * 2) != 13 || (6 / 2 == 3)
        1- 5*2 = 10 
        2- 4+10 = 14 
        3- 14 != 13 = true 
        4- 6/2 = 3
        5- 3==3 = true 
        6- true || true = true 
    result is true 
--------------------------------------------
    6 >= 3 * 2 && (5 % 2 == 1)
        1- 3*2 = 6
        2- 6>=6 = true 
        3- 5 % 2 = 1
        4- 1 == 1 = true 
        5- true && true = true 
    result is true 
        */
        // ex 2  programming
        int expr1 = (5 + 3) * 2 - 4 / 2;
        int expr2 = 10 - 3 * 2 + 4;
        bool expr3 = (2 + 3 * 4 > 10) && (4 <= 4);
        bool expr4 = !(10 >= 5) || (7 != 3);
        int expr5 = (8 % 3 + 2) * 4 - 6;
        bool expr6 = (10 == 5 + 5 && 4 > 2) || (3 < 1);
        int x = 3;
        int y = 5;
        int expr7 = ++x * 2 - --y / 2;
        bool expr8 = (4 + 5 * 2) != 13 || (6 / 2 == 3);
        bool expr9 = 6 >= 3 * 2 && (5 % 2 == 1);


        Debug.Log(expr1); // 14
        Debug.Log(expr2); // 8
        Debug.Log(expr3); // True
        Debug.Log(expr4); // True
        Debug.Log(expr5); // 10
        Debug.Log(expr6); // True
        Debug.Log(expr7); // 6
        Debug.Log(expr8); // True
        Debug.Log(expr9); // True

        // ex 3 
        //==============================================

        int playerLives = 3;
        while (playerLives > 0)
        {
            if (playerLives == 3)
            {
                Debug.Log("Many lives");
            }
            else if (playerLives == 1)
            {
                Debug.Log("The last life!");
            }
            playerLives--;

        }

        Debug.Log("Game Over!");


    }
}
