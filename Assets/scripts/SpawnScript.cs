using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    //private Transform[] spawnPoints;
    public GameObject[] balloon;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }
    IEnumerator StartSpawning()
    {

        for(int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(Random.Range(0.5f,3f));
            Instantiate(balloon[i], new Vector3 (Random.Range(-2.5f,2.5f),-1.5f,Random.Range(2f,4f)), Quaternion.identity);
        }
        StartCoroutine(StartSpawning());
    }
    // Update is called once per frame

}
