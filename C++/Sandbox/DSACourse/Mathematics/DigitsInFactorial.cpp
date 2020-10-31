#include <iostream>
#include <bits/stdc++.h>
using namespace std;

#define MAX 40000 

// Driver code 
int digitsCount(int n) 
{ 
    if (n > MAX) { 
        cout << " Integer Overflow" << endl; 
        return 0; 
    } 
  
    long long counter; 
    long double sum = 0; 
  
    // Base case 
    if (n == 0) 
        return 1; 
  
    // Calculate the sum of 
    // logarithmic values 
  
    for (counter = n; counter > 0; counter--) { 
        sum = sum + log10(counter); 
    } 
  
    // Number becomes too big to hold in 
    // unsigned long integers. 
    // Hence converted to string 
    // Answer is sometimes under 
    // estimated due to floating point 
    // operations so round() is used 
    int result = floor(sum)+1; 
  
    return result; 
} 

int factorialDigits(int N)
{
    return digitsCount(N);
}

int main()
{
    cout<<"Size of factorial digits is => "<<factorialDigits(19)<<endl;
}