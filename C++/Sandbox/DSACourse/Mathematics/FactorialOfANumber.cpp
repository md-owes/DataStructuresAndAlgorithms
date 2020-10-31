#include <iostream>
using namespace std;

long long factorial(int N) {
    // Your code here
    long long result=1;
    for(int i=N;i>0;i--){
        result=result*i;
    }
    return result;
}

int main()
{
    cout<<"Result => "<<factorial(10)<<endl;
}