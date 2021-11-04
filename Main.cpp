#include<iostream>
#include<fstream>
#include<string>
#include"Khudat.h"
#include"Nhasanvuon.h"
#include"Nhapho.h"
using namespace std;
int console(){
    float choose;
    do{
        system("cls");
        cout<<"\n=========== CONG TY BAO MINH HUNG ===========\n";
        cout<<"|             1. Khu dat                    |\n";
        cout<<"|             2. Nha san vuon               |\n";
        cout<<"|             3. Nha pho                    |\n";
        cout<<"=============================================\n";
        cout<<"Choose your option: ";
        fflush(stdin);
        cin>>choose;

		if (!((choose == (int)choose) && (choose <= 3 && choose >= 1)))
        {
			system("cls");
			printf("\nFailed! Please choose again!\n");
		}
        else
        {
            if(choose==1)
        {
        cout<<"\n=========== CONG TY BAO MINH HUNG ===========\n";
        cout<<"|             1. Dia diem khu dat           |\n";
        cout<<"|             2. Gia ban khu dat            |\n";
        cout<<"|             3. Dien tich khu dat          |\n";
        cout<<"=============================================\n";
        cout<<"Choose your option: ";
        int choose;
        cin>>choose;
        if(choose<1&&choose>3)
        {
            cout<<"\nFailed! Please choose again!\n";
        }     
        else
        {
            switch (choose)
            {
            case 1:
                cout<<"Dia diem khu dat la: ";
                break;
            case 2:
                cout<<"Gia ban khu dat la: ";
                break;
            case 3:
                cout<<"Dien tich khu dat la: ";
                break;
            default: 
                cout<<"\nFailed! Please choose again!\n";
                break;
            }
        }
        }
        else if(choose==2)
        {
        cout<<"\n=========== CONG TY BAO MINH HUNG ===========\n";
        cout<<"|             1. Dia diem                   |\n";
        cout<<"|             2. Gia ban                    |\n";
        cout<<"|             3. Dien tich xay dung         |\n";
        cout<<"|             4. Dien tich san vuon         |\n";
        cout<<"=============================================\n";
        cout<<"Choose your option: ";
        int choose;
        cin>>choose;
        if(choose<1&&choose>4)
        {
            cout<<"\nFailed! Please choose again!\n";
        }     
        else
        {
            switch (choose)
            {
            case 1:
                cout<<"Dia diem la: ";
                break;
            case 2:
                cout<<"Gia ban la: ";
                break;
            case 3:
                cout<<"Dien tich xay dung la: ";
                break;
            case 4:
                cout<<"Dien tich san vuon la: ";
                break;
            default: 
                cout<<"\nFailed! Please choose again!\n";
                break;
            }
        }
        }
        else if(choose==3)
        {
        cout<<"\n=========== CONG TY BAO MINH HUNG ===========\n";
        cout<<"|             1. Dia diem                   |\n";
        cout<<"|             2. Gia ban                    |\n";
        cout<<"|             3. Dien tich xay dung         |\n";
        cout<<"|             4. So tang                    |\n";
        cout<<"=============================================\n";
        cout<<"Choose your option: ";
        int choose;
        cin>>choose;
        if(choose<1&&choose>4)
        {
            cout<<"\nFailed! Please choose again!\n";
        }     
        else
        {
            switch (choose)
            {
            case 1:
                cout<<"Dia diem la: ";
                break;
            case 2:
                cout<<"Gia ban la: ";
                break;
            case 3:
                cout<<"Dien tich xay dung la: ";
                break;
            case 4:
                cout<<"So tang la: ";
                break;
            default: 
                cout<<"\nFailed! Please choose again!\n";
                break;
            }
        }
        }
        else
        {
            cout<<"\nFailed! Please choose again!\n";
        }
        }
		
    }
    while (!((choose == (int)choose) && (choose <= 3 && choose >= 1)));
    return choose;
}

    void DiaDiemKhuDat(fstream dataKhuDat){
    string data;
    string line;
    while(!dataKhuDat.eof()){
        getline(dataKhuDat,line);
        data+=line;
    }
    cout<<data;
}
int main(){
    fstream dataKhuDat;
    dataKhuDat.open("khudat.txt",ios_base::out);
    Khudat a[100];
    int choose=console();
   
}
