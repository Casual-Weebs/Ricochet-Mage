using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ricochetWin;
    public GameObject ricochetLose;
    public GameObject ricochetWinButton;
    public GameObject ricochetLoseButton;

    public GameObject shot1;
    public GameObject shot2;
    public GameObject shot3;
    public GameObject shot4;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;


    private float wait = .1f;

    public float mana;
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && mana > 0)
        {
            StartCoroutine(waitShot());
            //Shoot();
        }

        //Enemy HUD
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 3) enemy4.SetActive(false);
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 2) enemy3.SetActive(false);
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 1) enemy2.SetActive(false);
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0) enemy1.SetActive(false);

        //Win
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
        {
            ricochetWin.SetActive(true);

            ricochetWinButton.SetActive(true);
        }
        //Lose
        if (GameObject.FindGameObjectsWithTag("Enemy").Length > 0 && GameObject.FindGameObjectsWithTag("Bullet").Length <= 0 && mana <= 0)
        {
            ricochetLose.SetActive(true);

            ricochetLoseButton.SetActive(true);
        }
        
    }
    
    IEnumerator waitShot()
    {
        yield return new WaitForSeconds(wait);
        Shoot();
    }
    void Shoot()
    {
        //shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        mana--;
        if (mana == 3) shot4.SetActive(false);
        if (mana == 2) shot3.SetActive(false);
        if (mana == 1) shot2.SetActive(false);
        if (mana == 0) shot1.SetActive(false);
    }
}
