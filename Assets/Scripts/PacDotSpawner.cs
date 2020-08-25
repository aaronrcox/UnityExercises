using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PacDotSpawner : MonoBehaviour
{
    public GameObject pacDotPrefab;

    // Start is called before the first frame update
    void Start()
    {
       var bc = GetComponent<BoxCollider>();
        for(var z = bc.bounds.min.z+0.5f; z<bc.bounds.max.z; z++)
        {
            for (var x = bc.bounds.min.x+0.5f; x < bc.bounds.max.x; x++)
            {
                var pd = GameObject.Instantiate(pacDotPrefab);
                pd.transform.position = new Vector3(x, 0.5f, z);
                pd.transform.SetParent(this.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
