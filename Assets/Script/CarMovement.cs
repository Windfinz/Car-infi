using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float Speed;
    void Update()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + Speed * Time.deltaTime);
        transform.position = newPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Wall"))
        {
            Speed = 0;
        }
    }

}
