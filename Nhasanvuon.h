#include<string>
using namespace std;
class Nhasanvuon
{
    private:
    string Diadiem;
    double Giaban;
    int Dientichxaydung;
    int Dientichsanvuon;
    public:
    void set();
    void get();
    Nhasanvuon (string="",double=0,int=0,int=0);
};