#include <iostream>
#include <vector> 
using namespace std;

int isPrime(int n)
{
    int counter;
    vector<int> arr;
    for(int i = 1; i <= n; i++)
    {
        counter=0;
        for(int j=1;j<=i/2;j++)
        {
            if(i % j == 0)
            {
                counter++;
            }
        }
        if(counter==2)
            arr.push_back(i); 
    }
        
    return arr.size();
}

int main()
{
    cout<<"Result => "<<isPrime(6)<<endl;
}