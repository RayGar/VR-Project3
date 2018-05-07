using UnityEngine;

public class Ball : MonoBehaviour {

    public float force;
    private Rigidbody _rigidbody;
    private bool _isGrounded;
    public float rotationSpeed = 5.0f;

    // Use this for initialization
    void Start () {
        _rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!_isGrounded) return;
        var vectorForce = Input.GetAxis("Vertical") * Vector3.forward;
        vectorForce += Input.GetAxis("Horizontal") * Vector3.right;

        // Enable camera rotation
        /*if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(rotationSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(-rotationSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -rotationSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
        }*/

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 180);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 90);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, -90);
        }

        _rigidbody.AddForce(vectorForce * force);
	}

    void OnTriggerEnter (Collider other)
    {
        _isGrounded = true;
    }

    void OnTriggerExit (Collider other)
    {
        _isGrounded = false;
    }
}