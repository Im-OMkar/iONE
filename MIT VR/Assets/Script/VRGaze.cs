using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    bool gvrstat;
    float gvrtimer;
    public GameObject player;
    public float timer;

   
    void Start()
    {
      
    }
    void Update()
    {
        if (gvrstat)
        {
            gvrtimer += Time.deltaTime;
            timer = gvrtimer;
        }
        if (gvrtimer >=2 && gvrstat == true)
        {
            gvrtimer = 0;
            gvrstat = false;
            player.transform.position = new Vector3(transform.position.x + 10, transform.position.y, transform.position.z);
            
        }
    }
    public void GVRon() {
        gvrstat = true;
    }
    public void GVRoff() {
        gvrstat = false;
        gvrtimer = 0;
    }

}
