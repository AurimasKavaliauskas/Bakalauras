using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class begin_end : MonoBehaviour
{
    public GameObject bottom;
    public GameObject left;
    public GameObject empty_spot;
    public GameObject upper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = empty_spot.transform.position;
        pos.y -= 10;
        pos.x = upper.transform.position.x;
        bottom.transform.position = pos;
    }
}
