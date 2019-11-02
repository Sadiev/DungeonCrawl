using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Combat
    {
        public static void Battle(Player player, Mob enemy)
        {
            Dice attack = new Dice(1, 20);
            Dice playerDamage = new Dice(player.Damage);
            Dice enemyDamage = new Dice(enemy.Damage);
            int attackRoll;
            int damageAmount;

            while (enemy.Dead != true && player.Dead != true)
            {
                attackRoll = attack.Roll();

                if(attackRoll >= enemy.AC)
                {
                    damageAmount = playerDamage.Roll();
                    enemy.HP -= damageAmount;

                    if(enemy.HP <= 0)
                    {
                        Console.WriteLine("Enemy is dead!");
                        enemy.Dead = true;
                    }
                }
                else
                {
                    Console.WriteLine("Your attack missed");
                }

                attackRoll = attack.Roll();

                if(attackRoll >= player.AC)
                {
                    damageAmount = enemyDamage.Roll();
                    player.HP -= damageAmount;

                    if(player.HP <= 0)
                    {
                        Console.WriteLine("You are dead!");
                        player.Dead = true;
                    }
                }
                else
                {
                    Console.WriteLine("The enemies attack missed");
                }
            }
        }
    }
}
