using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulOnCollisionEnter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // 衝突、進入判定の参考： https://www.sejuku.net/blog/83742

    // 衝突時
    private void OnCollisionEnter(Collision collision)
    {
      Debug.Log("HIT!!");
      var r = Random.Range(0f, 1f);
      var g = Random.Range(0f, 1f);
      var b = Random.Range(0f, 1f);
      GetComponent<Renderer>().material.color = new Color(r, g, b);
    }

    // 進入時
    // isTriger にチェックが入れられているオブジェクト
    private void OnTriggerEnter(Collider other)
    {
      Debug.Log("HIT!!");
      var r = Random.Range(0f, 1f);
      var g = Random.Range(0f, 1f);
      var b = Random.Range(0f, 1f);
      GetComponent<Renderer>().material.color = new Color(r, g, b);
    }
}
