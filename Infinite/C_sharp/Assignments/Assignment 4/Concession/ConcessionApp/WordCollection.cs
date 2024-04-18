using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class WordCollection
{
    public List<string> filteredWords(List<string> words) { 
        return words
            .Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase) && word.EndsWith("m", StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}