using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawn : MonoBehaviour
{
    public GameObject Bomb;      // Apple Object in Scene (Sprite

    //public GameObject badApple;      // Bad Apple Object in Scene (Sprite)
    public float spawnTime = 13f;            // How long between each spawn.
    public float fallSpeed = 2f;    //The speed of falling Apples
    private float timer = 0; //counting timer, reset after calling SpawnRandom() function
    private int randomNumber;       //variable for storage of an random Number

    void Update()
    {
        timer += Time.deltaTime;   // Timer Counter
        if (timer > spawnTime)
        {
            SpawnRandom();       //Calling method SpawnRandom()
            timer = 0;        //Reseting timer to 0

        }
    }
    public void SpawnRandom()
    {

        //Creating random Vector3 position
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(600, Screen.height), Camera.main.farClipPlane / 2));
        //Instantiation of the Apple Object
        GameObject bclone = Instantiate(Bomb, screenPosition, Quaternion.identity);



        Object.Destroy(bclone, 6f);


    }
}