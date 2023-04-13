//using System;

//namespace SOLID
//{

//    public class Player : IAttackable, IShootSkill
//    {
//        public int Health { get; set; }
//        public string Name { get; set; }
//        public float Damage { get; set; }
//        public Skill Skill { get; set; }



//        public void Attack()
//        {
//            // Attack Logic
//            /*  
//             Skill.Activate();
//             */

//        }

//        public void TakeDamage(int damage)
//        {
//            //health-=damage
//        }


//    }


//    public class PlayerMovement : IMoveable
//    {
//        public float Speed { get; set; }
//        public float Direction { get; set; }
//        public float FaceAngle { get; set; }

//        public void Move()
//        {
//            // Move logic
//        }

//        public float TurnFace(float direction)
//        {
//            // FaceAngel logic 
//            return default(float);
//        }
//    }



//    public interface IShootSkill
//    {
//        void ShootSkill();
//        void UpdateCooldown();
//    }


//    public interface IDamagable
//    {
//        void TakeDamage(int damage);
//    }

//    public interface IAttackable
//    {
//        void Attack(int damage);
//    }


//    public interface IDestructable
//    {
//        public bool IsDestructable { get; set; }
//        void TakeDamage(float damage);
//    }
//    public interface IMoveable
//    {
//        public bool CanMove { get; set; }
//        void Move();
//        void TurnFace(float direction);
//    }

//    public interface IStatManipalator
//    {
//        void GetStats();
//        void SetStats(Stat stat);
//    }



//    public class Enemy : IShootSkill, IAttackable
//    {

//    }

//    public class EnemyMovement : IMoveable
//    {

//    }
//}
