using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class SpawnMangager : MonoBehaviour {
    //basket movement
    
    public List<GameObject> funnels;
    public GameObject bread;

    

    void Start() {
        
        Instantiate(bread, funnels[2].transform.position, Quaternion.identity);
    }

    private void Update() {
        
    }
}
