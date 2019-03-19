using UnityEngine;

public class Shop : MonoBehaviour {

    public ShopBlueprint standartTurret;
    public ShopBlueprint missileLauncher;
    public ShopBlueprint laserturret;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandartTurret()
    {
        Debug.Log("Standart Turret Purchased");
        buildManager.SelectTurretToBuild(standartTurret);
    }
    public void SelectMissileLauncher()
    {
        Debug.Log("Missile Launcher Purchased");
        buildManager.SelectTurretToBuild(missileLauncher);
    }
    public void SelectLaserTurret()
    {
        Debug.Log("Laser Turret Purchased");
        buildManager.SelectTurretToBuild(laserturret);
    }

}
