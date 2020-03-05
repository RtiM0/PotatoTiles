using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionscript : MonoBehaviour
{
    public float width = 10f;
    public float height = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnDrawGizmos() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position,new Vector3(width,height,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
