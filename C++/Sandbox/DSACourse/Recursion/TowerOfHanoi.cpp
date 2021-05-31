#include <iostream>
using namespace std;

void toh(int N, int from, int to, int aux) {
  // Your code here
  if (N == 1) {
    cout << "move disk 1 from rod " << from << " to rod " << to << endl;
    return;
  }
  toh(N - 1, from, aux, to);
  cout << "move disk " << N << " from rod " << from << " to rod " << to << endl;
  toh(N - 1, aux, to, from);
}

int main() {
  toh(3, 1, 3, 2);
  return 0;
}