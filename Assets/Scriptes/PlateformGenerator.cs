﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformGenerator : MonoBehaviour
{
    public List<GameObject> prefabList;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefabList[0], new Vector3(0,0,0),Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
