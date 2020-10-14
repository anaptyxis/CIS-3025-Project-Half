using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Creature: IMobile, IActionable
{
    /* Fields */

    private int[] attributes;
    
    /* Properties */

    public int HP { get; set; }
    public int ArmorClass { get; protected set; }
    public bool Darkvision { get; protected set; } 
    public string Resistances { get; protected set; }
    public int Strength
    {
        get
        {
            return attributes[0];
        }

        protected set
        {
            attributes[0] = value;
        }
    }

    public int Dexterity
    {
        get
        {
            return attributes[1];
        }

        protected set
        {
            attributes[1] = value;
        }
    }

    public int Constitution
    {
        get
        {
            return attributes[2];
        }

        protected set
        {
            attributes[2] = value;
        }
    }

    public int Intelligence
    {
        get
        {
            return attributes[3];
        }

        protected set
        {
            attributes[3] = value;
        }
    }

    public int Wisdom
    {
        get
        {
            return attributes[4];
        }

        protected set
        {
            attributes[4] = value;
        }
    }

    public int Charisma
    {
        get
        {
            return attributes[5];
        }

        protected set
        {
            attributes[5] = value;
        }
    }

    /* Constructors */

    public Creature()
    {
        this.attributes = new int[6];
        this.Darkvision = false;
        this.HP = 0;          
        this.Resistances = "";
    }

    /* methods */

    /* It is necessary to override ToString() from the object class
       if we want a custom serialized Creature object as a string.
    */
    public override string ToString()
    {
        string output =
            this.GetType().Name +
            "\n============" +
            "\nSTR: " + this.Strength +
            "\nDEX: " + this.Dexterity +
            "\nCON: " + this.Constitution +
            "\nINT: " + this.Intelligence +
            "\nWIS: " + this.Wisdom +
            "\nCHA: " + this.Charisma +
            "\n============" +
            "\nHP: " + this.HP +
            "\nAC: " + this.ArmorClass +
            "\nResistances: " + this.Resistances +
            "\n============" +
            "\nDarkvision: " + this.Darkvision + "\n";
        return output;
    }

    /* We are required to implement Attack because we implement the
       IActionable interface. However, because Creature is abstract
       and there is no default attack, we will make Attack abstract
       and define specific Attacks in subclasses by overriding. 
    */
    public abstract string Attack(Creature defender);

}
