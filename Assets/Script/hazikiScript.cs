using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazikiScript : MonoBehaviour
{
    [SerializeField] private float Takasa = 100;
    [SerializeField] private float Yoko = 100;
    private Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        Takasa = Random.Range(-1 * Takasa, Takasa);
        Yoko = Random.Range(-1 * Yoko, Yoko);
        RB = GetComponent<Rigidbody2D>();
        RB.AddForce(transform.up * Takasa);
        RB.AddForce(transform.right * Yoko);
        RB.AddTorque(-Yoko);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
