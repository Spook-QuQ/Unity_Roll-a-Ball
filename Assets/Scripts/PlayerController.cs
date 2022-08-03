using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody rb;

    void Start()
    {
      this.rb = this.GetComponent<Rigidbody>();
      Debug.Log(rb);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

      float size = 100f;
      float forceX = 0.0f;
      float forceY = 0.0f;
      if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
      {
        forceX = -size;
      }
      if (!Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
      {
        forceX = size;
      }
      if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
      {
        forceY = size;
      }
      if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
      {
        forceY = -size;
      }

      if (forceX == 0.0f && forceY == 0.0f) return;

      Vector3 force = new Vector3 (forceX, 0.0f, forceY); // X, Y, Z
      rb.AddForce(force); //力を加える

      // 第二引数に力の加え方を設定できるらしい
      // 参考：https://www.sejuku.net/blog/54896
    }
}
