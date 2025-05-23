using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    public TankView() {}

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
