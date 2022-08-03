using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update\

    private GameObject Player;

    void Start()
    {
        this.Player = GameObject.Find("Player");
        Debug.Log(this.Player);
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = new Vector3(
        this.Player.transform.position.x,
        this.Player.transform.position.y + 5f,
        this.Player.transform.position.z - 10f
      );
    }
}
