// Example program
#include <iostream>
#include <string>
#include <unordered_set>
#include <vector>

bool HasPairWithSum(const std::vector<int> data, int sum)
{
    std::unordered_set<int> comp;
    for (int value : data) {
        if (comp.find(value) !=comp.end())
            return true;
        comp.insert(sum - value);
    }
    return false;
}

int main()
{
  std::cout << HasPairWithSum({1, 2, 4, 4},8) << std::endl;
  system("pause");
}


