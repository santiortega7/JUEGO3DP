using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidadP = 3.0f;
    public float rotateP = 50.0f;
    private Animator miAnim;
    public float px, py;

    // Start is called before the first frame update
    void Start()
    {
        miAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        px = Input.GetAxis("Horizontal");

        py = Input.GetAxis("Vertical");

        transform.Translate(0, 0, py * Time.deltaTime * velocidadP);
        transform.Rotate(0, px * Time.deltaTime * rotateP, 0);

       miAnim.SetFloat("velX", px);
        miAnim.SetFloat("velY", py);
    }
    
}
