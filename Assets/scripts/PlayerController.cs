using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed=0;
    [SerializeField] private float angleSpeed=0;

    void Update()
    {
        float angle = 0;
        if (Input.GetKey(KeyCode.D))
            transform.GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * speed, ForceMode.Impulse);
        if (Input.GetKey(KeyCode.A))
            transform.GetComponent<Rigidbody>().AddForce(-transform.forward * Time.deltaTime * speed, ForceMode.Impulse);
        if (Input.GetKey(KeyCode.Space))
            transform.GetComponent<Rigidbody>().AddForce(Vector3.up * Time.deltaTime * speed, ForceMode.Impulse);
        if (Input.GetKey(KeyCode.S))
            angle++;
        if (Input.GetKey(KeyCode.W))
            angle--;
        transform.Rotate(Vector3.up*angle* angleSpeed * Time.deltaTime);
    }
}
