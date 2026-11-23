using System.Collections.Generic;
using UnityEngine;

namespace Healthsystem.components
{


    public class HealthScript : MonoBehaviour
    {
        

        float health;
        float maxHealth;
        float healthRegen;

        float damage;



        public void Damage()
        {
            health -= damage;
        }

        

        public void Heal()
        {
            float heal = damage * -1;
            health -= heal;
        }







    }
}