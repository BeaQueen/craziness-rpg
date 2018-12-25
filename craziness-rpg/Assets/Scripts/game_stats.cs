using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_stats : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static bool IsFemale;
    //public static string playerName = new string[](get; set;);
    public static int PlayerOrderNum;
    public static int PlayerHealth;
    public static int PlayerAttack;
}
