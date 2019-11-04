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
    }
}
