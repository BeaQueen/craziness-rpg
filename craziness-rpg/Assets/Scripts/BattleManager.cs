using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BattleManager : MonoBehaviour{
    public Text statusText;
    public int[] numPlayers;
    public int[] numEnemies;
    public Text playerName;
    public bool BattleMode = true;

    void Awake()
    {
        BattleMode = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (BattleMode == true)
        {
            Debug.Log("Battle starts!");
        }
       
    }
         

    // Update is called once per frame
    void Update()
    {
        
    }
}
