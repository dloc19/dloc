void xoa_pos_3(TRO L) {
    // di chuyen len vi tri thu 2
    L = L->next;
    // vi tri can xoa
    TRO Q = L->next;
    // tao lien ket moi
    L->next = Q->next;
    // xoa con tro Q
    delete Q;
}

// c.Đưa ra thông tin của những sinh viên thi khối A1.
void in_tt_khoi_a1(TRO L) {
    int d = 0;
    while (L != NULL) {
        // so sanh neu khoi thi la A1
        // strcmp = 0 neu 2 mang char co ket qua la trung nhau
        if (strcmp(L->infor.khoiThi, "A1") == 0){
            cout << L->infor.soBaoDanh << L->infor.hoTen << L->infor.namSinh << L->infor.khoiThi << L->infor.tongDiem << endl;
        }
        L = L->next;
        d++;
    }
    if (d == 0) {
        cout << "Khong co sinh vien nao khoi A1" << endl;
    }
}

// d.Đưa ra thông tin của những thí sinh có điểm cao nhất (thấp nhất).

void dua_tt_diem_max(TRO L) {
    int max = L->infor.tongDiem;
    TRO P = L;
    // tim diem lon nhat
    while (P != NULL) {
        if (P->infor.tongDiem > max) {
            max = P->infor.tongDiem;
        }
        P = P->next;
    }
    // bat dau in
    while (L != NULL) {
        // tmdk thi in
        if (L->infor.tongDiem == max) {
            cout << L->infor.soBaoDanh << L->infor.hoTen << L->infor.namSinh << L->infor.khoiThi << L->infor.tongDiem << endl;
        }
    }
}

// e.Chèn một thí sinh vào trước (sau) thí sinh có điểm cao nhất (thấp nhất).
void chen_sau_diem_cao_nhat(TRO L) {
    int max = L->infor.tongDiem;
    TRO P = L;
    // tim diem lon nhat
    while (P != NULL) {
        if (P->infor.tongDiem > max) {
            max = P->infor.tongDiem;
        }
        P = P->next;
    }
    TRO i = NULL;
    // di den vi tri thi sinh co tong diem cao nhat
    for (i = L; i != NULL; i = i->next) {
        if (i->infor.tongDiem == max) {
            break;
        }
    }
    ThiSinh ts;
    nhap(ts);
    TRO P = new Node{};
    P->infor = ts;
    // tao lien ket
    P->next = i->next;
    // chen 
    i->next = P;
}

// f.Chèn một thí sinh sau thí sinh cuối cùng trong danh sách.
void chen_cuoi_ds(TRO L) {
    while (L != NULL) {
        if (L->next == NULL) {
            break;
        }
        L = L->next;
    }
    TRO P = new Node{};
    ThiSinh ts;
    nhap(ts);
    P->infor = ts;
    P->next = NULL;
    L->next = P;
}
