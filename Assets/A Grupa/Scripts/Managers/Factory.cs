using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public List<Transform> spawnLocations = new List<Transform>();

    public GameObject enemyPrefab;
    public GameObject playerObj;
        
    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            spawnLocations.Add(transform.GetChild(i).transform);
        }
        
        SpawnEnemy();
        
        // IDefenceRobot defRob = new DefenceRobot("Deflecter");
        // IDefenceRobot bigDef = new BigDefenceRobot("Big Def");
        // defRob.Deflect();
        // bigDef.Deflect();
    }

    private void SpawnEnemy()
    {
        int randomLocation = Random.Range(0, spawnLocations.Count);
        GameObject temp = Instantiate(enemyPrefab, spawnLocations[randomLocation].position, Quaternion.identity);
        temp.GetComponent<RobotMono>().SetTarget(playerObj);
    }


    public void CreateAttackers()
    {
        Rifle rifle = new Rifle();
        rifle.SetName("AR Cool");
        rifle.PrintName();

        Rifle akRifle = new Rifle();
        akRifle.SetName("AK");
        akRifle.SetAttackStrength(20);

        
        AttackRobot attRob = new AttackRobot("Attacker", rifle);
        BigAttackRobot bigRob = new BigAttackRobot("Big Rob", akRifle);

        attRob.Attack();
        bigRob.Attack();
    }
}
