using UnityEngine;
using UnityEngine.PlayerLoop;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotation;

    public Rigidbody rb;
    public MeshRenderer[] childs;

    void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");
        camera.transform.SetParent(transform);
        camera.transform.position = new Vector3(0f, 3f, -4f);
    }

    void Update()
    {
        Movement();

        if (movement != 0)
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);

        if (rotation != 0)
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public void ChangColor(Material color)
    {
        foreach (MeshRenderer child in childs)
        {
            child.material = color;
        }
    }

    public Rigidbody GetRigidbody() { return rb; }
}
