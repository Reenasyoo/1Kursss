using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Factory : MonoBehaviour
{
    public List<Transform> spawnLocations = new List<Transform>();

    public GameObject enemyPrefab;
    public GameObject playerObj;
    public Text counterText;

    public int counter = 0;
        
    private void Start()
    {
        counter = 0;
        UpdateCounterText();
        
        for (int i = 0; i < transform.childCount; i++)
        {
            spawnLocations.Add(transform.GetChild(i).transform);
        }

        StartCoroutine(Spawn());

        // IDefenceRobot defRob = new DefenceRobot("Deflecter");
        // IDefenceRobot bigDef = new BigDefenceRobot("Big Def");
        // defRob.Deflect();
        // bigDef.Deflect();
    }

    private void SpawnEnemy()
    {
        int randomLocation = Random.Range(0, spawnLocations.Count);
        GameObject temp = Instantiate(enemyPrefab, spawnLocations[randomLocation].position, Quaternion.identity);
        RobotMono script = temp.GetComponent<RobotMono>();
        script.SetTarget(playerObj);
        script.SetFactoryReference(this);
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

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            SpawnEnemy();
        }
    }

    public void UpdateCounter()
    {
        counter++;
        UpdateCounterText();
    }

    private void UpdateCounterText()
    {
        counterText.text = $"Counter : {counter}";
    }
}
