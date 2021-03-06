﻿using UnityEngine;
using System.Collections;

public class LaneSpawner : MonoBehaviour {

    public GameObject[] lanePrefabs;
    public int maxOffset = 50000;

    // Use this for initialization
    void Start () {
        int offset = 0;
        while (offset < maxOffset)
        {
            CreateRandomLane(offset);
            offset += 1000;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void CreateRandomLane(float offset)
    {
        int laneIndex = Random.Range(0, lanePrefabs.Length);
        var lane = Instantiate(lanePrefabs[laneIndex]);

        Debug.Log(lane.name);
        lane.transform.parent = transform;
        lane.transform.Translate(0, 0, offset);
        
    }

    
}
