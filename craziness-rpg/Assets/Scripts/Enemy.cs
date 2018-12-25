using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    public string EnemyType;
    public int EnemyHealth;
    bool BattleMode; 


    // Start is called before the first frame update
    void Awake()
    {
        BattleMode = GameObject.Find("BattleManager").GetComponent<BattleManager>().BattleMode;
    }
    void Start()
    {
        if (BattleMode == true)
        {
            Debug.Log("Battle starts!");
        }
    }

    public void OnBattleStarts ()
    {
           
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
