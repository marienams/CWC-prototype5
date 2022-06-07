﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnRate()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
}
