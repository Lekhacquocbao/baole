#include"Khudat.h"
#include<iostream>
#include<string>
using namespace std;
void Khudat::set()
{
    cout<<"Nhap dia diem: ";
    cin>>this->Diadiem;
    cout<<"Nhap gia ban: ";
    cin>>this->Giaban;
    cout<<"Nhap dien tich: ";
    cin>>this->Dientich;
}
void Khudat::get()
{
    cout<<this->Diadiem<<endl;
    cout<<this->Giaban<<endl;
    cout<<this->Dientich<<endl;
}
Khudat::Khudat(string Diadiem,double Giaban, int Dientich)
    :Diadiem(Diadiem),Giaban(Giaban),Dientich(Dientich)
{}
