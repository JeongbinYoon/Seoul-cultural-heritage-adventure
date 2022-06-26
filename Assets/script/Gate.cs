using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public Transform gate1; 
    float pos = 1f;
    AudioSource gateSound;

    // Start is called before the first frame update
    void Start()
    {
        gateSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            Debug.Log("hi");
            while(pos > 0.45f){
              open();
            }
        }
    }

    void open(){
        pos = pos - 0.5f * Time.deltaTime;
        gate1.localScale = new Vector3(1f, pos, 1f);
        gateSound.Play();
    }
}
