Ingredients[] ingredients = new Ingredients[] { Ingredients.Stardust, Ingredients.EyeshineGem }; // NIGHT SIGHT
//Ingredients[] ingredients = new Ingredients[] { Ingredients.Stardust, Ingredients.ShadowGlass, Ingredients.EyeshineGem }; // CLOUDY BREW
//Ingredients[] ingredients = new Ingredients[] { Ingredients.Stardust, Ingredients.DragonBreath }; // FLYING
//Ingredients[] ingredients = new Ingredients[] { Ingredients.Stardust, Ingredients.DragonBreath, Ingredients.Stardust }; // RUINED

PotionType potionType = ingredients switch
{
    [] => PotionType.Water,
    [Ingredients.Stardust] => PotionType.Elixir,
    [Ingredients.Stardust, Ingredients.SnakeVenom]   => PotionType.Poison,
    [Ingredients.Stardust, Ingredients.DragonBreath] => PotionType.Flying,
    [Ingredients.Stardust, Ingredients.ShadowGlass]  => PotionType.Invisibility,
    [Ingredients.Stardust, Ingredients.EyeshineGem]  => PotionType.NightSight,
    [Ingredients.Stardust, Ingredients.EyeshineGem, Ingredients.ShadowGlass] => PotionType.CloudyBrew,
    [Ingredients.Stardust, Ingredients.ShadowGlass, Ingredients.EyeshineGem] => PotionType.CloudyBrew,
    [Ingredients.Stardust, Ingredients.EyeshineGem, Ingredients.ShadowGlass, Ingredients.Stardust] => PotionType.Wraith,
    [Ingredients.Stardust, Ingredients.ShadowGlass, Ingredients.EyeshineGem, Ingredients.Stardust] => PotionType.Wraith,
    _ => PotionType.Ruined
};

Console.WriteLine($"Result: { potionType }");

public enum Ingredients { Stardust, SnakeVenom, DragonBreath, ShadowGlass, EyeshineGem }
public enum PotionType { Water, Elixir, Poison, Flying, Invisibility, NightSight, CloudyBrew, Wraith, Ruined }