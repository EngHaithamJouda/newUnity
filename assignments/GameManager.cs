using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // player p_1 = new player();
        // player p_2 = new player();
        // player p_3 = new player();
        // p_1.InitializePlayer("haitham", 150);
        // p_2.InitializePlayer("player2", 60);
        // Debug.Log("player1 name " + p_1.playerName);
        // Debug.Log("player1 health " + p_1.health);
        // Debug.Log("player2 name " + p_2.playerName);
        // Debug.Log("player2 health " + p_2.health);
        // Debug.Log("players after healing");
        // p_1.heal(200);
        // p_2.heal(30);
        // p_2.heal(false);
        // Debug.Log("player 1 after full Restore");
        // p_1.heal(true);
        // Debug.Log("player 2 after full Restore");
        // p_2.heal(true);
        // player.ShowPlayerCount();
        Player1 player = new Player1("Haitham", 100);
        Enemy enemy = new Enemy("Unity", 100);
        enemy.Attack(player, 70);
        player.Heal(50);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
