using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;

// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field
//FlavorComparer comparer = new FlavorComparer();



Console.WriteLine("CHOOSE FROM THE MENU BELOW: ");
Console.WriteLine("*************");
   

foreach (Flavor flavor in availableFlavors)
{
    Console.WriteLine(flavor.Name);
    
}

// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.

availableFlavors.Sort(new FlavorComparer());
Console.WriteLine("*****THIS IS A DIVIDER*****");

foreach (Flavor flav in availableFlavors)
{
    Console.WriteLine($"{flav.Name} Allergens: {flav.Allergens.Count}");
}

foreach (Cone con in availableCones)
{
    Console.WriteLine($"{con.Name} : ${con.Cost}");
}

// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.

availableCones.Sort(new ConeComparer ());
Console.WriteLine("*****THIS IS A DIVIDER*****");

foreach (Cone con in availableCones)
{
    Console.WriteLine($"{con.Name} : ${con.Cost}");
}

