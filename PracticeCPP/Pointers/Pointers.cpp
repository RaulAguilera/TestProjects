#include <iostream>

int main()
{
    int x{1};
    int *pointer_to_x{&x};
    int y{*pointer_to_x};
    y = 3;

    *pointer_to_x = 4;

    int *p{&x};
    p = &y;

    int j{*p};

    p = nullptr;

    try
    {
        int *p2{new int{1}}; //The heap or free store
        *p2 = 2;
        throw std::runtime_error("My error");
        delete p; //if we don't delete it it'll stay there until the program finishes
                  //NEVER use delete there's a better way ;)
    }
    catch (const std::exception &e)
    {
        std::cout << " Exception caught " << e.what();
    }

    std::cin.get();

    return 0;
}