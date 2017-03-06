using UnityEngine;
using System.Collections;

public class TreeSpawner : MonoBehaviour {


    public GameObject treePrefab;
    public int minTrees = 1;
    public int maxTrees = 6;
    // Use this for initialization
    void Start () {
        CreateTrees();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void CreateTrees()
    {
        var numberOfTrees = Random.Range(minTrees, maxTrees);
        for (int i = 0; i <= numberOfTrees; i++)
        {
            var tree = Instantiate(treePrefab);
            tree.transform.parent = transform;
            tree.transform.localPosition= new Vector3(Random.Range(-50, 50), 0, Random.Range(-5, 5));
        }
        
    }


}
