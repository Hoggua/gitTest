using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] float speed = 100f;

    [SerializeField] GameObject soundObj;
    Transform playerTransfrom;
    Vector2 moveinput;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = (moveinput * speed);

        //if(Input.GetMouseButtonDown(0))
        //{
        //    GameObject inst = Instantiate(soundObj, playerTransfrom.transform.position, playerTransfrom.transform.rotation);
        //}
    }

    public void OnMove(InputValue value)
    {
        moveinput = value.Get<Vector2>();
        Debug.Log("¾Æ");
    }

}
