using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public Slider HealthSider;
    public float Health;
    float maxHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthSider.value = Health;

        Health -= 1f * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            Health -= 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Health -= 5f * Time.deltaTime;
        }
    }
}
