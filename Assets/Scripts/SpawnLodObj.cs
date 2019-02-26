using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLodObj : MonoBehaviour {
    public Transform prefab;

    [Range(10, 1000)]
    public int numToSpawn;

    [Range(1, 500)]
    public float distanceScale;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < numToSpawn; i++)
        {
            var obj = Instantiate(prefab);
            obj.parent = transform;
            obj.localPosition = Random.onUnitSphere * (distanceScale * Random.value);
            obj.rotation = Random.rotationUniform;
        }
	}
	
}
