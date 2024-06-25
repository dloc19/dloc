import numpy as np
import matplotlib.pyplot as mp

def nhap_mang(n):
    a = []
    for i in range(n):
        k = int(input("a[{}] = ".format(i)))
        a.append(k)
    return np.array(a)

def ghi_file(a_sorted):
    with open("dloc.txt", "w") as file:
        file.write("dong 1:" + a_sorted[:2] + "\n")
        file.write("dong 2:" + a_sorted[2:])
    print("đã ghi vào tệp dloc.txt")

def to2D(a, n):
    try:
        t = int(input("nhap so dong cua ma tran = "))
        if n % t != 0: raise ValueError
        k = a.reshape(t, n//t)
        return k
    except:
        print(ValueError, "không thể reshape")
        return

#nhap mang 2 chieu nxm
def in_mang_2_chieu_2(n,m):
    a = np.zeros((n,m))
    for i in range(n):
        for j in range(m):
            a[i][j] = int(input("a[{}][{}] = ".format(i,j)))
    return np.array(a)

def in_mang_2_chieu_1(n,m):
    a = []
    for i in range(n):
        k = [0]*m
        for j in range(m):
            k[j] = int(input("k[{}][{}]".format(i,j)))
        a.append(k)
    return np.array(a)

n = int(input("nhap so luong phan tu cua mang = "))
m = int(input("nhap m = "))
c = in_mang_2_chieu_1(n,m)
print(c)
a = nhap_mang(n)
print(a)

#tim vị trí và giá trị không duyệt mảng
vi_tri = np.array(np.where(a%2!= 0) and np.where(a%3==0))
gia_tri = np.array(a[vi_tri])

#tính tổng các số đã tìm
tong = np.sum(gia_tri)

#sắp xếp giảm kiểu headsorrt
a_sorted_giam = np.sort(a, kind = "headsort")[::-1]
print("mang sau khi sap xep giam: ", a_sorted_giam)

#sắp xếp tăng kiểu mặc định quicksort
a_sorted_tang = np.sort(a)
print("tong = ", tong)

#chèn k vào vị trí cho trước
k = int(input("nhap k = "))
vt = int(input("nhap vị trí cần chèn vt = "))
a_inserted = np.insert(a, vt, k)
print("mang sau khi chèn: ", a_inserted)

#xoa ở vị trí
p = int(input("nhap vi tri can xoa p = "))
if p<len(a):
    a_removed = np.delete(a, p)
    print(a_removed)

#xoa theo gia tri
l = int(input("nhap gia tri can xoa: "))
a_removedd = a[a!=l]
print(a_removedd)

#chuyển thành mảng 2 chiều
b = to2D(a, n)
print("mang sau khi chuyen: ", b)

#nhap mang 2 chieu nxm


y = np.array([44,67,99,80,120])
mp.title("BIỂU ĐỒ DLOC")
mylabels= {"Cam", "Chanh", " Xoài", "Bưởi", "Mít"}
wp = {"linewidth" : 1, "edgecolor":"black"}
myexplode = [0.1 , 0.1, 0, 0, 0.1]
mp.pie(y, autopct = "%.2f", labels = mylabels, explode = myexplode, wedgeprops = wp ,shadow = True)
mp.show()

#########################################################################################################
def nhap_tu_dien(n):
    tu_dien_hoc_phan = {}
    for i in range(n):
        hoc_phan = input("nhap hoc phan: ")
        hoc_phi = int(input("nhap hoc phi: "))
        tu_dien_hoc_phan[hoc_phan] = hoc_phi
    return tu_dien_hoc_phan

def kiem_tra(tu_dien_hoc_phan):
    if "IT6073" not in tu_dien_hoc_phan:
        tu_dien_hoc_phan["IT6073"] = 500
    else:
        print("co hoc phan IT6073 in tu dien")

def in_tu_dien(tu_dien_hoc_phan):
    for key, value in tu_dien_hoc_phan.items():
        print(key, "-", value)
def tong_hoc_phi(tu_dien_hoc_phan):
        hoc_phi_1 = tu_dien_hoc_phan.get("IT6013", 0)
        hoc_phi_2 = tu_dien_hoc_phan.get("IT6073", 0)
        hoc_phi = hoc_phi_1 + hoc_phi_2
        return hoc_phi

n = int(input("nhap so luong item: "))
tu_dien_hoc_phan = nhap_tu_dien(n)
kiem_tra(tu_dien_hoc_phan)
hoc_phi = tong_hoc_phi(tu_dien_hoc_phan)
print(hoc_phi)


###################################################################################################

def nhap_ma_hang():
    tu_dien_hang = {}
    n = int(input("nhap so luong item trong tu dien: "))
    for i in range(n):
        ma_hang = input("nhap ma hang: ")
        so_luong = int(input("nhap so luong"))
        tu_dien_hang[ma_hang] = so_luong
    return tu_dien_hang

def  nhap_nha_cung_cap():
    tu_dien_nha_cung_cap = {}
    m = int(input("nhap so luong nha cung cap: "))
    for i in range(m):
        ma_nha_cung_cap = input("nhap ma nha cung cap")
        ten_nha_cung_cap = input("nhap ten nha cung cap")
        tu_dien_nha_cung_cap[ma_nha_cung_cap] = ten_nha_cung_cap
    return tu_dien_nha_cung_cap


def in_tu_dien(tu_dien):
    for key, value in tu_dien.items():
        print(key, "-", value)


def kiem_tra(tu_dien_hang):
    if "H001" in tu_dien_hang:
        tu_dien_hang["H001"] = 200
    else:
        so_luong = int(input("nhap so luong cho ma hang H001: "))
        tu_dien_hang["H001"] = so_luong

def xoa_muc_khong_co(tu_dien_hang):
    muc_hang_can_xoa = [key for key, value in tu_dien_hang.items() if value == 0]
    for key in muc_hang_can_xoa:
        del tu_dien_hang[key]


def chuyen_du_lieu(tu_dien):
    list_ma_hang = []
    list_so_luong = []
    for key, value in tu_dien.items():
        list_ma_hang.append(key)
        list_so_luong.append(value)
    return list_ma_hang, list_so_luong

tu_dien_hang = nhap_ma_hang()
print("tu dien nha cung cap")

tu_dien_nha_cung_cap = nhap_nha_cung_cap()

in_tu_dien(tu_dien_nha_cung_cap)

kiem_tra(tu_dien_hang)

xoa_muc_khong_co(tu_dien_hang)


list_ma_hang, list_so_luong = chuyen_du_lieu(tu_dien_hang)
print("ba phan tu dau cua list thu nhat:", list_ma_hang[:3])
print("ba phan tu cuoi cua list thu hai:",list_so_luong[-3:])









