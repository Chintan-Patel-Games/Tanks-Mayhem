using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }

    public List<Tank> TankList;

    public TankView tankView;

    void Start()
    {
        CreateTank();
    }

    void CreateTank()
    {
        TankModel tankModel = new TankModel(TankList[0].movementSpeed, TankList[0].rotationSpeed, TankList[0].tankType, TankList[0].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}