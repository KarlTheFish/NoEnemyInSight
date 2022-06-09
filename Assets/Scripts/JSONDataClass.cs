using System;
using System.Collections.Generic;

[Serializable]
public class JSONDataClass
{
    public string weapon;
    public List<weaponList> weapons;
}

[Serializable]
public class weaponList
{
    public string name;
    public double firerate;
}
