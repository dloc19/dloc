  #include <iostream>
using namespace std;

struct HocPhan {
    char maHP[10];
    char tenHp[50];
    int soTc;
};

struct Node {
    HocPhan infor;
    Node* next;
};

typedef Node* TRO;

int list_size(TRO L) {
    int d = 0;
    while (L != NULL) {
        d++;
        L = L->next;
    }
    return d;
}

void nhap(HocPhan &hp) {
    cout << "Nhap ma hp: ";
    cin >> hp.maHP;
    cout << "Nhap ten hp:";
    cin >> hp.tenHp;
    cout << "Nhap so tin chi: ";
    cin.ignore();
    cin >> hp.soTc;
}

void tao(TRO& L, int n) {
    TRO P = NULL, Q = NULL;
    HocPhan hp;
    do {
        P = new Node{};
        nhap(hp);
        P->infor = hp;
        P->next = NULL;
        if (L == NULL) {
            L = P;
            Q = L;
        }
        else {
            Q->next = P;
            Q = Q->next;
        }
        n--;
    } while (n > 0);
}

void print(TRO L) {
    while (L != NULL) {
        cout << L->infor.maHP << L->infor.tenHp << L->infor.soTc << endl;
        L = L->next;
    }
}

void chen_pos3(TRO L) {
    int n = list_size(L);
    if (n <= 3) {
        cout << "Danh sach khong thoa man de chen" << endl;
        return;
    }
    // đi đến phần tử thứ 2
    L = L->next;
    TRO P = new Node{};
    HocPhan hp;
    nhap(hp);
    P->infor = hp;
    // vị trí tiếp theo của P trỏ đến vị trí thứ 3 hiện tại của L
    P->next = L->next;
    // tạo liên kết mới giữa phần tử thứ 2 và 3
    L->next = P;
}

void chen_truoc_2(TRO L) {
    TRO P = new Node{};
    HocPhan hp;
    nhap(hp);
    P->infor = hp;
    // vị trí tiếp theo của P trỏ đến vị trí thứ 3 hiện tại của L
    P->next = L->next;
    // tạo liên kết mới giữa phần tử thứ 2 và 3
    L->next = P;
}

void chen_dau(TRO& L) {
    TRO P = new Node{};
    HocPhan hp;
    nhap(hp);
    P->infor = hp;
    // vị trí tiếp theo của P trỏ đến vị trí hiện tại của L
    P->next = L;
    L = P;
}

void xoa_tc_cao_nhat(TRO& L) {
    TRO P = L;
    int max = P->infor.soTc;
    int index = 0;
    int max_i = 0;
    while (P != NULL) {
        if (P->infor.soTc > max) {
            max = P->infor.soTc;
            max_i = index;
        }
        P = P->next;
        index++;
    }
    if (max_i == 0) {
        TRO Q = L;
        L = Q->next;
        delete Q;
        return;
    }
    TRO Q = L;
    for (int i = 0; i < max_i - 1; i++) {
        Q = Q->next;
    }
    // vi tri can xoa
    TRO H = Q->next;
    Q->next = H->next;
    delete H;
}

void xoa_tc_truoc_ma_123(TRO& L) {
    TRO P = L;
    int d = 0;
    int index = -1;
    while (P != NULL) {
        if (strcmp(P->infor.maHP, "123") == 0) {
            index = d;
            break;
        }
        d++;
        P = P->next;
    }
    if (index == 0) {
        cout << "Khong co hoc phan nao truoc no de xoa" << endl;
        return;
    }
    if (index == 1) {
        TRO Q = L;
        L = Q->next;
        delete Q;
        return;
    }
    TRO Q = L;
    // di den truoc phan tu can xoa
    // vi phan tu can xoa o vi tri index - 1 nen ta di den index - 2
    for (int i = 0; i < index - 2; i++) {
        Q = Q->next;
    }
    // phan tu can xoa
    TRO H = Q->next;
    Q->next = H->next;
    delete H;
}

int main() {
    TRO L = NULL;
    tao(L, 5);
    print(L);
    chen_pos3(L);
    print(L);
    chen_truoc_2(L);
    print(L);
    xoa_tc_truoc_ma_123(L);
    print(L);
    return 0;
}