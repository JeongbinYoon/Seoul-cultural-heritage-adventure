using Photon.Pun;
using UnityEngine;


public class Bullet : MonoBehaviourPun {
    float speed = 30f;
    void Start () {
    }
    void Update () {
        float amount = speed * Time.deltaTime;
        transform.Translate(Vector3.forward * amount);
    } 
}
