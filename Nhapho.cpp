#include"Nhapho.h"
#include<iostream>
#include<string>
using namespace std;
void Nhapho::set()
{
    cout<<"Nhap dia diem: ";
    cin>>this->Diadiem;
    cout<<"Nhap gia ban: ";
    cin>>this->Giaban;
    cout<<"Nhap dien tich xay dung: ";
    cin>>this->Dientichxaydung;
    cout<<"Nhap so tang: ";
    cin>>this->Sotang;
}
void Nhapho::get()
{
    cout<<this->Diadiem<<endl;
    cout<<this->Giaban<<endl;
    cout<<this->Dientichxaydung<<endl;
    cout<<this->Sotang<<endl;
}
Nhapho::Nhapho(string Diadiem,double Giaban, int Dientichxaydung, int Sotang)
    :Diadiem(Diadiem),Giaban(Giaban),Dientichxaydung(Dientichxaydung),Sotang(Sotang)
{}
