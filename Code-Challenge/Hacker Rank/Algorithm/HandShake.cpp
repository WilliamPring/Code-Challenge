//https://www.hackerrank.com/challenges/handshake/copy-from/16064659
//At the annual meeting of Board of Directors of Acme Inc, every one starts shaking hands with everyone else 
//in the room. Given the fact that any two persons shake hand exactly once, Can you tell the total count of 
//handshakes?


#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    int theAmountOfPeople =0;
    int amountOfTime =0;
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */  
    cin >> amountOfTime;
    for (int i =0; i < amountOfTime; i++)
        {
            cin >> theAmountOfPeople;
           int total = ((theAmountOfPeople - 1) * theAmountOfPeople / 2);
           cout << total << "\n";
        }

    
    return 0;
}
