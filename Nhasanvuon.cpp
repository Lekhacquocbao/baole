#include"Nhasanvuon.h"
#include<iostream>
#include<string>
using namespace std;
void Nhasanvuon::set()
{
    cout<<"Nhap dia diem: ";
    cin>>this->Diadiem;
    cout<<"Nhap gia ban: ";
    cin>>this->Giaban;
    cout<<"Nhap dien tich xay dung: ";
    cin>>this->Dientichxaydung;
    cout<<"Nhap dien tich san vuon: ";
    cin>>this->Dientichsanvuon;
}
void Nhasanvuon::get()
{
    cout<<this->Diadiem<<endl;
    cout<<this->Giaban<<endl;
    cout<<this->Dientichxaydung<<endl;
    cout<<this->Dientichsanvuon<<endl;
}
Nhasanvuon::Nhasanvuon(string Diadiem,double Giaban, int Dientichxaydung, int Dientichsanvuon)
    :Diadiem(Diadiem),Giaban(Giaban),Dientichxaydung(Dientichxaydung),Dientichsanvuon(Dientichsanvuon)
{}
