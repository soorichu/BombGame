using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermySpawner : MonoBehaviour
{
    public GameObject EnermyPrefab;
    private int count = 30;
    private GameObject[] Enermys;
    void Start()
    {
        Enermys = new GameObject[count];
        for (int i=0; i<count; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-30, 30), 0.5f, Random.Range(-30, 30));
            Enermys[i] = Instantiate(EnermyPrefab, pos, Quaternion.identity);
        }
    }

}
