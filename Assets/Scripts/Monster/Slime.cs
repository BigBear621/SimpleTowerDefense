using UnityEngine;

class Slime : Monster
{
    public Slime()
    {
        type = MonsterType.Slime;
        name = "Slime";
        hp = 100;
        damage = 10;

        Debug.Log(this.name + " ����");
    }

    public override void Move()
    {
    }
    public override void Die()
    {
        
    }
}