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

    public void CreateTank(TankTypes tankTypes)
    {
        if (tankTypes == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(TankList[0].movementSpeed, TankList[0].rotationSpeed, TankList[0].tankType, TankList[0].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if (tankTypes == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(TankList[1].movementSpeed, TankList[1].rotationSpeed, TankList[1].tankType, TankList[1].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if (tankTypes == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(TankList[2].movementSpeed, TankList[2].rotationSpeed, TankList[2].tankType, TankList[2].color);
            TankController tankController = new TankController(tankModel, tankView);
        }

        
    }
}