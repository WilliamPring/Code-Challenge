--------------------Case swapping--------------------------------

//Test Case
Kata.Swap("") == ""
Kata.Swap("CodeWars") == "cODEwARS"
Kata.Swap("abc") == "ABC"
Kata.Swap("ABC") == "abc"
Kata.Swap("123235") == "123235"
//Test Case

public static class Kata {
  public static string Swap(string name) {
  string newString ="";
    for (int i =0; i < name.Length; i++)
            {
                if((name[i] <=90) && (name[i] >= 65))
                {
                    newString += name[i].ToString().ToLower();
                }
                else if ((name[i] >= 97) && (name[i] <= 122))
                {
                    newString += name[i].ToString().ToUpper();
                }
                else
                {
                    newString += name[i]; 
                } 
            }
     
     
     
    return newString; //your code here
  }
}

--------------------Credit Card Mask--------------------------------
//Test Case
Kata.Maskify('4556364607935616'); // should return "############5616"
Kata.Maskify('64607935616');      // should return "#######5616"
Kata.Maskify('1');                // should return "1"
Kata.Maskify('');                 // should return ""

// "What was the name of your first pet?"
Kata.Maskify('Skippy');                                   // should return "##ippy"
Kata.Maskify('Nananananananananananananananana Batman!'); // should return "####################################man!"
//test Case

public static class Kata
{
  // return masked string
  public static char[] Maskify(string cc)
  {
    char[] totalScreen = cc.ToCharArray();
  
    if(cc.Length > 4)
    {
      int lengthOfString =0;
      lengthOfString = cc.Length;      
      for (int i =0; i < lengthOfString - 4; i++)
      {
        totalScreen[i] = '#';
      }
    }
    return totalScreen;
  }
}

