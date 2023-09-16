//nested class template
#include<iostream>
using namespace std;

template<class T>class X
{
    template<class U> class Y
    {
        U* u;
        public : Y();
        U& Value();
        void print();
        ~Y();
    };
    Y<int> y;
    public : x(T t)
    {
        y.Value() = t;
    }
    void print()
    {
        y.print();
    }
};

template<class T> 
template<class U>
X<T>::Y<U>::Y()
{
    cout<<"X<T>::Y<U>::Y()"<<endl;
    U = new U();
}
template<class T>
template<class U>
U& X<T>::Y<U>::Value()
{
    return* u;
}   
template<class T>
template<class U>void 
X<T>::Y<U>::print()
{
    cout<<this->Value()<<endl;
}
template<class T>
template<class U> 
X<T>::Y<U>::~Y()
{
    cout<<"X<T>::Y<U>::~Y()"<<endl;
    delete u;
}
int main()
{
    X<int>*xi=new X<int>(10);
    X<int>*xc=new X<char>('c');
    xi->print();
    xc->print();
    delete xi;
    delete xc;
    return 0;
}
