#include <cstdio>
#include <iostream>
using namespace std;

long long toh(int N, int from, int to, int aux) {
  // Your code here
  int moves = 0;
  if (N == 1) {
    cout << "move disk 1 from rod " << from << " to rod " << to << endl;
    return N;
  }
  moves += toh(N - 1, from, aux, to) + 1;
  cout << "move disk " << N << " from rod " << from << " to rod " << to << endl;
  moves += toh(N - 1, aux, to, from) + 1;
  return --moves;
}

int main() {

  int T;
  scanf("%d", &T);
  while (T--) {
    long long moves = 0;
    int N;
    scanf("%d", &N);
    moves = toh(N, 1, 3, 2);
    printf("%ld\n", moves);
  }
  return 0;
}