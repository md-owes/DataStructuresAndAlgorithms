#include <iostream>
#include <cmath>
using namespace std;

double termOfGP(int A,int B,int N)
{
    //Your code here
    double result = 0;

    float r = (float)B/A;
    for(int i=0;i<N;i++)
    {
        result=ceil(A*(pow(r, i)));
    }
    return result;
}

int main()
{
    cout<<"Result => "<<termOfGP(73,37,2)<<endl;
}