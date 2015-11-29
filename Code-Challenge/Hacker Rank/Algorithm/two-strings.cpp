#include <cmath>
#include <cstdio>
#include <vector>
#include <string>
#include <iostream>

#include <algorithm>
using namespace std;

int main()
{
    int count;
    cin >> count;

    while(count > 0)
        {
        bool status = true;
            string stringInput ="";
            string stringInput1 = "";
             cin >> stringInput;
                cin >> stringInput1;
    for (int i =0; i < stringInput1.length(); i++)
        {
      if (stringInput.find(stringInput1[i]) != std::string::npos)
        {
          status = false;
            printf("YES\n");
                break;
        }
        }
        if (status == true)
            {
                        printf("NO\n");
        }
        else
            {
            status = true;
        }
    count--;
    }

	
}