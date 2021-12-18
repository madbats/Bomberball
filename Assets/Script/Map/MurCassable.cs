using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurCassable : Mur
{
    public GameObject sol;
    // Start is called before the first frame update
    void Start()
    {
        this.isBreakable = true;
    }
    
    public void OnDestroy()
    {
    }
    
    public void OnBreak(){
        GameObject qqc;
        Debug.Log("OnBreak called :"+transform.position);
        qqc=Instantiate(sol, gameObject.transform.position, Quaternion.identity);
        qqc.transform.SetParent(transform.parent,false);
        qqc.transform.parent.GetComponent<Map>().mapItemsList[(int)transform.position.x, (int)transform.position.y] = qqc.GetComponent<MapItem>();
        Destroy(this.gameObject);
    }
}
