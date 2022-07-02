using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternImplementation.Patterns.Creational
{
    // Gun Factory
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    abstract class GunFactory
    {
        public abstract HandGun CreateHandGun();
        public abstract AssaultRifle CreateAssaultRifle();

        public abstract Target CreateTargets();
    }


    /// <summary>
    /// The 'ConcreteFactory1' class 
    /// </summary>
    class GunCachePlayer : GunFactory
    {
        public override AssaultRifle CreateAssaultRifle()
        {
            return new AK47();
        }

        public override HandGun CreateHandGun()
        {
            return new RemingtonMagnum();
        }

        public override Target CreateTargets()
        {
            return new Enemy();
        }

    }

    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class GunCacheEnemy : GunFactory
    {
        public override AssaultRifle CreateAssaultRifle()
        {
            throw new NotImplementedException();
        }

        public override HandGun CreateHandGun()
        {
            throw new NotImplementedException();
        }

        public override Target CreateTargets()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// The 'AbstractProductA' abstract class
    /// </summary>
    abstract class HandGun
    {
        public abstract void Shoot(Target t);
    }

    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    abstract class AssaultRifle
    {
        public abstract void Shoot(Target t);
    }


    abstract class Target
    {

    }

    class RemingtonMagnum : HandGun
    {
        public override void Shoot(Target t)
        {
            // Shoot gun
            Console.WriteLine(this.GetType().Name +
                " Shoots at " + t.GetType().Name);
        }
    }

    class AK47 : AssaultRifle
    {
        public override void Shoot(Target t)
        {
            // Shoot Rifle
            Console.WriteLine(this.GetType().Name +
                " Shoots at " + t.GetType().Name);
        }
    }

   
    class Enemy : Target
    {
    }

   

   

    class TheBattlefield
    {
        private AssaultRifle _assaultRifle;
        private HandGun _handGun;
        private Target _target;
        

        public TheBattlefield(GunFactory factory)
        {
            _assaultRifle = factory.CreateAssaultRifle();
            _handGun = factory.CreateHandGun();
            _target = factory.CreateTargets();
        }

        public void RunBattle()
        {
            _assaultRifle.Shoot(_target);
            _handGun.Shoot(_target);
        }
    }

}
