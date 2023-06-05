using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Library
{
    public abstract class Hero
    {
        public abstract void ShowInventory();
    }

    public class Warrior : Hero
    {
        public override void ShowInventory()
        {
            Console.WriteLine("Warrior inventory:");
        }
    }
    public class Mage : Hero
    {
        public override void ShowInventory()
        {
            Console.WriteLine("Mage inventory:");
        }
    }

    public class Paladin : Hero
    {
        public override void ShowInventory()
        {
            Console.WriteLine("Paladin inventory:");
        }
    }

    public abstract class InventoryDecorator : Hero
    {
        protected Hero hero;
        public InventoryDecorator(Hero hero)
        {
            this.hero = hero;
        }

        public override void ShowInventory()
        {
            hero.ShowInventory();
        }
    }

    public class WeaponInventoryDecorator : InventoryDecorator
    {
        public WeaponInventoryDecorator(Hero hero) : base(hero) { }

        public override void ShowInventory()
        {
            base.ShowInventory();
            Console.WriteLine("- Weapon");
        }
    }

    public class ClothingInventoryDecorator : InventoryDecorator
    {
        public ClothingInventoryDecorator(Hero hero) : base(hero) { }

        public override void ShowInventory()
        {
            base.ShowInventory();
            Console.WriteLine("- Clothing");
        }
    }

    public class ArtifactInventoryDecorator : InventoryDecorator
    {
        public ArtifactInventoryDecorator(Hero hero) : base(hero) { }

        public override void ShowInventory()
        {
            base.ShowInventory();
            Console.WriteLine("- Artifact");
        }
    }

}
