using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

    private Transform camera;
    private Transform player;
    GameObject ball;
    private Vector3 offset;
    public void Awake() {
    camera = GetComponent<Transform>();
    ball = GameObject.Find("Ball");
    player = ball.GetComponent<Transform>();
    offset = camera.position;
    }
	
    public void Update()
    {
        camera.position = player.position;
        camera.position = player.position + offset;

    }
	
}
