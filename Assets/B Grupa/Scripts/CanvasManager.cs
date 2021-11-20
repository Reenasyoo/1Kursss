using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private InputField nameInput;
    [SerializeField] private Text outputNameText;
    [SerializeField] private Text outputHealthText;
    [SerializeField] private Text enemyNameText;
    [SerializeField] private Text enemyHealthText;

    private string playerName;
    private string enemyName = "Orc";
    private int playerHealth = 10;
    private int enemyHealth = 10;
    private int maxHealth = 10;
    private int maxAttackDamage = 3;
    private int maxHeal = 4;

    private void Start()
    {
        DispalyOutputName(enemyNameText, enemyName);
        DispalyOutputName(outputHealthText, playerHealth.ToString());
        DispalyOutputName(enemyHealthText, enemyHealth.ToString());
    }

    public void PlayerAttack() 
    {
        int playerAttackDamage = Random.Range(0, maxAttackDamage+1);
        print("player Attack " + playerAttackDamage);

        if((enemyHealth - maxAttackDamage) < 0)
        {
            enemyHealth = 0;
            DispalyOutputName(enemyNameText, enemyName + " diededed");
        }
        else if(enemyHealth > 0)
        {
            enemyHealth -= maxAttackDamage;
        }
        
        DispalyOutputName(enemyHealthText, enemyHealth.ToString());

        EnemyAttack();
    }

    public void Heal()
    {
        int currentHeal = Random.Range(0, maxHeal +1);
        print($"Current heal amount : {currentHeal} ");


        if((playerHealth + currentHeal) > maxHealth)
        {
            playerHealth = maxHealth;
        }
        else if(playerHealth < maxHealth)
        {
            playerHealth += currentHeal;
        }
        EnemyAttack();
        DispalyOutputName(outputHealthText, playerHealth.ToString());
    }

    private void EnemyAttack()
    {
        int enemyAttackDamage = Random.Range(0, maxAttackDamage+1);
        print("Enemy attack " + enemyAttackDamage);

        if ( (playerHealth - enemyAttackDamage) < 0)
        {
            playerHealth = 0;
            DispalyOutputName(outputNameText, playerName + "diededed");
        }
        else if (playerHealth > 0)
        {
            playerHealth -= enemyAttackDamage;
        }
        DispalyOutputName(outputHealthText, playerHealth.ToString());
    }


    // Gets and saves player's input name
    public void SaveName()
    {
        playerName = nameInput.text;
        DispalyOutputName(outputNameText, playerName);
    }

    private void DispalyOutputName(Text textComp, string tempText)
    {
        textComp.text = tempText;
    }

    public void AddHealth()
    {
        if(playerHealth < maxHealth)
        {
            playerHealth++;
        }

        DispalyOutputName(outputHealthText, playerHealth.ToString());
    }

    public void RemoveHealth()
    {
        if(playerHealth > 0)
        {
            playerHealth--;
        }
            
        DispalyOutputName(outputHealthText, playerHealth.ToString());
    }
}
