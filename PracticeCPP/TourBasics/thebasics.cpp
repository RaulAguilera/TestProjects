#include <iostream>

double square(double x)
{
    return x * x;
}

void print_square(double x)
{
    std::cout << "the square of " << x << " is " << square(x) << "\n";
}

int main()
{
    double x{1.234};
    auto y{5.555}; //auto is like var in c#

    print_square(x);
    print_square(y);
    std::cout << sizeof(int) << "\n";
    std::cout << sizeof(char) << "\n";

    char v[6];
    
    v[3] = 'a';
    
    char *p = &v[3]; //p points to v's fourth element
    int w = *p; //read the value of what p points to


    std::cout << "*p " << *p << "\n";
    std::cout << "p " << p << "\n";

    std::cin.get();
}