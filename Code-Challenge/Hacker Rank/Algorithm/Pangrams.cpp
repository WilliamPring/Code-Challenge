#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <stdio.h>

using namespace std;
 int main() {  
   /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
   char arr[10000]; 
     bool status = true;
   gets(arr);  
   int a[150]={0};  
   for(int i =0;arr[i]!='\0';i++){  
     char t;  
     t = tolower(arr[i]);  
     int n = t;  
     if(n>0)  
     {  
       a[n]++;  
     }  
   }  
    for(int i = 97;i<123;i++){  
     if(a[i]==0){  
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