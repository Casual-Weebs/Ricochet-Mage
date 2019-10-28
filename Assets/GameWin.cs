using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public GameObject ricochetWin;
    public GameObject ricochetLose;
    public float mana;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
        {
            ricochetWin.SetActive(true);
        }

        if (GameObject.FindGameObjectsWithTag("Enemy").Length > 0 || mana <= 0)
        {
            ricochetLose.SetActive(true);
        }
    }
}
