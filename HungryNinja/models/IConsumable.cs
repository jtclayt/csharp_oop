using System;

namespace HungryNinja
{
    interface IConsumable
    {
        string Name {get;}
        int Calories {get;}
        bool IsSpicy {get;}
        bool IsSweet {get;}
        string GetInfo();
    }
}
