using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    public GameObject cratePrefab;

    public int amountofCratesToSpawn;

    private void Start()
    {
        for(int i = 0; i <amountofCratesToSpawn; i++)
        {
            Instantiate(cratePrefab, transform.localPosition, Quaternion.identity, this.transform);
        }
    }





}
