using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAction : MonoBehaviour
{
    public float width = 10f;
    public float height = 5f;
    public float min = 5f;
    public float max = 10f;
    public GameObject pianotile;
    public float delay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        waitSpawner();
    }
    private void OnDrawGizmos() {
        Gizmos.DrawWireCube(transform.position,new Vector3(width,height,0));
    }

    // Update is called once per frame
    void Update()
    {
        if(isChildEmpty()){
            waitSpawner();
        }
    }
    void waitSpawner(){
        Transform position = freeposition();
        float rand = Random.Range(min,max);
        Vector3 offset = new Vector3(0,rand,0);
        if(position){
            GameObject piano = Instantiate(pianotile,position.transform.position+offset,Quaternion.identity);
            piano.transform.parent = position;
            Invoke("waitSpawner",delay);

        }
        if(freeposition()){
        }
   }
    void spawner(){
        foreach(Transform child in transform){
            GameObject piano = Instantiate(pianotile,child.position,Quaternion.identity);
            piano.transform.parent = child;
        }
    }
    bool isChildEmpty(){
        foreach(Transform child in transform){
            if(child.childCount>0){
                return false;
            }
        }
        return true;
    }
    Transform freeposition(){
        foreach(Transform child in transform){
            if(child.childCount==0){
                return child;
            }
        }
        return null;
    }
}
