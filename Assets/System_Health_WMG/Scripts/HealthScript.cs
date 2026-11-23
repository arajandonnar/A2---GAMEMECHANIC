using System.Collections.Generic;
using UnityEngine;

namespace Healthsystem.components
{


    public class HealthScript : MonoBehaviour
    {

        [SerializeField] float health;
        [SerializeField] float minHealth;
        [SerializeField] float maxHealth;
        float maxHPUp;
        float healthRegen;
        float healthRegenLength;
        float damage;

        private void Update()
        {
            Mathf.Clamp(health, minHealth, maxHealth);
        }
        //this damages you
        public void Damage()
        {
            health -= damage;
        }

        
        //this heals you
        public void HealOverTime()
        {
            for(float i = 0; i < healthRegenLength; i++)
            {
                health =+ healthRegen;
            }
        }
        public void HealOnDamagedByEnemy()
        {
            float heal = damage * -1;
            health -= heal;
        }

        //this increases max health

        public void MaxHealthUp()
        {
            maxHealth += maxHPUp;
        }





    }
}