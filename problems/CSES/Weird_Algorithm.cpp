#include<bits/stdc++.h>
using namespace std;

#define ll long long

int main() 
{
    ll n;
    cin >> n;

    while (n != 1) 
    {
        cout << n << " ";
        n = (n % 2 == 0 ? n/2 : n*3+1);
    }
    cout << n;

}