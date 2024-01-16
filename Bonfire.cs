using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bonfire : MonoBehaviour
{
    public float lifeTime;
    public float temUp = 0.2f;
    // Update is called once per frame
    void Update()
    {
        lifeTime -= 1 * Time.deltaTime;
        if (lifeTime <= 0 )
        {
            Destroy (gameObject);
        }
    }
    private void OmTriggerStay(Collider other)
    {
        if (other.GetComponent<Temperature>() != null)
        {
            other.GetComponent<Temperature>().TemperatureUp(tempUp);
        }
    }
}
