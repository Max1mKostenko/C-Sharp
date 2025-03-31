using System.Collections.ObjectModel;

class CountryCities
{
    private Dictionary<string, ObservableCollection<string>> countries = new();

    public void AddCountry(string country)
    {
        if (!countries.ContainsKey(country))
        {
            countries[country] = new ObservableCollection<string>();
            Console.WriteLine($"Country '{country}' added.");
        }
        else
        {
            Console.WriteLine($"Country '{country}' already exists.");
        }
    }

    public void AddCity(string country, string city)
    {
        if (countries.ContainsKey(country))
        {
            var cities = countries[country];
            if (!cities.Contains(city))
            {
                cities.Add(city);
                Console.WriteLine($"City '{city}' added to {country}.");
            }
            else
            {
                Console.WriteLine($"City '{city}' already exists in {country}.");
            }
        }
        else
        {
            Console.WriteLine($"Country '{country}' not found.");
        }
    }

    public void RemoveCity(string country, string city)
    {
        if (countries.ContainsKey(country))
        {
            var cities = countries[country];
            if (cities.Remove(city))
            {
                Console.WriteLine($"City '{city}' removed from {country}.");
            }
            else
            {
                Console.WriteLine($"City '{city}' not found in {country}.");
            }
        }
        else
        {
            Console.WriteLine($"Country '{country}' not found.");
        }
    }

    public void RemoveCountry(string country)
    {
        if (countries.ContainsKey(country))
        {
            countries.Remove(country);
            Console.WriteLine($"Country '{country}' removed.");
        }
        else
        {
            Console.WriteLine($"Country '{country}' not found.");
        }
    }

    public void ReplaceCity(string country, string oldCity, string newCity)
    {
        if (countries.ContainsKey(country))
        {
            var cities = countries[country];
            int index = cities.IndexOf(oldCity);
            if (index != -1)
            {
                cities[index] = newCity;
                Console.WriteLine($"City '{oldCity}' replaced with '{newCity}' in {country}.");
            }
            else
            {
                Console.WriteLine($"City '{oldCity}' not found in {country}.");
            }
        }
        else
        {
            Console.WriteLine($"Country '{country}' not found.");
        }
    }

    public int CountCities(string country)
    {
        return countries.ContainsKey(country) ? countries[country].Count : 0;
    }

    public void ShowCountries()
    {
        Console.WriteLine("Countries:");
        foreach (var country in countries.Keys)
        {
            Console.WriteLine(country);
        }
    }

    public void ShowCities(string country)
    {
        if (countries.ContainsKey(country))
        {
            var cities = countries[country];
            Console.WriteLine($"Cities in {country}: {string.Join(", ", cities)}");
        }
        else
        {
            Console.WriteLine($"Country '{country}' not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        CountryCities manager = new();
        manager.AddCountry("USA");
        manager.AddCity("USA", "New York");
        manager.AddCity("USA", "Los Angeles");
        manager.ShowCities("USA");
        manager.ReplaceCity("USA", "Los Angeles", "San Francisco");
        manager.ShowCities("USA");
        manager.RemoveCity("USA", "New York");
        manager.ShowCities("USA");
        manager.ShowCountries();
    }
}
