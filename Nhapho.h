#include<string>
using namespace std;
class Nhapho
{
    private:
    string Diadiem;
    double Giaban;
    int Dientichxaydung;
    int Sotang;
    public:
    void set();
    void get();
    Nhapho (string="",double=0,int=0,int=0);
};