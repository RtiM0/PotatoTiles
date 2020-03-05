using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAction : MonoBehaviour
{
    public float width = 10f;
    public float height = 5f;
    public GameObject pianotile;
    public static float delay = 1f;
    private Transform childer;
    // Start is called before the first frame update
    void Start()
    {
        spawner();
    }
    private void OnDrawGizmos() {
        Gizmos.DrawWireCube(transform.position,new Vector3(width,height,0));
    }

    // Update is called once per frame
    void Update()
    {

    }
    void waitSpawner(){
        Transform position = freeposition();
        if(position){
            GameObject piano = Instantiate(pianotile,position.transform.position,Quaternion.identity);
            piano.transform.parent = position;
            Invoke("waitSpawner",delay);
        }
   }
    public void spawner(){
        // foreach(Transform child in transform){
        //     GameObject piano = Instantiate(pianotile,child.position,Quaternion.identity);
        //     piano.transform.parent = child;
        // }
        childer = transform.GetChild(Random.Range(0,3));
        GameObject piano = Instantiate(pianotile,childer.position,Quaternion.identity);
        piano.transform.parent = childer;
        float del = SpawnerAction.delay;
        Debug.Log("delay is "+del);
        Invoke("spawner",del);
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