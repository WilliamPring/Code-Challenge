#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <stdio.h>
#define MAXLENGTH 20000
#define CHECKMAXLENGTH 200
using namespace std;
 int main() {  
   /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
   char buffer[MAXLENGTH]; 
     bool status = true;
   gets(buffer);  
   int arrayToCheck[CHECKMAXLENGTH]={0};  
   for(int i =0;buffer[i]!='\0';i++){  
     char t;  
     t = tolower(buffer[i]);  
     int n = t;  
     if(n>0)  
     {  
       arrayToCheck[n]++;  
     }  
   }  
    for(int i = 97;i<123;i++){  
     if(arrayToCheck[i]==0){  
       status = false;  
     }  
   }  
   if(status == true)  
       {
     cout<<"pangram"<<endl; 
   }
   else  
       {
     cout<<"not pangram"<<endl;
   }
   return 0;  
 }  
