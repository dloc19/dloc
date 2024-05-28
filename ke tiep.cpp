#include <iostream>
using namespace std;

#define MAX 100

struct Sach {
    char maSach[10];
    char tenSach[100];
    char tenTG[100];
    int namXB;
};

struct List {
    Sach data[MAX];
    int count = 0;
};

void xoa_cuon_thu_4(List &L) {
    // day phan tu ve ben trai
    for (int i = L.count - 1; i > 3; i--) {
        L.data[i - 1] = L.data[i];
    }
    // giam do dai danh sach
    L.count--;
}

void nhap(Sach& s) {
    cout << "Nhap ma sach: ";
    cin >> s.maSach;
    cout << "Nhap ten sach: ";
    cin >> s.tenSach;
    cout << "Nhap ten tac gia: ";
    cin >> s.tenTG;
    cout << "Nhap nam xuat ban: ";
    cin >> s.namXB;
    cin.ignore();
}

void chen_vi_tri_thu_3(List &L) {
    if (L.count <= 3) {
        cout << "Danh sach khong du sach de chen" << endl;
        return;
    }
    Sach s;
    nhap(s);
    for (int i = L.count - 1; i >= 2; i--) {
        L.data[i + 1] = L.data[i];
    }
    L.data[2] = s;
    L.count++;
}

void in(List L) {
    for (int i = 0; i < L.count; i++) {
        cout << L.data[i].maSach << L.data[i].tenSach << L.data[i].tenTG << L.data[i].namXB << endl;
    }
}

void init(List &L, int n) {
    Sach s;
    for (int i = 0; i < n; i++) {
        nhap(s);
        L.data[i] = s;
    }
    L.count = n;
}

int main() {
    List L;
    init(L, 5);
    xoa_cuon_thu_4(L);
    in(L);
    chen_vi_tri_thu_3(L);
    in(L);
    return 0;
}
