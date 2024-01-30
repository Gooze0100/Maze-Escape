using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    [SerializeField][Range(0, 1)] float movementFactor;
    [SerializeField] float period = 2f;
    [SerializeField] float followSpeed = 20f;
    Vector3 playersPosition;
    // Rigidbody rb;

    bool isPlayerTriggered = false;

    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        startingPosition = transform.position;
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.tag == "Player")
    //     {
    //         isPlayerTriggered = true;
    //         Debug.Log("entering trigger player");
    //         playersPosition = other.gameObject.transform.position;
    //         Debug.Log(playersPosition);
    //     }
    // }

    // void OnTriggerExit(Collider other)
    // {
    //     isPlayerTriggered = false;
    //     Debug.Log("Leaving trigger");
    // }

    void Update()
    {
        // if (!isPlayerTriggered)
        // {
        if (period <= Mathf.Epsilon)
        {
            return;
        }

        float cycles = Time.time / period;

        const float tau = Mathf.PI * 2;
        float rawSinWave = Mathf.Sin(cycles * tau);

        movementFactor = (rawSinWave + 1f) / 2f;

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
        // }
        // else
        // {
        //     Debug.Log("entering else");
        //     rb.AddForce(playersPosition * followSpeed);
        // }
    }
}
