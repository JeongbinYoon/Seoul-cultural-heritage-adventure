using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeFire : MonoBehaviourPun {
public Transform spPoint; // SpawnPoint 
public Transform spPoint2; // SpawnPoint 
public Transform bullet; // Bullet 프리팹 
 float moveSpeed = 10f; // 이동 속도
 float rotSpeed = 60f; // 회전 속도 (초속 60˚)
 // 게임 초기화
 void Start () { 
 }
 // 게임 루프
 void Update () {
    // 현재 프레임에서 이동할 거리와 각도
    float amount = moveSpeed * Time.deltaTime;
    float amountRot = rotSpeed * Time.deltaTime;
    // 키 입력
    float vert = Input.GetAxis("Vertical");
    float horz = Input.GetAxis("Horizontal");

    transform.Translate(Vector3.forward * amount * vert);
    transform.Rotate(Vector3.up * amountRot * horz);

    // 단발 사격
    if (Input.GetButtonDown("Fire1")) { 
        SingleShut();
    } else if (Input.GetButton("Fire2")) { 
        AutoFire();
    }
}
    // 단발 사격
    void SingleShut () {
    Instantiate(bullet, spPoint.position, spPoint.rotation); 
    Instantiate(bullet, spPoint2.position, spPoint2.rotation); 
    }

    // 연발 사격
    void AutoFire () {
    Instantiate(bullet, spPoint.position, spPoint.rotation); 
    Instantiate(bullet, spPoint2.position, spPoint2.rotation); 
    }
}
