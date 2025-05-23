using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;

    void Start()
    {
        CreateTank();
    }

    void CreateTank()
    {
        TankModel tankModel = new TankModel(30,100);
        TankController tankController = new TankController(tankModel, tankView);
    }
}